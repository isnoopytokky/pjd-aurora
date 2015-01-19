<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuEmployee
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_pledge = New System.Windows.Forms.Button()
        Me.btn_sale = New System.Windows.Forms.Button()
        Me.btn_member = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(35, 415)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(210, 59)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "ข้อมูลรายงาน"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(35, 351)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(210, 59)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "ข้อมูลชำระเงิน"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(35, 286)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(210, 59)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "ข้อมูลการสั่งทำทอง"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(35, 221)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(210, 59)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "ข้อมูลชำระดอกเบี้ย"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_pledge
        '
        Me.btn_pledge.Location = New System.Drawing.Point(35, 156)
        Me.btn_pledge.Name = "btn_pledge"
        Me.btn_pledge.Size = New System.Drawing.Size(210, 59)
        Me.btn_pledge.TabIndex = 11
        Me.btn_pledge.Text = "ข้อมูลการรับจำนำ/ไถ่ถอนทอง"
        Me.btn_pledge.UseVisualStyleBackColor = True
        '
        'btn_sale
        '
        Me.btn_sale.Location = New System.Drawing.Point(35, 91)
        Me.btn_sale.Name = "btn_sale"
        Me.btn_sale.Size = New System.Drawing.Size(210, 59)
        Me.btn_sale.TabIndex = 10
        Me.btn_sale.Text = "ข้อมูลการขายทอง"
        Me.btn_sale.UseVisualStyleBackColor = True
        '
        'btn_member
        '
        Me.btn_member.Location = New System.Drawing.Point(35, 26)
        Me.btn_member.Name = "btn_member"
        Me.btn_member.Size = New System.Drawing.Size(210, 59)
        Me.btn_member.TabIndex = 9
        Me.btn_member.Text = "ข้อมูลสมาชิก"
        Me.btn_member.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(35, 478)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(210, 59)
        Me.btn_logout.TabIndex = 8
        Me.btn_logout.Text = "ออกจากระบบ"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'frmMenuEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 537)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_pledge)
        Me.Controls.Add(Me.btn_sale)
        Me.Controls.Add(Me.btn_member)
        Me.Controls.Add(Me.btn_logout)
        Me.Name = "frmMenuEmployee"
        Me.Text = "frmMenuEmployee"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_member As System.Windows.Forms.Button
    Friend WithEvents btn_sale As System.Windows.Forms.Button
    Friend WithEvents btn_pledge As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
