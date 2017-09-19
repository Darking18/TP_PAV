<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_pefiles
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
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.dgv_perfiles = New System.Windows.Forms.DataGridView()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_todos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_perfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_quitar.Location = New System.Drawing.Point(114, 331)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(40, 41)
        Me.btn_quitar.TabIndex = 11
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(395, 331)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 41)
        Me.btn_salir.TabIndex = 12
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Enabled = False
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(68, 331)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 41)
        Me.btn_editar.TabIndex = 10
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(22, 331)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 41)
        Me.btn_nuevo.TabIndex = 9
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.dgv_perfiles)
        Me.pnl_filtros.Controls.Add(Me.chk_todos)
        Me.pnl_filtros.Controls.Add(Me.Label3)
        Me.pnl_filtros.Controls.Add(Me.txt_nombre)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Location = New System.Drawing.Point(22, 12)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(413, 314)
        Me.pnl_filtros.TabIndex = 8
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'dgv_perfiles
        '
        Me.dgv_perfiles.AllowUserToAddRows = False
        Me.dgv_perfiles.AllowUserToDeleteRows = False
        Me.dgv_perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_perfiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nombre, Me.col_estado, Me.id_perfil})
        Me.dgv_perfiles.Location = New System.Drawing.Point(26, 115)
        Me.dgv_perfiles.Name = "dgv_perfiles"
        Me.dgv_perfiles.ReadOnly = True
        Me.dgv_perfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_perfiles.Size = New System.Drawing.Size(178, 192)
        Me.dgv_perfiles.TabIndex = 8
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
        'id_perfil
        '
        Me.id_perfil.HeaderText = "id_perfil"
        Me.id_perfil.Name = "id_perfil"
        Me.id_perfil.ReadOnly = True
        Me.id_perfil.Visible = False
        '
        'chk_todos
        '
        Me.chk_todos.AutoSize = True
        Me.chk_todos.Location = New System.Drawing.Point(74, 75)
        Me.chk_todos.Name = "chk_todos"
        Me.chk_todos.Size = New System.Drawing.Size(56, 17)
        Me.chk_todos.TabIndex = 2
        Me.chk_todos.Text = "Todos"
        Me.chk_todos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 22)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(276, 127)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 78)
        Me.btn_consultar.TabIndex = 3
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'Frm_pefiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 394)
        Me.Controls.Add(Me.btn_quitar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.Name = "Frm_pefiles"
        Me.Text = "Frm_Perfiles"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_perfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_perfiles As System.Windows.Forms.DataGridView
    Friend WithEvents col_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk_todos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
End Class
