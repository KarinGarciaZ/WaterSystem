Imports System.Data.SqlClient
Public Class CompraMateriales
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub CompraMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        llenarProveedores()
        llenarMateriales()
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

    Private Sub llenarProveedores()
        cbProveedores.Items.Clear()
        comando.CommandText = "select * from Proveedores"
        lector = comando.ExecuteReader
        While lector.Read
            cbProveedores.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub cbProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedores.SelectedIndexChanged
        Dim r As String
        r = "select * from Proveedores where nombre = '" & cbProveedores.Text & "'"
        comando.CommandText = r
        lector = comando.ExecuteReader
        lector.Read()
        mtbidProveedores.Text = lector(0)
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
        mtbExistencia.Text = lector(3)
        mtbMinimo.Text = lector(4)
        mtbMaximo.Text = lector(5)
        mtbCostoAnterior.Text = lector(6)
        mtbUM.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        dgCompraMateriales.Rows.Clear()
        cmdGrabar.Enabled = True
        mtbFactura.Enabled = True
        cmdAceptar.Enabled = True
        mtbCosto.Enabled = True
        mtbCantidad.Enabled = True
        dtpFecha.Enabled = True
        comando.CommandText = "select count(*) from ComprasMateriales"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        mtbOrden.Text = n
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not mtbidProveedores.Text.Equals("") And Not mtbFactura.Text.Equals("") And dgCompraMateriales.Rows.Count > 1 Then
            cmdAceptar.Enabled = False
            cmdGrabar.Enabled = False
            mtbFactura.Enabled = False
            mtbCosto.Enabled = False
            mtbCantidad.Enabled = False
            dtpFecha.Enabled = False

            Dim idMat As Integer
            Dim cantidad As Double
            Dim costo As Double
            Dim orden As Integer
            Dim r As String
            orden = mtbOrden.Text

            For i = 0 To dgCompraMateriales.Rows.Count - 2
                idMat = Val(dgCompraMateriales.Item(0, i).Value)
                cantidad = Val(dgCompraMateriales.Item(2, i).Value)
                costo = Val(dgCompraMateriales.Item(3, i).Value)
                r = "insert into DetalleComprasMateriales values(" & orden & "," & idMat & ",'" & cantidad & "','" & costo & "')"
                comando.CommandText = r
                comando.ExecuteNonQuery()
                r = "update Materiales set ultimaFechaCompra = '" & dtpFecha.Value.Date & "', existencia = existencia +'" & cantidad & "', costo = '" & costo & "' where idMaterial = " & idMat & ""
                comando.CommandText = r
                comando.ExecuteNonQuery()
            Next
            r = "insert into ComprasMateriales values(" & orden & "," & mtbidProveedores.Text & ",'" & mtbFactura.Text & "','" & dtpFecha.Value.Date & "', '" & lblSubtotal.Text & "','" & lblIVA.Text & "','" & lblTotal.Text & "')"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            mtbOrden.Text = ""
            mtbFactura.Text = ""
            mtbDomicilio.Text = ""
            mtbidProveedores.Text = ""
            mtbTelefono.Text = ""
            dtpFecha.Value = Today
            llenarMateriales()
            llenarProveedores()
            dgCompraMateriales.Rows.Clear()
        Else
            MsgBox("Asegure haber agregado materiales, la factura y poner el proveedor.")
        End If

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If Not mtbCantidad.Text.Equals("       .") And Not mtbCosto.Text.Equals("       .") And Not cbMaterial.Text.Equals("") Then
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

            For i = 0 To dgCompraMateriales.Rows.Count - 2
                If mtbidMaterial.Text = dgCompraMateriales.Item(0, i).Value Then
                    pos = i
                    ban = True
                End If
            Next

            If ban = False Then
                dgCompraMateriales.Rows.Add(mtbidMaterial.Text, cbMaterial.Text, cant, cost, imp)
            Else
                dgCompraMateriales.Item(2, pos).Value += cant
                dgCompraMateriales.Item(4, pos).Value = dgCompraMateriales.Item(3, pos).Value * dgCompraMateriales.Item(2, pos).Value
            End If
            lblSubtotal.Text = subTotal
            lblIVA.Text = iva
            lblTotal.Text = total
            mtbCosto.Text = ""
            mtbCantidad.Text = ""
            mtbCostoAnterior.Text = ""
            mtbExistencia.Text = ""
            mtbidMaterial.Text = ""
            mtbMaximo.Text = ""
            mtbMinimo.Text = ""
            mtbUM.Text = ""
            llenarMateriales()
        Else
            MsgBox("Asegure agregar una cantidad y un costo.")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class