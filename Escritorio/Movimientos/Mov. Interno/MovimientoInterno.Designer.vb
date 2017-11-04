<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientoInterno
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlDatosMov = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbTipoPago = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEntregaInicial = New System.Windows.Forms.TextBox()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.rbContado = New System.Windows.Forms.RadioButton()
        Me.dpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroOperacion = New System.Windows.Forms.TextBox()
        Me.gbSolicitante = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSolicitante = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAutorizador = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlDatosProducto = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnInsertarProd = New System.Windows.Forms.Button()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.pnlDatosMov.SuspendLayout()
        Me.gbTipoPago.SuspendLayout()
        Me.gbSolicitante.SuspendLayout()
        Me.pnlDatosProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDatosMov
        '
        Me.pnlDatosMov.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosMov.Controls.Add(Me.cbProveedor)
        Me.pnlDatosMov.Controls.Add(Me.Label11)
        Me.pnlDatosMov.Controls.Add(Me.gbSolicitante)
        Me.pnlDatosMov.Controls.Add(Me.cbAutorizador)
        Me.pnlDatosMov.Controls.Add(Me.Label18)
        Me.pnlDatosMov.Controls.Add(Me.gbTipoPago)
        Me.pnlDatosMov.Controls.Add(Me.dpFechaMov)
        Me.pnlDatosMov.Controls.Add(Me.Label3)
        Me.pnlDatosMov.Controls.Add(Me.Label1)
        Me.pnlDatosMov.Controls.Add(Me.Label2)
        Me.pnlDatosMov.Controls.Add(Me.txtNroOperacion)
        Me.pnlDatosMov.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosMov.Location = New System.Drawing.Point(12, 72)
        Me.pnlDatosMov.Name = "pnlDatosMov"
        Me.pnlDatosMov.Size = New System.Drawing.Size(1046, 198)
        Me.pnlDatosMov.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(12, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(216, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS MOVIMIENTO"
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
        Me.gbTipoPago.Location = New System.Drawing.Point(646, 110)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(307, 67)
        Me.gbTipoPago.TabIndex = 3
        Me.gbTipoPago.TabStop = False
        Me.gbTipoPago.Text = "Tipo de Movimiento"
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
        Me.rbCredito.Size = New System.Drawing.Size(74, 23)
        Me.rbCredito.TabIndex = 1
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "Salida"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'rbContado
        '
        Me.rbContado.AutoSize = True
        Me.rbContado.Location = New System.Drawing.Point(28, 28)
        Me.rbContado.Name = "rbContado"
        Me.rbContado.Size = New System.Drawing.Size(87, 23)
        Me.rbContado.TabIndex = 0
        Me.rbContado.TabStop = True
        Me.rbContado.Text = "Entrada"
        Me.rbContado.UseVisualStyleBackColor = True
        '
        'dpFechaMov
        '
        Me.dpFechaMov.CustomFormat = "dd/mm/aaaa"
        Me.dpFechaMov.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpFechaMov.Location = New System.Drawing.Point(432, 38)
        Me.dpFechaMov.Name = "dpFechaMov"
        Me.dpFechaMov.Size = New System.Drawing.Size(168, 27)
        Me.dpFechaMov.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(333, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Proveedor"
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(432, 110)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(168, 27)
        Me.cbProveedor.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(333, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pedido Nro. :"
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOperacion.Location = New System.Drawing.Point(138, 39)
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.Size = New System.Drawing.Size(168, 26)
        Me.txtNroOperacion.TabIndex = 0
        '
        'gbSolicitante
        '
        Me.gbSolicitante.BackColor = System.Drawing.Color.Transparent
        Me.gbSolicitante.Controls.Add(Me.Label4)
        Me.gbSolicitante.Controls.Add(Me.cbSolicitante)
        Me.gbSolicitante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSolicitante.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbSolicitante.Location = New System.Drawing.Point(646, 3)
        Me.gbSolicitante.Name = "gbSolicitante"
        Me.gbSolicitante.Size = New System.Drawing.Size(379, 77)
        Me.gbSolicitante.TabIndex = 9
        Me.gbSolicitante.TabStop = False
        Me.gbSolicitante.Text = "Solicitado por"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sucursal"
        '
        'cbSolicitante
        '
        Me.cbSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSolicitante.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSolicitante.FormattingEnabled = True
        Me.cbSolicitante.Location = New System.Drawing.Point(179, 29)
        Me.cbSolicitante.Name = "cbSolicitante"
        Me.cbSolicitante.Size = New System.Drawing.Size(168, 27)
        Me.cbSolicitante.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Autorizado Por:"
        '
        'cbAutorizador
        '
        Me.cbAutorizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutorizador.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutorizador.FormattingEnabled = True
        Me.cbAutorizador.Location = New System.Drawing.Point(138, 110)
        Me.cbAutorizador.Name = "cbAutorizador"
        Me.cbAutorizador.Size = New System.Drawing.Size(168, 27)
        Me.cbAutorizador.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(357, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(322, 32)
        Me.lblTitulo.TabIndex = 22
        Me.lblTitulo.Text = "MOVIMIENTO INTERNO"
        '
        'pnlDatosProducto
        '
        Me.pnlDatosProducto.Controls.Add(Me.Label19)
        Me.pnlDatosProducto.Controls.Add(Me.btnBuscarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label5)
        Me.pnlDatosProducto.Controls.Add(Me.btnInsertarProd)
        Me.pnlDatosProducto.Controls.Add(Me.btnEliminarProd)
        Me.pnlDatosProducto.Controls.Add(Me.txtCodProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label6)
        Me.pnlDatosProducto.Controls.Add(Me.txtCantidad)
        Me.pnlDatosProducto.Controls.Add(Me.txtDescripcionProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label7)
        Me.pnlDatosProducto.Location = New System.Drawing.Point(12, 299)
        Me.pnlDatosProducto.Name = "pnlDatosProducto"
        Me.pnlDatosProducto.Size = New System.Drawing.Size(1046, 131)
        Me.pnlDatosProducto.TabIndex = 23
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(23, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Código"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(605, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvProductos.Location = New System.Drawing.Point(12, 463)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(812, 322)
        Me.dgvProductos.TabIndex = 35
        '
        'MovimientoInterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1088, 587)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.pnlDatosProducto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pnlDatosMov)
        Me.MaximizeBox = False
        Me.Name = "MovimientoInterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovimientoInterno"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDatosMov.ResumeLayout(False)
        Me.pnlDatosMov.PerformLayout()
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.gbSolicitante.ResumeLayout(False)
        Me.gbSolicitante.PerformLayout()
        Me.pnlDatosProducto.ResumeLayout(False)
        Me.pnlDatosProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDatosMov As Panel
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents gbSolicitante As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSolicitante As ComboBox
    Friend WithEvents cbAutorizador As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents gbTipoPago As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtEntregaInicial As TextBox
    Friend WithEvents rbCredito As RadioButton
    Friend WithEvents rbContado As RadioButton
    Friend WithEvents dpFechaMov As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNroOperacion As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlDatosProducto As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents btnBuscarProd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnInsertarProd As Button
    Friend WithEvents btnEliminarProd As Button
    Friend WithEvents txtCodProd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtDescripcionProd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvProductos As DataGridView
End Class
