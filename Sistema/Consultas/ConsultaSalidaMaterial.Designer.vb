<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaSalidaMaterial
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgConsultaSalidaMateriales = New System.Windows.Forms.DataGridView()
        Me.idSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbidSalida = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.cbCalles = New System.Windows.Forms.ComboBox()
        Me.lblf2 = New System.Windows.Forms.Label()
        Me.lblf1 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbTodo = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCalle = New System.Windows.Forms.RadioButton()
        Me.rbidSalida = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtidSalida = New System.Windows.Forms.TextBox()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgConsultaPorId = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgConsultaSalidaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgConsultaPorId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(828, 430)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 13)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.Text = "0.00"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(828, 406)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(28, 13)
        Me.lblIVA.TabIndex = 45
        Me.lblIVA.Text = "0.00"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(828, 385)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(28, 13)
        Me.lblSubtotal.TabIndex = 44
        Me.lblSubtotal.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(740, 430)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Total:           $"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(740, 406)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "IVA:             $"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(739, 385)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Subtotal:      $"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(271, 385)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(151, 55)
        Me.cmdSalir.TabIndex = 40
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgConsultaSalidaMateriales
        '
        Me.dgConsultaSalidaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaSalidaMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSalida, Me.idMaterial, Me.Material, Me.idEmpleado, Me.idCalle, Me.Fecha, Me.Cantidad, Me.Costo, Me.Importe})
        Me.dgConsultaSalidaMateriales.Location = New System.Drawing.Point(12, 208)
        Me.dgConsultaSalidaMateriales.Name = "dgConsultaSalidaMateriales"
        Me.dgConsultaSalidaMateriales.Size = New System.Drawing.Size(895, 154)
        Me.dgConsultaSalidaMateriales.TabIndex = 39
        '
        'idSalida
        '
        Me.idSalida.HeaderText = "idSalida"
        Me.idSalida.Name = "idSalida"
        Me.idSalida.Width = 50
        '
        'idMaterial
        '
        Me.idMaterial.HeaderText = "idMaterial"
        Me.idMaterial.Name = "idMaterial"
        Me.idMaterial.ReadOnly = True
        Me.idMaterial.Width = 50
        '
        'Material
        '
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.ReadOnly = True
        Me.Material.Width = 120
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "Empleado"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Width = 150
        '
        'idCalle
        '
        Me.idCalle.HeaderText = "Calle"
        Me.idCalle.Name = "idCalle"
        Me.idCalle.ReadOnly = True
        Me.idCalle.Width = 150
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 70
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 90
        '
        'cbidSalida
        '
        Me.cbidSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbidSalida.FormattingEnabled = True
        Me.cbidSalida.Location = New System.Drawing.Point(100, 12)
        Me.cbidSalida.Name = "cbidSalida"
        Me.cbidSalida.Size = New System.Drawing.Size(77, 21)
        Me.cbidSalida.TabIndex = 31
        Me.cbidSalida.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAceptar)
        Me.GroupBox1.Controls.Add(Me.cbEmpleado)
        Me.GroupBox1.Controls.Add(Me.cbCalles)
        Me.GroupBox1.Controls.Add(Me.lblf2)
        Me.GroupBox1.Controls.Add(Me.lblf1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.rbFecha)
        Me.GroupBox1.Controls.Add(Me.rbTodo)
        Me.GroupBox1.Controls.Add(Me.rbEmpleado)
        Me.GroupBox1.Controls.Add(Me.rbCalle)
        Me.GroupBox1.Controls.Add(Me.rbidSalida)
        Me.GroupBox1.Controls.Add(Me.cbidSalida)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 127)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(230, 91)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(283, 30)
        Me.cmdAceptar.TabIndex = 48
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cbEmpleado
        '
        Me.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(100, 63)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(225, 21)
        Me.cbEmpleado.TabIndex = 42
        Me.cbEmpleado.Visible = False
        '
        'cbCalles
        '
        Me.cbCalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCalles.FormattingEnabled = True
        Me.cbCalles.Location = New System.Drawing.Point(100, 35)
        Me.cbCalles.Name = "cbCalles"
        Me.cbCalles.Size = New System.Drawing.Size(225, 21)
        Me.cbCalles.TabIndex = 41
        Me.cbCalles.Visible = False
        '
        'lblf2
        '
        Me.lblf2.AutoSize = True
        Me.lblf2.Location = New System.Drawing.Point(410, 71)
        Me.lblf2.Name = "lblf2"
        Me.lblf2.Size = New System.Drawing.Size(65, 13)
        Me.lblf2.TabIndex = 40
        Me.lblf2.Text = "Fecha Final:"
        Me.lblf2.Visible = False
        '
        'lblf1
        '
        Me.lblf1.AutoSize = True
        Me.lblf1.Location = New System.Drawing.Point(409, 43)
        Me.lblf1.Name = "lblf1"
        Me.lblf1.Size = New System.Drawing.Size(69, 13)
        Me.lblf1.TabIndex = 39
        Me.lblf1.Text = "Fecha inicial:"
        Me.lblf1.Visible = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Location = New System.Drawing.Point(481, 65)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFinal.TabIndex = 38
        Me.dtpFechaFinal.Visible = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Location = New System.Drawing.Point(481, 39)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicial.TabIndex = 37
        Me.dtpFechaInicial.Visible = False
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(331, 39)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbFecha.TabIndex = 36
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'rbTodo
        '
        Me.rbTodo.AutoSize = True
        Me.rbTodo.Location = New System.Drawing.Point(331, 16)
        Me.rbTodo.Name = "rbTodo"
        Me.rbTodo.Size = New System.Drawing.Size(50, 17)
        Me.rbTodo.TabIndex = 35
        Me.rbTodo.TabStop = True
        Me.rbTodo.Text = "Todo"
        Me.rbTodo.UseVisualStyleBackColor = True
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Location = New System.Drawing.Point(15, 62)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.rbEmpleado.TabIndex = 34
        Me.rbEmpleado.TabStop = True
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'rbCalle
        '
        Me.rbCalle.AutoSize = True
        Me.rbCalle.Location = New System.Drawing.Point(15, 39)
        Me.rbCalle.Name = "rbCalle"
        Me.rbCalle.Size = New System.Drawing.Size(48, 17)
        Me.rbCalle.TabIndex = 33
        Me.rbCalle.TabStop = True
        Me.rbCalle.Text = "Calle"
        Me.rbCalle.UseVisualStyleBackColor = True
        '
        'rbidSalida
        '
        Me.rbidSalida.AutoSize = True
        Me.rbidSalida.Location = New System.Drawing.Point(15, 16)
        Me.rbidSalida.Name = "rbidSalida"
        Me.rbidSalida.Size = New System.Drawing.Size(62, 17)
        Me.rbidSalida.TabIndex = 32
        Me.rbidSalida.TabStop = True
        Me.rbidSalida.Text = "idSalida"
        Me.rbidSalida.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtidSalida)
        Me.GroupBox2.Controls.Add(Me.txtEmpleado)
        Me.GroupBox2.Controls.Add(Me.txtCalle)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(685, 66)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de salida por ID"
        Me.GroupBox2.Visible = False
        '
        'txtidSalida
        '
        Me.txtidSalida.Enabled = False
        Me.txtidSalida.Location = New System.Drawing.Point(65, 15)
        Me.txtidSalida.Name = "txtidSalida"
        Me.txtidSalida.Size = New System.Drawing.Size(76, 20)
        Me.txtidSalida.TabIndex = 41
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(65, 40)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(257, 20)
        Me.txtEmpleado.TabIndex = 40
        '
        'txtCalle
        '
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(412, 40)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(267, 20)
        Me.txtCalle.TabIndex = 39
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(412, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 38
        Me.dtpFecha.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Calle:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Salida:"
        '
        'dgConsultaPorId
        '
        Me.dgConsultaPorId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaPorId.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgConsultaPorId.Location = New System.Drawing.Point(140, 209)
        Me.dgConsultaPorId.Name = "dgConsultaPorId"
        Me.dgConsultaPorId.Size = New System.Drawing.Size(445, 154)
        Me.dgConsultaPorId.TabIndex = 49
        Me.dgConsultaPorId.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "idMaterial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'ConsultaSalidaMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgConsultaPorId)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.dgConsultaSalidaMateriales)
        Me.Name = "ConsultaSalidaMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaSalidaMaterial"
        CType(Me.dgConsultaSalidaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgConsultaPorId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgConsultaSalidaMateriales As DataGridView
    Friend WithEvents cbidSalida As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents cbCalles As ComboBox
    Friend WithEvents lblf2 As Label
    Friend WithEvents lblf1 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbTodo As RadioButton
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents rbCalle As RadioButton
    Friend WithEvents rbidSalida As RadioButton
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents idSalida As DataGridViewTextBoxColumn
    Friend WithEvents idMaterial As DataGridViewTextBoxColumn
    Friend WithEvents Material As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents idCalle As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtidSalida As TextBox
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgConsultaPorId As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
