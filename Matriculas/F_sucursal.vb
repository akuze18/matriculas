Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class F_sucursal
    Dim msgCaption As String = "SISTEMA MATRICULA"
    Dim source = "Provider=Microsoft.Jet.OLEDB.4.0;" + _
                "Data Source=" + F_menu.source_db

    Private Sub F_sucursal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        F_menu.Show()
    End Sub

    Private Sub F_sucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_sucursales
    End Sub

    Public Sub cargar_sucursales()
        Dim connection As OleDbConnection
        Dim oledbAdapter As OleDbDataAdapter
        Dim ds As New DataSet
        Dim comando As String
        connection = New OleDbConnection(source)
        comando = "SELECT Id,nombre,direccion,activa FROM sucursal order by nombre"
        Try
            connection.Open()
            oledbAdapter = New OleDbDataAdapter(comando, connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            connection.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                ListSucursal.Items.Clear()
                For Each fila As DataRow In ds.Tables(0).Rows
                    ListSucursal.Items.Add(New list_sucursal(fila("Id"), fila("nombre") + " " + fila("direccion")))
                    If fila("activa") Then
                        ListSucursal.SelectedIndex = ListSucursal.Items.Count - 1
                    End If
                Next
            Else
                MessageBox.Show("No hay sucursal disponible", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ListSucursal.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar sucursal", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            ListSucursal.Items.Clear()
        End Try
    End Sub

    Private Sub btn_act_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_act.Click
        Dim sel_elemento As list_sucursal
        sel_elemento = CType(ListSucursal.SelectedItem, list_sucursal)

        Dim connection As OleDbConnection
        'Dim oledbAdapter As OleDbDataAdapter
        Dim myCommand As OleDbCommand
        Dim ds As New DataSet
        Dim comando_clear, comando_set As String
        connection = New OleDbConnection(source)
        Try
            connection.Open()
            comando_clear = "UPDATE sucursal SET activa=0"
            myCommand = New OleDbCommand(comando_clear, connection)
            myCommand.ExecuteNonQuery()
            comando_set = "UPDATE sucursal SET activa=-1 WHERE Id=" + sel_elemento.indice.ToString
            myCommand = New OleDbCommand(comando_set, connection)
            myCommand.ExecuteNonQuery()
            connection.Close()
            F_menu.actualizar_sucursal(sel_elemento)
            MessageBox.Show("Se cambio la sucursal correctamente", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al selecccionar sucursal", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        F_Nsucur.Show()
    End Sub
End Class

Public Class list_sucursal
    Dim Contenido As String
    Dim Index As Integer

    Public Sub New(ByVal i As Integer, ByVal c As String)
        Contenido = c
        Index = i
    End Sub
    Public Overrides Function ToString() As String
        Return Contenido
    End Function
    Public ReadOnly Property texto As String
        Get
            Return Contenido
        End Get
    End Property
    Public ReadOnly Property indice As Integer
        Get
            Return Index
        End Get
    End Property
End Class