Public Class Frm_add_provider
    Enum Opcion
        insert
        update
        delete
    End Enum
    Private _action As Opcion = Opcion.insert
    Private _row_selected As DataGridViewRow
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()

    End Sub
    Private Function existe_nombre() As Boolean
        Return BDHelper.getDBHelper.ConsultaSQL("Select * from dbo.Proveedor where n_proveedor = '" + txt_name.Text + "'").Rows.Count > 0
    End Function
    Public Sub seleccionar_usuario(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub
    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            txt_account.Text = _row_selected.Cells("col_cuenta_bancaria").Value
            txt_name.Text = _row_selected.Cells("col_n_proveedor").Value
            txt_phone.Text = _row_selected.Cells("col_telefono").Value
        End If
    End Sub

    Private Sub btn_accept_Click(sender As Object, e As EventArgs) Handles btn_accept.Click
        Dim str_sql As String = ""
        'Dim estado As String
        Select _action
            Case Opcion.insert
                If validar_campos() Then
                    str_sql = "insert into dbo.Proveedor (n_proveedor, cuenta_bancaria, telefono, estado) values ('"
                    str_sql += txt_name.Text & "','"
                    str_sql += txt_account.Text & "','"
                    str_sql += txt_phone.Text & "','S')"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Proveedor Agregado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Proveeedor ya existente, Use otro nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                ' Case Opcion.delete
                '  If MessageBox.Show("Seguro que desea al Proveedor seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                ' estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from dbo.Proveedor where id_proveedor = '" + _row_selected.Cells("col_id_proveedor").Value + "'").Rows(0).Item("estado").ToString
                'If estado = "N" Then
                'estado = "S"
                'Else
                'estado = "N"
                'End If
                'str_sql = "UPDATE dbo.Proveedor SET estado = '" + estado + "' WHERE id_proveedor = " + _row_selected.Cells("col_id_proveedor").Value
                'If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                'MessageBox.Show("Proveedor borrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.Dispose()
                'Else
                'MessageBox.Show("Error al borrar al proveedor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
                'End If
            Case Opcion.update
                If validar_campos() Then
                    str_sql = "update dbo.Proveedor set n_proveedor ='"
                    str_sql += txt_name.Text & "', cuenta_bancaria='"
                    str_sql += txt_account.Text & "',telefono='"
                    str_sql += txt_phone.Text & "'"
                    str_sql += "where id_proveedor ='" + _row_selected.Cells("col_id_proveedor").Value + "'"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Proveedor actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar la informacion de proveedor!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select
    End Sub
    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_account.Text = String.Empty Then
            txt_account.BackColor = Color.Red
            txt_account.Focus()
            Return False
        Else
            txt_account.BackColor = Color.White
        End If

        If txt_name.Text = String.Empty Then
            txt_name.BackColor = Color.Red
            txt_name.Focus()
            Return False
        Else
            txt_name.BackColor = Color.White
        End If


        If txt_phone.Text = String.Empty Then
            txt_phone.BackColor = Color.Red
            txt_phone.Focus()
            Return False
        Else
            txt_phone.BackColor = Color.White
        End If

        Return True
    End Function
End Class