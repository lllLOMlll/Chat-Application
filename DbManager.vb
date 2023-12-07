
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class DbManager
    Private Property connectionString = "server=localhost;user id=root;password=;database=vp2_final_project
" 'add the name of the database afther the database=
    Private Property connect As MySqlConnection

    'Constructor
    Public Sub New()
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Sub TestConnection()
        If Me.connect.State = ConnectionState.Open Then
            MsgBox("I am open")
        Else
            MsgBox("Not open")
        End If
    End Sub

    Public Sub AddUser(user As User)
        Dim query As String = "INSERT INTO users (username, password, avatar) VALUES (@username, @password, @avatar)"

        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", user.Username)
            cmd.Parameters.AddWithValue("@password", user.Password) ' Consider hashing the password
            cmd.Parameters.AddWithValue("@avatar", user.Avatar)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Insert Failed")
            End Try
        End Using
    End Sub

    'Creating a class to hashed to passwords
    Public Class PasswordHasher
        Public Shared Function HashPassword(password As String) As String
            Using sha256 As SHA256 = SHA256.Create()
                Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
                Dim hash As Byte() = sha256.ComputeHash(bytes)

                Dim stringBuilder As New StringBuilder()
                For Each b In hash
                    stringBuilder.Append(b.ToString("x2"))
                Next

                Return stringBuilder.ToString()
            End Using
        End Function
    End Class

    Public Sub UpdateUserDetails(user As User)
        Dim query As String = "UPDATE users SET first_name = @firstName, last_name = @lastName, dob = @dob, address = @address, telephone = @telephone, school = @school, program = @program, avatar = @avatar WHERE username = @username"

        Using cmd As New MySqlCommand(query, Me.connect)
            ' Bind parameters
            cmd.Parameters.AddWithValue("@username", user.Username)
            cmd.Parameters.AddWithValue("@firstName", user.FirstName)
            cmd.Parameters.AddWithValue("@lastName", user.LastName)
            cmd.Parameters.AddWithValue("@dob", If(user.DateOfBirth.HasValue, user.DateOfBirth.Value, DBNull.Value))
            cmd.Parameters.AddWithValue("@address", user.Address)
            cmd.Parameters.AddWithValue("@telephone", user.Telephone)
            cmd.Parameters.AddWithValue("@school", user.School)
            cmd.Parameters.AddWithValue("@program", user.Program)
            cmd.Parameters.AddWithValue("@avatar", user.Avatar)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update Failed")
            End Try
        End Using
    End Sub


    Public Function CheckCredentials(username As String, password As String) As Integer
        ' Define the SQL query to check user credentials and status
        Dim query As String = "SELECT password, status FROM users WHERE username = @username"
        Dim dbPassword As String = String.Empty
        Dim userStatus As String = String.Empty

        ' Execute the query using the provided username
        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)
            Try
                ' Retrieve the password and status from the database
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        dbPassword = reader("password").ToString()
                        userStatus = reader("status").ToString()
                    End If
                End Using
            Catch ex As Exception
                ' Handle any exceptions during the query
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Query Failed")
                Return -1 ' Return -1 to indicate a query failure
            End Try
        End Using

        ' Check if the user's account is inactive
        If userStatus = "inactive" Then
            Return -2 ' Return -2 to indicate an inactive account
        End If

        ' Hash the input password
        Dim hashedInputPassword As String = PasswordHasher.HashPassword(password)

        ' Compare the hashed input password with the hashed password from the database
        If dbPassword.Equals(hashedInputPassword) Then
            Return 0 ' Return 0 to indicate a successful login
        Else
            Return -1 ' Return -1 to indicate invalid credentials
        End If
    End Function



    Public Function GetUserDetails(username As String) As User
        Dim query As String = "SELECT username, avatar FROM users WHERE username = @username"
        Dim userDetails As User = Nothing

        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)
            Try
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        userDetails = New User() With {
                        .Username = reader("username").ToString(),
                        .Avatar = reader("avatar").ToString()
                    }
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Query Failed")
            End Try
        End Using

        Return userDetails
    End Function


    Public Function GetAllUserDetails(username As String) As User
        ' Update the query with the correct column name 'dob' instead of 'date_of_birth'
        Dim query As String = "SELECT username, first_name, last_name, dob, address, telephone, school, program, avatar FROM users WHERE username = @username"
        Dim userDetails As User = Nothing

        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)
            Try
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        userDetails = New User() With {
                        .Username = reader("username").ToString(),
                        .FirstName = If(IsDBNull(reader("first_name")), String.Empty, reader("first_name").ToString()),
                        .LastName = If(IsDBNull(reader("last_name")), String.Empty, reader("last_name").ToString()),
                         .DateOfBirth = If(IsDBNull(reader("dob")), Nothing, Convert.ToDateTime(reader("dob"))),
                        .Address = If(IsDBNull(reader("address")), String.Empty, reader("address").ToString()),
                        .Telephone = If(IsDBNull(reader("telephone")), String.Empty, reader("telephone").ToString()),
                        .School = If(IsDBNull(reader("school")), String.Empty, reader("school").ToString()),
                        .Program = If(IsDBNull(reader("program")), String.Empty, reader("program").ToString()),
                        .Avatar = If(IsDBNull(reader("avatar")), String.Empty, reader("avatar").ToString())
                    }
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Query Failed")
            End Try
        End Using

        Return userDetails
    End Function


    Public Function IsUsernameTaken(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username"
        Dim count As Integer = 0

        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)
            Try
                count = Convert.ToInt32(cmd.ExecuteScalar())
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Query Failed")
                Return False ' Consider returning False or throwing an exception
            End Try
        End Using

        Return count > 0
    End Function


    Public Function GetUserIdByUsername(username As String) As Integer
        Dim query As String = "SELECT user_id FROM users WHERE username = @username"
        Dim userId As Integer = 0  ' Default to 0, indicating no user found

        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)
            Try
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        userId = Convert.ToInt32(reader("user_id"))
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Query Failed")
            End Try
        End Using

        Return userId
    End Function


    Public Sub SetUserStatusInactive(username As String)
        Dim query As String = "UPDATE users SET status = 'inactive' WHERE username = @username"

        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update Failed")
            End Try
        End Using
    End Sub


    Public Function CheckOldPassword(username As String, oldPassword As String) As Boolean
        Dim query As String = "SELECT password FROM users WHERE username = @username"
        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)

            Try
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim storedPassword As String = reader("password").ToString()
                        ' Assuming you are hashing passwords and need to compare the hashed old password with the stored hashed password
                        Return PasswordHasher.HashPassword(oldPassword) = storedPassword
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Query Failed")
                Return False
            End Try
        End Using

        ' If the username is not found or any other issue, return False
        Return False
    End Function


    Public Sub UpdatePassword(username As String, newPassword As String)
        Dim query As String = "UPDATE users SET password = @password WHERE username = @username"
        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", PasswordHasher.HashPassword(newPassword)) ' Assuming you are hashing passwords

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Update Failed")
            End Try
        End Using
    End Sub

    Public Sub AddPost(post As Post)
        Dim query As String = "INSERT INTO posts (user_id, post, time_published) VALUES (@userId, @content, @timePublished)"

        Using cmd As New MySqlCommand(query, Me.connect)
            cmd.Parameters.AddWithValue("@userId", post.UserId)
            cmd.Parameters.AddWithValue("@content", post.Content)
            cmd.Parameters.AddWithValue("@timePublished", post.TimePublished)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Insert Failed")
            End Try
        End Using
    End Sub

    Public Function GetPosts() As DataTable
        Dim query As String = "SELECT u.username, p.post, p.time_published, u.avatar FROM posts p JOIN users u ON p.user_id = u.user_id ORDER BY p.time_published DESC"
        Dim dataTable As New DataTable()

        Using cmd As New MySqlCommand(query, Me.connect)
            Try
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Query Failed")
            End Try
        End Using

        Return dataTable
    End Function



End Class
