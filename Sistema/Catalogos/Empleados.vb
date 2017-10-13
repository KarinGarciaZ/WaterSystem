Public Class Empleados
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DataSetSistema.Empleados)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        EmpleadosBindingSource.MoveFirst()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = EmpleadosBindingSource.Count + 1
        EmpleadosBindingSource.AddNew()
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        txtidEmpleado.Text = n
        txtColonia.Enabled = True
        txtCP.Enabled = True
        txtDomicilio.Enabled = True
        txtNombre.Enabled = True
        txtTelCasa.Enabled = True
        txtTelefono.Enabled = True
        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        EmpleadosBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        EmpleadosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        EmpleadosBindingSource.MoveLast()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtColonia.Text.Equals("") And Not txtCP.Text.Equals("") And Not txtDomicilio.Text.Equals("") And Not txtNombre.Text.Equals("") And Not txtTelCasa.Text.Equals("") And Not txtTelefono.Text.Equals("") Then
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            txtColonia.Enabled = False
            txtCP.Enabled = False
            txtDomicilio.Enabled = False
            txtidEmpleado.Enabled = False
            txtNombre.Enabled = False
            txtTelCasa.Enabled = False
            txtTelefono.Enabled = False
            cmdGrabar.Enabled = False
            cmdSalir.Enabled = True
            cmdNuevo.Enabled = True
            cmdCancelar.Enabled = False
            dgEmpleados.Refresh()
        Else
            MsgBox("Llene todos los campos")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        EmpleadosBindingSource.EndEdit()
        Me.EmpleadosTableAdapter.Update(Me.DataSetSistema.Empleados)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        EmpleadosBindingSource.CancelEdit()
    End Sub
End Class