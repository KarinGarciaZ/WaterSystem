Public Class frmSituaciones
    Private Sub frmSituaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Situacion' Puede moverla o quitarla según sea necesario.
        Me.SituacionTableAdapter.Fill(Me.DataSetSistema.Situacion)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        SituacionBindingSource.MoveFirst()
        txtidSituacion.Text = SituacionBindingSource.Current(0)
        txtDescripcion.Text = SituacionBindingSource.Current(1)
        txtdescuento.Text = SituacionBindingSource.Current(2)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        SituacionBindingSource.MoveNext()
        txtidSituacion.Text = SituacionBindingSource.Current(0)
        txtDescripcion.Text = SituacionBindingSource.Current(1)
        txtdescuento.Text = SituacionBindingSource.Current(2)
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        SituacionBindingSource.MovePrevious()
        txtidSituacion.Text = SituacionBindingSource.Current(0)
        txtDescripcion.Text = SituacionBindingSource.Current(1)
        txtdescuento.Text = SituacionBindingSource.Current(2)
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        SituacionBindingSource.MoveLast()
        txtidSituacion.Text = SituacionBindingSource.Current(0)
        txtDescripcion.Text = SituacionBindingSource.Current(1)
        txtdescuento.Text = SituacionBindingSource.Current(2)
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = SituacionBindingSource.Count + 1
        SituacionBindingSource.AddNew()
        txtidSituacion.Text = n
        txtDescripcion.Enabled = True
        txtdescuento.Enabled = True
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtDescripcion.Text.Equals("") And Not txtdescuento.Text.Equals("") Then
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            cmdNuevo.Enabled = True
            cmdSalir.Enabled = True
            cmdCancelar.Enabled = False
            cmdGrabar.Enabled = False
            SituacionBindingSource.Current(0) = txtidSituacion.Text
            SituacionBindingSource.Current(1) = txtDescripcion.Text
            SituacionBindingSource.Current(2) = txtdescuento.Text
            txtDescripcion.Enabled = False
            txtdescuento.Enabled = False
            dgSituaciones.Refresh()
        Else
            MsgBox("Llene todos los campos")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        SituacionBindingSource.EndEdit()
        SituacionTableAdapter.Update(DataSetSistema.Situacion)
        Me.Dispose()
    End Sub

    Private Sub txtdescuento_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged
        If txtdescuento.TextLength > 0 Then
            If Not Char.IsNumber(txtdescuento.Text.Chars(txtdescuento.TextLength - 1)) Then
                MessageBox.Show("Solo números.")
                txtdescuento.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        SituacionBindingSource.CancelEdit()
    End Sub
End Class