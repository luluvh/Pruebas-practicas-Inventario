Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        BuscarporCategoria.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        AñadirDocumentos.Show()
    End Sub


    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click

    End Sub
End Class

