<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuAdmin
    'Inherits System.Windows.Forms.Form
	Inherits frmBase

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
        Me.btn_sell_gold = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_sell_gold
        '
        Me.btn_sell_gold.Location = New System.Drawing.Point(33, 31)
        Me.btn_sell_gold.Name = "btn_sell_gold"
        Me.btn_sell_gold.Size = New System.Drawing.Size(210, 59)
        Me.btn_sell_gold.TabIndex = 0
        Me.btn_sell_gold.Text = "ข้อมูลขายทอง"
        Me.btn_sell_gold.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(33, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 59)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ข้อมูลรับจำนำ/ไถ่ถอนทอง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(33, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(210, 59)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "ข้อมูลชำระดอกเบี้ย"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(33, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(210, 59)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "ข้อมูลสั่งทำทอง"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(33, 291)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(210, 59)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "ข้อมูลชำระเงิน"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(33, 356)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(210, 59)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "ข้อมูลพื้นฐาน"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(33, 421)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(210, 59)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "ข้อมูลรายงาน"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(33, 486)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(210, 59)
        Me.btn_logout.TabIndex = 7
        Me.btn_logout.Text = "ออกจากระบบ"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'frmMenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 551)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_sell_gold)
        Me.Name = "frmMenuAdmin"
        Me.Text = "frmMenuAdmin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_sell_gold As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
End Class
