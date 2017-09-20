Imports App_BugTracker.Frm_abm_user

Public Class Frm_Users

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Frm_abm_user.seleccionar_usuario(Opcion.insert, Nothing)
        Frm_abm_user.ShowDialog()
    End Sub

    Private Sub Frm_Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Compras.llenarCombo(cbo_perfiles, BDHelper.getDBHelper.ConsultaSQL("SELECT * From Perfiles WHERE id_perfil <> 1"), "n_perfil", "id_perfil")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_nombre.Enabled = False
            cbo_perfiles.Enabled = False
        Else
            txt_nombre.Enabled = True
            cbo_perfiles.Enabled = True
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", _
                "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar.Click
        Dim sql As String = "SELECT n_usuario, email, n_perfil, id_usuario, password, estado FROM Users U JOIN Perfiles P ON U.id_perfil = P.id_perfil  WHERE 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then
            'Validar si el combo 'Perfiles' esta seleccionado.
            If cbo_perfiles.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(cbo_perfiles.SelectedValue)
                sql += " AND U.id_perfil=@param1 "
                flag_filtros = True
            Else
                filters.Add(Nothing)
            End If

            'Validar si el combo 'Perfiles' esta seleccionado.
            If txt_nombre.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_nombre.Text)
                sql += " AND U.n_usuario LIKE '%' + @param2 + '%' "
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

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_users.Rows.Clear()
        For Each row As DataRow In source.Rows
            If row.Item("estado").ToString <> "N" Then
                dgv_users.Rows.Add(New String() {row.Item("n_usuario").ToString, row.Item("estado").ToString, row.Item("email").ToString, row.Item("n_perfil").ToString, row.Item("id_usuario").ToString, row.Item("password").ToString})
            End If
Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        Frm_abm_user.seleccionar_usuario(Frm_abm_user.Opcion.update, dgv_users.CurrentRow)
        Frm_abm_user.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub


    Private Sub dgv_users_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_users.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Dim estado As String
        Dim str_sql As String = ""
        If MessageBox.Show("Seguro que desea borrar al Usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Users where id_usuario = '" + dgv_users.CurrentRow.Cells("col_id").Value + "'").Rows(0).Item("estado").ToString
            If estado = "N" Then
                estado = "S"
            Else
                estado = "N"
            End If
            str_sql = "UPDATE Users SET estado = '" + estado + "' WHERE id_usuario = " + dgv_users.CurrentRow.Cells("col_id").Value
            If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                MessageBox.Show("Usuario Borrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MessageBox.Show("Error al borrar al Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Frm_abm_user.seleccionar_usuario(Frm_abm_user.Opcion.delete, dgv_users.CurrentRow)
        ' Frm_abm_user.ShowDialog()
        'btn_consultar_Click(sender, e)
    End Sub

    Private Sub pnl_filtros_Enter(sender As Object, e As EventArgs) Handles pnl_filtros.Enter

    End Sub
End Class