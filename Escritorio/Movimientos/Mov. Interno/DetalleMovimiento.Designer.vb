<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleMovimiento
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleMovimiento))
        Me.pnlDatosMov = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProv = New System.Windows.Forms.Label()
        Me.gbSolicitante = New System.Windows.Forms.GroupBox()
        Me.lblSolicita = New System.Windows.Forms.Label()
        Me.txtSolicita = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtAutorizado = New System.Windows.Forms.TextBox()
        Me.txtNroOperacion = New System.Windows.Forms.TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.pnlOperadores = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlDatosMov.SuspendLayout()
        Me.gbSolicitante.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOperadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDatosMov
        '
        Me.pnlDatosMov.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosMov.Controls.Add(Me.Label5)
        Me.pnlDatosMov.Controls.Add(Me.lblProv)
        Me.pnlDatosMov.Controls.Add(Me.gbSolicitante)
        Me.pnlDatosMov.Controls.Add(Me.Label18)
        Me.pnlDatosMov.Controls.Add(Me.Label3)
        Me.pnlDatosMov.Controls.Add(Me.Label1)
        Me.pnlDatosMov.Controls.Add(Me.Label2)
        Me.pnlDatosMov.Controls.Add(Me.txtFecha)
        Me.pnlDatosMov.Controls.Add(Me.txtTipo)
        Me.pnlDatosMov.Controls.Add(Me.txtProveedor)
        Me.pnlDatosMov.Controls.Add(Me.txtAutorizado)
        Me.pnlDatosMov.Controls.Add(Me.txtNroOperacion)
        Me.pnlDatosMov.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosMov.Location = New System.Drawing.Point(24, 62)
        Me.pnlDatosMov.Name = "pnlDatosMov"
        Me.pnlDatosMov.Size = New System.Drawing.Size(1046, 177)
        Me.pnlDatosMov.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(642, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tipo"
        '
        'lblProv
        '
        Me.lblProv.AutoSize = True
        Me.lblProv.BackColor = System.Drawing.Color.Transparent
        Me.lblProv.Enabled = False
        Me.lblProv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProv.Location = New System.Drawing.Point(333, 114)
        Me.lblProv.Name = "lblProv"
        Me.lblProv.Size = New System.Drawing.Size(89, 19)
        Me.lblProv.TabIndex = 1
        Me.lblProv.Text = "Proveedor"
        '
        'gbSolicitante
        '
        Me.gbSolicitante.BackColor = System.Drawing.Color.Transparent
        Me.gbSolicitante.Controls.Add(Me.lblSolicita)
        Me.gbSolicitante.Controls.Add(Me.txtSolicita)
        Me.gbSolicitante.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSolicitante.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbSolicitante.Location = New System.Drawing.Point(646, 3)
        Me.gbSolicitante.Name = "gbSolicitante"
        Me.gbSolicitante.Size = New System.Drawing.Size(352, 77)
        Me.gbSolicitante.TabIndex = 9
        Me.gbSolicitante.TabStop = False
        Me.gbSolicitante.Text = "Solicitado por"
        '
        'lblSolicita
        '
        Me.lblSolicita.AutoSize = True
        Me.lblSolicita.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicita.Location = New System.Drawing.Point(24, 32)
        Me.lblSolicita.Name = "lblSolicita"
        Me.lblSolicita.Size = New System.Drawing.Size(77, 19)
        Me.lblSolicita.TabIndex = 1
        Me.lblSolicita.Text = "Sucursal"
        '
        'txtSolicita
        '
        Me.txtSolicita.Enabled = False
        Me.txtSolicita.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicita.Location = New System.Drawing.Point(139, 30)
        Me.txtSolicita.Name = "txtSolicita"
        Me.txtSolicita.ReadOnly = True
        Me.txtSolicita.Size = New System.Drawing.Size(168, 26)
        Me.txtSolicita.TabIndex = 0
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
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(432, 38)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(168, 26)
        Me.txtFecha.TabIndex = 0
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(714, 110)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(168, 26)
        Me.txtTipo.TabIndex = 0
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(432, 110)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(168, 26)
        Me.txtProveedor.TabIndex = 0
        '
        'txtAutorizado
        '
        Me.txtAutorizado.Enabled = False
        Me.txtAutorizado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorizado.Location = New System.Drawing.Point(144, 110)
        Me.txtAutorizado.Name = "txtAutorizado"
        Me.txtAutorizado.ReadOnly = True
        Me.txtAutorizado.Size = New System.Drawing.Size(168, 26)
        Me.txtAutorizado.TabIndex = 0
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Enabled = False
        Me.txtNroOperacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOperacion.Location = New System.Drawing.Point(144, 38)
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.ReadOnly = True
        Me.txtNroOperacion.Size = New System.Drawing.Size(168, 26)
        Me.txtNroOperacion.TabIndex = 0
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToOrderColumns = True
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProductos.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvProductos.Location = New System.Drawing.Point(24, 267)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1046, 325)
        Me.dgvProductos.TabIndex = 37
        '
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.btnSalir)
        Me.pnlOperadores.Controls.Add(Me.btnReporte)
        Me.pnlOperadores.Location = New System.Drawing.Point(685, 637)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(385, 70)
        Me.pnlOperadores.TabIndex = 38
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(208, 16)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(129, 41)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnReporte
        '
        Me.btnReporte.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Location = New System.Drawing.Point(38, 16)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(129, 41)
        Me.btnReporte.TabIndex = 6
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(375, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(384, 36)
        Me.lblTitulo.TabIndex = 39
        Me.lblTitulo.Text = "Listado de Movimientos"
        '
        'DetalleMovimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1193, 742)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pnlOperadores)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.pnlDatosMov)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DetalleMovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleMovimiento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDatosMov.ResumeLayout(False)
        Me.pnlDatosMov.PerformLayout()
        Me.gbSolicitante.ResumeLayout(False)
        Me.gbSolicitante.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOperadores.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDatosMov As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblProv As Label
    Friend WithEvents gbSolicitante As GroupBox
    Friend WithEvents lblSolicita As Label
    Friend WithEvents txtSolicita As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents txtAutorizado As TextBox
    Friend WithEvents txtNroOperacion As TextBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents pnlOperadores As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents lblTitulo As Label
End Class
