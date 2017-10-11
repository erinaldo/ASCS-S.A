Imports BackEnd

Public Class AgregarCliente


    Private Sub Panel1_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.BorderStyle = BorderStyle.None

        e.Graphics.DrawRectangle(Pens.White,
                                 e.ClipRectangle.Left,
                                 e.ClipRectangle.Top,
                                 e.ClipRectangle.Width - 1,
                                 e.ClipRectangle.Height - 1)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validarDatos() Then
            Dim modelo As New Cliente
            Dim clienteDAO As New ClienteDAO
            modelo.nombre = txtNombre.Text
            modelo.ruc = txtRUC.Text
            modelo.tel = txtTel.Text
            modelo.contacto = txtContacto.Text
            clienteDAO.agregar(modelo)
            MsgBox("Cliente Agregado!", MsgBoxStyle.Information, "Notificación")
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

    Private Sub AgregarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class