Public Class frmEmployeeRegister

    Private Sub frmEmployeeRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' combo box ของ เพศ
        Dim sex_list = New List(Of String)
        sex_list.Add("ชาย")
        sex_list.Add("หญิง")
        cbb_Member_Sex.DataSource = sex_list

        ' combo box ของ จังหวัด
        Dim contect = New ProvinceContext()
        Dim provice_list = contect.GetAll()
        cbb_Province.DataSource = provice_list
        cbb_Province.ValueMember = "Province_Id"
        cbb_Province.DisplayMember = "Province_Name"

    End Sub
    Private Sub btn_show_all_member_Click(sender As Object, e As EventArgs) Handles btn_show_all_member.Click

        Dim frmMember = New frmEmployeeMember_Showall()
        frmMember._parent = Me
        frmMember.Show()
        Me.Hide()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If (Validate_Data()) Then
            ' Do save
            Dim context = New MemberContext()
            Dim member = New Member()
            'Dim id As Integer
            'id = 15
            'member.Member_Id = id.ToString("D5")
            member.Member_Name = txt_Member_Name.Text
            member.Member_SurName = txt_Member_SurName.Text
            member.Member_Tel = txt_Member_Tel.Text
            member.Member_IdentNumber = txt_Member_IdentNumber.Text
            member.Member_Address = txt_Member_Address.Text
            member.Member_Sex = cbb_Member_Sex.SelectedText
            member.Province_Id = cbb_Province.SelectedValue

            Dim result = context.Add(member)
            If result = True Then
                MessageBox.Show("บันทึกสำเร็จ")
                clear_all()
            Else
                MessageBox.Show("บันทึกไม่สำเร็จ")
            End If
        Else
            MessageBox.Show("ข้อมูลไม่ครบถ้วนกรุณากรอกใหม่")
        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
    Public Sub clear_all()
        txt_Member_Name.Text = ""
        txt_Member_SurName.Text = ""
        txt_Member_Tel.Text = ""
        txt_Member_Address.Text = ""
        txt_Member_IdentNumber.Text = ""
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear_all()
    End Sub
    Public Function Validate_Data() As Boolean

        Dim result = Not (txt_Member_Name.Text.Trim() = "" Or _
        txt_Member_SurName.Text.Trim() = "" Or _
        txt_Member_Tel.Text.Trim() = "" Or _
        txt_Member_IdentNumber.Text.Trim() = "" Or _
        txt_Member_Address.Text.Trim() = "")

        Return result
    End Function

End Class