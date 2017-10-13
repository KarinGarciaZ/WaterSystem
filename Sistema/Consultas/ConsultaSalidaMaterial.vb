Imports System.Data.SqlClient
Public Class ConsultaSalidaMaterial
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub ConsultaSalidaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.Open()
        comando.CommandText = "select * from SalidaMateriales"
        lector = comando.ExecuteReader
        While lector.Read
            cbidSalida.Items.Add(lector(0))
        End While
        lector.Close()
        comando.CommandText = "select * from Empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cbEmpleado.Items.Add(lector(1))
        End While
        lector.Close()
        comando.CommandText = "select * from Calles"
        lector = comando.ExecuteReader
        While lector.Read
            cbCalles.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub rbidSalida_CheckedChanged(sender As Object, e As EventArgs) Handles rbidSalida.CheckedChanged
        cbidSalida.Visible = True
        cbEmpleado.Visible = False
        cbCalles.Visible = False
        dtpFechaFinal.Visible = False
        dtpFechaInicial.Visible = False
        lblf1.Visible = False
        lblf2.Visible = False
    End Sub

    Private Sub rbCalle_CheckedChanged(sender As Object, e As EventArgs) Handles rbCalle.CheckedChanged
        cbidSalida.Visible = False
        cbEmpleado.Visible = False
        cbCalles.Visible = True
        dtpFechaFinal.Visible = False
        dtpFechaInicial.Visible = False
        lblf1.Visible = False
        lblf2.Visible = False
    End Sub

    Private Sub rbEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpleado.CheckedChanged
        cbidSalida.Visible = False
        cbEmpleado.Visible = True
        cbCalles.Visible = False
        dtpFechaFinal.Visible = False
        dtpFechaInicial.Visible = False
        lblf1.Visible = False
        lblf2.Visible = False
    End Sub

    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        cbidSalida.Visible = False
        cbEmpleado.Visible = False
        cbCalles.Visible = False
        dtpFechaFinal.Visible = True
        dtpFechaInicial.Visible = True
        lblf1.Visible = True
        lblf2.Visible = True
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim importe As Double
        importe = 0
        dgConsultaSalidaMateriales.Rows.Clear()
        dgConsultaPorId.Rows.Clear()
        If rbidSalida.Checked Then
            GroupBox2.Visible = True
            dgConsultaPorId.Visible = True
            dgConsultaSalidaMateriales.Visible = False
            comando.CommandText = "select DetalleSalidaMateriales.idMaterial , Materiales.descripcion, DetalleSalidaMateriales.idSalida, Empleados.nombre, Calles.nombre, SalidaMateriales.fecha, DetalleSalidaMateriales.cantidad, DetalleSalidaMateriales.costo from SalidaMateriales inner join DetalleSalidaMateriales on DetalleSalidaMateriales.idSalida = SalidaMateriales.idSalida inner join Empleados on Empleados.idEmpleado = SalidaMateriales.idEmpleado inner join Calles on Calles.idCalle = SalidaMateriales.idCalle inner join Materiales on Materiales.idMaterial = DetalleSalidaMateriales.idMaterial where SalidaMateriales.idSalida = " & cbidSalida.Text & ""
            lector = comando.ExecuteReader
            Dim dia As Date
            While lector.Read
                txtidSalida.Text = lector(2)
                txtEmpleado.Text = lector(3)
                txtCalle.Text = lector(4)
                dia = lector(5)
                dtpFecha.Value = dia
                dgConsultaPorId.Rows.Add(lector(0), lector(1), lector(6), lector(7), lector(6) * lector(7))
                importe += lector(6) * lector(7)
            End While
        ElseIf rbEmpleado.Checked
            dgConsultaPorId.Visible = False
            GroupBox2.Visible = False
            dgConsultaSalidaMateriales.Visible = True
            comando.CommandText = "select DetalleSalidaMateriales.idMaterial , Materiales.descripcion, DetalleSalidaMateriales.idSalida, Empleados.nombre, Calles.nombre, SalidaMateriales.fecha, DetalleSalidaMateriales.cantidad, DetalleSalidaMateriales.costo from SalidaMateriales inner join DetalleSalidaMateriales on DetalleSalidaMateriales.idSalida = SalidaMateriales.idSalida inner join Empleados on Empleados.idEmpleado = SalidaMateriales.idEmpleado inner join Calles on Calles.idCalle = SalidaMateriales.idCalle inner join Materiales on Materiales.idMaterial = DetalleSalidaMateriales.idMaterial where Empleados.nombre = '" & cbEmpleado.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgConsultaSalidaMateriales.Rows.Add(lector(2), lector(0), lector(1), lector(3), lector(4), lector(5), lector(6), lector(7), lector(6) * lector(7))
                importe += lector(6) * lector(7)
            End While
        ElseIf rbCalle.Checked
            GroupBox2.Visible = False
            dgConsultaPorId.Visible = False
            dgConsultaSalidaMateriales.Visible = True
            comando.CommandText = "select DetalleSalidaMateriales.idMaterial , Materiales.descripcion, DetalleSalidaMateriales.idSalida, Empleados.nombre, Calles.nombre, SalidaMateriales.fecha, DetalleSalidaMateriales.cantidad, DetalleSalidaMateriales.costo from SalidaMateriales inner join DetalleSalidaMateriales on DetalleSalidaMateriales.idSalida = SalidaMateriales.idSalida inner join Empleados on Empleados.idEmpleado = SalidaMateriales.idEmpleado inner join Calles on Calles.idCalle = SalidaMateriales.idCalle inner join Materiales on Materiales.idMaterial = DetalleSalidaMateriales.idMaterial where Calles.nombre = '" & cbCalles.Text & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgConsultaSalidaMateriales.Rows.Add(lector(2), lector(0), lector(1), lector(3), lector(4), lector(5), lector(6), lector(7), lector(6) * lector(7))
                importe += lector(6) * lector(7)
            End While
        ElseIf rbTodo.Checked
            GroupBox2.Visible = False
            dgConsultaPorId.Visible = False
            dgConsultaSalidaMateriales.Visible = True
            comando.CommandText = "select DetalleSalidaMateriales.idMaterial , Materiales.descripcion, DetalleSalidaMateriales.idSalida, Empleados.nombre, Calles.nombre, SalidaMateriales.fecha, DetalleSalidaMateriales.cantidad, DetalleSalidaMateriales.costo from SalidaMateriales inner join DetalleSalidaMateriales on DetalleSalidaMateriales.idSalida = SalidaMateriales.idSalida inner join Empleados on Empleados.idEmpleado = SalidaMateriales.idEmpleado inner join Calles on Calles.idCalle = SalidaMateriales.idCalle inner join Materiales on Materiales.idMaterial = DetalleSalidaMateriales.idMaterial"
            lector = comando.ExecuteReader
            While lector.Read
                dgConsultaSalidaMateriales.Rows.Add(lector(2), lector(0), lector(1), lector(3), lector(4), lector(5), lector(6), lector(7), lector(6) * lector(7))
                importe += lector(6) * lector(7)
            End While
        ElseIf rbFecha.Checked
            GroupBox2.Visible = False
            dgConsultaPorId.Visible = False
            dgConsultaSalidaMateriales.Visible = True
            comando.CommandText = "select DetalleSalidaMateriales.idMaterial , Materiales.descripcion, DetalleSalidaMateriales.idSalida, Empleados.nombre, Calles.nombre, SalidaMateriales.fecha, DetalleSalidaMateriales.cantidad, DetalleSalidaMateriales.costo from SalidaMateriales inner join DetalleSalidaMateriales on DetalleSalidaMateriales.idSalida = SalidaMateriales.idSalida inner join Empleados on Empleados.idEmpleado = SalidaMateriales.idEmpleado inner join Calles on Calles.idCalle = SalidaMateriales.idCalle inner join Materiales on Materiales.idMaterial = DetalleSalidaMateriales.idMaterial where SalidaMateriales.fecha >= '" & dtpFechaInicial.Value.Date & "' and SalidaMateriales .fecha <= '" & dtpFechaFinal.Value.Date & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgConsultaSalidaMateriales.Rows.Add(lector(2), lector(0), lector(1), lector(3), lector(4), lector(5), lector(6), lector(7), lector(6) * lector(7))
                importe += lector(6) * lector(7)
            End While
        End If
        lblSubtotal.Text = importe
        lblIVA.Text = importe * 0.16
        lblTotal.Text = importe * 1.16
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class