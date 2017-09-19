<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbo_perfiles = New System.Windows.Forms.ComboBox()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.Txt_telefono = New System.Windows.Forms.TextBox()
        Me.Txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_dni = New System.Windows.Forms.TextBox()
        Me.dgv_cliente = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_users
        '
        Me.dgv_users.AllowUserToAddRows = False
        Me.dgv_users.AllowUserToDeleteRows = False
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_estado, Me.col_email, Me.col_perfil, Me.col_id, Me.col_pass})
        Me.dgv_users.Location = New System.Drawing.Point(59, 156)
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.ReadOnly = True
        Me.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_users.Size = New System.Drawing.Size(372, 192)
        Me.dgv_users.TabIndex = 23
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        Me.col_estado.Visible = False
        '
        'col_email
        '
        Me.col_email.HeaderText = "Email"
        Me.col_email.Name = "col_email"
        Me.col_email.ReadOnly = True
        Me.col_email.Width = 130
        '
        'col_perfil
        '
        Me.col_perfil.HeaderText = "Perfil"
        Me.col_perfil.Name = "col_perfil"
        Me.col_perfil.ReadOnly = True
        '
        'col_id
        '
        Me.col_id.HeaderText = "Id"
        Me.col_id.Name = "col_id"
        Me.col_id.ReadOnly = True
        Me.col_id.Visible = False
        '
        'col_pass
        '
        Me.col_pass.HeaderText = "Password"
        Me.col_pass.Name = "col_pass"
        Me.col_pass.ReadOnly = True
        Me.col_pass.Visible = False
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(107, 116)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 21
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(107, 63)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombre.TabIndex = 18
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(344, 127)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 22
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbo_perfiles
        '
        Me.cbo_perfiles.FormattingEnabled = True
        Me.cbo_perfiles.Location = New System.Drawing.Point(107, 89)
        Me.cbo_perfiles.Name = "cbo_perfiles"
        Me.cbo_perfiles.Size = New System.Drawing.Size(181, 21)
        Me.cbo_perfiles.TabIndex = 20
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Location = New System.Drawing.Point(65, 92)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(33, 13)
        Me.lbl_estado.TabIndex = 19
        Me.lbl_estado.Text = "Perfil:"
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.Txt_telefono)
        Me.pnl_filtros.Controls.Add(Me.Txt_direccion)
        Me.pnl_filtros.Controls.Add(Me.Label5)
        Me.pnl_filtros.Controls.Add(Me.Label4)
        Me.pnl_filtros.Controls.Add(Me.Txt_dni)
        Me.pnl_filtros.Controls.Add(Me.dgv_cliente)
        Me.pnl_filtros.Controls.Add(Me.CheckBox1)
        Me.pnl_filtros.Controls.Add(Me.Label1)
        Me.pnl_filtros.Controls.Add(Me.txt_name)
        Me.pnl_filtros.Controls.Add(Me.btn_consulta)
        Me.pnl_filtros.Controls.Add(Me.Label2)
        Me.pnl_filtros.Location = New System.Drawing.Point(37, 12)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(519, 375)
        Me.pnl_filtros.TabIndex = 25
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'Txt_telefono
        '
        Me.Txt_telefono.Location = New System.Drawing.Point(335, 47)
        Me.Txt_telefono.Name = "Txt_telefono"
        Me.Txt_telefono.Size = New System.Drawing.Size(114, 20)
        Me.Txt_telefono.TabIndex = 22
        '
        'Txt_direccion
        '
        Me.Txt_direccion.Location = New System.Drawing.Point(125, 73)
        Me.Txt_direccion.Name = "Txt_direccion"
        Me.Txt_direccion.Size = New System.Drawing.Size(115, 20)
        Me.Txt_direccion.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Telefono: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Direccion: "
        '
        'Txt_dni
        '
        Me.Txt_dni.Location = New System.Drawing.Point(125, 47)
        Me.Txt_dni.Name = "Txt_dni"
        Me.Txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.Txt_dni.TabIndex = 18
        '
        'dgv_cliente
        '
        Me.dgv_cliente.AllowUserToAddRows = False
        Me.dgv_cliente.AllowUserToDeleteRows = False
        Me.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.col_id_id, Me.DataGridViewTextBoxColumn6})
        Me.dgv_cliente.Location = New System.Drawing.Point(77, 144)
        Me.dgv_cliente.Name = "dgv_cliente"
        Me.dgv_cliente.ReadOnly = True
        Me.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cliente.Size = New System.Drawing.Size(372, 192)
        Me.dgv_cliente.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(125, 121)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Todos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Apellido y Nombre:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(125, 22)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(181, 20)
        Me.txt_name.TabIndex = 0
        '
        'btn_consulta
        '
        Me.btn_consulta.Location = New System.Drawing.Point(288, 86)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(93, 35)
        Me.btn_consulta.TabIndex = 3
        Me.btn_consulta.Text = "Consultar"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DNI:"
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_quitar.Location = New System.Drawing.Point(162, 393)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(40, 40)
        Me.btn_quitar.TabIndex = 25
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(488, 393)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 26
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(115, 393)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 24
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(68, 393)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 23
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'col_id_id
        '
        Me.col_id_id.HeaderText = "Id"
        Me.col_id_id.Name = "col_id_id"
        Me.col_id_id.ReadOnly = True
        Me.col_id_id.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 502)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_users)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.chk_todos)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.cbo_perfiles)
        Me.Controls.Add(Me.lbl_estado)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_users As System.Windows.Forms.DataGridView
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_pass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents cbo_perfiles As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_estado As System.Windows.Forms.Label
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents btn_consulta As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents Txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_id_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
