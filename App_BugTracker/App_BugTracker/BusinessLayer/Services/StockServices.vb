Public Class StockServices
    Private oStockDao As StockDao
    Public Sub New()
        oStockDao = New StockDao

    End Sub
    Public Function consultarStock() As List(Of Stock)
        Return oStockDao.getAll
    End Function
End Class
