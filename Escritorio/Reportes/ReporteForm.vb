Public Class ReporteForm
    Public codigoCompra As String

    Private Sub ReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objreporte As New rpDetalleCompraCod
        objreporte.SetParameterValue("codigo", codigoCompra)
        objreporte.SetParameterValue("prueba", 23)
        CrystalReportViewer1.ReportSource = objreporte
    End Sub
End Class