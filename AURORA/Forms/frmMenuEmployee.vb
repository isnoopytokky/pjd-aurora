Public Class frmMenuEmployee

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        Me._parent.Show()
    End Sub

    Private Sub btn_member_Click(sender As Object, e As EventArgs) Handles btn_member.Click
        Dim frmRegis = New frmEmployeeRegister()
        frmRegis._parent = Me
        frmRegis.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sale_Click(sender As Object, e As EventArgs) Handles btn_sale.Click
        Dim frmSale = New frmEmployeeSaleGold()
        frmSale._parent = Me
        frmSale.Show()
        frmSale._current_user = Me._current_user
        Me.Hide()
    End Sub

    Private Sub btn_pledge_Click(sender As Object, e As EventArgs) Handles btn_pledge.Click
        Dim frmPledge = New frmEmployeePledgeGold()
        frmPledge._parent = Me
        frmPledge.Show()
        frmPledge._current_user = Me._current_user
        Me.Hide()
    End Sub

    Private Sub frmMenuEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class