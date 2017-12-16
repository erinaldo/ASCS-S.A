<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CobroVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CobroVenta))
        Me.pnlOperadores = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.pnlDatosVenta = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtFechaUlt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaFact = New System.Windows.Forms.TextBox()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPagoEfectivo = New System.Windows.Forms.TextBox()
        Me.pnlCobro = New System.Windows.Forms.Panel()
        Me.pnlCheque = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chbCheque = New System.Windows.Forms.CheckBox()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.txtPagoCheque = New System.Windows.Forms.TextBox()
        Me.pnlEfectivo = New System.Windows.Forms.Panel()
        Me.chbEfectivo = New System.Windows.Forms.CheckBox()
        Me.pnlRecibo = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRecibo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dpChequeFecha = New System.Windows.Forms.DateTimePicker()
        Me.pnlOperadores.SuspendLayout()
        Me.pnlDatosVenta.SuspendLayout()
        Me.pnlCobro.SuspendLayout()
        Me.pnlCheque.SuspendLayout()
        Me.pnlEfectivo.SuspendLayout()
        Me.pnlRecibo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.btnCancelar)
        Me.pnlOperadores.Controls.Add(Me.btnCobrar)
        Me.pnlOperadores.Location = New System.Drawing.Point(132, 474)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(499, 60)
        Me.pnlOperadores.TabIndex = 24
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(273, 18)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(141, 32)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Location = New System.Drawing.Point(78, 18)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(141, 32)
        Me.btnCobrar.TabIndex = 9
        Me.btnCobrar.Text = "Confirmar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'pnlDatosVenta
        '
        Me.pnlDatosVenta.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosVenta.Controls.Add(Me.Label11)
        Me.pnlDatosVenta.Controls.Add(Me.Label7)
        Me.pnlDatosVenta.Controls.Add(Me.Label1)
        Me.pnlDatosVenta.Controls.Add(Me.Label18)
        Me.pnlDatosVenta.Controls.Add(Me.Label5)
        Me.pnlDatosVenta.Controls.Add(Me.txtVendedor)
        Me.pnlDatosVenta.Controls.Add(Me.txtCliente)
        Me.pnlDatosVenta.Controls.Add(Me.Label3)
        Me.pnlDatosVenta.Controls.Add(Me.txtSaldo)
        Me.pnlDatosVenta.Controls.Add(Me.txtFechaUlt)
        Me.pnlDatosVenta.Controls.Add(Me.Label2)
        Me.pnlDatosVenta.Controls.Add(Me.txtFechaFact)
        Me.pnlDatosVenta.Controls.Add(Me.txtFacturaNro)
        Me.pnlDatosVenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosVenta.Location = New System.Drawing.Point(46, 24)
        Me.pnlDatosVenta.Name = "pnlDatosVenta"
        Me.pnlDatosVenta.Size = New System.Drawing.Size(660, 176)
        Me.pnlDatosVenta.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(324, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Vendedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(324, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(324, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Saldo Actual"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(250, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS VENTA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(13, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Último Pago"
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.Location = New System.Drawing.Point(456, 84)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(168, 26)
        Me.txtVendedor.TabIndex = 0
        Me.txtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(456, 42)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(168, 26)
        Me.txtCliente.TabIndex = 0
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(456, 133)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(168, 26)
        Me.txtSaldo.TabIndex = 0
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaUlt
        '
        Me.txtFechaUlt.Enabled = False
        Me.txtFechaUlt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaUlt.Location = New System.Drawing.Point(138, 133)
        Me.txtFechaUlt.Name = "txtFechaUlt"
        Me.txtFechaUlt.ReadOnly = True
        Me.txtFechaUlt.Size = New System.Drawing.Size(168, 26)
        Me.txtFechaUlt.TabIndex = 0
        Me.txtFechaUlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Factura Nº"
        '
        'txtFechaFact
        '
        Me.txtFechaFact.Enabled = False
        Me.txtFechaFact.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFact.Location = New System.Drawing.Point(137, 84)
        Me.txtFechaFact.Name = "txtFechaFact"
        Me.txtFechaFact.ReadOnly = True
        Me.txtFechaFact.Size = New System.Drawing.Size(168, 26)
        Me.txtFechaFact.TabIndex = 0
        Me.txtFechaFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFacturaNro
        '
        Me.txtFacturaNro.Enabled = False
        Me.txtFacturaNro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacturaNro.Location = New System.Drawing.Point(138, 39)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.ReadOnly = True
        Me.txtFacturaNro.Size = New System.Drawing.Size(168, 26)
        Me.txtFacturaNro.TabIndex = 0
        Me.txtFacturaNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(76, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Monto a Cobrar"
        '
        'txtPagoEfectivo
        '
        Me.txtPagoEfectivo.Enabled = False
        Me.txtPagoEfectivo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagoEfectivo.Location = New System.Drawing.Point(49, 53)
        Me.txtPagoEfectivo.Name = "txtPagoEfectivo"
        Me.txtPagoEfectivo.Size = New System.Drawing.Size(193, 26)
        Me.txtPagoEfectivo.TabIndex = 1
        Me.txtPagoEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlCobro
        '
        Me.pnlCobro.Controls.Add(Me.pnlCheque)
        Me.pnlCobro.Controls.Add(Me.pnlEfectivo)
        Me.pnlCobro.Controls.Add(Me.pnlRecibo)
        Me.pnlCobro.Location = New System.Drawing.Point(46, 221)
        Me.pnlCobro.Name = "pnlCobro"
        Me.pnlCobro.Size = New System.Drawing.Size(660, 247)
        Me.pnlCobro.TabIndex = 25
        '
        'pnlCheque
        '
        Me.pnlCheque.Controls.Add(Me.dpChequeFecha)
        Me.pnlCheque.Controls.Add(Me.Label9)
        Me.pnlCheque.Controls.Add(Me.chbCheque)
        Me.pnlCheque.Controls.Add(Me.txtBanco)
        Me.pnlCheque.Controls.Add(Me.Label6)
        Me.pnlCheque.Controls.Add(Me.Label12)
        Me.pnlCheque.Controls.Add(Me.Label8)
        Me.pnlCheque.Controls.Add(Me.txtCheque)
        Me.pnlCheque.Controls.Add(Me.txtPagoCheque)
        Me.pnlCheque.Location = New System.Drawing.Point(297, 19)
        Me.pnlCheque.Name = "pnlCheque"
        Me.pnlCheque.Size = New System.Drawing.Size(349, 207)
        Me.pnlCheque.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(12, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Banco:"
        '
        'chbCheque
        '
        Me.chbCheque.AutoSize = True
        Me.chbCheque.BackColor = System.Drawing.Color.Transparent
        Me.chbCheque.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCheque.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chbCheque.Location = New System.Drawing.Point(15, 3)
        Me.chbCheque.Name = "chbCheque"
        Me.chbCheque.Size = New System.Drawing.Size(82, 22)
        Me.chbCheque.TabIndex = 9
        Me.chbCheque.Text = "Cheque"
        Me.chbCheque.UseVisualStyleBackColor = False
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.Location = New System.Drawing.Point(140, 163)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(191, 25)
        Me.txtBanco.TabIndex = 8
        Me.txtBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(11, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Monto a Cobrar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(12, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cheque Nro:"
        '
        'txtCheque
        '
        Me.txtCheque.Enabled = False
        Me.txtCheque.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(144, 73)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(187, 25)
        Me.txtCheque.TabIndex = 7
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPagoCheque
        '
        Me.txtPagoCheque.Enabled = False
        Me.txtPagoCheque.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagoCheque.Location = New System.Drawing.Point(144, 31)
        Me.txtPagoCheque.Name = "txtPagoCheque"
        Me.txtPagoCheque.Size = New System.Drawing.Size(187, 26)
        Me.txtPagoCheque.TabIndex = 6
        Me.txtPagoCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlEfectivo
        '
        Me.pnlEfectivo.Controls.Add(Me.chbEfectivo)
        Me.pnlEfectivo.Controls.Add(Me.Label4)
        Me.pnlEfectivo.Controls.Add(Me.txtPagoEfectivo)
        Me.pnlEfectivo.Location = New System.Drawing.Point(14, 19)
        Me.pnlEfectivo.Name = "pnlEfectivo"
        Me.pnlEfectivo.Size = New System.Drawing.Size(277, 86)
        Me.pnlEfectivo.TabIndex = 7
        '
        'chbEfectivo
        '
        Me.chbEfectivo.AutoSize = True
        Me.chbEfectivo.BackColor = System.Drawing.Color.Transparent
        Me.chbEfectivo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEfectivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chbEfectivo.Location = New System.Drawing.Point(11, 3)
        Me.chbEfectivo.Name = "chbEfectivo"
        Me.chbEfectivo.Size = New System.Drawing.Size(83, 22)
        Me.chbEfectivo.TabIndex = 9
        Me.chbEfectivo.Text = "Efectivo"
        Me.chbEfectivo.UseVisualStyleBackColor = False
        '
        'pnlRecibo
        '
        Me.pnlRecibo.Controls.Add(Me.Label10)
        Me.pnlRecibo.Controls.Add(Me.txtRecibo)
        Me.pnlRecibo.Location = New System.Drawing.Point(14, 130)
        Me.pnlRecibo.Name = "pnlRecibo"
        Me.pnlRecibo.Size = New System.Drawing.Size(277, 96)
        Me.pnlRecibo.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(90, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Recibo Nro:"
        '
        'txtRecibo
        '
        Me.txtRecibo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecibo.Location = New System.Drawing.Point(30, 38)
        Me.txtRecibo.Name = "txtRecibo"
        Me.txtRecibo.Size = New System.Drawing.Size(222, 26)
        Me.txtRecibo.TabIndex = 2
        Me.txtRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(12, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fecha Cheque:"
        '
        'dpChequeFecha
        '
        Me.dpChequeFecha.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpChequeFecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpChequeFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpChequeFecha.Location = New System.Drawing.Point(140, 119)
        Me.dpChequeFecha.Name = "dpChequeFecha"
        Me.dpChequeFecha.Size = New System.Drawing.Size(191, 26)
        Me.dpChequeFecha.TabIndex = 10
        '
        'CobroVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(757, 565)
        Me.Controls.Add(Me.pnlCobro)
        Me.Controls.Add(Me.pnlOperadores)
        Me.Controls.Add(Me.pnlDatosVenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CobroVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CobroVenta"
        Me.pnlOperadores.ResumeLayout(False)
        Me.pnlDatosVenta.ResumeLayout(False)
        Me.pnlDatosVenta.PerformLayout()
        Me.pnlCobro.ResumeLayout(False)
        Me.pnlCheque.ResumeLayout(False)
        Me.pnlCheque.PerformLayout()
        Me.pnlEfectivo.ResumeLayout(False)
        Me.pnlEfectivo.PerformLayout()
        Me.pnlRecibo.ResumeLayout(False)
        Me.pnlRecibo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlOperadores As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCobrar As Button
    Friend WithEvents pnlDatosVenta As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPagoEfectivo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents txtFechaUlt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaFact As TextBox
    Friend WithEvents txtFacturaNro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents pnlCobro As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCheque As TextBox
    Friend WithEvents pnlRecibo As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRecibo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents pnlEfectivo As Panel
    Friend WithEvents pnlCheque As Panel
    Friend WithEvents chbCheque As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPagoCheque As TextBox
    Friend WithEvents chbEfectivo As CheckBox
    Friend WithEvents dpChequeFecha As DateTimePicker
    Friend WithEvents Label12 As Label
End Class
