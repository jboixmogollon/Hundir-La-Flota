Public Class Form1
    Dim x, y As Integer
    Dim terreno(9, 9) As Integer
    Dim salida As String = ""
    Dim name1 As String = ""
    Dim name2 As String = ""
    Dim j1 As Jugador
    Dim j2 As Jugador
    Dim g As New Game
    Dim resultado As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    'ASIGNAR NOMBRES A LOS JUGADORES
        name1 = InputBox("Instroduce el nombre del jugador 1")
        'name2 = InputBox("Introduce el nombre del jugador 2")
        salida = g.crearArray().ToString
        l1.Text = salida
    End Sub

    Private Sub beginning_Click(sender As Object, e As EventArgs) Handles beginning.Click   'AQUI CREAMOS EL MAPA
        'beginning.Enabled = False
        'salida = g.crearArray().ToString
    End Sub

    Private Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click   'SOLO MUESTRA EL MAPA
        'l1.Text = salida
    End Sub

    Private Sub up_array_Click(sender As Object, e As EventArgs) Handles up_array.Click
        salida = g.updateArray().ToString
        l1.Text = salida
    End Sub

    Private Sub disparar_Click(sender As Object, e As EventArgs) Handles disparar.Click
        Dim shootx As Integer = InputBox("Introduce X para disparar")
        Dim shooty As Integer = InputBox("Introduce Y para disparar")

        resultado = g.shoot(shootx, shooty)
        labelresultado.Text = resultado
    End Sub
End Class
