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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrarVentas))
        Me.tbcVenta = New System.Windows.Forms.TabControl()
        Me.tpListado = New System.Windows.Forms.TabPage()
        Me.dgvVentasListado = New System.Windows.Forms.DataGridView()
        Me.pnlListado = New System.Windows.Forms.Panel()
        Me.txtClienteRucListado = New System.Windows.Forms.TextBox()
        Me.txtNroFacturaListado = New System.Windows.Forms.TextBox()
        Me.cbEstadoCompra = New System.Windows.Forms.ComboBox()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnBuscarCompra = New System.Windows.Forms.Button()
        Me.lblBusqTxt = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbBuscarVentaListado = New System.Windows.Forms.ComboBox()
        Me.pnlRangoFecha = New System.Windows.Forms.Panel()
        Me.datepFin = New System.Windows.Forms.DateTimePicker()
        Me.datepInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTituloBusquedaList = New System.Windows.Forms.Label()
        Me.tpNuevaVenta = New System.Windows.Forms.TabPage()
        Me.pnlDescuento = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnDeschacerDesc = New System.Windows.Forms.Button()
        Me.btnAplicarDesc = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNombreCli = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbVendedor2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvBusquedaResult = New System.Windows.Forms.DataGridView()
        Me.pnlDatosProducto = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbImpuesto = New System.Windows.Forms.ComboBox()
        Me.txtPrecioProd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtM2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.txtFiltroBusquedaNC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnInsertarProd = New System.Windows.Forms.Button()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.pnlDatosVenta = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDeposito = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.dateFactura = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbContado = New System.Windows.Forms.RadioButton()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlSeleccionProd = New System.Windows.Forms.Panel()
        Me.btnCancelarSeleccion = New System.Windows.Forms.Button()
        Me.btnSeleccionarPr = New System.Windows.Forms.Button()
        Me.pnlOperadores = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnGuardarVenta = New System.Windows.Forms.Button()
        Me.pnlComentario = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.pnlTotales = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.tpAnularVenta = New System.Windows.Forms.TabPage()
        Me.pnlComentarioAnular = New System.Windows.Forms.Panel()
        Me.txtComentAnular = New System.Windows.Forms.RichTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.pnlOperandosAnular = New System.Windows.Forms.Panel()
        Me.btnAnularVenta = New System.Windows.Forms.Button()
        Me.btnVerDetalleAnul = New System.Windows.Forms.Button()
        Me.dgvVentasAnular = New System.Windows.Forms.DataGridView()
        Me.txtTituloAnular = New System.Windows.Forms.Label()
        Me.pnlAnular = New System.Windows.Forms.Panel()
        Me.txtClienteAnular = New System.Windows.Forms.TextBox()
        Me.txtHastaAnul = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.Label()
        Me.btnBuscarAnular = New System.Windows.Forms.Button()
        Me.dpAnularVentaFin = New System.Windows.Forms.DateTimePicker()
        Me.dpAnularVentaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNrofacturaAnul = New System.Windows.Forms.TextBox()
        Me.cbAnularFiltro = New System.Windows.Forms.ComboBox()
        Me.tpCobros = New System.Windows.Forms.TabPage()
        Me.dgvVentasCobro = New System.Windows.Forms.DataGridView()
        Me.lblTituloVenta = New System.Windows.Forms.Label()
        Me.pnlCobro = New System.Windows.Forms.Panel()
        Me.txtClienteCobro = New System.Windows.Forms.TextBox()
        Me.btnDetalleCobro = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnBuscarCobro = New System.Windows.Forms.Button()
        Me.lblFiltroTipo = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNroFactCobro = New System.Windows.Forms.TextBox()
        Me.cbFiltroCobro = New System.Windows.Forms.ComboBox()
        Me.pnlFechas = New System.Windows.Forms.Panel()
        Me.dpHastaPago = New System.Windows.Forms.DateTimePicker()
        Me.dpDesdePago = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbcVenta.SuspendLayout()
        Me.tpListado.SuspendLayout()
        CType(Me.dgvVentasListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlListado.SuspendLayout()
        Me.pnlRangoFecha.SuspendLayout()
        Me.tpNuevaVenta.SuspendLayout()
        Me.pnlDescuento.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatosProducto.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlDatosVenta.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlSeleccionProd.SuspendLayout()
        Me.pnlOperadores.SuspendLayout()
        Me.pnlComentario.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAnularVenta.SuspendLayout()
        Me.pnlComentarioAnular.SuspendLayout()
        Me.pnlOperandosAnular.SuspendLayout()
        CType(Me.dgvVentasAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAnular.SuspendLayout()
        Me.tpCobros.SuspendLayout()
        CType(Me.dgvVentasCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCobro.SuspendLayout()
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
        Me.tbcVenta.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcVenta.Location = New System.Drawing.Point(0, 0)
        Me.tbcVenta.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcVenta.Name = "tbcVenta"
        Me.tbcVenta.Padding = New System.Drawing.Point(10, 5)
        Me.tbcVenta.SelectedIndex = 0
        Me.tbcVenta.Size = New System.Drawing.Size(1309, 742)
        Me.tbcVenta.TabIndex = 4
        '
        'tpListado
        '
        Me.tpListado.BackColor = System.Drawing.Color.SteelBlue
        Me.tpListado.Controls.Add(Me.dgvVentasListado)
        Me.tpListado.Controls.Add(Me.pnlListado)
        Me.tpListado.Controls.Add(Me.txtTituloBusquedaList)
        Me.tpListado.Location = New System.Drawing.Point(4, 29)
        Me.tpListado.Name = "tpListado"
        Me.tpListado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListado.Size = New System.Drawing.Size(1301, 709)
        Me.tpListado.TabIndex = 0
        Me.tpListado.Text = "Listado"
        '
        'dgvVentasListado
        '
        Me.dgvVentasListado.AllowUserToAddRows = False
        Me.dgvVentasListado.AllowUserToDeleteRows = False
        Me.dgvVentasListado.AllowUserToOrderColumns = True
        Me.dgvVentasListado.AllowUserToResizeColumns = False
        Me.dgvVentasListado.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvVentasListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentasListado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVentasListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasListado.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentasListado.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvVentasListado.Location = New System.Drawing.Point(51, 323)
        Me.dgvVentasListado.MultiSelect = False
        Me.dgvVentasListado.Name = "dgvVentasListado"
        Me.dgvVentasListado.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVentasListado.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvVentasListado.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVentasListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentasListado.Size = New System.Drawing.Size(910, 334)
        Me.dgvVentasListado.TabIndex = 35
        Me.dgvVentasListado.Visible = False
        '
        'pnlListado
        '
        Me.pnlListado.Controls.Add(Me.txtClienteRucListado)
        Me.pnlListado.Controls.Add(Me.txtNroFacturaListado)
        Me.pnlListado.Controls.Add(Me.cbEstadoCompra)
        Me.pnlListado.Controls.Add(Me.btnDetalle)
        Me.pnlListado.Controls.Add(Me.btnBuscarCompra)
        Me.pnlListado.Controls.Add(Me.lblBusqTxt)
        Me.pnlListado.Controls.Add(Me.Label15)
        Me.pnlListado.Controls.Add(Me.cbBuscarVentaListado)
        Me.pnlListado.Controls.Add(Me.pnlRangoFecha)
        Me.pnlListado.Location = New System.Drawing.Point(51, 85)
        Me.pnlListado.Name = "pnlListado"
        Me.pnlListado.Size = New System.Drawing.Size(910, 189)
        Me.pnlListado.TabIndex = 5
        '
        'txtClienteRucListado
        '
        Me.txtClienteRucListado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteRucListado.Location = New System.Drawing.Point(248, 135)
        Me.txtClienteRucListado.Name = "txtClienteRucListado"
        Me.txtClienteRucListado.Size = New System.Drawing.Size(262, 26)
        Me.txtClienteRucListado.TabIndex = 8
        Me.txtClienteRucListado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnDetalle.Location = New System.Drawing.Point(746, 113)
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
        Me.btnBuscarCompra.Location = New System.Drawing.Point(749, 51)
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
        Me.lblBusqTxt.Location = New System.Drawing.Point(383, 27)
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
        'cbBuscarVentaListado
        '
        Me.cbBuscarVentaListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscarVentaListado.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarVentaListado.FormattingEnabled = True
        Me.cbBuscarVentaListado.Location = New System.Drawing.Point(144, 56)
        Me.cbBuscarVentaListado.Name = "cbBuscarVentaListado"
        Me.cbBuscarVentaListado.Size = New System.Drawing.Size(184, 27)
        Me.cbBuscarVentaListado.TabIndex = 6
        '
        'pnlRangoFecha
        '
        Me.pnlRangoFecha.BackColor = System.Drawing.Color.Transparent
        Me.pnlRangoFecha.Controls.Add(Me.datepFin)
        Me.pnlRangoFecha.Controls.Add(Me.datepInicio)
        Me.pnlRangoFecha.Controls.Add(Me.Label14)
        Me.pnlRangoFecha.Controls.Add(Me.Label13)
        Me.pnlRangoFecha.Location = New System.Drawing.Point(332, 10)
        Me.pnlRangoFecha.Name = "pnlRangoFecha"
        Me.pnlRangoFecha.Size = New System.Drawing.Size(350, 162)
        Me.pnlRangoFecha.TabIndex = 7
        Me.pnlRangoFecha.Visible = False
        '
        'datepFin
        '
        Me.datepFin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepFin.Location = New System.Drawing.Point(35, 106)
        Me.datepFin.Name = "datepFin"
        Me.datepFin.Size = New System.Drawing.Size(238, 27)
        Me.datepFin.TabIndex = 0
        '
        'datepInicio
        '
        Me.datepInicio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepInicio.Location = New System.Drawing.Point(35, 46)
        Me.datepInicio.Name = "datepInicio"
        Me.datepInicio.Size = New System.Drawing.Size(238, 27)
        Me.datepInicio.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(30, 76)
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
        'txtTituloBusquedaList
        '
        Me.txtTituloBusquedaList.AutoSize = True
        Me.txtTituloBusquedaList.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTituloBusquedaList.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTituloBusquedaList.Location = New System.Drawing.Point(375, 28)
        Me.txtTituloBusquedaList.Name = "txtTituloBusquedaList"
        Me.txtTituloBusquedaList.Size = New System.Drawing.Size(292, 36)
        Me.txtTituloBusquedaList.TabIndex = 1
        Me.txtTituloBusquedaList.Text = "Listado de Ventas"
        '
        'tpNuevaVenta
        '
        Me.tpNuevaVenta.AutoScroll = True
        Me.tpNuevaVenta.BackColor = System.Drawing.Color.SteelBlue
        Me.tpNuevaVenta.Controls.Add(Me.pnlDescuento)
        Me.tpNuevaVenta.Controls.Add(Me.Panel3)
        Me.tpNuevaVenta.Controls.Add(Me.Panel2)
        Me.tpNuevaVenta.Controls.Add(Me.dgvBusquedaResult)
        Me.tpNuevaVenta.Controls.Add(Me.pnlDatosProducto)
        Me.tpNuevaVenta.Controls.Add(Me.pnlDatosVenta)
        Me.tpNuevaVenta.Controls.Add(Me.pnlSeleccionProd)
        Me.tpNuevaVenta.Controls.Add(Me.pnlOperadores)
        Me.tpNuevaVenta.Controls.Add(Me.pnlComentario)
        Me.tpNuevaVenta.Controls.Add(Me.pnlTotales)
        Me.tpNuevaVenta.Controls.Add(Me.dgvProductos)
        Me.tpNuevaVenta.Location = New System.Drawing.Point(4, 31)
        Me.tpNuevaVenta.Name = "tpNuevaVenta"
        Me.tpNuevaVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNuevaVenta.Size = New System.Drawing.Size(1301, 707)
        Me.tpNuevaVenta.TabIndex = 1
        Me.tpNuevaVenta.Text = "Nueva Venta"
        '
        'pnlDescuento
        '
        Me.pnlDescuento.Controls.Add(Me.Label28)
        Me.pnlDescuento.Controls.Add(Me.btnDeschacerDesc)
        Me.pnlDescuento.Controls.Add(Me.btnAplicarDesc)
        Me.pnlDescuento.Controls.Add(Me.txtDescuento)
        Me.pnlDescuento.Location = New System.Drawing.Point(3, 622)
        Me.pnlDescuento.Name = "pnlDescuento"
        Me.pnlDescuento.Size = New System.Drawing.Size(336, 139)
        Me.pnlDescuento.TabIndex = 39
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Location = New System.Drawing.Point(125, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(86, 18)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Descuento"
        '
        'btnDeschacerDesc
        '
        Me.btnDeschacerDesc.Enabled = False
        Me.btnDeschacerDesc.Location = New System.Drawing.Point(167, 85)
        Me.btnDeschacerDesc.Name = "btnDeschacerDesc"
        Me.btnDeschacerDesc.Size = New System.Drawing.Size(131, 38)
        Me.btnDeschacerDesc.TabIndex = 2
        Me.btnDeschacerDesc.Text = "Deshacer"
        Me.btnDeschacerDesc.UseVisualStyleBackColor = True
        '
        'btnAplicarDesc
        '
        Me.btnAplicarDesc.Location = New System.Drawing.Point(30, 85)
        Me.btnAplicarDesc.Name = "btnAplicarDesc"
        Me.btnAplicarDesc.Size = New System.Drawing.Size(131, 38)
        Me.btnAplicarDesc.TabIndex = 2
        Me.btnAplicarDesc.Text = "Aplicar"
        Me.btnAplicarDesc.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(61, 38)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(223, 26)
        Me.txtDescuento.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtNombreCli)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtCI)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(350, 117)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(855, 81)
        Me.Panel3.TabIndex = 38
        '
        'txtNombreCli
        '
        Me.txtNombreCli.Enabled = False
        Me.txtNombreCli.Location = New System.Drawing.Point(564, 35)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.ShortcutsEnabled = False
        Me.txtNombreCli.Size = New System.Drawing.Size(212, 26)
        Me.txtNombreCli.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Location = New System.Drawing.Point(383, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 19)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "CLIENTE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(75, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "RUC/C.I"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(166, 35)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(197, 26)
        Me.txtCI.TabIndex = 7
        Me.txtCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(464, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nombre"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbVendedor2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(8, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(308, 81)
        Me.Panel2.TabIndex = 37
        '
        'cbVendedor2
        '
        Me.cbVendedor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVendedor2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVendedor2.FormattingEnabled = True
        Me.cbVendedor2.Location = New System.Drawing.Point(62, 38)
        Me.cbVendedor2.Name = "cbVendedor2"
        Me.cbVendedor2.Size = New System.Drawing.Size(215, 27)
        Me.cbVendedor2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(115, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "VENDEDOR"
        '
        'dgvBusquedaResult
        '
        Me.dgvBusquedaResult.AllowUserToAddRows = False
        Me.dgvBusquedaResult.AllowUserToDeleteRows = False
        Me.dgvBusquedaResult.AllowUserToOrderColumns = True
        Me.dgvBusquedaResult.AllowUserToResizeColumns = False
        Me.dgvBusquedaResult.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBusquedaResult.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBusquedaResult.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBusquedaResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBusquedaResult.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBusquedaResult.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvBusquedaResult.Location = New System.Drawing.Point(93, 385)
        Me.dgvBusquedaResult.Name = "dgvBusquedaResult"
        Me.dgvBusquedaResult.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvBusquedaResult.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvBusquedaResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusquedaResult.Size = New System.Drawing.Size(826, 208)
        Me.dgvBusquedaResult.TabIndex = 36
        Me.dgvBusquedaResult.Visible = False
        '
        'pnlDatosProducto
        '
        Me.pnlDatosProducto.Controls.Add(Me.Panel6)
        Me.pnlDatosProducto.Controls.Add(Me.Panel1)
        Me.pnlDatosProducto.Controls.Add(Me.Label19)
        Me.pnlDatosProducto.Controls.Add(Me.btnInsertarProd)
        Me.pnlDatosProducto.Controls.Add(Me.btnEliminarProd)
        Me.pnlDatosProducto.Location = New System.Drawing.Point(6, 208)
        Me.pnlDatosProducto.Name = "pnlDatosProducto"
        Me.pnlDatosProducto.Size = New System.Drawing.Size(1199, 173)
        Me.pnlDatosProducto.TabIndex = 21
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cbImpuesto)
        Me.Panel6.Controls.Add(Me.txtPrecioProd)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label27)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label26)
        Me.Panel6.Controls.Add(Me.txtStock)
        Me.Panel6.Controls.Add(Me.txtCantidad)
        Me.Panel6.Controls.Add(Me.txtM2)
        Me.Panel6.Location = New System.Drawing.Point(433, 29)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(612, 135)
        Me.Panel6.TabIndex = 20
        '
        'cbImpuesto
        '
        Me.cbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImpuesto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbImpuesto.FormattingEnabled = True
        Me.cbImpuesto.Location = New System.Drawing.Point(10, 32)
        Me.cbImpuesto.Name = "cbImpuesto"
        Me.cbImpuesto.Size = New System.Drawing.Size(188, 27)
        Me.cbImpuesto.TabIndex = 13
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProd.Location = New System.Drawing.Point(232, 33)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(187, 27)
        Me.txtPrecioProd.TabIndex = 5
        Me.txtPrecioProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(290, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(8, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Stock Actual"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label27.Location = New System.Drawing.Point(456, 11)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 19)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Cantidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(53, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Impuesto"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label26.Location = New System.Drawing.Point(228, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(146, 19)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Superficie (M^2)"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(12, 96)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(187, 27)
        Me.txtStock.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(455, 33)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(83, 27)
        Me.txtCantidad.TabIndex = 5
        '
        'txtM2
        '
        Me.txtM2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtM2.Location = New System.Drawing.Point(232, 96)
        Me.txtM2.Name = "txtM2"
        Me.txtM2.Size = New System.Drawing.Size(187, 27)
        Me.txtM2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.btnBuscarProd)
        Me.Panel1.Controls.Add(Me.txtFiltroBusquedaNC)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDescripcionProd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtCodProd)
        Me.Panel1.Location = New System.Drawing.Point(20, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 135)
        Me.Panel1.TabIndex = 19
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label29.Location = New System.Drawing.Point(6, 6)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 19)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Filtro:"
        '
        'btnBuscarProd
        '
        Me.btnBuscarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProd.Location = New System.Drawing.Point(253, 28)
        Me.btnBuscarProd.Name = "btnBuscarProd"
        Me.btnBuscarProd.Size = New System.Drawing.Size(127, 32)
        Me.btnBuscarProd.TabIndex = 12
        Me.btnBuscarProd.Text = "Buscar"
        Me.btnBuscarProd.UseVisualStyleBackColor = True
        '
        'txtFiltroBusquedaNC
        '
        Me.txtFiltroBusquedaNC.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroBusquedaNC.Location = New System.Drawing.Point(10, 32)
        Me.txtFiltroBusquedaNC.Name = "txtFiltroBusquedaNC"
        Me.txtFiltroBusquedaNC.Size = New System.Drawing.Size(202, 27)
        Me.txtFiltroBusquedaNC.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(6, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'txtDescripcionProd
        '
        Me.txtDescripcionProd.Enabled = False
        Me.txtDescripcionProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProd.Location = New System.Drawing.Point(163, 96)
        Me.txtDescripcionProd.Name = "txtDescripcionProd"
        Me.txtDescripcionProd.ReadOnly = True
        Me.txtDescripcionProd.Size = New System.Drawing.Size(214, 27)
        Me.txtDescripcionProd.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(161, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción"
        '
        'txtCodProd
        '
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Enabled = False
        Me.txtCodProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(10, 96)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.ReadOnly = True
        Me.txtCodProd.Size = New System.Drawing.Size(137, 27)
        Me.txtCodProd.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(527, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(192, 22)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "DATOS PRODUCTO"
        '
        'btnInsertarProd
        '
        Me.btnInsertarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProd.Location = New System.Drawing.Point(1069, 56)
        Me.btnInsertarProd.Name = "btnInsertarProd"
        Me.btnInsertarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnInsertarProd.TabIndex = 2
        Me.btnInsertarProd.Text = "+"
        Me.btnInsertarProd.UseVisualStyleBackColor = True
        '
        'btnEliminarProd
        '
        Me.btnEliminarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProd.Location = New System.Drawing.Point(1069, 121)
        Me.btnEliminarProd.Name = "btnEliminarProd"
        Me.btnEliminarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnEliminarProd.TabIndex = 3
        Me.btnEliminarProd.Text = "-"
        Me.btnEliminarProd.UseVisualStyleBackColor = True
        '
        'pnlDatosVenta
        '
        Me.pnlDatosVenta.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosVenta.Controls.Add(Me.Panel5)
        Me.pnlDatosVenta.Controls.Add(Me.Panel4)
        Me.pnlDatosVenta.Controls.Add(Me.Label18)
        Me.pnlDatosVenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosVenta.Location = New System.Drawing.Point(8, 1)
        Me.pnlDatosVenta.Name = "pnlDatosVenta"
        Me.pnlDatosVenta.Size = New System.Drawing.Size(1197, 105)
        Me.pnlDatosVenta.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txtFacturaNro)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cbDeposito)
        Me.Panel5.Controls.Add(Me.Label30)
        Me.Panel5.Controls.Add(Me.dateFactura)
        Me.Panel5.Location = New System.Drawing.Point(34, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(718, 64)
        Me.Panel5.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(87, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Factura Nº"
        '
        'txtFacturaNro
        '
        Me.txtFacturaNro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacturaNro.Location = New System.Drawing.Point(28, 32)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.Size = New System.Drawing.Size(196, 26)
        Me.txtFacturaNro.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(289, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Factura"
        '
        'cbDeposito
        '
        Me.cbDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeposito.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDeposito.FormattingEnabled = True
        Me.cbDeposito.Location = New System.Drawing.Point(484, 31)
        Me.cbDeposito.Name = "cbDeposito"
        Me.cbDeposito.Size = New System.Drawing.Size(202, 27)
        Me.cbDeposito.TabIndex = 10
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label30.Location = New System.Drawing.Point(535, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(81, 19)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "Depósito"
        '
        'dateFactura
        '
        Me.dateFactura.CustomFormat = "dd/mm/aaaa"
        Me.dateFactura.Enabled = False
        Me.dateFactura.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFactura.Location = New System.Drawing.Point(248, 31)
        Me.dateFactura.Name = "dateFactura"
        Me.dateFactura.Size = New System.Drawing.Size(202, 27)
        Me.dateFactura.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.rbContado)
        Me.Panel4.Controls.Add(Me.rbCredito)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Location = New System.Drawing.Point(810, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(320, 64)
        Me.Panel4.TabIndex = 16
        '
        'rbContado
        '
        Me.rbContado.AutoSize = True
        Me.rbContado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbContado.Location = New System.Drawing.Point(30, 33)
        Me.rbContado.Name = "rbContado"
        Me.rbContado.Size = New System.Drawing.Size(93, 23)
        Me.rbContado.TabIndex = 0
        Me.rbContado.TabStop = True
        Me.rbContado.Text = "Contado"
        Me.rbContado.UseVisualStyleBackColor = True
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCredito.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbCredito.Location = New System.Drawing.Point(185, 32)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(83, 23)
        Me.rbCredito.TabIndex = 1
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "Crédito"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(101, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 19)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Tipo de Pago"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(525, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS VENTA"
        '
        'pnlSeleccionProd
        '
        Me.pnlSeleccionProd.Controls.Add(Me.btnCancelarSeleccion)
        Me.pnlSeleccionProd.Controls.Add(Me.btnSeleccionarPr)
        Me.pnlSeleccionProd.Location = New System.Drawing.Point(408, 622)
        Me.pnlSeleccionProd.Name = "pnlSeleccionProd"
        Me.pnlSeleccionProd.Size = New System.Drawing.Size(370, 70)
        Me.pnlSeleccionProd.TabIndex = 19
        Me.pnlSeleccionProd.Visible = False
        '
        'btnCancelarSeleccion
        '
        Me.btnCancelarSeleccion.Location = New System.Drawing.Point(208, 16)
        Me.btnCancelarSeleccion.Name = "btnCancelarSeleccion"
        Me.btnCancelarSeleccion.Size = New System.Drawing.Size(129, 41)
        Me.btnCancelarSeleccion.TabIndex = 7
        Me.btnCancelarSeleccion.Text = "Cancelar"
        Me.btnCancelarSeleccion.UseVisualStyleBackColor = True
        '
        'btnSeleccionarPr
        '
        Me.btnSeleccionarPr.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarPr.Location = New System.Drawing.Point(45, 16)
        Me.btnSeleccionarPr.Name = "btnSeleccionarPr"
        Me.btnSeleccionarPr.Size = New System.Drawing.Size(129, 41)
        Me.btnSeleccionarPr.TabIndex = 6
        Me.btnSeleccionarPr.Text = "Seleccionar"
        Me.btnSeleccionarPr.UseVisualStyleBackColor = True
        '
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.Button4)
        Me.pnlOperadores.Controls.Add(Me.btnGuardarVenta)
        Me.pnlOperadores.Location = New System.Drawing.Point(32, 766)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(370, 70)
        Me.pnlOperadores.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(215, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 41)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnGuardarVenta
        '
        Me.btnGuardarVenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarVenta.Location = New System.Drawing.Point(38, 21)
        Me.btnGuardarVenta.Name = "btnGuardarVenta"
        Me.btnGuardarVenta.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarVenta.TabIndex = 6
        Me.btnGuardarVenta.Text = "Guardar"
        Me.btnGuardarVenta.UseVisualStyleBackColor = True
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
        Me.pnlTotales.Controls.Add(Me.txtTotalVenta)
        Me.pnlTotales.Controls.Add(Me.Label10)
        Me.pnlTotales.Controls.Add(Me.txtIva)
        Me.pnlTotales.Controls.Add(Me.Label12)
        Me.pnlTotales.Controls.Add(Me.txtSub)
        Me.pnlTotales.Location = New System.Drawing.Point(577, 622)
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
        'txtTotalVenta
        '
        Me.txtTotalVenta.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.Location = New System.Drawing.Point(158, 161)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.ReadOnly = True
        Me.txtTotalVenta.Size = New System.Drawing.Size(193, 30)
        Me.txtTotalVenta.TabIndex = 12
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvProductos.Location = New System.Drawing.Point(6, 385)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1199, 208)
        Me.dgvProductos.TabIndex = 4
        '
        'tpAnularVenta
        '
        Me.tpAnularVenta.BackColor = System.Drawing.Color.SteelBlue
        Me.tpAnularVenta.Controls.Add(Me.pnlComentarioAnular)
        Me.tpAnularVenta.Controls.Add(Me.pnlOperandosAnular)
        Me.tpAnularVenta.Controls.Add(Me.dgvVentasAnular)
        Me.tpAnularVenta.Controls.Add(Me.txtTituloAnular)
        Me.tpAnularVenta.Controls.Add(Me.pnlAnular)
        Me.tpAnularVenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpAnularVenta.Location = New System.Drawing.Point(4, 29)
        Me.tpAnularVenta.Name = "tpAnularVenta"
        Me.tpAnularVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAnularVenta.Size = New System.Drawing.Size(1301, 709)
        Me.tpAnularVenta.TabIndex = 2
        Me.tpAnularVenta.Text = "Anular Venta"
        '
        'pnlComentarioAnular
        '
        Me.pnlComentarioAnular.Controls.Add(Me.txtComentAnular)
        Me.pnlComentarioAnular.Controls.Add(Me.Label31)
        Me.pnlComentarioAnular.Enabled = False
        Me.pnlComentarioAnular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlComentarioAnular.Location = New System.Drawing.Point(53, 210)
        Me.pnlComentarioAnular.Name = "pnlComentarioAnular"
        Me.pnlComentarioAnular.Size = New System.Drawing.Size(398, 108)
        Me.pnlComentarioAnular.TabIndex = 5
        '
        'txtComentAnular
        '
        Me.txtComentAnular.Location = New System.Drawing.Point(12, 31)
        Me.txtComentAnular.Name = "txtComentAnular"
        Me.txtComentAnular.Size = New System.Drawing.Size(370, 67)
        Me.txtComentAnular.TabIndex = 0
        Me.txtComentAnular.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label31.Location = New System.Drawing.Point(8, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 19)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Comentario"
        '
        'pnlOperandosAnular
        '
        Me.pnlOperandosAnular.Controls.Add(Me.btnAnularVenta)
        Me.pnlOperandosAnular.Controls.Add(Me.btnVerDetalleAnul)
        Me.pnlOperandosAnular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOperandosAnular.Location = New System.Drawing.Point(538, 210)
        Me.pnlOperandosAnular.Name = "pnlOperandosAnular"
        Me.pnlOperandosAnular.Size = New System.Drawing.Size(398, 108)
        Me.pnlOperandosAnular.TabIndex = 4
        '
        'btnAnularVenta
        '
        Me.btnAnularVenta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularVenta.Location = New System.Drawing.Point(205, 46)
        Me.btnAnularVenta.Name = "btnAnularVenta"
        Me.btnAnularVenta.Size = New System.Drawing.Size(164, 34)
        Me.btnAnularVenta.TabIndex = 1
        Me.btnAnularVenta.Text = "Anular Factura"
        Me.btnAnularVenta.UseVisualStyleBackColor = True
        '
        'btnVerDetalleAnul
        '
        Me.btnVerDetalleAnul.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleAnul.Location = New System.Drawing.Point(33, 46)
        Me.btnVerDetalleAnul.Name = "btnVerDetalleAnul"
        Me.btnVerDetalleAnul.Size = New System.Drawing.Size(132, 35)
        Me.btnVerDetalleAnul.TabIndex = 0
        Me.btnVerDetalleAnul.Text = "Ver Detalle"
        Me.btnVerDetalleAnul.UseVisualStyleBackColor = True
        '
        'dgvVentasAnular
        '
        Me.dgvVentasAnular.AllowUserToAddRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray
        Me.dgvVentasAnular.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvVentasAnular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentasAnular.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvVentasAnular.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvVentasAnular.Location = New System.Drawing.Point(53, 324)
        Me.dgvVentasAnular.MultiSelect = False
        Me.dgvVentasAnular.Name = "dgvVentasAnular"
        Me.dgvVentasAnular.ReadOnly = True
        Me.dgvVentasAnular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentasAnular.Size = New System.Drawing.Size(942, 218)
        Me.dgvVentasAnular.TabIndex = 3
        Me.dgvVentasAnular.Visible = False
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
        Me.pnlAnular.Controls.Add(Me.txtClienteAnular)
        Me.pnlAnular.Controls.Add(Me.txtHastaAnul)
        Me.pnlAnular.Controls.Add(Me.txtFiltro)
        Me.pnlAnular.Controls.Add(Me.btnBuscarAnular)
        Me.pnlAnular.Controls.Add(Me.dpAnularVentaFin)
        Me.pnlAnular.Controls.Add(Me.dpAnularVentaIni)
        Me.pnlAnular.Controls.Add(Me.Label21)
        Me.pnlAnular.Controls.Add(Me.txtNrofacturaAnul)
        Me.pnlAnular.Controls.Add(Me.cbAnularFiltro)
        Me.pnlAnular.Location = New System.Drawing.Point(115, 84)
        Me.pnlAnular.Name = "pnlAnular"
        Me.pnlAnular.Size = New System.Drawing.Size(821, 155)
        Me.pnlAnular.TabIndex = 0
        '
        'txtClienteAnular
        '
        Me.txtClienteAnular.Location = New System.Drawing.Point(146, 126)
        Me.txtClienteAnular.Name = "txtClienteAnular"
        Me.txtClienteAnular.Size = New System.Drawing.Size(227, 26)
        Me.txtClienteAnular.TabIndex = 8
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
        Me.tpCobros.Controls.Add(Me.dgvVentasCobro)
        Me.tpCobros.Controls.Add(Me.lblTituloVenta)
        Me.tpCobros.Controls.Add(Me.pnlCobro)
        Me.tpCobros.Location = New System.Drawing.Point(4, 29)
        Me.tpCobros.Name = "tpCobros"
        Me.tpCobros.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCobros.Size = New System.Drawing.Size(1301, 709)
        Me.tpCobros.TabIndex = 3
        Me.tpCobros.Text = "Cobros"
        '
        'dgvVentasCobro
        '
        Me.dgvVentasCobro.AllowUserToAddRows = False
        Me.dgvVentasCobro.AllowUserToDeleteRows = False
        Me.dgvVentasCobro.AllowUserToOrderColumns = True
        Me.dgvVentasCobro.AllowUserToResizeColumns = False
        Me.dgvVentasCobro.AllowUserToResizeRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvVentasCobro.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvVentasCobro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasCobro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvVentasCobro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVentasCobro.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvVentasCobro.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvVentasCobro.Location = New System.Drawing.Point(42, 317)
        Me.dgvVentasCobro.Name = "dgvVentasCobro"
        Me.dgvVentasCobro.ReadOnly = True
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasCobro.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvVentasCobro.RowHeadersVisible = False
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvVentasCobro.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvVentasCobro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentasCobro.Size = New System.Drawing.Size(910, 308)
        Me.dgvVentasCobro.TabIndex = 37
        Me.dgvVentasCobro.Visible = False
        '
        'lblTituloVenta
        '
        Me.lblTituloVenta.AutoSize = True
        Me.lblTituloVenta.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVenta.Location = New System.Drawing.Point(372, 38)
        Me.lblTituloVenta.Name = "lblTituloVenta"
        Me.lblTituloVenta.Size = New System.Drawing.Size(291, 32)
        Me.lblTituloVenta.TabIndex = 6
        Me.lblTituloVenta.Text = "COBROS DE VENTAS"
        '
        'pnlCobro
        '
        Me.pnlCobro.Controls.Add(Me.txtClienteCobro)
        Me.pnlCobro.Controls.Add(Me.btnDetalleCobro)
        Me.pnlCobro.Controls.Add(Me.btnPagar)
        Me.pnlCobro.Controls.Add(Me.btnBuscarCobro)
        Me.pnlCobro.Controls.Add(Me.lblFiltroTipo)
        Me.pnlCobro.Controls.Add(Me.Label25)
        Me.pnlCobro.Controls.Add(Me.txtNroFactCobro)
        Me.pnlCobro.Controls.Add(Me.cbFiltroCobro)
        Me.pnlCobro.Controls.Add(Me.pnlFechas)
        Me.pnlCobro.Location = New System.Drawing.Point(42, 83)
        Me.pnlCobro.Name = "pnlCobro"
        Me.pnlCobro.Size = New System.Drawing.Size(910, 188)
        Me.pnlCobro.TabIndex = 5
        '
        'txtClienteCobro
        '
        Me.txtClienteCobro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCobro.Location = New System.Drawing.Point(637, 27)
        Me.txtClienteCobro.Name = "txtClienteCobro"
        Me.txtClienteCobro.Size = New System.Drawing.Size(228, 26)
        Me.txtClienteCobro.TabIndex = 12
        Me.txtClienteCobro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDetalleCobro
        '
        Me.btnDetalleCobro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleCobro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDetalleCobro.Location = New System.Drawing.Point(231, 132)
        Me.btnDetalleCobro.Name = "btnDetalleCobro"
        Me.btnDetalleCobro.Size = New System.Drawing.Size(131, 29)
        Me.btnDetalleCobro.TabIndex = 11
        Me.btnDetalleCobro.Text = "Ver Detalle"
        Me.btnDetalleCobro.UseVisualStyleBackColor = True
        Me.btnDetalleCobro.Visible = False
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPagar.Location = New System.Drawing.Point(736, 74)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(142, 52)
        Me.btnPagar.TabIndex = 3
        Me.btnPagar.Text = "Realizar Pago"
        Me.btnPagar.UseVisualStyleBackColor = True
        Me.btnPagar.Visible = False
        '
        'btnBuscarCobro
        '
        Me.btnBuscarCobro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCobro.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscarCobro.Location = New System.Drawing.Point(51, 132)
        Me.btnBuscarCobro.Name = "btnBuscarCobro"
        Me.btnBuscarCobro.Size = New System.Drawing.Size(135, 29)
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
        Me.lblFiltroTipo.Location = New System.Drawing.Point(398, 24)
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
        'txtNroFactCobro
        '
        Me.txtNroFactCobro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFactCobro.Location = New System.Drawing.Point(401, 58)
        Me.txtNroFactCobro.Name = "txtNroFactCobro"
        Me.txtNroFactCobro.Size = New System.Drawing.Size(262, 26)
        Me.txtNroFactCobro.TabIndex = 8
        '
        'cbFiltroCobro
        '
        Me.cbFiltroCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltroCobro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltroCobro.FormattingEnabled = True
        Me.cbFiltroCobro.Location = New System.Drawing.Point(178, 57)
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
        Me.pnlFechas.Location = New System.Drawing.Point(389, 13)
        Me.pnlFechas.Name = "pnlFechas"
        Me.pnlFechas.Size = New System.Drawing.Size(308, 159)
        Me.pnlFechas.TabIndex = 7
        Me.pnlFechas.Visible = False
        '
        'dpHastaPago
        '
        Me.dpHastaPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpHastaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpHastaPago.Location = New System.Drawing.Point(12, 121)
        Me.dpHastaPago.Name = "dpHastaPago"
        Me.dpHastaPago.Size = New System.Drawing.Size(223, 27)
        Me.dpHastaPago.TabIndex = 0
        '
        'dpDesdePago
        '
        Me.dpDesdePago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDesdePago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDesdePago.Location = New System.Drawing.Point(12, 44)
        Me.dpDesdePago.Name = "dpDesdePago"
        Me.dpDesdePago.Size = New System.Drawing.Size(221, 27)
        Me.dpDesdePago.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(9, 86)
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
        Me.Label24.Location = New System.Drawing.Point(9, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 27)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Desde"
        '
        'AdministrarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 742)
        Me.Controls.Add(Me.tbcVenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdministrarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdministrarVentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbcVenta.ResumeLayout(False)
        Me.tpListado.ResumeLayout(False)
        Me.tpListado.PerformLayout()
        CType(Me.dgvVentasListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlListado.ResumeLayout(False)
        Me.pnlListado.PerformLayout()
        Me.pnlRangoFecha.ResumeLayout(False)
        Me.pnlRangoFecha.PerformLayout()
        Me.tpNuevaVenta.ResumeLayout(False)
        Me.pnlDescuento.ResumeLayout(False)
        Me.pnlDescuento.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatosProducto.ResumeLayout(False)
        Me.pnlDatosProducto.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlDatosVenta.ResumeLayout(False)
        Me.pnlDatosVenta.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlSeleccionProd.ResumeLayout(False)
        Me.pnlOperadores.ResumeLayout(False)
        Me.pnlComentario.ResumeLayout(False)
        Me.pnlComentario.PerformLayout()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAnularVenta.ResumeLayout(False)
        Me.tpAnularVenta.PerformLayout()
        Me.pnlComentarioAnular.ResumeLayout(False)
        Me.pnlComentarioAnular.PerformLayout()
        Me.pnlOperandosAnular.ResumeLayout(False)
        CType(Me.dgvVentasAnular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAnular.ResumeLayout(False)
        Me.pnlAnular.PerformLayout()
        Me.tpCobros.ResumeLayout(False)
        Me.tpCobros.PerformLayout()
        CType(Me.dgvVentasCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCobro.ResumeLayout(False)
        Me.pnlCobro.PerformLayout()
        Me.pnlFechas.ResumeLayout(False)
        Me.pnlFechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcVenta As TabControl
    Friend WithEvents tpListado As TabPage
    Friend WithEvents dgvVentasListado As DataGridView
    Friend WithEvents pnlListado As Panel
    Friend WithEvents txtNroFacturaListado As TextBox
    Friend WithEvents cbEstadoCompra As ComboBox
    Friend WithEvents btnDetalle As Button
    Friend WithEvents btnBuscarCompra As Button
    Friend WithEvents lblBusqTxt As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbBuscarVentaListado As ComboBox
    Friend WithEvents pnlRangoFecha As Panel
    Friend WithEvents datepFin As DateTimePicker
    Friend WithEvents datepInicio As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTituloBusquedaList As Label
    Friend WithEvents tpNuevaVenta As TabPage
    Friend WithEvents dgvBusquedaResult As DataGridView
    Friend WithEvents pnlDatosProducto As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents cbImpuesto As ComboBox
    Friend WithEvents cbDeposito As ComboBox
    Friend WithEvents btnBuscarProd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsertarProd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminarProd As Button
    Friend WithEvents txtFiltroBusquedaNC As TextBox
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtDescripcionProd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrecioProd As TextBox
    Friend WithEvents pnlDatosVenta As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents rbCredito As RadioButton
    Friend WithEvents rbContado As RadioButton
    Friend WithEvents dateFactura As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFacturaNro As TextBox
    Friend WithEvents pnlSeleccionProd As Panel
    Friend WithEvents btnSeleccionarPr As Button
    Friend WithEvents pnlOperadores As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnGuardarVenta As Button
    Friend WithEvents pnlComentario As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents txtComentario As RichTextBox
    Friend WithEvents pnlTotales As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSub As TextBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents tpAnularVenta As TabPage
    Friend WithEvents pnlOperandosAnular As Panel
    Friend WithEvents btnAnularVenta As Button
    Friend WithEvents btnVerDetalleAnul As Button
    Friend WithEvents dgvVentasAnular As DataGridView
    Friend WithEvents txtTituloAnular As Label
    Friend WithEvents pnlAnular As Panel
    Friend WithEvents txtHastaAnul As Label
    Friend WithEvents txtFiltro As Label
    Friend WithEvents btnBuscarAnular As Button
    Friend WithEvents dpAnularVentaFin As DateTimePicker
    Friend WithEvents dpAnularVentaIni As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNrofacturaAnul As TextBox
    Friend WithEvents cbAnularFiltro As ComboBox
    Friend WithEvents tpCobros As TabPage
    Friend WithEvents dgvVentasCobro As DataGridView
    Friend WithEvents lblTituloVenta As Label
    Friend WithEvents pnlCobro As Panel
    Friend WithEvents btnDetalleCobro As Button
    Friend WithEvents btnPagar As Button
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
    Friend WithEvents cbVendedor2 As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnCancelarSeleccion As Button
    Friend WithEvents txtNombreCli As TextBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtM2 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtClienteRucListado As TextBox
    Friend WithEvents txtClienteCobro As TextBox
    Friend WithEvents pnlDescuento As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents btnDeschacerDesc As Button
    Friend WithEvents btnAplicarDesc As Button
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtClienteAnular As TextBox
    Friend WithEvents pnlComentarioAnular As Panel
    Friend WithEvents txtComentAnular As RichTextBox
    Friend WithEvents Label31 As Label
End Class
