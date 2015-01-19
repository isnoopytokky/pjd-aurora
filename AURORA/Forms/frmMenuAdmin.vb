Public Class frmMenuAdmin

    Private Sub frmMenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a = New cmpLabel()
        a.Label1.Text = "ss"


    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        Me._parent.Show()
    End Sub
End Class