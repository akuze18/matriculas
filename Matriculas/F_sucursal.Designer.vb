<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_sucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_sucursal))
        Me.ListSucursal = New System.Windows.Forms.ListBox()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_act = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListSucursal
        '
        Me.ListSucursal.FormattingEnabled = True
        Me.ListSucursal.Location = New System.Drawing.Point(79, 123)
        Me.ListSucursal.Name = "ListSucursal"
        Me.ListSucursal.Size = New System.Drawing.Size(245, 147)
        Me.ListSucursal.TabIndex = 0
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(103, 286)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(86, 24)
        Me.btn_new.TabIndex = 1
        Me.btn_new.Text = "Nueva"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_act
        '
        Me.btn_act.Location = New System.Drawing.Point(206, 286)
        Me.btn_act.Name = "btn_act"
        Me.btn_act.Size = New System.Drawing.Size(85, 24)
        Me.btn_act.TabIndex = 2
        Me.btn_act.Text = "Seleccionar"
        Me.btn_act.UseVisualStyleBackColor = True
        '
        'F_sucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.user_matricula.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(417, 344)
        Me.Controls.Add(Me.btn_act)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.ListSucursal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_sucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Sucursal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListSucursal As System.Windows.Forms.ListBox
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_act As System.Windows.Forms.Button
End Class
