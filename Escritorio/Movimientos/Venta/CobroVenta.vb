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
        If cajaAbierta() = False Then
            MsgBox("Caja cerrada", MsgBoxStyle.Information, "Caja")
            desactivarControles()
        End If

    End Sub
    Private Sub desactivarControles()
        pnlDatosVenta.Enabled = False
        pnlCobro.Enabled = False
        btnCobrar.Enabled = False

    End Sub
    Private Function cajaAbierta()
        Dim daoVenta As New VentaDAO
        Return daoVenta.confirmarCaja()
    End Function
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
            dpChequeFecha.Enabled = True
        Else
            txtPagoCheque.Enabled = False
            txtPagoCheque.Text = ""
            txtCheque.Enabled = False
            txtCheque.Text = ""
            txtBanco.Enabled = False
            txtBanco.Text = ""
            dpChequeFecha.Enabled = False
        End If
        Me.ResumeLayout()
    End Sub

    Private Sub pnlCheque_Paint(sender As Object, e As PaintEventArgs) Handles pnlCheque.Paint

    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Dim tipo = 11
        Try
            If validarCobro() Then
                Dim cobro As New Cobro
                If chbCheque.Checked = True And chbEfectivo.Checked = True Then
                    cobro.tipo = 2
                    cobro.efectivo = CDbl(txtPagoEfectivo.Text)
                    cobro.cheque = CDbl(txtPagoCheque.Text)
                    cobro.chequeNro = txtCheque.Text
                    cobro.banco = txtBanco.Text
                    cobro.fechaCheque = dpChequeFecha.Value
                Else
                    If chbEfectivo.Checked = True Then
                        cobro.tipo = 0
                        cobro.efectivo = CDbl(txtPagoEfectivo.Text)
                    End If
                    If chbCheque.Checked = True Then
                        cobro.tipo = 1
                        cobro.cheque = CDbl(txtPagoCheque.Text)
                        cobro.chequeNro = txtCheque.Text
                        cobro.banco = txtBanco.Text
                        cobro.fechaCheque = dpChequeFecha.Value
                    End If
                End If




                cobro.cliente = venta.cliente
                cobro.recibo = txtRecibo.Text
                Dim daoVenta As New VentaDAO
                daoVenta.cobrar(cobro, venta.codigo)
                MsgBox("¡Pago realizado con éxito!")
                Me.DialogResult = DialogResult.OK
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Function validarCobro()
        If chbCheque.Checked = False And chbEfectivo.Checked = False Then
            MsgBox("¡Seleccione un tipo de pago!", MsgBoxStyle.Critical, "Error pago")
            Return False
        End If

        If chbCheque.Checked = True Then
            If txtBanco.Text = "" Or txtCheque.Text = "" Or txtPagoCheque.Text = "" Then
                MsgBox("¡Complete los datos del pago via cheque!", MsgBoxStyle.Critical, "Faltan parámetros")
                txtPagoCheque.Focus()
                Return False
            End If
        End If

        If chbEfectivo.Checked = True Then
            If txtPagoEfectivo.Text = "" Then
                MsgBox("¡Complete los datos del pago via efectivo!", MsgBoxStyle.Critical, "Faltan parámetros")
                txtPagoEfectivo.Focus()
                Return False
            End If
        End If

        If txtRecibo.Text = "" Then
            MsgBox("¡Debe ingresar un número de recibo!", MsgBoxStyle.Critical, "Faltan parámetros")
            txtRecibo.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub txtPagoEfectivo_LostFocus(sender As Object, e As EventArgs) Handles txtPagoEfectivo.LostFocus
        If txtPagoEfectivo.Text <> "" Then
            txtPagoEfectivo.Text = FormatCurrency(txtPagoEfectivo.Text)
        End If
    End Sub

    Private Sub txtPagoCheque_LostFocus(sender As Object, e As EventArgs) Handles txtPagoCheque.LostFocus
        If txtPagoCheque.Text <> "" Then
            txtPagoCheque.Text = FormatCurrency(txtPagoCheque.Text)
        End If
    End Sub
End Class