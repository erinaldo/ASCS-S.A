Imports System.Windows.Forms
Imports BackEnd

Public Class Inicio

    Dim DT As New DataTable
    Dim target As String = ""

   

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, Panel1.Location.Y)
        Dim pos = Panel1.Location.X - panelBuscar.Location.X

        panelBuscar.Location = New Point(Panel1.Location.X, panelBuscar.Location.Y)
        panelOperaciones.Location = New Point(pos + panelOperaciones.Location.X, panelBuscar.Location.Y)
        panelBuscar.Visible = False
        panelOperaciones.Visible = False
        Panel2.Visible = False



    End Sub

  

    ' hovers
    Private Sub labels_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbProductos.MouseHover, lbVent.MouseHover, lbProv.MouseHover, lbClientes.MouseHover
        sender.BackColor = Color.LightGray


    End Sub

    Private Sub labels_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbProductos.MouseLeave, lbVent.MouseLeave, lbProv.MouseLeave, lbClientes.MouseLeave
        sender.BackColor = Color.White
    End Sub

   
    Private Sub pbProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbProductos.Click
        Dim prod As New ProductoDAO
        DT.Clear()
        panelBuscar.Visible = False
        panelOperaciones.Visible = False
        dgvProductos.DataSource = prod
        dgvProductos.DataSource = Nothing

        Try
            Dim listaProductos = prod.cargar()
            Me.dgvProductos.DataSource = listaProductos.Tables("tabla")
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProductos.AutoResizeColumns()

            dgvProductos.EditMode = False

            Panel2.Location = New Point((Me.Width - Panel2.Width) \ 2, (Me.Height - Panel2.Height + Panel1.Height + panelBuscar.Height) \ 2)

            panelBuscar.Visible = True
            panelOperaciones.Visible = True
            Panel2.Visible = True
            target = "productos"
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    


 
   

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub ListadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProductosList.Click
        Dim prod As New ProductoDAO
        DT.Clear()
        panelBuscar.Visible = False
        panelOperaciones.Visible = False
        dgvProductos.DataSource = prod
        dgvProductos.DataSource = Nothing

        Try
            Dim listaProductos = prod.cargar()
            Me.dgvProductos.DataSource = listaProductos.Tables("tabla")
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProductos.AutoResizeColumns()

            dgvProductos.EditMode = False

            Panel2.Location = New Point((Me.Width - Panel2.Width) \ 2, (Me.Height - Panel2.Height + Panel1.Height + panelBuscar.Height) \ 2)

            panelBuscar.Visible = True
            panelOperaciones.Visible = True
            Panel2.Visible = True
            target = "productos"
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProductoAgregar.Click
        Dim agregarProd As New AgregarProducto

        agregarProd.Show()
    End Sub
End Class
