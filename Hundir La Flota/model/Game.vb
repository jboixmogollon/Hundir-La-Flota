Public Class Game
    Private x, y As Integer
    Private terreno(9, 9) As Integer
    Private salida As String
    Private c As Cruisser

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
        salida = ""
        Dim c1pos1 As Integer = InputBox("Introduce X del crucero")
        Dim c1pos2 As Integer = InputBox("Introduce Y del crucero")

        Dim c2pos1 As Integer = InputBox("Introduce X del crucero")
        Dim c2pos2 As Integer = InputBox("Introduce Y del crucero")

        For x = 0 To 9
            For y = 0 To 9
                If x = c1pos1 And y = c2pos2 Or x = c2pos2 And y = c2pos2 Then
                    terreno(x, y) = 2
                Else
                    terreno(x, y) = 0
                End If
                salida = salida + terreno(x, y).ToString + "     "
            Next
            salida = salida + vbNewLine
        Next
        Return Me.salida
    End Function
End Class
