Public Class Game
    Dim x, y As Integer
    Dim terreno(9, 9) As Integer
    Dim salida As String
    Dim c As Cruisser

    Public Function crearArray() As String
        For x = 0 To 9
            For y = 0 To 9
                salida = salida + "|     "
            Next
            salida = salida + vbNewLine
        Next
        Return Me.salida
    End Function

    Public Sub setCruisser(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y
    End Sub

    Public Function updateArray() As String
        For x = 0 To 9
            For y = 0 To 9
                If x = InputBox("introduce x") And y = InputBox("Introduce Y") Then ''CREAR VARIABLE PARA INTRODUCIR AQUI EL INPUT BOX DE "CRUISER"
                    terreno(x, y) = 2
                Else
                    terreno(x, y) = 1
                End If
                salida = salida + terreno(x, y).ToString
            Next
            salida = salida + vbNewLine
        Next
        Return Me.salida
    End Function
End Class
