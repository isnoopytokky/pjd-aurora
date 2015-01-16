Public Class EmployeeContext
    Implements IContexts(Of Employee)


    Public Function Login(ByVal Username As String, ByVal Password As String) As Employee
        Using context As AURORAEntities = New AURORAEntities()

            Dim row = context.Employee.Include("Permis").Where(Function(r) _
                                                                    r.UserName.Trim() = Username.Trim() And _
                                                                    r.PassWord.Trim() = Password.Trim())

            If row.Count > 0 Then
                Return row.FirstOrDefault()
            Else
                Return Nothing
            End If

        End Using
    End Function



    Public Function Delete(obj As Employee) As Boolean Implements IContexts(Of Employee).Delete
        Return False
    End Function

    Public Function GetAll() As List(Of Employee) Implements IContexts(Of Employee).GetAll
        Return New List(Of Employee)
    End Function

    Public Function GetID() As Employee Implements IContexts(Of Employee).GetID
        Return New Employee
    End Function
End Class


 
