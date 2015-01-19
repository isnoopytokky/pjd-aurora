Public Class MemberContext
    Implements IContexts(Of Member)



    Public Function Add(obj As Member) As Boolean
        Using context As AURORAEntities = New AURORAEntities()
            Try

                Dim max_id = context.Member.Max(Function(r) r.Member_Id)
                Dim current_id = Convert.ToInt32(max_id) + 1
                obj.Member_Id = current_id.ToString("D5")

                context.Member.AddObject(obj)
                context.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using


    End Function

    Public Function GetDropdown() As List(Of Member)
        Using context As AURORAEntities = New AURORAEntities()

            Dim list = context.Member.Include("Province").OrderBy(Function(r) r.Member_Name).ToList()

            For Each l In list
                l.Member_Name = l.Member_Name + " " + l.Member_SurName
            Next

            Return list

        End Using

    End Function

    Public Function Delete(obj As Member) As Boolean Implements IContexts(Of Member).Delete
        Return False
    End Function

    Public Function GetAll() As List(Of Member) Implements IContexts(Of Member).GetAll
        Using context As AURORAEntities = New AURORAEntities()

            Dim list = context.Member.Include("Province").OrderBy(Function(r) r.Member_Name).ToList()



            Return list

        End Using

    End Function

    Public Function GetID() As Member Implements IContexts(Of Member).GetID
        Return New Member
    End Function
End Class


 
