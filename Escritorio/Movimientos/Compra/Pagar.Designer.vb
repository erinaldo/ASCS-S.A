<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagar))
        Me.pnlDatosCompra = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtNuevoSaldo = New System.Windows.Forms.TextBox()
        Me.txtFechaUlt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaFact = New System.Windows.Forms.TextBox()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.pnlOperadores = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.pnlDatosCompra.SuspendLayout()
        Me.pnlOperadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDatosCompra
        '
        Me.pnlDatosCompra.BackColor = System.Drawing.Color.Transparent
        Me.pnlDatosCompra.Controls.Add(Me.Label18)
        Me.pnlDatosCompra.Controls.Add(Me.Label6)
        Me.pnlDatosCompra.Controls.Add(Me.Label5)
        Me.pnlDatosCompra.Controls.Add(Me.Label3)
        Me.pnlDatosCompra.Controls.Add(Me.Label4)
        Me.pnlDatosCompra.Controls.Add(Me.txtPago)
        Me.pnlDatosCompra.Controls.Add(Me.Label1)
        Me.pnlDatosCompra.Controls.Add(Me.txtSaldo)
        Me.pnlDatosCompra.Controls.Add(Me.txtNuevoSaldo)
        Me.pnlDatosCompra.Controls.Add(Me.txtFechaUlt)
        Me.pnlDatosCompra.Controls.Add(Me.Label2)
        Me.pnlDatosCompra.Controls.Add(Me.txtFechaFact)
        Me.pnlDatosCompra.Controls.Add(Me.txtFacturaNro)
        Me.pnlDatosCompra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDatosCompra.Location = New System.Drawing.Point(31, 48)
        Me.pnlDatosCompra.Name = "pnlDatosCompra"
        Me.pnlDatosCompra.Size = New System.Drawing.Size(636, 176)
        Me.pnlDatosCompra.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(12, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(166, 23)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "DATOS COMPRA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(320, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nuevo Saldo"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(319, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Monto a Pagar"
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(444, 84)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(168, 26)
        Me.txtPago.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(319, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Saldo Actual"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(444, 39)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(168, 26)
        Me.txtSaldo.TabIndex = 0
        '
        'txtNuevoSaldo
        '
        Me.txtNuevoSaldo.Enabled = False
        Me.txtNuevoSaldo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoSaldo.Location = New System.Drawing.Point(444, 129)
        Me.txtNuevoSaldo.Name = "txtNuevoSaldo"
        Me.txtNuevoSaldo.ReadOnly = True
        Me.txtNuevoSaldo.Size = New System.Drawing.Size(168, 26)
        Me.txtNuevoSaldo.TabIndex = 0
        '
        'txtFechaUlt
        '
        Me.txtFechaUlt.Enabled = False
        Me.txtFechaUlt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaUlt.Location = New System.Drawing.Point(137, 129)
        Me.txtFechaUlt.Name = "txtFechaUlt"
        Me.txtFechaUlt.ReadOnly = True
        Me.txtFechaUlt.Size = New System.Drawing.Size(168, 26)
        Me.txtFechaUlt.TabIndex = 0
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
        '
        'pnlOperadores
        '
        Me.pnlOperadores.Controls.Add(Me.btnCancelar)
        Me.pnlOperadores.Controls.Add(Me.btnPagar)
        Me.pnlOperadores.Location = New System.Drawing.Point(106, 268)
        Me.pnlOperadores.Name = "pnlOperadores"
        Me.pnlOperadores.Size = New System.Drawing.Size(499, 100)
        Me.pnlOperadores.TabIndex = 22
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(291, 46)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(138, 32)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(62, 46)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(181, 32)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Confirmar Pago"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'Pagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(689, 403)
        Me.Controls.Add(Me.pnlOperadores)
        Me.Controls.Add(Me.pnlDatosCompra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagar"
        Me.pnlDatosCompra.ResumeLayout(False)
        Me.pnlDatosCompra.PerformLayout()
        Me.pnlOperadores.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDatosCompra As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFacturaNro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPago As TextBox
    Friend WithEvents txtFechaFact As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNuevoSaldo As TextBox
    Friend WithEvents txtFechaUlt As TextBox
    Friend WithEvents pnlOperadores As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnPagar As Button
End Class
