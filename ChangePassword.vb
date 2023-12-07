Public Class ChangePassword
    Private Sub Button_Change_Password_Click(sender As Object, e As EventArgs) Handles Button_Change_Password.Click
        Dim oldPassword As String = TextBox_Old_Password.Text
        Dim newPassword As String = TextBox_New_Password.Text
        Dim confirmNewPassword As String = TextBox_Confirm_New_Password.Text

        ' Check if new password and confirm password match
        If newPassword <> confirmNewPassword Then
            MsgBox("The new password and confirmation password do not match.", MsgBoxStyle.Critical, "Password Mismatch")
            Return
        End If

        ' Check if the old password is correct
        Dim dbManager As New DbManager()
        If Not dbManager.CheckOldPassword(Globals.Username, oldPassword) Then
            MsgBox("The old password is incorrect.", MsgBoxStyle.Critical, "Invalid Password")
            Return
        End If

        ' Update the password in the database
        dbManager.UpdatePassword(Globals.Username, newPassword)
        MsgBox("Your password has been successfully changed" & vbCr & "You'll need to log again with your new password", MsgBoxStyle.Information, "Password Changed")

        'Logout the user
        Globals.IsUserLoggedIn = False
        Globals.Username = ""

        'Redirect the user to the login screen
        Dim homeScreen As New MainLogin
        homeScreen.Show()
        Me.Hide()
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class