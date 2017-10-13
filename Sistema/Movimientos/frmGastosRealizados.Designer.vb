<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastosRealizados
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbidGastoR = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtbDomicilio = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtbidEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtbObservaciones = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mtbImporte = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtbidGasto = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbConceptoGasto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.cbEmpleadoConsulta = New System.Windows.Forms.ComboBox()
        Me.cbConceptoConsulta = New System.Windows.Forms.ComboBox()
        Me.dtpFechaConsulta = New System.Windows.Forms.DateTimePicker()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbConcepto = New System.Windows.Forms.RadioButton()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.dgGastosRealizados = New System.Windows.Forms.DataGridView()
        Me.idGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgGastosRealizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "idGasto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "fecha:"
        '
        'mtbidGastoR
        '
        Me.mtbidGastoR.Enabled = False
        Me.mtbidGastoR.Location = New System.Drawing.Point(128, 16)
        Me.mtbidGastoR.Name = "mtbidGastoR"
        Me.mtbidGastoR.Size = New System.Drawing.Size(100, 20)
        Me.mtbidGastoR.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(470, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtbTelefono)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.mtbDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mtbidEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbEmpleado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 79)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'mtbTelefono
        '
        Me.mtbTelefono.Enabled = False
        Me.mtbTelefono.Location = New System.Drawing.Point(505, 48)
        Me.mtbTelefono.Name = "mtbTelefono"
        Me.mtbTelefono.Size = New System.Drawing.Size(106, 20)
        Me.mtbTelefono.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefono:"
        '
        'mtbDomicilio
        '
        Me.mtbDomicilio.Enabled = False
        Me.mtbDomicilio.Location = New System.Drawing.Point(230, 48)
        Me.mtbDomicilio.Name = "mtbDomicilio"
        Me.mtbDomicilio.Size = New System.Drawing.Size(194, 20)
        Me.mtbDomicilio.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Domicilio:"
        '
        'mtbidEmpleado
        '
        Me.mtbidEmpleado.Enabled = False
        Me.mtbidEmpleado.Location = New System.Drawing.Point(76, 48)
        Me.mtbidEmpleado.Name = "mtbidEmpleado"
        Me.mtbidEmpleado.Size = New System.Drawing.Size(54, 20)
        Me.mtbidEmpleado.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "idEmpleado:"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleado.Enabled = False
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Location = New System.Drawing.Point(69, 13)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(296, 21)
        Me.cbEmpleado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Empleado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.mtbImporte)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.mtbidGasto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbConceptoGasto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 76)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'mtbObservaciones
        '
        Me.mtbObservaciones.Enabled = False
        Me.mtbObservaciones.Location = New System.Drawing.Point(411, 50)
        Me.mtbObservaciones.Name = "mtbObservaciones"
        Me.mtbObservaciones.Size = New System.Drawing.Size(200, 20)
        Me.mtbObservaciones.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Observaciones:"
        '
        'mtbImporte
        '
        Me.mtbImporte.Enabled = False
        Me.mtbImporte.Location = New System.Drawing.Point(187, 50)
        Me.mtbImporte.Mask = "99999999.99"
        Me.mtbImporte.Name = "mtbImporte"
        Me.mtbImporte.Size = New System.Drawing.Size(118, 20)
        Me.mtbImporte.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(136, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Importe:"
        '
        'mtbidGasto
        '
        Me.mtbidGasto.Enabled = False
        Me.mtbidGasto.Location = New System.Drawing.Point(58, 50)
        Me.mtbidGasto.Name = "mtbidGasto"
        Me.mtbidGasto.Size = New System.Drawing.Size(54, 20)
        Me.mtbidGasto.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "idGasto:"
        '
        'cbConceptoGasto
        '
        Me.cbConceptoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConceptoGasto.Enabled = False
        Me.cbConceptoGasto.FormattingEnabled = True
        Me.cbConceptoGasto.Location = New System.Drawing.Point(97, 9)
        Me.cbConceptoGasto.Name = "cbConceptoGasto"
        Me.cbConceptoGasto.Size = New System.Drawing.Size(235, 21)
        Me.cbConceptoGasto.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Concepto gasto:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAceptar)
        Me.GroupBox3.Controls.Add(Me.rbTodos)
        Me.GroupBox3.Controls.Add(Me.cbEmpleadoConsulta)
        Me.GroupBox3.Controls.Add(Me.cbConceptoConsulta)
        Me.GroupBox3.Controls.Add(Me.dtpFechaConsulta)
        Me.GroupBox3.Controls.Add(Me.rbEmpleado)
        Me.GroupBox3.Controls.Add(Me.rbConcepto)
        Me.GroupBox3.Controls.Add(Me.rbFecha)
        Me.GroupBox3.Location = New System.Drawing.Point(60, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(617, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(438, 64)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 24)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(450, 16)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbTodos.TabIndex = 7
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'cbEmpleadoConsulta
        '
        Me.cbEmpleadoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpleadoConsulta.FormattingEnabled = True
        Me.cbEmpleadoConsulta.Location = New System.Drawing.Point(86, 68)
        Me.cbEmpleadoConsulta.Name = "cbEmpleadoConsulta"
        Me.cbEmpleadoConsulta.Size = New System.Drawing.Size(235, 21)
        Me.cbEmpleadoConsulta.TabIndex = 6
        '
        'cbConceptoConsulta
        '
        Me.cbConceptoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConceptoConsulta.FormattingEnabled = True
        Me.cbConceptoConsulta.Location = New System.Drawing.Point(86, 41)
        Me.cbConceptoConsulta.Name = "cbConceptoConsulta"
        Me.cbConceptoConsulta.Size = New System.Drawing.Size(235, 21)
        Me.cbConceptoConsulta.TabIndex = 5
        '
        'dtpFechaConsulta
        '
        Me.dtpFechaConsulta.Location = New System.Drawing.Point(87, 16)
        Me.dtpFechaConsulta.Name = "dtpFechaConsulta"
        Me.dtpFechaConsulta.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaConsulta.TabIndex = 3
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Location = New System.Drawing.Point(9, 68)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.rbEmpleado.TabIndex = 2
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'rbConcepto
        '
        Me.rbConcepto.AutoSize = True
        Me.rbConcepto.Location = New System.Drawing.Point(9, 42)
        Me.rbConcepto.Name = "rbConcepto"
        Me.rbConcepto.Size = New System.Drawing.Size(71, 17)
        Me.rbConcepto.TabIndex = 1
        Me.rbConcepto.Text = "Concepto"
        Me.rbConcepto.UseVisualStyleBackColor = True
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(9, 19)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbFecha.TabIndex = 0
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'dgGastosRealizados
        '
        Me.dgGastosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGastosRealizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idGasto, Me.idEmpleado, Me.fecha, Me.empleado, Me.concepto, Me.importe, Me.observaciones})
        Me.dgGastosRealizados.Location = New System.Drawing.Point(12, 318)
        Me.dgGastosRealizados.Name = "dgGastosRealizados"
        Me.dgGastosRealizados.Size = New System.Drawing.Size(713, 150)
        Me.dgGastosRealizados.TabIndex = 7
        '
        'idGasto
        '
        Me.idGasto.HeaderText = "idGasto"
        Me.idGasto.Name = "idGasto"
        Me.idGasto.ReadOnly = True
        Me.idGasto.Width = 50
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "idEmpleado"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Width = 50
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 90
        '
        'empleado
        '
        Me.empleado.HeaderText = "Empleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Width = 150
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        Me.concepto.Width = 150
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        Me.importe.Width = 80
        '
        'observaciones
        '
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(239, 473)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 24)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(333, 473)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(88, 24)
        Me.btnGrabar.TabIndex = 10
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(535, 473)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 24)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmGastosRealizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgGastosRealizados)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.mtbidGastoR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGastosRealizados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGastosRealizados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgGastosRealizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbidGastoR As MaskedTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbEmpleado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mtbTelefono As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mtbDomicilio As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mtbidEmpleado As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbConceptoGasto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mtbObservaciones As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mtbImporte As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mtbidGasto As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpFechaConsulta As DateTimePicker
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents rbConcepto As RadioButton
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents rbTodos As RadioButton
    Friend WithEvents cbEmpleadoConsulta As ComboBox
    Friend WithEvents cbConceptoConsulta As ComboBox
    Friend WithEvents dgGastosRealizados As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents idGasto As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents empleado As DataGridViewTextBoxColumn
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents observaciones As DataGridViewTextBoxColumn
End Class
