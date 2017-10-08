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
        Me.lbProductos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbVent = New System.Windows.Forms.Label()
        Me.lbProv = New System.Windows.Forms.Label()
        Me.lbClientes = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.panelBuscar = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.panelOperaciones = New System.Windows.Forms.Panel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.miSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductosList = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductosOper = New System.Windows.Forms.ToolStripMenuItem()
        Me.miProductoAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBuscar.SuspendLayout()
        Me.panelOperaciones.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbProductos
        '
        Me.lbProductos.AutoSize = True
        Me.lbProductos.Location = New System.Drawing.Point(36, 114)
        Me.lbProductos.Name = "lbProductos"
        Me.lbProductos.Padding = New System.Windows.Forms.Padding(8, 5, 5, 8)
        Me.lbProductos.Size = New System.Drawing.Size(88, 26)
        Me.lbProductos.TabIndex = 1
        Me.lbProductos.Text = "PRODUCTOS"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbVent)
        Me.Panel1.Controls.Add(Me.lbProv)
        Me.Panel1.Controls.Add(Me.lbClientes)
        Me.Panel1.Controls.Add(Me.lbProductos)
        Me.Panel1.Location = New System.Drawing.Point(28, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 149)
        Me.Panel1.TabIndex = 19
        '
        'lbVent
        '
        Me.lbVent.AutoSize = True
        Me.lbVent.Location = New System.Drawing.Point(374, 114)
        Me.lbVent.Name = "lbVent"
        Me.lbVent.Padding = New System.Windows.Forms.Padding(8, 5, 5, 8)
        Me.lbVent.Size = New System.Drawing.Size(63, 26)
        Me.lbVent.TabIndex = 1
        Me.lbVent.Text = "VENTAS"
        '
        'lbProv
        '
        Me.lbProv.AutoSize = True
        Me.lbProv.Location = New System.Drawing.Point(252, 114)
        Me.lbProv.Name = "lbProv"
        Me.lbProv.Padding = New System.Windows.Forms.Padding(8, 5, 5, 8)
        Me.lbProv.Size = New System.Drawing.Size(102, 26)
        Me.lbProv.TabIndex = 1
        Me.lbProv.Text = "PROVEEDORES"
        '
        'lbClientes
        '
        Me.lbClientes.AutoSize = True
        Me.lbClientes.Location = New System.Drawing.Point(152, 114)
        Me.lbClientes.Name = "lbClientes"
        Me.lbClientes.Padding = New System.Windows.Forms.Padding(8, 5, 5, 8)
        Me.lbClientes.Size = New System.Drawing.Size(72, 26)
        Me.lbClientes.TabIndex = 1
        Me.lbClientes.Text = "CLIENTES"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.dgvProductos)
        Me.Panel2.Location = New System.Drawing.Point(28, 286)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 280)
        Me.Panel2.TabIndex = 21
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.Location = New System.Drawing.Point(0, 0)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.Size = New System.Drawing.Size(736, 280)
        Me.dgvProductos.TabIndex = 0
        '
        'panelBuscar
        '
        Me.panelBuscar.Controls.Add(Me.ComboBox1)
        Me.panelBuscar.Controls.Add(Me.btnBuscar)
        Me.panelBuscar.Controls.Add(Me.TextBox1)
        Me.panelBuscar.Location = New System.Drawing.Point(28, 208)
        Me.panelBuscar.Name = "panelBuscar"
        Me.panelBuscar.Size = New System.Drawing.Size(484, 52)
        Me.panelBuscar.TabIndex = 22
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(352, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(177, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 1
        '
        'panelOperaciones
        '
        Me.panelOperaciones.Controls.Add(Me.btnEliminar)
        Me.panelOperaciones.Controls.Add(Me.btnModificar)
        Me.panelOperaciones.Location = New System.Drawing.Point(597, 208)
        Me.panelOperaciones.Name = "panelOperaciones"
        Me.panelOperaciones.Size = New System.Drawing.Size(229, 52)
        Me.panelOperaciones.TabIndex = 25
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(22, 14)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miSesion, Me.miProductos})
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
        Me.miProductosList.Size = New System.Drawing.Size(152, 22)
        Me.miProductosList.Text = "Listado"
        '
        'miProductosOper
        '
        Me.miProductosOper.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miProductoAgregar, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.miProductosOper.Name = "miProductosOper"
        Me.miProductosOper.Size = New System.Drawing.Size(152, 22)
        Me.miProductosOper.Text = "Operaciones"
        '
        'miProductoAgregar
        '
        Me.miProductoAgregar.Name = "miProductoAgregar"
        Me.miProductoAgregar.Size = New System.Drawing.Size(152, 22)
        Me.miProductoAgregar.Text = "Agregar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(118, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(39, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Inicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(963, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelOperaciones)
        Me.Controls.Add(Me.panelBuscar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBuscar.ResumeLayout(False)
        Me.panelBuscar.PerformLayout()
        Me.panelOperaciones.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbProductos As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbVent As System.Windows.Forms.Label
    Friend WithEvents lbProv As System.Windows.Forms.Label
    Friend WithEvents lbClientes As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents panelBuscar As System.Windows.Forms.Panel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents panelOperaciones As System.Windows.Forms.Panel
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
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
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
