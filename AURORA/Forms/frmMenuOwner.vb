Public Class frmMenuOwner

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        Me._parent.Show()
    End Sub
End Class