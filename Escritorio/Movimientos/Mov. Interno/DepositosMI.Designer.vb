<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositosMI
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepositosMI))
        Me.pnlGuardarMov = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardarMov = New System.Windows.Forms.Button()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.btnSeleccionarDeBusqueda = New System.Windows.Forms.Button()
        Me.dgvBusquedaResult = New System.Windows.Forms.DataGridView()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.pnlDatosProducto = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnInsertarProd = New System.Windows.Forms.Button()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCodigoProd = New System.Windows.Forms.TextBox()
        Me.txtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlDatosMov = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDepositoOrigen = New System.Windows.Forms.ComboBox()
        Me.cbAutorizador = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dpFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDepoDestino = New System.Windows.Forms.TextBox()
        Me.txtNroOperacion = New System.Windows.Forms.TextBox()
        Me.lblTituloDetalle = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlGuardarMov.SuspendLayout()
        Me.pnlBusqueda.SuspendLayout()
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatosProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlDatosMov.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGuardarMov
        '
        Me.pnlGuardarMov.Controls.Add(Me.btnSalir)
        Me.pnlGuardarMov.Controls.Add(Me.btnGuardarMov)
        Me.pnlGuardarMov.Location = New System.Drawing.Point(1027, 516)
        Me.pnlGuardarMov.Name = "pnlGuardarMov"
        Me.pnlGuardarMov.Size = New System.Drawing.Size(200, 161)
        Me.pnlGuardarMov.TabIndex = 44
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(35, 97)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 48)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.UseVisualStyleBackColor = True
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
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.btnSeleccionarDeBusqueda)
        Me.pnlBusqueda.Location = New System.Drawing.Point(1027, 410)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(200, 100)
        Me.pnlBusqueda.TabIndex = 45
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
        Me.btnSeleccionarDeBusqueda.UseVisualStyleBackColor = True
        Me.btnSeleccionarDeBusqueda.Visible = False
        '
        'dgvBusquedaResult
        '
        Me.dgvBusquedaResult.AllowUserToAddRows = False
        Me.dgvBusquedaResult.AllowUserToDeleteRows = False
        Me.dgvBusquedaResult.AllowUserToOrderColumns = True
        Me.dgvBusquedaResult.AllowUserToResizeColumns = False
        Me.dgvBusquedaResult.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBusquedaResult.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvBusquedaResult.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvBusquedaResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBusquedaResult.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvBusquedaResult.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvBusquedaResult.Location = New System.Drawing.Point(429, 402)
        Me.dgvBusquedaResult.MultiSelect = False
        Me.dgvBusquedaResult.Name = "dgvBusquedaResult"
        Me.dgvBusquedaResult.ReadOnly = True
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBusquedaResult.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvBusquedaResult.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvBusquedaResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusquedaResult.Size = New System.Drawing.Size(696, 306)
        Me.dgvBusquedaResult.TabIndex = 43
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvProductos.Location = New System.Drawing.Point(172, 402)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(696, 306)
        Me.dgvProductos.TabIndex = 42
        '
        'pnlDatosProducto
        '
        Me.pnlDatosProducto.Controls.Add(Me.Panel1)
        Me.pnlDatosProducto.Controls.Add(Me.Label19)
        Me.pnlDatosProducto.Controls.Add(Me.btnInsertarProd)
        Me.pnlDatosProducto.Controls.Add(Me.btnEliminarProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label8)
        Me.pnlDatosProducto.Controls.Add(Me.Label6)
        Me.pnlDatosProducto.Controls.Add(Me.txtStock)
        Me.pnlDatosProducto.Controls.Add(Me.txtCantidad)
        Me.pnlDatosProducto.Controls.Add(Me.txtCodigoProd)
        Me.pnlDatosProducto.Controls.Add(Me.txtDescripcionProd)
        Me.pnlDatosProducto.Controls.Add(Me.Label9)
        Me.pnlDatosProducto.Controls.Add(Me.Label7)
        Me.pnlDatosProducto.Location = New System.Drawing.Point(92, 200)
        Me.pnlDatosProducto.Name = "pnlDatosProducto"
        Me.pnlDatosProducto.Size = New System.Drawing.Size(1147, 141)
        Me.pnlDatosProducto.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnBuscarProd)
        Me.Panel1.Controls.Add(Me.txtFiltro)
        Me.Panel1.Location = New System.Drawing.Point(16, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 81)
        Me.Panel1.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Busqueda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(24, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Filtro:"
        '
        'btnBuscarProd
        '
        Me.btnBuscarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBuscarProd.Location = New System.Drawing.Point(330, 28)
        Me.btnBuscarProd.Name = "btnBuscarProd"
        Me.btnBuscarProd.Size = New System.Drawing.Size(127, 32)
        Me.btnBuscarProd.TabIndex = 12
        Me.btnBuscarProd.Text = "Buscar"
        Me.btnBuscarProd.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFiltro.Location = New System.Drawing.Point(111, 32)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(202, 27)
        Me.txtFiltro.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(12, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(192, 22)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "DATOS PRODUCTO"
        '
        'btnInsertarProd
        '
        Me.btnInsertarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProd.Location = New System.Drawing.Point(1052, 35)
        Me.btnInsertarProd.Name = "btnInsertarProd"
        Me.btnInsertarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnInsertarProd.TabIndex = 2
        Me.btnInsertarProd.Text = "+"
        Me.btnInsertarProd.UseVisualStyleBackColor = True
        '
        'btnEliminarProd
        '
        Me.btnEliminarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProd.Location = New System.Drawing.Point(1052, 90)
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
        Me.Label8.Location = New System.Drawing.Point(624, 17)
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
        Me.Label6.Location = New System.Drawing.Point(606, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(932, 93)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(61, 27)
        Me.txtStock.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(932, 39)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(61, 27)
        Me.txtCantidad.TabIndex = 5
        '
        'txtCodigoProd
        '
        Me.txtCodigoProd.Enabled = False
        Me.txtCodigoProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProd.Location = New System.Drawing.Point(505, 39)
        Me.txtCodigoProd.Name = "txtCodigoProd"
        Me.txtCodigoProd.ReadOnly = True
        Me.txtCodigoProd.Size = New System.Drawing.Size(319, 27)
        Me.txtCodigoProd.TabIndex = 5
        Me.txtCodigoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescripcionProd
        '
        Me.txtDescripcionProd.Enabled = False
        Me.txtDescripcionProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProd.Location = New System.Drawing.Point(505, 93)
        Me.txtDescripcionProd.Name = "txtDescripcionProd"
        Me.txtDescripcionProd.ReadOnly = True
        Me.txtDescripcionProd.Size = New System.Drawing.Size(319, 27)
        Me.txtDescripcionProd.TabIndex = 5
        Me.txtDescripcionProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(844, 97)
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
        Me.Label7.Location = New System.Drawing.Point(844, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad"
        '
        'pnlDatosMov
        '
        Me.pnlDatosMov.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosMov.Controls.Add(Me.Label10)
        Me.pnlDatosMov.Controls.Add(Me.Label4)
        Me.pnlDatosMov.Controls.Add(Me.cbDepositoOrigen)
        Me.pnlDatosMov.Controls.Add(Me.cbAutorizador)
        Me.pnlDatosMov.Controls.Add(Me.Label18)
        Me.pnlDatosMov.Controls.Add(Me.dpFechaMov)
        Me.pnlDatosMov.Controls.Add(Me.Label3)
        Me.pnlDatosMov.Controls.Add(Me.Label1)
        Me.pnlDatosMov.Controls.Add(Me.Label2)
        Me.pnlDatosMov.Controls.Add(Me.txtDepoDestino)
        Me.pnlDatosMov.Controls.Add(Me.txtNroOperacion)
        Me.pnlDatosMov.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosMov.Location = New System.Drawing.Point(92, 38)
        Me.pnlDatosMov.Name = "pnlDatosMov"
        Me.pnlDatosMov.Size = New System.Drawing.Size(1033, 150)
        Me.pnlDatosMov.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(498, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 19)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(229, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "DE"
        '
        'cbDepositoOrigen
        '
        Me.cbDepositoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepositoOrigen.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDepositoOrigen.FormattingEnabled = True
        Me.cbDepositoOrigen.Location = New System.Drawing.Point(264, 101)
        Me.cbDepositoOrigen.Name = "cbDepositoOrigen"
        Me.cbDepositoOrigen.Size = New System.Drawing.Size(209, 27)
        Me.cbDepositoOrigen.TabIndex = 6
        '
        'cbAutorizador
        '
        Me.cbAutorizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAutorizador.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutorizador.FormattingEnabled = True
        Me.cbAutorizador.Location = New System.Drawing.Point(760, 35)
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
        Me.Label1.Location = New System.Drawing.Point(634, 39)
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
        'txtDepoDestino
        '
        Me.txtDepoDestino.Enabled = False
        Me.txtDepoDestino.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepoDestino.Location = New System.Drawing.Point(524, 101)
        Me.txtDepoDestino.Name = "txtDepoDestino"
        Me.txtDepoDestino.ReadOnly = True
        Me.txtDepoDestino.Size = New System.Drawing.Size(209, 26)
        Me.txtDepoDestino.TabIndex = 0
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOperacion.Location = New System.Drawing.Point(138, 39)
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.Size = New System.Drawing.Size(168, 26)
        Me.txtNroOperacion.TabIndex = 0
        '
        'lblTituloDetalle
        '
        Me.lblTituloDetalle.AutoSize = True
        Me.lblTituloDetalle.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloDetalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloDetalle.Location = New System.Drawing.Point(513, 372)
        Me.lblTituloDetalle.Name = "lblTituloDetalle"
        Me.lblTituloDetalle.Size = New System.Drawing.Size(303, 22)
        Me.lblTituloDetalle.TabIndex = 47
        Me.lblTituloDetalle.Text = "PRODUCTOS DEL MOVIMIENTO"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(425, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(344, 23)
        Me.lblTitulo.TabIndex = 48
        Me.lblTitulo.Text = "MOVIMIENTO INTERNO DEPÓSITOS"
        '
        'DepositosMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1329, 742)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblTituloDetalle)
        Me.Controls.Add(Me.pnlGuardarMov)
        Me.Controls.Add(Me.pnlBusqueda)
        Me.Controls.Add(Me.dgvBusquedaResult)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.pnlDatosProducto)
        Me.Controls.Add(Me.pnlDatosMov)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DepositosMI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DepositosMI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlGuardarMov.ResumeLayout(False)
        Me.pnlBusqueda.ResumeLayout(False)
        CType(Me.dgvBusquedaResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatosProducto.ResumeLayout(False)
        Me.pnlDatosProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlDatosMov.ResumeLayout(False)
        Me.pnlDatosMov.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlGuardarMov As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardarMov As Button
    Friend WithEvents pnlBusqueda As Panel
    Friend WithEvents btnSeleccionarDeBusqueda As Button
    Friend WithEvents dgvBusquedaResult As DataGridView
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents pnlDatosProducto As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarProd As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnInsertarProd As Button
    Friend WithEvents btnEliminarProd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtCodigoProd As TextBox
    Friend WithEvents txtDescripcionProd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlDatosMov As Panel
    Friend WithEvents cbDepositoOrigen As ComboBox
    Friend WithEvents cbAutorizador As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dpFechaMov As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNroOperacion As TextBox
    Friend WithEvents lblTituloDetalle As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtDepoDestino As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
End Class
