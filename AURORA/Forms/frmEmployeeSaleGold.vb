Public Class frmEmployeeSaleGold

    Private Sub frmEmployeeSaleGold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' combo box ของ เพศ
        Dim payment_list = New List(Of String)
        payment_list.Add("ชำระครบแล้ว")
        payment_list.Add("ยังไม่ชำระ")
        cbb_pay_status.DataSource = payment_list

        ' combo box ของ จังหวัด
        Dim contect = New MemberContext()
        Dim member_list = contect.GetDropdown()
        cbb_member.DataSource = member_list
        cbb_member.ValueMember = "Member_Id"
        cbb_member.DisplayMember = "Member_Name"
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Validate_Data() Then
            Dim context = New SaleContext()
            Dim sale = New Sale()

            'sale.DateofSale = DateTime.Now()
            'sale.TimeofSale = New TimeSpan()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_money.Text = ""
    End Sub

    Public Function Validate_Data() As Boolean

        Dim result = Not (txt_money.Text.Trim() = "" )

        Return result
    End Function
End Class