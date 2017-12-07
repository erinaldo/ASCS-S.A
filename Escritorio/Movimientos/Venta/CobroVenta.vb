Imports BackEnd

Public Class CobroVenta
    Public cliente = ""
    Public vendedor = ""
    Public venta As New Venta
    Private Sub CobroVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        prepararElementos()
        backgroundElementos()
        txtPagoEfectivo.Focus()
        Me.ResumeLayout()
    End Sub
    Private Sub prepararElementos()
        txtFacturaNro.Text = venta.nroFactura
        txtSaldo.Text = FormatCurrency(venta.saldo)

        txtFechaFact.Text = venta.fechaFactura.ToShortDateString
        txtVendedor.Text = vendedor
        Dim daoventa As New VentaDAO
        txtCliente.Text = cliente
        If venta.fechaActualizacion = Nothing Then
            txtFechaUlt.Text = "---"
        Else
            txtFechaUlt.Text = venta.fechaActualizacion.ToShortDateString
        End If


    End Sub

    Private Sub backgroundElementos()
        pnlDatosVenta.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        pnlCobro.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel

    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label6.Click

    End Sub



    Private Sub txtPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagoEfectivo.KeyPress, txtPagoCheque.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub chbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbEfectivo.CheckedChanged
        Me.SuspendLayout()
        If chbEfectivo.Checked = True Then
            txtPagoEfectivo.Enabled = True
            txtPagoEfectivo.Focus()
        Else
            txtPagoEfectivo.Text = ""
            txtPagoEfectivo.Enabled = False
        End If
        Me.ResumeLayout()
    End Sub

    Private Sub chbCheque_CheckedChanged(sender As Object, e As EventArgs) Handles chbCheque.CheckedChanged
        Me.SuspendLayout()

        If chbCheque.Checked = True Then
            txtPagoCheque.Enabled = True
            txtPagoCheque.Focus()
            txtCheque.Enabled = True
            txtBanco.Enabled = True
        Else
            txtPagoCheque.Enabled = False
            txtPagoCheque.Text = ""
            txtCheque.Enabled = False
            txtCheque.Text = ""
            txtBanco.Enabled = False
            txtBanco.Text = ""
        End If
        Me.ResumeLayout()
    End Sub

    Private Sub pnlCheque_Paint(sender As Object, e As PaintEventArgs) Handles pnlCheque.Paint

    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click

    End Sub
End Class