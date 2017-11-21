Imports BackEnd

Public Class AgregarProveedor


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validarDatos() Then
            Dim modelo As New Proveedor
            Dim provDAO As New ProveedorDAO
            modelo.descripcion = txtNombre.Text
            modelo.ruc = txtRUC.Text
            modelo.tel = txtTel.Text
            modelo.contacto = txtContacto.Text
            modelo.fecha = Date.Now.Date
            provDAO.agregar(modelo)
            MsgBox("Proveedor Agregado!", MsgBoxStyle.Information, "Notificación")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Debe llenar todos los campos!", MsgBoxStyle.Exclamation, "Atención")
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If

    End Sub

    Private Function validarDatos()

        If txtNombre.Text = "" Then
            Return False
        ElseIf txtRUC.Text = "" Then
            Return False
        ElseIf txtTel.Text = "" Then
            Return False
        ElseIf txtContacto.Text = "" Then
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtNombre.Text = ""

        txtRUC.Text = ""

        txtTel.Text = ""

        txtContacto.Text = ""
    End Sub

    Private Sub AgregarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        backgroundElementos()
    End Sub
    Private Sub backgroundElementos()
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
        Panel1.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)

    End Sub
End Class