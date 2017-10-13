Public Class frmCuentas
    Private Sub frmCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Cuenta' Puede moverla o quitarla según sea necesario.
        Me.CuentaTableAdapter.Fill(Me.DataSetSistema.Cuenta)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Cuenta' Puede moverla o quitarla según sea necesario.
        Me.CuentaTableAdapter.Fill(Me.DataSetSistema.Cuenta)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.Calles)

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtNoExterior.Text.Equals("") And Not txtNombre.Text.Equals("") Then
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            CuentaBindingSource.Current(1) = cbCalle.SelectedValue
            CuentaBindingSource.Current(5) = dtpFechaAlta.Value.Date
            CuentaBindingSource.Current(6) = "0"
            CuentaBindingSource.Current(7) = "0"
            txtNoInterior.Enabled = False
            txtNoExterior.Enabled = False
            txtNombre.Enabled = False
            dtpFechaAlta.Enabled = False
            cbCalle.Enabled = False

            cmdGrabar.Enabled = False
            cmdNuevo.Enabled = True
            cmdCancelar.Enabled = False
            cmdSalir.Enabled = True

            Dim n As Integer
            n = cbCalle.SelectedValue
            CallesBindingSource.MoveFirst()
            For i = 0 To CallesBindingSource.Count - 1
                If CallesBindingSource.Current(0) = n Then
                    CallesBindingSource.Current(4) += 1
                End If
                CallesBindingSource.MoveNext()
            Next
            dgCuentas.Refresh()
        Else
            MsgBox("Llene todos los campos")
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CuentaBindingSource.EndEdit()
        CallesBindingSource.EndEdit()
        Me.CuentaTableAdapter.Update(Me.DataSetSistema.Cuenta)
        Me.CallesTableAdapter.Update(Me.DataSetSistema.Calles)
        Me.Dispose()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = CuentaBindingSource.Count + 1
        CuentaBindingSource.AddNew()
        txtidCuenta.Text = n
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        txtNoInterior.Enabled = True
        txtNoExterior.Enabled = True
        txtNombre.Enabled = True
        dtpFechaAlta.Enabled = True
        cbCalle.Enabled = True
        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CuentaBindingSource.MoveFirst()
        'cbCalle.Text = CallesBindingSource.Current(1)
        dtpFechaAlta.Value = CuentaBindingSource.Current(5)
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CuentaBindingSource.MoveNext()
        'cbCalle.Text = CallesBindingSource.Current(1)
        dtpFechaAlta.Value = CuentaBindingSource.Current(5)
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CuentaBindingSource.MovePrevious()
        'cbCalle.Text = CallesBindingSource.Current(1)
        dtpFechaAlta.Value = CuentaBindingSource.Current(5)
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CuentaBindingSource.MoveLast()
        'cbCalle.Text = CallesBindingSource.Current(1)
        dtpFechaAlta.Value = CuentaBindingSource.Current(5)
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        CuentaBindingSource.CancelEdit()
        CallesBindingSource.CancelEdit()
    End Sub
End Class