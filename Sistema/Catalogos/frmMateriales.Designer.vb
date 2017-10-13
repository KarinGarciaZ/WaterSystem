<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateriales
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
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.dgMateriales = New System.Windows.Forms.DataGridView()
        Me.IdMaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimaFechaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtidMaterial = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtExistencias = New System.Windows.Forms.TextBox()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.dtpUltimaFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.cbUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.MaterialesTableAdapter = New Sistema.DataSetSistemaTableAdapters.MaterialesTableAdapter()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Location = New System.Drawing.Point(484, 12)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(57, 23)
        Me.cmdUltimo.TabIndex = 19
        Me.cmdUltimo.Text = "Ultimo"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Location = New System.Drawing.Point(421, 12)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(57, 23)
        Me.cmdAnterior.TabIndex = 18
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Location = New System.Drawing.Point(343, 12)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(72, 23)
        Me.cmdSiguiente.TabIndex = 17
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Location = New System.Drawing.Point(280, 12)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(57, 23)
        Me.cmdInicio.TabIndex = 16
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(639, 351)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(128, 47)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(267, 351)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(128, 47)
        Me.cmdGrabar.TabIndex = 21
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(81, 350)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(128, 47)
        Me.cmdNuevo.TabIndex = 20
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'dgMateriales
        '
        Me.dgMateriales.AutoGenerateColumns = False
        Me.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMaterialDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.MinimoDataGridViewTextBoxColumn, Me.MaximoDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.UnidadMedidaDataGridViewTextBoxColumn, Me.UltimaFechaCompraDataGridViewTextBoxColumn})
        Me.dgMateriales.DataSource = Me.MaterialesBindingSource
        Me.dgMateriales.Location = New System.Drawing.Point(1, 166)
        Me.dgMateriales.Name = "dgMateriales"
        Me.dgMateriales.Size = New System.Drawing.Size(843, 179)
        Me.dgMateriales.TabIndex = 23
        '
        'IdMaterialDataGridViewTextBoxColumn
        '
        Me.IdMaterialDataGridViewTextBoxColumn.DataPropertyName = "idMaterial"
        Me.IdMaterialDataGridViewTextBoxColumn.HeaderText = "idMaterial"
        Me.IdMaterialDataGridViewTextBoxColumn.Name = "IdMaterialDataGridViewTextBoxColumn"
        Me.IdMaterialDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.Width = 90
        '
        'MinimoDataGridViewTextBoxColumn
        '
        Me.MinimoDataGridViewTextBoxColumn.DataPropertyName = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.HeaderText = "minimo"
        Me.MinimoDataGridViewTextBoxColumn.Name = "MinimoDataGridViewTextBoxColumn"
        Me.MinimoDataGridViewTextBoxColumn.Width = 90
        '
        'MaximoDataGridViewTextBoxColumn
        '
        Me.MaximoDataGridViewTextBoxColumn.DataPropertyName = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.HeaderText = "maximo"
        Me.MaximoDataGridViewTextBoxColumn.Name = "MaximoDataGridViewTextBoxColumn"
        Me.MaximoDataGridViewTextBoxColumn.Width = 90
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.Width = 90
        '
        'UnidadMedidaDataGridViewTextBoxColumn
        '
        Me.UnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "unidadMedida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.HeaderText = "unidadMedida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.Name = "UnidadMedidaDataGridViewTextBoxColumn"
        '
        'UltimaFechaCompraDataGridViewTextBoxColumn
        '
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.DataPropertyName = "ultimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.HeaderText = "ultimaFechaCompra"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.Name = "UltimaFechaCompraDataGridViewTextBoxColumn"
        Me.UltimaFechaCompraDataGridViewTextBoxColumn.Width = 90
        '
        'MaterialesBindingSource
        '
        Me.MaterialesBindingSource.DataMember = "Materiales"
        Me.MaterialesBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "idMaterial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Existencias:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Mínimo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(439, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Máximo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(439, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Costo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(439, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Unidad de Medida:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(439, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Última fecha de compra:"
        '
        'txtidMaterial
        '
        Me.txtidMaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "idMaterial", True))
        Me.txtidMaterial.Enabled = False
        Me.txtidMaterial.Location = New System.Drawing.Point(81, 60)
        Me.txtidMaterial.Name = "txtidMaterial"
        Me.txtidMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtidMaterial.TabIndex = 32
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(81, 83)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(199, 20)
        Me.txtDescripcion.TabIndex = 33
        '
        'txtExistencias
        '
        Me.txtExistencias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "existencia", True))
        Me.txtExistencias.Enabled = False
        Me.txtExistencias.Location = New System.Drawing.Point(81, 109)
        Me.txtExistencias.Name = "txtExistencias"
        Me.txtExistencias.Size = New System.Drawing.Size(100, 20)
        Me.txtExistencias.TabIndex = 34
        '
        'txtMinimo
        '
        Me.txtMinimo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "minimo", True))
        Me.txtMinimo.Enabled = False
        Me.txtMinimo.Location = New System.Drawing.Point(81, 136)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMinimo.TabIndex = 35
        '
        'txtMaximo
        '
        Me.txtMaximo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "maximo", True))
        Me.txtMaximo.Enabled = False
        Me.txtMaximo.Location = New System.Drawing.Point(567, 57)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximo.TabIndex = 36
        '
        'txtCosto
        '
        Me.txtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaterialesBindingSource, "costo", True))
        Me.txtCosto.Enabled = False
        Me.txtCosto.Location = New System.Drawing.Point(567, 83)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 37
        '
        'dtpUltimaFechaCompra
        '
        Me.dtpUltimaFechaCompra.Enabled = False
        Me.dtpUltimaFechaCompra.Location = New System.Drawing.Point(567, 136)
        Me.dtpUltimaFechaCompra.Name = "dtpUltimaFechaCompra"
        Me.dtpUltimaFechaCompra.Size = New System.Drawing.Size(200, 20)
        Me.dtpUltimaFechaCompra.TabIndex = 39
        '
        'cbUnidadMedida
        '
        Me.cbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidadMedida.Enabled = False
        Me.cbUnidadMedida.FormattingEnabled = True
        Me.cbUnidadMedida.Items.AddRange(New Object() {"PIEZA", "LITRO", "GRAMO", "KILOGRAMO", "LIBRA", "CENTIMETRO", "METRO", "PULGADA"})
        Me.cbUnidadMedida.Location = New System.Drawing.Point(567, 109)
        Me.cbUnidadMedida.Name = "cbUnidadMedida"
        Me.cbUnidadMedida.Size = New System.Drawing.Size(121, 21)
        Me.cbUnidadMedida.TabIndex = 40
        '
        'MaterialesTableAdapter
        '
        Me.MaterialesTableAdapter.ClearBeforeFill = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Location = New System.Drawing.Point(453, 351)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(128, 47)
        Me.cmdCancelar.TabIndex = 47
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cbUnidadMedida)
        Me.Controls.Add(Me.dtpUltimaFechaCompra)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.txtExistencias)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtidMaterial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMateriales)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdInicio)
        Me.Name = "frmMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMateriales"
        CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents dgMateriales As DataGridView
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents MaterialesBindingSource As BindingSource
    Friend WithEvents MaterialesTableAdapter As DataSetSistemaTableAdapters.MaterialesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtidMaterial As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents txtMinimo As TextBox
    Friend WithEvents txtMaximo As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents dtpUltimaFechaCompra As DateTimePicker
    Friend WithEvents cbUnidadMedida As ComboBox
    Friend WithEvents IdMaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UltimaFechaCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdCancelar As Button
End Class
