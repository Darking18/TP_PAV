<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Compras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnl_filtros = New System.Windows.Forms.GroupBox()
        Me.ckb_todos = New System.Windows.Forms.CheckBox()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.txt_product = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.cbo_payform = New System.Windows.Forms.ComboBox()
        Me.lbl_payform = New System.Windows.Forms.Label()
        Me.cbo_proveedor = New System.Windows.Forms.ComboBox()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.lbl_cant = New System.Windows.Forms.Label()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.dgv_bugs = New System.Windows.Forms.DataGridView()
        Me.col_id_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_payform = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_comentar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pnl_filtros.SuspendLayout()
        CType(Me.dgv_bugs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_filtros
        '
        Me.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_filtros.Controls.Add(Me.ckb_todos)
        Me.pnl_filtros.Controls.Add(Me.txt_cant)
        Me.pnl_filtros.Controls.Add(Me.txt_product)
        Me.pnl_filtros.Controls.Add(Me.txt_precio)
        Me.pnl_filtros.Controls.Add(Me.cbo_payform)
        Me.pnl_filtros.Controls.Add(Me.lbl_payform)
        Me.pnl_filtros.Controls.Add(Me.cbo_proveedor)
        Me.pnl_filtros.Controls.Add(Me.lbl_proveedor)
        Me.pnl_filtros.Controls.Add(Me.lbl_precio)
        Me.pnl_filtros.Controls.Add(Me.btn_consultar)
        Me.pnl_filtros.Controls.Add(Me.lbl_cant)
        Me.pnl_filtros.Controls.Add(Me.lbl_product)
        Me.pnl_filtros.Location = New System.Drawing.Point(2, 3)
        Me.pnl_filtros.Name = "pnl_filtros"
        Me.pnl_filtros.Size = New System.Drawing.Size(561, 365)
        Me.pnl_filtros.TabIndex = 0
        Me.pnl_filtros.TabStop = False
        Me.pnl_filtros.Text = "Filtros"
        '
        'ckb_todos
        '
        Me.ckb_todos.AutoSize = True
        Me.ckb_todos.Location = New System.Drawing.Point(299, 139)
        Me.ckb_todos.Name = "ckb_todos"
        Me.ckb_todos.Size = New System.Drawing.Size(94, 17)
        Me.ckb_todos.TabIndex = 19
        Me.ckb_todos.Text = "Mostrar Todos"
        Me.ckb_todos.UseVisualStyleBackColor = True
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(354, 19)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.Size = New System.Drawing.Size(181, 20)
        Me.txt_cant.TabIndex = 18
        '
        'txt_product
        '
        Me.txt_product.Location = New System.Drawing.Point(102, 19)
        Me.txt_product.Name = "txt_product"
        Me.txt_product.Size = New System.Drawing.Size(181, 20)
        Me.txt_product.TabIndex = 17
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(102, 79)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(181, 20)
        Me.txt_precio.TabIndex = 16
        '
        'cbo_payform
        '
        Me.cbo_payform.FormattingEnabled = True
        Me.cbo_payform.Location = New System.Drawing.Point(102, 131)
        Me.cbo_payform.Name = "cbo_payform"
        Me.cbo_payform.Size = New System.Drawing.Size(181, 21)
        Me.cbo_payform.TabIndex = 15
        '
        'lbl_payform
        '
        Me.lbl_payform.AutoSize = True
        Me.lbl_payform.Location = New System.Drawing.Point(3, 139)
        Me.lbl_payform.Name = "lbl_payform"
        Me.lbl_payform.Size = New System.Drawing.Size(89, 13)
        Me.lbl_payform.TabIndex = 14
        Me.lbl_payform.Text = "Metodo de Pago:"
        '
        'cbo_proveedor
        '
        Me.cbo_proveedor.FormattingEnabled = True
        Me.cbo_proveedor.Location = New System.Drawing.Point(354, 79)
        Me.cbo_proveedor.Name = "cbo_proveedor"
        Me.cbo_proveedor.Size = New System.Drawing.Size(181, 21)
        Me.cbo_proveedor.TabIndex = 8
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(289, 87)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(59, 13)
        Me.lbl_proveedor.TabIndex = 7
        Me.lbl_proveedor.Text = "Proveedor:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(25, 87)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(67, 13)
        Me.lbl_precio.TabIndex = 5
        Me.lbl_precio.Text = "Precio Total:"
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(467, 156)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(87, 23)
        Me.btn_consultar.TabIndex = 4
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Location = New System.Drawing.Point(296, 27)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(52, 13)
        Me.lbl_cant.TabIndex = 2
        Me.lbl_cant.Text = "Cantidad:"
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(39, 27)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(53, 13)
        Me.lbl_product.TabIndex = 0
        Me.lbl_product.Text = "Producto:"
        '
        'dgv_bugs
        '
        Me.dgv_bugs.AllowUserToAddRows = False
        Me.dgv_bugs.AllowUserToDeleteRows = False
        Me.dgv_bugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bugs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_compra, Me.col_product, Me.col_cant, Me.col_precio, Me.col_proveedor, Me.col_payform, Me.col_estado})
        Me.dgv_bugs.Location = New System.Drawing.Point(12, 198)
        Me.dgv_bugs.Name = "dgv_bugs"
        Me.dgv_bugs.ReadOnly = True
        Me.dgv_bugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_bugs.Size = New System.Drawing.Size(545, 269)
        Me.dgv_bugs.TabIndex = 5
        '
        'col_id_compra
        '
        Me.col_id_compra.HeaderText = "id_compra"
        Me.col_id_compra.Name = "col_id_compra"
        Me.col_id_compra.ReadOnly = True
        Me.col_id_compra.Visible = False
        '
        'col_product
        '
        Me.col_product.HeaderText = "Producto"
        Me.col_product.Name = "col_product"
        Me.col_product.ReadOnly = True
        '
        'col_cant
        '
        Me.col_cant.HeaderText = "Cantidad"
        Me.col_cant.Name = "col_cant"
        Me.col_cant.ReadOnly = True
        '
        'col_precio
        '
        Me.col_precio.HeaderText = "Precio Total"
        Me.col_precio.Name = "col_precio"
        Me.col_precio.ReadOnly = True
        '
        'col_proveedor
        '
        Me.col_proveedor.HeaderText = "Proveedor"
        Me.col_proveedor.Name = "col_proveedor"
        Me.col_proveedor.ReadOnly = True
        '
        'col_payform
        '
        Me.col_payform.HeaderText = "Metodo de pago"
        Me.col_payform.Name = "col_payform"
        Me.col_payform.ReadOnly = True
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        Me.col_estado.Visible = False
        '
        'btn_comentar
        '
        Me.btn_comentar.Image = Global.App_BugTracker.My.Resources.Resources.comentar
        Me.btn_comentar.Location = New System.Drawing.Point(167, 473)
        Me.btn_comentar.Name = "btn_comentar"
        Me.btn_comentar.Size = New System.Drawing.Size(40, 40)
        Me.btn_comentar.TabIndex = 10
        Me.btn_comentar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_salir.Location = New System.Drawing.Point(521, 473)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(40, 40)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_editar.Location = New System.Drawing.Point(97, 473)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(40, 40)
        Me.btn_editar.TabIndex = 8
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_borrar.Location = New System.Drawing.Point(54, 473)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_borrar.TabIndex = 7
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 473)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'Frm_Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(568, 525)
        Me.Controls.Add(Me.dgv_bugs)
        Me.Controls.Add(Me.btn_comentar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.pnl_filtros)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta General de Compras"
        Me.pnl_filtros.ResumeLayout(False)
        Me.pnl_filtros.PerformLayout()
        CType(Me.dgv_bugs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents lbl_product As System.Windows.Forms.Label
    Friend WithEvents dgv_bugs As System.Windows.Forms.DataGridView
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_comentar As System.Windows.Forms.Button
    Friend WithEvents cbo_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents cbo_payform As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_payform As System.Windows.Forms.Label
    Friend WithEvents txt_cant As System.Windows.Forms.TextBox
    Friend WithEvents txt_product As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents ckb_todos As System.Windows.Forms.CheckBox
    Friend WithEvents col_id_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_payform As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
