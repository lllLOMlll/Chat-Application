Public Class Chat

    Private Sub Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DISPLAY USERNAME AND AVATAR
        Dim dbManager As New DbManager()
        ' Using my Globars.Username to retrive the username username
        Dim username = Globals.Username
        Dim currentUser As User = dbManager.GetUserDetails(username)

        If currentUser IsNot Nothing Then
            Label_Username.Text = currentUser.Username
            If Not String.IsNullOrEmpty(currentUser.Avatar) Then
                Try
                    PictureBox_User_Avatar.Image = Image.FromFile(currentUser.Avatar)
                    ' I was not able to stretch the image in the box. This fixed the issue
                    PictureBox_User_Avatar.SizeMode = PictureBoxSizeMode.Zoom
                Catch ex As Exception
                    MessageBox.Show("Error loading avatar image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

        'DISPLAY THE POSTS
        DisplayPost()
    End Sub


    'MENU
    'Login/Logout
    Private Sub LoginLogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginLogoutToolStripMenuItem.Click
        ' Logout the user 
        Globals.IsUserLoggedIn = False
        Globals.Username = ""

        MsgBox("Thanks for using Open Registration, a Major Software", MsgBoxStyle.Information, "Logout")

        ' Go back the login screen
        Dim loginScreen As New MainLogin
        loginScreen.Show()
        Me.Hide()
    End Sub

    ' Create a Profile
    Private Sub CreateAProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAProfileToolStripMenuItem.Click
        ' To check the value
        Dim loginStatus As Boolean = Globals.IsUserLoggedIn
        If loginStatus = False Then
            MsgBox("You need to be logged to create your profile", MsgBoxStyle.Critical, "Error")
        ElseIf loginStatus = True Then
            Dim editProfile As New EditProfile
            editProfile.Show()
            Me.Hide()
        End If
    End Sub
    'Edit profile
    Private Sub EditAProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditAProfileToolStripMenuItem.Click
        Dim loginStatus As Boolean = Globals.IsUserLoggedIn
        If loginStatus = False Then
            MsgBox("You need to be logged to create your profile", MsgBoxStyle.Critical, "Error")
        ElseIf loginStatus = True Then
            Dim editProfile As New EditProfile
            editProfile.Show()
            Me.Hide()
        End If
    End Sub

    'Delete Profile
    Private Sub DeleteProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProfileToolStripMenuItem.Click
        ' Confirmation dialog
        Dim confirmResult As MsgBoxResult = MsgBox("Are you sure you want to deactivate your account?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Deactivation")

        If confirmResult = MsgBoxResult.Yes Then
            Dim dbManager As New DbManager()
            dbManager.SetUserStatusInactive(Globals.Username)

            MsgBox("Your profile has been set to inactive.", MsgBoxStyle.Information, "Profile Inactivated")

            'Logout the user
            Globals.IsUserLoggedIn = False
            Globals.Username = ""

            'Redirect to the home page
            Dim homepage As New MainLogin
            homepage.Show()
            Me.Hide()

        Else
            MsgBox("Account deactivation cancelled.", MsgBoxStyle.Information, "Cancellation")
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


    Private Sub Button_Publish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Publish.Click
        ' Capture the post content from the text box
        Dim postContent As String = TextBox_Post.Text.Trim()

        ' VALIDATION
        ' No empty posts
        If String.IsNullOrEmpty(postContent) Then
            MessageBox.Show("The post content cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' No more than 2000 characters
        If postContent.Length > 2000 Then
            MessageBox.Show("The post content cannot exceed 2000 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Initialize database manager
        Dim databaseManager As New DbManager()

        ' Retrieve the current user's ID and avatar path
        Dim currentUserId As Integer = databaseManager.GetUserIdByUsername(Globals.Username)
        Dim currentUserAvatarPath As String = databaseManager.GetUserDetails(Globals.Username).Avatar

        ' Create a new post instance
        Dim userPost As New Post(currentUserId, postContent, DateTime.Now)

        ' Add the new post to the database
        databaseManager.AddPost(userPost)

        ' Clear the input text box after posting
        TextBox_Post.Text = String.Empty

        ' Display a success message to the user
        MessageBox.Show("Your post has been successfully published.", "Post Published", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refresh the DataGridView to display the new post
        DisplayPost()

        ' Scroll to the last post in the DataGridView, if there are any posts
        'If DataGridView_Chat.Rows.Count > 0 Then
        '    DataGridView_Chat.FirstDisplayedScrollingRowIndex = DataGridView_Chat.Rows.Count - 1
        'End If
    End Sub



    Private Sub DisplayPost()
        ' DataGrid 
        DataGridView_Chat.AutoGenerateColumns = False
        DataGridView_Chat.AllowUserToAddRows = False

        ' Increase the font size for the rows
        Dim rowFont As New Font("Arial", 12, FontStyle.Regular)
        DataGridView_Chat.DefaultCellStyle.Font = rowFont

        ' Adjust row height to accommodate larger font
        DataGridView_Chat.RowTemplate.Height = 40

        ' Set bold font for column headers
        Dim headerFont As New Font("Arial", 14, FontStyle.Bold)
        DataGridView_Chat.ColumnHeadersDefaultCellStyle.Font = headerFont


        ' Check if columns are already added to avoid duplication
        If DataGridView_Chat.Columns.Count = 0 Then
            ' Add columns only if they haven't been added before
            ' Column for username
            Dim usernameColumn As New DataGridViewTextBoxColumn()
            usernameColumn.HeaderText = "Username"
            usernameColumn.DataPropertyName = "username"
            usernameColumn.Width = 160
            DataGridView_Chat.Columns.Add(usernameColumn)


            ' Column for post content
            Dim postContentColumn As New DataGridViewTextBoxColumn()
            postContentColumn.HeaderText = "Post"
            postContentColumn.DataPropertyName = "post"
            postContentColumn.Width = 400
            DataGridView_Chat.Columns.Add(postContentColumn)

            ' Column for time published
            Dim timePublishedColumn As New DataGridViewTextBoxColumn()
            timePublishedColumn.HeaderText = "Time Published"
            timePublishedColumn.DataPropertyName = "time_published"
            timePublishedColumn.Width = 170
            DataGridView_Chat.Columns.Add(timePublishedColumn)

            ' Column for avatars
            Dim imageColumn As New DataGridViewImageColumn()
            imageColumn.HeaderText = "Avatar"
            imageColumn.Name = "AvatarImage"
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            DataGridView_Chat.Columns.Add(imageColumn)
        End If

        ' Load data
        Dim dbManager As New DbManager()
        Dim postsTable As DataTable = dbManager.GetPosts()

        ' Set DataSource for the DataGridView
        DataGridView_Chat.DataSource = postsTable

        ' Process each row to set the avatar image
        For Each row As DataRow In postsTable.Rows
            If Not IsDBNull(row("avatar")) Then
                Dim imagePath As String = row("avatar").ToString()
                Try
                    Dim image As Image = Image.FromFile(imagePath)
                    DataGridView_Chat.Rows(postsTable.Rows.IndexOf(row)).Cells("AvatarImage").Value = image
                Catch ex As Exception
                    MessageBox.Show("Error loading avatar image: " & ex.Message)
                End Try
            End If
        Next
    End Sub


End Class