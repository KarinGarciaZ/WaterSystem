Imports System.Data.SqlClient
Public Class SalidaMaterial
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub SalidaMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        llenar()
        llenarMateriales()
    End Sub

    Private Sub llenar()
        cbEmpleados.Items.Clear()
        cbCalles.Items.Clear()
        comando.CommandText = "select * from Empleados"
        lector = comando.ExecuteReader
        While lector.Read
            cbEmpleados.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "select * from Calles"
        lector = comando.ExecuteReader
        While lector.Read
            cbCalles.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub llenarMateriales()
        cbMaterial.Items.Clear()
        comando.CommandText = "select * from Materiales"
        lector = comando.ExecuteReader
        While lector.Read
            cbMaterial.Items.Add(lector(2))
        End While
        lector.Close()
    End Sub

    Private Sub cbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleados.SelectedIndexChanged
        Dim r As String
        r = "select * from Empleados where nombre = '" & cbEmpleados.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mtbidEmpleados.Text = lector(0)
        mtbDomicilio.Text = lector(2)
        mtbTelefono.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub cbMaterial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMaterial.SelectedIndexChanged
        Dim r As String
        r = "select * from Materiales where descripcion = '" & cbMaterial.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mtbidMaterial.Text = lector(0)
        dtmFechaMaterial.Value = lector(1)
        mtbExistencia.Text = lector(3)
        mtbMinimo.Text = lector(4)
        mtbMaximo.Text = lector(5)
        mtbCosto.Text = lector(6)
        mtbUM.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub cbCalles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCalles.SelectedIndexChanged
        Dim r As String
        r = "select * from Calles where nombre = '" & cbCalles.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mtbidCalle.Text = lector(0)
        mtbTotalCasas.Text = lector(4)
        lector.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        dgSalidaMateriales.Rows.Clear()
        cmdAceptar.Enabled = True
        cmdGrabar.Enabled = True
        mtbConcepto.Enabled = True
        mtbCantidad.Enabled = True
        dtpFecha.Enabled = True
        comando.CommandText = "select count(*) from SalidaMateriales"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        mtbidSalida.Text = n
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If Not mtbCantidad.Text.Equals("       .") And Not cbMaterial.Text.Equals("") Then
            Dim cant As Double
            Dim cost As Double
            Dim imp As Double
            Dim subTotal As Double
            Dim iva As Double
            Dim total As Double
            Dim ban As Boolean
            Dim pos As Integer
            ban = False
            subTotal = lblSubtotal.Text
            cant = mtbCantidad.Text
            cost = mtbCosto.Text
            imp = cant * cost
            subTotal += imp
            iva = subTotal * 0.16
            total = subTotal + iva

            For i = 0 To dgSalidaMateriales.Rows.Count - 2
                If mtbidMaterial.Text = dgSalidaMateriales.Item(0, i).Value Then
                    pos = i
                    ban = True
                End If
            Next

            If ban = False Then
                dgSalidaMateriales.Rows.Add(mtbidMaterial.Text, cbMaterial.Text, cant, cost, imp)
            Else
                dgSalidaMateriales.Item(2, pos).Value += cant
                dgSalidaMateriales.Item(4, pos).Value = dgSalidaMateriales.Item(3, pos).Value * dgSalidaMateriales.Item(2, pos).Value
            End If
            lblSubtotal.Text = subTotal
            lblIVA.Text = iva
            lblTotal.Text = total
            llenarMateriales()
            mtbidMaterial.Text = ""
            mtbUM.Text = ""
            mtbCosto.Text = ""
            mtbExistencia.Text = ""
            mtbMaximo.Text = ""
            mtbMinimo.Text = ""
            mtbCantidad.Text = ""
        Else
            MsgBox("Asegure de seleccionar el material y la cantidad.")
        End If

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not mtbidCalle.Text.Equals("") And Not mtbidEmpleados.Text.Equals("") And Not mtbConcepto.Text.Equals("") And dgSalidaMateriales.Rows.Count > 1 Then
            cmdAceptar.Enabled = False
            cmdGrabar.Enabled = False
            mtbConcepto.Enabled = False
            mtbCosto.Enabled = False
            mtbCantidad.Enabled = False
            dtpFecha.Enabled = False

            Dim idMat As Integer
            Dim cantidad As Double
            Dim costo As Double
            Dim idSalida As Integer
            Dim r As String
            idSalida = mtbidSalida.Text

            For i = 0 To dgSalidaMateriales.Rows.Count - 2
                idMat = Val(dgSalidaMateriales.Item(0, i).Value)
                cantidad = Val(dgSalidaMateriales.Item(2, i).Value)
                costo = Val(dgSalidaMateriales.Item(3, i).Value)
                r = "insert into DetalleSalidaMateriales values(" & idSalida & "," & idMat & ",'" & cantidad & "','" & costo & "')"
                comando.CommandText = r
                comando.ExecuteNonQuery()
                r = "update Materiales set existencia = existencia -'" & cantidad & "' where idMaterial = " & idMat & ""
                comando.CommandText = r
                comando.ExecuteNonQuery()
            Next
            r = "insert into SalidaMateriales values(" & idSalida & "," & mtbidEmpleados.Text & "," & mtbidCalle.Text & ",'" & dtpFecha.Value.Date & "','" & mtbConcepto.Text & "')"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            llenar()
            mtbConcepto.Text = ""
            mtbidSalida.Text = ""
            mtbidEmpleados.Text = ""
            mtbTelefono.Text = ""
            mtbDomicilio.Text = ""
            mtbTotalCasas.Text = ""
            mtbidCalle.Text = ""
            dtpFecha.Value = Today
        Else
            MsgBox("Asegure de agregar una calle, un empleado y un concepto de salida de material.")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class