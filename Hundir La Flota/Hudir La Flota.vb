Public Class Form1
    Dim x, y As Integer
    Dim terreno(9, 9) As Integer
    Dim salida As String = ""
    Dim name1 As String = ""
    Dim name2 As String = ""
    Dim g As New Game

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    'ASIGNAR NOMBRES A LOS JUGADORES
        name1 = InputBox("Instroduce el nombre del jugador 1")
        name2 = InputBox("Introduce el nombre del jugador 2")
    End Sub

    Private Sub beginning_Click(sender As Object, e As EventArgs) Handles beginning.Click   'AQUI CREAMOS EL MAPA
        beginning.Enabled = False
        salida = g.crearArray().ToString
    End Sub

    Private Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click   'SOLO MUESTRA EL MAPA
        l1.Text = salida
    End Sub

    Private Sub ubicar_Click(sender As Object, e As EventArgs) Handles ubicar.Click
        'Dim c As Cruisser
        Dim xc As Integer
        Dim yc As Integer

        xc = InputBox("Establece X")
        yc = InputBox("Establece Y")

        g.setCruisser(xc, yc)
        'xc = CInt(Math.Floor((10 - 0 + 1) * Rnd())) + 0
        'yc = CInt(Math.Floor((10 - 0 + 1) * Rnd())) + 0

        MessageBox.Show(xc.ToString + yc.ToString)

    End Sub
End Class
