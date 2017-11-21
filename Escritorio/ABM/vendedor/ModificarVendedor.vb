Imports BackEnd

Public Class ModificarVendedor

    Private codigo As String
    Private modelo As Vendedor
    Private daoVend As New VendedorDAO
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        codigo = item
    End Sub

    Private Sub ModificarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SuspendLayout()
            backgroundElementos()
            modelo = daoVend.obtenerVendedor(codigo)
            txtNombre.Text = modelo.nombre
            txtTel.Text = modelo.tel
            cbEstado.SelectedItem = modelo.estado
            cbPorcentaje.SelectedItem = VariablesUtiles.porcentaje(modelo.porcentaje.ToString)
            Me.ResumeLayout()
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub
    Private Sub backgroundElementos()
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
        Panel1.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)

    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtNombre.Text = modelo.nombre
        txtTel.Text = modelo.tel
        cbEstado.SelectedItem = modelo.estado
        cbPorcentaje.SelectedItem = modelo.porcentaje
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then
                Dim modelo2 As New Vendedor
                modelo2.nombre = txtNombre.Text
                modelo2.codigo = codigo
                modelo2.tel = txtTel.Text
                'MsgBox(cbPorcentaje.SelectedIndex)
                modelo2.porcentaje = cbPorcentaje.SelectedIndex + 1
                modelo2.estado = cbEstado.SelectedItem
                daoVend.actualizarVendedor(modelo2)
                MsgBox("Proveedor Modificado!", MsgBoxStyle.Information, "Notificación")
            Else
                MsgBox("Debe llenar todos los campos!", MsgBoxStyle.Exclamation, "Atención")
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Private Function validarDatos()

        'If txtNombre.Text = "" Then
        '    Return False
        'ElseIf txtRUC.Text = "" Then
        '    Return False
        'ElseIf txtTel.Text = "" Then
        '    Return False
        'ElseIf txtContacto.Text = "" Then
        '    Return False
        'End If

        Return True
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub




End Class