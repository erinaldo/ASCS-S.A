Imports BackEnd

Public Class DetalleCompra
    Dim codigo As String
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        codigo = item
    End Sub

    Private Sub DetalleCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim compraDao As New CompraDAO
        Dim productos = compraDao.cargarPoductosCompra(codigo)
        dgvProductos.DataSource = productos
        dgvProductos.Columns(1).Visible = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.EditMode = False
        dgvProductos.Visible = True
        dgvProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Private Sub cargarDetalle()
        Dim compraDao As New CompraDAO
        Dim compra As New Compra
        compra = compraDao.obtenerCompraDatos(codigo)

        txtFacturaNro.Text = compra.nroFactura
        txtComentario.Text = compra.comentario
        txtFechaCompra.Text = compra.fechaInsFactura
        txtFechaFactura.Text = compra.fechaFactura

        If compra.fechaPagado = Nothing Then
            txtFechaPagado.Text = ""
        Else
            txtFechaPagado.Text = compra.fechaPagado
        End If
        Dim prov As New ProveedorDAO
        Dim proveedor = prov.obtenerProveedor(compra.proveedor)

        txtProveedor.Text = proveedor.descripcion
        txtSaldo.Text = compra.saldo
        txtTipo.Text = compra.tipo
        txtUsuario.Text = compra.usuario

    End Sub

    Private Sub pintarControles()
        pnlComentario.BackColor = Color.FromArgb(80, Color.Black)
        pnlDatosCompra.BackColor = Color.FromArgb(80, Color.Black)
        pnlOperadores.BackColor = Color.FromArgb(80, Color.Black)
    End Sub

    Private Sub centrarControles()
        'txtTituloBusqueda.Left = (Me.ClientSize.Width / 2) - (txtTituloBusqueda.Width / 2)
        'gbBusquedaCompra.Left = (Me.ClientSize.Width / 2) - (gbBusquedaCompra.Width / 2)
        'dgvCompras.Left = (Me.ClientSize.Width / 2) - (dgvCompras.Width / 2)
        pnlDatosCompra.Left = (Me.ClientSize.Width / 2) - (pnlDatosCompra.Width / 2)
        'pnlDatosProducto.Left = (Me.ClientSize.Width / 2) - (pnlDatosProducto.Width / 2)
        pnlComentario.Left = pnlDatosCompra.Left
        lblDetalleCompra.Left = (Me.ClientSize.Width / 2) - (lblDetalleCompra.Width / 2)
        dgvProductos.Left = pnlDatosCompra.Left
        pnlOperadores.Left = pnlDatosCompra.Right - pnlOperadores.Width
        'pnlTotales.Left = pnlDatosCompra.Right - pnlTotales.Width

        ' Anular Compra
        'pnlAnular.Left = (Me.ClientSize.Width / 2) - (pnlAnular.Width / 2)
        'txtTituloAnular.Left = (Me.ClientSize.Width / 2) - (txtTituloAnular.Width / 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim reporte As New ReporteForm
        reporte.codigoCompra = codigo
        reporte.ShowDialog()
        reporte.Dispose()
    End Sub
End Class