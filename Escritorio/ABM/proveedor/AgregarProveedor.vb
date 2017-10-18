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

   
End Class