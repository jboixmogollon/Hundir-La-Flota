Public Class Cruisser
    Private x As Integer
    Private y As Integer
    Private xc As Integer
    Private yc As Integer

    Public Function getUbicacion()
        Return Me.x
        Return Me.y
    End Function
    Public Sub setUbicacion(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y
    End Sub

    Public Sub setXc(ByVal xc As Integer)
        Me.xc = xc
    End Sub
    Public Sub setYc(ByVal yc As Integer)
        Me.yc = yc
    End Sub

    Public Function getXc()
        Return Me.xc
    End Function

    Public Function getYc()
        Return Me.yc
    End Function
End Class
