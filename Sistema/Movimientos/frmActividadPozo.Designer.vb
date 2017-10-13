<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividadPozo
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
        Me.ActividadPozoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetSistema = New Sistema.DataSetSistema()
        Me.ActividadPozoTableAdapter = New Sistema.DataSetSistemaTableAdapters.ActividadPozoTableAdapter()
        Me.mtbHora = New System.Windows.Forms.MaskedTextBox()
        Me.mtbObservaciones = New System.Windows.Forms.MaskedTextBox()
        Me.mtbLectura = New System.Windows.Forms.MaskedTextBox()
        Me.mtbidPozo = New System.Windows.Forms.MaskedTextBox()
        Me.mtbidActividad = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cbPozo = New System.Windows.Forms.ComboBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgActividadPozo = New System.Windows.Forms.DataGridView()
        Me.idActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPozo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lectura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ActividadPozoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgActividadPozo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActividadPozoBindingSource
        '
        Me.ActividadPozoBindingSource.DataMember = "ActividadPozo"
        Me.ActividadPozoBindingSource.DataSource = Me.DataSetSistema
        '
        'DataSetSistema
        '
        Me.DataSetSistema.DataSetName = "DataSetSistema"
        Me.DataSetSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActividadPozoTableAdapter
        '
        Me.ActividadPozoTableAdapter.ClearBeforeFill = True
        '
        'mtbHora
        '
        Me.mtbHora.Enabled = False
        Me.mtbHora.Location = New System.Drawing.Point(431, 12)
        Me.mtbHora.Mask = "00:00"
        Me.mtbHora.Name = "mtbHora"
        Me.mtbHora.Size = New System.Drawing.Size(100, 20)
        Me.mtbHora.TabIndex = 1
        Me.mtbHora.ValidatingType = GetType(Date)
        '
        'mtbObservaciones
        '
        Me.mtbObservaciones.Enabled = False
        Me.mtbObservaciones.Location = New System.Drawing.Point(431, 108)
        Me.mtbObservaciones.Name = "mtbObservaciones"
        Me.mtbObservaciones.Size = New System.Drawing.Size(228, 20)
        Me.mtbObservaciones.TabIndex = 2
        '
        'mtbLectura
        '
        Me.mtbLectura.Enabled = False
        Me.mtbLectura.Location = New System.Drawing.Point(431, 58)
        Me.mtbLectura.Name = "mtbLectura"
        Me.mtbLectura.Size = New System.Drawing.Size(228, 20)
        Me.mtbLectura.TabIndex = 3
        '
        'mtbidPozo
        '
        Me.mtbidPozo.Enabled = False
        Me.mtbidPozo.Location = New System.Drawing.Point(218, 58)
        Me.mtbidPozo.Name = "mtbidPozo"
        Me.mtbidPozo.ReadOnly = True
        Me.mtbidPozo.Size = New System.Drawing.Size(100, 20)
        Me.mtbidPozo.TabIndex = 4
        '
        'mtbidActividad
        '
        Me.mtbidActividad.Enabled = False
        Me.mtbidActividad.Location = New System.Drawing.Point(81, 12)
        Me.mtbidActividad.Name = "mtbidActividad"
        Me.mtbidActividad.ReadOnly = True
        Me.mtbidActividad.Size = New System.Drawing.Size(100, 20)
        Me.mtbidActividad.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Location = New System.Drawing.Point(81, 105)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'cbPozo
        '
        Me.cbPozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPozo.Enabled = False
        Me.cbPozo.FormattingEnabled = True
        Me.cbPozo.Location = New System.Drawing.Point(81, 58)
        Me.cbPozo.Name = "cbPozo"
        Me.cbPozo.Size = New System.Drawing.Size(121, 21)
        Me.cbPozo.TabIndex = 8
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(466, 305)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(85, 23)
        Me.cmdSalir.TabIndex = 33
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Location = New System.Drawing.Point(340, 305)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(85, 23)
        Me.cmdGrabar.TabIndex = 32
        Me.cmdGrabar.Text = "Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Location = New System.Drawing.Point(210, 305)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(85, 23)
        Me.cmdNuevo.TabIndex = 31
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "idActividad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Pozo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "hora:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "lectura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(346, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "observaciones:"
        '
        'dgActividadPozo
        '
        Me.dgActividadPozo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgActividadPozo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idActividad, Me.idPozo, Me.Ubicacion, Me.Fecha, Me.Hora, Me.Lectura, Me.Observaciones})
        Me.dgActividadPozo.Location = New System.Drawing.Point(12, 149)
        Me.dgActividadPozo.Name = "dgActividadPozo"
        Me.dgActividadPozo.Size = New System.Drawing.Size(745, 150)
        Me.dgActividadPozo.TabIndex = 40
        '
        'idActividad
        '
        Me.idActividad.HeaderText = "idActividad"
        Me.idActividad.Name = "idActividad"
        '
        'idPozo
        '
        Me.idPozo.HeaderText = "idPozo"
        Me.idPozo.Name = "idPozo"
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicacion"
        Me.Ubicacion.Name = "Ubicacion"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        '
        'Lectura
        '
        Me.Lectura.HeaderText = "Lectura"
        Me.Lectura.Name = "Lectura"
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        '
        'frmActividadPozo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgActividadPozo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.cbPozo)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.mtbidActividad)
        Me.Controls.Add(Me.mtbidPozo)
        Me.Controls.Add(Me.mtbLectura)
        Me.Controls.Add(Me.mtbObservaciones)
        Me.Controls.Add(Me.mtbHora)
        Me.Name = "frmActividadPozo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmActividadPozo"
        CType(Me.ActividadPozoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgActividadPozo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetSistema As DataSetSistema
    Friend WithEvents ActividadPozoBindingSource As BindingSource
    Friend WithEvents ActividadPozoTableAdapter As DataSetSistemaTableAdapters.ActividadPozoTableAdapter
    Friend WithEvents mtbHora As MaskedTextBox
    Friend WithEvents mtbObservaciones As MaskedTextBox
    Friend WithEvents mtbLectura As MaskedTextBox
    Friend WithEvents mtbidPozo As MaskedTextBox
    Friend WithEvents mtbidActividad As MaskedTextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cbPozo As ComboBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGrabar As Button
    Friend WithEvents cmdNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgActividadPozo As DataGridView
    Friend WithEvents idActividad As DataGridViewTextBoxColumn
    Friend WithEvents idPozo As DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Lectura As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
End Class
