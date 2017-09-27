Public Class CompraDao
    Public Function getCompraByFilters(ByVal params As Object()) As IList(Of Compra)
        Dim lst As New List(Of Compra)

        Dim sql As String = "SELECT id_compra, producto, cantidad, precio, n_proveedor, n_metodo_pago, Compras.estado " & _
        "FROM ((Compras join  Proveedor on Compras.proveedor = id_proveedor)join  MetodoDePago on Compras.metodo_pago   = id_metodo_pago) where 1=1  "

        If Not IsNothing(params(0)) Then
            sql += "and producto = '%' @param1 '%' "
        End If
        If Not IsNothing(params(1)) Then
            sql += "and cantidad = @param2 "
        End If
        If Not IsNothing(params(2)) Then sql += "and precio = @param3"
        If Not IsNothing(params(3)) Then sql += "and n_proveedor = @param4"
        If Not IsNothing(params(4)) Then sql += "and n_metodo_pago = @param5"

        For Each row As DataRow In BDHelper.getDBHelper.ConsultarSQLConParametros(sql, params).Rows
        Next
        Return lst
    End Function
    Private Function map_buy(ByRef row As DataRow) As Compra
        Dim oCompra As New Compra

        oCompra.cantidades = Convert.ToInt32(row.Item("cantidad").ToString)
        oCompra.estado = row.Item("estado").ToString
        oCompra.metodo_pago = row.Item("metodo_pago").ToString
        oCompra.precio = row.Item("precio").ToString
        oCompra.producto = row.Item("producto").ToString
        oCompra.proveedor = row.Item("proveedor").ToString
        oCompra.id_compra = row.Item("id_compra").ToString
        Return oCompra
    End Function
    Public Function create(ByVal oCompra As Compra)
        Dim str_sql As String

        str_sql = "INSERT INTO compra (producto,cantidad,precio,proveedor,metodo_pago, estado) VALUES('"
        str_sql += oCompra.producto.ToString + "','"
        str_sql += oCompra.cantidades.ToString + "','"
        str_sql += oCompra.precio.ToString + "','"
        str_sql += oCompra.proveedor.ToString + "',' "
        str_sql += oCompra.metodo_pago.ToString + "','S'"

        'Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function
End Class
