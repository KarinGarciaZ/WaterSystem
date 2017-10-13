<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCuentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbCalle = New System.Windows.Forms.ComboBox()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.CallesTableAdapter = New Sistema.DataSetSistemaTableAdapters.CallesTableAdapter()
        Me.dgCuentas = New System.Windows.Forms.DataGridView()
        Me.IdCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoExteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoInteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoAnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoPagoMesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentaTableAdapter = New Sistema.DataSetSistemaTableAdapters.CuentaTableAdapter()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.txtNoExterior = New System.Windows.Forms.TextBox()
        Me.txtNoInterior = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCalle
        '
        Me.cbCalle.DataSource = Me.CallesBindingSource
        Me.cbCalle.DisplayMember = "nombre"
        Me.cbCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCalle.Enabled = False
        Me.cbCalle.FormattingEnabled = True
        Me.cbCalle.Location = New System.Drawing.Point(105, 78)
        Me.cbCalle.Name = "cbCalle"
        Me.cbCalle.Size = New System.Drawing.Size(121, 21)
        Me.cbCalle.TabIndex = 0
        Me.cbCalle.ValueMember = "idCalle"
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "Calles"
        Me.CallesBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'dgCuentas
        '
        Me.dgCuentas.AutoGenerateColumns = False
        Me.dgCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCuentaDataGridViewTextBoxColumn, Me.IdCalleDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.NoExteriorDataGridViewTextBoxColumn, Me.NoInteriorDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.UltimoPagoAnioDataGridViewTextBoxColumn, Me.UltimoPagoMesDataGridViewTextBoxColumn})
        Me.dgCuentas.DataSource = Me.CuentaBindingSource
        Me.dgCuentas.Location = New System.Drawing.Point(1, 150)
        Me.dgCuentas.Name = "dgCuentas"
        Me.dgCuentas.Size = New System.Drawing.Size(753, 188)
        Me.dgCuentas.TabIndex = 1
        '
        'IdCuentaDataGridViewTextBoxColumn
        '
        Me.IdCuentaDataGridViewTextBoxColumn.DataPropertyName = "idCuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.HeaderText = "idCuenta"
        Me.IdCuentaDataGridViewTextBoxColumn.Name = "IdCuentaDataGridViewTextBoxColumn"
        Me.IdCuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCuentaDataGridViewTextBoxColumn.Width = 50
        '
        'IdCalleDataGridViewTextBoxColumn
        '
        Me.IdCalleDataGridViewTextBoxColumn.DataPropertyName = "idCalle"
        Me.IdCalleDataGridViewTextBoxColumn.HeaderText = "idCalle"
        Me.IdCalleDataGridViewTextBoxColumn.Name = "IdCalleDataGridViewTextBoxColumn"
        Me.IdCalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCalleDataGridViewTextBoxColumn.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 200
        '
        'NoExteriorDataGridViewTextBoxColumn
        '
        Me.NoExteriorDataGridViewTextBoxColumn.DataPropertyName = "noExterior"
        Me.NoExteriorDataGridViewTextBoxColumn.HeaderText = "noExterior"
        Me.NoExteriorDataGridViewTextBoxColumn.Name = "NoExteriorDataGridViewTextBoxColumn"
        Me.NoExteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoExteriorDataGridViewTextBoxColumn.Width = 50
        '
        'NoInteriorDataGridViewTextBoxColumn
        '
        Me.NoInteriorDataGridViewTextBoxColumn.DataPropertyName = "noInterior"
        Me.NoInteriorDataGridViewTextBoxColumn.HeaderText = "noInterior"
        Me.NoInteriorDataGridViewTextBoxColumn.Name = "NoInteriorDataGridViewTextBoxColumn"
        Me.NoInteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoInteriorDataGridViewTextBoxColumn.Width = 50
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "fechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoAnioDataGridViewTextBoxColumn
        '
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoAnio"
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.HeaderText = "ultimoPagoAnio"
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.Name = "UltimoPagoAnioDataGridViewTextBoxColumn"
        Me.UltimoPagoAnioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UltimoPagoMesDataGridViewTextBoxColumn
        '
        Me.UltimoPagoMesDataGridViewTextBoxColumn.DataPropertyName = "ultimoPagoMes"
        Me.UltimoPagoMesDataGridViewTextBoxColumn.HeaderText = "ultimoPagoMes"
        Me.UltimoPagoMesDataGridViewTextBoxColumn.Name = "UltimoPagoMesDataGridViewTextBoxColumn"
        Me.UltimoPagoMesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuentaBindingSource
        '
        Me.CuentaBindingSource.DataMember = "Cuenta"
        Me.CuentaBindingSource.DataSource = Me.DataSetSistema
        '
        'CuentaTableAdapter
        '
        Me.CuentaTableAdapter.ClearBeforeFill = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(454, 12)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(57, 23)
        Me.cmdUltimo.TabIndex = 27
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(391, 12)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(57, 23)
        Me.cmdAnterior.TabIndex = 26
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(313, 12)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(72, 23)
        Me.cmdSiguiente.TabIndex = 25
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(250, 12)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(57, 23)
        Me.cmdInicio.TabIndex = 24
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(601, 347)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 43)
        Me.cmdSalir.TabIndex = 30
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(227, 347)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 43)
        Me.cmdGrabar.TabIndex = 29
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(40, 347)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 43)
        Me.cmdNuevo.TabIndex = 28
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(37, 57)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(52, 13)
        Me.label.TabIndex = 31
        Me.label.Text = "idCuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Calle:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(432, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "No.Exterior:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(432, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "No.Interior:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(431, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Fecha alta:"
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Enabled = False
        Me.dtpFechaAlta.Location = New System.Drawing.Point(521, 51)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaAlta.TabIndex = 41
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaBindingSource, "nombre", True))
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(105, 109)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(269, 20)
        Me.txtNombre.TabIndex = 42
        '
        'txtidCuenta
        '
        Me.txtidCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaBindingSource, "idCuenta", True))
        Me.txtidCuenta.Enabled = False
        Me.txtidCuenta.Location = New System.Drawing.Point(105, 50)
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.Size = New System.Drawing.Size(61, 20)
        Me.txtidCuenta.TabIndex = 43
        '
        'txtNoExterior
        '
        Me.txtNoExterior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaBindingSource, "noExterior", True))
        Me.txtNoExterior.Enabled = False
        Me.txtNoExterior.Location = New System.Drawing.Point(500, 80)
        Me.txtNoExterior.Name = "txtNoExterior"
        Me.txtNoExterior.Size = New System.Drawing.Size(61, 20)
        Me.txtNoExterior.TabIndex = 44
        '
        'txtNoInterior
        '
        Me.txtNoInterior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaBindingSource, "noInterior", True))
        Me.txtNoInterior.Enabled = False
        Me.txtNoInterior.Location = New System.Drawing.Point(500, 112)
        Me.txtNoInterior.Name = "txtNoInterior"
        Me.txtNoInterior.Size = New System.Drawing.Size(61, 20)
        Me.txtNoInterior.TabIndex = 45
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Location = New System.Drawing.Point(414, 347)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 43)
        Me.cmdCancelar.TabIndex = 46
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.txtNoInterior)
        Me.Controls.Add(Me.txtNoExterior)
        Me.Controls.Add(Me.txtidCuenta)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dtpFechaAlta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.dgCuentas)
        Me.Controls.Add(Me.cbCalle)
        Me.Name = "frmCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCuentas"
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCalle As ComboBox
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents CallesBindingSource As BindingSource
    Friend WithEvents CallesTableAdapter As DataSetSistemaTableAdapters.CallesTableAdapter
    Friend WithEvents dgCuentas As DataGridView
    Friend WithEvents CuentaBindingSource As BindingSource
    Friend WithEvents CuentaTableAdapter As DataSetSistemaTableAdapters.CuentaTableAdapter
    Friend WithEvents IdCuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoExteriorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoInteriorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoAnioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimoPagoMesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaAlta As DateTimePicker
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtidCuenta As TextBox
    Friend WithEvents txtNoExterior As TextBox
    Friend WithEvents txtNoInterior As TextBox
    Friend WithEvents cmdCancelar As Button
End Class
