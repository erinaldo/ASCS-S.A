Imports BackEnd
Public Class AgregarProducto

    Private Sub AgregarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If validarParametros() Then
            Dim modelo As New Producto
            modelo.codigo = txtCod.Text
            modelo.descripcion = txtDesc.Text
            modelo.espesor = txtEspesor.Text
            modelo.alto = txtAlto.Text
            modelo.largo = txtLargo.Text
            modelo.m2 = txtM2.Text
            'Double.TryParse(txtEspesor.Text, modelo.espesor)
            modelo.color = txtColor.Text
            'Double.TryParse(txtAlto.Text, modelo.alto)
            ' Double.TryParse(txtLargo.Text, modelo.largo)
            ' Double.TryParse(txtM2.Text, modelo.m2)
            modelo.tipo = txtTipo.Text

            Dim daoProducto As New ProductoDAO
            daoProducto.agregarProducto(modelo)
            MsgBox("Producto agregado con éxito!")
            Me.Close()

        Else
            MsgBox("Debe completar todos lo campos", MsgBoxStyle.Exclamation, "Atención")
        End If











    End Sub

    Private Function validarParametros()
        Dim validar As Boolean = True

        If txtAlto.Text = "" Then
            Return False
        ElseIf txtCod.Text = "" Then
            Return False
        ElseIf txtColor.Text = "" Then
            Return False
        ElseIf txtDesc.Text = "" Then
            Return False
        ElseIf txtEspesor.Text = "" Then
            Return False
        ElseIf txtLargo.Text = "" Then
            Return False
        ElseIf txtM2.Text = "" Then
            Return False
        ElseIf txtTipo.Text = "" Then
            Return False
        End If

        Return True

    End Function

    

    

    Private Sub txtEspesor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEspesor.KeyPress
        ' soloNumeros(e)

    End Sub
End Class