Public Class frmProveedores
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.DataSetSistema.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Situacion' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = ProveedoresBindingSource.Count + 1
        ProveedoresBindingSource.AddNew()
        txtidProovedor.Text = n
        txtNombre.Enabled = True
        txtTelefono.Enabled = True
        txtCiudad.Enabled = True
        txtCP.Enabled = True
        txtEmail.Enabled = True
        txtDomicilio.Enabled = True
        cmdAnterior.Enabled = False
        cmdGrabar.Enabled = True
        cmdInicio.Enabled = False
        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdSiguiente.Enabled = False
        cmdCancelar.Enabled = True
        cmdUltimo.Enabled = False

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtNombre.Text.Equals("") And Not txtDomicilio.Text.Equals("") And Not txtCP.Text.Equals("") And Not txtCiudad.Text.Equals("") And Not txtTelefono.Text.Equals("") And Not txtEmail.Text.Equals("") Then
            txtNombre.Enabled = False
            txtTelefono.Enabled = False
            txtCiudad.Enabled = False
            txtCP.Enabled = False
            txtDomicilio.Enabled = False
            cmdAnterior.Enabled = True
            cmdGrabar.Enabled = False
            cmdInicio.Enabled = True
            cmdNuevo.Enabled = True
            cmdCancelar.Enabled = False
            cmdSalir.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            ProveedoresBindingSource.Current(0) = txtidProovedor.Text
            ProveedoresBindingSource.Current(1) = txtNombre.Text
            ProveedoresBindingSource.Current(2) = txtDomicilio.Text
            ProveedoresBindingSource.Current(3) = txtCP.Text
            ProveedoresBindingSource.Current(4) = txtCiudad.Text
            ProveedoresBindingSource.Current(5) = txtTelefono.Text
            ProveedoresBindingSource.Current(6) = txtEmail.Text
            dgProveedores.Refresh()
        Else
            MsgBox("Llene todos los campos")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        ProveedoresBindingSource.EndEdit()
        ProveedoresTableAdapter.Update(DataSetSistema.Proveedores)
        Me.Dispose()
    End Sub



    'Private Sub txtCP_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCP.KeyUp
    '    If (Not Char.IsNumber(ChrW(e.KeyCode))) Then
    '        MessageBox.Show("Solo números.")
    '        txtCP.Text = ""
    '    End If
    'End Sub

    Private Sub txtCP_TextChanged(sender As Object, e As EventArgs) Handles txtCP.TextChanged
        If txtCP.TextLength > 0 Then
            If Not Char.IsNumber(txtCP.Text.Chars(txtCP.TextLength - 1)) Then
                MessageBox.Show("Solo números.")
                txtCP.Text = ""
            End If
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        ProveedoresBindingSource.CancelEdit()
    End Sub
End Class