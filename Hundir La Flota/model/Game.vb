Public Class Game
    Dim x, y As Integer
    Dim terreno(9, 9) As Integer
    Dim salida As String

    Public Function crearArray() As String
        For x = 0 To 9
            For y = 0 To 9
                salida = salida + "1     "
            Next
            salida = salida + vbNewLine
        Next
        Return Me.salida
    End Function

    Public Sub setCruisser(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y
    End Sub
End Class
