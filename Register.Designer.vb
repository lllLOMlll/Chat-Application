<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Register))
        Label_Title = New Label()
        Label_Username = New Label()
        TextBox_Username = New TextBox()
        Label_Password = New Label()
        TextBox_Password = New TextBox()
        Label_Confirm_Password = New Label()
        TextBox_Confirm_Password = New TextBox()
        Label_Avatar = New Label()
        Button_Register = New Button()
        Button_Back_To_Login = New Button()
        ImageList_Avatars = New ImageList(components)
        RadioButton_Blue_Woman = New RadioButton()
        RadioButton_Yellow_Ladie = New RadioButton()
        RadioButton_Green_Man_Glasses = New RadioButton()
        RadioButton_Orange_Mustache = New RadioButton()
        RadioButton_Prink_Something = New RadioButton()
        PictureBox_1 = New PictureBox()
        PictureBox_2 = New PictureBox()
        PictureBox_3 = New PictureBox()
        PictureBox_4 = New PictureBox()
        PictureBox_5 = New PictureBox()
        RadioButton_Dummy = New RadioButton()
        CType(PictureBox_1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.Red
        Label_Title.Location = New Point(61, 31)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(283, 86)
        Label_Title.TabIndex = 3
        Label_Title.Text = "Register"
        Label_Title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_Username
        ' 
        Label_Username.AutoSize = True
        Label_Username.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Username.ForeColor = Color.Red
        Label_Username.Location = New Point(79, 137)
        Label_Username.Name = "Label_Username"
        Label_Username.Size = New Size(109, 30)
        Label_Username.TabIndex = 4
        Label_Username.Text = "Username"
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Username.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Username.Location = New Point(79, 181)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.Size = New Size(401, 33)
        TextBox_Username.TabIndex = 5
        ' 
        ' Label_Password
        ' 
        Label_Password.AutoSize = True
        Label_Password.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Password.ForeColor = Color.Red
        Label_Password.Location = New Point(79, 244)
        Label_Password.Name = "Label_Password"
        Label_Password.Size = New Size(103, 30)
        Label_Password.TabIndex = 6
        Label_Password.Text = "Password"
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Password.Location = New Point(79, 277)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.PasswordChar = "*"c
        TextBox_Password.Size = New Size(401, 33)
        TextBox_Password.TabIndex = 7
        ' 
        ' Label_Confirm_Password
        ' 
        Label_Confirm_Password.AutoSize = True
        Label_Confirm_Password.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Confirm_Password.ForeColor = Color.Red
        Label_Confirm_Password.Location = New Point(79, 339)
        Label_Confirm_Password.Name = "Label_Confirm_Password"
        Label_Confirm_Password.Size = New Size(186, 30)
        Label_Confirm_Password.TabIndex = 8
        Label_Confirm_Password.Text = "Confirm Password"
        ' 
        ' TextBox_Confirm_Password
        ' 
        TextBox_Confirm_Password.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Confirm_Password.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Confirm_Password.Location = New Point(79, 372)
        TextBox_Confirm_Password.Name = "TextBox_Confirm_Password"
        TextBox_Confirm_Password.PasswordChar = "*"c
        TextBox_Confirm_Password.Size = New Size(401, 33)
        TextBox_Confirm_Password.TabIndex = 9
        ' 
        ' Label_Avatar
        ' 
        Label_Avatar.AutoSize = True
        Label_Avatar.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Avatar.ForeColor = Color.Red
        Label_Avatar.Location = New Point(555, 137)
        Label_Avatar.Name = "Label_Avatar"
        Label_Avatar.Size = New Size(182, 30)
        Label_Avatar.TabIndex = 10
        Label_Avatar.Text = "Choose an Avatar"
        ' 
        ' Button_Register
        ' 
        Button_Register.BackColor = Color.White
        Button_Register.FlatAppearance.BorderColor = Color.Gray
        Button_Register.FlatAppearance.BorderSize = 3
        Button_Register.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Register.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Register.FlatStyle = FlatStyle.Flat
        Button_Register.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Register.Location = New Point(75, 552)
        Button_Register.Name = "Button_Register"
        Button_Register.Size = New Size(400, 64)
        Button_Register.TabIndex = 12
        Button_Register.Text = "Register"
        Button_Register.UseVisualStyleBackColor = False
        ' 
        ' Button_Back_To_Login
        ' 
        Button_Back_To_Login.BackColor = Color.White
        Button_Back_To_Login.FlatAppearance.BorderColor = Color.Gray
        Button_Back_To_Login.FlatAppearance.BorderSize = 3
        Button_Back_To_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Back_To_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Back_To_Login.FlatStyle = FlatStyle.Flat
        Button_Back_To_Login.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Back_To_Login.Location = New Point(551, 552)
        Button_Back_To_Login.Name = "Button_Back_To_Login"
        Button_Back_To_Login.Size = New Size(400, 64)
        Button_Back_To_Login.TabIndex = 13
        Button_Back_To_Login.Text = "Login Screen"
        Button_Back_To_Login.UseVisualStyleBackColor = False
        ' 
        ' ImageList_Avatars
        ' 
        ImageList_Avatars.ColorDepth = ColorDepth.Depth8Bit
        ImageList_Avatars.ImageStream = CType(resources.GetObject("ImageList_Avatars.ImageStream"), ImageListStreamer)
        ImageList_Avatars.TransparentColor = Color.Transparent
        ImageList_Avatars.Images.SetKeyName(0, "astronaut.jpg")
        ImageList_Avatars.Images.SetKeyName(1, "cat.jpg")
        ImageList_Avatars.Images.SetKeyName(2, "coffee.jpg")
        ImageList_Avatars.Images.SetKeyName(3, "corporate_man.jpg")
        ImageList_Avatars.Images.SetKeyName(4, "dragon1.png")
        ' 
        ' RadioButton_Blue_Woman
        ' 
        RadioButton_Blue_Woman.AutoSize = True
        RadioButton_Blue_Woman.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_Blue_Woman.Location = New Point(611, 201)
        RadioButton_Blue_Woman.Name = "RadioButton_Blue_Woman"
        RadioButton_Blue_Woman.Size = New Size(14, 13)
        RadioButton_Blue_Woman.TabIndex = 14
        RadioButton_Blue_Woman.TabStop = True
        RadioButton_Blue_Woman.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Yellow_Ladie
        ' 
        RadioButton_Yellow_Ladie.AutoSize = True
        RadioButton_Yellow_Ladie.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_Yellow_Ladie.Location = New Point(611, 277)
        RadioButton_Yellow_Ladie.Name = "RadioButton_Yellow_Ladie"
        RadioButton_Yellow_Ladie.Size = New Size(14, 13)
        RadioButton_Yellow_Ladie.TabIndex = 15
        RadioButton_Yellow_Ladie.TabStop = True
        RadioButton_Yellow_Ladie.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Green_Man_Glasses
        ' 
        RadioButton_Green_Man_Glasses.AutoSize = True
        RadioButton_Green_Man_Glasses.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_Green_Man_Glasses.Location = New Point(611, 339)
        RadioButton_Green_Man_Glasses.Name = "RadioButton_Green_Man_Glasses"
        RadioButton_Green_Man_Glasses.Size = New Size(14, 13)
        RadioButton_Green_Man_Glasses.TabIndex = 16
        RadioButton_Green_Man_Glasses.TabStop = True
        RadioButton_Green_Man_Glasses.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Orange_Mustache
        ' 
        RadioButton_Orange_Mustache.AutoSize = True
        RadioButton_Orange_Mustache.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_Orange_Mustache.Location = New Point(611, 404)
        RadioButton_Orange_Mustache.Name = "RadioButton_Orange_Mustache"
        RadioButton_Orange_Mustache.Size = New Size(14, 13)
        RadioButton_Orange_Mustache.TabIndex = 17
        RadioButton_Orange_Mustache.TabStop = True
        RadioButton_Orange_Mustache.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Prink_Something
        ' 
        RadioButton_Prink_Something.AutoSize = True
        RadioButton_Prink_Something.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton_Prink_Something.Location = New Point(611, 473)
        RadioButton_Prink_Something.Name = "RadioButton_Prink_Something"
        RadioButton_Prink_Something.Size = New Size(14, 13)
        RadioButton_Prink_Something.TabIndex = 18
        RadioButton_Prink_Something.TabStop = True
        RadioButton_Prink_Something.UseVisualStyleBackColor = True
        ' 
        ' PictureBox_1
        ' 
        PictureBox_1.BackgroundImage = My.Resources.Resources.blue_woman
        PictureBox_1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox_1.Location = New Point(644, 181)
        PictureBox_1.Name = "PictureBox_1"
        PictureBox_1.Size = New Size(60, 60)
        PictureBox_1.TabIndex = 19
        PictureBox_1.TabStop = False
        ' 
        ' PictureBox_2
        ' 
        PictureBox_2.Image = My.Resources.Resources.aisan_yellow_ladie
        PictureBox_2.Location = New Point(644, 247)
        PictureBox_2.Name = "PictureBox_2"
        PictureBox_2.Size = New Size(60, 60)
        PictureBox_2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_2.TabIndex = 20
        PictureBox_2.TabStop = False
        ' 
        ' PictureBox_3
        ' 
        PictureBox_3.Image = My.Resources.Resources.green_man_glass
        PictureBox_3.Location = New Point(644, 316)
        PictureBox_3.Name = "PictureBox_3"
        PictureBox_3.Size = New Size(60, 60)
        PictureBox_3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_3.TabIndex = 21
        PictureBox_3.TabStop = False
        ' 
        ' PictureBox_4
        ' 
        PictureBox_4.Image = My.Resources.Resources.orange_mustache_man
        PictureBox_4.Location = New Point(644, 382)
        PictureBox_4.Name = "PictureBox_4"
        PictureBox_4.Size = New Size(60, 60)
        PictureBox_4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_4.TabIndex = 22
        PictureBox_4.TabStop = False
        ' 
        ' PictureBox_5
        ' 
        PictureBox_5.Image = My.Resources.Resources.pink_something
        PictureBox_5.Location = New Point(644, 448)
        PictureBox_5.Name = "PictureBox_5"
        PictureBox_5.Size = New Size(60, 60)
        PictureBox_5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox_5.TabIndex = 23
        PictureBox_5.TabStop = False
        ' 
        ' RadioButton_Dummy
        ' 
        RadioButton_Dummy.AutoSize = True
        RadioButton_Dummy.Location = New Point(854, 201)
        RadioButton_Dummy.Name = "RadioButton_Dummy"
        RadioButton_Dummy.Size = New Size(68, 19)
        RadioButton_Dummy.TabIndex = 24
        RadioButton_Dummy.TabStop = True
        RadioButton_Dummy.Text = "Dummy"
        RadioButton_Dummy.UseVisualStyleBackColor = True
        RadioButton_Dummy.Visible = False
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(984, 661)
        Controls.Add(RadioButton_Dummy)
        Controls.Add(PictureBox_5)
        Controls.Add(PictureBox_4)
        Controls.Add(PictureBox_3)
        Controls.Add(PictureBox_2)
        Controls.Add(PictureBox_1)
        Controls.Add(RadioButton_Prink_Something)
        Controls.Add(RadioButton_Orange_Mustache)
        Controls.Add(RadioButton_Green_Man_Glasses)
        Controls.Add(RadioButton_Yellow_Ladie)
        Controls.Add(RadioButton_Blue_Woman)
        Controls.Add(Button_Back_To_Login)
        Controls.Add(Button_Register)
        Controls.Add(Label_Avatar)
        Controls.Add(TextBox_Confirm_Password)
        Controls.Add(Label_Confirm_Password)
        Controls.Add(TextBox_Password)
        Controls.Add(Label_Password)
        Controls.Add(TextBox_Username)
        Controls.Add(Label_Username)
        Controls.Add(Label_Title)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(PictureBox_1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Username As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Label_Password As Label
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Label_Confirm_Password As Label
    Friend WithEvents TextBox_Confirm_Password As TextBox
    Friend WithEvents Label_Avatar As Label
    Friend WithEvents Button_Register As Button
    Friend WithEvents Button_Back_To_Login As Button
    Friend WithEvents ImageList_Avatars As ImageList
    Friend WithEvents RadioButton_Blue_Woman As RadioButton
    Friend WithEvents RadioButton_Yellow_Ladie As RadioButton
    Friend WithEvents RadioButton_Green_Man_Glasses As RadioButton
    Friend WithEvents RadioButton_Orange_Mustache As RadioButton
    Friend WithEvents RadioButton_Prink_Something As RadioButton
    Friend WithEvents PictureBox_1 As PictureBox
    Friend WithEvents PictureBox_2 As PictureBox
    Friend WithEvents PictureBox_3 As PictureBox
    Friend WithEvents PictureBox_4 As PictureBox
    Friend WithEvents PictureBox_5 As PictureBox
    Friend WithEvents RadioButton_Dummy As RadioButton
End Class
