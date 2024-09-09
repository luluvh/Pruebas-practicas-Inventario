<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtconfirmarcontraseña = New System.Windows.Forms.TextBox()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirmar contraseña:"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(273, 70)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(184, 22)
        Me.txtusuario.TabIndex = 4
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(273, 114)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(184, 22)
        Me.txtcontraseña.TabIndex = 5
        '
        'txtconfirmarcontraseña
        '
        Me.txtconfirmarcontraseña.Location = New System.Drawing.Point(273, 160)
        Me.txtconfirmarcontraseña.Name = "txtconfirmarcontraseña"
        Me.txtconfirmarcontraseña.Size = New System.Drawing.Size(184, 22)
        Me.txtconfirmarcontraseña.TabIndex = 6
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario.Location = New System.Drawing.Point(512, 183)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(135, 32)
        Me.btnCrearUsuario.TabIndex = 7
        Me.btnCrearUsuario.Text = "Crear usuario"
        Me.btnCrearUsuario.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pruebas_practicas_Inventario.My.Resources.Resources.Captura_de_pantalla_2024_09_04_091524
        Me.PictureBox1.Location = New System.Drawing.Point(506, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'CrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 245)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.txtconfirmarcontraseña)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrearUsuario"
        Me.Text = "Crear Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents txtconfirmarcontraseña As TextBox
    Friend WithEvents btnCrearUsuario As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
