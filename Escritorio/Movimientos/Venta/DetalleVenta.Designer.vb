﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleVenta))
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.gbTipoPago = New System.Windows.Forms.GroupBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaPagado = New System.Windows.Forms.TextBox()
        Me.pnlOperadores = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.lblDetalleCompra = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.RichTextBox()
        Me.pnlComentario = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaVenta = New System.Windows.Forms.TextBox()
        Me.txtFechaFactura = New System.Windows.Forms.TextBox()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.pnlDatosVenta = New System.Windows.Forms.Panel()
        Me.gbTipoPago.SuspendLayout()
        Me.pnlOperadores.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComentario.SuspendLayout()
        Me.pnlDatosVenta.SuspendLayout()
        Me.SuspendLayout()
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(382, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(488, 48)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(168, 22)
        Me.txtCliente.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(27, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS VENTA"
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
        Me.gbTipoPago.Location = New System.Drawing.Point(734, 3)
        Me.gbTipoPago.Name = "gbTipoPago"
        Me.gbTipoPago.Size = New System.Drawing.Size(370, 184)
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
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.btnSalir)
        Me.pnlOperadores.Controls.Add(Me.btnReporte)
        Me.pnlOperadores.Location = New System.Drawing.Point(777, 605)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(385, 70)
        Me.pnlOperadores.TabIndex = 30
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
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Enabled = False
        Me.dgvProductos.Location = New System.Drawing.Point(33, 312)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.ShowEditingIcon = False
        Me.dgvProductos.Size = New System.Drawing.Size(1145, 275)
        Me.dgvProductos.TabIndex = 29
        '
        'lblDetalleCompra
        '
        Me.lblDetalleCompra.AutoSize = True
        Me.lblDetalleCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblDetalleCompra.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalleCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDetalleCompra.Location = New System.Drawing.Point(413, 33)
        Me.lblDetalleCompra.Name = "lblDetalleCompra"
        Me.lblDetalleCompra.Size = New System.Drawing.Size(186, 32)
        Me.lblDetalleCompra.TabIndex = 28
        Me.lblDetalleCompra.Text = "Detalle Venta"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(18, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(208, 22)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Observaciones Venta"
        '
        'txtComentario
        '
        Me.txtComentario.Enabled = False
        Me.txtComentario.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario.Location = New System.Drawing.Point(22, 31)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ReadOnly = True
        Me.txtComentario.Size = New System.Drawing.Size(359, 68)
        Me.txtComentario.TabIndex = 5
        Me.txtComentario.Text = ""
        '
        'pnlComentario
        '
        Me.pnlComentario.Controls.Add(Me.Label17)
        Me.pnlComentario.Controls.Add(Me.txtComentario)
        Me.pnlComentario.Location = New System.Drawing.Point(33, 605)
        Me.pnlComentario.Name = "pnlComentario"
        Me.pnlComentario.Size = New System.Drawing.Size(405, 112)
        Me.pnlComentario.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(382, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Vendedor"
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
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Venta"
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
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Location = New System.Drawing.Point(488, 91)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(168, 22)
        Me.txtVendedor.TabIndex = 0
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
        'txtFechaVenta
        '
        Me.txtFechaVenta.Enabled = False
        Me.txtFechaVenta.Location = New System.Drawing.Point(137, 137)
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.ReadOnly = True
        Me.txtFechaVenta.Size = New System.Drawing.Size(168, 22)
        Me.txtFechaVenta.TabIndex = 0
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
        'pnlDatosVenta
        '
        Me.pnlDatosVenta.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosVenta.Controls.Add(Me.Label11)
        Me.pnlDatosVenta.Controls.Add(Me.txtCliente)
        Me.pnlDatosVenta.Controls.Add(Me.Label18)
        Me.pnlDatosVenta.Controls.Add(Me.gbTipoPago)
        Me.pnlDatosVenta.Controls.Add(Me.Label1)
        Me.pnlDatosVenta.Controls.Add(Me.Label4)
        Me.pnlDatosVenta.Controls.Add(Me.Label3)
        Me.pnlDatosVenta.Controls.Add(Me.txtVendedor)
        Me.pnlDatosVenta.Controls.Add(Me.Label2)
        Me.pnlDatosVenta.Controls.Add(Me.txtFechaVenta)
        Me.pnlDatosVenta.Controls.Add(Me.txtFechaFactura)
        Me.pnlDatosVenta.Controls.Add(Me.txtFacturaNro)
        Me.pnlDatosVenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosVenta.Location = New System.Drawing.Point(33, 69)
        Me.pnlDatosVenta.Name = "pnlDatosVenta"
        Me.pnlDatosVenta.Size = New System.Drawing.Size(1145, 210)
        Me.pnlDatosVenta.TabIndex = 27
        '
        'DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1210, 750)
        Me.Controls.Add(Me.pnlOperadores)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.lblDetalleCompra)
        Me.Controls.Add(Me.pnlComentario)
        Me.Controls.Add(Me.pnlDatosVenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbTipoPago.ResumeLayout(False)
        Me.gbTipoPago.PerformLayout()
        Me.pnlOperadores.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComentario.ResumeLayout(False)
        Me.pnlComentario.PerformLayout()
        Me.pnlDatosVenta.ResumeLayout(False)
        Me.pnlDatosVenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReporte As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents gbTipoPago As GroupBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaPagado As TextBox
    Friend WithEvents pnlOperadores As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents lblDetalleCompra As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtComentario As RichTextBox
    Friend WithEvents pnlComentario As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaVenta As TextBox
    Friend WithEvents txtFechaFactura As TextBox
    Friend WithEvents txtFacturaNro As TextBox
    Friend WithEvents pnlDatosVenta As Panel
End Class
