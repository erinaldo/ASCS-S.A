Imports BackEnd

Public Class Reporte
    Public codigoCompra As String
    Public compra As New Compra
    Public venta As New Venta
    Public movInt As New BackEnd.MovimientoInterno
    Public tipo As String = ""
    Private Sub ReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If tipo = "compra" Then
            Dim objreporte As New rpDetalleCompraCod
            objreporte.SetParameterValue("codigo", codigoCompra)
            objreporte.SetParameterValue("proveedor", compra.proveedor)
            objreporte.SetParameterValue("estado", compra.estado)
            objreporte.SetParameterValue("fechaCompra", compra.fechaInsFactura.ToString)

            If compra.fechaPagado = Nothing Then
                objreporte.SetParameterValue("fechaPagado", "- - -")
            Else
                objreporte.SetParameterValue("fechaPagado", compra.fechaPagado.ToString)
            End If

            If compra.fechaActualizacion = Nothing Then
                objreporte.SetParameterValue("ultAct", "- - -")
            Else
                objreporte.SetParameterValue("ultAct", compra.fechaActualizacion.ToString)
            End If

            If compra.fechaAnulacion = Nothing Then
                objreporte.SetParameterValue("fechaAnulacion", "- - -")
            Else
                objreporte.SetParameterValue("fechaAnulacion", compra.fechaAnulacion.ToString)
            End If


            objreporte.SetParameterValue("tipoFactura", compra.tipo)
            objreporte.SetParameterValue("usuario", compra.usuario)
            objreporte.SetParameterValue("nroFactura", compra.nroFactura)
            CrystalReportViewer1.ReportSource = objreporte
        ElseIf tipo = "movInt" Then
            Dim objreporte As New rpMovInterno
            objreporte.SetParameterValue("codigo", movInt.nroMov)
            objreporte.SetParameterValue("autorizado", movInt.autorizado)
            objreporte.SetParameterValue("solicitado", movInt.solicitante)
            Dim daomovin As New MovInternoDAO
            Dim prov
            If movInt.tipo = "Depos" Then
                prov = daomovin.buscarDeposito(movInt.proveedor)

            Else
                prov = daomovin.buscarSolicitante(movInt.proveedor)

            End If
            objreporte.SetParameterValue("proveedor", prov)
            objreporte.SetParameterValue("fecha", movInt.fecha.ToShortDateString)
            objreporte.SetParameterValue("tipo", movInt.tipo)
            CrystalReportViewer1.ReportSource = objreporte
        ElseIf tipo = "venta" Then
            Dim objreporte As New rpVenta
            Dim daoVenta As New VentaDAO
            Dim daoVendedor As New VendedorDAO
            Dim vendedor = daoVenta.obtenerVendedor(venta.vendedor)
            Dim cliente = daoVenta.obtenerCliente(venta.cliente)
            objreporte.SetParameterValue("codigo", venta.codigo.ToString)
            objreporte.SetParameterValue("cliente", cliente.nombre)
            objreporte.SetParameterValue("vendedor", vendedor.nombre)
            objreporte.SetParameterValue("NroFactura", venta.nroFactura.ToString)
            objreporte.SetParameterValue("fecha", venta.fechaFactura.ToShortDateString)
            objreporte.SetParameterValue("tipo", venta.tipo)
            objreporte.SetParameterValue("saldo", venta.saldo.ToString)
            objreporte.SetParameterValue("descuento", venta.descuento)
            'objreporte.SetParameterValue("proveedor", prov)
            'objreporte.SetParameterValue("fecha", movInt.fecha.ToShortDateString)
            'objreporte.SetParameterValue("tipo", movInt.tipo)
            CrystalReportViewer1.ReportSource = objreporte
        End If

    End Sub
End Class