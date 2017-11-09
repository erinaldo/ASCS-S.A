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
        Me.components = New System.ComponentModel.Container()
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
        Me.pnlDatosMov = New System.Windows.Forms.Panel()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbSolicitante = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSolicitante = New System.Windows.Forms.ComboBox()
        Me.cbAutorizador = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbTipoMov = New System.Windows.Forms.GroupBox()
        Me.rbSalida = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.dpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroOperacion = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlDatosProducto = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnInsertarProd = New System.Windows.Forms.Button()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCodigoProd = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvBusquedaResult = New System.Windows.Forms.DataGridView()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.btnSeleccionarDeBusqueda = New System.Windows.Forms.Button()
        Me.pnlGuardarMov = New System.Windows.Forms.Panel()
        Me.btnGuardarMov = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTituloDetalle = New System.Windows.Forms.Label()
        Me.pnlDatosMov.SuspendLayout()
        Me.gbSolicitante.SuspendLayout()
        Me.gbTipoMov.SuspendLayout()
        Me.pnlDatosProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBusqueda.SuspendLayout()
        Me.pnlGuardarMov.SuspendLayout()
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
        Me.pnlDatosMov.Controls.Add(Me.gbTipoMov)
        Me.pnlDatosMov.Controls.Add(Me.dpFechaMov)
        Me.pnlDatosMov.Controls.Add(Me.Label3)
        Me.pnlDatosMov.Controls.Add(Me.Label1)
        Me.pnlDatosMov.Controls.Add(Me.Label2)
        Me.pnlDatosMov.Controls.Add(Me.txtNroOperacion)
        Me.pnlDatosMov.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosMov.Location = New System.Drawing.Point(12, 47)
        Me.pnlDatosMov.Name = "pnlDatosMov"
        Me.pnlDatosMov.Size = New System.Drawing.Size(1046, 198)
        Me.pnlDatosMov.TabIndex = 21
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.Enabled = False
        Me.cbProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(432, 110)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(168, 27)
        Me.cbProveedor.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(333, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Proveedor"
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
        'gbTipoMov
        '
        Me.gbTipoMov.BackColor = System.Drawing.Color.Transparent
        Me.gbTipoMov.Controls.Add(Me.rbSalida)
        Me.gbTipoMov.Controls.Add(Me.rbEntrada)
        Me.gbTipoMov.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoMov.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbTipoMov.Location = New System.Drawing.Point(646, 110)
        Me.gbTipoMov.Name = "gbTipoMov"
        Me.gbTipoMov.Size = New System.Drawing.Size(307, 68)
        Me.gbTipoMov.TabIndex = 3
        Me.gbTipoMov.TabStop = False
        Me.gbTipoMov.Text = "Tipo de Movimiento"
        '
        'rbSalida
        '
        Me.rbSalida.AutoSize = True
        Me.rbSalida.Location = New System.Drawing.Point(163, 28)
        Me.rbSalida.Name = "rbSalida"
        Me.rbSalida.Size = New System.Drawing.Size(74, 23)
        Me.rbSalida.TabIndex = 1
        Me.rbSalida.TabStop = True
        Me.rbSalida.Text = "Salida"
        Me.rbSalida.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Location = New System.Drawing.Point(28, 28)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(87, 23)
        Me.rbEntrada.TabIndex = 0
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada"
        Me.rbEntrada.UseVisualStyleBackColor = True
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
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(360, 9)
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
        Me.pnlDatosProducto.Controls.Add(Me.txtFiltro)
        Me.pnlDatosProducto.Controls.Add(Me.Label8)
        Me.pnlDatosProducto.Controls.Add(Me.Label6)
        Me.pnlDatosProducto.Controls.Add(Me.txtStock)
        Me.pnlDatosProducto.Controls.Add(Me.txtCantidad)
        Me.pnlDatosProducto.Controls.Add(Me.txtCodigoProd)
        Me.pnlDatosProducto.Controls.Add(Me.txtDescripcionProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label9)
        Me.pnlDatosProducto.Controls.Add(Me.Label7)
        Me.pnlDatosProducto.Location = New System.Drawing.Point(12, 271)
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
        Me.ToolTip1.SetToolTip(Me.btnBuscarProd, "Buscar Producto")
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
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Filtro:"
        '
        'btnInsertarProd
        '
        Me.btnInsertarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProd.Location = New System.Drawing.Point(957, 34)
        Me.btnInsertarProd.Name = "btnInsertarProd"
        Me.btnInsertarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnInsertarProd.TabIndex = 2
        Me.btnInsertarProd.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnInsertarProd, "Agregar Producto")
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
        Me.ToolTip1.SetToolTip(Me.btnEliminarProd, "Eliminar Producto Seleccionado")
        Me.btnEliminarProd.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(92, 39)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(127, 27)
        Me.txtFiltro.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(290, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Código"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(290, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(693, 88)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(177, 27)
        Me.txtStock.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(693, 40)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(177, 27)
        Me.txtCantidad.TabIndex = 5
        '
        'txtCodigoProd
        '
        Me.txtCodigoProd.Enabled = False
        Me.txtCodigoProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProd.Location = New System.Drawing.Point(398, 40)
        Me.txtCodigoProd.Name = "txtCodigoProd"
        Me.txtCodigoProd.ReadOnly = True
        Me.txtCodigoProd.Size = New System.Drawing.Size(195, 27)
        Me.txtCodigoProd.TabIndex = 5
        '
        'txtDescripcionProd
        '
        Me.txtDescripcionProd.Enabled = False
        Me.txtDescripcionProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProd.Location = New System.Drawing.Point(398, 88)
        Me.txtDescripcionProd.Name = "txtDescripcionProd"
        Me.txtDescripcionProd.ReadOnly = True
        Me.txtDescripcionProd.Size = New System.Drawing.Size(195, 27)
        Me.txtDescripcionProd.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(605, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Stock"
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
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvProductos.Location = New System.Drawing.Point(465, 463)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(593, 325)
        Me.dgvProductos.TabIndex = 35
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
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBusquedaResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBusquedaResult.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBusquedaResult.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvBusquedaResult.Location = New System.Drawing.Point(12, 463)
        Me.dgvBusquedaResult.Name = "dgvBusquedaResult"
        Me.dgvBusquedaResult.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvBusquedaResult.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvBusquedaResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusquedaResult.Size = New System.Drawing.Size(593, 325)
        Me.dgvBusquedaResult.TabIndex = 36
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.btnSeleccionarDeBusqueda)
        Me.pnlBusqueda.Location = New System.Drawing.Point(867, 452)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(200, 100)
        Me.pnlBusqueda.TabIndex = 37
        Me.pnlBusqueda.Visible = False
        '
        'btnSeleccionarDeBusqueda
        '
        Me.btnSeleccionarDeBusqueda.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarDeBusqueda.Location = New System.Drawing.Point(42, 36)
        Me.btnSeleccionarDeBusqueda.Name = "btnSeleccionarDeBusqueda"
        Me.btnSeleccionarDeBusqueda.Size = New System.Drawing.Size(117, 38)
        Me.btnSeleccionarDeBusqueda.TabIndex = 0
        Me.btnSeleccionarDeBusqueda.Text = "Seleccionar"
        Me.ToolTip1.SetToolTip(Me.btnSeleccionarDeBusqueda, "Seleccionar Producto")
        Me.btnSeleccionarDeBusqueda.UseVisualStyleBackColor = True
        Me.btnSeleccionarDeBusqueda.Visible = False
        '
        'pnlGuardarMov
        '
        Me.pnlGuardarMov.Controls.Add(Me.btnGuardarMov)
        Me.pnlGuardarMov.Location = New System.Drawing.Point(867, 619)
        Me.pnlGuardarMov.Name = "pnlGuardarMov"
        Me.pnlGuardarMov.Size = New System.Drawing.Size(200, 100)
        Me.pnlGuardarMov.TabIndex = 37
        '
        'btnGuardarMov
        '
        Me.btnGuardarMov.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarMov.Location = New System.Drawing.Point(35, 29)
        Me.btnGuardarMov.Name = "btnGuardarMov"
        Me.btnGuardarMov.Size = New System.Drawing.Size(135, 50)
        Me.btnGuardarMov.TabIndex = 0
        Me.btnGuardarMov.Text = "Guardar Movimiento"
        Me.btnGuardarMov.UseVisualStyleBackColor = True
        '
        'lblTituloDetalle
        '
        Me.lblTituloDetalle.AutoSize = True
        Me.lblTituloDetalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloDetalle.Location = New System.Drawing.Point(513, 425)
        Me.lblTituloDetalle.Name = "lblTituloDetalle"
        Me.lblTituloDetalle.Size = New System.Drawing.Size(303, 22)
        Me.lblTituloDetalle.TabIndex = 38
        Me.lblTituloDetalle.Text = "PRODUCTOS DEL MOVIMIENTO"
        '
        'MovimientoInterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1088, 742)
        Me.Controls.Add(Me.lblTituloDetalle)
        Me.Controls.Add(Me.pnlGuardarMov)
        Me.Controls.Add(Me.pnlBusqueda)
        Me.Controls.Add(Me.dgvBusquedaResult)
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
        Me.gbSolicitante.ResumeLayout(False)
        Me.gbSolicitante.PerformLayout()
        Me.gbTipoMov.ResumeLayout(False)
        Me.gbTipoMov.PerformLayout()
        Me.pnlDatosProducto.ResumeLayout(False)
        Me.pnlDatosProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBusqueda.ResumeLayout(False)
        Me.pnlGuardarMov.ResumeLayout(False)
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
    Friend WithEvents gbTipoMov As GroupBox
    Friend WithEvents rbSalida As RadioButton
    Friend WithEvents rbEntrada As RadioButton
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
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtDescripcionProd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents dgvBusquedaResult As DataGridView
    Friend WithEvents pnlBusqueda As Panel
    Friend WithEvents btnSeleccionarDeBusqueda As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodigoProd As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlGuardarMov As Panel
    Friend WithEvents btnGuardarMov As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblTituloDetalle As Label
End Class
