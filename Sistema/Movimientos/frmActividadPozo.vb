Imports System.Data.SqlClient
Public Class frmActividadPozo
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Private Sub frmActividadPozo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        Dim comando As New SqlCommand("", conexion)
        Dim lector As SqlDataReader
        llenarPozo()
        comando.CommandText = "select ActividadPozo.idActividad, ActividadPozo.idPozo, Pozos.ubicacion, ActividadPozo.fecha, ActividadPozo.hora, ActividadPozo.lectura, ActividadPozo.observaciones from ActividadPozo inner join Pozos on ActividadPozo.idPozo = Pozos.idPozo"
        lector = comando.ExecuteReader
        While lector.Read
            dgActividadPozo.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.ActividadPozo' Puede moverla o quitarla según sea necesario.
        Me.ActividadPozoTableAdapter.Fill(Me.DataSetSistema.ActividadPozo)

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        mtbHora.Enabled = True
        mtbLectura.Enabled = True
        mtbObservaciones.Enabled = True
        cbPozo.Enabled = True
        dtpFecha.Enabled = True
        Dim comando As New SqlCommand("Select count(*) from ActividadPozo", conexion)
        Dim n As Integer
        n = comando.ExecuteScalar() + 1
        mtbidActividad.Text = n
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not mtbidPozo.Text.Equals("") And Not mtbHora.Text.Equals("  :") And Not mtbLectura.Text.Equals("") And Not mtbObservaciones.Text.Equals("") Then
            cmdNuevo.Enabled = True
            cmdGrabar.Enabled = False
            Dim idActividad As Integer
            Dim idPozo As Integer
            Dim fecha As Date
            Dim hora As String
            Dim lectura As String
            Dim observaciones As String
            Dim r As String
            idActividad = Val(mtbidActividad.Text)
            idPozo = 1
            'c2 = Val(mtbidPozo.Text)
            fecha = dtpFecha.Value.Date
            hora = mtbHora.Text
            lectura = mtbLectura.Text
            observaciones = mtbObservaciones.Text
            r = "insert into ActividadPozo values(" & idActividad & "," & idPozo & ",'" & fecha & "','" & hora & "','" & lectura & "','" & observaciones & "')"
            Dim comando As New SqlCommand(r, conexion)
            comando.ExecuteNonQuery()
            dtpFecha.Value = Today
            mtbHora.Text = ""
            mtbidActividad.Text = ""
            mtbidPozo.Text = ""
            mtbLectura.Text = ""
            mtbObservaciones.Text = ""
            llenarPozo()
        Else
            MsgBox("Asegure no dejar algún campo vacío.")
        End If

    End Sub

    Private Sub llenarPozo()
        cbPozo.Items.Clear()
        Dim comando As New SqlCommand("Select * from pozos", conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        While lector.Read
            cbPozo.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub cbPozo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPozo.SelectedIndexChanged
        Dim r As String
        r = "select * from pozos where ubicacion = '" & cbPozo.Text & "'"
        Dim comando As New SqlCommand(r, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        mtbidPozo.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class