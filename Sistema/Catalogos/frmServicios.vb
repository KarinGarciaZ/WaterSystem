Public Class frmServicios
    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Servicios' Puede moverla o quitarla según sea necesario.
        Me.ServiciosTableAdapter.Fill(Me.DataSetSistema.Servicios)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ServiciosBindingSource.MoveFirst()
        txtidServicio.Text = ServiciosBindingSource.Current(0)
        txtDescripcion.Text = ServiciosBindingSource.Current(1)
        txtPrecio.Text = ServiciosBindingSource.Current(2)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        ServiciosBindingSource.MoveNext()
        txtidServicio.Text = ServiciosBindingSource.Current(0)
        txtDescripcion.Text = ServiciosBindingSource.Current(1)
        txtPrecio.Text = ServiciosBindingSource.Current(2)
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ServiciosBindingSource.MovePrevious()
        txtidServicio.Text = ServiciosBindingSource.Current(0)
        txtDescripcion.Text = ServiciosBindingSource.Current(1)
        txtPrecio.Text = ServiciosBindingSource.Current(2)
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ServiciosBindingSource.MoveLast()
        txtidServicio.Text = ServiciosBindingSource.Current(0)
        txtDescripcion.Text = ServiciosBindingSource.Current(1)
        txtPrecio.Text = ServiciosBindingSource.Current(2)
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = ServiciosBindingSource.Count + 1
        ServiciosBindingSource.AddNew()
        cmdAnterior.Enabled = False
        cmdSalir.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        txtidServicio.Text = n
        txtDescripcion.Enabled = True
        txtPrecio.Enabled = True
        cmdNuevo.Enabled = False
        cmdCancelar.Enabled = True
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtDescripcion.Text.Equals("") And Not txtPrecio.Text.Equals("") Then
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            ServiciosBindingSource.Current(0) = txtidServicio.Text
            ServiciosBindingSource.Current(1) = txtDescripcion.Text
            ServiciosBindingSource.Current(2) = txtPrecio.Text
            txtDescripcion.Enabled = True
            txtPrecio.Enabled = True
            cmdGrabar.Enabled = False
            cmdSalir.Enabled = True
            cmdCancelar.Enabled = False
            cmdNuevo.Enabled = True
            dgServicios.Refresh()
        Else
            MsgBox("Llene todos los campos")
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        ServiciosBindingSource.EndEdit()
        Me.ServiciosTableAdapter.Update(Me.DataSetSistema.Servicios)
        Me.Dispose()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If txtPrecio.TextLength > 0 Then
            If Not Char.IsNumber(txtPrecio.Text.Chars(txtPrecio.TextLength - 1)) And Not txtPrecio.Text.Chars(txtPrecio.TextLength - 1) = "." Then
                MessageBox.Show("Solo números.")
                txtPrecio.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        ServiciosBindingSource.CancelEdit()
    End Sub
End Class