<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgPagos = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoAñoPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoMesPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidPago = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.gbTipoPago = New System.Windows.Forms.GroupBox()
        Me.rbServicio = New System.Windows.Forms.RadioButton()
        Me.rbAgua = New System.Windows.Forms.RadioButton()
        Me.gbAgua = New System.Windows.Forms.GroupBox()
        Me.txtMesInicial = New System.Windows.Forms.TextBox()
        Me.cbTarifas = New System.Windows.Forms.ComboBox()
        Me.cbMesInicial = New System.Windows.Forms.ComboBox()
        Me.txtInfra2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRecargos2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTAR2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCF2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbMesFinal = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtInfra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRecargos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTAR = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCF = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidSituacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSituaciones = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbServicios = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtidServicio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbServicios = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtidEmpleado = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbidCuenta = New System.Windows.Forms.ComboBox()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUAP = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtUMP = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtNombreConsulta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTipoPago.SuspendLayout()
        Me.gbAgua.SuspendLayout()
        Me.gbServicios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(62, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(278, 20)
        Me.txtNombre.TabIndex = 1
        '
        'dgPagos
        '
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.Nombre, Me.Calle, Me.UltimoAñoPagado, Me.UltimoMesPagado})
        Me.dgPagos.Location = New System.Drawing.Point(34, 49)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.ReadOnly = True
        Me.dgPagos.Size = New System.Drawing.Size(749, 173)
        Me.dgPagos.TabIndex = 3
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "idCuenta"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        Me.Calle.ReadOnly = True
        Me.Calle.Width = 200
        '
        'UltimoAñoPagado
        '
        Me.UltimoAñoPagado.HeaderText = "UltimoAñoPagado"
        Me.UltimoAñoPagado.Name = "UltimoAñoPagado"
        Me.UltimoAñoPagado.ReadOnly = True
        '
        'UltimoMesPagado
        '
        Me.UltimoMesPagado.HeaderText = "UltimoMesPagado"
        Me.UltimoMesPagado.Name = "UltimoMesPagado"
        Me.UltimoMesPagado.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "idCuenta:"
        '
        'txtidPago
        '
        Me.txtidPago.Enabled = False
        Me.txtidPago.Location = New System.Drawing.Point(606, 3)
        Me.txtidPago.Name = "txtidPago"
        Me.txtidPago.Size = New System.Drawing.Size(85, 20)
        Me.txtidPago.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "idPago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(555, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(606, 26)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'gbTipoPago
        '
        Me.gbTipoPago.Controls.Add(Me.rbServicio)
        Me.gbTipoPago.Controls.Add(Me.rbAgua)
        Me.gbTipoPago.Enabled = False
        Me.gbTipoPago.Location = New System.Drawing.Point(680, 228)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(126, 77)
        Me.gbTipoPago.TabIndex = 10
        Me.gbTipoPago.TabStop = False
        Me.gbTipoPago.Text = "Tipo Pago"
        '
        'rbServicio
        '
        Me.rbServicio.AutoSize = True
        Me.rbServicio.Location = New System.Drawing.Point(28, 47)
        Me.rbServicio.Name = "rbServicio"
        Me.rbServicio.Size = New System.Drawing.Size(63, 17)
        Me.rbServicio.TabIndex = 1
        Me.rbServicio.TabStop = True
        Me.rbServicio.Text = "Servicio"
        Me.rbServicio.UseVisualStyleBackColor = True
        '
        'rbAgua
        '
        Me.rbAgua.AutoSize = True
        Me.rbAgua.Location = New System.Drawing.Point(28, 24)
        Me.rbAgua.Name = "rbAgua"
        Me.rbAgua.Size = New System.Drawing.Size(50, 17)
        Me.rbAgua.TabIndex = 0
        Me.rbAgua.TabStop = True
        Me.rbAgua.Text = "Agua"
        Me.rbAgua.UseVisualStyleBackColor = True
        '
        'gbAgua
        '
        Me.gbAgua.Controls.Add(Me.txtMesInicial)
        Me.gbAgua.Controls.Add(Me.cbTarifas)
        Me.gbAgua.Controls.Add(Me.cbMesInicial)
        Me.gbAgua.Controls.Add(Me.txtInfra2)
        Me.gbAgua.Controls.Add(Me.Label15)
        Me.gbAgua.Controls.Add(Me.txtRecargos2)
        Me.gbAgua.Controls.Add(Me.Label16)
        Me.gbAgua.Controls.Add(Me.txtTAR2)
        Me.gbAgua.Controls.Add(Me.Label17)
        Me.gbAgua.Controls.Add(Me.txtCF2)
        Me.gbAgua.Controls.Add(Me.Label18)
        Me.gbAgua.Controls.Add(Me.cbMesFinal)
        Me.gbAgua.Controls.Add(Me.Label14)
        Me.gbAgua.Controls.Add(Me.Label13)
        Me.gbAgua.Controls.Add(Me.txtInfra)
        Me.gbAgua.Controls.Add(Me.Label11)
        Me.gbAgua.Controls.Add(Me.txtRecargos)
        Me.gbAgua.Controls.Add(Me.Label12)
        Me.gbAgua.Controls.Add(Me.txtTAR)
        Me.gbAgua.Controls.Add(Me.Label8)
        Me.gbAgua.Controls.Add(Me.txtCF)
        Me.gbAgua.Controls.Add(Me.Label9)
        Me.gbAgua.Controls.Add(Me.Label10)
        Me.gbAgua.Controls.Add(Me.txtDescuento)
        Me.gbAgua.Controls.Add(Me.Label7)
        Me.gbAgua.Controls.Add(Me.txtidSituacion)
        Me.gbAgua.Controls.Add(Me.Label6)
        Me.gbAgua.Controls.Add(Me.cbSituaciones)
        Me.gbAgua.Controls.Add(Me.Label5)
        Me.gbAgua.Location = New System.Drawing.Point(7, 323)
        Me.gbAgua.Name = "gbAgua"
        Me.gbAgua.Size = New System.Drawing.Size(793, 144)
        Me.gbAgua.TabIndex = 11
        Me.gbAgua.TabStop = False
        Me.gbAgua.Text = "Agua"
        Me.gbAgua.Visible = False
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Enabled = False
        Me.txtMesInicial.Location = New System.Drawing.Point(265, 84)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Size = New System.Drawing.Size(76, 20)
        Me.txtMesInicial.TabIndex = 50
        Me.txtMesInicial.Visible = False
        '
        'cbTarifas
        '
        Me.cbTarifas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTarifas.FormattingEnabled = True
        Me.cbTarifas.Location = New System.Drawing.Point(66, 57)
        Me.cbTarifas.Name = "cbTarifas"
        Me.cbTarifas.Size = New System.Drawing.Size(121, 21)
        Me.cbTarifas.TabIndex = 41
        '
        'cbMesInicial
        '
        Me.cbMesInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMesInicial.FormattingEnabled = True
        Me.cbMesInicial.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMesInicial.Location = New System.Drawing.Point(254, 84)
        Me.cbMesInicial.Name = "cbMesInicial"
        Me.cbMesInicial.Size = New System.Drawing.Size(121, 21)
        Me.cbMesInicial.TabIndex = 40
        '
        'txtInfra2
        '
        Me.txtInfra2.Enabled = False
        Me.txtInfra2.Location = New System.Drawing.Point(599, 114)
        Me.txtInfra2.Name = "txtInfra2"
        Me.txtInfra2.Size = New System.Drawing.Size(76, 20)
        Me.txtInfra2.TabIndex = 39
        Me.txtInfra2.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(538, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "INFRA:"
        '
        'txtRecargos2
        '
        Me.txtRecargos2.Enabled = False
        Me.txtRecargos2.Location = New System.Drawing.Point(454, 114)
        Me.txtRecargos2.Name = "txtRecargos2"
        Me.txtRecargos2.Size = New System.Drawing.Size(76, 20)
        Me.txtRecargos2.TabIndex = 37
        Me.txtRecargos2.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(97, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Cuota fija:"
        '
        'txtTAR2
        '
        Me.txtTAR2.Enabled = False
        Me.txtTAR2.Location = New System.Drawing.Point(305, 114)
        Me.txtTAR2.Name = "txtTAR2"
        Me.txtTAR2.Size = New System.Drawing.Size(76, 20)
        Me.txtTAR2.TabIndex = 35
        Me.txtTAR2.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(244, 117)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "TAR:"
        '
        'txtCF2
        '
        Me.txtCF2.Enabled = False
        Me.txtCF2.Location = New System.Drawing.Point(160, 114)
        Me.txtCF2.Name = "txtCF2"
        Me.txtCF2.Size = New System.Drawing.Size(76, 20)
        Me.txtCF2.TabIndex = 33
        Me.txtCF2.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(391, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Recargos:"
        '
        'cbMesFinal
        '
        Me.cbMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMesFinal.Enabled = False
        Me.cbMesFinal.FormattingEnabled = True
        Me.cbMesFinal.Location = New System.Drawing.Point(439, 84)
        Me.cbMesFinal.Name = "cbMesFinal"
        Me.cbMesFinal.Size = New System.Drawing.Size(121, 21)
        Me.cbMesFinal.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(381, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Mes final:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(187, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Mes inicial:"
        '
        'txtInfra
        '
        Me.txtInfra.Enabled = False
        Me.txtInfra.Location = New System.Drawing.Point(711, 58)
        Me.txtInfra.Name = "txtInfra"
        Me.txtInfra.Size = New System.Drawing.Size(76, 20)
        Me.txtInfra.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(650, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "INFRA:"
        '
        'txtRecargos
        '
        Me.txtRecargos.Enabled = False
        Me.txtRecargos.Location = New System.Drawing.Point(566, 58)
        Me.txtRecargos.Name = "txtRecargos"
        Me.txtRecargos.Size = New System.Drawing.Size(76, 20)
        Me.txtRecargos.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(202, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cuota fija:"
        '
        'txtTAR
        '
        Me.txtTAR.Enabled = False
        Me.txtTAR.Location = New System.Drawing.Point(410, 58)
        Me.txtTAR.Name = "txtTAR"
        Me.txtTAR.Size = New System.Drawing.Size(76, 20)
        Me.txtTAR.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "TAR:"
        '
        'txtCF
        '
        Me.txtCF.Enabled = False
        Me.txtCF.Location = New System.Drawing.Point(265, 58)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(76, 20)
        Me.txtCF.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(503, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Recargos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Año Tarifa:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(410, 23)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(76, 20)
        Me.txtDescuento.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Descuento:"
        '
        'txtidSituacion
        '
        Me.txtidSituacion.Enabled = False
        Me.txtidSituacion.Location = New System.Drawing.Point(265, 23)
        Me.txtidSituacion.Name = "txtidSituacion"
        Me.txtidSituacion.Size = New System.Drawing.Size(76, 20)
        Me.txtidSituacion.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "idSituacion:"
        '
        'cbSituaciones
        '
        Me.cbSituaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSituaciones.FormattingEnabled = True
        Me.cbSituaciones.Location = New System.Drawing.Point(66, 23)
        Me.cbSituaciones.Name = "cbSituaciones"
        Me.cbSituaciones.Size = New System.Drawing.Size(121, 21)
        Me.cbSituaciones.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Situacion:"
        '
        'gbServicios
        '
        Me.gbServicios.Controls.Add(Me.txtPrecio)
        Me.gbServicios.Controls.Add(Me.Label25)
        Me.gbServicios.Controls.Add(Me.txtidServicio)
        Me.gbServicios.Controls.Add(Me.Label23)
        Me.gbServicios.Controls.Add(Me.cbServicios)
        Me.gbServicios.Controls.Add(Me.Label24)
        Me.gbServicios.Controls.Add(Me.txtidEmpleado)
        Me.gbServicios.Controls.Add(Me.Label22)
        Me.gbServicios.Controls.Add(Me.cbEmpleados)
        Me.gbServicios.Controls.Add(Me.Label21)
        Me.gbServicios.Location = New System.Drawing.Point(114, 315)
        Me.gbServicios.Name = "gbServicios"
        Me.gbServicios.Size = New System.Drawing.Size(590, 122)
        Me.gbServicios.TabIndex = 16
        Me.gbServicios.TabStop = False
        Me.gbServicios.Text = "Servicios"
        Me.gbServicios.Visible = False
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(499, 19)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(76, 20)
        Me.txtPrecio.TabIndex = 21
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(436, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 13)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Precio:   $"
        '
        'txtidServicio
        '
        Me.txtidServicio.Enabled = False
        Me.txtidServicio.Location = New System.Drawing.Point(338, 19)
        Me.txtidServicio.Name = "txtidServicio"
        Me.txtidServicio.Size = New System.Drawing.Size(76, 20)
        Me.txtidServicio.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(275, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "idServicio:"
        '
        'cbServicios
        '
        Me.cbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServicios.FormattingEnabled = True
        Me.cbServicios.Location = New System.Drawing.Point(66, 19)
        Me.cbServicios.Name = "cbServicios"
        Me.cbServicios.Size = New System.Drawing.Size(191, 21)
        Me.cbServicios.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Servicio:"
        '
        'txtidEmpleado
        '
        Me.txtidEmpleado.Enabled = False
        Me.txtidEmpleado.Location = New System.Drawing.Point(412, 57)
        Me.txtidEmpleado.Name = "txtidEmpleado"
        Me.txtidEmpleado.Size = New System.Drawing.Size(76, 20)
        Me.txtidEmpleado.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(349, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 13)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "idEmpleado:"
        '
        'cbEmpleados
        '
        Me.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleados.FormattingEnabled = True
        Me.cbEmpleados.Location = New System.Drawing.Point(66, 56)
        Me.cbEmpleados.Name = "cbEmpleados"
        Me.cbEmpleados.Size = New System.Drawing.Size(266, 21)
        Me.cbEmpleados.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Empleado:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(697, 519)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(103, 20)
        Me.txtTotal.TabIndex = 20
        Me.txtTotal.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(657, 522)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(656, 496)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Otros:"
        '
        'cbidCuenta
        '
        Me.cbidCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbidCuenta.Enabled = False
        Me.cbidCuenta.FormattingEnabled = True
        Me.cbidCuenta.Location = New System.Drawing.Point(415, 22)
        Me.cbidCuenta.Name = "cbidCuenta"
        Me.cbidCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cbidCuenta.TabIndex = 40
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(94, 479)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(115, 46)
        Me.cmdNuevo.TabIndex = 41
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(218, 479)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(115, 46)
        Me.cmdGrabar.TabIndex = 42
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Location = New System.Drawing.Point(342, 479)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(115, 46)
        Me.cmdImprimir.TabIndex = 43
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(466, 479)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(115, 46)
        Me.cmdSalir.TabIndex = 44
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(632, 470)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Descuento:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(698, 470)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(28, 13)
        Me.lblDesc.TabIndex = 46
        Me.lblDesc.Text = "0.00"
        '
        'txtOtros
        '
        Me.txtOtros.Enabled = False
        Me.txtOtros.Location = New System.Drawing.Point(697, 493)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(103, 20)
        Me.txtOtros.TabIndex = 47
        Me.txtOtros.Text = "0.00"
        '
        'txtidCuenta
        '
        Me.txtidCuenta.Enabled = False
        Me.txtidCuenta.Location = New System.Drawing.Point(80, 19)
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.Size = New System.Drawing.Size(76, 20)
        Me.txtidCuenta.TabIndex = 49
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(17, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 13)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "idCuenta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUAP)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtUMP)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtNombreConsulta)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.txtidCuenta)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 76)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de la cuenta"
        '
        'txtUAP
        '
        Me.txtUAP.Enabled = False
        Me.txtUAP.Location = New System.Drawing.Point(580, 48)
        Me.txtUAP.Name = "txtUAP"
        Me.txtUAP.Size = New System.Drawing.Size(76, 20)
        Me.txtUAP.TabIndex = 56
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(481, 51)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 13)
        Me.Label31.TabIndex = 55
        Me.Label31.Text = "Ultimo año pagado:"
        '
        'txtUMP
        '
        Me.txtUMP.Enabled = False
        Me.txtUMP.Location = New System.Drawing.Point(395, 47)
        Me.txtUMP.Name = "txtUMP"
        Me.txtUMP.Size = New System.Drawing.Size(76, 20)
        Me.txtUMP.TabIndex = 54
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(295, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 13)
        Me.Label30.TabIndex = 53
        Me.Label30.Text = "Ultimo mes pagado:"
        '
        'txtCalle
        '
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(55, 46)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(222, 20)
        Me.txtCalle.TabIndex = 52
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 50)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 13)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "Calle:"
        '
        'txtNombreConsulta
        '
        Me.txtNombreConsulta.Enabled = False
        Me.txtNombreConsulta.Location = New System.Drawing.Point(254, 19)
        Me.txtNombreConsulta.Name = "txtNombreConsulta"
        Me.txtNombreConsulta.Size = New System.Drawing.Size(346, 20)
        Me.txtNombreConsulta.TabIndex = 51
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(191, 22)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 13)
        Me.Label28.TabIndex = 50
        Me.Label28.Text = "Nombre:"
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtOtros)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cbidCuenta)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.gbServicios)
        Me.Controls.Add(Me.gbAgua)
        Me.Controls.Add(Me.gbTipoPago)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtidPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgPagos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pagos"
        Me.Text = "Pagos"
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.gbAgua.ResumeLayout(False)
        Me.gbAgua.PerformLayout()
        Me.gbServicios.ResumeLayout(False)
        Me.gbServicios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgPagos As DataGridView
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents UltimoAñoPagado As DataGridViewTextBoxColumn
    Friend WithEvents UltimoMesPagado As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidPago As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents gbTipoPago As GroupBox
    Friend WithEvents rbServicio As RadioButton
    Friend WithEvents rbAgua As RadioButton
    Friend WithEvents gbAgua As GroupBox
    Friend WithEvents txtInfra2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRecargos2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTAR2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCF2 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cbMesFinal As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtInfra As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRecargos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTAR As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCF As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtidSituacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbSituaciones As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gbServicios As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtidServicio As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cbServicios As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtidEmpleado As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbEmpleados As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cbidCuenta As ComboBox
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdImprimir As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents txtOtros As TextBox
    Friend WithEvents txtidCuenta As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtNombreConsulta As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtUAP As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtUMP As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents cbTarifas As ComboBox
    Friend WithEvents cbMesInicial As ComboBox
    Friend WithEvents txtMesInicial As TextBox
End Class
