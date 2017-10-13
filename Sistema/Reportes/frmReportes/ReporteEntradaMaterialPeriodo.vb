﻿Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class ReporteEntradaMaterialPeriodo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CONEXION As New SqlConnection("Data Source= KARINSPC;Initial Catalog= SistemaAgua;Integrated security=True")
        CONEXION.Open()
        Dim cmd As New SqlCommand("REPORTECOMPRASPER", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter()
        adaptador.SelectCommand = New SqlCommand
        adaptador.SelectCommand.Connection = CONEXION
        adaptador.SelectCommand.CommandText = "REPORTECOMPRASPER"
        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim param1 = New SqlParameter("@FECHA1", SqlDbType.Date)
        Dim param2 = New SqlParameter("@FECHA2", SqlDbType.Date)
        param1.Direction = ParameterDirection.Input
        param2.Direction = ParameterDirection.Input
        param1.Value = CDate(DateTimePicker1.Text)
        param2.Value = CDate(DateTimePicker2.Text)
        adaptador.SelectCommand.Parameters.Add(param1)
        adaptador.SelectCommand.Parameters.Add(param2)
        Dim dataset As New DataSet
        adaptador.Fill(dataset)
        dataset.DataSetName = "DataSet1"
        Dim datasource As New ReportDataSource("DataSet1", dataset.Tables(0))
        datasource.Name = "DataSet1"
        datasource.Value = dataset.Tables(0)
        Dim p1 As New ReportParameter("F1", CDate(DateTimePicker1.Text))
        Dim p2 As New ReportParameter("F2", CDate(DateTimePicker2.Text))
        Reporte.ReportViewer1.LocalReport.DataSources.Clear()
        Reporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Reporte.ReportViewer1.LocalReport.ReportPath = "C:\DesImpSist\5\Sistema\Sistema\Reportes\ReportesPar\ReporteComprasPer.rdlc"
        Reporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        Reporte.ReportViewer1.RefreshReport()
        Reporte.ShowDialog()
        CONEXION.Close()
    End Sub

End Class