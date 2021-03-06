﻿Imports App_BugTracker.frm_amb_perfiles

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

    Private Sub dgv_perfiles_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_perfiles.CellContentClick
        btn_editar.Enabled = True
        btn_quitar.Enabled = True
    End Sub

    Private Sub llenar_grid(ByVal source As DataTable)
        dgv_perfiles.Rows.Clear()
        For Each row As DataRow In source.Rows
            If row.Item("estado").ToString <> "N" Then
                dgv_perfiles.Rows.Add(New String() {row.Item("n_perfil").ToString, row.Item("estado").ToString, row.Item("id_perfil").ToString})
            End If
Next
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_editar.Click
        frm_amb_perfiles.seleccionar_usuario(frm_amb_perfiles.Opcion.update, dgv_perfiles.CurrentRow)
        frm_amb_perfiles.ShowDialog()
        btn_consultar_Click(sender, e)
    End Sub
    Private Sub btn_quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quitar.Click
        Dim estado As String
        Dim str_sql As String
        If MessageBox.Show("Seguro que desea borrar al Perfil seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Perfiles where id_perfil = '" + dgv_perfiles.CurrentRow.Cells("id_perfil").Value + "'").Rows(0).Item("estado").ToString
            If estado = "N" Then
                estado = "S"
            Else
                estado = "N"
            End If
            str_sql = "UPDATE Perfiles SET estado = '" + estado + "' WHERE id_perfil = " + dgv_perfiles.CurrentRow.Cells("id_perfil").Value
            If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                MessageBox.Show("Perfil Borrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MessageBox.Show("Error al borrar al Perfil", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'frm_amb_perfiles.seleccionar_usuario(frm_amb_perfiles.Opcion.delete, dgv_perfiles.CurrentRow)
        'frm_amb_perfiles.ShowDialog()
        'btn_consultar_Click(sender, e)
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