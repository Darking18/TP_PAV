Public Class CompraServices
    Private oCompraDao As CompraDao
    Public Sub New()
        oCompraDao = New CompraDao

    End Sub
    Public Function create(ByVal oCompra As Compra) As Boolean
        Return oCompraDao.create(oCompra)
    End Function

    Public Function consultarCompraConFiltros(ByVal params As Object()) As List(Of Compra)
        Return oCompraDao.getCompraByFilters(params)
    End Function
End Class

