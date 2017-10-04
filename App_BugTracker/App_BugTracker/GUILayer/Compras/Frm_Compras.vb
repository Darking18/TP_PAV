Public Class Frm_Compras
    Friend row_selected As DataGridViewRow
    Private oCompraSerivce As New CompraServices

    Private Sub Frm_Bugs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializar componentes:
        clear_components()
        'Deshabilitar botones
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        btn_comentar.Enabled = False

        'LLenar combos y limpiar grid
        llenarCombo(cbo_payform, BDHelper.getDBHelper.ConsultaSQL("Select * from MetodoDePago"), "n_metodo_pago", "id_metodo_pago")
        llenarCombo(cbo_proveedor, BDHelper.getDBHelper.ConsultaSQL("Select * from Proveedor"), "n_proveedor", "id_proveedor")
        dgv_bugs.Rows.Clear()
    End Sub

    Private Sub clear_components()
        txt_product.Text = ""
        txt_precio.Text = ""
        txt_cant.Text = ""
        cbo_proveedor.Text = ""
        cbo_payform.Text = ""
    End Sub


    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub dgv_bugs_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_bugs.CellClick
        btn_borrar.Enabled = True
        btn_editar.Enabled = True
        row_selected = dgv_bugs.CurrentRow
    End Sub

    'Definimos un procedimiento Friend (Amigo) para poder utilizarlo desde otro formulario, que permita cargar un combo a partir de:
    'Componente combo
    'Source, una lista de objetos
    'Nombre de la property a mostrar en el displayMember del componente
    'Nombre de la property a almacenar en el valueMember del componente
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    'Procedimiento Friend (Amigo) que nos permite llenar la grilla de bugs desde otro formulario.
    'Recibe OPCIONALMENTE una lista de bugs. Si no se recibe nada, se recuperan todos los bug mediante el servicio listarBugs()
    Private Sub llenarGrid(ByRef source As List(Of Compra))
        dgv_bugs.Rows.Clear()
        For Each oCompra As Compra In source
            If oCompra.estado.ToString <> "N" Then
                dgv_bugs.Rows.Add(New String() {oCompra.id_compra.ToString, oCompra.n_producto.ToString, oCompra.cantidades.ToString, oCompra.precio.ToString, oCompra.proveedor.ToString, oCompra.metodo_pago.ToString, oCompra.estado.ToString})
            End If
        Next
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT id_compra, producto, cantidad, precio, n_proveedor, n_metodo_pago, Compras.estado FROM ((Compras join  Proveedor on Compras.proveedor = id_proveedor)join  MetodoDePago on Compras.metodo_pago   = id_metodo_pago) where 1=1 "
        Dim flag As Boolean = False
        'Validar campos de fechas. Si son fechas válidas las agregamos. Caso contrario Nothing
        If Not ckb_todos.Checked Then
            If txt_cant.Text <> String.Empty Then
                filters.Add(txt_cant.Text)
                'str += " and cantidad => @param1"
                flag = True
            Else
                filters.Add(Nothing)
                filters.Add(Nothing)
            End If

            'Validar si el combo 'Estado' esta seleccionado.
            If txt_precio.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_precio.Text)
                'str += "AND precio => @param2 "
                flag = True
            Else
                filters.Add(Nothing)
            End If

            'Validar si el combo 'Asignado a' esta seleccionado.
            If txt_product.Text <> String.Empty Then
                filters.Add(txt_product.Text)
                'str += "AND producto = '%' + @param3 + '%'"
                flag = True
            Else
                filters.Add(Nothing)
            End If

            'Validar si el combo 'Prioridad' esta seleccionado.
            ' If cbo_prioridades.Text <> String.Empty Then
            'filters.Add(cbo_prioridades.SelectedValue)
            'str += "AND id_prioridad=@param5 "
            'Else
            'filters.Add(Nothing)
            'End If

            'Validar si el combo 'Criticidad' a esta seleccionado.
            If cbo_proveedor.Text <> String.Empty Then
                filters.Add(cbo_proveedor.SelectedValue)
                'str += "AND proveedor=@param4 "
                flag = True
            Else
                filters.Add(Nothing)
            End If

            'Validar si el combo 'Producto' a esta seleccionado.
            If cbo_payform.Text <> String.Empty Then
                filters.Add(cbo_payform.SelectedValue)
                'str += "AND metodo_pago=@param5"
                flag = True
            Else
                filters.Add(Nothing)
            End If
            'str += " ORDER BY id_compra DESC"

            'Solicitar al BDHelper que ejecuta una consulta con los filtros seleccionados
            'dgv_bugs.DataSource = BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray())

            'If dgv_bugs.Rows.Count = 0 Then
            'MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", _
            '       "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '       clear_components()
            If flag Then
                llenarGrid(oCompraSerivce.consultarCompraConFiltros(filters.ToArray))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenarGrid(oCompraSerivce.consultarcompra())

        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Frm_Agregar.seleccionar_usuario(Frm_Agregar.Opcion.insert, dgv_bugs.CurrentRow)
        Frm_Agregar.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_Agregar.seleccionar_usuario(Frm_Agregar.Opcion.update, dgv_bugs.CurrentRow)
        Frm_Agregar.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        Dim estado As String
        Dim str_sql As String

        If MessageBox.Show("Seguro que desea borrar la compra seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from dbo.Compras where id_compra = '" + dgv_bugs.CurrentRow.Cells("col_id_compra").Value + "'").Rows(0).Item("estado").ToString
            If estado = "N" Then
                estado = "S"
            Else
                estado = "N"
            End If
            str_sql = "UPDATE dbo.Compras SET estado = '" + estado + "' WHERE id_compra = " + dgv_bugs.CurrentRow.Cells("col_id_compra").Value
            If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                MessageBox.Show("Compra Borrada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MessageBox.Show("Error al borrar la Compra!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        'Frm_Agregar.seleccionar_usuario(Frm_Agregar.Opcion.delete, dgv_bugs.CurrentRow)
        'Frm_Agregar.ShowDialog()
        'btn_consultar_Click(sender, e)
    End Sub

    Private Sub ckb_todos_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_todos.CheckedChanged
        If ckb_todos.Checked Then
            txt_cant.Enabled = False
            cbo_payform.Enabled = False
            txt_precio.Enabled = False
            txt_product.Enabled = False
            cbo_proveedor.Enabled = False
        Else
            txt_cant.Enabled = True
            cbo_payform.Enabled = True
            txt_precio.Enabled = True
            txt_product.Enabled = True
            cbo_proveedor.Enabled = True
        End If
    End Sub

    Private Sub dgv_bugs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_bugs.CellContentClick

    End Sub
End Class