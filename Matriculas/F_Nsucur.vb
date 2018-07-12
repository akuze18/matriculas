Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class F_Nsucur
    Dim msgCaption As String = "SISTEMA MATRICULA"
    Dim source = "Provider=Microsoft.Jet.OLEDB.4.0;" + _
                "Data Source=" + F_menu.source_db


    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        If String.IsNullOrEmpty(Tnombre.Text) Then
            MessageBox.Show("Debe ingresar el nombre de la nueva sucursal", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Tnombre.Focus()
            Exit Sub
        End If
        Dim connection As OleDbConnection
        'Dim oledbAdapter As OleDbDataAdapter
        Dim myCommand As OleDbCommand
        Dim ds As New DataSet
        Dim comando_new, nombre, direccion As String
        connection = New OleDbConnection(source)
        nombre = Replace(Replace(Trim(Tnombre.Text), Chr(13), ""), Chr(10), "")
        direccion = Replace(Replace(Trim(Tdireccion.Text), Chr(13), ""), Chr(10), "")
        Try
            connection.Open()
            comando_new = "INSERT INTO sucursal(nombre,direccion,activa) VALUES('" + nombre + "','" + direccion + "',0)"
            myCommand = New OleDbCommand(comando_new, connection)
            myCommand.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Se cambio la sucursal correctamente", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            F_sucursal.cargar_sucursales()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al selecccionar sucursal", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class