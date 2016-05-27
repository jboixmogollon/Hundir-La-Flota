Public Class Jugador
    Private id1 As Integer
    Private id2 As Integer

    Public Sub New()
        Me.id1 = 1
        Me.id2 = 2
    End Sub
    Public Sub setId1(ByVal id1 As Integer)
        Me.id1 = id1
    End Sub

    Public Sub setId2(ByVal id2 As Integer)
        Me.id2 = id2
    End Sub

    Public Function getId1()
        Return Me.id1
    End Function

    Public Function getId2()
        Return Me.id2
    End Function

    'CREAR SET Y GET PARA EL NOMBRE
End Class
