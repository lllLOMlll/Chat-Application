<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label_Title = New Label()
        DataGridView_Chat = New DataGridView()
        TextBox_Post = New TextBox()
        Button_Publish = New Button()
        Label_Username = New Label()
        PictureBox_User_Avatar = New PictureBox()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginLogoutToolStripMenuItem = New ToolStripMenuItem()
        CreateAProfileToolStripMenuItem = New ToolStripMenuItem()
        EditAProfileToolStripMenuItem = New ToolStripMenuItem()
        DeleteProfileToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutTheProgramToolStripMenuItem = New ToolStripMenuItem()
        CType(DataGridView_Chat, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_User_Avatar, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.Red
        Label_Title.Location = New Point(347, 25)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(277, 65)
        Label_Title.TabIndex = 0
        Label_Title.Text = "Chat Room"
        ' 
        ' DataGridView_Chat
        ' 
        DataGridView_Chat.BackgroundColor = Color.Black
        DataGridView_Chat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_Chat.Location = New Point(44, 93)
        DataGridView_Chat.Name = "DataGridView_Chat"
        DataGridView_Chat.RowTemplate.Height = 25
        DataGridView_Chat.Size = New Size(913, 360)
        DataGridView_Chat.TabIndex = 1
        ' 
        ' TextBox_Post
        ' 
        TextBox_Post.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Post.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Post.Location = New Point(44, 534)
        TextBox_Post.Multiline = True
        TextBox_Post.Name = "TextBox_Post"
        TextBox_Post.PlaceholderText = "What are you thinking about! Share!"
        TextBox_Post.Size = New Size(913, 59)
        TextBox_Post.TabIndex = 2
        ' 
        ' Button_Publish
        ' 
        Button_Publish.BackColor = Color.White
        Button_Publish.FlatAppearance.BorderColor = Color.Gray
        Button_Publish.FlatAppearance.BorderSize = 3
        Button_Publish.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button_Publish.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button_Publish.FlatStyle = FlatStyle.Flat
        Button_Publish.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Publish.Location = New Point(44, 599)
        Button_Publish.Name = "Button_Publish"
        Button_Publish.Size = New Size(913, 46)
        Button_Publish.TabIndex = 3
        Button_Publish.Text = "Publish"
        Button_Publish.UseVisualStyleBackColor = False
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.White
        Label_Username.Location = New Point(120, 482)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(93, 47)
        Label_Username.TabIndex = 4
        Label_Username.Text = "User"
        ' 
        ' PictureBox_User_Avatar
        ' 
        PictureBox_User_Avatar.BackColor = Color.Yellow
        PictureBox_User_Avatar.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox_User_Avatar.Location = New Point(44, 459)
        PictureBox_User_Avatar.Name = "PictureBox_User_Avatar"
        PictureBox_User_Avatar.Size = New Size(70, 70)
        PictureBox_User_Avatar.TabIndex = 5
        PictureBox_User_Avatar.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(984, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginLogoutToolStripMenuItem, CreateAProfileToolStripMenuItem, EditAProfileToolStripMenuItem, DeleteProfileToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' LoginLogoutToolStripMenuItem
        ' 
        LoginLogoutToolStripMenuItem.Name = "LoginLogoutToolStripMenuItem"
        LoginLogoutToolStripMenuItem.Size = New Size(154, 22)
        LoginLogoutToolStripMenuItem.Text = "&Login/Logout"
        ' 
        ' CreateAProfileToolStripMenuItem
        ' 
        CreateAProfileToolStripMenuItem.Name = "CreateAProfileToolStripMenuItem"
        CreateAProfileToolStripMenuItem.Size = New Size(154, 22)
        CreateAProfileToolStripMenuItem.Text = "&Create a Profile"
        ' 
        ' EditAProfileToolStripMenuItem
        ' 
        EditAProfileToolStripMenuItem.Name = "EditAProfileToolStripMenuItem"
        EditAProfileToolStripMenuItem.Size = New Size(154, 22)
        EditAProfileToolStripMenuItem.Text = "&Edit a Profile"
        ' 
        ' DeleteProfileToolStripMenuItem
        ' 
        DeleteProfileToolStripMenuItem.Name = "DeleteProfileToolStripMenuItem"
        DeleteProfileToolStripMenuItem.Size = New Size(154, 22)
        DeleteProfileToolStripMenuItem.Text = "&Delete Profile"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutTheProgramToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutTheProgramToolStripMenuItem
        ' 
        AboutTheProgramToolStripMenuItem.Name = "AboutTheProgramToolStripMenuItem"
        AboutTheProgramToolStripMenuItem.Size = New Size(176, 22)
        AboutTheProgramToolStripMenuItem.Text = "&About the Program"
        ' 
        ' Chat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(984, 661)
        Controls.Add(PictureBox_User_Avatar)
        Controls.Add(Label_Username)
        Controls.Add(Button_Publish)
        Controls.Add(TextBox_Post)
        Controls.Add(DataGridView_Chat)
        Controls.Add(Label_Title)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Chat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Chat"
        CType(DataGridView_Chat, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_User_Avatar, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents DataGridView_Chat As DataGridView
    Friend WithEvents TextBox_Post As TextBox
    Friend WithEvents Button_Publish As Button
    Friend WithEvents Label_Username As Label
    Friend WithEvents PictureBox_User_Avatar As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginLogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTheProgramToolStripMenuItem As ToolStripMenuItem
End Class
