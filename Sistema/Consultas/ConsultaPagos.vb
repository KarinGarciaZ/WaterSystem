Imports System.Data.SqlClient
Public Class ConsultaPagos
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub ConsultaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        '  comando.CommandText = "select * from Pagos"
        ' lector = comando.ExecuteReader
        'While lector.Read
        '       cbidPago.Items.Add(lector(0))
        'End While
        '   lector.Close()
    End Sub

    Private Sub cbidPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidPago.SelectedIndexChanged
        Dim tipo As String
        comando.CommandText = "select Pagos.idCuenta, Cuenta.nombre, Pagos.fecha, Pagos.otros, Pagos.total, Pagos.tipo from Pagos inner join Cuenta on Pagos.idCuenta = Cuenta.idCuenta where Pagos.idPago = " & cbidPago.Text & ""
        lector = comando.ExecuteReader
        lector.Read()
        txtidCuenta.Text = lector(0)
        Dim fecha As Date = lector(2)
        dtpFecha.Value = fecha.Date
        txtOtros.Text = lector(3)
        txtTotal.Text = lector(4)
        tipo = lector(5)
        lector.Close()

        If tipo.Equals("Agua") Then
            gbServicioAtendido.Visible = False
            comando.CommandText = "select * from Agua where idPago = " & cbidPago.Text & ""
            lector = comando.ExecuteReader
            lector.Read()
            txtidPago.Text = lector(0)
            txtSituacion.Text = lector(1)
            txtAño.Text = lector(2)
            txtMesInicial.Text = lector(3)
            txtMesFinal.Text = lector(4)
            txtCF.Text = lector(5)
            txtRecargos.Text = lector(6)
            txtTar.Text = lector(7)
            txtInfra.Text = lector(8)
            txtDescuento.Text = lector(9)
            lector.Close()
            comando.CommandText = "select descripcion from Situacion where idSituacion = " & txtSituacion.Text & ""
            lector = comando.ExecuteReader
            lector.Read()
            txtSituacion.Text = lector(0)
            lector.Close()
            gbAgua.Visible = True
        ElseIf tipo.Equals("Servicio")
            gbAgua.Visible = False
            txtidPago2.Text = cbidPago.Text
            txtidPago.Text = cbidPago.Text
            comando.CommandText = "select ServiciosAtendidos.idServicio, Servicios.descripcion, ServiciosAtendidos.idEmpleado, Empleados.nombre, ServiciosAtendidos.precio from ServiciosAtendidos inner join Servicios on ServiciosAtendidos.idServicio = Servicios.idServicio inner join Empleados on ServiciosAtendidos.idEmpleado = Empleados.idEmpleado where idPago = " & cbidPago.Text & ""
            lector = comando.ExecuteReader
            lector.Read()
            txtidServicio.Text = lector(0)
            txtServicio.Text = lector(1)
            txtidEmpleado.Text = lector(2)
            txtNombreEmpleado.Text = lector(3)
            txtPrecio.Text = lector(4)
            lector.Close()
            gbServicioAtendido.Visible = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        dgPagos.Rows.Clear()
        cbidPago.Items.Clear()
        cbidPago.Enabled = True
        Dim dia As Date
        Dim r As String
        r = "select Pagos.idPago, Cuenta.nombre, Pagos.fecha, Pagos.tipo, Pagos.otros, Pagos.total from Pagos inner join Cuenta on Pagos.idCuenta = Cuenta.idCuenta where Cuenta.nombre like '%" & txtNombre.Text & "%'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        While lector.Read
            dia = lector(2)
            dgPagos.Rows.Add(lector(0), lector(1), dia.Date, lector(3), lector(4), lector(5))
            cbidPago.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class