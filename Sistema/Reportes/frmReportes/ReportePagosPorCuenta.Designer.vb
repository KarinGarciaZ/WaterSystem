<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportePagosPorCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCuentas
        '
        Me.dgCuentas.AllowUserToAddRows = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c, Me.Column1, Me.Column6, Me.Column4, Me.Column5})
        Me.dgCuentas.Location = New System.Drawing.Point(12, 89)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.Size = New System.Drawing.Size(760, 218)
        Me.dgCuentas.TabIndex = 21
        '
        'c
        '
        Me.c.FillWeight = 80.0!
        Me.c.HeaderText = "ID Cuenta"
        Me.c.Name = "c"
        '
        'Column1
        '
        Me.Column1.FillWeight = 150.0!
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Calle"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "No. Exterior"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 150.0!
        Me.Column5.HeaderText = "No. Interior"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(243, 52)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(307, 20)
        Me.txtBuscar.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Buscar cuenta por nombre:"
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(363, 315)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(116, 41)
        Me.btnReporte.TabIndex = 22
        Me.btnReporte.Text = "Realizar reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'ReportePagosPorCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 368)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.dgCuentas)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Name = "ReportePagosPorCuenta"
        Me.Text = "ReportePagosPorCuenta"
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgCuentas As DataGridView
    Friend WithEvents txtBuscar As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents c As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btnReporte As Button
End Class
