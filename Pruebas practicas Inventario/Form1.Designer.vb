<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(157, 52)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(201, 22)
        Me.Txtusuario.TabIndex = 2
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(157, 110)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(201, 22)
        Me.txtcontraseña.TabIndex = 3
        Me.txtcontraseña.Tag = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(384, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 176)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.Txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Button1 As Button
End Class
