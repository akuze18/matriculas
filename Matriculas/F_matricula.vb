Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class F_matricula
    Dim msgCaption As String = "SISTEMA MATRICULA"
    Dim source = "Provider=Microsoft.Jet.OLEDB.4.0;" + _
                "Data Source=" + F_menu.source_db

    Private Sub F_matricula_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        F_menu.Show()
    End Sub

    Private Sub F_matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tdv.Enabled = False
        Tnombre.Enabled = False
        Dim origen_datos As New DataTable
        origen_datos.Columns.Add("Codigo Matricula", Type.GetType("System.Int32"))
        origen_datos.Columns.Add("Numero Cuenta", Type.GetType("System.String"))
        origen_datos.Columns.Add("Fecha Apertura", Type.GetType("System.DateTime"))
        origen_datos.Columns.Add("Fecha Fin", Type.GetType("System.DateTime"))
        origen_datos.Columns.Add("foto", Type.GetType("System.String"))
        origen_datos.Columns.Add("cod_sucursal", Type.GetType("System.Int32"))
        origen_datos.Columns.Add("Sucursal", Type.GetType("System.String"))
        DGmatriculas.DataSource = origen_datos
        DGmatriculas.RowHeadersWidth = 20
        DGmatriculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGmatriculas.MultiSelect = False
        DGmatriculas.Columns(0).Visible = False
        DGmatriculas.Columns(1).Width = 120
        DGmatriculas.Columns(2).Width = 80
        DGmatriculas.Columns(3).Visible = False
        DGmatriculas.Columns(4).Visible = False
        DGmatriculas.Columns(5).Visible = False
        DGmatriculas.Columns(6).Width = 80
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If String.IsNullOrEmpty(Trut.Text) Then
            MessageBox.Show("Debe indicar un RUT para buscar", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Trut.Focus()
            Exit Sub
        End If
        If Not IsNumeric(Trut.Text) Then
            MessageBox.Show("Solo puede ingresar numeros en el RUT", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Trut.Focus()
            Trut.SelectionStart = 0
            Trut.SelectionLength = Trut.Text.Length
            Exit Sub
        End If

        Dim connection As OleDbConnection
        Dim oledbAdapter As OleDbDataAdapter
        Dim ds As New DataSet
        Dim command, sql_matricula As String
        command = "SELECT RUT, dv, nombre, fecha_crea FROM persona WHERE RUT='" + Trut.Text + "'"
        connection = New OleDbConnection(source)
        Try
            connection.Open()
            oledbAdapter = New OleDbDataAdapter(command, connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            connection.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    Tdv.Text = fila.Item("dv")
                    Tnombre.Text = fila.Item("nombre")
                    'DTnacim.Value = fila.Item("fecha_crea")
                Next
                Tdv.Enabled = False
                Tnombre.Enabled = False
            Else
                MessageBox.Show("RUT no ha sido encontrado", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Tdv.Text = String.Empty
                Tnombre.Text = String.Empty
                DGmatriculas.DataSource.Rows.Clear()
                Pfoto.Image = Nothing
                Exit Sub
            End If
            sql_matricula = "SELECT Id, num_cuenta, fecha_inicio, fecha_fin, foto, sucursal, (SELECT nombre FROM sucursal WHERE sucursal.id=matricula.sucursal) as nam_suc FROM matricula WHERE persona = '" + Trut.Text + "'"
            connection.Open()
            oledbAdapter = New OleDbDataAdapter(sql_matricula, connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            connection.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                Dim origen_data As DataTable
                origen_data = DGmatriculas.DataSource
                origen_data.Rows.Clear()
                For Each fila As DataRow In ds.Tables(0).Rows
                    If Not IsDBNull(fila.Item("Id")) Then
                        Dim newfila As DataRow = origen_data.NewRow
                        newfila(0) = fila.Item("Id")
                        newfila(1) = fila.Item("num_cuenta")
                        newfila(2) = fila.Item("fecha_inicio")
                        newfila(3) = fila.Item("fecha_fin")
                        newfila(4) = fila.Item("foto")
                        newfila(5) = fila.Item("sucursal")
                        newfila(6) = fila.Item("nam_suc")
                        origen_data.Rows.Add(newfila)
                    End If
                Next
                DGmatriculas.ClearSelection()
                Pfoto.Image = Nothing
            Else
                MessageBox.Show("RUT no tiene matriculas asociadas", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("No se puede abrir la conexión")
        End Try
    End Sub

    Private Sub DGmatriculas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGmatriculas.CellClick
        Dim sel_foto As String
        For Each Sfila As DataGridViewRow In DGmatriculas.SelectedRows
            sel_foto = Sfila.Cells(4).Value
            Pfoto.Image = Drawing.Bitmap.FromFile(F_menu.dir_foto + sel_foto)
            Nimagen.Text = sel_foto
        Next
    End Sub

    Private Sub Pfoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pfoto.DoubleClick
        If Not IsNothing(Pfoto.Image) Then
            If ckAction.Checked Then
                Dim extension, filtro As String
                extension = UCase(Strings.Right(Nimagen.Text, 3))
                SaveDialogo.Title = "Elija ubicación para el archivo"
                Select Case extension
                    Case "JPG"
                        filtro = "Imagen JPeg|*.jpg"
                    Case "BMP"
                        filtro = "Imagen Bitmap|*.bmp"
                    Case "GIF"
                        filtro = "Imagen Gif|*.gif"
                    Case Else
                        filtro = "Imagen JPeg|*.jpg|Imagen Bitmap|*.bmp|Imagen Gif|*.gif"
                End Select
                SaveDialogo.Filter = filtro
                SaveDialogo.FileName = Nimagen.Text

                If SaveDialogo.FileName <> "" And (SaveDialogo.ShowDialog = Windows.Forms.DialogResult.OK) Then
                    File.Copy(F_menu.dir_foto + Nimagen.Text, SaveDialogo.FileName)
                    MessageBox.Show("Se ha copiado la imagen existosamente", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                My.Computer.Clipboard.SetImage(Pfoto.Image)

                'Dim mostrar_foto As New Form
                'mostrar_foto.StartPosition = FormStartPosition.CenterScreen
                'mostrar_foto.WindowState = FormWindowState.Maximized
                'mostrar_foto.BackgroundImage = Pfoto.Image
                'mostrar_foto.BackgroundImageLayout = ImageLayout.Stretch
                'mostrar_foto.Icon = Me.Icon
                'mostrar_foto.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                'mostrar_foto.ShowInTaskbar = False

                'mostrar_foto.Show()
                'SendKeys.SendWait("%{PRTSC}")

                'mostrar_foto.Close()
                MessageBox.Show("Imagen copiada al portapapeles", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class