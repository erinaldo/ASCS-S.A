Imports BackEnd

Public Class ModificarVendedor

    Private codigo As String
    Private modelo As Vendedor
    Private daoVend As New VendedorDAO
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        codigo = item
    End Sub

    Private Sub ModificarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            modelo = daoVend.obtenerVendedor(codigo)
            txtNombre.Text = modelo.nombre
            txtTel.Text = modelo.tel
            cbEstado.SelectedItem = modelo.estado
            cbPorcentaje.SelectedItem = VariablesUtiles.porcentaje(modelo.porcentaje.ToString)
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtNombre.Text = modelo.nombre
        txtTel.Text = modelo.tel
        cbEstado.SelectedItem = modelo.estado
        cbPorcentaje.SelectedItem = modelo.porcentaje
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If validarDatos() Then
                Dim modelo2 As New Vendedor
                modelo2.nombre = txtNombre.Text
                modelo2.codigo = codigo
                modelo2.tel = txtTel.Text
                'MsgBox(cbPorcentaje.SelectedIndex)
                modelo2.porcentaje = cbPorcentaje.SelectedIndex + 1
                modelo2.estado = cbEstado.SelectedItem
                daoVend.actualizarVendedor(modelo2)
                MsgBox("Proveedor Modificado!", MsgBoxStyle.Information, "Notificación")
            Else
                MsgBox("Debe llenar todos los campos!", MsgBoxStyle.Exclamation, "Atención")
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Private Function validarDatos()

        'If txtNombre.Text = "" Then
        '    Return False
        'ElseIf txtRUC.Text = "" Then
        '    Return False
        'ElseIf txtTel.Text = "" Then
        '    Return False
        'ElseIf txtContacto.Text = "" Then
        '    Return False
        'End If

        Return True
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub Panel1_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.BorderStyle = BorderStyle.None

        e.Graphics.DrawRectangle(Pens.White,
                                 e.ClipRectangle.Left,
                                 e.ClipRectangle.Top,
                                 e.ClipRectangle.Width - 1,
                                 e.ClipRectangle.Height - 1)
    End Sub

   
End Class