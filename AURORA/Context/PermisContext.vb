Public Class PermisContext
    Implements IContexts(Of Permis)




    Public Function Delete(obj As Permis) As Boolean Implements IContexts(Of Permis).Delete
        Return False
    End Function

    Public Function GetAll() As List(Of Permis) Implements IContexts(Of Permis).GetAll
        Return New List(Of Permis)
    End Function

    Public Function GetID() As Permis Implements IContexts(Of Permis).GetID
        Return New Permis
    End Function
End Class


 
