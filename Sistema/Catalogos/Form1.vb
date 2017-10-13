Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Gastos' Puede moverla o quitarla según sea necesario.
        Me.GastosTableAdapter.Fill(Me.DataSetSistema.Gastos)

    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtConcepto.Text.Equals("") Then
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            txtConcepto.Enabled = False
            cmdGrabar.Enabled = False
            cmdSalir.Enabled = True
            cmdNuevo.Enabled = True
            cmdCancelar.Enabled = False
            dgGastos.Refresh()
        Else
            MsgBox("Ponga un concepto del gasto")
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        GastosBindingSource.EndEdit()
        Me.GastosTableAdapter.Update(Me.DataSetSistema.Gastos)
        Me.Dispose()
    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        GastosBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        GastosBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        GastosBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        GastosBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = GastosBindingSource.Count + 1
        GastosBindingSource.AddNew()
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        txtidGastos.Text = n
        txtConcepto.Enabled = True
        cmdNuevo.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True
        cmdSalir.Enabled = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        GastosBindingSource.CancelEdit()
    End Sub
End Class
