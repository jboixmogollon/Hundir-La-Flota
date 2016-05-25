Public Class Form1
    Dim x, y As Integer
    Dim terreno(9, 9) As Integer
    Dim salida As String = ""
    Dim name1 As String = ""
    Dim name2 As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    'ASIGNAR NOMBRES A LOS JUGADORES
        name1 = InputBox("Instroduce el nombre del jugador 1")
        name2 = InputBox("Introduce el nombre del jugador 2")
    End Sub

    Private Sub beginning_Click(sender As Object, e As EventArgs) Handles beginning.Click   'AQUI CREAMOS EL MAPA
        For x = 0 To 9
            For y = 0 To 9
                salida = salida + "1     "
            Next
            salida = salida + vbNewLine
        Next
        'MessageBox.Show(salida)
        beginning.Enabled = False
    End Sub

    Private Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click   'SOLO MUESTRA EL MAPA
        l1.Text = salida
        'MessageBox.Show(salida)
    End Sub

    Private Sub ubicar_Click(sender As Object, e As EventArgs) Handles ubicar.Click
        Dim c As Cruisser
        Dim xc As Integer
        Dim yc As Integer

        xc = InputBox("Establece X")
        yc = InputBox("Establece Y")

        'xc = CInt(Math.Floor((10 - 0 + 1) * Rnd())) + 0
        'yc = CInt(Math.Floor((10 - 0 + 1) * Rnd())) + 0

        MessageBox.Show(xc.ToString + yc.ToString)

    End Sub
End Class
