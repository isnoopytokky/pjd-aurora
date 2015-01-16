<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label_User = New System.Windows.Forms.Label()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(44, 193)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "เข้าสู่ระบบ"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(160, 193)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "ออกจากโปรแกรม"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Label_User
        '
        Me.Label_User.AutoSize = True
        Me.Label_User.Location = New System.Drawing.Point(41, 79)
        Me.Label_User.Name = "Label_User"
        Me.Label_User.Size = New System.Drawing.Size(40, 13)
        Me.Label_User.TabIndex = 2
        Me.Label_User.Text = "ชื่อผู้ใช้"
        '
        'Label_Password
        '
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Location = New System.Drawing.Point(41, 115)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(46, 13)
        Me.Label_Password.TabIndex = 3
        Me.Label_Password.Text = "รหัสผ่าน"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(96, 76)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(150, 20)
        Me.txt_username.TabIndex = 4
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(96, 112)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(150, 20)
        Me.txt_password.TabIndex = 5
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label_Password)
        Me.Controls.Add(Me.Label_User)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Label_User As System.Windows.Forms.Label
    Friend WithEvents Label_Password As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
End Class
