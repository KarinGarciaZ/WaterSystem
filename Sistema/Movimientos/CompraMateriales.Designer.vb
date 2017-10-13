<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraMateriales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.mtbDomicilio = New System.Windows.Forms.MaskedTextBox()
        Me.mtbidProveedores = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbOrden = New System.Windows.Forms.MaskedTextBox()
        Me.mtbFactura = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.mtbCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mtbCosto = New System.Windows.Forms.MaskedTextBox()
        Me.mtbMinimo = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mtbMaximo = New System.Windows.Forms.MaskedTextBox()
        Me.mtbExistencia = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mtbCostoAnterior = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtbUM = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mtbidMaterial = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgCompraMateriales = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgCompraMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbProveedores)
        Me.GroupBox1.Controls.Add(Me.mtbTelefono)
        Me.GroupBox1.Controls.Add(Me.mtbDomicilio)
        Me.GroupBox1.Controls.Add(Me.mtbidProveedores)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbProveedores
        '
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(71, 13)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(214, 21)
        Me.cbProveedores.TabIndex = 7
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Enabled = False
        Me.mtbTelefono.Location = New System.Drawing.Point(64, 51)
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(113, 20)
        Me.mtbTelefono.TabIndex = 6
        '
        'mtbDomicilio
        '
        Me.mtbDomicilio.Enabled = False
        Me.mtbDomicilio.Location = New System.Drawing.Point(246, 51)
        Me.mtbDomicilio.Name = "mtbDomicilio"
        Me.mtbDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.mtbDomicilio.TabIndex = 5
        '
        'mtbidProveedores
        '
        Me.mtbidProveedores.Enabled = False
        Me.mtbidProveedores.Location = New System.Drawing.Point(364, 13)
        Me.mtbidProveedores.Name = "mtbidProveedores"
        Me.mtbidProveedores.Size = New System.Drawing.Size(82, 20)
        Me.mtbidProveedores.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "idProveedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        '
        'mtbOrden
        '
        Me.mtbOrden.Enabled = False
        Me.mtbOrden.Location = New System.Drawing.Point(561, 28)
        Me.mtbOrden.Name = "mtbOrden"
        Me.mtbOrden.Size = New System.Drawing.Size(75, 20)
        Me.mtbOrden.TabIndex = 7
        '
        'mtbFactura
        '
        Me.mtbFactura.Enabled = False
        Me.mtbFactura.Location = New System.Drawing.Point(561, 54)
        Me.mtbFactura.Name = "mtbFactura"
        Me.mtbFactura.Size = New System.Drawing.Size(200, 20)
        Me.mtbFactura.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(561, 80)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.mtbCantidad)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.mtbCosto)
        Me.GroupBox2.Controls.Add(Me.mtbMinimo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.mtbMaximo)
        Me.GroupBox2.Controls.Add(Me.mtbExistencia)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.mtbCostoAnterior)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.mtbUM)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.mtbidMaterial)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbMaterial)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 124)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(260, 85)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(230, 30)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(607, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Cantidad:"
        '
        'mtbCantidad
        '
        Me.mtbCantidad.Enabled = False
        Me.mtbCantidad.Location = New System.Drawing.Point(665, 49)
        Me.mtbCantidad.Mask = "9999999.999"
        Me.mtbCantidad.Name = "mtbCantidad"
        Me.mtbCantidad.Size = New System.Drawing.Size(71, 20)
        Me.mtbCantidad.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(622, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Costo:"
        '
        'mtbCosto
        '
        Me.mtbCosto.Enabled = False
        Me.mtbCosto.Location = New System.Drawing.Point(665, 13)
        Me.mtbCosto.Mask = "9999999.99"
        Me.mtbCosto.Name = "mtbCosto"
        Me.mtbCosto.Size = New System.Drawing.Size(71, 20)
        Me.mtbCosto.TabIndex = 24
        '
        'mtbMinimo
        '
        Me.mtbMinimo.Enabled = False
        Me.mtbMinimo.Location = New System.Drawing.Point(519, 49)
        Me.mtbMinimo.Name = "mtbMinimo"
        Me.mtbMinimo.Size = New System.Drawing.Size(82, 20)
        Me.mtbMinimo.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(470, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Minimo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(328, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Maximo:"
        '
        'mtbMaximo
        '
        Me.mtbMaximo.Enabled = False
        Me.mtbMaximo.Location = New System.Drawing.Point(380, 49)
        Me.mtbMaximo.Name = "mtbMaximo"
        Me.mtbMaximo.Size = New System.Drawing.Size(82, 20)
        Me.mtbMaximo.TabIndex = 17
        '
        'mtbExistencia
        '
        Me.mtbExistencia.Enabled = False
        Me.mtbExistencia.Location = New System.Drawing.Point(240, 49)
        Me.mtbExistencia.Name = "mtbExistencia"
        Me.mtbExistencia.Size = New System.Drawing.Size(82, 20)
        Me.mtbExistencia.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(176, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Existencia:"
        '
        'mtbCostoAnterior
        '
        Me.mtbCostoAnterior.Enabled = False
        Me.mtbCostoAnterior.Location = New System.Drawing.Point(84, 49)
        Me.mtbCostoAnterior.Name = "mtbCostoAnterior"
        Me.mtbCostoAnterior.Size = New System.Drawing.Size(80, 20)
        Me.mtbCostoAnterior.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Costo Anterior:"
        '
        'mtbUM
        '
        Me.mtbUM.Enabled = False
        Me.mtbUM.Location = New System.Drawing.Point(536, 13)
        Me.mtbUM.Name = "mtbUM"
        Me.mtbUM.Size = New System.Drawing.Size(80, 20)
        Me.mtbUM.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(436, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Unidad de Medida:"
        '
        'mtbidMaterial
        '
        Me.mtbidMaterial.Enabled = False
        Me.mtbidMaterial.Location = New System.Drawing.Point(348, 13)
        Me.mtbidMaterial.Name = "mtbidMaterial"
        Me.mtbidMaterial.Size = New System.Drawing.Size(82, 20)
        Me.mtbidMaterial.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(291, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "idMaterial:"
        '
        'cbMaterial
        '
        Me.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaterial.FormattingEnabled = True
        Me.cbMaterial.Location = New System.Drawing.Point(64, 13)
        Me.cbMaterial.Name = "cbMaterial"
        Me.cbMaterial.Size = New System.Drawing.Size(214, 21)
        Me.cbMaterial.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(502, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Orden:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(502, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Factura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(502, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha:"
        '
        'dgCompraMateriales
        '
        Me.dgCompraMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompraMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.Material, Me.Cantidad, Me.Costo, Me.Importe})
        Me.dgCompraMateriales.Location = New System.Drawing.Point(44, 254)
        Me.dgCompraMateriales.Name = "dgCompraMateriales"
        Me.dgCompraMateriales.Size = New System.Drawing.Size(695, 155)
        Me.dgCompraMateriales.TabIndex = 13
        '
        'idMaterial
        '
        Me.idMaterial.HeaderText = "idMaterial"
        Me.idMaterial.Name = "idMaterial"
        Me.idMaterial.ReadOnly = True
        '
        'Material
        '
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.ReadOnly = True
        Me.Material.Width = 200
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 150
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(18, 424)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(153, 55)
        Me.cmdNuevo.TabIndex = 14
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(197, 424)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(153, 55)
        Me.cmdGrabar.TabIndex = 15
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(378, 424)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(153, 55)
        Me.cmdSalir.TabIndex = 16
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(560, 424)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Subtotal:      $"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(561, 445)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "IVA:             $"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(561, 469)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Total:           $"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(649, 424)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(28, 13)
        Me.lblSubtotal.TabIndex = 22
        Me.lblSubtotal.Text = "0.00"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(649, 445)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(28, 13)
        Me.lblIVA.TabIndex = 23
        Me.lblIVA.Text = "0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(649, 469)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 13)
        Me.lblTotal.TabIndex = 24
        Me.lblTotal.Text = "0.00"
        '
        'CompraMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgCompraMateriales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.mtbFactura)
        Me.Controls.Add(Me.mtbOrden)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CompraMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CompraMateriales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgCompraMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents mtbDomicilio As MaskedTextBox
    Friend WithEvents mtbidProveedores As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbOrden As MaskedTextBox
    Friend WithEvents mtbFactura As MaskedTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents mtbCantidad As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mtbCosto As MaskedTextBox
    Friend WithEvents mtbMinimo As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents mtbMaximo As MaskedTextBox
    Friend WithEvents mtbExistencia As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents mtbCostoAnterior As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents mtbUM As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents mtbidMaterial As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbMaterial As ComboBox
    Friend WithEvents dgCompraMateriales As DataGridView
    Friend WithEvents idMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblTotal As Label
End Class
