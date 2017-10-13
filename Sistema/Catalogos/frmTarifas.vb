Public Class frmTarifas
    Private Sub frmTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Tarifas' Puede moverla o quitarla según sea necesario.
        Me.TarifasTableAdapter.Fill(Me.DataSetSistema.Tarifas)

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = TarifasBindingSource.Count + 1
        TarifasBindingSource.AddNew()
        txtidTarifa.Text = n
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        dtpAnio.Enabled = True
        txtCF.Enabled = True
        txtINFRA.Enabled = True
        txtRecargo.Enabled = True
        txtTAR.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        TarifasBindingSource.Current(1) = dtpAnio.Value.Date
        cmdAnterior.Enabled = True
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdUltimo.Enabled = True
        dtpAnio.Enabled = True
        txtCF.Enabled = True
        txtINFRA.Enabled = True
        txtRecargo.Enabled = True
        txtTAR.Enabled = True
        cmdGrabar.Enabled = False
        cmdNuevo.Enabled = True
        cmdCancelar.Enabled = False
        dgTarifas.Refresh()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        TarifasBindingSource.EndEdit()
        Me.TarifasTableAdapter.Update(Me.DataSetSistema.Tarifas)
        Me.Dispose()
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        TarifasBindingSource.MoveFirst()
        dtpAnio.Value = TarifasBindingSource.Current(1)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        TarifasBindingSource.MoveNext()
        dtpAnio.Value = TarifasBindingSource.Current(1)
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        TarifasBindingSource.MovePrevious()
        dtpAnio.Value = TarifasBindingSource.Current(1)
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        TarifasBindingSource.MoveLast()
        dtpAnio.Value = TarifasBindingSource.Current(1)
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        TarifasBindingSource.CancelEdit()
    End Sub
End Class