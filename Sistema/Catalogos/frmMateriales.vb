Public Class frmMateriales
    Private Sub frmMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Materiales' Puede moverla o quitarla según sea necesario.
        Me.MaterialesTableAdapter.Fill(Me.DataSetSistema.Materiales)
        cbUnidadMedida.Text = "PIEZA"
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = MaterialesBindingSource.Count + 1
        MaterialesBindingSource.AddNew()
        txtidMaterial.Text = n
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        txtDescripcion.Enabled = True
        txtExistencias.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        txtCosto.Enabled = True
        dtpUltimaFechaCompra.Enabled = True
        cbUnidadMedida.Enabled = True
        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtCosto.Text.Equals("") And Not txtDescripcion.Text.Equals("") And Not txtExistencias.Text.Equals("") And Not txtMaximo.Text.Equals("") And Not txtMinimo.Text.Equals("") Then
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            MaterialesBindingSource.Current(1) = dtpUltimaFechaCompra.Value.Date
            MaterialesBindingSource.Current(7) = cbUnidadMedida.Text
            txtDescripcion.Enabled = True
            txtExistencias.Enabled = True
            txtMaximo.Enabled = True
            txtMinimo.Enabled = True
            txtCosto.Enabled = True
            dtpUltimaFechaCompra.Enabled = True
            cbUnidadMedida.Enabled = True
            cmdGrabar.Enabled = False
            cmdCancelar.Enabled = False
            cmdNuevo.Enabled = True
            cmdSalir.Enabled = True
            dgMateriales.Refresh()
        Else
            MsgBox("Llene todos los campos")
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        MaterialesBindingSource.EndEdit()
        Me.MaterialesTableAdapter.Update(Me.DataSetSistema.Materiales)
        Me.Dispose()
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        MaterialesBindingSource.MoveFirst()
        dtpUltimaFechaCompra.Value = MaterialesBindingSource.Current(1)
        cbUnidadMedida.Text = MaterialesBindingSource.Current(7)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        MaterialesBindingSource.MoveNext()
        dtpUltimaFechaCompra.Value = MaterialesBindingSource.Current(1)
        cbUnidadMedida.Text = MaterialesBindingSource.Current(7)
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        MaterialesBindingSource.MovePrevious()
        dtpUltimaFechaCompra.Value = MaterialesBindingSource.Current(1)
        cbUnidadMedida.Text = MaterialesBindingSource.Current(7)
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        MaterialesBindingSource.MoveLast()
        dtpUltimaFechaCompra.Value = MaterialesBindingSource.Current(1)
        cbUnidadMedida.Text = MaterialesBindingSource.Current(7)
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        MaterialesBindingSource.CancelEdit()
    End Sub
End Class