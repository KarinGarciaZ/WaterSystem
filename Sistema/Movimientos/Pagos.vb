Imports System.Data.SqlClient
Public Class Pagos
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub rbAgua_CheckedChanged(sender As Object, e As EventArgs) Handles rbAgua.CheckedChanged
        gbAgua.Visible = True
        gbServicios.Visible = False
        cmdGrabar.Enabled = True
    End Sub

    Private Sub rbServicio_CheckedChanged(sender As Object, e As EventArgs) Handles rbServicio.CheckedChanged
        lblDesc.Text = "0.00"
        gbServicios.Visible = True
        gbAgua.Visible = False
        cmdGrabar.Enabled = True
    End Sub


    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If Not txtNombre.Text.Contains("'") And txtNombre.TextLength > 0 Then
            If Not Char.IsNumber(txtNombre.Text.Chars(txtNombre.TextLength - 1)) Then
                dgPagos.Rows.Clear()
                cbidCuenta.Items.Clear()
                cbidCuenta.Enabled = True
                comando.CommandText = "select Cuenta.idCuenta, Cuenta.nombre, Calles.nombre, Cuenta.ultimoPagoAnio, Cuenta.ultimoPagoMes from Cuenta inner join Calles on Calles.idCalle = Cuenta.idCalle where Cuenta.nombre like '%" & txtNombre.Text & "%'"
                lector = comando.ExecuteReader
                While lector.Read
                    dgPagos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
                    cbidCuenta.Items.Add(lector(0))
                End While
                lector.Close()
            Else
                MessageBox.Show("No se aceptan números.")
                txtNombre.Text = ""
            End If
        Else
            Dim cadena As String = ""
            For i = 0 To txtNombre.Text.Length - 2
                cadena += txtNombre.Text.Chars(i)
            Next
            txtNombre.Text = cadena
        End If
    End Sub

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        llenar()
    End Sub

    Private Sub llenar()
        cbTarifas.Items.Clear()
        cbSituaciones.Items.Clear()
        cbServicios.Items.Clear()
        cbEmpleados.Items.Clear()
        comando.CommandText = "select * from Empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cbEmpleados.Items.Add(lector(1))
        End While
        lector.Close()
        Dim ano As Date
        comando.CommandText = "select * from Tarifas"
        lector = comando.ExecuteReader
        While lector.Read
            ano = lector(1)
            cbTarifas.Items.Add(ano.Year)
        End While
        lector.Close()

        comando.CommandText = "select * from Servicios"
        lector = comando.ExecuteReader
        While lector.Read
            cbServicios.Items.Add(lector(1))
        End While
        lector.Close()
        comando.CommandText = "select * from Situacion"
        lector = comando.ExecuteReader
        While lector.Read
            cbSituaciones.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub cbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServicios.SelectedIndexChanged
        Dim r As String
        r = "select * from Servicios where descripcion = '" & cbServicios.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        txtidServicio.Text = lector(0)
        txtPrecio.Text = lector(2)
        txtTotal.Text = lector(2)
        lector.Close()
    End Sub

    Private Sub cbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleados.SelectedIndexChanged
        Dim r As String
        r = "select * from Empleados where nombre = '" & cbEmpleados.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        txtidEmpleado.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub cbSituaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSituaciones.SelectedIndexChanged
        'If cbTarifas.Equals(CStr(dtpFecha.Value.Year)) Or cbTarifas.Equals("") Then
        Dim r As String
        r = "select * from Situacion where descripcion = '" & cbSituaciones.Text & "'"
        comando.CommandText = r
            lector = comando.ExecuteReader
            lector.Read()
            txtidSituacion.Text = lector(0)
            txtDescuento.Text = lector(2)
            lector.Close()
        'End If
        cbMesFinal.Enabled = True
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        cmdNuevo .Enabled = false
        gbTipoPago.Enabled = True
        txtNombre.Enabled = True
        txtOtros.Enabled = True
        comando.CommandText = "select count(*) from Pagos"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        txtidPago.Text = n
    End Sub

    Private Sub cbMesFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMesFinal.SelectedIndexChanged
        Dim inicio As Integer
        Dim final As Integer
        Dim dif As Integer
        Dim desc As Double = 1
        Dim dia As Date = dtpFecha.Value.Date
        Dim s(12) As String
        s(0) = "Enero"
        s(1) = "Febrero"
        s(2) = "Marzo"
        s(3) = "Abril"
        s(4) = "Mayo"
        s(5) = "Junio"
        s(6) = "Julio"
        s(7) = "Agosto"
        s(8) = "Septiembre"
        s(9) = "Octubre"
        s(10) = "Noviembre"
        s(11) = "Diciembre"

        If txtMesInicial.Visible Then
            For i = 0 To 12
                If txtMesInicial.Text.Equals(s(i)) Then
                    inicio = i
                End If
            Next
        Else
            For i = 0 To 12
                If cbMesInicial.Text.Equals(s(i)) Then
                    inicio = i
                End If
            Next
        End If

        For i = 0 To 12
            If cbMesFinal.Text.Equals(s(i)) Then
                final = i
            End If
        Next
        dif = final - inicio + 1
        desc -= CDbl(txtDescuento.Text) * 0.01
        txtCF2.Text = CDbl(txtCF.Text) / 12 * dif
        txtTAR2.Text = CDbl(txtTAR.Text) / 12 * dif
        txtRecargos2.Text = CDbl(txtRecargos.Text) / 12 * dif
        txtInfra2.Text = CDbl(txtInfra.Text) / 12 * dif
        Dim anioTar As Integer = cbTarifas.Text
        If anioTar = dia.Year Then
            txtRecargos2.Text = "0"
        Else
            desc = 1
        End If
        If desc <> 1 Then
            txtTotal.Text = (CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text)) * desc
            'MessageBox.Show(CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text) & " - " & CDbl(txtTotal.Text) & " = " & CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text) - CDbl(txtTotal.Text))
            'MessageBox.Show(CDbl(txtTotal.Text))
            'MessageBox.Show(CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text) - CDbl(txtTotal.Text))
            lblDesc.Text = CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text) - CDbl(txtTotal.Text)
        Else
            txtTotal.Text = (CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text))
        End If

    End Sub


    Private Sub txtOtros_TextChanged_1(sender As Object, e As EventArgs) Handles txtOtros.TextChanged
        If Not txtOtros.Text.Contains("'") And txtOtros.TextLength > 0 Then
            If Not Char.IsNumber(txtOtros.Text.Chars(txtOtros.TextLength - 1)) And Not txtOtros.Text.Chars(txtOtros.TextLength - 1) = "." Then
                MessageBox.Show("Solo números.")
                txtOtros.Text = ""
            Else
                If rbAgua.Checked Then
                    If txtOtros.Text <> "" Then
                        txtTotal.Text = CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text) + CDbl(txtOtros.Text)
                        txtTotal.Text = CDbl(txtTotal.Text) - CDbl(lblDesc.Text)
                    Else
                        txtTotal.Text = CDbl(txtCF2.Text) + CDbl(txtTAR2.Text) + CDbl(txtRecargos2.Text) + CDbl(txtInfra2.Text)
                        txtTotal.Text = CDbl(txtTotal.Text) - CDbl(lblDesc.Text)
                    End If
                ElseIf rbServicio.Checked
                    If txtOtros.Text <> "" Then
                        txtTotal.Text = CDbl(txtPrecio.Text) + CDbl(txtOtros.Text)
                    Else
                        txtTotal.Text = CDbl(txtPrecio.Text)
                    End If
                End If
            End If
        Else
            Dim cadena As String = ""
            For i = 0 To txtOtros.Text.Length - 2
                cadena += txtOtros.Text.Chars(i)
            Next
            txtOtros.Text = cadena
        End If

    End Sub

    Private Sub validar()
        cmdImprimir.Enabled = True
        cmdNuevo.Enabled = True
        txtOtros.Enabled = False
        gbTipoPago.Enabled = False
        gbServicios.Visible = False
        gbAgua.Visible = False
        txtNombre.Enabled = False
        cbidCuenta.Enabled = False
        cmdGrabar.Enabled = False
        txtNombre.Text = ""
        dgPagos.Rows.Clear()
        txtidPago.Text = ""
        cbidCuenta.Items.Clear()
        txtidCuenta.Text = ""
        txtNombreConsulta.Text = ""
        txtUAP.Text = ""
        txtUMP.Text = ""
        txtCalle.Text = ""
        txtidEmpleado.Text = ""
        txtidServicio.Text = ""
        txtPrecio.Text = ""
        txtidSituacion.Text = ""
        txtDescuento.Text = ""
        txtCF.Text = ""
        txtTAR.Text = ""
        txtInfra.Text = ""
        txtRecargos.Text = ""
        txtMesInicial.Text = ""
        cbMesFinal.Items.Clear()
        txtCF2.Text = "0.00"
        txtTAR2.Text = "0.00"
        txtInfra2.Text = "0.00"
        txtRecargos2.Text = "0.00"
        lblDesc.Text = "0.00"
        txtOtros.Text = "0.00"
        txtTotal.Text = "0.00"
        rbAgua.Checked = False
        rbServicio.Checked = False
        llenar()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtidCuenta.Text.Equals("") And Not txtOtros.Text.Equals("") Then

            Dim ss(12) As String
            ss(0) = "Enero"
            ss(1) = "Febrero"
            ss(2) = "Marzo"
            ss(3) = "Abril"
            ss(4) = "Mayo"
            ss(5) = "Junio"
            ss(6) = "Julio"
            ss(7) = "Agosto"
            ss(8) = "Septiembre"
            ss(9) = "Octubre"
            ss(10) = "Noviembre"
            ss(11) = "Diciembre"
            Dim numMes As Integer
            Dim mesInicial As String
            For i = 0 To 12
                If cbMesFinal.Text.Equals(ss(i)) Then
                    numMes = i + 1
                End If
            Next
            If txtUMP.Text.Equals("0") Then
                mesInicial = cbMesInicial.Text
            Else
                mesInicial = txtMesInicial.Text
            End If

            Dim s As String
            If rbAgua.Checked Then
                If Not txtidSituacion.Text.Equals("") And Not cbTarifas.Text.Equals("") And Not mesInicial.Equals("") And Not cbMesFinal.Text.Equals("") Then
                    s = "insert into Pagos values(" & txtidPago.Text & "," & cbidCuenta.Text & ",'" & dtpFecha.Value.Date & "','Agua'," & txtOtros.Text & "," & txtTotal.Text & ")"
                    comando.CommandText = s
                    comando.ExecuteNonQuery()
                    s = "insert into Agua values(" & txtidPago.Text & "," & txtidSituacion.Text & "," & cbTarifas.Text & ",'" & mesInicial & "','" & cbMesFinal.Text & "'," & txtCF2.Text & "," & txtRecargos2.Text & "," & txtTAR2.Text & "," & txtInfra2.Text & "," & lblDesc.Text & ")"
                    comando.CommandText = s
                    comando.ExecuteNonQuery()
                    s = "update Cuenta set ultimoPagoAnio = " & cbTarifas.Text & ", ultimoPagoMes = " & numMes & " where idCuenta = " & cbidCuenta.Text & ""
                    comando.CommandText = s
                    comando.ExecuteNonQuery()
                    validar()
                Else
                    MsgBox("Asegure llenar bien los datos del pago de agua.")
                End If
            ElseIf rbServicio.Checked
                If Not txtidServicio.Text.Equals("") And Not txtidEmpleado.Text.Equals("") And Not txtPrecio.Text.Equals("") Then
                    s = "insert into Pagos values(" & txtidPago.Text & "," & cbidCuenta.Text & ",'" & dtpFecha.Value.Date & "','Servicio'," & txtOtros.Text & "," & txtTotal.Text & ")"
                    comando.CommandText = s
                    comando.ExecuteNonQuery()
                    s = "insert into ServiciosAtendidos values(" & txtidPago.Text & "," & txtidServicio.Text & "," & txtidEmpleado.Text & "," & txtPrecio.Text & ")"
                    comando.CommandText = s
                    comando.ExecuteNonQuery()
                    validar()
                Else
                    MsgBox("Asegure poner bien los datos del servicio atendido.")
                End If
            End If
            txtOtros.Text = "0.00"
        Else
            MsgBox("Asegure llenar bien los datos del pago.")
        End If
    End Sub

    Private Sub cbidCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidCuenta.SelectedIndexChanged
        comando.CommandText = "select Cuenta.idCuenta, Cuenta.nombre, Calles.nombre, Cuenta.ultimoPagoAnio, Cuenta.ultimoPagoMes from Cuenta inner join Calles on Calles.idCalle = Cuenta.idCalle where Cuenta.idCuenta like '%" & cbidCuenta.Text & "%'"
        lector = comando.ExecuteReader
        lector.Read()
        txtidCuenta.Text = lector(0)
        txtNombreConsulta.Text = lector(1)
        txtCalle.Text = lector(2)
        txtUAP.Text = lector(3)
        txtUMP.Text = lector(4)
        lector.Close()

        cbMesFinal.Items.Clear()
        cbMesFinal.Enabled = True
        Dim s(12) As String
        s(0) = "Enero"
        s(1) = "Febrero"
        s(2) = "Marzo"
        s(3) = "Abril"
        s(4) = "Mayo"
        s(5) = "Junio"
        s(6) = "Julio"
        s(7) = "Agosto"
        s(8) = "Septiembre"
        s(9) = "Octubre"
        s(10) = "Noviembre"
        s(11) = "Diciembre"

        If Not txtUMP.Text.Equals("0") Then
            cbMesInicial.Visible = False
            txtMesInicial.Visible = True
            If txtUMP.Text.Equals("12") Then
                txtMesInicial.Text = "Enero"
            Else
                txtMesInicial.Text = (s(txtUMP.Text))
            End If
            For i = 0 To 12
                If txtMesInicial.Text.Equals(s(i)) Then
                    While i < 12
                        cbMesFinal.Items.Add(s(i))
                        i += 1
                    End While
                End If
            Next
        Else
            cbMesInicial.Visible = True
            txtMesInicial.Visible = False

        End If



    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub cbTarifas_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbTarifas.SelectedIndexChanged
        Dim r As String
        r = "select * from Tarifas where anio = '" & cbTarifas.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        txtCF.Text = lector(2)
        txtRecargos.Text = lector(3)
        txtTAR.Text = lector(4)
        txtInfra.Text = lector(5)
        lector.Close()
        If cbTarifas.Text <> dtpFecha.Value.Year Then
            MessageBox.Show("No aplica descuento. Debe de ser el año en curso.", "Alerta")
        Else
            r = "select * from Situacion where descripcion = '" & cbSituaciones.Text & "'"
            comando.CommandText = r
            lector = comando.ExecuteReader
            lector.Read()
            txtidSituacion.Text = lector(0)
            txtDescuento.Text = lector(2)
            lector.Close()
        End If
        cbMesFinal.Enabled = True
    End Sub

    Private Sub cbMesInicial_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbMesInicial.SelectedIndexChanged
        cbMesFinal.Items.Clear()
        cbMesFinal.Enabled = True
        Dim s(12) As String
        s(0) = "Enero"
        s(1) = "Febrero"
        s(2) = "Marzo"
        s(3) = "Abril"
        s(4) = "Mayo"
        s(5) = "Junio"
        s(6) = "Julio"
        s(7) = "Agosto"
        s(8) = "Septiembre"
        s(9) = "Octubre"
        s(10) = "Noviembre"
        s(11) = "Diciembre"

        For i = 0 To 12
            If cbMesInicial.Text.Equals(s(i)) Then
                While i < 12
                    cbMesFinal.Items.Add(s(i))
                    i += 1
                End While
            End If
        Next
    End Sub
End Class