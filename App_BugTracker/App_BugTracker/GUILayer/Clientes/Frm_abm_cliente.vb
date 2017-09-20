Public Class Frm_abm_cliente
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
    Public Sub seleccionar_usuario(ByVal op As Opcion, ByVal row_selected As DataGridViewRow)
        _action = op
        _row_selected = row_selected
    End Sub
    Private Sub mostrar_datos()
        If Not IsNothing(_row_selected) Then
            Text_nombre.Text = _row_selected.Cells("col_nombre").Value
            Text_dni.Text = _row_selected.Cells("col_dni").Value
            Text_telefono.Text = _row_selected.Cells("col_telefono").Value
            Text_direccion.Text = _row_selected.Cells("col_direccion").Value
        End If
    End Sub
    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim str_sql As String = ""
        Dim estado As String
        Dim tabla As DataTable
        Dim sql As String = ""
        Select Case _action
            Case Opcion.insert
                sql = "Select * from Cliente x where x.n_cliente like '%' +'" & Text_nombre.Text & "'+ '%' "
                tabla = BDHelper.getDBHelper().ConsultaSQL(sql)
                If Not (tabla.Rows.Count > 0) Then
                    If validar_campos() Then
                        str_sql = "insert into dbo.Cliente (n_cliente, dni, direccion, telefono,estado) values ('"
                        str_sql += Text_nombre.Text & "','"
                        str_sql += Text_dni.Text & "','"
                        str_sql += Text_direccion.Text & "','"
                        str_sql += Text_telefono.Text & "','S')"
                        If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Cliente Ingresado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    Else
                        MessageBox.Show("CLIENTE Ya ingresado!. Ingrese un nombre de Usuario diferente o Modifique el actual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
                'Case Opcion.delete
                '   If MessageBox.Show("Seguro que desea borrar al Cliente seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                'estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Cliente where id_cliente = '" + _row_selected.Cells("col_id_id").Value + "'").Rows(0).Item("estado").ToString
                'If estado = "N" Then
                ' estado = "S"
                ' Else
                ' estado = "N"
                ' End If
                ' str_sql = "UPDATE Cliente SET estado = '" + estado + "' WHERE id_cliente = " + _row_selected.Cells("col_id_id").Value
                ' If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                ' MessageBox.Show("Cliente Borrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Me.Dispose()
                ' Else
                ' MessageBox.Show("Error al borrar al Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' End If
                ' End If

            Case Opcion.update
                If validar_campos() Then
                    str_sql = "update Cliente set n_cliente ='"
                    str_sql += Text_nombre.Text & "', direccion='"
                    str_sql += Text_direccion.Text & "',dni='"
                    str_sql += Text_dni.Text & "', telefono='"
                    str_sql += Text_telefono.Text & "'"
                    str_sql += "where id_cliente ='" + _row_selected.Cells("col_id_id").Value + "'"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select

    End Sub
    Private Function validar_campos() As Boolean
        'campos obligatorios
        If Text_nombre.Text = String.Empty Then
            Text_nombre.BackColor = Color.Red
            Text_nombre.Focus()
            Return False
        Else
            Text_nombre.BackColor = Color.White
        End If

        If Text_dni.Text = String.Empty Then
            Text_dni.BackColor = Color.Red
            Text_dni.Focus()
            Return False
        Else
            Text_dni.BackColor = Color.White
        End If

        If Text_direccion.Text = String.Empty Then
            Text_direccion.BackColor = Color.Red
            Text_direccion.Focus()
            Return False
        Else
            Text_direccion.BackColor = Color.White
        End If
        Return True
    End Function

End Class