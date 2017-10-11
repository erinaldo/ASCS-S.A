Imports System.Windows.Forms
Imports BackEnd

Public Class Inicio

    Dim DT As New DataTable
    Dim target As String = ""

   
    'Carga del Formulario de Inicio
    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        panelBuscar.Visible = False
        panelOperaciones.Visible = False

        pnlControles.Left = (Me.ClientSize.Width / 2) - (pnlControles.Width / 2)

        dgvDatos.Left = pnlControles.Left

        'panelOperaciones.Left = (Me.ClientSize.Width / 2) - (panelBuscar.Width / 2)

    End Sub
    ' Operaciones de Sesion
    ' Salir
    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    
    'Private Sub pbProductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim prod As New ProductoDAO
    '    DT.Clear()
    '    panelBuscar.Visible = False
    '    panelOperaciones.Visible = False
    '    dgvDatos.DataSource = prod
    '    dgvDatos.DataSource = Nothing

    '    Try
    '        Dim listaProductos = prod.cargar()
    '        Me.dgvDatos.DataSource = listaProductos.Tables("tabla")
    '        dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
    '        dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '        dgvDatos.AutoResizeColumns()
    '        dgvDatos.AutoSize = True


    '        dgvDatos.EditMode = False



    '        panelBuscar.Visible = True
    '        panelOperaciones.Visible = True

    '        target = "productos"
    '    Catch ex As Exception
    '        Throw New DAOException(ex.ToString)
    '    End Try
    'End Sub



    '  --------------------------------------------------------- Operaciones sobre Productos --------------------------------------     

    ' ------------------- Listado ------------------- 
    Private Sub listadoProductos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProductosList.Click
        Dim prod As New ProductoDAO
        DT.Clear()
        dgvDatos.DataSource = prod
        dgvDatos.DataSource = ""

        Try
            Dim listaProductos = prod.cargar()
            Me.dgvDatos.DataSource = listaProductos.Tables("tabla")
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDatos.EditMode = False
            dgvDatos.Visible = True
            dgvDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            panelBuscar.Visible = True
            cboxBuscar.DataSource = VariablesUtiles.busquedaProducto

            panelOperaciones.Visible = True
            txtBusqueda.Text = ""
            target = "productos"
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    ' -------------------  Agregar Producto/Carga de Formulario -------------------
    Private Sub agregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProductoAgregar.Click
        Dim agregarProd As New AgregarProducto
        dgvDatos.Visible = False
        agregarProd.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        agregarProd.ShowDialog(Me)
        listadoProductos(sender, e)
        dgvDatos.Visible = True
    End Sub

    ' ------------------- Manejo Modificar Producto/Carga de listado/Carga de formulario
    Private Sub modificarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miModificarProducto.Click
        If target <> "productos" Then
            listadoProductos(sender, e)
            MsgBox("Seleccione el producto a modificar", MsgBoxStyle.Information, "Notificación")
        Else
            Dim row = dgvDatos.CurrentRow.Index
            Dim codigo = dgvDatos.Item(0, row).Value
            Dim modificarForm As New ModificarProducto(codigo)
            modificarForm.ShowDialog()
            listadoProductos(sender, e)

        End If
    End Sub


    '  --------------------------------------------------------- Operaciones sobre Clientes --------------------------------------     


    '  ---------------------------- Carga de listado de Clientes   ----------------------------
    Private Sub listadoClientes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClientesListado.Click
        target = "clientes"
        Dim client As New ClienteDAO

        Try
            Dim listaClientes = client.cargar()
            Me.dgvDatos.DataSource = listaClientes.Tables("tabla")
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvDatos.AutoResizeColumns()
            dgvDatos.Visible = True
            dgvDatos.EditMode = False


            cbTipoBusqueda.Visible = False
            txtBusqueda.Visible = True 
            cboxBuscar.DataSource = VariablesUtiles.busquedaCliente
            panelBuscar.Visible = True
            panelOperaciones.Visible = True
            txtBusqueda.Text = ""

            target = "clientes"
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    '  ---------------------------- Carga de formulario de agregar Cliente   ----------------------------
    Private Sub agregarCliente_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClienteAgregar.Click
        Dim agregarCliente As New AgregarCliente
        dgvDatos.Visible = False
        agregarCliente.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        agregarCliente.ShowDialog(Me)
        dgvDatos.Visible = True
    End Sub
    '  ---------------------------- Carga de formulario de modificar Cliente   ----------------------------
    Private Sub modificarCliente_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem1.Click
        If target <> "clientes" Then
            listadoClientes(sender, e)
            MsgBox("Seleccione el cliente a modificar", MsgBoxStyle.Information, "Notificación")
        Else
            Try
                Dim row = dgvDatos.CurrentRow.Index
                Dim codigo = dgvDatos.Item(0, row).Value
                Dim modificarForm As New ModificarCliente(codigo)
                modificarForm.ShowDialog()
                listadoClientes(sender, e)
            Catch ex As Exception
                Throw New DAOException(ex.ToString)
            End Try
        End If
    End Sub

    '  ---------------------------- Operaciones Comunes. BUSQUEDA   ----------------------------

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxBuscar.SelectedIndexChanged
        If cboxBuscar.SelectedItem = "Tipo" Then
            cbTipoBusqueda.Location = txtBusqueda.Location
            cbTipoBusqueda.Visible = True
            txtBusqueda.Visible = False
        ElseIf cboxBuscar.SelectedItem = "Código" Then
            cbTipoBusqueda.Visible = False
            txtBusqueda.Visible = True
        End If
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim busqueda As DataSet
        If target = "productos" Then
            Dim dao As New ProductoDAO
            Dim criterio = cboxBuscar.SelectedItem

            If cboxBuscar.SelectedIndex = 0 And txtBusqueda.Text.Length > 0 Then
                busqueda = dao.cargarBusqueda(0, txtBusqueda.Text)
            ElseIf cboxBuscar.SelectedIndex = 1 And cbTipoBusqueda.SelectedItem <> "" Then
                busqueda = dao.cargarBusqueda(1, cbTipoBusqueda.SelectedItem)
            ElseIf txtBusqueda.Text.Length Or cbTipoBusqueda.SelectedItem = "" = 0 Then
                listadoProductos(sender, e)
                Exit Sub
            End If
            dgvDatos.DataSource = busqueda.Tables("tabla")
        ElseIf target = "clientes" Then
            Dim dao As New ClienteDAO
            If cboxBuscar.SelectedItem <> "" And txtBusqueda.Text.Length > 0 Then
                busqueda = dao.cargarBusqueda(cboxBuscar.SelectedIndex, txtBusqueda.Text)
            ElseIf txtBusqueda.Text.Length = 0 Then
                listadoClientes(sender, e)
                Exit Sub
            End If
            dgvDatos.DataSource = busqueda.Tables("tabla")
        End If
    End Sub

   
   

  
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If target = "productos" Then
            agregarProducto_Click(sender, e)
        ElseIf target = "clientes" Then
            agregarCliente_click(sender, e)
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If target = "productos" Then
            modificarProducto_Click(sender, e)
        ElseIf target = "clientes" Then
            modificarCliente_click(sender, e)

        End If
    End Sub

   
End Class
