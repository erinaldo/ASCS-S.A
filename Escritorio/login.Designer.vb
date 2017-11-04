<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.lbbienvenida = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lbPasswd = New System.Windows.Forms.Label()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.lbAdvertencia = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlBienvenida = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBienvenida.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbbienvenida
        '
        Me.lbbienvenida.AutoSize = True
        Me.lbbienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lbbienvenida.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbbienvenida.ForeColor = System.Drawing.Color.White
        Me.lbbienvenida.Location = New System.Drawing.Point(166, 9)
        Me.lbbienvenida.Name = "lbbienvenida"
        Me.lbbienvenida.Size = New System.Drawing.Size(268, 30)
        Me.lbbienvenida.TabIndex = 0
        Me.lbbienvenida.Text = "Bienvenido al Sistema"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lbUsuario.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.ForeColor = System.Drawing.Color.White
        Me.lbUsuario.Location = New System.Drawing.Point(37, 25)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(78, 23)
        Me.lbUsuario.TabIndex = 1
        Me.lbUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(41, 51)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(208, 26)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbPasswd
        '
        Me.lbPasswd.AutoSize = True
        Me.lbPasswd.BackColor = System.Drawing.Color.Transparent
        Me.lbPasswd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPasswd.ForeColor = System.Drawing.Color.White
        Me.lbPasswd.Location = New System.Drawing.Point(37, 80)
        Me.lbPasswd.Name = "lbPasswd"
        Me.lbPasswd.Size = New System.Drawing.Size(97, 23)
        Me.lbPasswd.TabIndex = 3
        Me.lbPasswd.Text = "Password"
        '
        'txtPasswd
        '
        Me.txtPasswd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswd.Location = New System.Drawing.Point(41, 106)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd.Size = New System.Drawing.Size(208, 26)
        Me.txtPasswd.TabIndex = 4
        Me.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnIngresar
        '
        Me.btnIngresar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(41, 184)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(94, 32)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'lbAdvertencia
        '
        Me.lbAdvertencia.AutoSize = True
        Me.lbAdvertencia.BackColor = System.Drawing.Color.Transparent
        Me.lbAdvertencia.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdvertencia.ForeColor = System.Drawing.Color.White
        Me.lbAdvertencia.Location = New System.Drawing.Point(26, 151)
        Me.lbAdvertencia.Name = "lbAdvertencia"
        Me.lbAdvertencia.Size = New System.Drawing.Size(255, 18)
        Me.lbAdvertencia.TabIndex = 7
        Me.lbAdvertencia.Text = "Usuario o contraseña incorrectos"
        Me.lbAdvertencia.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(165, 184)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 32)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Escritorio.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'pnlBienvenida
        '
        Me.pnlBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.pnlBienvenida.Controls.Add(Me.btnSalir)
        Me.pnlBienvenida.Controls.Add(Me.txtUsuario)
        Me.pnlBienvenida.Controls.Add(Me.btnIngresar)
        Me.pnlBienvenida.Controls.Add(Me.lbAdvertencia)
        Me.pnlBienvenida.Controls.Add(Me.lbUsuario)
        Me.pnlBienvenida.Controls.Add(Me.txtPasswd)
        Me.pnlBienvenida.Controls.Add(Me.lbPasswd)
        Me.pnlBienvenida.Location = New System.Drawing.Point(257, 60)
        Me.pnlBienvenida.Name = "pnlBienvenida"
        Me.pnlBienvenida.Size = New System.Drawing.Size(305, 239)
        Me.pnlBienvenida.TabIndex = 10
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(591, 329)
        Me.Controls.Add(Me.pnlBienvenida)
        Me.Controls.Add(Me.lbbienvenida)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBienvenida.ResumeLayout(False)
        Me.pnlBienvenida.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbbienvenida As System.Windows.Forms.Label
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lbPasswd As System.Windows.Forms.Label
    Friend WithEvents txtPasswd As System.Windows.Forms.TextBox
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents lbAdvertencia As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlBienvenida As Panel
End Class
