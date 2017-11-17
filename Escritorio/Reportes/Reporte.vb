Imports BackEnd

Public Class Reporte
    Public codigoCompra As String
    Public compra As New Compra
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
            objreporte.SetParameterValue("proveedor", movInt.proveedor)
            objreporte.SetParameterValue("fecha", movInt.fecha.ToShortDateString)
            objreporte.SetParameterValue("tipo", movInt.tipo)
            CrystalReportViewer1.ReportSource = objreporte
        End If

    End Sub
End Class