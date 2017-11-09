Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports BackEnd

Public Class Inicio

    Dim DT As New DataTable
    Dim target As String = ""
    Dim padre As Control

    'Carga del Formulario de Inicio
    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SuspendLayout()
        ' Se establece el background y se cambia el padre de los paneles al picture box
        pbInicio.BackgroundImageLayout = ImageLayout.Center
        panelBuscar.Visible = False
        panelOperaciones.Visible = False
        PanelTitulo.Visible = False
        pnlControles.Visible = False
        pnlControles.Parent = pbInicio

        PanelTitulo.Parent = pbInicio

        'Centrado de elementos
        pnlControles.Left = (Me.ClientSize.Width / 2) - (pnlControles.Width / 2)
        dgvDatos.Left = pnlControles.Left
        PanelTitulo.Left = pnlControles.Left

        ' Estilo a paneles
        PanelTitulo.BackColor = Color.FromArgb(80, Color.Black)
        panelBuscar.BackColor = Color.FromArgb(80, Color.Black)
        panelOperaciones.BackColor = Color.FromArgb(80, Color.Black)
        msInicio.BackColor = Color.DarkOrange
        Me.SuspendLayout()
    End Sub




    'Private Sub cambiarFondo()

    '    For Each ctl As Control In Me.Controls
    '        If TypeOf ctl Is MdiClient Then
    '            'Set properties of ctl here, e.g.

    '            'Create a New brush. Make Is a Gradient style brush.



    '            ctl.BackgroundImage = My.Resources.Panther1
    '            ctl.BackgroundImageLayout = ImageLayout.Center


    '            padre = ctl
    '        End If
    '    Next ctl

    'For Each c As Control In Me.Controls
    '    If TypeOf c Is MdiClient Then
    '        AddHandler c.Paint, AddressOf myMdiControlPaint
    '        AddHandler c.SizeChanged, AddressOf myMdiControlResize
    '        Exit For
    '    End If
    'Next

    'End Sub





    'Private Sub myMdiControlPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    '    e.Graphics.DrawImage(My.Resources.Panther1, 0, 0, Me.Width, Me.Height)
    'End Sub

    'Private Sub myMdiControlResize(ByVal sender As Object, ByVal e As System.EventArgs)
    '    CType(sender, MdiClient).Invalidate()
    'End Sub


    ' Operaciones de Sesion
    ' Salir

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        Dim lg As New login
        lg.Show()
    End Sub

    ' Cambiar Contraseña
    Private Sub CambiarContra(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miCambiarContra.Click
        Dim cont As New CambiarContra
        cont.FormBorderStyle = FormBorderStyle.FixedDialog
        cont.ShowDialog(Me)
        cont.Dispose()
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
        'dgvDatos.DataSource = prod
        pnlControles.Visible = True
        dgvDatos.DataSource = ""
        If target = "" Then
            'dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            Me.dgvDatos.EditMode = False
            dgvDatos.Visible = True
            dgvDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End If
        Try
            Dim listaProductos = prod.cargar()
            Me.dgvDatos.DataSource = listaProductos.Tables("tabla")
            dgvDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            panelBuscar.Visible = True
            cboxBuscar.DataSource = VariablesUtiles.busquedaProducto
            cbTipoBusqueda.DataSource = VariablesUtiles.productoTipo
            panelOperaciones.Visible = True
            PanelTitulo.Visible = True
            txtBusqueda.Text = ""
            ''dgvDatos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader

            target = "productos"
            lblTitulo.Text = "LISTADO DE PRODUCTOS"
            lblTitulo.Left = (PanelTitulo.Width / 2) - (lblTitulo.Width / 2)
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    ' -------------------  Agregar Producto/Carga de Formulario -------------------
    Private Sub agregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProductoAgregar.Click
        Dim agregarProd As New AgregarProducto
        'dgvDatos.Visible = False
        agregarProd.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        agregarProd.ShowDialog(Me)
        listadoProductos(sender, e)
        dgvDatos.Visible = True
        agregarProd.Dispose()
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
            modificarForm.Dispose()
        End If
    End Sub

    ' ------------------- Manejo Eliminar Producto/Carga 
    Private Sub eliminarProducto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        If target <> "productos" Then
            listadoProductos(sender, e)
            MsgBox("Seleccione el/los producto/s a elminar", MsgBoxStyle.Information, "Notificación")
        Else
            Try
                Dim eliminar = dgvDatos.SelectedRows

                Dim result As Integer = MessageBox.Show("Eliminar los " + dgvDatos.SelectedRows.Count.ToString + " productos seleccionados?", "caption", MessageBoxButtons.YesNoCancel)

                If result = DialogResult.Cancel Then
                    MessageBox.Show("Cancel pressed")
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("No pressed")
                ElseIf result = DialogResult.Yes Then
                    Dim daoProd As New ProductoDAO
                    daoProd.eliminar(eliminar, dgvDatos.SelectedRows.Count)
                    listadoProductos(sender, e)
                End If
            Catch ex As Exception
                Throw New DAOException(ex.ToString)
            End Try

        End If
    End Sub


    '  --------------------------------------------------------- Operaciones sobre Clientes --------------------------------------     


    '  ---------------------------- Carga de listado de Clientes   ----------------------------
    Private Sub listadoClientes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miClientesListado.Click
        dgvDatos.DataSource = ""
        pnlControles.Visible = True
        Dim client As New ClienteDAO
        If target = "" Then
            'dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDatos.EditMode = False
            dgvDatos.Visible = True
            dgvDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        End If
        Try
            Dim listaClientes = client.cargar()
            Me.dgvDatos.DataSource = listaClientes.Tables("tabla")
            'dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
            'dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'dgvDatos.AutoResizeColumns()
            'dgvDatos.Visible = True            'dgvDatos.EditMode = False

            cbTipoBusqueda.Visible = False
            txtBusqueda.Visible = True
            cboxBuscar.DataSource = VariablesUtiles.busquedaCliente
            panelBuscar.Visible = True
            panelOperaciones.Visible = True
            PanelTitulo.Visible = True
            lblTitulo.Text = "LISTADO DE CLIENTES"
            txtBusqueda.Text = ""
            lblTitulo.Left = (PanelTitulo.Width / 2) - (lblTitulo.Width / 2)
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
        agregarCliente.Dispose()
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
                modificarForm.Dispose()
            Catch ex As Exception
                Throw New DAOException(ex.ToString)
            End Try
        End If
    End Sub

    '  ---------------------------- Manejo de eliminación de Clientes   ----------------------------
    Private Sub eliminarCliente(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElimiarToolStripMenuItem.Click
        If target <> "clientes" Then
            listadoClientes(sender, e)
            MsgBox("Seleccione el/los cliente/s a eliminar", MsgBoxStyle.Information, "Notificación")
        Else
            Try
                Dim eliminar = dgvDatos.SelectedRows

                Dim result As Integer = MessageBox.Show("Eliminar los " + dgvDatos.SelectedRows.Count.ToString + " cliente/s seleccionados?", "Eliminar", MessageBoxButtons.YesNoCancel)

                If result = DialogResult.Cancel Then
                    MessageBox.Show("Cancel pressed")
                ElseIf result = DialogResult.No Then
                    MessageBox.Show("No pressed")
                ElseIf result = DialogResult.Yes Then
                    Dim daoClie As New ClienteDAO
                    daoClie.eliminar(eliminar, dgvDatos.SelectedRows.Count)
                    listadoClientes(sender, e)
                End If
            Catch ex As Exception
                Throw New DAOException(ex.ToString)
            End Try

        End If
    End Sub


    '  --------------------------------------------------------- Operaciones sobre Proveedores --------------------------------------     

    ' ------------------- Listado ------------------- 

    Private Sub listadoProveedores(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProveedoresListado.Click
        Dim prov As New ProveedorDAO
        dgvDatos.DataSource = ""
        pnlControles.Visible = True
        If target = "" Then
            'dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDatos.EditMode = False
            dgvDatos.Visible = True
            dgvDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End If
        Try
            Dim listaProv = prov.cargar()
            Me.dgvDatos.DataSource = listaProv.Tables("tabla")
            cbTipoBusqueda.Visible = False
            txtBusqueda.Visible = True
            cboxBuscar.DataSource = VariablesUtiles.busquedaCliente
            panelBuscar.Visible = True
            panelOperaciones.Visible = True
            txtBusqueda.Text = ""
            dgvDatos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            target = "proveedores"
            PanelTitulo.Visible = True
            dgvDatos.Columns("Usuario").Visible = False
            dgvDatos.Columns("Fecha").Visible = False
            lblTitulo.Text = "LISTADO DE PROVEEDORES"
            lblTitulo.Left = (PanelTitulo.Width / 2) - (lblTitulo.Width / 2)
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    ' ------------------- Agregar nuevo Proveedor ------------------- 
    Private Sub agregarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProvAgregar.Click
        Dim agregarProv As New AgregarProveedor
        'dgvDatos.Visible = False
        agregarProv.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        agregarProv.ShowDialog(Me)
        listadoProveedores(sender, e)
        dgvDatos.Visible = True
        agregarProv.Dispose()
    End Sub


    ' ------------------- Modificar Proveedor Seleccionado ------------------- 
    Private Sub modificarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miProvModificar.Click
        If target <> "proveedores" Then
            listadoProveedores(sender, e)
            MsgBox("Seleccione el proveedor a modificar", MsgBoxStyle.Information, "Notificación")
        Else
            Try
                Dim row = dgvDatos.CurrentRow.Index
                Dim codigo = dgvDatos.Item(0, row).Value
                Dim modificarForm As New ModificarProveedor(codigo)
                modificarForm.ShowDialog()
                listadoProveedores(sender, e)
                modificarForm.Dispose()
            Catch ex As Exception
                Throw New DAOException(ex.ToString)
            End Try
        End If
    End Sub


    ' --------------------------------------------- Operaciones Sobre Vendedores --------------------------------------------- 
    ' ------------------- Listado de Vendedores ------------------- 
    Private Sub listadoVendedores(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miVendedoresListado.Click
        dgvDatos.DataSource = ""
        Dim vend As New VendedorDAO
        pnlControles.Visible = True
        If target = "" Then
            'dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDatos.EditMode = False
            dgvDatos.Visible = True
            dgvDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End If
        Try
            Dim listaProv = vend.cargar()
            Me.dgvDatos.DataSource = listaProv.Tables("tabla")
            cbTipoBusqueda.Visible = False
            txtBusqueda.Visible = True
            cboxBuscar.DataSource = VariablesUtiles.busquedaVendedores

            panelBuscar.Visible = True
            panelOperaciones.Visible = True
            txtBusqueda.Text = ""
            dgvDatos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            target = "vendedores"
            PanelTitulo.Visible = True
            lblTitulo.Text = "LISTADO DE VENDEDORES"
            lblTitulo.Left = (PanelTitulo.Width / 2) - (lblTitulo.Width / 2)
        Catch ex As Exception
            Throw New DAOException(ex.ToString)
        End Try
    End Sub

    '  ---------------------------- Agregar Vendedor nuevo   ----------------------------

    Private Sub agregarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miVendAgregar.Click
        Dim agregarVend As New AgregarVendedor
        'dgvDatos.Visible = False
        agregarVend.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        agregarVend.ShowDialog(Me)
        listadoVendedores(sender, e)
        dgvDatos.Visible = True
        agregarVend.Dispose()
    End Sub

    '  ---------------------------- Modificar Vendedor Seleccionado   ----------------------------
    Private Sub modificarVend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miVendModificar.Click
        If target <> "vendedores" Then
            listadoVendedores(sender, e)
            MsgBox("Seleccione el vendedor a modificar", MsgBoxStyle.Information, "Notificación")
        Else
            Try
                Dim row = dgvDatos.CurrentRow.Index
                Dim codigo = dgvDatos.Item(0, row).Value
                Dim modificarForm As New ModificarVendedor(codigo)
                modificarForm.ShowDialog()
                listadoVendedores(sender, e)
                modificarForm.Dispose()
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
        ElseIf cboxBuscar.SelectedItem = "Nombre" Then
            cbTipoBusqueda.Visible = False
            txtBusqueda.Visible = True
            txtBusqueda.Text = ""
            txtBusqueda.Focus()
        ElseIf cboxBuscar.SelectedItem = "Estado" Then
            cbTipoBusqueda.Location = txtBusqueda.Location
            cbTipoBusqueda.DataSource = VariablesUtiles.estado
            cbTipoBusqueda.Visible = True
            txtBusqueda.Visible = False
        ElseIf cboxBuscar.SelectedItem = "Porcentaje" Then
            cbTipoBusqueda.Location = txtBusqueda.Location
            cbTipoBusqueda.DataSource = VariablesUtiles.porcentaje
            cbTipoBusqueda.Visible = True
            txtBusqueda.Visible = False
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
        ElseIf target = "proveedores" Then
            Dim dao As New ProveedorDAO
            If cboxBuscar.SelectedItem <> "" And txtBusqueda.Text.Length > 0 Then
                busqueda = dao.cargarBusqueda(cboxBuscar.SelectedIndex, txtBusqueda.Text)
            ElseIf txtBusqueda.Text.Length = 0 Then
                listadoProveedores(sender, e)
                Exit Sub
            End If
            dgvDatos.DataSource = busqueda.Tables("tabla")
        ElseIf target = "vendedores" Then
            Dim dao As New VendedorDAO
            If cboxBuscar.SelectedIndex = 0 And txtBusqueda.Text.Length > 0 Then
                busqueda = dao.cargarBusqueda(cboxBuscar.SelectedIndex, txtBusqueda.Text)
            ElseIf cboxBuscar.SelectedIndex = 1 Then
                busqueda = dao.cargarBusqueda(cboxBuscar.SelectedIndex, cbTipoBusqueda.SelectedItem)
            ElseIf cboxBuscar.SelectedIndex = 2 Then
                busqueda = dao.cargarBusqueda(cboxBuscar.SelectedIndex, cbTipoBusqueda.SelectedIndex)
            Else
                listadoVendedores(sender, e)
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
        ElseIf target = "proveedores" Then
            agregarProv_Click(sender, e)
        ElseIf target = "vendedores" Then
            agregarVendedor_Click(sender, e)
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If target = "productos" Then
            modificarProducto_Click(sender, e)
        ElseIf target = "clientes" Then
            modificarCliente_click(sender, e)
        ElseIf target = "proveedores" Then
            modificarProv_Click(sender, e)
        ElseIf target = "vendedores" Then
            modificarVend_Click(sender, e)
        End If
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If target = "productos" Then
            eliminarProducto(sender, e)
        ElseIf target = "clientes" Then
            eliminarCliente(sender, e)

        End If

    End Sub






    Private Sub miGenerarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miGenerarCompra.Click
        Dim agregarProv As New GenerarCompras
        'dgvDatos.Visible = False
        agregarProv.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        agregarProv.ShowDialog(Me)
        agregarProv.Dispose()

    End Sub



    ' ------------------------------------------------------ MOVIMIENTO INTERNO  ------------------------------------------------------

    Private Sub MovInternoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miMovInterno.Click

    End Sub

    Private Sub GeneraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miGenerarMI.Click
        Dim movInt As New MovimientoInterno
        'dgvDatos.Visible = False
        movInt.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        movInt.ShowDialog(Me)
        movInt.Dispose()
    End Sub
End Class
