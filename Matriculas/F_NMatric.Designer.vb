<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_NMatric
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_NMatric))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Trut = New System.Windows.Forms.TextBox()
        Me.Tdv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTnacim = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTfin = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tnum_cuenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Nimagen = New System.Windows.Forms.TextBox()
        Me.Pfoto = New System.Windows.Forms.PictureBox()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.Dialogo = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Pfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT"
        '
        'Trut
        '
        Me.Trut.Location = New System.Drawing.Point(83, 31)
        Me.Trut.MaxLength = 9
        Me.Trut.Name = "Trut"
        Me.Trut.Size = New System.Drawing.Size(133, 20)
        Me.Trut.TabIndex = 1
        '
        'Tdv
        '
        Me.Tdv.Location = New System.Drawing.Point(238, 31)
        Me.Tdv.MaxLength = 1
        Me.Tdv.Name = "Tdv"
        Me.Tdv.Size = New System.Drawing.Size(23, 20)
        Me.Tdv.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre"
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(83, 64)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(254, 20)
        Me.Tnombre.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Nacimiento"
        Me.Label4.Visible = False
        '
        'DTnacim
        '
        Me.DTnacim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTnacim.Location = New System.Drawing.Point(520, 64)
        Me.DTnacim.Name = "DTnacim"
        Me.DTnacim.Size = New System.Drawing.Size(128, 20)
        Me.DTnacim.TabIndex = 8
        Me.DTnacim.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Apertura"
        '
        'DTinicio
        '
        Me.DTinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTinicio.Location = New System.Drawing.Point(156, 37)
        Me.DTinicio.Name = "DTinicio"
        Me.DTinicio.Size = New System.Drawing.Size(127, 20)
        Me.DTinicio.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fecha Vencimiento"
        Me.Label6.Visible = False
        '
        'DTfin
        '
        Me.DTfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTfin.Location = New System.Drawing.Point(134, 179)
        Me.DTfin.Name = "DTfin"
        Me.DTfin.Size = New System.Drawing.Size(127, 20)
        Me.DTfin.TabIndex = 3
        Me.DTfin.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DTnacim)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tnombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Tdv)
        Me.GroupBox1.Controls.Add(Me.Trut)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Persona"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.user_matricula.My.Resources.Resources.encontrar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(305, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Tnum_cuenta)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Nimagen)
        Me.GroupBox2.Controls.Add(Me.Pfoto)
        Me.GroupBox2.Controls.Add(Me.DTfin)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DTinicio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(720, 218)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Matrícula"
        '
        'Tnum_cuenta
        '
        Me.Tnum_cuenta.Location = New System.Drawing.Point(156, 65)
        Me.Tnum_cuenta.MaxLength = 100
        Me.Tnum_cuenta.Name = "Tnum_cuenta"
        Me.Tnum_cuenta.Size = New System.Drawing.Size(126, 20)
        Me.Tnum_cuenta.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Número de Cuenta"
        '
        'Nimagen
        '
        Me.Nimagen.Location = New System.Drawing.Point(273, 182)
        Me.Nimagen.Name = "Nimagen"
        Me.Nimagen.Size = New System.Drawing.Size(44, 20)
        Me.Nimagen.TabIndex = 13
        Me.Nimagen.Visible = False
        '
        'Pfoto
        '
        Me.Pfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pfoto.Location = New System.Drawing.Point(327, 19)
        Me.Pfoto.Name = "Pfoto"
        Me.Pfoto.Size = New System.Drawing.Size(378, 183)
        Me.Pfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pfoto.TabIndex = 12
        Me.Pfoto.TabStop = False
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Location = New System.Drawing.Point(317, 515)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(82, 32)
        Me.Btn_guardar.TabIndex = 2
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.UseVisualStyleBackColor = True
        '
        'Dialogo
        '
        Me.Dialogo.FileName = "OpenFileDialog1"
        '
        'F_NMatric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.user_matricula.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 556)
        Me.Controls.Add(Me.Btn_guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_NMatric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Matricula de Ahorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Pfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Trut As System.Windows.Forms.TextBox
    Friend WithEvents Tdv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTnacim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Pfoto As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Dialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Nimagen As System.Windows.Forms.TextBox
    Friend WithEvents Tnum_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
