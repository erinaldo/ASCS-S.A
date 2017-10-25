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
        Me.dateFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbTipoPago = New System.Windows.Forms.GroupBox()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.rbContado = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.tbcCompra = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvCompras = New System.Windows.Forms.DataGridView()
        Me.gbBusquedaCompra = New System.Windows.Forms.GroupBox()
        Me.btnBuscarCompra = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.datepFin = New System.Windows.Forms.DateTimePicker()
        Me.datepInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtTituloBusqueda = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.gbComentario = New System.Windows.Forms.GroupBox()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.gbOperadores = New System.Windows.Forms.GroupBox()
        Me.btnGuardarCompra = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.gbDatosProducto = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProd = New System.Windows.Forms.Button()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.cbDeposito = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcionProd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrecioProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.btnEliminarProd = New System.Windows.Forms.Button()
        Me.btnInsertarProd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbDatosCompra = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ttCompra = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbTipoPago.SuspendLayout()
        Me.tbcCompra.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBusquedaCompra.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbComentario.SuspendLayout()
        Me.gbOperadores.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosProducto.SuspendLayout()
        Me.gbDatosCompra.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateFactura
        '
        Me.dateFactura.CustomFormat = "dd/mm/aaaa"
        Me.dateFactura.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFactura.Location = New System.Drawing.Point(128, 94)
        Me.dateFactura.Name = "dateFactura"
        Me.dateFactura.Size = New System.Drawing.Size(168, 27)
        Me.dateFactura.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Factura"
        '
        'gbTipoPago
        '
        Me.gbTipoPago.Controls.Add(Me.rbCredito)
        Me.gbTipoPago.Controls.Add(Me.rbContado)
        Me.gbTipoPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoPago.Location = New System.Drawing.Point(733, 21)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(307, 64)
        Me.gbTipoPago.TabIndex = 3
        Me.gbTipoPago.TabStop = False
        Me.gbTipoPago.Text = "Tipo de Pago"
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Location = New System.Drawing.Point(163, 28)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(78, 23)
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
        Me.rbContado.Size = New System.Drawing.Size(86, 23)
        Me.rbContado.TabIndex = 0
        Me.rbContado.TabStop = True
        Me.rbContado.Text = "Contado"
        Me.rbContado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Factura Nº"
        '
        'txtFacturaNro
        '
        Me.txtFacturaNro.Location = New System.Drawing.Point(128, 42)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.Size = New System.Drawing.Size(168, 30)
        Me.txtFacturaNro.TabIndex = 0
        '
        'tbcCompra
        '
        Me.tbcCompra.Controls.Add(Me.TabPage1)
        Me.tbcCompra.Controls.Add(Me.TabPage2)
        Me.tbcCompra.Controls.Add(Me.TabPage3)
        Me.tbcCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcCompra.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcCompra.Location = New System.Drawing.Point(0, 0)
        Me.tbcCompra.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.tbcCompra.Name = "tbcCompra"
        Me.tbcCompra.SelectedIndex = 0
        Me.tbcCompra.Size = New System.Drawing.Size(1120, 742)
        Me.tbcCompra.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.Controls.Add(Me.dgvCompras)
        Me.TabPage1.Controls.Add(Me.gbBusquedaCompra)
        Me.TabPage1.Controls.Add(Me.txtTituloBusqueda)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1112, 713)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'dgvCompras
        '
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Location = New System.Drawing.Point(51, 298)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.Size = New System.Drawing.Size(910, 304)
        Me.dgvCompras.TabIndex = 4
        '
        'gbBusquedaCompra
        '
        Me.gbBusquedaCompra.Controls.Add(Me.btnBuscarCompra)
        Me.gbBusquedaCompra.Controls.Add(Me.Label13)
        Me.gbBusquedaCompra.Controls.Add(Me.Label14)
        Me.gbBusquedaCompra.Controls.Add(Me.datepFin)
        Me.gbBusquedaCompra.Controls.Add(Me.datepInicio)
        Me.gbBusquedaCompra.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBusquedaCompra.Location = New System.Drawing.Point(51, 88)
        Me.gbBusquedaCompra.Name = "gbBusquedaCompra"
        Me.gbBusquedaCompra.Size = New System.Drawing.Size(910, 100)
        Me.gbBusquedaCompra.TabIndex = 3
        Me.gbBusquedaCompra.TabStop = False
        Me.gbBusquedaCompra.Text = "Rango de Compra"
        '
        'btnBuscarCompra
        '
        Me.btnBuscarCompra.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCompra.Location = New System.Drawing.Point(703, 42)
        Me.btnBuscarCompra.Name = "btnBuscarCompra"
        Me.btnBuscarCompra.Size = New System.Drawing.Size(108, 27)
        Me.btnBuscarCompra.TabIndex = 3
        Me.btnBuscarCompra.Text = "Buscar"
        Me.btnBuscarCompra.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(53, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Desde"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(372, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 19)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Hasta"
        '
        'datepFin
        '
        Me.datepFin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepFin.Location = New System.Drawing.Point(448, 42)
        Me.datepFin.Name = "datepFin"
        Me.datepFin.Size = New System.Drawing.Size(200, 27)
        Me.datepFin.TabIndex = 0
        '
        'datepInicio
        '
        Me.datepInicio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepInicio.Location = New System.Drawing.Point(132, 42)
        Me.datepInicio.Name = "datepInicio"
        Me.datepInicio.Size = New System.Drawing.Size(200, 27)
        Me.datepInicio.TabIndex = 0
        '
        'txtTituloBusqueda
        '
        Me.txtTituloBusqueda.AutoSize = True
        Me.txtTituloBusqueda.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTituloBusqueda.Location = New System.Drawing.Point(383, 40)
        Me.txtTituloBusqueda.Name = "txtTituloBusqueda"
        Me.txtTituloBusqueda.Size = New System.Drawing.Size(196, 25)
        Me.txtTituloBusqueda.TabIndex = 1
        Me.txtTituloBusqueda.Text = "Listado de Compras"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage2.Controls.Add(Me.txtTotalCompra)
        Me.TabPage2.Controls.Add(Me.lblTotal)
        Me.TabPage2.Controls.Add(Me.gbComentario)
        Me.TabPage2.Controls.Add(Me.gbOperadores)
        Me.TabPage2.Controls.Add(Me.dgvProductos)
        Me.TabPage2.Controls.Add(Me.gbDatosProducto)
        Me.TabPage2.Controls.Add(Me.gbDatosCompra)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1112, 713)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nueva Compra"
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompra.Location = New System.Drawing.Point(885, 554)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.Size = New System.Drawing.Size(193, 30)
        Me.txtTotalCompra.TabIndex = 12
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(770, 559)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(109, 23)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "TOTAL Gs."
        '
        'gbComentario
        '
        Me.gbComentario.Controls.Add(Me.txtComentario)
        Me.gbComentario.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbComentario.Location = New System.Drawing.Point(32, 559)
        Me.gbComentario.Name = "gbComentario"
        Me.gbComentario.Size = New System.Drawing.Size(367, 140)
        Me.gbComentario.TabIndex = 10
        Me.gbComentario.TabStop = False
        Me.gbComentario.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComentario.Location = New System.Drawing.Point(3, 26)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(361, 111)
        Me.txtComentario.TabIndex = 5
        Me.txtComentario.Text = ""
        '
        'gbOperadores
        '
        Me.gbOperadores.Controls.Add(Me.btnGuardarCompra)
        Me.gbOperadores.Controls.Add(Me.Button4)
        Me.gbOperadores.Location = New System.Drawing.Point(674, 599)
        Me.gbOperadores.Name = "gbOperadores"
        Me.gbOperadores.Size = New System.Drawing.Size(385, 100)
        Me.gbOperadores.TabIndex = 9
        Me.gbOperadores.TabStop = False
        '
        'btnGuardarCompra
        '
        Me.btnGuardarCompra.Location = New System.Drawing.Point(46, 36)
        Me.btnGuardarCompra.Name = "btnGuardarCompra"
        Me.btnGuardarCompra.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarCompra.TabIndex = 6
        Me.btnGuardarCompra.Text = "Guardar"
        Me.btnGuardarCompra.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(219, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 41)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(32, 385)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1046, 150)
        Me.dgvProductos.TabIndex = 4
        '
        'gbDatosProducto
        '
        Me.gbDatosProducto.Controls.Add(Me.btnBuscarProd)
        Me.gbDatosProducto.Controls.Add(Me.txtImpuesto)
        Me.gbDatosProducto.Controls.Add(Me.cbDeposito)
        Me.gbDatosProducto.Controls.Add(Me.Label9)
        Me.gbDatosProducto.Controls.Add(Me.Label8)
        Me.gbDatosProducto.Controls.Add(Me.Label6)
        Me.gbDatosProducto.Controls.Add(Me.txtDescripcionProd)
        Me.gbDatosProducto.Controls.Add(Me.Label7)
        Me.gbDatosProducto.Controls.Add(Me.txtPrecioProd)
        Me.gbDatosProducto.Controls.Add(Me.Label5)
        Me.gbDatosProducto.Controls.Add(Me.txtCantidad)
        Me.gbDatosProducto.Controls.Add(Me.txtCodProd)
        Me.gbDatosProducto.Controls.Add(Me.btnEliminarProd)
        Me.gbDatosProducto.Controls.Add(Me.btnInsertarProd)
        Me.gbDatosProducto.Controls.Add(Me.Label4)
        Me.gbDatosProducto.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosProducto.Location = New System.Drawing.Point(32, 182)
        Me.gbDatosProducto.Name = "gbDatosProducto"
        Me.gbDatosProducto.Size = New System.Drawing.Size(1046, 165)
        Me.gbDatosProducto.TabIndex = 3
        Me.gbDatosProducto.TabStop = False
        Me.gbDatosProducto.Text = "Agregar Producto"
        '
        'btnBuscarProd
        '
        Me.btnBuscarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProd.Location = New System.Drawing.Point(87, 73)
        Me.btnBuscarProd.Name = "btnBuscarProd"
        Me.btnBuscarProd.Size = New System.Drawing.Size(127, 32)
        Me.btnBuscarProd.TabIndex = 12
        Me.btnBuscarProd.Text = "Buscar"
        Me.ttCompra.SetToolTip(Me.btnBuscarProd, "Buscar Producto por código")
        Me.btnBuscarProd.UseVisualStyleBackColor = True
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto.Location = New System.Drawing.Point(387, 129)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(195, 27)
        Me.txtImpuesto.TabIndex = 11
        '
        'cbDeposito
        '
        Me.cbDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDeposito.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDeposito.FormattingEnabled = True
        Me.cbDeposito.Location = New System.Drawing.Point(387, 89)
        Me.cbDeposito.Name = "cbDeposito"
        Me.cbDeposito.Size = New System.Drawing.Size(195, 27)
        Me.cbDeposito.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(279, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(279, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Depósito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Descripción"
        '
        'txtDescripcionProd
        '
        Me.txtDescripcionProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionProd.Location = New System.Drawing.Point(387, 40)
        Me.txtDescripcionProd.Name = "txtDescripcionProd"
        Me.txtDescripcionProd.Size = New System.Drawing.Size(195, 27)
        Me.txtDescripcionProd.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(600, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio"
        '
        'txtPrecioProd
        '
        Me.txtPrecioProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProd.Location = New System.Drawing.Point(687, 83)
        Me.txtPrecioProd.Name = "txtPrecioProd"
        Me.txtPrecioProd.Size = New System.Drawing.Size(178, 27)
        Me.txtPrecioProd.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(600, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(688, 41)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(177, 27)
        Me.txtCantidad.TabIndex = 5
        '
        'txtCodProd
        '
        Me.txtCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProd.Location = New System.Drawing.Point(87, 40)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(127, 27)
        Me.txtCodProd.TabIndex = 4
        '
        'btnEliminarProd
        '
        Me.btnEliminarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProd.Location = New System.Drawing.Point(952, 89)
        Me.btnEliminarProd.Name = "btnEliminarProd"
        Me.btnEliminarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnEliminarProd.TabIndex = 3
        Me.btnEliminarProd.Text = "-"
        Me.ttCompra.SetToolTip(Me.btnEliminarProd, "Quitar Producto")
        Me.btnEliminarProd.UseVisualStyleBackColor = True
        '
        'btnInsertarProd
        '
        Me.btnInsertarProd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertarProd.Location = New System.Drawing.Point(952, 35)
        Me.btnInsertarProd.Name = "btnInsertarProd"
        Me.btnInsertarProd.Size = New System.Drawing.Size(75, 32)
        Me.btnInsertarProd.TabIndex = 2
        Me.btnInsertarProd.Text = "+"
        Me.ttCompra.SetToolTip(Me.btnInsertarProd, "Agregar Producto")
        Me.btnInsertarProd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Código"
        '
        'gbDatosCompra
        '
        Me.gbDatosCompra.Controls.Add(Me.GroupBox2)
        Me.gbDatosCompra.Controls.Add(Me.dateFactura)
        Me.gbDatosCompra.Controls.Add(Me.Label2)
        Me.gbDatosCompra.Controls.Add(Me.Label3)
        Me.gbDatosCompra.Controls.Add(Me.txtFacturaNro)
        Me.gbDatosCompra.Controls.Add(Me.gbTipoPago)
        Me.gbDatosCompra.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosCompra.Location = New System.Drawing.Point(32, 16)
        Me.gbDatosCompra.Name = "gbDatosCompra"
        Me.gbDatosCompra.Size = New System.Drawing.Size(1046, 146)
        Me.gbDatosCompra.TabIndex = 2
        Me.gbDatosCompra.TabStop = False
        Me.gbDatosCompra.Text = "Datos Compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbProveedores)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(332, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 111)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar por Código"
        '
        'cbProveedores
        '
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(179, 29)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(168, 27)
        Me.cbProveedores.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(179, 67)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(168, 27)
        Me.TextBox6.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1112, 713)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Anular Compra"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GenerarCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1120, 742)
        Me.Controls.Add(Me.tbcCompra)
        Me.Name = "GenerarCompras"
        Me.Text = "COMPRAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.tbcCompra.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBusquedaCompra.ResumeLayout(False)
        Me.gbBusquedaCompra.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gbComentario.ResumeLayout(False)
        Me.gbOperadores.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosProducto.ResumeLayout(False)
        Me.gbDatosProducto.PerformLayout()
        Me.gbDatosCompra.ResumeLayout(False)
        Me.gbDatosCompra.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dateFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbTipoPago As System.Windows.Forms.GroupBox
    Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbContado As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFacturaNro As System.Windows.Forms.TextBox
    Friend WithEvents tbcCompra As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents gbDatosProducto As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionProd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioProd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarProd As System.Windows.Forms.Button
    Friend WithEvents btnInsertarProd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbDatosCompra As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnGuardarCompra As System.Windows.Forms.Button
    Friend WithEvents txtComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents cbDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents dgvCompras As System.Windows.Forms.DataGridView
    Friend WithEvents gbBusquedaCompra As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents datepFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents datepInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTituloBusqueda As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCompra As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents gbOperadores As GroupBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents btnBuscarProd As Button

    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gbComentario As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalCompra As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents CódigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ttCompra As ToolTip
End Class
