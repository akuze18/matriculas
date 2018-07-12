Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class F_NMatric
    Dim msgCaption As String = "SISTEMA MATRICULA"
    Dim source = "Provider=Microsoft.Jet.OLEDB.4.0;" + _
                "Data Source=" + F_menu.source_db

    Private Sub F_NMatric_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        F_menu.Show()
    End Sub

    Private Sub F_NMatric_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Trut.Enabled = True
        Tdv.Enabled = False
        Tnombre.Enabled = False
        DTnacim.Enabled = False
        GroupBox2.Enabled = False
        Btn_guardar.Enabled = False
    End Sub

    Private Sub Trut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Trut.TextChanged
        If String.IsNullOrEmpty(Trut.Text) Then
            Tdv.Enabled = False
            Tdv.Text = String.Empty
            Tnombre.Enabled = False
            Tnombre.Text = String.Empty
            DTnacim.Enabled = False
            GroupBox2.Enabled = False
            Btn_guardar.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNumeric(Trut.Text) Then
            MessageBox.Show("Solo puede ingresar numeros en RUT", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim connection As OleDbConnection
        Dim oledbAdapter As OleDbDataAdapter
        Dim ds As New DataSet
        Dim command As String
        command = "SELECT RUT, dv, nombre, fecha_crea FROM persona WHERE RUT='" + Trut.Text + "'"
        connection = New OleDbConnection(source)
        Try
            connection.Open()
            oledbAdapter = New OleDbDataAdapter(command, connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            connection.Close()
            If ds.Tables(0).Rows.Count = 0 Then
                'MessageBox.Show("Rut ingresado no existe", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tdv.Enabled = True
                Tnombre.Enabled = True
                DTnacim.Enabled = True
                DTnacim.Value = Now
            Else
                For Each fila As DataRow In ds.Tables(0).Rows
                    Tdv.Text = fila.Item("dv")
                    Tnombre.Text = fila.Item("nombre")
                    DTnacim.Value = fila.Item("fecha_crea")
                Next
                Tdv.Enabled = False
                Tnombre.Enabled = False
                DTnacim.Enabled = False
            End If
            GroupBox2.Enabled = True
            DTinicio.Value = Now
            DTfin.Value = DateTimePicker.MaximumDateTime 'DateSerial(9998, 12, 31)
            Btn_guardar.Enabled = True
        Catch ex As Exception
            MsgBox("No se puede abrir la conexión")
        End Try
    End Sub

    Private Sub Pfoto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pfoto.DoubleClick
        Dialogo.Title = "Elija el archivo"
        Dialogo.Filter = "Archivos de Imagen|*.jpg;*.bmp;*.gif"
        Dialogo.ShowDialog()
        If Dialogo.FileName <> "" Then
            Pfoto.Image = Drawing.Bitmap.FromFile(Dialogo.FileName)
            Nimagen.Text = Dialogo.FileName
        Else
            Pfoto.Image = Nothing
            Nimagen.Text = String.Empty
        End If
    End Sub

    Private Sub Btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_guardar.Click
        'revisar campos necesarios
        If String.IsNullOrEmpty(Trut.Text) Then
            MessageBox.Show("Debe indicar el RUT", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Trut.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(Tdv.Text) Then
            MessageBox.Show("Debe indicar el digito verificador", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Tdv.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(Tnombre.Text) Then
            MessageBox.Show("Debe indicar el nombre del usuario", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Tnombre.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(Tnum_cuenta.Text) Then
            MessageBox.Show("Debe indicar el número de la cuenta", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Tnum_cuenta.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(Nimagen.Text) Then
            MessageBox.Show("Debe indicar una imagen para la matricula", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Pfoto.Focus()
            Exit Sub
        End If
        'ingreso los campos a la tabla

        Dim connection As OleDbConnection
        Dim oledbAdapter As OleDbDataAdapter
        Dim myCommand As OleDbCommand
        Dim ds, ds2 As New DataSet
        Dim command As String
        Dim identidad As Integer
        Dim sql_persona, sql_matricula, sql_foto As String
        command = "SELECT count(*) as Campo FROM persona WHERE RUT='" + Trut.Text + "'"
        connection = New OleDbConnection(source)
        Try
            connection.Open()
            oledbAdapter = New OleDbDataAdapter(command, connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            If ds.Tables(0).Rows(0).Item(0) = 0 Then
                'rut no existe por lo que ingresamos persona
                sql_persona = "INSERT INTO persona(RUT,dv,nombre,fecha_crea) " + _
                    "VALUES('" + Trut.Text + "','" + Tdv.Text + "','" + Tnombre.Text + "','" + DTnacim.Value.ToString("dd-MM-yyyy") + "')"
                myCommand = New OleDbCommand(sql_persona, connection)
                myCommand.ExecuteNonQuery()
                
            End If
            'Ahora que sabemos que el rut esta en la bd, ingreso los datos de la matricula
            sql_matricula = "INSERT INTO matricula(persona,num_cuenta,fecha_inicio,fecha_fin,sucursal) " + _
                "VALUES('" + Trut.Text + "','" + Tnum_cuenta.Text + "','" + DTinicio.Value.ToString("dd-MM-yyyy") + "','" + DTfin.Value.ToString("dd-MM-yyyy") + "'," + F_menu.cod_suc.ToString + ")"
            myCommand = New OleDbCommand(sql_matricula, connection)
            myCommand.ExecuteNonQuery()

            oledbAdapter = New OleDbDataAdapter("SELECT @@IDENTITY AS NUMERO", connection)
            oledbAdapter.Fill(ds2)
            oledbAdapter.Dispose()
            identidad = ds2.Tables(0).Rows(0).Item("NUMERO")
            'copiar la imagen al directorio de las fotos
            Dim foto_dir, new_foto, only_foto As String
            foto_dir = F_menu.dir_foto
            'If Not Directory.Exists(foto_dir) Then
            '    Directory.CreateDirectory(foto_dir)
            'End If
            only_foto = Trut.Text + "-" + identidad.ToString + Strings.Right(Nimagen.Text, 4)
            new_foto = foto_dir + only_foto
            If File.Exists(new_foto) Then
                File.Delete(new_foto)
            End If
            File.Copy(Nimagen.Text, new_foto)
            sql_foto = "UPDATE matricula SET foto='" + only_foto + "' WHERE id=" + identidad.ToString
            myCommand = New OleDbCommand(sql_foto, connection)
            myCommand.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("OK", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MsgBox("No se puede abrir la conexión")
        End Try

    End Sub

    Private Sub Tnombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tnombre.LostFocus
        Tnombre.Text = UCase(Tnombre.Text)
    End Sub
End Class
