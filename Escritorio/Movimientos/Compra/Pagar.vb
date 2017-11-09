Imports BackEnd

Public Class Pagar
    Dim nroFact, saldo, monto, saldoNuevo As String
    Dim fechaFact, fechaUlt As Date
    Dim daoCompra As New CompraDAO
    Public Sub New(ByVal nro As String, ByVal sald As String, ByVal fecha As Date, ByVal fechau As Date)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        nroFact = nro
        saldo = sald

        fechaFact = fecha
        fechaUlt = fechau
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim pago = CDbl(txtPago.Text)
        If (pago <= CDbl(txtSaldo.Text)) Then
            daoCompra.pagoCompra(txtFacturaNro.Text, pago)
            MsgBox("Pago registrado!")
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("Monto ingresado supera al saldo!", MsgBoxStyle.ApplicationModal, "Notificación")
        End If
    End Sub

    Private Sub Pagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        prepararElementos()
        backgroundElementos()
        txtPago.Focus()
        Me.ResumeLayout()
    End Sub

    Private Sub prepararElementos()
        txtFacturaNro.Text = nroFact
        txtSaldo.Text = saldo
        txtNuevoSaldo.Text = saldoNuevo
        txtFechaFact.Text = fechaFact.ToShortDateString
        If fechaUlt = Nothing Then
            txtFechaUlt.Text = "---"
        Else
            txtFechaUlt.Text = fechaUlt.ToShortDateString
        End If


    End Sub

    Private Sub backgroundElementos()
        pnlDatosCompra.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel

    End Sub
End Class