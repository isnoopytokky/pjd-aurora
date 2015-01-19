Public Class ProvinceContext
    Implements IContexts(Of Province)




    Public Function Delete(obj As Province) As Boolean Implements IContexts(Of Province).Delete
        Return False
    End Function

    Public Function GetAll() As List(Of Province) Implements IContexts(Of Province).GetAll
        Using context As AURORAEntities = New AURORAEntities()

            Dim list = context.Province.OrderBy(Function(r) r.Province_Name).ToList()
            Return list

        End Using

    End Function

    Public Function GetID() As Province Implements IContexts(Of Province).GetID
        Return New Province
    End Function
End Class


 
