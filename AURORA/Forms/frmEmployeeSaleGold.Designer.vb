<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeSaleGold
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
        Me.txt_money = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbb_pay_status = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbb_member = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_employee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_show_all_member = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_money
        '
        Me.txt_money.Location = New System.Drawing.Point(126, 162)
        Me.txt_money.Name = "txt_money"
        Me.txt_money.Size = New System.Drawing.Size(223, 20)
        Me.txt_money.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "จำนวนเงิน"
        '
        'cbb_pay_status
        '
        Me.cbb_pay_status.FormattingEnabled = True
        Me.cbb_pay_status.Location = New System.Drawing.Point(126, 126)
        Me.cbb_pay_status.Name = "cbb_pay_status"
        Me.cbb_pay_status.Size = New System.Drawing.Size(223, 21)
        Me.cbb_pay_status.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "สถานะการชำระเงิน"
        '
        'cbb_member
        '
        Me.cbb_member.FormattingEnabled = True
        Me.cbb_member.Location = New System.Drawing.Point(126, 88)
        Me.cbb_member.Name = "cbb_member"
        Me.cbb_member.Size = New System.Drawing.Size(223, 21)
        Me.cbb_member.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "สมาชิก"
        '
        'txt_employee
        '
        Me.txt_employee.Enabled = False
        Me.txt_employee.Location = New System.Drawing.Point(214, 33)
        Me.txt_employee.Name = "txt_employee"
        Me.txt_employee.Size = New System.Drawing.Size(151, 20)
        Me.txt_employee.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "พนักงาน"
        '
        'txt_date
        '
        Me.txt_date.Enabled = False
        Me.txt_date.Location = New System.Drawing.Point(214, 6)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(151, 20)
        Me.txt_date.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "วัน/เดือน/ปี"
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(249, 231)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(86, 32)
        Me.btn_clear.TabIndex = 21
        Me.btn_clear.Text = "ล้างข้อมูล"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(157, 231)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(86, 32)
        Me.btn_cancel.TabIndex = 20
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(65, 231)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(86, 32)
        Me.btn_save.TabIndex = 19
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_show_all_member
        '
        Me.btn_show_all_member.Location = New System.Drawing.Point(138, -73)
        Me.btn_show_all_member.Name = "btn_show_all_member"
        Me.btn_show_all_member.Size = New System.Drawing.Size(160, 32)
        Me.btn_show_all_member.TabIndex = 18
        Me.btn_show_all_member.Text = "แสดงข้อมูลสมาชิกทั้งหมด"
        Me.btn_show_all_member.UseVisualStyleBackColor = True
        '
        'frmEmployeeSaleGold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 294)
        Me.Controls.Add(Me.txt_money)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbb_pay_status)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbb_member)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_employee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_show_all_member)
        Me.Name = "frmEmployeeSaleGold"
        Me.Text = "frmEmployeeSaleGold"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_show_all_member As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_date As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_employee As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbb_member As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_pay_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_money As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
