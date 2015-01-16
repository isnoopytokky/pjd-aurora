Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Dim context = New AURORAEntities()
        Dim a = context.Permis.FirstOrDefault().Permis_Name

        Dim result = From employee In context.Employee
                        Where employee.UserName.Trim() = txt_username.Text.Trim() And
                        employee.PassWord.Trim = txt_password.Text.Trim()

        If (result.Count() > 0) Then
            MessageBox.Show("เข้าระบบ")
        Else
            MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านผิดพลาด")
        End If





    End Sub
End Class