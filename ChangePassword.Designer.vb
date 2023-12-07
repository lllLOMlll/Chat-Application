<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Label_Old_Password = New Label()
        TextBox_Old_Password = New TextBox()
        Label_New_Password = New Label()
        TextBox_New_Password = New TextBox()
        Label_Confirm_New_Password = New Label()
        TextBox_Confirm_New_Password = New TextBox()
        Button_Change_Password = New Button()
        SuspendLayout()
        ' 
        ' Label_Title
        ' 
        Label_Title.AutoSize = True
        Label_Title.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Title.ForeColor = Color.Red
        Label_Title.Location = New Point(42, 43)
        Label_Title.Name = "Label_Title"
        Label_Title.Size = New Size(423, 65)
        Label_Title.TabIndex = 0
        Label_Title.Text = "Change Password"
        ' 
        ' Label_Old_Password
        ' 
        Label_Old_Password.AutoSize = True
        Label_Old_Password.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Old_Password.ForeColor = Color.Red
        Label_Old_Password.Location = New Point(42, 126)
        Label_Old_Password.Name = "Label_Old_Password"
        Label_Old_Password.Size = New Size(109, 21)
        Label_Old_Password.TabIndex = 1
        Label_Old_Password.Text = "Old Password"
        ' 
        ' TextBox_Old_Password
        ' 
        TextBox_Old_Password.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Old_Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Old_Password.Location = New Point(42, 150)
        TextBox_Old_Password.Name = "TextBox_Old_Password"
        TextBox_Old_Password.PasswordChar = "*"c
        TextBox_Old_Password.Size = New Size(403, 29)
        TextBox_Old_Password.TabIndex = 8
        ' 
        ' Label_New_Password
        ' 
        Label_New_Password.AutoSize = True
        Label_New_Password.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_New_Password.ForeColor = Color.Red
        Label_New_Password.Location = New Point(42, 198)
        Label_New_Password.Name = "Label_New_Password"
        Label_New_Password.Size = New Size(116, 21)
        Label_New_Password.TabIndex = 9
        Label_New_Password.Text = "New Password"
        ' 
        ' TextBox_New_Password
        ' 
        TextBox_New_Password.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_New_Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_New_Password.Location = New Point(42, 222)
        TextBox_New_Password.Name = "TextBox_New_Password"
        TextBox_New_Password.PasswordChar = "*"c
        TextBox_New_Password.Size = New Size(403, 29)
        TextBox_New_Password.TabIndex = 10
        ' 
        ' Label_Confirm_New_Password
        ' 
        Label_Confirm_New_Password.AutoSize = True
        Label_Confirm_New_Password.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label_Confirm_New_Password.ForeColor = Color.Red
        Label_Confirm_New_Password.Location = New Point(42, 270)
        Label_Confirm_New_Password.Name = "Label_Confirm_New_Password"
        Label_Confirm_New_Password.Size = New Size(179, 21)
        Label_Confirm_New_Password.TabIndex = 11
        Label_Confirm_New_Password.Text = "Confirm New Password"
        ' 
        ' TextBox_Confirm_New_Password
        ' 
        TextBox_Confirm_New_Password.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        TextBox_Confirm_New_Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Confirm_New_Password.Location = New Point(42, 294)
        TextBox_Confirm_New_Password.Name = "TextBox_Confirm_New_Password"
        TextBox_Confirm_New_Password.PasswordChar = "*"c
        TextBox_Confirm_New_Password.Size = New Size(403, 29)
        TextBox_Confirm_New_Password.TabIndex = 12
        ' 
        ' Button_Change_Password
        ' 
        Button_Change_Password.BackColor = Color.White
        Button_Change_Password.FlatAppearance.BorderColor = Color.Gray
        Button_Change_Password.FlatAppearance.BorderSize = 3
        Button_Change_Password.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Change_Password.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button_Change_Password.FlatStyle = FlatStyle.Flat
        Button_Change_Password.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Change_Password.Location = New Point(44, 365)
        Button_Change_Password.Name = "Button_Change_Password"
        Button_Change_Password.Size = New Size(401, 58)
        Button_Change_Password.TabIndex = 13
        Button_Change_Password.Text = "Change Password"
        Button_Change_Password.UseVisualStyleBackColor = False
        ' 
        ' ChangePassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(504, 450)
        Controls.Add(Button_Change_Password)
        Controls.Add(TextBox_Confirm_New_Password)
        Controls.Add(Label_Confirm_New_Password)
        Controls.Add(TextBox_New_Password)
        Controls.Add(Label_New_Password)
        Controls.Add(TextBox_Old_Password)
        Controls.Add(Label_Old_Password)
        Controls.Add(Label_Title)
        Name = "ChangePassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChangePassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_Old_Password As Label
    Friend WithEvents TextBox_Old_Password As TextBox
    Friend WithEvents Label_New_Password As Label
    Friend WithEvents TextBox_New_Password As TextBox
    Friend WithEvents Label_Confirm_New_Password As Label
    Friend WithEvents TextBox_Confirm_New_Password As TextBox
    Friend WithEvents Button_Change_Password As Button
End Class
