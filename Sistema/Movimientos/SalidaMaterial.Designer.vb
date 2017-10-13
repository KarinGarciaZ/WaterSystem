<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalidaMaterial
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
        Me.dgSalidaMateriales = New System.Windows.Forms.DataGridView()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtmFechaMaterial = New System.Windows.Forms.DateTimePicker()
        Me.mtbCosto = New System.Windows.Forms.MaskedTextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.mtbCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mtbMinimo = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mtbMaximo = New System.Windows.Forms.MaskedTextBox()
        Me.mtbExistencia = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtbUM = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mtbidMaterial = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.mtbConcepto = New System.Windows.Forms.MaskedTextBox()
        Me.mtbidSalida = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbEmpleados = New System.Windows.Forms.ComboBox()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.mtbDomicilio = New System.Windows.Forms.MaskedTextBox()
        Me.mtbidEmpleados = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbTotalCasas = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbCalles = New System.Windows.Forms.ComboBox()
        Me.mtbidCalle = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        CType(Me.dgSalidaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgSalidaMateriales
        '
        Me.dgSalidaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSalidaMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMaterial, Me.Material, Me.Cantidad, Me.Costo, Me.Importe})
        Me.dgSalidaMateriales.Location = New System.Drawing.Point(34, 299)
        Me.dgSalidaMateriales.Name = "dgSalidaMateriales"
        Me.dgSalidaMateriales.Size = New System.Drawing.Size(695, 170)
        Me.dgSalidaMateriales.TabIndex = 22
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(498, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(498, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Concepto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(498, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "idSalida:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtmFechaMaterial)
        Me.GroupBox2.Controls.Add(Me.mtbCosto)
        Me.GroupBox2.Controls.Add(Me.cmdAceptar)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.mtbCantidad)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.mtbMinimo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.mtbMaximo)
        Me.GroupBox2.Controls.Add(Me.mtbExistencia)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.mtbUM)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.mtbidMaterial)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbMaterial)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 124)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'dtmFechaMaterial
        '
        Me.dtmFechaMaterial.Enabled = False
        Me.dtmFechaMaterial.Location = New System.Drawing.Point(52, 88)
        Me.dtmFechaMaterial.Name = "dtmFechaMaterial"
        Me.dtmFechaMaterial.Size = New System.Drawing.Size(200, 20)
        Me.dtmFechaMaterial.TabIndex = 24
        '
        'mtbCosto
        '
        Me.mtbCosto.Enabled = False
        Me.mtbCosto.Location = New System.Drawing.Point(662, 13)
        Me.mtbCosto.Name = "mtbCosto"
        Me.mtbCosto.Size = New System.Drawing.Size(80, 20)
        Me.mtbCosto.TabIndex = 29
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Location = New System.Drawing.Point(380, 85)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(230, 30)
        Me.cmdAceptar.TabIndex = 28
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(578, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Cantidad:"
        '
        'mtbCantidad
        '
        Me.mtbCantidad.Enabled = False
        Me.mtbCantidad.Location = New System.Drawing.Point(636, 48)
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
        'mtbMinimo
        '
        Me.mtbMinimo.Enabled = False
        Me.mtbMinimo.Location = New System.Drawing.Point(468, 48)
        Me.mtbMinimo.Name = "mtbMinimo"
        Me.mtbMinimo.Size = New System.Drawing.Size(82, 20)
        Me.mtbMinimo.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(419, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Minimo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(247, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Maximo:"
        '
        'mtbMaximo
        '
        Me.mtbMaximo.Enabled = False
        Me.mtbMaximo.Location = New System.Drawing.Point(299, 48)
        Me.mtbMaximo.Name = "mtbMaximo"
        Me.mtbMaximo.Size = New System.Drawing.Size(82, 20)
        Me.mtbMaximo.TabIndex = 17
        '
        'mtbExistencia
        '
        Me.mtbExistencia.Enabled = False
        Me.mtbExistencia.Location = New System.Drawing.Point(138, 48)
        Me.mtbExistencia.Name = "mtbExistencia"
        Me.mtbExistencia.Size = New System.Drawing.Size(82, 20)
        Me.mtbExistencia.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Existencia:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Fecha:"
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
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(557, 36)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 18
        '
        'mtbConcepto
        '
        Me.mtbConcepto.Enabled = False
        Me.mtbConcepto.Location = New System.Drawing.Point(557, 62)
        Me.mtbConcepto.Name = "mtbConcepto"
        Me.mtbConcepto.Size = New System.Drawing.Size(200, 20)
        Me.mtbConcepto.TabIndex = 17
        '
        'mtbidSalida
        '
        Me.mtbidSalida.Enabled = False
        Me.mtbidSalida.Location = New System.Drawing.Point(557, 10)
        Me.mtbidSalida.Name = "mtbidSalida"
        Me.mtbidSalida.Size = New System.Drawing.Size(75, 20)
        Me.mtbidSalida.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbEmpleados)
        Me.GroupBox1.Controls.Add(Me.mtbTelefono)
        Me.GroupBox1.Controls.Add(Me.mtbDomicilio)
        Me.GroupBox1.Controls.Add(Me.mtbidEmpleados)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 80)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cbEmpleados
        '
        Me.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleados.FormattingEnabled = True
        Me.cbEmpleados.Location = New System.Drawing.Point(71, 13)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(214, 21)
        Me.cbEmpleados.TabIndex = 7
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
        'mtbidEmpleados
        '
        Me.mtbidEmpleados.Enabled = False
        Me.mtbidEmpleados.Location = New System.Drawing.Point(364, 13)
        Me.mtbidEmpleados.Name = "mtbidEmpleados"
        Me.mtbidEmpleados.Size = New System.Drawing.Size(82, 20)
        Me.mtbidEmpleados.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Celular:"
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
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "idEmpleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtbTotalCasas)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.cbCalles)
        Me.GroupBox3.Controls.Add(Me.mtbidCalle)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(742, 55)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'mtbTotalCasas
        '
        Me.mtbTotalCasas.Enabled = False
        Me.mtbTotalCasas.Location = New System.Drawing.Point(654, 20)
        Me.mtbTotalCasas.Name = "mtbTotalCasas"
        Me.mtbTotalCasas.Size = New System.Drawing.Size(82, 20)
        Me.mtbTotalCasas.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(581, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Total casas:"
        '
        'cbCalles
        '
        Me.cbCalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCalles.FormattingEnabled = True
        Me.cbCalles.Location = New System.Drawing.Point(84, 19)
        Me.cbCalles.Name = "cbCalles"
        Me.cbCalles.Size = New System.Drawing.Size(290, 21)
        Me.cbCalles.TabIndex = 11
        '
        'mtbidCalle
        '
        Me.mtbidCalle.Enabled = False
        Me.mtbidCalle.Location = New System.Drawing.Point(458, 20)
        Me.mtbidCalle.Name = "mtbidCalle"
        Me.mtbidCalle.Size = New System.Drawing.Size(82, 20)
        Me.mtbidCalle.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(404, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "idCalle:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Calle:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(685, 520)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 13)
        Me.lblTotal.TabIndex = 33
        Me.lblTotal.Text = "0.00"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(685, 496)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(28, 13)
        Me.lblIVA.TabIndex = 32
        Me.lblIVA.Text = "0.00"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(685, 475)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(28, 13)
        Me.lblSubtotal.TabIndex = 31
        Me.lblSubtotal.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(597, 520)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Total:           $"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(597, 496)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "IVA:             $"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(596, 475)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Subtotal:      $"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(414, 475)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(153, 55)
        Me.cmdSalir.TabIndex = 27
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(233, 475)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(153, 55)
        Me.cmdGrabar.TabIndex = 26
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(54, 475)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(153, 55)
        Me.cmdNuevo.TabIndex = 25
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'SalidaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgSalidaMateriales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.mtbConcepto)
        Me.Controls.Add(Me.mtbidSalida)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SalidaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalidaMaterial"
        CType(Me.dgSalidaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgSalidaMateriales As DataGridView
    Friend WithEvents idMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents mtbCantidad As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents mtbMinimo As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents mtbMaximo As MaskedTextBox
    Friend WithEvents mtbExistencia As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents mtbUM As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents mtbidMaterial As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbMaterial As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents mtbConcepto As MaskedTextBox
    Friend WithEvents mtbidSalida As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbEmpleados As ComboBox
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents mtbDomicilio As MaskedTextBox
    Friend WithEvents mtbidEmpleados As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbCosto As MaskedTextBox
    Friend WithEvents dtmFechaMaterial As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mtbTotalCasas As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cbCalles As ComboBox
    Friend WithEvents mtbidCalle As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
End Class
