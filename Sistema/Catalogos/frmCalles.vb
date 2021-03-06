﻿Public Class frmCalles
    Private Sub frmCalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Gastos' Puede moverla o quitarla según sea necesario.
        Me.GastosTableAdapter.Fill(Me.DataSetSistema.Gastos)
        'TODO: esta línea de código carga datos en la tabla 'DataSetSistema.Calles' Puede moverla o quitarla según sea necesario.
        Me.CallesTableAdapter.Fill(Me.DataSetSistema.Calles)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CallesBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CallesBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CallesBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CallesBindingSource.MoveLast()
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Dim n As Integer
        n = CallesBindingSource.Count + 1
        CallesBindingSource.AddNew()
        cmdAnterior.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdUltimo.Enabled = False
        txtidCalles.Text = n
        txtNombre.Enabled = True
        txtColonia.Enabled = True
        txtCP.Enabled = True
        cmdNuevo.Enabled = False
        cmdSalir.Enabled = False
        cmdCancelar.Enabled = True
        cmdGrabar.Enabled = True
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CallesBindingSource.EndEdit()
        Me.CallesTableAdapter.Update(Me.DataSetSistema.Calles)
        Me.Dispose()
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        If Not txtColonia.Text.Equals("") And Not txtCP.Text.Equals("") And Not txtNombre.Text.Equals("") Then
            CallesBindingSource.Current(4) = "0"
            cmdAnterior.Enabled = True
            cmdInicio.Enabled = True
            cmdSiguiente.Enabled = True
            cmdUltimo.Enabled = True
            txtNombre.Enabled = False
            txtColonia.Enabled = False
            txtCP.Enabled = False
            cmdGrabar.Enabled = False
            cmdSalir.Enabled = True
            cmdNuevo.Enabled = True
            cmdCancelar.Enabled = False
            dgCalles.Refresh()
        Else
            MsgBox("Llene todos los campos")
        End If

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        CallesBindingSource.CancelEdit()
    End Sub
End Class