Public Class StockDao
    Public Function getAll() As List(Of Stock)
        Dim lst As New List(Of Stock)
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("Select * from Stock").Rows
            lst.Add(map(row))
        Next
        Return lst
    End Function

    Private Function map(ByRef row As DataRow) As Stock
        Dim oStock As New Stock
        oStock.cantidad = Convert.ToInt32(row.Item("cantidad").ToString)
        oStock.id_producto = row.Item("id_producto").ToString
        oStock.id_stock = row.Item("id_stock").ToString
        Return oStock
    End Function
End Class
