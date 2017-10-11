<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelBuscar = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.cboxBuscar = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.panelOperaciones = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductosList = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductosOper = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductoAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.miModificarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClientesListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClientesOper = New System.Windows.Forms.ToolStripMenuItem()
        Me.miClienteAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElimiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.panelBuscar.SuspendLayout()
        Me.panelOperaciones.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBuscar
        '
        Me.panelBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.panelBuscar.Controls.Add(Me.Label3)
        Me.panelBuscar.Controls.Add(Me.Label1)
        Me.panelBuscar.Controls.Add(Me.cbTipoBusqueda)
        Me.panelBuscar.Controls.Add(Me.cboxBuscar)
        Me.panelBuscar.Controls.Add(Me.btnBuscar)
        Me.panelBuscar.Controls.Add(Me.txtBusqueda)
        Me.panelBuscar.Location = New System.Drawing.Point(0, 20)
        Me.panelBuscar.Name = "panelBuscar"
        Me.panelBuscar.Size = New System.Drawing.Size(487, 80)
        Me.panelBuscar.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Búsqueda/Filtro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar por:"
        '
        'cbTipoBusqueda
        '
        Me.cbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoBusqueda.FormattingEnabled = True
        Me.cbTipoBusqueda.Items.AddRange(New Object() {"Herrajes", "Perfiles"})
        Me.cbTipoBusqueda.Location = New System.Drawing.Point(176, 15)
        Me.cbTipoBusqueda.Name = "cbTipoBusqueda"
        Me.cbTipoBusqueda.Size = New System.Drawing.Size(150, 21)
        Me.cbTipoBusqueda.TabIndex = 3
        Me.cbTipoBusqueda.Visible = False
        '
        'cboxBuscar
        '
        Me.cboxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBuscar.FormattingEnabled = True
        Me.cboxBuscar.Location = New System.Drawing.Point(38, 42)
        Me.cboxBuscar.Name = "cboxBuscar"
        Me.cboxBuscar.Size = New System.Drawing.Size(121, 21)
        Me.cboxBuscar.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(351, 42)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(113, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(176, 42)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(150, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'panelOperaciones
        '
        Me.panelOperaciones.BackColor = System.Drawing.SystemColors.Control
        Me.panelOperaciones.Controls.Add(Me.Label2)
        Me.panelOperaciones.Controls.Add(Me.btnAgregar)
        Me.panelOperaciones.Controls.Add(Me.btnEliminar)
        Me.panelOperaciones.Controls.Add(Me.btnModificar)
        Me.panelOperaciones.Location = New System.Drawing.Point(507, 20)
        Me.panelOperaciones.Name = "panelOperaciones"
        Me.panelOperaciones.Size = New System.Drawing.Size(305, 80)
        Me.panelOperaciones.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Operaciones"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(27, 42)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(211, 42)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(120, 42)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miSesion, Me.miProductos, Me.miClientes})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(963, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'miSesion
        '
        Me.miSesion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.miSesion.Name = "miSesion"
        Me.miSesion.Size = New System.Drawing.Size(53, 20)
        Me.miSesion.Text = "Sesión"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'miProductos
        '
        Me.miProductos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProductosList, Me.miProductosOper})
        Me.miProductos.Name = "miProductos"
        Me.miProductos.Size = New System.Drawing.Size(73, 20)
        Me.miProductos.Text = "Productos"
        '
        'miProductosList
        '
        Me.miProductosList.Name = "miProductosList"
        Me.miProductosList.Size = New System.Drawing.Size(140, 22)
        Me.miProductosList.Text = "Listado"
        '
        'miProductosOper
        '
        Me.miProductosOper.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProductoAgregar, Me.miModificarProducto, Me.EliminarToolStripMenuItem})
        Me.miProductosOper.Name = "miProductosOper"
        Me.miProductosOper.Size = New System.Drawing.Size(140, 22)
        Me.miProductosOper.Text = "Operaciones"
        '
        'miProductoAgregar
        '
        Me.miProductoAgregar.Name = "miProductoAgregar"
        Me.miProductoAgregar.Size = New System.Drawing.Size(125, 22)
        Me.miProductoAgregar.Text = "Agregar"
        '
        'miModificarProducto
        '
        Me.miModificarProducto.Name = "miModificarProducto"
        Me.miModificarProducto.Size = New System.Drawing.Size(125, 22)
        Me.miModificarProducto.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'miClientes
        '
        Me.miClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miClientesListado, Me.miClientesOper})
        Me.miClientes.Name = "miClientes"
        Me.miClientes.Size = New System.Drawing.Size(61, 20)
        Me.miClientes.Text = "Clientes"
        '
        'miClientesListado
        '
        Me.miClientesListado.Name = "miClientesListado"
        Me.miClientesListado.Size = New System.Drawing.Size(152, 22)
        Me.miClientesListado.Text = "Listado"
        '
        'miClientesOper
        '
        Me.miClientesOper.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miClienteAgregar, Me.ModificarToolStripMenuItem1, Me.ElimiarToolStripMenuItem})
        Me.miClientesOper.Name = "miClientesOper"
        Me.miClientesOper.Size = New System.Drawing.Size(152, 22)
        Me.miClientesOper.Text = "Operaciones"
        '
        'miClienteAgregar
        '
        Me.miClienteAgregar.Name = "miClienteAgregar"
        Me.miClienteAgregar.Size = New System.Drawing.Size(152, 22)
        Me.miClienteAgregar.Text = "Agregar"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'ElimiarToolStripMenuItem
        '
        Me.ElimiarToolStripMenuItem.Name = "ElimiarToolStripMenuItem"
        Me.ElimiarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ElimiarToolStripMenuItem.Text = "Eliminar"
        '
        'dgvDatos
        '
        Me.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.GridColor = System.Drawing.Color.CadetBlue
        Me.dgvDatos.Location = New System.Drawing.Point(90, 321)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(812, 247)
        Me.dgvDatos.TabIndex = 29
        Me.dgvDatos.Visible = False
        '
        'pnlControles
        '
        Me.pnlControles.BackColor = System.Drawing.Color.Transparent
        Me.pnlControles.Controls.Add(Me.panelBuscar)
        Me.pnlControles.Controls.Add(Me.panelOperaciones)
        Me.pnlControles.Location = New System.Drawing.Point(90, 40)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(812, 100)
        Me.pnlControles.TabIndex = 31
        '
        'Inicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(963, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlControles)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casa Marco"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelBuscar.ResumeLayout(False)
        Me.panelBuscar.PerformLayout()
        Me.panelOperaciones.ResumeLayout(False)
        Me.panelOperaciones.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControles.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelBuscar As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents panelOperaciones As System.Windows.Forms.Panel
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents SesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents miSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductosList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductosOper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miProductoAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miModificarProducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents cboxBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents miClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClientesListado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClientesOper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miClienteAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElimiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents pnlControles As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
