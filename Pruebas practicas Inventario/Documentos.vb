Imports MySql.Data.MySqlClient

Public Class BuscarporCategoria

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim nombreBusqueda As String = TextBox1.Text.Trim()
        If ComboBoxCategorias.SelectedIndex <> -1 Then
            Dim seleccion As String = ComboBoxCategorias.SelectedItem.ToString()
            Dim id_categoria As Integer = Integer.Parse(seleccion.Split("-"c)(0).Trim())

            Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"
            Dim conn As New MySqlConnection(cString)

            Try
                conn.Open()
                Dim sQuery As String = "SELECT id_categorias, fecha, estudiante, dirigido_a, descripcion " &
                                       "FROM Documentos " &
                                       "WHERE id_categorias = @id_categorias AND " &
                                       "(estudiante LIKE @nombre_busqueda OR dirigido_a LIKE @nombre_busqueda);"
                Dim da As New MySqlDataAdapter(sQuery, conn)
                da.SelectCommand.Parameters.AddWithValue("@id_categorias", id_categoria)
                da.SelectCommand.Parameters.AddWithValue("@nombre_busqueda", "%" & nombreBusqueda & "%")

                Dim dt As New DataTable
                da.Fill(dt)
                DataGridViewResultados.DataSource = dt
                DataGridViewResultados.Refresh()
                DataGridViewResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Catch ex As Exception
                MessageBox.Show("Error al realizar la búsqueda: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Seleccione una categoría para buscar.")
        End If
    End Sub

    Sub CargarCategorias()
        Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"
        Dim conn As New MySqlConnection(cString)
        Try
            conn.Open()
            Dim sQuery As String = "SELECT * FROM Categorias;"
            Dim da As New MySqlDataAdapter(sQuery, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    Dim fila As DataRow = dt.Rows(i)
                    ComboBoxCategorias.Items.Add(fila("id_categorias") & "- " & fila("nombre_categoria").ToString())
                Next
            Else
                MessageBox.Show("No se encontraron categorías.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorías: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BuscarDocumentosPorCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class
