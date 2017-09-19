Imports App_BugTracker.frm_amb_perfiles

Public Class Frm_pefiles

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        frm_amb_perfiles.seleccionar_usuario(Opcion.insert, Nothing)
        frm_amb_perfiles.ShowDialog()
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
        dgv_perfiles.Rows.Clear()
        For Each row As DataRow In source.Rows
            dgv_perfiles.Rows.Add(New String() {row.Item("n_perfil").ToString, row.Item("estado").ToString, row.Item("id_perfil").ToString})
        Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        frm_amb_perfiles.seleccionar_usuario(frm_amb_perfiles.Opcion.update, dgv_perfiles.CurrentRow)
        frm_amb_perfiles.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub
    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        frm_amb_perfiles.seleccionar_usuario(frm_amb_perfiles.Opcion.delete, dgv_perfiles.CurrentRow)
        frm_amb_perfiles.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Dim sql As String = "SELECT n_perfil, estado, id_perfil FROM Perfiles WHERE 1=1"
        Dim filters As New List(Of Object)
        Dim flag_filtros As Boolean = False

        If Not chk_todos.Checked Then

            'Validar si el combo 'Perfiles' esta seleccionado.
            If txt_nombre.Text <> String.Empty Then
                'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                filters.Add(txt_nombre.Text)
                sql += " AND n_perfil = @param1"
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

    Private Sub chk_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_todos.CheckedChanged
        If chk_todos.Checked Then
            txt_nombre.Enabled = False
        Else
            txt_nombre.Enabled = True
        End If
    End Sub
End Class