<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifas
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
        Me.components = New System.ComponentModel.Container()
        Me.dgTarifas = New System.Windows.Forms.DataGridView()
        Me.IdTarifaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INFRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TarifasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.TarifasTableAdapter = New Sistema.DataSetSistemaTableAdapters.TarifasTableAdapter()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtidTarifa = New System.Windows.Forms.TextBox()
        Me.txtCF = New System.Windows.Forms.TextBox()
        Me.txtRecargo = New System.Windows.Forms.TextBox()
        Me.txtTAR = New System.Windows.Forms.TextBox()
        Me.txtINFRA = New System.Windows.Forms.TextBox()
        Me.dtpAnio = New System.Windows.Forms.DateTimePicker()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTarifas
        '
        Me.dgTarifas.AutoGenerateColumns = False
        Me.dgTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTarifas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTarifaDataGridViewTextBoxColumn, Me.AnioDataGridViewTextBoxColumn, Me.CFDataGridViewTextBoxColumn, Me.RecargoDataGridViewTextBoxColumn, Me.TARDataGridViewTextBoxColumn, Me.INFRADataGridViewTextBoxColumn})
        Me.dgTarifas.DataSource = Me.TarifasBindingSource
        Me.dgTarifas.Location = New System.Drawing.Point(7, 167)
        Me.dgTarifas.Name = "dgTarifas"
        Me.dgTarifas.Size = New System.Drawing.Size(594, 150)
        Me.dgTarifas.TabIndex = 0
        '
        'IdTarifaDataGridViewTextBoxColumn
        '
        Me.IdTarifaDataGridViewTextBoxColumn.DataPropertyName = "idTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IdTarifaDataGridViewTextBoxColumn.HeaderText = "idTarifa"
        Me.IdTarifaDataGridViewTextBoxColumn.Name = "IdTarifaDataGridViewTextBoxColumn"
        Me.IdTarifaDataGridViewTextBoxColumn.Width = 50
        '
        'AnioDataGridViewTextBoxColumn
        '
        Me.AnioDataGridViewTextBoxColumn.DataPropertyName = "anio"
        Me.AnioDataGridViewTextBoxColumn.HeaderText = "anio"
        Me.AnioDataGridViewTextBoxColumn.Name = "AnioDataGridViewTextBoxColumn"
        '
        'CFDataGridViewTextBoxColumn
        '
        Me.CFDataGridViewTextBoxColumn.DataPropertyName = "CF"
        Me.CFDataGridViewTextBoxColumn.HeaderText = "CF"
        Me.CFDataGridViewTextBoxColumn.Name = "CFDataGridViewTextBoxColumn"
        '
        'RecargoDataGridViewTextBoxColumn
        '
        Me.RecargoDataGridViewTextBoxColumn.DataPropertyName = "recargo"
        Me.RecargoDataGridViewTextBoxColumn.HeaderText = "recargo"
        Me.RecargoDataGridViewTextBoxColumn.Name = "RecargoDataGridViewTextBoxColumn"
        '
        'TARDataGridViewTextBoxColumn
        '
        Me.TARDataGridViewTextBoxColumn.DataPropertyName = "TAR"
        Me.TARDataGridViewTextBoxColumn.HeaderText = "TAR"
        Me.TARDataGridViewTextBoxColumn.Name = "TARDataGridViewTextBoxColumn"
        '
        'INFRADataGridViewTextBoxColumn
        '
        Me.INFRADataGridViewTextBoxColumn.DataPropertyName = "INFRA"
        Me.INFRADataGridViewTextBoxColumn.HeaderText = "INFRA"
        Me.INFRADataGridViewTextBoxColumn.Name = "INFRADataGridViewTextBoxColumn"
        '
        'TarifasBindingSource
        '
        Me.TarifasBindingSource.DataMember = "Tarifas"
        Me.TarifasBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TarifasTableAdapter
        '
        Me.TarifasTableAdapter.ClearBeforeFill = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(404, 12)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(57, 23)
        Me.cmdUltimo.TabIndex = 23
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(341, 12)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(57, 23)
        Me.cmdAnterior.TabIndex = 22
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(263, 12)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(72, 23)
        Me.cmdSiguiente.TabIndex = 21
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(200, 12)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(57, 23)
        Me.cmdInicio.TabIndex = 20
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(480, 333)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(120, 42)
        Me.cmdSalir.TabIndex = 26
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(168, 333)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(120, 42)
        Me.cmdGrabar.TabIndex = 25
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(12, 333)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(120, 42)
        Me.cmdNuevo.TabIndex = 24
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "idTarifa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "CF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Recargo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "TAR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "INFRA:"
        '
        'txtidTarifa
        '
        Me.txtidTarifa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "idTarifa", True))
        Me.txtidTarifa.Enabled = False
        Me.txtidTarifa.Location = New System.Drawing.Point(144, 59)
        Me.txtidTarifa.Name = "txtidTarifa"
        Me.txtidTarifa.Size = New System.Drawing.Size(100, 20)
        Me.txtidTarifa.TabIndex = 33
        '
        'txtCF
        '
        Me.txtCF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "CF", True))
        Me.txtCF.Enabled = False
        Me.txtCF.Location = New System.Drawing.Point(144, 129)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(100, 20)
        Me.txtCF.TabIndex = 35
        '
        'txtRecargo
        '
        Me.txtRecargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "recargo", True))
        Me.txtRecargo.Enabled = False
        Me.txtRecargo.Location = New System.Drawing.Point(449, 55)
        Me.txtRecargo.Name = "txtRecargo"
        Me.txtRecargo.Size = New System.Drawing.Size(100, 20)
        Me.txtRecargo.TabIndex = 36
        '
        'txtTAR
        '
        Me.txtTAR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "TAR", True))
        Me.txtTAR.Enabled = False
        Me.txtTAR.Location = New System.Drawing.Point(449, 92)
        Me.txtTAR.Name = "txtTAR"
        Me.txtTAR.Size = New System.Drawing.Size(100, 20)
        Me.txtTAR.TabIndex = 37
        '
        'txtINFRA
        '
        Me.txtINFRA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TarifasBindingSource, "INFRA", True))
        Me.txtINFRA.Enabled = False
        Me.txtINFRA.Location = New System.Drawing.Point(449, 129)
        Me.txtINFRA.Name = "txtINFRA"
        Me.txtINFRA.Size = New System.Drawing.Size(100, 20)
        Me.txtINFRA.TabIndex = 38
        '
        'dtpAnio
        '
        Me.dtpAnio.Location = New System.Drawing.Point(144, 92)
        Me.dtpAnio.Name = "dtpAnio"
        Me.dtpAnio.Size = New System.Drawing.Size(200, 20)
        Me.dtpAnio.TabIndex = 39
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Location = New System.Drawing.Point(324, 333)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(120, 42)
        Me.cmdCancelar.TabIndex = 52
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.dtpAnio)
        Me.Controls.Add(Me.txtINFRA)
        Me.Controls.Add(Me.txtTAR)
        Me.Controls.Add(Me.txtRecargo)
        Me.Controls.Add(Me.txtCF)
        Me.Controls.Add(Me.txtidTarifa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Controls.Add(Me.dgTarifas)
        Me.Name = "frmTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTarifas"
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgTarifas As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents TarifasBindingSource As BindingSource
    Friend WithEvents TarifasTableAdapter As DataSetSistemaTableAdapters.TarifasTableAdapter
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtidTarifa As TextBox
    Friend WithEvents txtCF As TextBox
    Friend WithEvents txtRecargo As TextBox
    Friend WithEvents txtTAR As TextBox
    Friend WithEvents txtINFRA As TextBox
    Friend WithEvents dtpAnio As DateTimePicker
    Friend WithEvents IdTarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INFRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As Button
End Class
