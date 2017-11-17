<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoMovimientoInt
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
        Me.pnlListado = New System.Windows.Forms.Panel()
        Me.txtNroFacturaListado = New System.Windows.Forms.TextBox()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnBuscarCompra = New System.Windows.Forms.Button()
        Me.lblBusqTxt = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.cbBuscarMovInt = New System.Windows.Forms.ComboBox()
        Me.pnlRangoFecha = New System.Windows.Forms.Panel()
        Me.datepFin = New System.Windows.Forms.DateTimePicker()
        Me.datepInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvMovInt = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.pnlListado.SuspendLayout()
        Me.pnlRangoFecha.SuspendLayout()
        CType(Me.dgvMovInt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlListado
        '
        Me.pnlListado.Controls.Add(Me.btnAnular)
        Me.pnlListado.Controls.Add(Me.txtNroFacturaListado)
        Me.pnlListado.Controls.Add(Me.btnDetalle)
        Me.pnlListado.Controls.Add(Me.btnBuscarCompra)
        Me.pnlListado.Controls.Add(Me.lblBusqTxt)
        Me.pnlListado.Controls.Add(Me.Label15)
        Me.pnlListado.Controls.Add(Me.cbProveedor)
        Me.pnlListado.Controls.Add(Me.cbBuscarMovInt)
        Me.pnlListado.Controls.Add(Me.pnlRangoFecha)
        Me.pnlListado.Location = New System.Drawing.Point(86, 88)
        Me.pnlListado.Name = "pnlListado"
        Me.pnlListado.Size = New System.Drawing.Size(910, 189)
        Me.pnlListado.TabIndex = 6
        '
        'txtNroFacturaListado
        '
        Me.txtNroFacturaListado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroFacturaListado.Location = New System.Drawing.Point(369, 58)
        Me.txtNroFacturaListado.Name = "txtNroFacturaListado"
        Me.txtNroFacturaListado.Size = New System.Drawing.Size(262, 26)
        Me.txtNroFacturaListado.TabIndex = 8
        '
        'btnDetalle
        '
        Me.btnDetalle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDetalle.Location = New System.Drawing.Point(605, 131)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(111, 30)
        Me.btnDetalle.TabIndex = 11
        Me.btnDetalle.Text = "Ver Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = True
        Me.btnDetalle.Visible = False
        '
        'btnBuscarCompra
        '
        Me.btnBuscarCompra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCompra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscarCompra.Location = New System.Drawing.Point(722, 131)
        Me.btnBuscarCompra.Name = "btnBuscarCompra"
        Me.btnBuscarCompra.Size = New System.Drawing.Size(108, 30)
        Me.btnBuscarCompra.TabIndex = 3
        Me.btnBuscarCompra.Text = "Buscar"
        Me.btnBuscarCompra.UseVisualStyleBackColor = True
        '
        'lblBusqTxt
        '
        Me.lblBusqTxt.AutoSize = True
        Me.lblBusqTxt.BackColor = System.Drawing.Color.Transparent
        Me.lblBusqTxt.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBusqTxt.Location = New System.Drawing.Point(364, 27)
        Me.lblBusqTxt.Name = "lblBusqTxt"
        Me.lblBusqTxt.Size = New System.Drawing.Size(262, 27)
        Me.lblBusqTxt.TabIndex = 10
        Me.lblBusqTxt.Text = "Inserte Nro. Movimiento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(12, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 27)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Buscar por"
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(66, 135)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(262, 26)
        Me.cbProveedor.TabIndex = 9
        Me.cbProveedor.Visible = False
        '
        'cbBuscarMovInt
        '
        Me.cbBuscarMovInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscarMovInt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBuscarMovInt.FormattingEnabled = True
        Me.cbBuscarMovInt.Location = New System.Drawing.Point(144, 56)
        Me.cbBuscarMovInt.Name = "cbBuscarMovInt"
        Me.cbBuscarMovInt.Size = New System.Drawing.Size(184, 27)
        Me.cbBuscarMovInt.TabIndex = 6
        '
        'pnlRangoFecha
        '
        Me.pnlRangoFecha.BackColor = System.Drawing.Color.Transparent
        Me.pnlRangoFecha.Controls.Add(Me.datepFin)
        Me.pnlRangoFecha.Controls.Add(Me.datepInicio)
        Me.pnlRangoFecha.Controls.Add(Me.Label14)
        Me.pnlRangoFecha.Controls.Add(Me.Label13)
        Me.pnlRangoFecha.Location = New System.Drawing.Point(355, 12)
        Me.pnlRangoFecha.Name = "pnlRangoFecha"
        Me.pnlRangoFecha.Size = New System.Drawing.Size(494, 100)
        Me.pnlRangoFecha.TabIndex = 7
        '
        'datepFin
        '
        Me.datepFin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepFin.Location = New System.Drawing.Point(265, 46)
        Me.datepFin.Name = "datepFin"
        Me.datepFin.Size = New System.Drawing.Size(200, 27)
        Me.datepFin.TabIndex = 0
        '
        'datepInicio
        '
        Me.datepInicio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepInicio.Location = New System.Drawing.Point(35, 46)
        Me.datepInicio.Name = "datepInicio"
        Me.datepInicio.Size = New System.Drawing.Size(200, 27)
        Me.datepInicio.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(260, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 27)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Hasta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(30, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 27)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Desde"
        '
        'dgvMovInt
        '
        Me.dgvMovInt.AllowUserToAddRows = False
        Me.dgvMovInt.AllowUserToDeleteRows = False
        Me.dgvMovInt.AllowUserToOrderColumns = True
        Me.dgvMovInt.AllowUserToResizeColumns = False
        Me.dgvMovInt.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMovInt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvMovInt.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovInt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMovInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovInt.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMovInt.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvMovInt.Location = New System.Drawing.Point(86, 317)
        Me.dgvMovInt.Name = "dgvMovInt"
        Me.dgvMovInt.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovInt.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvMovInt.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvMovInt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovInt.Size = New System.Drawing.Size(910, 178)
        Me.dgvMovInt.TabIndex = 36
        Me.dgvMovInt.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(403, 27)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(384, 36)
        Me.lblTitulo.TabIndex = 37
        Me.lblTitulo.Text = "Listado de Movimientos"
        '
        'btnAnular
        '
        Me.btnAnular.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.Location = New System.Drawing.Point(490, 131)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(109, 30)
        Me.btnAnular.TabIndex = 12
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseVisualStyleBackColor = True
        Me.btnAnular.Visible = False
        '
        'ListadoMovimientoInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1140, 608)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dgvMovInt)
        Me.Controls.Add(Me.pnlListado)
        Me.Name = "ListadoMovimientoInt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListadoMovimientoInt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlListado.ResumeLayout(False)
        Me.pnlListado.PerformLayout()
        Me.pnlRangoFecha.ResumeLayout(False)
        Me.pnlRangoFecha.PerformLayout()
        CType(Me.dgvMovInt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlListado As Panel
    Friend WithEvents txtNroFacturaListado As TextBox
    Friend WithEvents btnDetalle As Button
    Friend WithEvents btnBuscarCompra As Button
    Friend WithEvents lblBusqTxt As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents cbBuscarMovInt As ComboBox
    Friend WithEvents pnlRangoFecha As Panel
    Friend WithEvents datepFin As DateTimePicker
    Friend WithEvents datepInicio As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvMovInt As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAnular As Button
End Class
