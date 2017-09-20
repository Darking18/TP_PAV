Imports App_BugTracker.Frm_abm_cliente
Public Class Cliente

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Frm_abm_cliente.seleccionar_usuario(Opcion.insert, Nothing)
        Frm_abm_cliente.ShowDialog()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txt_name.Enabled = False
            Txt_direccion.Enabled = False
            Txt_dni.Enabled = False
            Txt_telefono.Enabled = False
        Else
            txt_name.Enabled = True
            Txt_direccion.Enabled = True
            Txt_dni.Enabled = True
            Txt_telefono.Enabled = True
        End If
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Frm_abm_cliente.seleccionar_usuario(Frm_abm_cliente.Opcion.insert, Nothing)
        Frm_abm_cliente.ShowDialog()
        btn_consulta_Click_1(sender, e)
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Frm_abm_cliente.seleccionar_usuario(Frm_abm_cliente.Opcion.update, dgv_cliente.CurrentRow)
        Frm_abm_cliente.ShowDialog()
        btn_consulta_Click_1(sender, e)
    End Sub
    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Dim estado As String
        Dim str_sql As String

        If MessageBox.Show("Seguro que desea borrar al Cliente seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Cliente where id_cliente = '" + dgv_cliente.CurrentRow.Cells("col_id_id").Value + "'").Rows(0).Item("estado").ToString
            If estado = "N" Then
                estado = "S"
            Else
                estado = "N"
            End If
            str_sql = "UPDATE Cliente SET estado = '" + estado + "' WHERE id_cliente = " + dgv_cliente.CurrentRow.Cells("col_id_id").Value
            If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                MessageBox.Show("Cliente Borrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MessageBox.Show("Error al borrar al Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Frm_abm_cliente.seleccionar_usuario(Frm_abm_cliente.Opcion.delete, dgv_cliente.CurrentRow)
        'Frm_abm_cliente.ShowDialog()
        'btn_consulta_Click_1(sender, e)
    End Sub
    Private Sub dgv_cliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_cliente.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_cliente.Rows.Clear()
        For Each row As DataRow In source.Rows
            If row.Item("estado").ToString <> "N" Then
                dgv_cliente.Rows.Add(New String() {row.Item("n_cliente").ToString, row.Item("estado").ToString, row.Item("dni").ToString, row.Item("direccion").ToString, row.Item("id_cliente").ToString, row.Item("telefono").ToString})
            End If
Next
    End Sub

    Private Sub btn_consulta_Click_1(sender As Object, e As EventArgs) Handles btn_consulta.Click
        Dim sql As String = "SELECT n_cliente, dni, direccion, id_cliente, telefono, estado FROM Cliente   WHERE 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not CheckBox1.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.
            If txt_name.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_name.Text)
                sql += " AND n_cliente LIKE '%' + @param1 + '%' "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If Txt_dni.Text <> String.Empty Then
                filters.Add(Txt_dni.Text)
                sql += "AND dni = @param2 "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If Txt_direccion.Text <> String.Empty Then
                filters.Add(Txt_dni.Text)
                sql += "AND direccion = @param3 "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If Txt_telefono.Text <> String.Empty Then
                filters.Add(Txt_telefono.Text)
                sql += "AND telefono = @param4"
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            If flag_filtros Then
                llenar_grid(BDHelper.getDBHelper.ConsultarSQLConParametros(sql, filters.ToArray))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenar_grid(BDHelper.getDBHelper.ConsultaSQL(sql))
        End If
    End Sub

    Private Sub pnl_filtros_Enter(sender As Object, e As EventArgs) Handles pnl_filtros.Enter

    End Sub
End Class