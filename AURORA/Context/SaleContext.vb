Public Class SaleContext
    Implements IContexts(Of Sale)



    Public Function Add(obj As Sale) As Boolean
        Using context As AURORAEntities = New AURORAEntities()
            Try

                Dim max_id = context.Sale.Max(Function(r) r.Sale_Id)
                Dim current_id = Convert.ToInt32(max_id) + 1
                obj.Sale_Id = current_id.ToString("D4")

                context.Sale.AddObject(obj)
                context.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using


    End Function

    

    Public Function Delete(obj As Sale) As Boolean Implements IContexts(Of Sale).Delete
        Return False
    End Function

    Public Function GetAll() As List(Of Sale) Implements IContexts(Of Sale).GetAll
        Using context As AURORAEntities = New AURORAEntities()

            Dim list = context.Sale.ToList()
            Return list

        End Using

    End Function

    Public Function GetID() As Sale Implements IContexts(Of Sale).GetID
        Return New Sale
    End Function
End Class


 
