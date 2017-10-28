Public Module VariablesUtiles
    Public colores As New Collection From {{"Gris", "G"}, {"Incoloro", "I"}, {"Bronce", "B"}, {"Dorado", "D"}, _
                                       {"Cromado", "C"}, {"Fosco", "Fosco"}, {"Pintado", "P"}, {"Azul", "A"}}

    Public busquedaProducto As New Collection From {{"Código", 0}, {"Tipo", 1}}
    Public busquedaCliente As New Collection From {{"Nombre", 0}, {"RUC", 1}, {"Contacto", 2}}
    Public busquedaVendedores As New Collection From {{"Nombre", 0}, {"Estado", 1}, {"Porcentaje", 2}}
    Public busquedaCompras As New Collection From {{"Nro. Factura", 0}, {"Rango de Fecha", 1}, {"Estado", 2}}

    Public productoTipo As New Collection From {{"Herrajes", 0}, {"Perfiles", 1}}

    Public porcentaje As New Collection From {{"1%", 1}, {"0.5%", 2}}
    Public estado As New Collection From {{"Activo", 0}, {"Inactivo", 1}}
End Module
