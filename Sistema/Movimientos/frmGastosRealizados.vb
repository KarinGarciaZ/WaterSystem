Imports System.Data.SqlClient
Public Class frmGastosRealizados

    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader

    Private Sub frmGastosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbConceptoConsulta.Visible = False
        cbEmpleadoConsulta.Visible = False
        dtpFechaConsulta.Visible = False
        conexion.Open()
        llenar()
    End Sub

    Private Sub llenar()
        cbEmpleado.Items.Clear()
        cbConceptoGasto.Items.Clear()
        cbEmpleadoConsulta.Items.Clear()
        cbConceptoConsulta.Items.Clear()
        comando.CommandText = "select * from Empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cbEmpleado.Items.Add(lector(1))
            cbEmpleadoConsulta.Items.Add(lector(1))
        End While
        lector.Close()
        comando.CommandText = "select * from Gastos"
        lector = comando.ExecuteReader
        While lector.Read
            cbConceptoGasto.Items.Add(lector(1))
            cbConceptoConsulta.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dtpFecha.Enabled = True
        cbEmpleado.Enabled = True
        cbConceptoGasto.Enabled = True
        mtbImporte.Enabled = True
        mtbObservaciones.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
        comando.CommandText = "Select count(*) from GastosRealizados"
        Dim n As Integer
        n = comando.ExecuteScalar() + 1
        mtbidGastoR.Text = n
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If Not mtbidEmpleado.Text.Equals("") And Not mtbidGasto.Text.Equals("") And Not mtbObservaciones.Text.Equals("") And Not mtbImporte.Text.Equals("        .") Then
            dtpFecha.Enabled = False
            cbEmpleado.Enabled = False
            cbConceptoGasto.Enabled = False
            mtbImporte.Enabled = False
            mtbObservaciones.Enabled = False
            btnGrabar.Enabled = False
            btnNuevo.Enabled = True
            dtpFechaConsulta.Visible = False
            cbEmpleadoConsulta.Visible = False
            cbConceptoConsulta.Visible = False

            Dim idGastoR As Integer
            Dim idGasto As Integer
            Dim idEmpleado As Integer
            Dim fecha As Date
            Dim importe As Double
            Dim observaciones As String
            Dim r As String

            idGastoR = mtbidGastoR.Text
            idGasto = mtbidGasto.Text
            idEmpleado = mtbidEmpleado.Text
            fecha = dtpFecha.Value.Date
            importe = mtbImporte.Text
            observaciones = mtbObservaciones.Text
            r = "insert into GastosRealizados values(" & idGastoR & "," & idGasto & "," & idEmpleado & ",'" & fecha & "','" & importe & "','" & observaciones & "')"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            dgGastosRealizados.Rows.Clear()
            comando.CommandText = "select GastosRealizados.idGastoRealizado , GastosRealizados.idEmpleado, GastosRealizados.fecha, Empleados.nombre, Gastos.concepto, GastosRealizados.importe, GastosRealizados.observaciones from GastosRealizados inner join Gastos on GastosRealizados.idGasto = Gastos.idGasto inner join Empleados on Empleados.idEmpleado = GastosRealizados.idEmpleado"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastosRealizados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
            lector.Close()
            llenar()
            mtbDomicilio.Text = ""
            mtbidEmpleado.Text = ""
            mtbidGasto.Text = ""
            mtbidGastoR.Text = ""
            mtbImporte.Text = ""
            mtbObservaciones.Text = ""
            mtbTelefono.Text = ""
            dtpFecha.Value = Today
            dtpFechaConsulta.Value = Today
        Else
            MsgBox("Asegura de llenar todos los campos.")
        End If

    End Sub

    Private Sub rbConcepto_Click(sender As Object, e As EventArgs) Handles rbConcepto.Click
        cbConceptoConsulta.Visible = True
        cbEmpleadoConsulta.Visible = False
        dtpFechaConsulta.Visible = False
        btnAceptar.Enabled = True

    End Sub

    Private Sub rbFecha_Click(sender As Object, e As EventArgs) Handles rbFecha.Click
        dtpFechaConsulta.Visible = True
        cbEmpleadoConsulta.Visible = False
        cbConceptoConsulta.Visible = False
        btnAceptar.Enabled = True

    End Sub

    Private Sub rbEmpleado_Click(sender As Object, e As EventArgs) Handles rbEmpleado.Click
        cbEmpleadoConsulta.Visible = True
        cbConceptoConsulta.Visible = False
        dtpFechaConsulta.Visible = False
        btnAceptar.Enabled = True

    End Sub

    Private Sub rbTodos_Click(sender As Object, e As EventArgs) Handles rbTodos.Click
        cbConceptoConsulta.Visible = False
        cbEmpleadoConsulta.Visible = False
        dtpFechaConsulta.Visible = False
        btnAceptar.Enabled = True

    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleado.SelectedIndexChanged
        Dim r As String
        r = "select * from Empleados where nombre = '" & cbEmpleado.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mtbidEmpleado.Text = lector(0)
        mtbDomicilio.Text = lector(2)
        mtbTelefono.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub cbConceptoGasto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConceptoGasto.SelectedIndexChanged
        Dim r As String
        r = "select * from Gastos where concepto = '" & cbConceptoGasto.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mtbidGasto.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgGastosRealizados.Rows.Clear()
        If rbTodos.Checked Then
            comando.CommandText = "select GastosRealizados.idGastoRealizado , GastosRealizados.idEmpleado, GastosRealizados.fecha, Empleados.nombre, Gastos.concepto, GastosRealizados.importe, GastosRealizados.observaciones from GastosRealizados inner join Gastos on GastosRealizados.idGasto = Gastos.idGasto inner join Empleados on Empleados.idEmpleado = GastosRealizados.idEmpleado"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastosRealizados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
        ElseIf rbConcepto.Checked
            comando.CommandText = "select GastosRealizados.idGastoRealizado , GastosRealizados.idEmpleado, GastosRealizados.fecha, Empleados.nombre, Gastos.concepto, GastosRealizados.importe, GastosRealizados.observaciones from GastosRealizados inner join Gastos on GastosRealizados.idGasto = Gastos.idGasto inner join Empleados on Empleados.idEmpleado = GastosRealizados.idEmpleado where Gastos.concepto = '" & cbConceptoConsulta.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastosRealizados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
        ElseIf rbEmpleado.Checked
            comando.CommandText = "select GastosRealizados.idGastoRealizado , GastosRealizados.idEmpleado, GastosRealizados.fecha, Empleados.nombre, Gastos.concepto, GastosRealizados.importe, GastosRealizados.observaciones from GastosRealizados inner join Gastos on GastosRealizados.idGasto = Gastos.idGasto inner join Empleados on Empleados.idEmpleado = GastosRealizados.idEmpleado where Empleados.nombre = '" & cbEmpleadoConsulta.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastosRealizados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
        ElseIf rbFecha.Checked
            comando.CommandText = "select GastosRealizados.idGastoRealizado , GastosRealizados.idEmpleado, GastosRealizados.fecha, Empleados.nombre, Gastos.concepto, GastosRealizados.importe, GastosRealizados.observaciones from GastosRealizados inner join Gastos on GastosRealizados.idGasto = Gastos.idGasto inner join Empleados on Empleados.idEmpleado = GastosRealizados.idEmpleado where GastosRealizados.fecha = '" & dtpFechaConsulta.Value.Date & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgGastosRealizados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
        End If
        lector.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class