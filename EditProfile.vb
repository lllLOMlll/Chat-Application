Imports System.Runtime
Imports System.Text.RegularExpressions

Public Class EditProfile
    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Assume Globals.Username contains the logged-in username
        Dim dbManager As New DbManager()
        Dim userDetails As User = dbManager.GetAllUserDetails(Globals.Username)

        ' Populate the text boxes only if the user details are available
        If userDetails IsNot Nothing Then
            TextBox_First_Name.Text = If(userDetails.FirstName, "")
            TextBox_Last_Name.Text = If(userDetails.LastName, "")
            TextBox_DOB.Text = If(userDetails.DateOfBirth.HasValue AndAlso userDetails.DateOfBirth.Value > DateTime.MinValue, userDetails.DateOfBirth.Value.ToShortDateString(), "")
            TextBox_Address.Text = If(userDetails.Address, "")
            TextBox_Telephone.Text = If(userDetails.Telephone, "")
            TextBox_School.Text = If(userDetails.School, "")
            TextBox_Program.Text = If(userDetails.Program, "")
            ' Check the right avatar
            Select Case userDetails.Avatar
                Case "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\blue_woman.jpg"
                    RadioButton_Blue_Woman.Checked = True
                Case "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\aisan_yellow_ladie.jpg"
                    RadioButton_Yellow_Ladie.Checked = True
                Case "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\green_man_glass.jpg"
                    RadioButton_Green_Man_Glasses.Checked = True
                Case "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\orange_mustache_man.jpg"
                    RadioButton_Orange_Mustache.Checked = True
                Case "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\pink_something.jpg"
                    RadioButton_Prink_Something.Checked = True
            End Select
        End If
    End Sub



    ' DOB (only digits and /)
    Private Sub TextBox_DOB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_DOB.KeyPress
        ' Allow digits, the slash, and control characters (like Backspace)
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "/" Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True ' Reject the character if it's not allowed
        End If
    End Sub
    ' Telephpne (only digits and -)
    Private Sub TextBox_Telephone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_Telephone.KeyPress
        ' Allow only digits, the hyphen, and control characters
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "-" Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True ' Ignore any other character
        End If
    End Sub

    Private Sub Button_Back_To_Chat_Room_Click(sender As Object, e As EventArgs) Handles Button_Back_To_Chat_Room.Click
        Dim chatRoom As New Chat
        chatRoom.Show()
        Me.Hide()
    End Sub


    Private Sub Button_Edit_Profile_Click(sender As Object, e As EventArgs) Handles Button_Edit_Profile.Click

        ' Validate character lengths
        If TextBox_First_Name.Text.Length > 30 Then
            MsgBox("First Name cannot exceed 30 characters.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        If TextBox_Last_Name.Text.Length > 30 Then
            MsgBox("Last Name cannot exceed 30 characters.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        If TextBox_School.Text.Length > 30 Then
            MsgBox("School cannot exceed 30 characters.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        If TextBox_Program.Text.Length > 30 Then
            MsgBox("Program cannot exceed 30 characters.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        If TextBox_Address.Text.Length > 100 Then
            MsgBox("Address cannot exceed 100 characters.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        ' Validate telephone format (xxx-xxx-xxxx) only if the field is not empty
        If Not String.IsNullOrWhiteSpace(TextBox_Telephone.Text) AndAlso Not Regex.IsMatch(TextBox_Telephone.Text, "^\d{3}-\d{3}-\d{4}$") Then
            MsgBox("Telephone format must be xxx-xxx-xxxx.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        ' Validate and parse date of birth (dd/mm/yyyy) only if the field is not empty
        Dim dob As DateTime
        Dim isValidDateOfBirth As Boolean = DateTime.TryParseExact(TextBox_DOB.Text, "dd/MM/yyyy", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dob)

        If Not String.IsNullOrWhiteSpace(TextBox_DOB.Text) AndAlso Not isValidDateOfBirth Then
            MsgBox("Date of Birth must be in dd/mm/yyyy format.", MsgBoxStyle.Critical, "Validation Error")
            Return
        End If

        ' Continue with user update process
        Dim dbManager As New DbManager()
        Dim updatedUser As New User() With {
        .Username = Globals.Username,
        .FirstName = TextBox_First_Name.Text,
        .LastName = TextBox_Last_Name.Text,
        .DateOfBirth = If(isValidDateOfBirth, dob, Nothing),
        .Address = TextBox_Address.Text,
        .Telephone = TextBox_Telephone.Text,
        .School = TextBox_School.Text,
        .Program = TextBox_Program.Text,
        .Avatar = GetSelectedAvatarPath()
    }

        dbManager.UpdateUserDetails(updatedUser)

        MsgBox("Your profile was updated. Keep writing what you think about", MsgBoxStyle.Information, "Profile Updated")
        Dim chatRoom As New Chat
        chatRoom.Show()
        Me.Hide()
    End Sub



    Private Function GetSelectedAvatarPath() As String
        If RadioButton_Blue_Woman.Checked Then
            Return "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\blue_woman.jpg"
        ElseIf RadioButton_Yellow_Ladie.Checked Then
            Return "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\aisan_yellow_ladie.jpg"
        ElseIf RadioButton_Green_Man_Glasses.Checked Then
            Return "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\green_man_glass.jpg"
        ElseIf RadioButton_Orange_Mustache.Checked Then
            Return "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\orange_mustache_man.jpg"
        ElseIf RadioButton_Prink_Something.Checked Then
            Return "C:\Users\louis\source\repos\Visual Programming 2\Final Project\Open_Registration\Resources\pink_something.jpg"
        End If
        Return String.Empty
    End Function

    Private Sub Button_Change_Password_Click(sender As Object, e As EventArgs) Handles Button_Change_Password.Click
        Dim changePassword As New ChangePassword
        changePassword.Show()
        Me.Hide()
    End Sub
End Class