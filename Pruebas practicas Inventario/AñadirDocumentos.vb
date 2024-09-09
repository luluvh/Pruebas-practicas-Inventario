Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class AñadirDocumentos
    Dim bandera As Integer = -1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form2.Show()
    End Sub

    Sub CargarCategorias()
        Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"
        Dim conn As New MySqlConnection(cString)
        Try
            conn.Open()
            Dim sQuery As String = "SELECT * FROM inventariomeso.categorias;"
            Dim da As New MySqlDataAdapter(sQuery, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    Dim fila As DataRow = dt.Rows(i)
                    ComboBox1.Items.Add(fila("id_categorias") & "- " & fila("nombre_categoria").ToString())
                Next
            Else
                MessageBox.Show("El registro no Existe")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AñadirDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        CargarDatos()
    End Sub

    Sub CargarDatos()
        Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"
        Dim conn As New MySqlConnection(cString)
        Try
            conn.Open()

            Dim sQuery As String = "SELECT Documentos.id_documentos, Documentos.fecha, Documentos.estudiante, Documentos.dirigido_a, " &
                                   "Documentos.descripcion, Categorias.nombre_categoria FROM Documentos " &
                                   "INNER JOIN Categorias ON Documentos.id_categorias = Categorias.id_categorias;"
            Dim da As New MySqlDataAdapter(sQuery, conn)
            Dim dt As New DataTable
            da.Fill(dt)



            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha, estudiante, dirigido_a, descripcion As String
        fecha = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        estudiante = TextBox1.Text
        dirigido_a = TextBox2.Text
        descripcion = TextBox3.Text

        If ComboBox1.SelectedIndex = -1 OrElse fecha = "" OrElse estudiante = "" OrElse dirigido_a = "" OrElse descripcion = "" Then
            MessageBox.Show("Todos los campos deben estar completos")
        Else

            Dim seleccion As String = ComboBox1.SelectedItem.ToString()
            Dim id_categoria As Integer = Integer.Parse(seleccion.Split("-"c)(0).Trim())

            Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"
            Dim conn As New MySqlConnection(cString)

            Try
                conn.Open()
                Dim cm As New MySqlCommand
                Dim sQuery As String

                If bandera = -1 Then
                    sQuery = "INSERT INTO Documentos (id_categorias, fecha, estudiante, dirigido_a, descripcion) VALUES (@id_categorias, @fecha, @estudiante, @dirigido_a, @descripcion)"
                Else
                    sQuery = "UPDATE Documentos SET id_categorias=@id_categorias, fecha=@fecha, estudiante=@estudiante, dirigido_a=@dirigido_a, descripcion=@descripcion WHERE id_documentos=@id_documentos"
                End If

                cm.Connection = conn
                cm.CommandText = sQuery
                cm.Parameters.AddWithValue("@id_categorias", id_categoria)
                cm.Parameters.AddWithValue("@fecha", fecha)
                cm.Parameters.AddWithValue("@estudiante", estudiante)
                cm.Parameters.AddWithValue("@dirigido_a", dirigido_a)
                cm.Parameters.AddWithValue("@descripcion", descripcion)

                If bandera <> -1 Then
                    cm.Parameters.AddWithValue("@id_documentos", bandera)
                End If

                cm.ExecuteNonQuery()
                MessageBox.Show("Guardado con éxito")
                CargarDatos()
                Limpiar()
                bandera = -1
                Button1.Text = "Guardar"
                Button2.Enabled = False
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Sub Limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("¿Desea eliminar el documento?" & vbCrLf & "Esta acción es permanente", "Eliminar Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim cString As String = "server=localhost;user=root;database=InventarioMeso;port=3306;password=CVO2024;"
            Dim conn As New MySqlConnection(cString)
            Try
                conn.Open()
                Dim cm As New MySqlCommand
                Dim sQuery As String = "DELETE FROM inventariomeso.documentos WHERE id_documentos = @id_documentos"
                cm.Connection = conn
                cm.CommandText = sQuery
                cm.Parameters.AddWithValue("@id_documentos", bandera)
                cm.ExecuteNonQuery()
                MessageBox.Show("Eliminado con éxito")
                conn.Close()
                CargarCategorias()
                Limpiar()
                bandera = -1
                Button1.Text = "Guardar"
            Catch ex As Exception
                MessageBox.Show("Error al eliminar: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            Try
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                bandera = Convert.ToInt32(row.Cells("id_documentos").Value)
                DateTimePicker1.Value = Convert.ToDateTime(row.Cells("fecha").Value)
                TextBox1.Text = row.Cells("estudiante").Value.ToString()
                TextBox2.Text = row.Cells("dirigido_a").Value.ToString()
                TextBox3.Text = row.Cells("descripcion").Value.ToString()

                ' Buscar el índice en el ComboBox correspondiente al nombre de la categoría
                Dim nombreCategoria As String = row.Cells("nombre_categoria").Value.ToString()
                ComboBox1.SelectedIndex = ComboBox1.FindStringExact(nombreCategoria)

                Button1.Text = "Modificar"
                Button2.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error al seleccionar datos: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
    End Sub
End Class
