Imports BackEnd

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerarCompras
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbcCompra = New System.Windows.Forms.TabControl()
        Me.tpListado = New System.Windows.Forms.TabPage()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.gbBusquedaCompra = New System.Windows.Forms.GroupBox()
        Me.cbEstadoCompra = New System.Windows.Forms.ComboBox()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.lblBusqTxt = New System.Windows.Forms.Label()
        Me.cbProveedor1 = New System.Windows.Forms.ComboBox()
        Me.txtNroFacturaListado = New System.Windows.Forms.TextBox()
        Me.pnlRangoFecha = New System.Windows.Forms.Panel()
        Me.datepFin = New System.Windows.Forms.DateTimePicker()
        Me.datepInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbBuscarCompra = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBuscarCompra = New System.Windows.Forms.Button()
        Me.txtTituloBusqueda = New System.Windows.Forms.Label()
        Me.tpNuevaCompra = New System.Windows.Forms.TabPage()
        Me.pnlDatosProducto = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbImpuesto = New System.Windows.Forms.ComboBox()
        Me.cbDeposito = New System.Windows.Forms.ComboBox()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnInsertarProd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.gbProveedor = New System.Windows.Forms.GroupBox()
        Me.cbProveedor2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
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
        Me.tpAnularCompra = New System.Windows.Forms.TabPage()
        Me.pnlOperandosAnular = New System.Windows.Forms.Panel()
        Me.btnAnularCompra = New System.Windows.Forms.Button()
        Me.btnVerDetalleAnul = New System.Windows.Forms.Button()
        Me.dgvComprasAnular = New System.Windows.Forms.DataGridView()
        Me.txtTituloAnular = New System.Windows.Forms.Label()
        Me.pnlAnular = New System.Windows.Forms.Panel()
        Me.txtHastaAnul = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.Label()
        Me.btnBuscarAnular = New System.Windows.Forms.Button()
        Me.dpAnularCompraFin = New System.Windows.Forms.DateTimePicker()
        Me.dpAnularCompraIni = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNrofacturaAnul = New System.Windows.Forms.TextBox()
        Me.cbProveedor3 = New System.Windows.Forms.ComboBox()
        Me.cbAnularFiltro = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ttCompra = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbcCompra.SuspendLayout()
        Me.tpListado.SuspendLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBusquedaCompra.SuspendLayout()
        Me.pnlRangoFecha.SuspendLayout()
        Me.tpNuevaCompra.SuspendLayout()
        Me.pnlDatosProducto.SuspendLayout()
        Me.pnlDatosCompra.SuspendLayout()
        Me.gbTipoPago.SuspendLayout()
        Me.gbProveedor.SuspendLayout()
        Me.pnlOperadores.SuspendLayout()
        Me.pnlComentario.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAnularCompra.SuspendLayout()
        Me.pnlOperandosAnular.SuspendLayout()
        CType(Me.dgvComprasAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAnular.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcCompra
        '
        Me.tbcCompra.Controls.Add(Me.tpListado)
        Me.tbcCompra.Controls.Add(Me.tpNuevaCompra)
        Me.tbcCompra.Controls.Add(Me.tpAnularCompra)
        Me.tbcCompra.Controls.Add(Me.TabPage1)
        Me.tbcCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcCompra.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcCompra.Location = New System.Drawing.Point(0, 0)
        Me.tbcCompra.Margin = New System.Windows.Forms.Padding(0)
        Me.tbcCompra.Name = "tbcCompra"
        Me.tbcCompra.Padding = New System.Drawing.Point(10, 8)
        Me.tbcCompra.SelectedIndex = 0
        Me.tbcCompra.Size = New System.Drawing.Size(1120, 742)
        Me.tbcCompra.TabIndex = 3
        '
        'tpListado
        '
        Me.tpListado.BackColor = System.Drawing.Color.SteelBlue
        Me.tpListado.Controls.Add(Me.dgvCompras)
        Me.tpListado.Controls.Add(Me.gbBusquedaCompra)
        Me.tpListado.Controls.Add(Me.txtTituloBusqueda)
        Me.tpListado.Location = New System.Drawing.Point(4, 38)
        Me.tpListado.Name = "tpListado"
        Me.tpListado.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListado.Size = New System.Drawing.Size(1112, 700)
        Me.tpListado.TabIndex = 0
        Me.tpListado.Text = "Listado"
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.dgvCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Location = New System.Drawing.Point(51, 298)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.ReadOnly = True
        Me.dgvCompras.RowHeadersVisible = False
        Me.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompras.Size = New System.Drawing.Size(910, 304)
        Me.dgvCompras.TabIndex = 4
        '
        'gbBusquedaCompra
        '
        Me.gbBusquedaCompra.BackColor = System.Drawing.Color.Transparent
        Me.gbBusquedaCompra.Controls.Add(Me.cbEstadoCompra)
        Me.gbBusquedaCompra.Controls.Add(Me.btnDetalle)
        Me.gbBusquedaCompra.Controls.Add(Me.lblBusqTxt)
        Me.gbBusquedaCompra.Controls.Add(Me.cbProveedor1)
        Me.gbBusquedaCompra.Controls.Add(Me.txtNroFacturaListado)
        Me.gbBusquedaCompra.Controls.Add(Me.pnlRangoFecha)
        Me.gbBusquedaCompra.Controls.Add(Me.cbBuscarCompra)
        Me.gbBusquedaCompra.Controls.Add(Me.Label15)
        Me.gbBusquedaCompra.Controls.Add(Me.btnBuscarCompra)
        Me.gbBusquedaCompra.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBusquedaCompra.ForeColor = System.Drawing.SystemColors.Control
        Me.gbBusquedaCompra.Location = New System.Drawing.Point(51, 88)
        Me.gbBusquedaCompra.Name = "gbBusquedaCompra"
        Me.gbBusquedaCompra.Size = New System.Drawing.Size(910, 174)
        Me.gbBusquedaCompra.TabIndex = 3
        Me.gbBusquedaCompra.TabStop = False
        Me.gbBusquedaCompra.Text = "Rango de Compra"
        '
        'cbEstadoCompra
        '
        Me.cbEstadoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCompra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCompra.FormattingEnabled = True
        Me.cbEstadoCompra.Location = New System.Drawing.Point(30, 107)
        Me.cbEstadoCompra.Name = "cbEstadoCompra"
        Me.cbEstadoCompra.Size = New System.Drawing.Size(217, 26)
        Me.cbEstadoCompra.TabIndex = 12
        Me.cbEstadoCompra.Visible = False
        '
        'btnDetalle
        '
        Me.btnDetalle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDetalle.Location = New System.Drawing.Point(619, 117)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(111, 30)
        Me.btnDetalle.TabIndex = 11
        Me.btnDetalle.Text = "Ver Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = True
        Me.btnDetalle.Visible = False
        '
        'lblBusqTxt
        '
        Me.lblBusqTxt.AutoSize = True
        Me.lblBusqTxt.BackColor = System.Drawing.Color.Transparent
        Me.lblBusqTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBusqTxt.Location = New System.Drawing.Point(378, 14)
        Me.lblBusqTxt.Name = "lblBusqTxt"
        Me.lblBusqTxt.Size = New System.Drawing.Size(203, 23)
        Me.lblBusqTxt.TabIndex = 10
        Me.lblBusqTxt.Text = "Inserte Nro. Factura"
        '
        'cbProveedor1
        '
        Me.cbProveedor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor1.FormattingEnabled = True
        Me.cbProveedor1.Location = New System.Drawing.Point(379, 47)
        Me.cbProveedor1.Name = "cbProveedor1"
        Me.cbProveedor1.Size = New System.Drawing.Size(262, 26)
        Me.cbProveedor1.TabIndex = 9
        Me.cbProveedor1.Visible = False
        '
        'txtNroFacturaListado
        '
        Me.txtNroFacturaListado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFacturaListado.Location = New System.Drawing.Point(379, 44)
        Me.txtNroFacturaListado.Name = "txtNroFacturaListado"
        Me.txtNroFacturaListado.Size = New System.Drawing.Size(262, 26)
        Me.txtNroFacturaListado.TabIndex = 8
        '
        'pnlRangoFecha
        '
        Me.pnlRangoFecha.BackColor = System.Drawing.Color.Transparent
        Me.pnlRangoFecha.Controls.Add(Me.datepFin)
        Me.pnlRangoFecha.Controls.Add(Me.datepInicio)
        Me.pnlRangoFecha.Controls.Add(Me.Label14)
        Me.pnlRangoFecha.Controls.Add(Me.Label13)
        Me.pnlRangoFecha.Location = New System.Drawing.Point(369, -1)
        Me.pnlRangoFecha.Name = "pnlRangoFecha"
        Me.pnlRangoFecha.Size = New System.Drawing.Size(494, 100)
        Me.pnlRangoFecha.TabIndex = 7
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
        'cbBuscarCompra
        '
        Me.cbBuscarCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscarCompra.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarCompra.FormattingEnabled = True
        Me.cbBuscarCompra.Location = New System.Drawing.Point(158, 43)
        Me.cbBuscarCompra.Name = "cbBuscarCompra"
        Me.cbBuscarCompra.Size = New System.Drawing.Size(184, 27)
        Me.cbBuscarCompra.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(26, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 27)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Buscar por"
        '
        'btnBuscarCompra
        '
        Me.btnBuscarCompra.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCompra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscarCompra.Location = New System.Drawing.Point(736, 118)
        Me.btnBuscarCompra.Name = "btnBuscarCompra"
        Me.btnBuscarCompra.Size = New System.Drawing.Size(108, 29)
        Me.btnBuscarCompra.TabIndex = 3
        Me.btnBuscarCompra.Text = "Buscar"
        Me.btnBuscarCompra.UseVisualStyleBackColor = True
        '
        'txtTituloBusqueda
        '
        Me.txtTituloBusqueda.AutoSize = True
        Me.txtTituloBusqueda.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTituloBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTituloBusqueda.Location = New System.Drawing.Point(375, 28)
        Me.txtTituloBusqueda.Name = "txtTituloBusqueda"
        Me.txtTituloBusqueda.Size = New System.Drawing.Size(326, 36)
        Me.txtTituloBusqueda.TabIndex = 1
        Me.txtTituloBusqueda.Text = "Listado de Compras"
        '
        'tpNuevaCompra
        '
        Me.tpNuevaCompra.AutoScroll = True
        Me.tpNuevaCompra.BackColor = System.Drawing.Color.SteelBlue
        Me.tpNuevaCompra.Controls.Add(Me.pnlDatosProducto)
        Me.tpNuevaCompra.Controls.Add(Me.pnlDatosCompra)
        Me.tpNuevaCompra.Controls.Add(Me.pnlOperadores)
        Me.tpNuevaCompra.Controls.Add(Me.pnlComentario)
        Me.tpNuevaCompra.Controls.Add(Me.pnlTotales)
        Me.tpNuevaCompra.Controls.Add(Me.dgvProductos)
        Me.tpNuevaCompra.Location = New System.Drawing.Point(4, 38)
        Me.tpNuevaCompra.Name = "tpNuevaCompra"
        Me.tpNuevaCompra.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNuevaCompra.Size = New System.Drawing.Size(1112, 700)
        Me.tpNuevaCompra.TabIndex = 1
        Me.tpNuevaCompra.Text = "Nueva Compra"
        '
        'pnlDatosProducto
        '
        Me.pnlDatosProducto.Controls.Add(Me.Label19)
        Me.pnlDatosProducto.Controls.Add(Me.cbImpuesto)
        Me.pnlDatosProducto.Controls.Add(Me.cbDeposito)
        Me.pnlDatosProducto.Controls.Add(Me.btnBuscarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label4)
        Me.pnlDatosProducto.Controls.Add(Me.btnInsertarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label9)
        Me.pnlDatosProducto.Controls.Add(Me.btnEliminarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label8)
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
        Me.ttCompra.SetToolTip(Me.btnBuscarProd, "Buscar Producto por código")
        Me.btnBuscarProd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(23, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Código"
        '
        'btnInsertarProd
        '
        Me.btnInsertarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProd.Location = New System.Drawing.Point(957, 34)
        Me.btnInsertarProd.Name = "btnInsertarProd"
        Me.btnInsertarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnInsertarProd.TabIndex = 2
        Me.btnInsertarProd.Text = "+"
        Me.ttCompra.SetToolTip(Me.btnInsertarProd, "Agregar Producto")
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
        Me.ttCompra.SetToolTip(Me.btnEliminarProd, "Quitar Producto")
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
        'txtCodProd
        '
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(92, 39)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(127, 27)
        Me.txtCodProd.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(284, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(693, 40)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(177, 27)
        Me.txtCantidad.TabIndex = 5
        '
        'txtDescripcionProd
        '
        Me.txtDescripcionProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProd.Location = New System.Drawing.Point(392, 39)
        Me.txtDescripcionProd.Name = "txtDescripcionProd"
        Me.txtDescripcionProd.Size = New System.Drawing.Size(195, 27)
        Me.txtDescripcionProd.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(605, 43)
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
        Me.Label7.Location = New System.Drawing.Point(605, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio"
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProd.Location = New System.Drawing.Point(692, 82)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(178, 27)
        Me.txtPrecioProd.TabIndex = 5
        '
        'pnlDatosCompra
        '
        Me.pnlDatosCompra.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosCompra.Controls.Add(Me.Label18)
        Me.pnlDatosCompra.Controls.Add(Me.gbTipoPago)
        Me.pnlDatosCompra.Controls.Add(Me.dateFactura)
        Me.pnlDatosCompra.Controls.Add(Me.gbProveedor)
        Me.pnlDatosCompra.Controls.Add(Me.Label3)
        Me.pnlDatosCompra.Controls.Add(Me.Label2)
        Me.pnlDatosCompra.Controls.Add(Me.txtFacturaNro)
        Me.pnlDatosCompra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosCompra.Location = New System.Drawing.Point(32, 30)
        Me.pnlDatosCompra.Name = "pnlDatosCompra"
        Me.pnlDatosCompra.Size = New System.Drawing.Size(1046, 146)
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
        Me.Label18.Size = New System.Drawing.Size(166, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS COMPRA"
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
        Me.gbTipoPago.Location = New System.Drawing.Point(725, 17)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(307, 67)
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
        Me.rbCredito.Location = New System.Drawing.Point(163, 28)
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
        'gbProveedor
        '
        Me.gbProveedor.BackColor = System.Drawing.Color.Transparent
        Me.gbProveedor.Controls.Add(Me.Label11)
        Me.gbProveedor.Controls.Add(Me.cbProveedor2)
        Me.gbProveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbProveedor.Location = New System.Drawing.Point(336, 17)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(379, 67)
        Me.gbProveedor.TabIndex = 8
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Proveedor"
        '
        'cbProveedor2
        '
        Me.cbProveedor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor2.FormattingEnabled = True
        Me.cbProveedor2.Location = New System.Drawing.Point(179, 29)
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
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.Button4)
        Me.pnlOperadores.Controls.Add(Me.btnGuardarCompra)
        Me.pnlOperadores.Location = New System.Drawing.Point(611, 864)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(385, 70)
        Me.pnlOperadores.TabIndex = 19
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(222, 29)
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
        Me.pnlComentario.Size = New System.Drawing.Size(402, 227)
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
        Me.txtComentario.Size = New System.Drawing.Size(359, 183)
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
        Me.pnlTotales.Location = New System.Drawing.Point(611, 622)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.Location = New System.Drawing.Point(32, 385)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1046, 208)
        Me.dgvProductos.TabIndex = 4
        '
        'tpAnularCompra
        '
        Me.tpAnularCompra.BackColor = System.Drawing.Color.SteelBlue
        Me.tpAnularCompra.Controls.Add(Me.pnlOperandosAnular)
        Me.tpAnularCompra.Controls.Add(Me.dgvComprasAnular)
        Me.tpAnularCompra.Controls.Add(Me.txtTituloAnular)
        Me.tpAnularCompra.Controls.Add(Me.pnlAnular)
        Me.tpAnularCompra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpAnularCompra.Location = New System.Drawing.Point(4, 38)
        Me.tpAnularCompra.Name = "tpAnularCompra"
        Me.tpAnularCompra.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAnularCompra.Size = New System.Drawing.Size(1112, 900)
        Me.tpAnularCompra.TabIndex = 2
        Me.tpAnularCompra.Text = "Anular Compra"
        '
        'pnlOperandosAnular
        '
        Me.pnlOperandosAnular.Controls.Add(Me.btnAnularCompra)
        Me.pnlOperandosAnular.Controls.Add(Me.btnVerDetalleAnul)
        Me.pnlOperandosAnular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOperandosAnular.Location = New System.Drawing.Point(538, 242)
        Me.pnlOperandosAnular.Name = "pnlOperandosAnular"
        Me.pnlOperandosAnular.Size = New System.Drawing.Size(398, 76)
        Me.pnlOperandosAnular.TabIndex = 4
        '
        'btnAnularCompra
        '
        Me.btnAnularCompra.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnularCompra.Location = New System.Drawing.Point(205, 23)
        Me.btnAnularCompra.Name = "btnAnularCompra"
        Me.btnAnularCompra.Size = New System.Drawing.Size(164, 34)
        Me.btnAnularCompra.TabIndex = 1
        Me.btnAnularCompra.Text = "Anular Factura"
        Me.btnAnularCompra.UseVisualStyleBackColor = True
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
        Me.txtTituloAnular.Size = New System.Drawing.Size(245, 36)
        Me.txtTituloAnular.TabIndex = 2
        Me.txtTituloAnular.Text = "Anular Compra"
        '
        'pnlAnular
        '
        Me.pnlAnular.Controls.Add(Me.txtHastaAnul)
        Me.pnlAnular.Controls.Add(Me.txtFiltro)
        Me.pnlAnular.Controls.Add(Me.btnBuscarAnular)
        Me.pnlAnular.Controls.Add(Me.dpAnularCompraFin)
        Me.pnlAnular.Controls.Add(Me.dpAnularCompraIni)
        Me.pnlAnular.Controls.Add(Me.Label21)
        Me.pnlAnular.Controls.Add(Me.txtNrofacturaAnul)
        Me.pnlAnular.Controls.Add(Me.cbProveedor3)
        Me.pnlAnular.Controls.Add(Me.cbAnularFiltro)
        Me.pnlAnular.Location = New System.Drawing.Point(115, 144)
        Me.pnlAnular.Name = "pnlAnular"
        Me.pnlAnular.Size = New System.Drawing.Size(821, 77)
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
        'dpAnularCompraFin
        '
        Me.dpAnularCompraFin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpAnularCompraFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpAnularCompraFin.Location = New System.Drawing.Point(397, 98)
        Me.dpAnularCompraFin.Name = "dpAnularCompraFin"
        Me.dpAnularCompraFin.Size = New System.Drawing.Size(200, 26)
        Me.dpAnularCompraFin.TabIndex = 5
        Me.dpAnularCompraFin.Visible = False
        '
        'dpAnularCompraIni
        '
        Me.dpAnularCompraIni.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpAnularCompraIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpAnularCompraIni.Location = New System.Drawing.Point(20, 88)
        Me.dpAnularCompraIni.Name = "dpAnularCompraIni"
        Me.dpAnularCompraIni.Size = New System.Drawing.Size(200, 26)
        Me.dpAnularCompraIni.TabIndex = 5
        Me.dpAnularCompraIni.Visible = False
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
        'cbProveedor3
        '
        Me.cbProveedor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor3.FormattingEnabled = True
        Me.cbProveedor3.Location = New System.Drawing.Point(173, 88)
        Me.cbProveedor3.Name = "cbProveedor3"
        Me.cbProveedor3.Size = New System.Drawing.Size(200, 26)
        Me.cbProveedor3.TabIndex = 3
        Me.cbProveedor3.Visible = False
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
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1112, 900)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Pagos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Proveedor"
        '
        'GenerarCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1120, 742)
        Me.Controls.Add(Me.tbcCompra)
        Me.Name = "GenerarCompras"
        Me.Text = "COMPRAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbcCompra.ResumeLayout(False)
        Me.tpListado.ResumeLayout(False)
        Me.tpListado.PerformLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBusquedaCompra.ResumeLayout(False)
        Me.gbBusquedaCompra.PerformLayout()
        Me.pnlRangoFecha.ResumeLayout(False)
        Me.pnlRangoFecha.PerformLayout()
        Me.tpNuevaCompra.ResumeLayout(False)
        Me.pnlDatosProducto.ResumeLayout(False)
        Me.pnlDatosProducto.PerformLayout()
        Me.pnlDatosCompra.ResumeLayout(False)
        Me.pnlDatosCompra.PerformLayout()
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        Me.pnlOperadores.ResumeLayout(False)
        Me.pnlComentario.ResumeLayout(False)
        Me.pnlComentario.PerformLayout()
        Me.pnlTotales.ResumeLayout(False)
        Me.pnlTotales.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAnularCompra.ResumeLayout(False)
        Me.tpAnularCompra.PerformLayout()
        Me.pnlOperandosAnular.ResumeLayout(False)
        CType(Me.dgvComprasAnular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAnular.ResumeLayout(False)
        Me.pnlAnular.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcCompra As System.Windows.Forms.TabControl
    Friend WithEvents tpListado As System.Windows.Forms.TabPage
    Friend WithEvents dgvCompras As System.Windows.Forms.DataGridView
    Friend WithEvents gbBusquedaCompra As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents datepFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents datepInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTituloBusqueda As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCompra As System.Windows.Forms.Button

    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CódigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ttCompra As ToolTip
    Friend WithEvents pnlRangoFecha As Panel
    Friend WithEvents cbBuscarCompra As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tpNuevaCompra As TabPage
    Friend WithEvents pnlDatosProducto As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents cbImpuesto As ComboBox
    Friend WithEvents cbDeposito As ComboBox
    Friend WithEvents btnBuscarProd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnInsertarProd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEliminarProd As Button
    Friend WithEvents Label8 As Label
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
    Friend WithEvents rbCredito As RadioButton
    Friend WithEvents rbContado As RadioButton
    Friend WithEvents dateFactura As DateTimePicker
    Friend WithEvents gbProveedor As GroupBox
    Friend WithEvents cbProveedor2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFacturaNro As TextBox
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
    Friend WithEvents txtNroFacturaListado As TextBox
    Friend WithEvents cbProveedor1 As ComboBox
    Friend WithEvents btnDetalle As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label20 As Label
    Friend WithEvents txtEntregaInicial As TextBox
    Friend WithEvents tpAnularCompra As TabPage
    Friend WithEvents dgvComprasAnular As DataGridView
    Friend WithEvents txtTituloAnular As Label
    Friend WithEvents pnlAnular As Panel
    Friend WithEvents txtHastaAnul As Label
    Friend WithEvents txtFiltro As Label
    Friend WithEvents btnBuscarAnular As Button
    Friend WithEvents dpAnularCompraFin As DateTimePicker
    Friend WithEvents dpAnularCompraIni As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNrofacturaAnul As TextBox
    Friend WithEvents cbProveedor3 As ComboBox
    Friend WithEvents cbAnularFiltro As ComboBox
    Friend WithEvents pnlOperandosAnular As Panel
    Friend WithEvents btnAnularCompra As Button
    Friend WithEvents btnVerDetalleAnul As Button
    Friend WithEvents cbEstadoCompra As ComboBox
    Friend WithEvents lblBusqTxt As Label
    Friend WithEvents Label11 As Label
End Class
