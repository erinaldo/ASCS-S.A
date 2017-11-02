<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleCompra
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
        Me.pnlDatosCompra = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbTipoPago = New System.Windows.Forms.GroupBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaPagado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaCompra = New System.Windows.Forms.TextBox()
        Me.txtFechaFactura = New System.Windows.Forms.TextBox()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.pnlComentario = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.lblDetalleCompra = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.pnlOperadores = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.pnlDatosCompra.SuspendLayout()
        Me.gbTipoPago.SuspendLayout()
        Me.pnlComentario.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOperadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDatosCompra
        '
        Me.pnlDatosCompra.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosCompra.Controls.Add(Me.Label11)
        Me.pnlDatosCompra.Controls.Add(Me.txtProveedor)
        Me.pnlDatosCompra.Controls.Add(Me.Label18)
        Me.pnlDatosCompra.Controls.Add(Me.gbTipoPago)
        Me.pnlDatosCompra.Controls.Add(Me.Label1)
        Me.pnlDatosCompra.Controls.Add(Me.Label4)
        Me.pnlDatosCompra.Controls.Add(Me.Label3)
        Me.pnlDatosCompra.Controls.Add(Me.txtUsuario)
        Me.pnlDatosCompra.Controls.Add(Me.Label2)
        Me.pnlDatosCompra.Controls.Add(Me.txtFechaCompra)
        Me.pnlDatosCompra.Controls.Add(Me.txtFechaFactura)
        Me.pnlDatosCompra.Controls.Add(Me.txtFacturaNro)
        Me.pnlDatosCompra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosCompra.Location = New System.Drawing.Point(12, 76)
        Me.pnlDatosCompra.Name = "pnlDatosCompra"
        Me.pnlDatosCompra.Size = New System.Drawing.Size(1145, 260)
        Me.pnlDatosCompra.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(357, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Proveedor"
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(532, 46)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(168, 22)
        Me.txtProveedor.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(27, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(166, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS COMPRA"
        '
        'gbTipoPago
        '
        Me.gbTipoPago.BackColor = System.Drawing.Color.Transparent
        Me.gbTipoPago.Controls.Add(Me.txtTipo)
        Me.gbTipoPago.Controls.Add(Me.Label6)
        Me.gbTipoPago.Controls.Add(Me.Label7)
        Me.gbTipoPago.Controls.Add(Me.txtSaldo)
        Me.gbTipoPago.Controls.Add(Me.Label5)
        Me.gbTipoPago.Controls.Add(Me.txtFechaPagado)
        Me.gbTipoPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTipoPago.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbTipoPago.Location = New System.Drawing.Point(734, 17)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(370, 198)
        Me.gbTipoPago.TabIndex = 3
        Me.gbTipoPago.TabStop = False
        Me.gbTipoPago.Text = "Pago"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(130, 36)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(202, 26)
        Me.txtTipo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(6, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(6, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(130, 140)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(202, 26)
        Me.txtSaldo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(6, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Pagado"
        '
        'txtFechaPagado
        '
        Me.txtFechaPagado.Enabled = False
        Me.txtFechaPagado.Location = New System.Drawing.Point(130, 88)
        Me.txtFechaPagado.Name = "txtFechaPagado"
        Me.txtFechaPagado.ReadOnly = True
        Me.txtFechaPagado.Size = New System.Drawing.Size(202, 26)
        Me.txtFechaPagado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(357, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario Dispachante"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(13, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Compra"
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
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(532, 92)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(168, 22)
        Me.txtUsuario.TabIndex = 0
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
        'txtFechaCompra
        '
        Me.txtFechaCompra.Enabled = False
        Me.txtFechaCompra.Location = New System.Drawing.Point(137, 137)
        Me.txtFechaCompra.Name = "txtFechaCompra"
        Me.txtFechaCompra.ReadOnly = True
        Me.txtFechaCompra.Size = New System.Drawing.Size(168, 22)
        Me.txtFechaCompra.TabIndex = 0
        '
        'txtFechaFactura
        '
        Me.txtFechaFactura.Enabled = False
        Me.txtFechaFactura.Location = New System.Drawing.Point(137, 90)
        Me.txtFechaFactura.Name = "txtFechaFactura"
        Me.txtFechaFactura.ReadOnly = True
        Me.txtFechaFactura.Size = New System.Drawing.Size(168, 22)
        Me.txtFechaFactura.TabIndex = 0
        '
        'txtFacturaNro
        '
        Me.txtFacturaNro.Enabled = False
        Me.txtFacturaNro.Location = New System.Drawing.Point(138, 45)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.ReadOnly = True
        Me.txtFacturaNro.Size = New System.Drawing.Size(168, 22)
        Me.txtFacturaNro.TabIndex = 0
        '
        'pnlComentario
        '
        Me.pnlComentario.Controls.Add(Me.Label17)
        Me.pnlComentario.Controls.Add(Me.txtComentario)
        Me.pnlComentario.Location = New System.Drawing.Point(12, 671)
        Me.pnlComentario.Name = "pnlComentario"
        Me.pnlComentario.Size = New System.Drawing.Size(402, 227)
        Me.pnlComentario.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(18, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(230, 22)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Observaciones Compra"
        '
        'txtComentario
        '
        Me.txtComentario.Enabled = False
        Me.txtComentario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario.Location = New System.Drawing.Point(22, 31)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ReadOnly = True
        Me.txtComentario.Size = New System.Drawing.Size(359, 183)
        Me.txtComentario.TabIndex = 5
        Me.txtComentario.Text = ""
        '
        'lblDetalleCompra
        '
        Me.lblDetalleCompra.AutoSize = True
        Me.lblDetalleCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblDetalleCompra.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDetalleCompra.Location = New System.Drawing.Point(392, 22)
        Me.lblDetalleCompra.Name = "lblDetalleCompra"
        Me.lblDetalleCompra.Size = New System.Drawing.Size(219, 32)
        Me.lblDetalleCompra.TabIndex = 22
        Me.lblDetalleCompra.Text = "Detalle Compra"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Enabled = False
        Me.dgvProductos.Location = New System.Drawing.Point(12, 369)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.Size = New System.Drawing.Size(1145, 275)
        Me.dgvProductos.TabIndex = 23
        '
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.btnSalir)
        Me.pnlOperadores.Controls.Add(Me.btnReporte)
        Me.pnlOperadores.Location = New System.Drawing.Point(638, 828)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(385, 70)
        Me.pnlOperadores.TabIndex = 25
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
        'DetalleCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1169, 942)
        Me.Controls.Add(Me.pnlOperadores)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.lblDetalleCompra)
        Me.Controls.Add(Me.pnlComentario)
        Me.Controls.Add(Me.pnlDatosCompra)
        Me.Name = "DetalleCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleCompra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDatosCompra.ResumeLayout(False)
        Me.pnlDatosCompra.PerformLayout()
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.pnlComentario.ResumeLayout(False)
        Me.pnlComentario.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOperadores.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlDatosCompra As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaFactura As TextBox
    Friend WithEvents txtFacturaNro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFechaCompra As TextBox
    Friend WithEvents gbTipoPago As GroupBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaPagado As TextBox
    Friend WithEvents pnlComentario As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents txtComentario As RichTextBox
    Friend WithEvents lblDetalleCompra As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents pnlOperadores As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnReporte As Button
End Class
