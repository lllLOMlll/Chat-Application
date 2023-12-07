Public Class MainLogin


    'LOAD LOGIN SCREEN
    Private Sub MainLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New DbManager
        ' Test connection (uncomment if you need to test the connection)
        'db.TestConnection()
    End Sub

    'REGISTRATION (Button)
    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        Dim register As New Register() ' Create a new instance of Easy        
        register.Show()
        Me.Hide()
    End Sub

    'LOGIN (Button)
    'LOGIN (Button)
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim inputUsername As String = TextBox_Username.Text
        Dim inputPassword As String = TextBox_Password.Text

        Dim dbManager As New DbManager()
        Dim loginResult As Integer = dbManager.CheckCredentials(inputUsername, inputPassword)

        Select Case loginResult
            Case 0 ' Successful login
                Globals.IsUserLoggedIn = True
                Globals.Username = inputUsername
                Dim chat As New Chat()
                chat.Show()
                Me.Hide()

            Case -1 ' Invalid username or password
                MsgBox("Invalid username or password.", MsgBoxStyle.Critical, "Login Failed")

            Case -2 ' Inactive account
                MsgBox("Your account is inactive. Please contact the admin.", MsgBoxStyle.Critical, "Login Failed")

        End Select
    End Sub


    'MENU
    ' FILE
    ' Create a Profile
    Private Sub CreateAProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAProfileToolStripMenuItem.Click
        Dim loginStatus As Boolean = Globals.IsUserLoggedIn
        If loginStatus = False Then
            MsgBox("You need to be logged to create your profile", MsgBoxStyle.Critical, "Error")
        ElseIf loginStatus = True Then
            MsgBox("Good, you are logged. You can now create your profile.", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    'Login/Logout
    Private Sub LoginLogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginLogoutToolStripMenuItem.Click
        MsgBox("You are not logged in! Please log in.", MsgBoxStyle.Information, "Login")
    End Sub

    ' Edit profile
    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        Dim loginStatus As Boolean = Globals.IsUserLoggedIn
        If loginStatus = False Then
            MsgBox("You need to be logged to edit your profile", MsgBoxStyle.Critical, "Error")
        ElseIf loginStatus = True Then
            MsgBox("Good, you are logged. You can now edit your profile.", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    ' Delete profile
    Private Sub DeleteProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProfileToolStripMenuItem.Click
        Dim loginStatus As Boolean = Globals.IsUserLoggedIn
        If loginStatus = False Then
            MsgBox("You need to be logged to delete your profile", MsgBoxStyle.Critical, "Error")
        ElseIf loginStatus = True Then
            MsgBox("Good, you are logged. You can now delete your profile.", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    ' About
    Private Sub AboutTheProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTheProgramToolStripMenuItem.Click
        MsgBox("This is Open Registration" & vbCr & vbCr &
               "A program to chat with friends. Dont be shy and fight solitude. Text. It's fun and free." & vbCr & vbCr &
               "VERSION 32.2.5.7" & vbCr &
               "-Stable version" & vbCr &
               "-Almost no bugs :)" & vbCr & vbCr &
               "Thank for using a Major Software", MsgBoxStyle.Information, "About")
    End Sub


End Class
