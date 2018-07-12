<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Nsucur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Nsucur))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Tdireccion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(104, 206)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(108, 29)
        Me.btn_new.TabIndex = 3
        Me.btn_new.Text = "Crear Sucursal"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(79, 128)
        Me.Tnombre.MaxLength = 150
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(231, 20)
        Me.Tnombre.TabIndex = 4
        '
        'Tdireccion
        '
        Me.Tdireccion.Location = New System.Drawing.Point(80, 171)
        Me.Tdireccion.MaxLength = 255
        Me.Tdireccion.Name = "Tdireccion"
        Me.Tdireccion.Size = New System.Drawing.Size(230, 20)
        Me.Tdireccion.TabIndex = 5
        '
        'F_Nsucur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.user_matricula.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(332, 249)
        Me.Controls.Add(Me.Tdireccion)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Nsucur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Sucursal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Tdireccion As System.Windows.Forms.TextBox
End Class
