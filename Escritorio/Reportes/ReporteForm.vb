Imports BackEnd

Public Class ReporteForm
    Public codigoCompra As String
    Public compra As New Compra
    Private Sub ReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub
End Class