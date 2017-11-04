<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarContra
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNueva = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNueva2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlContra = New System.Windows.Forms.Panel()
        Me.pnlContra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(45, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña actual"
        '
        'txtActual
        '
        Me.txtActual.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActual.Location = New System.Drawing.Point(287, 54)
        Me.txtActual.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtActual.Name = "txtActual"
        Me.txtActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtActual.Size = New System.Drawing.Size(263, 26)
        Me.txtActual.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(45, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña Nueva"
        '
        'txtNueva
        '
        Me.txtNueva.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNueva.Location = New System.Drawing.Point(287, 114)
        Me.txtNueva.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNueva.Size = New System.Drawing.Size(263, 26)
        Me.txtNueva.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(45, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Repetir Contraseña"
        '
        'txtNueva2
        '
        Me.txtNueva2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNueva2.Location = New System.Drawing.Point(287, 173)
        Me.txtNueva2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNueva2.Name = "txtNueva2"
        Me.txtNueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNueva2.Size = New System.Drawing.Size(263, 26)
        Me.txtNueva2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(232, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cambiar Contraseña"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(331, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 36)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(147, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlContra
        '
        Me.pnlContra.Controls.Add(Me.Label1)
        Me.pnlContra.Controls.Add(Me.Button2)
        Me.pnlContra.Controls.Add(Me.Label2)
        Me.pnlContra.Controls.Add(Me.Button1)
        Me.pnlContra.Controls.Add(Me.txtNueva)
        Me.pnlContra.Controls.Add(Me.Label3)
        Me.pnlContra.Controls.Add(Me.txtActual)
        Me.pnlContra.Controls.Add(Me.txtNueva2)
        Me.pnlContra.Location = New System.Drawing.Point(53, 74)
        Me.pnlContra.Name = "pnlContra"
        Me.pnlContra.Size = New System.Drawing.Size(623, 362)
        Me.pnlContra.TabIndex = 4
        '
        'CambiarContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(710, 460)
        Me.Controls.Add(Me.pnlContra)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CambiarContra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        Me.pnlContra.ResumeLayout(False)
        Me.pnlContra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtActual As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNueva As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNueva2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnlContra As Panel
End Class
