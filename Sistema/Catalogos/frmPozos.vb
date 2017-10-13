Public Class frmPozos
    Private Sub frmPozos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Pozos' Puede moverla o quitarla según sea necesario.
        Me.PozosTableAdapter.Fill(Me.DataSetSistema.Pozos)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        PozosBindingSource.MoveFirst()
        txtidPozo.Text = PozosBindingSource.Current(0)
        txtUbicacion.Text = PozosBindingSource.Current(1)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        PozosBindingSource.MoveNext()
        txtidPozo.Text = PozosBindingSource.Current(0)
        txtUbicacion.Text = PozosBindingSource.Current(1)
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        PozosBindingSource.MovePrevious()
        txtidPozo.Text = PozosBindingSource.Current(0)
        txtUbicacion.Text = PozosBindingSource.Current(1)
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        PozosBindingSource.MoveLast()
        txtidPozo.Text = PozosBindingSource.Current(0)
        txtUbicacion.Text = PozosBindingSource.Current(1)
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = PozosBindingSource.Count + 1
        PozosBindingSource.AddNew()
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        txtidPozo.Text = n
        txtUbicacion.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtUbicacion.Text.Equals("") Then
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            PozosBindingSource.Current(0) = txtidPozo.Text
            PozosBindingSource.Current(1) = txtUbicacion.Text
            txtUbicacion.Enabled = False
            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            cmdCancelar.Enabled = False
            cmdSalir.Enabled = True
            dgPozos.Refresh()
        Else
            MsgBox("Agregue la ubicacion")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        PozosBindingSource.EndEdit()
        Me.PozosTableAdapter.Update(Me.DataSetSistema.Pozos)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        PozosBindingSource.CancelEdit()
    End Sub
End Class