Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class MenuPrincipal
    Private Sub CallesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CallesToolStripMenuItem.Click
        frmCalles.Show()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub MaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialesToolStripMenuItem.Click
        frmMateriales.Show()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PozosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PozosToolStripMenuItem.Click
        frmPozos.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        frmServicios.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Empleados.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem.Click
        frmCuentas.Show()
    End Sub

    Private Sub TarifasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifasToolStripMenuItem.Click
        frmTarifas.Show()
    End Sub

    Private Sub SituacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SituacionesToolStripMenuItem.Click
        frmSituaciones.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedores.Show()
    End Sub

    Private Sub ActividadDePozosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActividadDePozosToolStripMenuItem.Click
        frmActividadPozo.Show()
    End Sub

    Private Sub GastosRealizadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosRealizadosToolStripMenuItem.Click
        frmGastosRealizados.Show()
    End Sub

    Private Sub EntradaMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaMaterialToolStripMenuItem.Click
        CompraMateriales.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        ConsultaCompraMateriales.Show()
    End Sub

    Private Sub SalidaMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaMaterialToolStripMenuItem.Click
        SalidaMaterial.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem1.Click
        ConsultaSalidaMaterial.Show()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Pagos.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem2.Click
        ConsultaPagos.Show()
    End Sub

    Private Sub CuentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuentasToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTECUENTAS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteCuenta.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub ClientesPorCalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesPorCalleToolStripMenuItem.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTECUENTASPORCALLES", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteCuentaPorCalles.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub CallesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CallesToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTECALLES", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteCalles.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub MaterialesConExistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialesConExistenciaToolStripMenuItem.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEMATERIALESCONEXISTENCIA", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteMaterialesConExistencia.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEEMPLEADOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteEmpleados.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub GastosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEGASTOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteGastos.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub TarifasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TarifasToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTETARIFAS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteTarifas.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub PozosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PozosToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEPOZOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReportePozos.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEPROVEEDORES", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteProveedores.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub ServiciosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTESERVICIOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteServicios.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub ComprasPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorPeriodoToolStripMenuItem.Click
        ReporteEntradaMaterialPeriodo.ShowDialog()
    End Sub

    Private Sub GastosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosPorPeriodoToolStripMenuItem.Click
        ReporteGastosPer.ShowDialog()
    End Sub

    Private Sub SalidaMaterialPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaMaterialPorPeriodoToolStripMenuItem.Click
        ReporteSalidaMatPer.ShowDialog()
    End Sub

    Private Sub PagosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosPorPeriodoToolStripMenuItem.Click
        ReportePagosPer.ShowDialog()
    End Sub

    Private Sub ActividadDePozosEnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActividadDePozosEnPeriodoToolStripMenuItem.Click
        ReporteActividadPozoPer.ShowDialog()
    End Sub

    Private Sub ClientesMorososToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesMorososToolStripMenuItem.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTECLIENTESMOROSOSPER", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesSin\ReporteClientesMorosos.rdlc"
        Reporte.ReportViewer1.RefreshReport()
        Reporte.Show()
        CONEXION.Close()
    End Sub

    Private Sub HistorialDePagosPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDePagosPorClienteToolStripMenuItem.Click
        ReportePagosPorCuenta.ShowDialog()
    End Sub

    Private Sub ServiciosAtendidosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosAtendidosPorPeriodoToolStripMenuItem.Click
        ReporteServiciosAtendidos.ShowDialog()
    End Sub
End Class