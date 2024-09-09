Public Class Inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        CrearUsuario.Show()

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btneliminarUsuario_Click(sender As Object, e As EventArgs) Handles btneliminarUsuario.Click
        Eliminar_Usuario.Show()
    End Sub
End Class