Imports System.Math
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

        oCompra.id_compra = row.Item("id_compra").ToString
        oCompra.n_producto = row.Item("producto").ToString
        oCompra.cantidades = row.Item("cantidad").ToString
        oCompra.precio = row.Item("precio").ToString
        oCompra.proveedor = row.Item("n_proveedor").ToString
        oCompra.metodo_pago = row.Item("n_metodo_pago").ToString
        oCompra.estado = row.Item("estado").ToString

        Return oCompra
    End Function
    Public Function getall() As List(Of Compra)
        Dim lst As New List(Of Compra)
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL("SELECT id_compra, producto, Compras.cantidad, precio, n_proveedor, n_metodo_pago, Compras.estado FROM ((Compras join  Proveedor on Compras.proveedor = id_proveedor)join  MetodoDePago on Compras.metodo_pago   = id_metodo_pago) where 1=1 ").Rows
            lst.Add(map_buy(row))
        Next
        Return lst
    End Function
    Public Function create(ByVal oCompra As Compra)
        Dim str_sql As String
        Dim past As DataTable = BDHelper.getDBHelper.ConsultaSQL("select cantidad from stock where id_producto='" & oCompra.id_producto.ToString & "'")
        Dim rst As Integer
        Dim ast As Integer
        Dim ast2 As Integer
        Dim last As DataTable = BDHelper.getDBHelper.ConsultaSQL("select cantidad from metododepago where id_metodo_pago='" & oCompra.metodo_pago.ToString & "'")

        rst = Int(past.Rows(0).Item(0) + oCompra.cantidades)
        ast = Int(last.Rows(0).Item(0) - oCompra.precio)
        ast2 = Int(last.Rows(0).Item(0) + oCompra.precio)

        str_sql = "INSERT INTO compras (producto,cantidad,precio,proveedor,metodo_pago, estado) VALUES('"
        str_sql += oCompra.n_producto.ToString + "','"
        str_sql += oCompra.cantidades.ToString + "','"
        str_sql += oCompra.precio.ToString + "','"
        str_sql += oCompra.proveedor.ToString + "',' "
        str_sql += oCompra.metodo_pago.ToString + "','S');"

        str_sql += "Update Stock set id_producto='"
        str_sql += oCompra.id_producto.ToString + "',cantidad='"
        str_sql += rst.ToString + "' where id_producto='" & oCompra.id_producto.ToString & "';"

        str_sql += "update metododepago set cantidad='"

        If oCompra.metodo_pago.ToString = 1 Or oCompra.metodo_pago.ToString = 3 Then
            str_sql += ast.ToString + "' where id_metodo_pago ='" & oCompra.metodo_pago.ToString & ""
        Else
            str_sql += ast2.ToString + "' where id_metodo_pago = '" & oCompra.metodo_pago.ToString & "'"
        End If
        'Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
        Return (BDHelper.getDBHelper().EjecutarSQL(str_sql) = 1)
    End Function

End Class
