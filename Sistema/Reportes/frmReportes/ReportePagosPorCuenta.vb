Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class ReportePagosPorCuenta
    Dim conexion As New SqlConnection("Data Source = KARINSPC ; Initial Catalog='SistemaAgua'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand
    Dim lector As SqlDataReader
    Private Sub ReportePagosPorCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If Not txtBuscar.Text.Contains("'") Then
            dgCuentas.Rows.Clear()
            comando.CommandText = "select Cuenta.idCuenta, Cuenta.nombre, Calles.nombre, Cuenta.noExterior, Cuenta.noInterior from Cuenta inner join Calles on Cuenta.idCalle = Calles.idCalle where Cuenta.nombre like '%" & txtBuscar.Text & "%'"
            lector = comando.ExecuteReader
            While lector.Read
                dgCuentas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
        Else
            Dim cadena As String = ""
            For i = 0 To txtBuscar.Text.Length - 2
                cadena += txtBuscar.Text.Chars(i)
            Next
            txtBuscar.Text = cadena
        End If
    End Sub

    Private Sub dgCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuentas.CellClick
        btnReporte.Enabled = True
        dgCuentas.CurrentRow.Selected = True
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim id As Integer = dgCuentas.Item(0, dgCuentas.CurrentRow.Index).Value
        Dim cmd As New SqlCommand("REPORTEPAGOSPORCLIENTE", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter()
        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = conexion
        adaptador.SelectCommand.CommandText = "REPORTEPAGOSPORCLIENTE"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@ID", SqlDbType.Int)
        param1.Direction = ParameterDirection.Input
        param1.Value = id
        adaptador.SelectCommand.Parameters.Add(param1)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dataset.DataSetName = "DataSet1"
        Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
        datasource.Name = "DataSet1"
        datasource.Value = dataset.Tables(0)
        Dim p1 As New ReportParameter("ID", id)
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesPar\ReportePagosPorCliente.rdlc"
        Reporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1})
        Reporte.ReportViewer1.RefreshReport()
        Reporte.ShowDialog()
        Me.Dispose()

        conexion.Close()
    End Sub
End Class