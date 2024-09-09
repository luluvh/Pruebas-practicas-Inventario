<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarporCategoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarporCategoria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCategorias = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.DataGridViewResultados = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Categorias:"
        '
        'ComboBoxCategorias
        '
        Me.ComboBoxCategorias.FormattingEnabled = True
        Me.ComboBoxCategorias.Location = New System.Drawing.Point(154, 39)
        Me.ComboBoxCategorias.Name = "ComboBoxCategorias"
        Me.ComboBoxCategorias.Size = New System.Drawing.Size(217, 24)
        Me.ComboBoxCategorias.TabIndex = 1
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Silver
        Me.ButtonBuscar.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.Location = New System.Drawing.Point(785, 32)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(83, 37)
        Me.ButtonBuscar.TabIndex = 2
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'DataGridViewResultados
        '
        Me.DataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResultados.Location = New System.Drawing.Point(12, 75)
        Me.DataGridViewResultados.Name = "DataGridViewResultados"
        Me.DataGridViewResultados.RowHeadersWidth = 51
        Me.DataGridViewResultados.RowTemplate.Height = 24
        Me.DataGridViewResultados.Size = New System.Drawing.Size(1001, 497)
        Me.DataGridViewResultados.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(886, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(474, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(388, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'BuscarporCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 584)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridViewResultados)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.ComboBoxCategorias)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarporCategoria"
        Me.Text = "Buscar por Categoria"
        CType(Me.DataGridViewResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCategorias As ComboBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents DataGridViewResultados As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
