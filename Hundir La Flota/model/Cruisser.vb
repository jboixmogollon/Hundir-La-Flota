Public Class Cruisser
    Private x As Integer
    Private y As Integer

    Public Function getUbicacion(ByVal x As Integer, ByVal y As Integer)
        Return Me.x
        Return Me.y
    End Function
    Public Sub setUbicacion(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y
    End Sub
End Class
