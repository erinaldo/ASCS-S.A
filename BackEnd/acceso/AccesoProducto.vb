Public Class AccesoProducto
    Public Function cargar() As Collection
        Dim producto As New productoDAO
        Return producto.cargar()

    End Function
End Class
