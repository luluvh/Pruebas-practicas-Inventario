Imports MySql.Data.MySqlClient

Public Class CrearUsuario
    Private Sub BtnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        Dim nombreUsuario As String = txtusuario.Text
        Dim contraseña As String = txtcontraseña.Text
        Dim confirmarContraseña As String = TxtConfirmarContraseña.Text


        If String.IsNullOrWhiteSpace(nombreUsuario) Or String.IsNullOrWhiteSpace(contraseña) Or String.IsNullOrWhiteSpace(confirmarContraseña) Then
            MsgBox("Por favor complete todos los campos.")
            Return
        End If

        If contraseña <> confirmarContraseña Then
            MsgBox("Las contraseñas no coinciden. Por favor, inténtelo nuevamente.")
            Return
        End If

        CrearUsuario(nombreUsuario, contraseña)
    End Sub

    Private Sub CrearUsuario(ByVal nombreUsuario As String, ByVal contraseña As String)
        Dim query As String = "INSERT INTO usuarios (usuario, contraseña) VALUES (@usuario, @contraseña)"
        Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"

        Using conn As New MySqlConnection(cString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario)
                    cmd.Parameters.AddWithValue("@contraseña", contraseña)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario creado exitosamente.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al crear el usuario: " & ex.Message)
            End Try
        End Using
        Me.Close()
    End Sub

End Class
