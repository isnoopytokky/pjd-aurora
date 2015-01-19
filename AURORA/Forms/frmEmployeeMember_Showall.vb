Public Class frmEmployeeMember_Showall

    Private Sub frmEmployeeMember_Showall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim context = New MemberContext()
        Dim result = context.GetAll()
        gvMember.DataSource = result
    End Sub

    Private Sub gvMember_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub gvMember_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gvMember.CellContentClick

    End Sub
End Class