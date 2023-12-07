Imports System.Security.Cryptography.X509Certificates
Imports Open_Registration.DbManager

Public Class Register
    Public isFormvalid As Boolean = True
    Public avatarPath As String
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton_Dummy.Checked = True
    End Sub

    Private Sub Button_Back_To_Login_Click(sender As Object, e As EventArgs) Handles Button_Back_To_Login.Click
        Dim loginScreen As New MainLogin
        loginScreen.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        Dim dbManager As New DbManager()
        'Gathering data for creating new User

        Dim username As String
        username = TextBox_Username.Text
        Dim password As String
        password = TextBox_Password.Text
        Dim confirmPassword As String
        confirmPassword = TextBox_Confirm_Password.Text
        Dim hashedPassword As String = PasswordHasher.HashPassword(password)


        ' Validate username
        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isFormvalid = False
            Return
        ElseIf username.Length > 20 Then
            MessageBox.Show("Username must 20 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isFormvalid = False
            Return
        End If

        ' Check if the username is already taken
        If dbManager.IsUsernameTaken(username) Then
            MsgBox("This username is already taken. Please choose another one.", MsgBoxStyle.Critical, "Username Taken")
            Return
        End If

        ' Validate password
        If String.IsNullOrEmpty(password) Then
            MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isFormvalid = False
            Return
        ElseIf password.Length > 20 Then
            MessageBox.Show("Password must 20 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isFormvalid = False
            Return
        End If

        ' Confirm password
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isFormvalid = False
            Return
        End If

        ' Avatar
        If RadioButton_Dummy.Checked = True Then
            MessageBox.Show("You must choose an avatar.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isFormvalid = False
            Return
        End If

        If RadioButton_Blue_Woman.Checked = True Then
            avatarPath = "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\blue_woman.jpg"
        ElseIf RadioButton_Yellow_Ladie.Checked = True Then
            avatarPath = "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\aisan_yellow_ladie.jpg"
        ElseIf RadioButton_Green_Man_Glasses.Checked = True Then
            avatarPath = "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\green_man_glass.jpg"
        ElseIf RadioButton_Orange_Mustache.Checked = True Then
            avatarPath = "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\orange_mustache_man.jpg"
        ElseIf RadioButton_Prink_Something.Checked = True Then
            avatarPath = "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\pink_something.jpg"
        End If



        isFormvalid = True
        ' Add user if there is not error in the validation
        If isFormvalid = True Then
            'Creating new user
            Dim newUser As New User(username, hashedPassword, avatarPath) With {
                .Username = username,
                .Password = hashedPassword,
                .Avatar = avatarPath
            }

            'Addint the new user to the database
            dbManager.AddUser(newUser)

            MsgBox($"{username} was added to the database!", MsgBoxStyle.Exclamation, "Success")

            'Redirect to the login screen!
            Dim loginScreen As New MainLogin
            loginScreen.Show()
            Me.Hide()
        End If

    End Sub


End Class