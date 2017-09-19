<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_proveedor
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
        Me.components = New System.ComponentModel.Container()
        Me.pnl_filter = New System.Windows.Forms.GroupBox()
        Me.dgv_proveedor = New System.Windows.Forms.DataGridView()
        Me.chb_alls = New System.Windows.Forms.CheckBox()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_account = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_account = New System.Windows.Forms.TextBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._74507DataSet = New App_BugTracker._74507DataSet()
        Me.ProveedorTableAdapter = New App_BugTracker._74507DataSetTableAdapters.ProveedorTableAdapter()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.col_id_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_n_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cuenta_bancaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_filter.SuspendLayout()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._74507DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_filter
        '
        Me.pnl_filter.Controls.Add(Me.dgv_proveedor)
        Me.pnl_filter.Controls.Add(Me.chb_alls)
        Me.pnl_filter.Controls.Add(Me.btn_consulta)
        Me.pnl_filter.Controls.Add(Me.lbl_name)
        Me.pnl_filter.Controls.Add(Me.lbl_phone)
        Me.pnl_filter.Controls.Add(Me.lbl_account)
        Me.pnl_filter.Controls.Add(Me.txt_name)
        Me.pnl_filter.Controls.Add(Me.txt_phone)
        Me.pnl_filter.Controls.Add(Me.txt_account)
        Me.pnl_filter.Location = New System.Drawing.Point(12, 12)
        Me.pnl_filter.Name = "pnl_filter"
        Me.pnl_filter.Size = New System.Drawing.Size(521, 401)
        Me.pnl_filter.TabIndex = 0
        Me.pnl_filter.TabStop = False
        Me.pnl_filter.Text = "Filtros"
        '
        'dgv_proveedor
        '
        Me.dgv_proveedor.AllowUserToAddRows = False
        Me.dgv_proveedor.AllowUserToDeleteRows = False
        Me.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_proveedor, Me.col_n_proveedor, Me.col_cuenta_bancaria, Me.col_telefono, Me.col_estado})
        Me.dgv_proveedor.Location = New System.Drawing.Point(0, 173)
        Me.dgv_proveedor.Name = "dgv_proveedor"
        Me.dgv_proveedor.ReadOnly = True
        Me.dgv_proveedor.Size = New System.Drawing.Size(515, 214)
        Me.dgv_proveedor.TabIndex = 9
        '
        'chb_alls
        '
        Me.chb_alls.AutoSize = True
        Me.chb_alls.Location = New System.Drawing.Point(16, 149)
        Me.chb_alls.Name = "chb_alls"
        Me.chb_alls.Size = New System.Drawing.Size(178, 17)
        Me.chb_alls.TabIndex = 8
        Me.chb_alls.Text = "Mostrar a todos los Proveedores"
        Me.chb_alls.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Location = New System.Drawing.Point(440, 144)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(75, 23)
        Me.btn_consulta.TabIndex = 7
        Me.btn_consulta.Text = "Consultar"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(13, 112)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(47, 13)
        Me.lbl_name.TabIndex = 5
        Me.lbl_name.Text = "Nombre:"
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Location = New System.Drawing.Point(10, 68)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(52, 13)
        Me.lbl_phone.TabIndex = 4
        Me.lbl_phone.Text = "Telefono:"
        '
        'lbl_account
        '
        Me.lbl_account.AutoSize = True
        Me.lbl_account.Location = New System.Drawing.Point(7, 25)
        Me.lbl_account.Name = "lbl_account"
        Me.lbl_account.Size = New System.Drawing.Size(89, 13)
        Me.lbl_account.TabIndex = 3
        Me.lbl_account.Text = "Cuenta Bancaria:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(102, 105)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(216, 20)
        Me.txt_name.TabIndex = 2
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(102, 61)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(216, 20)
        Me.txt_phone.TabIndex = 1
        '
        'txt_account
        '
        Me.txt_account.Location = New System.Drawing.Point(102, 22)
        Me.txt_account.Name = "txt_account"
        Me.txt_account.Size = New System.Drawing.Size(216, 20)
        Me.txt_account.TabIndex = 0
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me._74507DataSet
        '
        '_74507DataSet
        '
        Me._74507DataSet.DataSetName = "_74507DataSet"
        Me._74507DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'btn_delete
        '
        Me.btn_delete.Image = Global.App_BugTracker.My.Resources.Resources.eliminar
        Me.btn_delete.Location = New System.Drawing.Point(122, 419)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(49, 42)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = Global.App_BugTracker.My.Resources.Resources.editar
        Me.btn_edit.Location = New System.Drawing.Point(66, 419)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 42)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = Global.App_BugTracker.My.Resources.Resources.agregar
        Me.btn_add.Location = New System.Drawing.Point(12, 419)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(48, 42)
        Me.btn_add.TabIndex = 3
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Image = Global.App_BugTracker.My.Resources.Resources.salir
        Me.btn_close.Location = New System.Drawing.Point(471, 419)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(55, 42)
        Me.btn_close.TabIndex = 4
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'col_id_proveedor
        '
        Me.col_id_proveedor.HeaderText = "id_proveedor"
        Me.col_id_proveedor.Name = "col_id_proveedor"
        Me.col_id_proveedor.ReadOnly = True
        Me.col_id_proveedor.Visible = False
        '
        'col_n_proveedor
        '
        Me.col_n_proveedor.HeaderText = "Proveedor"
        Me.col_n_proveedor.Name = "col_n_proveedor"
        Me.col_n_proveedor.ReadOnly = True
        '
        'col_cuenta_bancaria
        '
        Me.col_cuenta_bancaria.FillWeight = 200.0!
        Me.col_cuenta_bancaria.HeaderText = "Numero de Cuenta Bancaria"
        Me.col_cuenta_bancaria.Name = "col_cuenta_bancaria"
        Me.col_cuenta_bancaria.ReadOnly = True
        Me.col_cuenta_bancaria.Width = 200
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.ReadOnly = True
        '
        'col_estado
        '
        Me.col_estado.HeaderText = "estado"
        Me.col_estado.Name = "col_estado"
        Me.col_estado.ReadOnly = True
        Me.col_estado.Visible = False
        '
        'Frm_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 473)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.pnl_filter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta de Proveedor"
        Me.pnl_filter.ResumeLayout(False)
        Me.pnl_filter.PerformLayout()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._74507DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_filter As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_account As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_account As System.Windows.Forms.TextBox
    Friend WithEvents lbl_phone As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents _74507DataSet As App_BugTracker._74507DataSet
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As App_BugTracker._74507DataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents chb_alls As System.Windows.Forms.CheckBox
    Friend WithEvents btn_consulta As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents dgv_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents col_id_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_n_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cuenta_bancaria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
