Public Class Form1
    Dim x, y As Integer
    Dim terreno(9, 9) As Integer
    Dim salida As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub beginning_Click(sender As Object, e As EventArgs) Handles beginning.Click   'AQUI CREAMOS EL MAPA
        For x = 0 To 9
            For y = 0 To 9
                salida = salida + "1     "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
        beginning.Enabled = False
    End Sub

    Private Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click   'SOLO MUESTRA EL MAPA
        MessageBox.Show(salida)
    End Sub
End Class
