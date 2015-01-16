Imports System.Collections.Generic



Public Interface IContexts(Of T)

    Function Delete(ByVal obj As T) As Boolean
    Function GetID() As T
    Function GetAll() As List(Of T)

End Interface


