Public Class Form1
    Dim x, y As Integer
    Dim terreno(9, 9) As Integer
    Dim salida As String = ""
    Dim salida2 As String = ""
    Dim name1 As String = ""
    Dim name2 As String = ""
    Dim g As New Game
    Dim resultado As String
    Dim resultado2 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load    'ASIGNAR NOMBRES A LOS JUGADORES
        'name1 = InputBox("Instroduce el nombre del jugador 1")                     'CREAR EL MAPA EN EL LOAD
        'name2 = InputBox("Introduce el nombre del jugador 2")
        salida = g.crearArray().ToString
        l1.Text = salida                                                            'MOSTRAR MAPAS EN EL LOAD
        l2.Text = salida
    End Sub

    Private Sub up_array_Click(sender As Object, e As EventArgs) Handles up_array.Click
        salida = g.updateArray().ToString
        l1.Text = salida
        salida2 = g.updateArray2().ToString
        l2.Text = salida2
    End Sub

    Private Sub disparar_Click(sender As Object, e As EventArgs) Handles disparar.Click
        Dim shootx As Integer = InputBox("Introduce X para disparar")
        Dim shooty As Integer = InputBox("Introduce Y para disparar")

        resultado = g.shoot(shootx, shooty)
        labelresultado.Text = resultado

        Dim shootxenemy As Integer = CInt(Math.Floor((9 - 1 + 1) * Rnd())) + 1
        Dim shootyenemy As Integer = CInt(Math.Floor((9 - 1 + 1) * Rnd())) + 1

        resultado2 = g.shoot(shootxenemy, shootyenemy)
        labelresultado2.Text = resultado2
    End Sub
End Class
