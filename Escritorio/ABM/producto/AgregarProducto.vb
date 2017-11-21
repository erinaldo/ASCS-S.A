Imports BackEnd
Public Class AgregarProducto

    Private Sub AgregarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        backgroundElementos()

        Me.ResumeLayout()
    End Sub

    Private Sub backgroundElementos()
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
        Panel1.BackColor = Color.FromArgb(80, Color.Black)
        Panel2.BackColor = Color.FromArgb(80, Color.Black)
        Panel3.BackColor = Color.FromArgb(80, Color.Black)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel


    End Sub

    Private Sub guardarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If validarParametros() Then
            Dim modelo As New Producto
            modelo.codigo = txtCod.Text
            modelo.descripcion = txtDesc.Text
            modelo.espesor = txtEspesor.Text
            modelo.alto = txtAlto.Text
            modelo.largo = txtLargo.Text
            modelo.m2 = txtM2.Text
            modelo.color = cbColor.SelectedItem
            modelo.stock = txtStock.Text
            modelo.venta = txtPrecio.Text


            'Double.TryParse(txtAlto.Text, modelo.alto)
            ' Double.TryParse(txtLargo.Text, modelo.largo)
            ' Double.TryParse(txtM2.Text, modelo.m2)
            modelo.tipo = cbTipo.SelectedItem
            Dim daoProducto As New ProductoDAO
            daoProducto.agregarProducto(modelo)
            MsgBox("Producto agregado con éxito!")
            Me.DialogResult = Windows.Forms.DialogResult.OK


        Else
            MsgBox("Debe completar todos lo campos", MsgBoxStyle.Exclamation, "Atención")
            Me.DialogResult = Windows.Forms.DialogResult.None

        End If
    End Sub

    Private Function validarParametros()
        Dim validar As Boolean = True

        If txtAlto.Text = "" Then
            Return False
        ElseIf txtCod.Text = "" Then
            Return False
        ElseIf cbColor.SelectedItem = "" Then
            Return False
        ElseIf txtDesc.Text = "" Then
            Return False
        ElseIf txtEspesor.Text = "" Then
            Return False
        ElseIf txtLargo.Text = "" Then
            Return False
        ElseIf txtM2.Text = "" Then
            Return False
        ElseIf cbTipo.SelectedItem = "" Then
            Return False
        End If

        Return True

    End Function

    

    

    Private Sub txtEspesor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlto.KeyPress
        ' soloNumeros(e)

    End Sub

    Private Sub txtCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCod.TextChanged, txtStock.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub cbColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbColor.SelectedIndexChanged

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtAlto.Text = ""
        txtCod.Text = ""
        txtDesc.Text = ""
        txtEspesor.Text = ""
        txtLargo.Text = ""
        txtM2.Text = ""
        txtPrecio.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub
End Class