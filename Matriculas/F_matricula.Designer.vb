<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_matricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_matricula))
        Me.Trut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tdv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.DGmatriculas = New System.Windows.Forms.DataGridView()
        Me.Nimagen = New System.Windows.Forms.Label()
        Me.SaveDialogo = New System.Windows.Forms.SaveFileDialog()
        Me.Pfoto = New System.Windows.Forms.PictureBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.ckAction = New System.Windows.Forms.CheckBox()
        CType(Me.DGmatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Trut
        '
        Me.Trut.Location = New System.Drawing.Point(95, 118)
        Me.Trut.MaxLength = 9
        Me.Trut.Name = "Trut"
        Me.Trut.Size = New System.Drawing.Size(116, 20)
        Me.Trut.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(217, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "-"
        '
        'Tdv
        '
        Me.Tdv.Location = New System.Drawing.Point(233, 118)
        Me.Tdv.Name = "Tdv"
        Me.Tdv.Size = New System.Drawing.Size(28, 20)
        Me.Tdv.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(96, 148)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(337, 20)
        Me.Tnombre.TabIndex = 5
        '
        'DGmatriculas
        '
        Me.DGmatriculas.AllowUserToAddRows = False
        Me.DGmatriculas.AllowUserToDeleteRows = False
        Me.DGmatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGmatriculas.Location = New System.Drawing.Point(21, 185)
        Me.DGmatriculas.Name = "DGmatriculas"
        Me.DGmatriculas.ReadOnly = True
        Me.DGmatriculas.Size = New System.Drawing.Size(314, 170)
        Me.DGmatriculas.TabIndex = 7
        '
        'Nimagen
        '
        Me.Nimagen.AutoSize = True
        Me.Nimagen.Location = New System.Drawing.Point(574, 169)
        Me.Nimagen.Name = "Nimagen"
        Me.Nimagen.Size = New System.Drawing.Size(39, 13)
        Me.Nimagen.TabIndex = 9
        Me.Nimagen.Text = "Label4"
        Me.Nimagen.Visible = False
        '
        'Pfoto
        '
        Me.Pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pfoto.Location = New System.Drawing.Point(341, 185)
        Me.Pfoto.Name = "Pfoto"
        Me.Pfoto.Size = New System.Drawing.Size(287, 170)
        Me.Pfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pfoto.TabIndex = 8
        Me.Pfoto.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.user_matricula.My.Resources.Resources.encontrar
        Me.btn_buscar.Location = New System.Drawing.Point(466, 118)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(58, 50)
        Me.btn_buscar.TabIndex = 6
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'ckAction
        '
        Me.ckAction.AutoSize = True
        Me.ckAction.Location = New System.Drawing.Point(573, 148)
        Me.ckAction.Name = "ckAction"
        Me.ckAction.Size = New System.Drawing.Size(55, 17)
        Me.ckAction.TabIndex = 10
        Me.ckAction.Text = "action"
        Me.ckAction.UseVisualStyleBackColor = True
        Me.ckAction.Visible = False
        '
        'F_matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.user_matricula.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(640, 365)
        Me.Controls.Add(Me.ckAction)
        Me.Controls.Add(Me.Nimagen)
        Me.Controls.Add(Me.Pfoto)
        Me.Controls.Add(Me.DGmatriculas)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tdv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Trut)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_matricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Matriculas de Ahorro"
        CType(Me.DGmatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Trut As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tdv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents DGmatriculas As System.Windows.Forms.DataGridView
    Friend WithEvents Pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Nimagen As System.Windows.Forms.Label
    Friend WithEvents SaveDialogo As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ckAction As System.Windows.Forms.CheckBox
End Class
