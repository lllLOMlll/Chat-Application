<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginLogoutToolStripMenuItem = New ToolStripMenuItem()
        CreateAProfileToolStripMenuItem = New ToolStripMenuItem()
        EditProfileToolStripMenuItem = New ToolStripMenuItem()
        DeleteProfileToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutTheProgramToolStripMenuItem = New ToolStripMenuItem()
        Label_Title = New Label()
        Label_Username = New Label()
        Label_Password = New Label()
        TextBox_Username = New TextBox()
        TextBox_Password = New TextBox()
        Button_Login = New Button()
        Button_Register = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(984, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginLogoutToolStripMenuItem, CreateAProfileToolStripMenuItem, EditProfileToolStripMenuItem, DeleteProfileToolStripMenuItem})
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
        ' EditProfileToolStripMenuItem
        ' 
        EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        EditProfileToolStripMenuItem.Size = New Size(154, 22)
        EditProfileToolStripMenuItem.Text = "&Edit Profile"
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
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.Red
        Label_Title.Location = New Point(211, 58)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(584, 86)
        Label_Title.TabIndex = 2
        Label_Title.Text = "Open Registration"
        Label_Title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.Red
        Label_Username.Location = New Point(195, 182)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(124, 32)
        Label_Username.TabIndex = 4
        Label_Username.Text = "Username"
        ' 
        ' Label_Password
        ' 
        Label_Password.AutoSize = True
        Label_Password.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Password.ForeColor = Color.Red
        Label_Password.Location = New Point(195, 279)
        Label_Password.Name = "Label_Password"
        Label_Password.Size = New Size(115, 32)
        Label_Password.TabIndex = 5
        Label_Password.Text = "Password"
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Username.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Username.Location = New Point(195, 217)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.Size = New Size(600, 35)
        TextBox_Username.TabIndex = 6
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Password.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Password.Location = New Point(195, 314)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.PasswordChar = "*"c
        TextBox_Password.Size = New Size(600, 35)
        TextBox_Password.TabIndex = 7
        ' 
        ' Button_Login
        ' 
        Button_Login.BackColor = Color.White
        Button_Login.FlatAppearance.BorderColor = Color.Gray
        Button_Login.FlatAppearance.BorderSize = 3
        Button_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Login.FlatStyle = FlatStyle.Flat
        Button_Login.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Login.Location = New Point(188, 430)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(607, 54)
        Button_Login.TabIndex = 8
        Button_Login.Text = "Login"
        Button_Login.UseVisualStyleBackColor = False
        ' 
        ' Button_Register
        ' 
        Button_Register.BackColor = Color.White
        Button_Register.FlatAppearance.BorderColor = Color.Gray
        Button_Register.FlatAppearance.BorderSize = 3
        Button_Register.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Register.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Register.FlatStyle = FlatStyle.Flat
        Button_Register.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Register.Location = New Point(188, 517)
        Button_Register.Name = "Button_Register"
        Button_Register.Size = New Size(607, 54)
        Button_Register.TabIndex = 9
        Button_Register.Text = "Register"
        Button_Register.UseVisualStyleBackColor = False
        ' 
        ' MainLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(984, 661)
        Controls.Add(Button_Register)
        Controls.Add(Button_Login)
        Controls.Add(TextBox_Password)
        Controls.Add(TextBox_Username)
        Controls.Add(Label_Password)
        Controls.Add(Label_Username)
        Controls.Add(Label_Title)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainLogin"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginLogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTheProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Username As Label
    Friend WithEvents Label_Password As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_Register As Button
End Class
