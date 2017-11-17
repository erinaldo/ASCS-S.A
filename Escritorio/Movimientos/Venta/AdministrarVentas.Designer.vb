<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarVentas
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcVenta = New System.Windows.Forms.TabControl()
        Me.tpListado = New System.Windows.Forms.TabPage()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.pnlListado = New System.Windows.Forms.Panel()
        Me.txtNroFacturaListado = New System.Windows.Forms.TextBox()
        Me.cbEstadoCompra = New System.Windows.Forms.ComboBox()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnBuscarCompra = New System.Windows.Forms.Button()
        Me.lblBusqTxt = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbCliente1 = New System.Windows.Forms.ComboBox()
        Me.cbBuscarVenta = New System.Windows.Forms.ComboBox()
        Me.pnlRangoFecha = New System.Windows.Forms.Panel()
        Me.datepFin = New System.Windows.Forms.DateTimePicker()
        Me.datepInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTituloBusqueda = New System.Windows.Forms.Label()
        Me.tpNuevaVenta = New System.Windows.Forms.TabPage()
        Me.dgvBusquedaResult = New System.Windows.Forms.DataGridView()
        Me.pnlDatosProducto = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbImpuesto = New System.Windows.Forms.ComboBox()
        Me.cbDeposito = New System.Windows.Forms.ComboBox()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnInsertarProd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFiltroBusquedaNC = New System.Windows.Forms.TextBox()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioProd = New System.Windows.Forms.TextBox()
        Me.pnlDatosCompra = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbTipoPago = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEntregaInicial = New System.Windows.Forms.TextBox()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.rbContado = New System.Windows.Forms.RadioButton()
        Me.dateFactura = New System.Windows.Forms.DateTimePicker()
        Me.gbCliente = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbProveedor2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.pnlSeleccionProd = New System.Windows.Forms.Panel()
        Me.btnSeleccionarPr = New System.Windows.Forms.Button()
        Me.pnlOperadores = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnGuardarCompra = New System.Windows.Forms.Button()
        Me.pnlComentario = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.pnlTotales = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.tpAnularVenta = New System.Windows.Forms.TabPage()
        Me.pnlOperandosAnular = New System.Windows.Forms.Panel()
        Me.btnAnularVenta = New System.Windows.Forms.Button()
        Me.btnVerDetalleAnul = New System.Windows.Forms.Button()
        Me.dgvComprasAnular = New System.Windows.Forms.DataGridView()
        Me.txtTituloAnular = New System.Windows.Forms.Label()
        Me.pnlAnular = New System.Windows.Forms.Panel()
        Me.txtHastaAnul = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.Label()
        Me.btnBuscarAnular = New System.Windows.Forms.Button()
        Me.dpAnularVentaFin = New System.Windows.Forms.DateTimePicker()
        Me.dpAnularVentaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNrofacturaAnul = New System.Windows.Forms.TextBox()
        Me.cbCliente3 = New System.Windows.Forms.ComboBox()
        Me.cbAnularFiltro = New System.Windows.Forms.ComboBox()
        Me.tpCobros = New System.Windows.Forms.TabPage()
        Me.dgvComprasP = New System.Windows.Forms.DataGridView()
        Me.lblTituloP = New System.Windows.Forms.Label()
        Me.pnlPago = New System.Windows.Forms.Panel()
        Me.cbProveedor4 = New System.Windows.Forms.ComboBox()
        Me.btnDetalleP = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.lblFiltroTipo = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNroFactPago = New System.Windows.Forms.TextBox()
        Me.cbFiltroP = New System.Windows.Forms.ComboBox()
        Me.pnlFechas = New System.Windows.Forms.Panel()
        Me.dpHastaPago = New System.Windows.Forms.DateTimePicker()
        Me.dpDesdePago = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbcVenta.SuspendLayout()
        Me.tpListado.SuspendLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlListado.SuspendLayout()
        Me.pnlRangoFecha.SuspendLayout()
        Me.tpNuevaVenta.SuspendLayout()
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatosProducto.SuspendLayout()
        Me.pnlDatosCompra.SuspendLayout()
        Me.gbTipoPago.SuspendLayout()
        Me.gbCliente.SuspendLayout()
        Me.pnlSeleccionProd.SuspendLayout()
        Me.pnlOperadores.SuspendLayout()
        Me.pnlComentario.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAnularVenta.SuspendLayout()
        Me.pnlOperandosAnular.SuspendLayout()
        CType(Me.dgvComprasAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAnular.SuspendLayout()
        Me.tpCobros.SuspendLayout()
        CType(Me.dgvComprasP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPago.SuspendLayout()
        Me.pnlFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcVenta
        '
        Me.tbcVenta.Controls.Add(Me.tpListado)
        Me.tbcVenta.Controls.Add(Me.tpNuevaVenta)
        Me.tbcVenta.Controls.Add(Me.tpAnularVenta)
        Me.tbcVenta.Controls.Add(Me.tpCobros)
        Me.tbcVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcVenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcVenta.Location = New System.Drawing.Point(0, 0)
        Me.tbcVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcVenta.Name = "tbcVenta"
        Me.tbcVenta.Padding = New System.Drawing.Point(10, 8)
        Me.tbcVenta.SelectedIndex = 0
        Me.tbcVenta.Size = New System.Drawing.Size(1256, 574)
        Me.tbcVenta.TabIndex = 4
        '
        'tpListado
        '
        Me.tpListado.BackColor = System.Drawing.Color.SteelBlue
        Me.tpListado.Controls.Add(Me.dgvCompras)
        Me.tpListado.Controls.Add(Me.pnlListado)
        Me.tpListado.Controls.Add(Me.txtTituloBusqueda)
        Me.tpListado.Location = New System.Drawing.Point(4, 38)
        Me.tpListado.Name = "tpListado"
        Me.tpListado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListado.Size = New System.Drawing.Size(1248, 532)
        Me.tpListado.TabIndex = 0
        Me.tpListado.Text = "Listado"
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AllowUserToDeleteRows = False
        Me.dgvCompras.AllowUserToOrderColumns = True
        Me.dgvCompras.AllowUserToResizeColumns = False
        Me.dgvCompras.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvCompras.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCompras.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgvCompras.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvCompras.Location = New System.Drawing.Point(51, 323)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.ReadOnly = True
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvCompras.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompras.Size = New System.Drawing.Size(910, 178)
        Me.dgvCompras.TabIndex = 35
        Me.dgvCompras.Visible = False
        '
        'pnlListado
        '
        Me.pnlListado.Controls.Add(Me.txtNroFacturaListado)
        Me.pnlListado.Controls.Add(Me.cbEstadoCompra)
        Me.pnlListado.Controls.Add(Me.btnDetalle)
        Me.pnlListado.Controls.Add(Me.btnBuscarCompra)
        Me.pnlListado.Controls.Add(Me.lblBusqTxt)
        Me.pnlListado.Controls.Add(Me.Label15)
        Me.pnlListado.Controls.Add(Me.cbCliente1)
        Me.pnlListado.Controls.Add(Me.cbBuscarVenta)
        Me.pnlListado.Controls.Add(Me.pnlRangoFecha)
        Me.pnlListado.Location = New System.Drawing.Point(51, 85)
        Me.pnlListado.Name = "pnlListado"
        Me.pnlListado.Size = New System.Drawing.Size(910, 189)
        Me.pnlListado.TabIndex = 5
        '
        'txtNroFacturaListado
        '
        Me.txtNroFacturaListado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFacturaListado.Location = New System.Drawing.Point(367, 57)
        Me.txtNroFacturaListado.Name = "txtNroFacturaListado"
        Me.txtNroFacturaListado.Size = New System.Drawing.Size(262, 26)
        Me.txtNroFacturaListado.TabIndex = 8
        '
        'cbEstadoCompra
        '
        Me.cbEstadoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCompra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCompra.FormattingEnabled = True
        Me.cbEstadoCompra.Location = New System.Drawing.Point(16, 120)
        Me.cbEstadoCompra.Name = "cbEstadoCompra"
        Me.cbEstadoCompra.Size = New System.Drawing.Size(217, 26)
        Me.cbEstadoCompra.TabIndex = 12
        Me.cbEstadoCompra.Visible = False
        '
        'btnDetalle
        '
        Me.btnDetalle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDetalle.Location = New System.Drawing.Point(605, 131)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(111, 30)
        Me.btnDetalle.TabIndex = 11
        Me.btnDetalle.Text = "Ver Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = True
        Me.btnDetalle.Visible = False
        '
        'btnBuscarCompra
        '
        Me.btnBuscarCompra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCompra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscarCompra.Location = New System.Drawing.Point(722, 131)
        Me.btnBuscarCompra.Name = "btnBuscarCompra"
        Me.btnBuscarCompra.Size = New System.Drawing.Size(108, 30)
        Me.btnBuscarCompra.TabIndex = 3
        Me.btnBuscarCompra.Text = "Buscar"
        Me.btnBuscarCompra.UseVisualStyleBackColor = True
        '
        'lblBusqTxt
        '
        Me.lblBusqTxt.AutoSize = True
        Me.lblBusqTxt.BackColor = System.Drawing.Color.Transparent
        Me.lblBusqTxt.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBusqTxt.Location = New System.Drawing.Point(364, 27)
        Me.lblBusqTxt.Name = "lblBusqTxt"
        Me.lblBusqTxt.Size = New System.Drawing.Size(222, 27)
        Me.lblBusqTxt.TabIndex = 10
        Me.lblBusqTxt.Text = "Inserte Nro. Factura"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(12, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 27)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Buscar por"
        '
        'cbCliente1
        '
        Me.cbCliente1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente1.FormattingEnabled = True
        Me.cbCliente1.Location = New System.Drawing.Point(324, 120)
        Me.cbCliente1.Name = "cbCliente1"
        Me.cbCliente1.Size = New System.Drawing.Size(262, 26)
        Me.cbCliente1.TabIndex = 9
        Me.cbCliente1.Visible = False
        '
        'cbBuscarVenta
        '
        Me.cbBuscarVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscarVenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarVenta.FormattingEnabled = True
        Me.cbBuscarVenta.Location = New System.Drawing.Point(144, 56)
        Me.cbBuscarVenta.Name = "cbBuscarVenta"
        Me.cbBuscarVenta.Size = New System.Drawing.Size(184, 27)
        Me.cbBuscarVenta.TabIndex = 6
        '
        'pnlRangoFecha
        '
        Me.pnlRangoFecha.BackColor = System.Drawing.Color.Transparent
        Me.pnlRangoFecha.Controls.Add(Me.datepFin)
        Me.pnlRangoFecha.Controls.Add(Me.datepInicio)
        Me.pnlRangoFecha.Controls.Add(Me.Label14)
        Me.pnlRangoFecha.Controls.Add(Me.Label13)
        Me.pnlRangoFecha.Location = New System.Drawing.Point(355, 12)
        Me.pnlRangoFecha.Name = "pnlRangoFecha"
        Me.pnlRangoFecha.Size = New System.Drawing.Size(494, 100)
        Me.pnlRangoFecha.TabIndex = 7
        Me.pnlRangoFecha.Visible = False
        '
        'datepFin
        '
        Me.datepFin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepFin.Location = New System.Drawing.Point(265, 46)
        Me.datepFin.Name = "datepFin"
        Me.datepFin.Size = New System.Drawing.Size(200, 27)
        Me.datepFin.TabIndex = 0
        '
        'datepInicio
        '
        Me.datepInicio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepInicio.Location = New System.Drawing.Point(35, 46)
        Me.datepInicio.Name = "datepInicio"
        Me.datepInicio.Size = New System.Drawing.Size(200, 27)
        Me.datepInicio.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(260, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 27)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Hasta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(30, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 27)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Desde"
        '
        'txtTituloBusqueda
        '
        Me.txtTituloBusqueda.AutoSize = True
        Me.txtTituloBusqueda.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTituloBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTituloBusqueda.Location = New System.Drawing.Point(375, 28)
        Me.txtTituloBusqueda.Name = "txtTituloBusqueda"
        Me.txtTituloBusqueda.Size = New System.Drawing.Size(292, 36)
        Me.txtTituloBusqueda.TabIndex = 1
        Me.txtTituloBusqueda.Text = "Listado de Ventas"
        '
        'tpNuevaVenta
        '
        Me.tpNuevaVenta.AutoScroll = True
        Me.tpNuevaVenta.BackColor = System.Drawing.Color.SteelBlue
        Me.tpNuevaVenta.Controls.Add(Me.dgvBusquedaResult)
        Me.tpNuevaVenta.Controls.Add(Me.pnlDatosProducto)
        Me.tpNuevaVenta.Controls.Add(Me.pnlDatosCompra)
        Me.tpNuevaVenta.Controls.Add(Me.pnlSeleccionProd)
        Me.tpNuevaVenta.Controls.Add(Me.pnlOperadores)
        Me.tpNuevaVenta.Controls.Add(Me.pnlComentario)
        Me.tpNuevaVenta.Controls.Add(Me.pnlTotales)
        Me.tpNuevaVenta.Controls.Add(Me.dgvProductos)
        Me.tpNuevaVenta.Location = New System.Drawing.Point(4, 38)
        Me.tpNuevaVenta.Name = "tpNuevaVenta"
        Me.tpNuevaVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNuevaVenta.Size = New System.Drawing.Size(1248, 532)
        Me.tpNuevaVenta.TabIndex = 1
        Me.tpNuevaVenta.Text = "Nueva Venta"
        '
        'dgvBusquedaResult
        '
        Me.dgvBusquedaResult.AllowUserToAddRows = False
        Me.dgvBusquedaResult.AllowUserToDeleteRows = False
        Me.dgvBusquedaResult.AllowUserToOrderColumns = True
        Me.dgvBusquedaResult.AllowUserToResizeColumns = False
        Me.dgvBusquedaResult.AllowUserToResizeRows = False
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBusquedaResult.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvBusquedaResult.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvBusquedaResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBusquedaResult.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvBusquedaResult.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvBusquedaResult.Location = New System.Drawing.Point(93, 385)
        Me.dgvBusquedaResult.Name = "dgvBusquedaResult"
        Me.dgvBusquedaResult.ReadOnly = True
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvBusquedaResult.RowsDefaultCellStyle = DataGridViewCellStyle31
        Me.dgvBusquedaResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusquedaResult.Size = New System.Drawing.Size(826, 208)
        Me.dgvBusquedaResult.TabIndex = 36
        Me.dgvBusquedaResult.Visible = False
        '
        'pnlDatosProducto
        '
        Me.pnlDatosProducto.Controls.Add(Me.Label19)
        Me.pnlDatosProducto.Controls.Add(Me.cbImpuesto)
        Me.pnlDatosProducto.Controls.Add(Me.cbDeposito)
        Me.pnlDatosProducto.Controls.Add(Me.btnBuscarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label1)
        Me.pnlDatosProducto.Controls.Add(Me.Label4)
        Me.pnlDatosProducto.Controls.Add(Me.btnInsertarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label9)
        Me.pnlDatosProducto.Controls.Add(Me.btnEliminarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label8)
        Me.pnlDatosProducto.Controls.Add(Me.txtFiltroBusquedaNC)
        Me.pnlDatosProducto.Controls.Add(Me.txtCodProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label6)
        Me.pnlDatosProducto.Controls.Add(Me.txtCantidad)
        Me.pnlDatosProducto.Controls.Add(Me.txtDescripcionProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label5)
        Me.pnlDatosProducto.Controls.Add(Me.Label7)
        Me.pnlDatosProducto.Controls.Add(Me.txtPrecioProd)
        Me.pnlDatosProducto.Location = New System.Drawing.Point(32, 191)
        Me.pnlDatosProducto.Name = "pnlDatosProducto"
        Me.pnlDatosProducto.Size = New System.Drawing.Size(1046, 173)
        Me.pnlDatosProducto.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(13, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(192, 22)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "DATOS PRODUCTO"
        '
        'cbImpuesto
        '
        Me.cbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImpuesto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbImpuesto.FormattingEnabled = True
        Me.cbImpuesto.Location = New System.Drawing.Point(392, 128)
        Me.cbImpuesto.Name = "cbImpuesto"
        Me.cbImpuesto.Size = New System.Drawing.Size(195, 27)
        Me.cbImpuesto.TabIndex = 13
        '
        'cbDeposito
        '
        Me.cbDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeposito.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDeposito.FormattingEnabled = True
        Me.cbDeposito.Location = New System.Drawing.Point(392, 88)
        Me.cbDeposito.Name = "cbDeposito"
        Me.cbDeposito.Size = New System.Drawing.Size(195, 27)
        Me.cbDeposito.TabIndex = 10
        '
        'btnBuscarProd
        '
        Me.btnBuscarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProd.Location = New System.Drawing.Point(92, 72)
        Me.btnBuscarProd.Name = "btnBuscarProd"
        Me.btnBuscarProd.Size = New System.Drawing.Size(127, 32)
        Me.btnBuscarProd.TabIndex = 12
        Me.btnBuscarProd.Text = "Buscar"
        Me.btnBuscarProd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(284, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(23, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Filtro"
        '
        'btnInsertarProd
        '
        Me.btnInsertarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProd.Location = New System.Drawing.Point(957, 34)
        Me.btnInsertarProd.Name = "btnInsertarProd"
        Me.btnInsertarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnInsertarProd.TabIndex = 2
        Me.btnInsertarProd.Text = "+"
        Me.btnInsertarProd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(284, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Impuesto"
        '
        'btnEliminarProd
        '
        Me.btnEliminarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProd.Location = New System.Drawing.Point(957, 88)
        Me.btnEliminarProd.Name = "btnEliminarProd"
        Me.btnEliminarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnEliminarProd.TabIndex = 3
        Me.btnEliminarProd.Text = "-"
        Me.btnEliminarProd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(284, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Depósito"
        '
        'txtFiltroBusquedaNC
        '
        Me.txtFiltroBusquedaNC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltroBusquedaNC.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroBusquedaNC.Location = New System.Drawing.Point(94, 38)
        Me.txtFiltroBusquedaNC.Name = "txtFiltroBusquedaNC"
        Me.txtFiltroBusquedaNC.Size = New System.Drawing.Size(125, 27)
        Me.txtFiltroBusquedaNC.TabIndex = 4
        '
        'txtCodProd
        '
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Enabled = False
        Me.txtCodProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(392, 41)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.ReadOnly = True
        Me.txtCodProd.Size = New System.Drawing.Size(195, 27)
        Me.txtCodProd.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(605, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(713, 85)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(174, 27)
        Me.txtCantidad.TabIndex = 5
        '
        'txtDescripcionProd
        '
        Me.txtDescripcionProd.Enabled = False
        Me.txtDescripcionProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProd.Location = New System.Drawing.Point(713, 41)
        Me.txtDescripcionProd.Name = "txtDescripcionProd"
        Me.txtDescripcionProd.ReadOnly = True
        Me.txtDescripcionProd.Size = New System.Drawing.Size(174, 27)
        Me.txtDescripcionProd.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(605, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(605, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio"
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProd.Location = New System.Drawing.Point(713, 128)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(174, 27)
        Me.txtPrecioProd.TabIndex = 5
        '
        'pnlDatosCompra
        '
        Me.pnlDatosCompra.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosCompra.Controls.Add(Me.Label18)
        Me.pnlDatosCompra.Controls.Add(Me.gbTipoPago)
        Me.pnlDatosCompra.Controls.Add(Me.dateFactura)
        Me.pnlDatosCompra.Controls.Add(Me.gbCliente)
        Me.pnlDatosCompra.Controls.Add(Me.Label3)
        Me.pnlDatosCompra.Controls.Add(Me.Label26)
        Me.pnlDatosCompra.Controls.Add(Me.TextBox1)
        Me.pnlDatosCompra.Controls.Add(Me.Label2)
        Me.pnlDatosCompra.Controls.Add(Me.txtFacturaNro)
        Me.pnlDatosCompra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosCompra.Location = New System.Drawing.Point(32, 30)
        Me.pnlDatosCompra.Name = "pnlDatosCompra"
        Me.pnlDatosCompra.Size = New System.Drawing.Size(1193, 146)
        Me.pnlDatosCompra.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(12, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS VENTA"
        '
        'gbTipoPago
        '
        Me.gbTipoPago.BackColor = System.Drawing.Color.Transparent
        Me.gbTipoPago.Controls.Add(Me.Label20)
        Me.gbTipoPago.Controls.Add(Me.txtEntregaInicial)
        Me.gbTipoPago.Controls.Add(Me.rbCredito)
        Me.gbTipoPago.Controls.Add(Me.rbContado)
        Me.gbTipoPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbTipoPago.Location = New System.Drawing.Point(957, 17)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(233, 67)
        Me.gbTipoPago.TabIndex = 3
        Me.gbTipoPago.TabStop = False
        Me.gbTipoPago.Text = "Tipo de Pago"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 19)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Entrega Inicial"
        '
        'txtEntregaInicial
        '
        Me.txtEntregaInicial.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntregaInicial.Location = New System.Drawing.Point(131, 74)
        Me.txtEntregaInicial.Name = "txtEntregaInicial"
        Me.txtEntregaInicial.Size = New System.Drawing.Size(157, 26)
        Me.txtEntregaInicial.TabIndex = 2
        Me.txtEntregaInicial.Text = "0"
        Me.txtEntregaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Location = New System.Drawing.Point(131, 28)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(83, 23)
        Me.rbCredito.TabIndex = 1
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "Crédito"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'rbContado
        '
        Me.rbContado.AutoSize = True
        Me.rbContado.Location = New System.Drawing.Point(28, 28)
        Me.rbContado.Name = "rbContado"
        Me.rbContado.Size = New System.Drawing.Size(93, 23)
        Me.rbContado.TabIndex = 0
        Me.rbContado.TabStop = True
        Me.rbContado.Text = "Contado"
        Me.rbContado.UseVisualStyleBackColor = True
        '
        'dateFactura
        '
        Me.dateFactura.CustomFormat = "dd/mm/aaaa"
        Me.dateFactura.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFactura.Location = New System.Drawing.Point(138, 89)
        Me.dateFactura.Name = "dateFactura"
        Me.dateFactura.Size = New System.Drawing.Size(168, 27)
        Me.dateFactura.TabIndex = 5
        '
        'gbCliente
        '
        Me.gbCliente.BackColor = System.Drawing.Color.Transparent
        Me.gbCliente.Controls.Add(Me.Label22)
        Me.gbCliente.Controls.Add(Me.ComboBox1)
        Me.gbCliente.Controls.Add(Me.Label11)
        Me.gbCliente.Controls.Add(Me.cbProveedor2)
        Me.gbCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbCliente.Location = New System.Drawing.Point(646, 17)
        Me.gbCliente.Name = "gbCliente"
        Me.gbCliente.Size = New System.Drawing.Size(305, 119)
        Me.gbCliente.TabIndex = 8
        Me.gbCliente.TabStop = False
        Me.gbCliente.Text = "Cliente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cliente"
        '
        'cbProveedor2
        '
        Me.cbProveedor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor2.FormattingEnabled = True
        Me.cbProveedor2.Location = New System.Drawing.Point(118, 28)
        Me.cbProveedor2.Name = "cbProveedor2"
        Me.cbProveedor2.Size = New System.Drawing.Size(168, 27)
        Me.cbProveedor2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(13, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Factura Nº"
        '
        'txtFacturaNro
        '
        Me.txtFacturaNro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacturaNro.Location = New System.Drawing.Point(138, 39)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.Size = New System.Drawing.Size(168, 26)
        Me.txtFacturaNro.TabIndex = 0
        '
        'pnlSeleccionProd
        '
        Me.pnlSeleccionProd.Controls.Add(Me.btnSeleccionarPr)
        Me.pnlSeleccionProd.Location = New System.Drawing.Point(408, 606)
        Me.pnlSeleccionProd.Name = "pnlSeleccionProd"
        Me.pnlSeleccionProd.Size = New System.Drawing.Size(370, 70)
        Me.pnlSeleccionProd.TabIndex = 19
        Me.pnlSeleccionProd.Visible = False
        '
        'btnSeleccionarPr
        '
        Me.btnSeleccionarPr.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarPr.Location = New System.Drawing.Point(128, 23)
        Me.btnSeleccionarPr.Name = "btnSeleccionarPr"
        Me.btnSeleccionarPr.Size = New System.Drawing.Size(129, 41)
        Me.btnSeleccionarPr.TabIndex = 6
        Me.btnSeleccionarPr.Text = "Seleccionar"
        Me.btnSeleccionarPr.UseVisualStyleBackColor = True
        '
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.Button4)
        Me.pnlOperadores.Controls.Add(Me.btnGuardarCompra)
        Me.pnlOperadores.Location = New System.Drawing.Point(32, 766)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(370, 70)
        Me.pnlOperadores.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(215, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 41)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnGuardarCompra
        '
        Me.btnGuardarCompra.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCompra.Location = New System.Drawing.Point(42, 29)
        Me.btnGuardarCompra.Name = "btnGuardarCompra"
        Me.btnGuardarCompra.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarCompra.TabIndex = 6
        Me.btnGuardarCompra.Text = "Guardar"
        Me.btnGuardarCompra.UseVisualStyleBackColor = True
        '
        'pnlComentario
        '
        Me.pnlComentario.Controls.Add(Me.Label17)
        Me.pnlComentario.Controls.Add(Me.txtComentario)
        Me.pnlComentario.Location = New System.Drawing.Point(32, 622)
        Me.pnlComentario.Name = "pnlComentario"
        Me.pnlComentario.Size = New System.Drawing.Size(370, 138)
        Me.pnlComentario.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(19, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 22)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario.Location = New System.Drawing.Point(22, 31)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(322, 82)
        Me.txtComentario.TabIndex = 5
        Me.txtComentario.Text = ""
        '
        'pnlTotales
        '
        Me.pnlTotales.Controls.Add(Me.Label16)
        Me.pnlTotales.Controls.Add(Me.lblTotal)
        Me.pnlTotales.Controls.Add(Me.txtTotalCompra)
        Me.pnlTotales.Controls.Add(Me.Label10)
        Me.pnlTotales.Controls.Add(Me.txtIva)
        Me.pnlTotales.Controls.Add(Me.Label12)
        Me.pnlTotales.Controls.Add(Me.txtSub)
        Me.pnlTotales.Location = New System.Drawing.Point(577, 619)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Size = New System.Drawing.Size(385, 227)
        Me.pnlTotales.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(25, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 26)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "TOTALES"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.Location = New System.Drawing.Point(25, 165)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(111, 22)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "TOTAL Gs."
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompra.Location = New System.Drawing.Point(158, 161)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.ReadOnly = True
        Me.txtTotalCompra.Size = New System.Drawing.Size(193, 30)
        Me.txtTotalCompra.TabIndex = 12
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(25, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 22)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "SUB-TOTAL"
        '
        'txtIva
        '
        Me.txtIva.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(158, 108)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(193, 30)
        Me.txtIva.TabIndex = 14
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(78, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 22)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "IVA"
        '
        'txtSub
        '
        Me.txtSub.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSub.Location = New System.Drawing.Point(158, 56)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.ReadOnly = True
        Me.txtSub.Size = New System.Drawing.Size(193, 30)
        Me.txtSub.TabIndex = 14
        Me.txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle32
        Me.dgvProductos.Location = New System.Drawing.Point(32, 385)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1046, 208)
        Me.dgvProductos.TabIndex = 4
        '
        'tpAnularVenta
        '
        Me.tpAnularVenta.BackColor = System.Drawing.Color.SteelBlue
        Me.tpAnularVenta.Controls.Add(Me.pnlOperandosAnular)
        Me.tpAnularVenta.Controls.Add(Me.dgvComprasAnular)
        Me.tpAnularVenta.Controls.Add(Me.txtTituloAnular)
        Me.tpAnularVenta.Controls.Add(Me.pnlAnular)
        Me.tpAnularVenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpAnularVenta.Location = New System.Drawing.Point(4, 38)
        Me.tpAnularVenta.Name = "tpAnularVenta"
        Me.tpAnularVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAnularVenta.Size = New System.Drawing.Size(1248, 532)
        Me.tpAnularVenta.TabIndex = 2
        Me.tpAnularVenta.Text = "Anular Venta"
        '
        'pnlOperandosAnular
        '
        Me.pnlOperandosAnular.Controls.Add(Me.btnAnularVenta)
        Me.pnlOperandosAnular.Controls.Add(Me.btnVerDetalleAnul)
        Me.pnlOperandosAnular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOperandosAnular.Location = New System.Drawing.Point(538, 242)
        Me.pnlOperandosAnular.Name = "pnlOperandosAnular"
        Me.pnlOperandosAnular.Size = New System.Drawing.Size(398, 76)
        Me.pnlOperandosAnular.TabIndex = 4
        '
        'btnAnularVenta
        '
        Me.btnAnularVenta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularVenta.Location = New System.Drawing.Point(205, 23)
        Me.btnAnularVenta.Name = "btnAnularVenta"
        Me.btnAnularVenta.Size = New System.Drawing.Size(164, 34)
        Me.btnAnularVenta.TabIndex = 1
        Me.btnAnularVenta.Text = "Anular Factura"
        Me.btnAnularVenta.UseVisualStyleBackColor = True
        '
        'btnVerDetalleAnul
        '
        Me.btnVerDetalleAnul.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleAnul.Location = New System.Drawing.Point(38, 22)
        Me.btnVerDetalleAnul.Name = "btnVerDetalleAnul"
        Me.btnVerDetalleAnul.Size = New System.Drawing.Size(132, 35)
        Me.btnVerDetalleAnul.TabIndex = 0
        Me.btnVerDetalleAnul.Text = "Ver Detalle"
        Me.btnVerDetalleAnul.UseVisualStyleBackColor = True
        '
        'dgvComprasAnular
        '
        Me.dgvComprasAnular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComprasAnular.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvComprasAnular.Location = New System.Drawing.Point(115, 324)
        Me.dgvComprasAnular.MultiSelect = False
        Me.dgvComprasAnular.Name = "dgvComprasAnular"
        Me.dgvComprasAnular.ReadOnly = True
        Me.dgvComprasAnular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprasAnular.Size = New System.Drawing.Size(821, 218)
        Me.dgvComprasAnular.TabIndex = 3
        '
        'txtTituloAnular
        '
        Me.txtTituloAnular.AutoSize = True
        Me.txtTituloAnular.BackColor = System.Drawing.Color.Transparent
        Me.txtTituloAnular.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTituloAnular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTituloAnular.Location = New System.Drawing.Point(381, 45)
        Me.txtTituloAnular.Name = "txtTituloAnular"
        Me.txtTituloAnular.Size = New System.Drawing.Size(211, 36)
        Me.txtTituloAnular.TabIndex = 2
        Me.txtTituloAnular.Text = "Anular Venta"
        '
        'pnlAnular
        '
        Me.pnlAnular.Controls.Add(Me.txtHastaAnul)
        Me.pnlAnular.Controls.Add(Me.txtFiltro)
        Me.pnlAnular.Controls.Add(Me.btnBuscarAnular)
        Me.pnlAnular.Controls.Add(Me.dpAnularVentaFin)
        Me.pnlAnular.Controls.Add(Me.dpAnularVentaIni)
        Me.pnlAnular.Controls.Add(Me.Label21)
        Me.pnlAnular.Controls.Add(Me.txtNrofacturaAnul)
        Me.pnlAnular.Controls.Add(Me.cbCliente3)
        Me.pnlAnular.Controls.Add(Me.cbAnularFiltro)
        Me.pnlAnular.Location = New System.Drawing.Point(115, 144)
        Me.pnlAnular.Name = "pnlAnular"
        Me.pnlAnular.Size = New System.Drawing.Size(821, 75)
        Me.pnlAnular.TabIndex = 0
        '
        'txtHastaAnul
        '
        Me.txtHastaAnul.AutoSize = True
        Me.txtHastaAnul.BackColor = System.Drawing.Color.Transparent
        Me.txtHastaAnul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtHastaAnul.Location = New System.Drawing.Point(397, 76)
        Me.txtHastaAnul.Name = "txtHastaAnul"
        Me.txtHastaAnul.Size = New System.Drawing.Size(53, 19)
        Me.txtHastaAnul.TabIndex = 7
        Me.txtHastaAnul.Text = "Hasta"
        Me.txtHastaAnul.Visible = False
        '
        'txtFiltro
        '
        Me.txtFiltro.AutoSize = True
        Me.txtFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtFiltro.Location = New System.Drawing.Point(397, 8)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(103, 19)
        Me.txtFiltro.TabIndex = 7
        Me.txtFiltro.Text = "Nro. Factura"
        Me.txtFiltro.Visible = False
        '
        'btnBuscarAnular
        '
        Me.btnBuscarAnular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarAnular.Location = New System.Drawing.Point(661, 26)
        Me.btnBuscarAnular.Name = "btnBuscarAnular"
        Me.btnBuscarAnular.Size = New System.Drawing.Size(131, 33)
        Me.btnBuscarAnular.TabIndex = 6
        Me.btnBuscarAnular.Text = "Buscar"
        Me.btnBuscarAnular.UseVisualStyleBackColor = True
        '
        'dpAnularVentaFin
        '
        Me.dpAnularVentaFin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpAnularVentaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpAnularVentaFin.Location = New System.Drawing.Point(397, 98)
        Me.dpAnularVentaFin.Name = "dpAnularVentaFin"
        Me.dpAnularVentaFin.Size = New System.Drawing.Size(200, 26)
        Me.dpAnularVentaFin.TabIndex = 5
        Me.dpAnularVentaFin.Visible = False
        '
        'dpAnularVentaIni
        '
        Me.dpAnularVentaIni.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpAnularVentaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpAnularVentaIni.Location = New System.Drawing.Point(20, 88)
        Me.dpAnularVentaIni.Name = "dpAnularVentaIni"
        Me.dpAnularVentaIni.Size = New System.Drawing.Size(200, 26)
        Me.dpAnularVentaIni.TabIndex = 5
        Me.dpAnularVentaIni.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(76, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 27)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Buscar Por:"
        '
        'txtNrofacturaAnul
        '
        Me.txtNrofacturaAnul.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrofacturaAnul.Location = New System.Drawing.Point(397, 30)
        Me.txtNrofacturaAnul.Name = "txtNrofacturaAnul"
        Me.txtNrofacturaAnul.Size = New System.Drawing.Size(176, 26)
        Me.txtNrofacturaAnul.TabIndex = 4
        '
        'cbCliente3
        '
        Me.cbCliente3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente3.FormattingEnabled = True
        Me.cbCliente3.Location = New System.Drawing.Point(173, 88)
        Me.cbCliente3.Name = "cbCliente3"
        Me.cbCliente3.Size = New System.Drawing.Size(200, 26)
        Me.cbCliente3.TabIndex = 3
        Me.cbCliente3.Visible = False
        '
        'cbAnularFiltro
        '
        Me.cbAnularFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAnularFiltro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAnularFiltro.FormattingEnabled = True
        Me.cbAnularFiltro.Location = New System.Drawing.Point(227, 30)
        Me.cbAnularFiltro.Name = "cbAnularFiltro"
        Me.cbAnularFiltro.Size = New System.Drawing.Size(146, 26)
        Me.cbAnularFiltro.TabIndex = 2
        '
        'tpCobros
        '
        Me.tpCobros.BackColor = System.Drawing.Color.SteelBlue
        Me.tpCobros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tpCobros.Controls.Add(Me.dgvComprasP)
        Me.tpCobros.Controls.Add(Me.lblTituloP)
        Me.tpCobros.Controls.Add(Me.pnlPago)
        Me.tpCobros.Location = New System.Drawing.Point(4, 38)
        Me.tpCobros.Name = "tpCobros"
        Me.tpCobros.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCobros.Size = New System.Drawing.Size(1248, 532)
        Me.tpCobros.TabIndex = 3
        Me.tpCobros.Text = "Cobros"
        '
        'dgvComprasP
        '
        Me.dgvComprasP.AllowUserToAddRows = False
        Me.dgvComprasP.AllowUserToDeleteRows = False
        Me.dgvComprasP.AllowUserToOrderColumns = True
        Me.dgvComprasP.AllowUserToResizeColumns = False
        Me.dgvComprasP.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvComprasP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvComprasP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComprasP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvComprasP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComprasP.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvComprasP.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvComprasP.Location = New System.Drawing.Point(42, 317)
        Me.dgvComprasP.Name = "dgvComprasP"
        Me.dgvComprasP.ReadOnly = True
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvComprasP.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvComprasP.RowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvComprasP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprasP.Size = New System.Drawing.Size(910, 308)
        Me.dgvComprasP.TabIndex = 37
        Me.dgvComprasP.Visible = False
        '
        'lblTituloP
        '
        Me.lblTituloP.AutoSize = True
        Me.lblTituloP.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloP.Location = New System.Drawing.Point(372, 38)
        Me.lblTituloP.Name = "lblTituloP"
        Me.lblTituloP.Size = New System.Drawing.Size(291, 32)
        Me.lblTituloP.TabIndex = 6
        Me.lblTituloP.Text = "COBROS DE VENTAS"
        '
        'pnlPago
        '
        Me.pnlPago.Controls.Add(Me.cbProveedor4)
        Me.pnlPago.Controls.Add(Me.btnDetalleP)
        Me.pnlPago.Controls.Add(Me.btnPagar)
        Me.pnlPago.Controls.Add(Me.btnBuscarP)
        Me.pnlPago.Controls.Add(Me.lblFiltroTipo)
        Me.pnlPago.Controls.Add(Me.Label25)
        Me.pnlPago.Controls.Add(Me.txtNroFactPago)
        Me.pnlPago.Controls.Add(Me.cbFiltroP)
        Me.pnlPago.Controls.Add(Me.pnlFechas)
        Me.pnlPago.Location = New System.Drawing.Point(42, 83)
        Me.pnlPago.Name = "pnlPago"
        Me.pnlPago.Size = New System.Drawing.Size(910, 188)
        Me.pnlPago.TabIndex = 5
        '
        'cbProveedor4
        '
        Me.cbProveedor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor4.FormattingEnabled = True
        Me.cbProveedor4.Location = New System.Drawing.Point(50, 121)
        Me.cbProveedor4.Name = "cbProveedor4"
        Me.cbProveedor4.Size = New System.Drawing.Size(217, 26)
        Me.cbProveedor4.TabIndex = 12
        Me.cbProveedor4.Visible = False
        '
        'btnDetalleP
        '
        Me.btnDetalleP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDetalleP.Location = New System.Drawing.Point(639, 132)
        Me.btnDetalleP.Name = "btnDetalleP"
        Me.btnDetalleP.Size = New System.Drawing.Size(111, 30)
        Me.btnDetalleP.TabIndex = 11
        Me.btnDetalleP.Text = "Ver Detalle"
        Me.btnDetalleP.UseVisualStyleBackColor = True
        Me.btnDetalleP.Visible = False
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPagar.Location = New System.Drawing.Point(491, 132)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(142, 29)
        Me.btnPagar.TabIndex = 3
        Me.btnPagar.Text = "Realizar Pago"
        Me.btnPagar.UseVisualStyleBackColor = True
        Me.btnPagar.Visible = False
        '
        'btnBuscarP
        '
        Me.btnBuscarP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscarP.Location = New System.Drawing.Point(756, 133)
        Me.btnBuscarP.Name = "btnBuscarP"
        Me.btnBuscarP.Size = New System.Drawing.Size(108, 29)
        Me.btnBuscarP.TabIndex = 3
        Me.btnBuscarP.Text = "Buscar"
        Me.btnBuscarP.UseVisualStyleBackColor = True
        '
        'lblFiltroTipo
        '
        Me.lblFiltroTipo.AutoSize = True
        Me.lblFiltroTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblFiltroTipo.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFiltroTipo.Location = New System.Drawing.Point(398, 28)
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
        Me.Label25.Location = New System.Drawing.Point(46, 55)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 27)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Buscar por"
        '
        'txtNroFactPago
        '
        Me.txtNroFactPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFactPago.Location = New System.Drawing.Point(401, 59)
        Me.txtNroFactPago.Name = "txtNroFactPago"
        Me.txtNroFactPago.Size = New System.Drawing.Size(262, 26)
        Me.txtNroFactPago.TabIndex = 8
        '
        'cbFiltroP
        '
        Me.cbFiltroP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltroP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroP.FormattingEnabled = True
        Me.cbFiltroP.Location = New System.Drawing.Point(178, 57)
        Me.cbFiltroP.Name = "cbFiltroP"
        Me.cbFiltroP.Size = New System.Drawing.Size(184, 27)
        Me.cbFiltroP.TabIndex = 6
        '
        'pnlFechas
        '
        Me.pnlFechas.BackColor = System.Drawing.Color.Transparent
        Me.pnlFechas.Controls.Add(Me.dpHastaPago)
        Me.pnlFechas.Controls.Add(Me.dpDesdePago)
        Me.pnlFechas.Controls.Add(Me.Label23)
        Me.pnlFechas.Controls.Add(Me.Label24)
        Me.pnlFechas.Location = New System.Drawing.Point(389, 13)
        Me.pnlFechas.Name = "pnlFechas"
        Me.pnlFechas.Size = New System.Drawing.Size(494, 100)
        Me.pnlFechas.TabIndex = 7
        Me.pnlFechas.Visible = False
        '
        'dpHastaPago
        '
        Me.dpHastaPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpHastaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpHastaPago.Location = New System.Drawing.Point(265, 46)
        Me.dpHastaPago.Name = "dpHastaPago"
        Me.dpHastaPago.Size = New System.Drawing.Size(200, 27)
        Me.dpHastaPago.TabIndex = 0
        '
        'dpDesdePago
        '
        Me.dpDesdePago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDesdePago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDesdePago.Location = New System.Drawing.Point(35, 46)
        Me.dpDesdePago.Name = "dpDesdePago"
        Me.dpDesdePago.Size = New System.Drawing.Size(200, 27)
        Me.dpDesdePago.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(260, 13)
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
        Me.Label24.Location = New System.Drawing.Point(30, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 27)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Desde"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(118, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 27)
        Me.ComboBox1.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 19)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Vendedor"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(439, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 26)
        Me.TextBox1.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label26.Location = New System.Drawing.Point(332, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 19)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Recibo Nº"
        '
        'AdministrarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 574)
        Me.Controls.Add(Me.tbcVenta)
        Me.Name = "AdministrarVentas"
        Me.Text = "AdministrarVentas"
        Me.tbcVenta.ResumeLayout(False)
        Me.tpListado.ResumeLayout(False)
        Me.tpListado.PerformLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlListado.ResumeLayout(False)
        Me.pnlListado.PerformLayout()
        Me.pnlRangoFecha.ResumeLayout(False)
        Me.pnlRangoFecha.PerformLayout()
        Me.tpNuevaVenta.ResumeLayout(False)
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatosProducto.ResumeLayout(False)
        Me.pnlDatosProducto.PerformLayout()
        Me.pnlDatosCompra.ResumeLayout(False)
        Me.pnlDatosCompra.PerformLayout()
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.gbCliente.ResumeLayout(False)
        Me.gbCliente.PerformLayout()
        Me.pnlSeleccionProd.ResumeLayout(False)
        Me.pnlOperadores.ResumeLayout(False)
        Me.pnlComentario.ResumeLayout(False)
        Me.pnlComentario.PerformLayout()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAnularVenta.ResumeLayout(False)
        Me.tpAnularVenta.PerformLayout()
        Me.pnlOperandosAnular.ResumeLayout(False)
        CType(Me.dgvComprasAnular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAnular.ResumeLayout(False)
        Me.pnlAnular.PerformLayout()
        Me.tpCobros.ResumeLayout(False)
        Me.tpCobros.PerformLayout()
        CType(Me.dgvComprasP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPago.ResumeLayout(False)
        Me.pnlPago.PerformLayout()
        Me.pnlFechas.ResumeLayout(False)
        Me.pnlFechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcVenta As TabControl
    Friend WithEvents tpListado As TabPage
    Friend WithEvents dgvCompras As DataGridView
    Friend WithEvents pnlListado As Panel
    Friend WithEvents txtNroFacturaListado As TextBox
    Friend WithEvents cbEstadoCompra As ComboBox
    Friend WithEvents btnDetalle As Button
    Friend WithEvents btnBuscarCompra As Button
    Friend WithEvents lblBusqTxt As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbCliente1 As ComboBox
    Friend WithEvents cbBuscarVenta As ComboBox
    Friend WithEvents pnlRangoFecha As Panel
    Friend WithEvents datepFin As DateTimePicker
    Friend WithEvents datepInicio As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTituloBusqueda As Label
    Friend WithEvents tpNuevaVenta As TabPage
    Friend WithEvents dgvBusquedaResult As DataGridView
    Friend WithEvents pnlDatosProducto As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents cbImpuesto As ComboBox
    Friend WithEvents cbDeposito As ComboBox
    Friend WithEvents btnBuscarProd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnInsertarProd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminarProd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFiltroBusquedaNC As TextBox
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtDescripcionProd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecioProd As TextBox
    Friend WithEvents pnlDatosCompra As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents gbTipoPago As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtEntregaInicial As TextBox
    Friend WithEvents rbCredito As RadioButton
    Friend WithEvents rbContado As RadioButton
    Friend WithEvents dateFactura As DateTimePicker
    Friend WithEvents gbCliente As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbProveedor2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFacturaNro As TextBox
    Friend WithEvents pnlSeleccionProd As Panel
    Friend WithEvents btnSeleccionarPr As Button
    Friend WithEvents pnlOperadores As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnGuardarCompra As Button
    Friend WithEvents pnlComentario As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents txtComentario As RichTextBox
    Friend WithEvents pnlTotales As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotalCompra As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSub As TextBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents tpAnularVenta As TabPage
    Friend WithEvents pnlOperandosAnular As Panel
    Friend WithEvents btnAnularVenta As Button
    Friend WithEvents btnVerDetalleAnul As Button
    Friend WithEvents dgvComprasAnular As DataGridView
    Friend WithEvents txtTituloAnular As Label
    Friend WithEvents pnlAnular As Panel
    Friend WithEvents txtHastaAnul As Label
    Friend WithEvents txtFiltro As Label
    Friend WithEvents btnBuscarAnular As Button
    Friend WithEvents dpAnularVentaFin As DateTimePicker
    Friend WithEvents dpAnularVentaIni As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNrofacturaAnul As TextBox
    Friend WithEvents cbCliente3 As ComboBox
    Friend WithEvents cbAnularFiltro As ComboBox
    Friend WithEvents tpCobros As TabPage
    Friend WithEvents dgvComprasP As DataGridView
    Friend WithEvents lblTituloP As Label
    Friend WithEvents pnlPago As Panel
    Friend WithEvents cbProveedor4 As ComboBox
    Friend WithEvents btnDetalleP As Button
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnBuscarP As Button
    Friend WithEvents lblFiltroTipo As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtNroFactPago As TextBox
    Friend WithEvents cbFiltroP As ComboBox
    Friend WithEvents pnlFechas As Panel
    Friend WithEvents dpHastaPago As DateTimePicker
    Friend WithEvents dpDesdePago As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
