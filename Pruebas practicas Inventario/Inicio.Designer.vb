<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btneliminarUsuario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(60, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Usuario Existente"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(387, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Crear nuevo usuario"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btneliminarUsuario
        '
        Me.btneliminarUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btneliminarUsuario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminarUsuario.Location = New System.Drawing.Point(255, 392)
        Me.btneliminarUsuario.Name = "btneliminarUsuario"
        Me.btneliminarUsuario.Size = New System.Drawing.Size(165, 32)
        Me.btneliminarUsuario.TabIndex = 8
        Me.btneliminarUsuario.Text = "Eliminar usuario"
        Me.btneliminarUsuario.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Pruebas_practicas_Inventario.My.Resources.Resources.Logo_Meso_Color_medio
        Me.PictureBox1.Location = New System.Drawing.Point(195, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(682, 436)
        Me.Controls.Add(Me.btneliminarUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btneliminarUsuario As Button
End Class
