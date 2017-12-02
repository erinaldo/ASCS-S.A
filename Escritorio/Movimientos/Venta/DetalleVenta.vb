Imports BackEnd

Public Class DetalleVenta
    Dim codigo As String
    Dim venta As New Venta
    Dim provaux As String
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        codigo = item
    End Sub

    Private Sub DetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()

        pintarControles()
        centrarControles()
        cargarDetalle()
        cargarProductosDetalle()
        Me.ResumeLayout()

        Me.BackgroundImageLayout = ImageLayout.Center
        Me.BackgroundImage = My.Resources.Panther1
    End Sub

    Private Sub cargarProductosDetalle()
        Dim ventaDao As New VentaDAO
        Dim productos = ventaDao.cargarPoductosVenta(codigo)
        dgvProductos.DataSource = productos
        dgvProductos.Columns(0).Visible = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders

        dgvProductos.EditMode = False
        dgvProductos.Visible = True
        dgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgvProductos.ClearSelection()
    End Sub

    Private Sub cargarDetalle()
        Dim ventaDao As New VentaDAO

        venta = ventaDao.obtenerVentaDatos(codigo)

        txtFacturaNro.Text = venta.nroFactura
        txtComentario.Text = venta.comentario
        txtFechaVenta.Text = venta.fechaInsFactura.ToShortDateString
        txtFechaFactura.Text = venta.fechaFactura.ToShortDateString

        If venta.fechaPagado = Nothing Then
            txtFechaPagado.Text = ""
        Else
            txtFechaPagado.Text = venta.fechaPagado.ToShortDateString
        End If
        Dim client As New ClienteDAO
        Dim cliente = client.obtenerCliente(venta.cliente)
        txtCliente.Text = cliente.nombre
        txtSaldo.Text = venta.saldo
        txtTipo.Text = venta.tipo
        Dim vendedor As New VendedorDAO
        Dim vend = vendedor.obtenerVendedor(venta.vendedor)
        txtVendedor.Text = vend.nombre

    End Sub

    Private Sub pintarControles()
        pnlComentario.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosVenta.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
        Label1.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
    End Sub

    Private Sub centrarControles()
        'txtTituloBusqueda.Left = (Me.ClientSize.Width / 2) - (txtTituloBusqueda.Width / 2)
        'gbBusquedaCompra.Left = (Me.ClientSize.Width / 2) - (gbBusquedaCompra.Width / 2)
        'dgvCompras.Left = (Me.ClientSize.Width / 2) - (dgvCompras.Width / 2)
        pnlDatosVenta.Left = (Me.ClientSize.Width / 2) - (pnlDatosVenta.Width / 2)
        'pnlDatosProducto.Left = (Me.ClientSize.Width / 2) - (pnlDatosProducto.Width / 2)
        pnlComentario.Left = pnlDatosVenta.Left
        lblDetalleCompra.Left = (Me.ClientSize.Width / 2) - (lblDetalleCompra.Width / 2)
        dgvProductos.Left = pnlDatosVenta.Left
        pnlOperadores.Left = pnlDatosVenta.Right - pnlOperadores.Width
        'pnlTotales.Left = pnlDatosCompra.Right - pnlTotales.Width

        ' Anular Compra
        'pnlAnular.Left = (Me.ClientSize.Width / 2) - (pnlAnular.Width / 2)
        'txtTituloAnular.Left = (Me.ClientSize.Width / 2) - (txtTituloAnular.Width / 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim reporte As New Reporte
        'reporte.codigoCompra = codigo
        reporte.tipo = "venta"
        reporte.venta = venta
        'reporte.compra.proveedor = provaux
        reporte.ShowDialog()
        reporte.Dispose()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub


End Class