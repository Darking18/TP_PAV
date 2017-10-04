Public Class frm_amb_perfiles
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
                txt_nombre.Text = _row_selected.Cells("col_nombre").Value
            End If
        End Sub

        Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
            Dim str_sql As String = ""
        ' Dim estado As String
            Dim tabla As DataTable
            Dim sql As String = ""
            Select Case _action
                Case Opcion.insert
                sql = "Select * from Perfiles x where x.n_perfil like '%' +'" & txt_nombre.Text & "'+ '%' "
                    tabla = BDHelper.getDBHelper().ConsultaSQL(sql)
                    If Not (tabla.Rows.Count > 0) Then
                        If validar_campos() Then
                        str_sql = "insert into dbo.Users (n_perfil ,estado) values ('"
                        str_sql += txt_nombre.Text & ",'S')"
                            If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                            MessageBox.Show("Perfil Ingresado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            End If
                        Else
                        MessageBox.Show("PERFIL Ya ingresado!. Ingrese un nombre de Usuario diferente o Modifique el actual", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                ' Case Opcion.delete
                ' If MessageBox.Show("Seguro que desea borrar al Perfil seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                'estado = BDHelper.getDBHelper.ConsultaSQL("Select estado from Perfiles where id_perfil = '" + _row_selected.Cells("id_perfil").Value + "'").Rows(0).Item("estado").ToString
                'If estado = "N" Then
                ' estado = "S"
                ' Else
                ' estado = "N"
                ' End If
                ' str_sql = "UPDATE Perfiles SET estado = '" + estado + "' WHERE id_perfil = " + _row_selected.Cells("id_perfil").Value
                ' If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                ' MessageBox.Show("Perfil Borrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Me.Dispose()
                ' Else
                ' MessageBox.Show("Error al borrar al Perfil", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' End If
                ' End If

            Case Opcion.update
                If validar_campos() Then
                    str_sql = "update Perfiles set n_perfil ='"
                    str_sql += txt_nombre.Text & "'"
                    str_sql += "where id_perfil ='" + _row_selected.Cells("id_perfil").Value + "'"
                    If BDHelper.getDBHelper.EjecutarSQL(str_sql) > 0 Then
                        MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Error al actualizar el Usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
        End Select

    End Sub
    Private Function validar_campos() As Boolean
        'campos obligatorios
        If txt_nombre.Text = String.Empty Then
            txt_nombre.BackColor = Color.Red
            txt_nombre.Focus()
            Return False
        Else
            txt_nombre.BackColor = Color.White
        End If

        Return True
    End Function
    End Class