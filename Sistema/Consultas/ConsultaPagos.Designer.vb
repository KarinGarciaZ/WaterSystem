<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPagos
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
        Me.gbAgua = New System.Windows.Forms.GroupBox()
        Me.txtMesFinal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtMesInicial = New System.Windows.Forms.TextBox()
        Me.txtInfra = New System.Windows.Forms.TextBox()
        Me.txtSituacion = New System.Windows.Forms.TextBox()
        Me.txtCF = New System.Windows.Forms.TextBox()
        Me.txtRecargos = New System.Windows.Forms.TextBox()
        Me.txtTar = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.txtidPago = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbPago = New System.Windows.Forms.GroupBox()
        Me.dgPagos = New System.Windows.Forms.DataGridView()
        Me.idCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoAñoPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoMesPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtidCuenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbidPago = New System.Windows.Forms.ComboBox()
        Me.gbServicioAtendido = New System.Windows.Forms.GroupBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtidEmpleado = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtidServicio = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtidPago2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.gbAgua.SuspendLayout()
        Me.gbPago.SuspendLayout()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbServicioAtendido.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbAgua
        '
        Me.gbAgua.Controls.Add(Me.txtMesFinal)
        Me.gbAgua.Controls.Add(Me.txtDescuento)
        Me.gbAgua.Controls.Add(Me.txtMesInicial)
        Me.gbAgua.Controls.Add(Me.txtInfra)
        Me.gbAgua.Controls.Add(Me.txtSituacion)
        Me.gbAgua.Controls.Add(Me.txtCF)
        Me.gbAgua.Controls.Add(Me.txtRecargos)
        Me.gbAgua.Controls.Add(Me.txtTar)
        Me.gbAgua.Controls.Add(Me.txtAño)
        Me.gbAgua.Controls.Add(Me.txtidPago)
        Me.gbAgua.Controls.Add(Me.Label16)
        Me.gbAgua.Controls.Add(Me.Label15)
        Me.gbAgua.Controls.Add(Me.Label14)
        Me.gbAgua.Controls.Add(Me.Label13)
        Me.gbAgua.Controls.Add(Me.Label12)
        Me.gbAgua.Controls.Add(Me.Label11)
        Me.gbAgua.Controls.Add(Me.Label10)
        Me.gbAgua.Controls.Add(Me.Label9)
        Me.gbAgua.Controls.Add(Me.Label8)
        Me.gbAgua.Controls.Add(Me.Label2)
        Me.gbAgua.Location = New System.Drawing.Point(12, 277)
        Me.gbAgua.Name = "gbAgua"
        Me.gbAgua.Size = New System.Drawing.Size(817, 86)
        Me.gbAgua.TabIndex = 34
        Me.gbAgua.TabStop = False
        Me.gbAgua.Text = "Consulta de pago de agua"
        Me.gbAgua.Visible = False
        '
        'txtMesFinal
        '
        Me.txtMesFinal.Enabled = False
        Me.txtMesFinal.Location = New System.Drawing.Point(699, 27)
        Me.txtMesFinal.Name = "txtMesFinal"
        Me.txtMesFinal.Size = New System.Drawing.Size(95, 20)
        Me.txtMesFinal.TabIndex = 57
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Location = New System.Drawing.Point(699, 58)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(95, 20)
        Me.txtDescuento.TabIndex = 56
        '
        'txtMesInicial
        '
        Me.txtMesInicial.Enabled = False
        Me.txtMesInicial.Location = New System.Drawing.Point(525, 27)
        Me.txtMesInicial.Name = "txtMesInicial"
        Me.txtMesInicial.Size = New System.Drawing.Size(95, 20)
        Me.txtMesInicial.TabIndex = 55
        '
        'txtInfra
        '
        Me.txtInfra.Enabled = False
        Me.txtInfra.Location = New System.Drawing.Point(525, 58)
        Me.txtInfra.Name = "txtInfra"
        Me.txtInfra.Size = New System.Drawing.Size(95, 20)
        Me.txtInfra.TabIndex = 54
        '
        'txtSituacion
        '
        Me.txtSituacion.Enabled = False
        Me.txtSituacion.Location = New System.Drawing.Point(223, 27)
        Me.txtSituacion.Name = "txtSituacion"
        Me.txtSituacion.Size = New System.Drawing.Size(95, 20)
        Me.txtSituacion.TabIndex = 53
        '
        'txtCF
        '
        Me.txtCF.Enabled = False
        Me.txtCF.Location = New System.Drawing.Point(72, 58)
        Me.txtCF.Name = "txtCF"
        Me.txtCF.Size = New System.Drawing.Size(85, 20)
        Me.txtCF.TabIndex = 52
        '
        'txtRecargos
        '
        Me.txtRecargos.Enabled = False
        Me.txtRecargos.Location = New System.Drawing.Point(223, 58)
        Me.txtRecargos.Name = "txtRecargos"
        Me.txtRecargos.Size = New System.Drawing.Size(95, 20)
        Me.txtRecargos.TabIndex = 51
        '
        'txtTar
        '
        Me.txtTar.Enabled = False
        Me.txtTar.Location = New System.Drawing.Point(356, 58)
        Me.txtTar.Name = "txtTar"
        Me.txtTar.Size = New System.Drawing.Size(98, 20)
        Me.txtTar.TabIndex = 50
        '
        'txtAño
        '
        Me.txtAño.Enabled = False
        Me.txtAño.Location = New System.Drawing.Point(356, 27)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(98, 20)
        Me.txtAño.TabIndex = 49
        '
        'txtidPago
        '
        Me.txtidPago.Enabled = False
        Me.txtidPago.Location = New System.Drawing.Point(72, 27)
        Me.txtidPago.Name = "txtidPago"
        Me.txtidPago.Size = New System.Drawing.Size(85, 20)
        Me.txtidPago.TabIndex = 48
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(626, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Descuento:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(460, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Infra:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(324, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Tar:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(163, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Recargos:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Cuota fija:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(626, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Mes final:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(460, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Mes inicial:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(324, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Año:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Situacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "ID Pago:"
        '
        'gbPago
        '
        Me.gbPago.Controls.Add(Me.dgPagos)
        Me.gbPago.Controls.Add(Me.txtNombre)
        Me.gbPago.Controls.Add(Me.Label4)
        Me.gbPago.Controls.Add(Me.txtTotal)
        Me.gbPago.Controls.Add(Me.txtOtros)
        Me.gbPago.Controls.Add(Me.dtpFecha)
        Me.gbPago.Controls.Add(Me.txtidCuenta)
        Me.gbPago.Controls.Add(Me.Label7)
        Me.gbPago.Controls.Add(Me.Label6)
        Me.gbPago.Controls.Add(Me.Label5)
        Me.gbPago.Controls.Add(Me.Label3)
        Me.gbPago.Controls.Add(Me.Label1)
        Me.gbPago.Controls.Add(Me.cbidPago)
        Me.gbPago.Location = New System.Drawing.Point(12, 9)
        Me.gbPago.Name = "gbPago"
        Me.gbPago.Size = New System.Drawing.Size(817, 262)
        Me.gbPago.TabIndex = 35
        Me.gbPago.TabStop = False
        Me.gbPago.Text = "Informacion del Pago"
        '
        'dgPagos
        '
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCuenta, Me.Nombre, Me.Calle, Me.UltimoAñoPagado, Me.UltimoMesPagado, Me.Total})
        Me.dgPagos.Location = New System.Drawing.Point(6, 49)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.ReadOnly = True
        Me.dgPagos.Size = New System.Drawing.Size(805, 173)
        Me.dgPagos.TabIndex = 54
        '
        'idCuenta
        '
        Me.idCuenta.HeaderText = "idPago"
        Me.idCuenta.Name = "idCuenta"
        Me.idCuenta.ReadOnly = True
        Me.idCuenta.Width = 70
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
        Me.Calle.HeaderText = "Fecha"
        Me.Calle.Name = "Calle"
        Me.Calle.ReadOnly = True
        Me.Calle.Width = 200
        '
        'UltimoAñoPagado
        '
        Me.UltimoAñoPagado.HeaderText = "Tipo"
        Me.UltimoAñoPagado.Name = "UltimoAñoPagado"
        Me.UltimoAñoPagado.ReadOnly = True
        Me.UltimoAñoPagado.Width = 90
        '
        'UltimoMesPagado
        '
        Me.UltimoMesPagado.HeaderText = "Otros"
        Me.UltimoMesPagado.Name = "UltimoMesPagado"
        Me.UltimoMesPagado.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(166, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(325, 20)
        Me.txtNombre.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Nombre:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(680, 236)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(131, 20)
        Me.txtTotal.TabIndex = 51
        '
        'txtOtros
        '
        Me.txtOtros.Enabled = False
        Me.txtOtros.Location = New System.Drawing.Point(500, 236)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(134, 20)
        Me.txtOtros.TabIndex = 50
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(223, 236)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 49
        '
        'txtidCuenta
        '
        Me.txtidCuenta.Enabled = False
        Me.txtidCuenta.Location = New System.Drawing.Point(87, 236)
        Me.txtidCuenta.Name = "txtidCuenta"
        Me.txtidCuenta.Size = New System.Drawing.Size(70, 20)
        Me.txtidCuenta.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(640, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(459, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Otros:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "ID Cuenta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(551, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "ID Pago:"
        '
        'cbidPago
        '
        Me.cbidPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbidPago.FormattingEnabled = True
        Me.cbidPago.Location = New System.Drawing.Point(616, 22)
        Me.cbidPago.Name = "cbidPago"
        Me.cbidPago.Size = New System.Drawing.Size(132, 21)
        Me.cbidPago.TabIndex = 40
        '
        'gbServicioAtendido
        '
        Me.gbServicioAtendido.Controls.Add(Me.txtPrecio)
        Me.gbServicioAtendido.Controls.Add(Me.Label22)
        Me.gbServicioAtendido.Controls.Add(Me.txtNombreEmpleado)
        Me.gbServicioAtendido.Controls.Add(Me.Label20)
        Me.gbServicioAtendido.Controls.Add(Me.txtidEmpleado)
        Me.gbServicioAtendido.Controls.Add(Me.Label21)
        Me.gbServicioAtendido.Controls.Add(Me.txtServicio)
        Me.gbServicioAtendido.Controls.Add(Me.Label19)
        Me.gbServicioAtendido.Controls.Add(Me.txtidServicio)
        Me.gbServicioAtendido.Controls.Add(Me.Label18)
        Me.gbServicioAtendido.Controls.Add(Me.txtidPago2)
        Me.gbServicioAtendido.Controls.Add(Me.Label17)
        Me.gbServicioAtendido.Location = New System.Drawing.Point(12, 279)
        Me.gbServicioAtendido.Name = "gbServicioAtendido"
        Me.gbServicioAtendido.Size = New System.Drawing.Size(817, 84)
        Me.gbServicioAtendido.TabIndex = 36
        Me.gbServicioAtendido.TabStop = False
        Me.gbServicioAtendido.Text = "Servicio Atendido"
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(665, 42)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(117, 20)
        Me.txtPrecio.TabIndex = 60
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(708, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "Precio:"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Enabled = False
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(420, 58)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(200, 20)
        Me.txtNombreEmpleado.TabIndex = 58
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(366, 61)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "Nombre:"
        '
        'txtidEmpleado
        '
        Me.txtidEmpleado.Enabled = False
        Me.txtidEmpleado.Location = New System.Drawing.Point(255, 58)
        Me.txtidEmpleado.Name = "txtidEmpleado"
        Me.txtidEmpleado.Size = New System.Drawing.Size(85, 20)
        Me.txtidEmpleado.TabIndex = 56
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(187, 61)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "ID Empleado:"
        '
        'txtServicio
        '
        Me.txtServicio.Enabled = False
        Me.txtServicio.Location = New System.Drawing.Point(420, 19)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(200, 20)
        Me.txtServicio.TabIndex = 54
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(366, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Servicio:"
        '
        'txtidServicio
        '
        Me.txtidServicio.Enabled = False
        Me.txtidServicio.Location = New System.Drawing.Point(255, 19)
        Me.txtidServicio.Name = "txtidServicio"
        Me.txtidServicio.Size = New System.Drawing.Size(85, 20)
        Me.txtidServicio.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(187, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "ID Servicio:"
        '
        'txtidPago2
        '
        Me.txtidPago2.Enabled = False
        Me.txtidPago2.Location = New System.Drawing.Point(72, 39)
        Me.txtidPago2.Name = "txtidPago2"
        Me.txtidPago2.Size = New System.Drawing.Size(85, 20)
        Me.txtidPago2.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "ID Pago:"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(381, 369)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 37
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'ConsultaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.gbServicioAtendido)
        Me.Controls.Add(Me.gbPago)
        Me.Controls.Add(Me.gbAgua)
        Me.Name = "ConsultaPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaPagos"
        Me.gbAgua.ResumeLayout(False)
        Me.gbAgua.PerformLayout()
        Me.gbPago.ResumeLayout(False)
        Me.gbPago.PerformLayout()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbServicioAtendido.ResumeLayout(False)
        Me.gbServicioAtendido.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbAgua As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbPago As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtOtros As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtidCuenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbidPago As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMesFinal As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtMesInicial As TextBox
    Friend WithEvents txtInfra As TextBox
    Friend WithEvents txtSituacion As TextBox
    Friend WithEvents txtCF As TextBox
    Friend WithEvents txtRecargos As TextBox
    Friend WithEvents txtTar As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents txtidPago As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents gbServicioAtendido As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtidEmpleado As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtServicio As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtidServicio As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtidPago2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgPagos As DataGridView
    Friend WithEvents idCuenta As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents UltimoAñoPagado As DataGridViewTextBoxColumn
    Friend WithEvents UltimoMesPagado As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cmdSalir As Button
End Class
