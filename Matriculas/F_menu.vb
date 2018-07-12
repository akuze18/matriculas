Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class F_menu
    Dim app_path As String
    Dim file_dir As String
    Dim foto_dir As String
    Dim daba_nam As String
    Dim act_sucu As String
    Dim num_sucu As Integer
    Dim msgCaption As String = "SISTEMA MATRICULA"
    Dim source As String

    Private Sub F_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        app_path = System.AppDomain.CurrentDomain.BaseDirectory()
        file_dir = app_path + "Matriculas_Archivos\"
        If Not Directory.Exists(file_dir) Then
            Directory.CreateDirectory(file_dir)
        End If
        foto_dir = file_dir + "fotos\"
        If Not Directory.Exists(foto_dir) Then
            Directory.CreateDirectory(foto_dir)
        End If
        daba_nam = file_dir + "datos.mdb"
        If Not File.Exists(daba_nam) Then
            File.WriteAllBytes(daba_nam, My.Resources.datos)
        End If
        'revisar la sucursal activa en BD
        Dim connection As OleDbConnection
        Dim oledbAdapter As OleDbDataAdapter
        Dim ds As New DataSet
        Dim comando As String
        source = "Provider=Microsoft.Jet.OLEDB.4.0;" + _
                "Data Source=" + daba_nam
        connection = New OleDbConnection(source)
        comando = "SELECT Id,nombre,direccion,activa FROM sucursal WHERE activa=-1"    '
        Try
            connection.Open()
            oledbAdapter = New OleDbDataAdapter(comando, connection)
            oledbAdapter.Fill(ds)
            oledbAdapter.Dispose()
            connection.Close()
            If ds.Tables(0).Rows.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    act_sucu = fila("nombre")
                    num_sucu = fila("Id")
                Next
            Else
                MessageBox.Show("No hay sucursal disponible", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                act_sucu = ""
                num_sucu = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar sucursal", msgCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            act_sucu = ""
            num_sucu = 0
        End Try
        Lsucursal.Text = "Sucursal " + act_sucu
    End Sub

    Public ReadOnly Property dir_aplicacion As String
        Get
            Return app_path
        End Get
    End Property
    Public ReadOnly Property dir_foto As String
        Get
            Return foto_dir
        End Get
    End Property
    Public ReadOnly Property source_db As String
        Get
            Return daba_nam
        End Get
    End Property
    Public ReadOnly Property sucursal As String
        Get
            Return act_sucu
        End Get
    End Property
    Public ReadOnly Property cod_suc As Integer
        Get
            Return num_sucu
        End Get
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        F_NMatric.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        F_matricula.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        F_sucursal.Show()
        Me.Hide()
    End Sub

    Public Sub actualizar_sucursal(ByVal nueva_sucursal As list_sucursal)
        act_sucu = nueva_sucursal.texto
        num_sucu = nueva_sucursal.indice
        Lsucursal.Text = "Sucursal " + nueva_sucursal.ToString
    End Sub
End Class