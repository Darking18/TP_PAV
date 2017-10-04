Public Class Frm_Agregar
    Enum Opcion
        insert
        update
        delete
    End Enum
    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
    '  Private Function existe_nombre() As Boolean
    '    Return BDHelper.getDBHelper.ConsultaSQL("Select * from dbo.Compras where producto = '" + txt_product.Text + "'").Rows.Count > 0
    'End Function
    Public Sub seleccionar_usuario(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub
    Private Sub Frm_Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Compras.llenarCombo(cbo_proveedor, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Proveedor WHERE 1=1"), "n_proveedor", "id_proveedor")
        Frm_Compras.llenarCombo(cbo_payform, BDHelper.getDBHelper.ConsultaSQL("SELECT * From MetodoDePago WHERE 1=1"), "n_metodo_pago", "id_metodo_pago")
        Frm_Compras.llenarCombo(cbo_producto, BDHelper.getDBHelper.ConsultaSQL("Select * from productos where 1=1"), "nombre", "id_producto")
    End Sub
    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_cant.Text = _row_selected.Cells("col_cantidad").Value
            txt_precio.Text = _row_selected.Cells("col_precio").Value
            cbo_producto.Text = _row_selected.Cells("col_product").Value
            cbo_proveedor.Text = _row_selected.Cells("col_proveedor").Value
            cbo_payform.Text = _row_selected.Cells("col_payform").Value
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim oCompra As Compra
        Dim oCompraServices As New CompraServices

        If String.IsNullOrEmpty(cbo_producto.Text) Or String.IsNullOrEmpty(cbo_payform.Text) Then
            MessageBox.Show("Debe completar todos los campos indicados con (*).", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_producto.Focus()
        Else
            oCompra = New Compra
            oCompra.n_producto = cbo_producto.Text
            oCompra.id_producto = cbo_producto.SelectedValue
            oCompra.cantidades = txt_cant.Text
            oCompra.precio = txt_precio.Text
            oCompra.metodo_pago = cbo_payform.SelectedValue
            oCompra.proveedor = cbo_proveedor.SelectedValue

            If oCompraServices.create(oCompra) Then
                MessageBox.Show("La Compra se ha registrado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Ha ocurrido un error al registrar la Compra. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
        'Dim str_sql As String = ""
        'Dim estado As String
        'Select Case _action
        '   Case Opcion.insert
        'If validar_campos() Then
        ' str_sql = "insert into dbo.Compras (producto, cantidad, precio , metodo_pago, proveedor,estado) values ('"
        ' str_sql += txt_product.Text & "','"
        ' str_sql += txt_cant.Text & "','"
        ' str_sql += txt_precio.Text & "','"
        ' str_sql += cbo_payform.SelectedValue.ToString & "','"
        ' str_sql += cbo_proveedor.SelectedValue.ToString & "', 'S')"
        ' If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
        'MessageBox.Show("Compra Ingresada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.Close()
        'End If
        'Else
        'MessageBox.Show("Producto Ya ingresado!. Ingrese un nombre de producto diferente o Modifique el actual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '
        'End If

        ' Case Opcion.delete
        '    If MessageBox.Show("Seguro que desea borrar la compra seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
        'estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from dbo.Compras where id_compra = '" + _row_selected.Cells("col_id_compra").Value + "'").Rows(0).Item("estado").ToString
        'If estado = "N" Then
        ' estado = "S"
        ' Else
        ' estado = "N"
        'End If
        'str_sql = "UPDATE dbo.Compras SET estado = '" + estado + "' WHERE id_compra = " + _row_selected.Cells("col_id_compra").Value
        'If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
        ' MessageBox.Show("Compra Borrada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Me.Dispose()
        ' Else
        ' MessageBox.Show("Error al borrar la Compra!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' End If
        ' End If

        '   Case Opcion.update
        'If validar_campos() Then
        'str_sql = "update dbo.Compras set producto ='"
        'str_sql += txt_product.Text & "', precio='"
        'str_sql += txt_precio.Text & "',cantidad='"
        'str_sql += txt_cant.Text & "',metodo_pago='"
        'str_sql += cbo_payform.SelectedValue.ToString & "',proveedor='"
        'str_sql += cbo_proveedor.SelectedValue.ToString & "'"
        'str_sql += "where id_compra ='" + _row_selected.Cells("col_id_compra").Value + "'"
        'If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
        'MessageBox.Show("Compra actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.Dispose()
        'Else
        'MessageBox.Show("Error al actualizar la compra!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        'End If
        'End Select
    End Sub
    Private Function validar_campos() As Boolean
        'campos obligatorios
        If cbo_producto.Text = String.Empty Then
            cbo_producto.BackColor = Color.Red
            cbo_producto.Focus()
            Return False
        Else
            cbo_producto.BackColor = Color.White
        End If

        If txt_cant.Text = String.Empty Then
            txt_cant.BackColor = Color.Red
            txt_cant.Focus()
            Return False
        Else
            txt_cant.BackColor = Color.White
        End If


        If cbo_payform.Text = String.Empty Then
            cbo_payform.BackColor = Color.Red
            cbo_payform.Focus()
            Return False
        Else
            cbo_payform.BackColor = Color.White
        End If

        If cbo_proveedor.Text = String.Empty Then
            cbo_proveedor.BackColor = Color.Red
            cbo_proveedor.Focus()
            Return False
        Else
            cbo_proveedor.BackColor = Color.White
        End If

        Return True
    End Function
End Class