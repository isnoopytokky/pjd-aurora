Public Class frmBase
    Public _parent As Form
    Public _current_user As New Employee

    Private Sub frmBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        
        Dim name As String = My.Resources.resFormName.ResourceManager.GetString(Me.Name)
        If (Not name Is "Nothing") Then
            Me.Text = name
        End If

    End Sub


    Private Sub frmBase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _parent Is Nothing Then
            _parent.Show()
        End If
    End Sub
End Class
