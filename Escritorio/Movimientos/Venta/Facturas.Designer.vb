<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rucCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.pnlCobro = New System.Windows.Forms.Panel()
        Me.txtNroFactCobro = New System.Windows.Forms.TextBox()
        Me.txtClienteCobro = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscarCobro = New System.Windows.Forms.Button()
        Me.lblFiltroTipo = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbFiltroCobro = New System.Windows.Forms.ComboBox()
        Me.pnlFechas = New System.Windows.Forms.Panel()
        Me.dpHastaPago = New System.Windows.Forms.DateTimePicker()
        Me.dpDesdePago = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCobro.SuspendLayout()
        Me.pnlFechas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        Me.dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.FacturaNro, Me.Cliente, Me.rucCliente, Me.Fecha, Me.Tipo, Me.Total, Me.Estado, Me.Vendedor})
        Me.dgvVentas.Location = New System.Drawing.Point(30, 218)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(834, 208)
        Me.dgvVentas.TabIndex = 0
        '
        'Código
        '
        Me.Código.DataPropertyName = "Código"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        Me.Código.Visible = False
        '
        'FacturaNro
        '
        Me.FacturaNro.DataPropertyName = "Factura Nro."
        Me.FacturaNro.HeaderText = "Factura Nro"
        Me.FacturaNro.Name = "FacturaNro"
        Me.FacturaNro.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'rucCliente
        '
        Me.rucCliente.DataPropertyName = "rucCliente"
        Me.rucCliente.HeaderText = "RUC"
        Me.rucCliente.Name = "rucCliente"
        Me.rucCliente.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha Venta"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        '
        'Vendedor
        '
        Me.Vendedor.DataPropertyName = "Vendedor"
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        Me.Vendedor.Visible = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Location = New System.Drawing.Point(30, 501)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(834, 193)
        Me.dgvDetalle.TabIndex = 1
        '
        'pnlCobro
        '
        Me.pnlCobro.Controls.Add(Me.txtNroFactCobro)
        Me.pnlCobro.Controls.Add(Me.txtClienteCobro)
        Me.pnlCobro.Controls.Add(Me.btnImprimir)
        Me.pnlCobro.Controls.Add(Me.btnBuscarCobro)
        Me.pnlCobro.Controls.Add(Me.lblFiltroTipo)
        Me.pnlCobro.Controls.Add(Me.Label25)
        Me.pnlCobro.Controls.Add(Me.cbFiltroCobro)
        Me.pnlCobro.Controls.Add(Me.pnlFechas)
        Me.pnlCobro.Location = New System.Drawing.Point(30, 46)
        Me.pnlCobro.Name = "pnlCobro"
        Me.pnlCobro.Size = New System.Drawing.Size(834, 113)
        Me.pnlCobro.TabIndex = 6
        '
        'txtNroFactCobro
        '
        Me.txtNroFactCobro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFactCobro.Location = New System.Drawing.Point(245, 42)
        Me.txtNroFactCobro.Name = "txtNroFactCobro"
        Me.txtNroFactCobro.Size = New System.Drawing.Size(262, 26)
        Me.txtNroFactCobro.TabIndex = 8
        Me.txtNroFactCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClienteCobro
        '
        Me.txtClienteCobro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCobro.Location = New System.Drawing.Point(134, 132)
        Me.txtClienteCobro.Name = "txtClienteCobro"
        Me.txtClienteCobro.Size = New System.Drawing.Size(228, 26)
        Me.txtClienteCobro.TabIndex = 12
        Me.txtClienteCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImprimir.Location = New System.Drawing.Point(636, 75)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(184, 29)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscarCobro
        '
        Me.btnBuscarCobro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCobro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscarCobro.Location = New System.Drawing.Point(636, 23)
        Me.btnBuscarCobro.Name = "btnBuscarCobro"
        Me.btnBuscarCobro.Size = New System.Drawing.Size(184, 29)
        Me.btnBuscarCobro.TabIndex = 3
        Me.btnBuscarCobro.Text = "Buscar"
        Me.btnBuscarCobro.UseVisualStyleBackColor = True
        '
        'lblFiltroTipo
        '
        Me.lblFiltroTipo.AutoSize = True
        Me.lblFiltroTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblFiltroTipo.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFiltroTipo.Location = New System.Drawing.Point(241, 12)
        Me.lblFiltroTipo.Name = "lblFiltroTipo"
        Me.lblFiltroTipo.Size = New System.Drawing.Size(222, 27)
        Me.lblFiltroTipo.TabIndex = 10
        Me.lblFiltroTipo.Text = "Inserte Nro. Factura"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Control
        Me.Label25.Location = New System.Drawing.Point(22, 12)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 27)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Buscar por"
        '
        'cbFiltroCobro
        '
        Me.cbFiltroCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltroCobro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroCobro.FormattingEnabled = True
        Me.cbFiltroCobro.Location = New System.Drawing.Point(27, 42)
        Me.cbFiltroCobro.Name = "cbFiltroCobro"
        Me.cbFiltroCobro.Size = New System.Drawing.Size(184, 27)
        Me.cbFiltroCobro.TabIndex = 6
        '
        'pnlFechas
        '
        Me.pnlFechas.BackColor = System.Drawing.Color.Transparent
        Me.pnlFechas.Controls.Add(Me.dpHastaPago)
        Me.pnlFechas.Controls.Add(Me.dpDesdePago)
        Me.pnlFechas.Controls.Add(Me.Label23)
        Me.pnlFechas.Controls.Add(Me.Label24)
        Me.pnlFechas.Location = New System.Drawing.Point(239, -5)
        Me.pnlFechas.Name = "pnlFechas"
        Me.pnlFechas.Size = New System.Drawing.Size(368, 92)
        Me.pnlFechas.TabIndex = 7
        Me.pnlFechas.Visible = False
        '
        'dpHastaPago
        '
        Me.dpHastaPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpHastaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpHastaPago.Location = New System.Drawing.Point(199, 46)
        Me.dpHastaPago.Name = "dpHastaPago"
        Me.dpHastaPago.Size = New System.Drawing.Size(139, 27)
        Me.dpHastaPago.TabIndex = 0
        '
        'dpDesdePago
        '
        Me.dpDesdePago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDesdePago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDesdePago.Location = New System.Drawing.Point(7, 46)
        Me.dpDesdePago.Name = "dpDesdePago"
        Me.dpDesdePago.Size = New System.Drawing.Size(139, 27)
        Me.dpDesdePago.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(194, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 27)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Hasta"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Control
        Me.Label24.Location = New System.Drawing.Point(3, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 27)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Desde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(348, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Imprimir Facturas"
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.BackColor = System.Drawing.Color.Transparent
        Me.lblVentas.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVentas.Location = New System.Drawing.Point(71, 7)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(250, 27)
        Me.lblVentas.TabIndex = 8
        Me.lblVentas.Text = "VENTAS SIN IMPRIMIR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblVentas)
        Me.Panel1.Location = New System.Drawing.Point(201, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 34)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(432, 447)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 34)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(147, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DETALLE"
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(895, 740)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlCobro)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.dgvVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCobro.ResumeLayout(False)
        Me.pnlCobro.PerformLayout()
        Me.pnlFechas.ResumeLayout(False)
        Me.pnlFechas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents pnlCobro As Panel
    Friend WithEvents txtClienteCobro As TextBox
    Friend WithEvents btnBuscarCobro As Button
    Friend WithEvents lblFiltroTipo As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtNroFactCobro As TextBox
    Friend WithEvents cbFiltroCobro As ComboBox
    Friend WithEvents pnlFechas As Panel
    Friend WithEvents dpHastaPago As DateTimePicker
    Friend WithEvents dpDesdePago As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVentas As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents FacturaNro As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents rucCliente As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class
