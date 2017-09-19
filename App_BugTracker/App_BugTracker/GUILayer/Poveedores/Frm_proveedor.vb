Public Class Frm_proveedor
    Friend row_selected As DataGridViewRow
    Private Sub Frm_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_74507DataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        'Me.ProveedorTableAdapter.Fill(Me._74507DataSet.Proveedor)
        clear_components()

        btn_delete.Enabled = False
        btn_edit.Enabled = False

        dgv_proveedor.Rows.Clear()
    End Sub

    Private Sub clear_components()
        txt_phone.Text = ""
        txt_account.Text = ""
        txt_name.Text = ""
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        If MessageBox.Show("Seguro que desea salir?", _
              "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
              , MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
    Private Sub dgv_proveedor_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_proveedor.CellClick
        btn_delete.Enabled = True
        btn_edit.Enabled = True
        row_selected = dgv_proveedor.CurrentRow
    End Sub

    Private Sub llenarGrid(ByVal source As DataTable)
        dgv_proveedor.Rows.Clear()
        For Each fila As DataRow In source.Rows
            dgv_proveedor.Rows.Add(New String() {fila.Item("id_proveedor").ToString, fila.Item("n_proveedor").ToString, fila.Item("cuenta_bancaria").ToString, fila.Item("telefono").ToString})
        Next
    End Sub

    Private Sub btn_consulta_Click(sender As Object, e As EventArgs) Handles btn_consulta.Click
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT id_proveedor, n_proveedor, cuenta_bancaria, telefono FROM Proveedor where 1=1 "
        Dim flag As Boolean = False
        If Not chb_alls.Checked Then
            If txt_account.Text <> String.Empty Then
                filters.Add(txt_account.Text)
                str += " and cuenta_bancaria => @param1"
                flag = True
            Else
                filters.Add(Nothing)
                filters.Add(Nothing)
            End If
            If txt_name.Text <> String.Empty Then
                filters.Add(txt_name.Text)
                str += "AND n_proveedor => @param2 "
                flag = True
            Else
                filters.Add(Nothing)
            End If
            If txt_phone.Text <> String.Empty Then
                filters.Add(txt_phone.Text)
                str += "AND telefono => @param3 "
                flag = True
            Else
                filters.Add(Nothing)
            End If

            If flag Then
                llenarGrid(BDHelper.getDBHelper.ConsultarSQLConParametros(str, filters.ToArray))
            Else
                MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            llenarGrid(BDHelper.getDBHelper.ConsultaSQL(str))
        End If

    End Sub

    Private Sub ckb_todos_CheckedChanged(sender As Object, e As EventArgs) Handles chb_alls.CheckedChanged
        If chb_alls.Checked Then
            txt_account.Enabled = False
            txt_name.Enabled = False
            txt_phone.Enabled = False
        Else
            txt_account.Enabled = True
            txt_name.Enabled = True
            txt_phone.Enabled = True
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Frm_add_provider.seleccionar_usuario(Frm_add_provider.Opcion.insert, dgv_proveedor.CurrentRow)
        Frm_add_provider.ShowDialog()
        btn_consulta_Click(sender, e)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Frm_add_provider.seleccionar_usuario(Frm_add_provider.Opcion.update, dgv_proveedor.CurrentRow)
        Frm_add_provider.ShowDialog()
        btn_consulta_Click(sender, e)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Frm_add_provider.seleccionar_usuario(Frm_add_provider.Opcion.delete, dgv_proveedor.CurrentRow)
        Frm_add_provider.ShowDialog()
        btn_consulta_Click(sender, e)
    End Sub
End Class