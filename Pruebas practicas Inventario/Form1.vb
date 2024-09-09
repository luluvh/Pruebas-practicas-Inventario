Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Código de inicialización si es necesario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = Txtusuario.Text
        Dim contraseña As String = txtcontraseña.Text

        ' Validar que el usuario y contraseña no estén vacíos
        If String.IsNullOrWhiteSpace(usuario) Or String.IsNullOrWhiteSpace(contraseña) Then
            MsgBox("Por favor ingrese usuario y contraseña.")
            Return
        End If

        ' Validar las credenciales del usuario
        If ValidarCredenciales(usuario, contraseña) Then
            Form2.Show()
        Else
            MsgBox("Los datos son incorrectos, inténtelo nuevamente.")
        End If
    End Sub

    Private Function ValidarCredenciales(ByVal usuario As String, ByVal contraseña As String) As Boolean
        Dim sQuery As String = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND contraseña = @contraseña;"
        Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"

        Using conn As New MySqlConnection(cString)
            Try
                conn.Open()
                Using cm As New MySqlCommand(sQuery, conn)
                    cm.Parameters.AddWithValue("@usuario", usuario)
                    cm.Parameters.AddWithValue("@contraseña", contraseña) ' Considera encriptar la contraseña antes de comparar

                    Dim count As Integer = Convert.ToInt32(cm.ExecuteScalar())
                    Return count > 0
                End Using
            Catch ex As Exception
                MsgBox("Error al validar las credenciales: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    ' Método para crear un nuevo usuario en la base de datos
    Private Sub CrearUsuario(ByVal nombreUsuario As String, ByVal contraseña As String)
        Dim query As String = "INSERT INTO usuarios (usuario, contraseña) VALUES (@usuario, @contraseña)"
        Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"

        Using conn As New MySqlConnection(cString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario)
                    cmd.Parameters.AddWithValue("@contraseña", contraseña) ' Considera encriptar la contraseña antes de guardarla
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario creado exitosamente.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al crear el usuario: " & ex.Message)
            End Try
        End Using
    End Sub
End Class



