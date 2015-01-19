Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (True) Then
            txt_username.Text = "sureerut  "
            txt_password.Text = "2244"


            txt_username.Text = "เป็นต่อ  "
            txt_password.Text = "1234"

        End If
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click

        Dim context = New EmployeeContext()
        Dim result As Employee = context.Login(txt_username.Text, txt_password.Text)

        If (Not result Is Nothing) Then
            MessageBox.Show(String.Format("เข้าระบบสำเร็จ" + Environment.NewLine + _
                                          "-------------------------" + Environment.NewLine + _
                                             "ชื่อผู้ใช้: {0} {1}" + Environment.NewLine + _
                                             "สิทธิ์ : {2} ", _
                                             result.Employee_Name, _
                                             result.Employee_SurName, _
                                             result.Permis.Permis_Name _
                                                ))
            If result.Permis.Permis_Name.Trim() = "พนักงานขาย" Then
                Dim frmMain = New frmMenuEmployee()
                frmMain._parent = Me
                frmMain.Show()
                frmMain._current_user = result
            ElseIf result.Permis.Permis_Name.Trim() = "ผู้ดูแลระบบ" Then
                Dim frmMain = New frmMenuAdmin()
                frmMain._parent = Me
                frmMain.Show()
                frmMain._current_user = result
            ElseIf result.Permis.Permis_Name.Trim() = "เจ้าของกิจการ" Then
                Dim frmMain = New frmMenuOwner()
                frmMain._parent = Me
                frmMain.Show()
                frmMain._current_user = result
            End If


            Me.Hide()
        Else
            MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านผิดพลาด")
        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class