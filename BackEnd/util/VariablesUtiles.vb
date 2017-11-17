Public Module VariablesUtiles
    Public colores As New Collection From {{"Gris", "G"}, {"Incoloro", "I"}, {"Bronce", "B"}, {"Dorado", "D"},
                                       {"Cromado", "C"}, {"Fosco", "Fosco"}, {"Pintado", "P"}, {"Azul", "A"}}

    Public busquedaProducto As New Collection From {{"Código", 0}, {"Tipo", 1}}
    Public busquedaCliente As New Collection From {{"Nombre", 0}, {"RUC", 1}, {"Contacto", 2}}
    Public busquedaVendedores As New Collection From {{"Nombre", 0}, {"Estado", 1}, {"Porcentaje", 2}}
    Public busquedaCompras As New Collection From {{"Nro. Factura", 0}, {"Rango de Fecha", 1}, {"Proveedor", 2}, {"Estado", 3}}
    Public busquedaComprasPago As New Collection From {{"Nro. Factura", 0}, {"Rango de Fecha", 1}, {"Proveedor", 2}}
    Public AnularCompras As New Collection From {{"Nro. Factura", 0}, {"Fecha Factura", 1}, {"Proveedor", 2}}
    Public productoTipo As New Collection From {{"Herrajes", 0}, {"Perfiles", 1}}
    Public busquedaMovInterno As New Collection From {{"Nro. Movimiento", 0}, {"Rango de Fecha", 1}, {"Proveedor", 2}}

    Public porcentaje As New Collection From {{"1%", 1}, {"0.5%", 2}}
    Public estado As New Collection From {{"Activo", 0}, {"Pagado", 1}, {"Anulado", 2}}

    Public sucursales As New Collection From {{"Seleccione...", 0}, {"Mayoristas Asunción", 1}, {"Fáb. Lambaré", 2}, {"Depósito Capiata", 3}, {"Mayoristas Capiata", 4}, {"Sucursal K.M 9", 5}, {"ShowRoom", 6}}
    Public autorizado As New Collection From {{"Magali Lopez", 0}, {"Yeruti Vazquez", 1}, {"Marcelo Román", 2}}
End Module
