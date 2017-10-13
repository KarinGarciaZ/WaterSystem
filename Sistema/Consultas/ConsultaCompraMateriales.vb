Imports System.Data.SqlClient
Public Class ConsultaCompraMateriales
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub ConsultaCompraMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "select * from ComprasMateriales"
        lector = comando.ExecuteReader
        While lector.Read
            cbidOrden.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cbidOrden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidOrden.SelectedIndexChanged
        dgConsultaCompraMateriales.Rows.Clear()
        Dim id As Integer
        id = cbidOrden.Text
        comando.CommandText = "select Proveedores.nombre, ComprasMateriales.fecha, ComprasMateriales.factura, ComprasMateriales.subtotal, ComprasMateriales.iva, ComprasMateriales.total from ComprasMateriales inner join Proveedores on ComprasMateriales.idProveedor = Proveedores.idProveedor where ComprasMateriales.orden =  " & id & ""
        lector = comando.ExecuteReader
        lector.Read()
        mtbProveedor.Text = lector(0)
        dtpFecha.Value = lector(1)
        mtbFactura.Text = lector(2)
        lblSubtotal.Text = lector(3)
        lblIVA.Text = lector(4)
        lblTotal.Text = lector(5)
        lector.Close()
        comando.CommandText = "select DetalleComprasMateriales.idMaterial, Materiales.descripcion, DetalleComprasMateriales.cantidad, DetalleComprasMateriales.costo from DetalleComprasMateriales inner join Materiales on DetalleComprasMateriales.idMaterial = Materiales.idMaterial where DetalleComprasMateriales.orden = " & id & ""
        lector = comando.ExecuteReader
        While lector.Read
            dgConsultaCompraMateriales.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(2) * lector(3))
        End While
        lector.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Close()
        Me.Dispose()
    End Sub
End Class