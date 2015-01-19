<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeRegister
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
        Me.cbb_Province = New System.Windows.Forms.ComboBox()
        Me.cbb_Member_Sex = New System.Windows.Forms.ComboBox()
        Me.txt_Member_Address = New System.Windows.Forms.TextBox()
        Me.txt_Member_IdentNumber = New System.Windows.Forms.TextBox()
        Me.txt_Member_Tel = New System.Windows.Forms.TextBox()
        Me.txt_Member_SurName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Member_Name = New System.Windows.Forms.TextBox()
        Me.btn_show_all_member = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbb_Province
        '
        Me.cbb_Province.FormattingEnabled = True
        Me.cbb_Province.Location = New System.Drawing.Point(164, 351)
        Me.cbb_Province.Name = "cbb_Province"
        Me.cbb_Province.Size = New System.Drawing.Size(230, 21)
        Me.cbb_Province.TabIndex = 13
        '
        'cbb_Member_Sex
        '
        Me.cbb_Member_Sex.FormattingEnabled = True
        Me.cbb_Member_Sex.Location = New System.Drawing.Point(164, 148)
        Me.cbb_Member_Sex.Name = "cbb_Member_Sex"
        Me.cbb_Member_Sex.Size = New System.Drawing.Size(230, 21)
        Me.cbb_Member_Sex.TabIndex = 12
        '
        'txt_Member_Address
        '
        Me.txt_Member_Address.Location = New System.Drawing.Point(164, 267)
        Me.txt_Member_Address.Multiline = True
        Me.txt_Member_Address.Name = "txt_Member_Address"
        Me.txt_Member_Address.Size = New System.Drawing.Size(230, 70)
        Me.txt_Member_Address.TabIndex = 11
        '
        'txt_Member_IdentNumber
        '
        Me.txt_Member_IdentNumber.Location = New System.Drawing.Point(164, 224)
        Me.txt_Member_IdentNumber.Name = "txt_Member_IdentNumber"
        Me.txt_Member_IdentNumber.Size = New System.Drawing.Size(230, 20)
        Me.txt_Member_IdentNumber.TabIndex = 10
        '
        'txt_Member_Tel
        '
        Me.txt_Member_Tel.Location = New System.Drawing.Point(164, 189)
        Me.txt_Member_Tel.Name = "txt_Member_Tel"
        Me.txt_Member_Tel.Size = New System.Drawing.Size(230, 20)
        Me.txt_Member_Tel.TabIndex = 9
        '
        'txt_Member_SurName
        '
        Me.txt_Member_SurName.Location = New System.Drawing.Point(164, 112)
        Me.txt_Member_SurName.Name = "txt_Member_SurName"
        Me.txt_Member_SurName.Size = New System.Drawing.Size(230, 20)
        Me.txt_Member_SurName.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "จังหวัด"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "เพศ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "เบอร์โทร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "เลขบัตรประชาชน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "นามสกุล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ชื่อ"
        '
        'txt_Member_Name
        '
        Me.txt_Member_Name.Location = New System.Drawing.Point(164, 72)
        Me.txt_Member_Name.Name = "txt_Member_Name"
        Me.txt_Member_Name.Size = New System.Drawing.Size(230, 20)
        Me.txt_Member_Name.TabIndex = 0
        '
        'btn_show_all_member
        '
        Me.btn_show_all_member.Location = New System.Drawing.Point(234, 18)
        Me.btn_show_all_member.Name = "btn_show_all_member"
        Me.btn_show_all_member.Size = New System.Drawing.Size(160, 32)
        Me.btn_show_all_member.TabIndex = 14
        Me.btn_show_all_member.Text = "แสดงข้อมูลสมาชิกทั้งหมด"
        Me.btn_show_all_member.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(83, 392)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(86, 32)
        Me.btn_save.TabIndex = 15
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(175, 392)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(86, 32)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(267, 392)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(86, 32)
        Me.btn_clear.TabIndex = 17
        Me.btn_clear.Text = "ล้างข้อมูล"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frmEmployeeRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 436)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_show_all_member)
        Me.Controls.Add(Me.cbb_Province)
        Me.Controls.Add(Me.cbb_Member_Sex)
        Me.Controls.Add(Me.txt_Member_Address)
        Me.Controls.Add(Me.txt_Member_IdentNumber)
        Me.Controls.Add(Me.txt_Member_Tel)
        Me.Controls.Add(Me.txt_Member_SurName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Member_Name)
        Me.Name = "frmEmployeeRegister"
        Me.Text = "frmEmployeeRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Member_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Member_SurName As System.Windows.Forms.TextBox
    Friend WithEvents txt_Member_Tel As System.Windows.Forms.TextBox
    Friend WithEvents txt_Member_IdentNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_Member_Address As System.Windows.Forms.TextBox
    Friend WithEvents cbb_Member_Sex As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_Province As System.Windows.Forms.ComboBox
    Friend WithEvents btn_show_all_member As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
