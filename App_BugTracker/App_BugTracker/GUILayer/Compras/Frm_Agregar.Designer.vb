<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Agregar
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_payform = New System.Windows.Forms.Label()
        Me.txt_product = New System.Windows.Forms.TextBox()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.cbo_payform = New System.Windows.Forms.ComboBox()
        Me.cbo_proveedor = New System.Windows.Forms.ComboBox()
        Me.lbl_advise = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(325, 197)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 0
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(244, 197)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 1
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(12, 21)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(50, 13)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "Producto"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(12, 47)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cantidad.TabIndex = 3
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(12, 73)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(64, 13)
        Me.lbl_precio.TabIndex = 4
        Me.lbl_precio.Text = "Precio Total"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(12, 99)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbl_proveedor.TabIndex = 5
        Me.lbl_proveedor.Text = "Proveedor"
        '
        'lbl_payform
        '
        Me.lbl_payform.AutoSize = True
        Me.lbl_payform.Location = New System.Drawing.Point(12, 125)
        Me.lbl_payform.Name = "lbl_payform"
        Me.lbl_payform.Size = New System.Drawing.Size(86, 13)
        Me.lbl_payform.TabIndex = 6
        Me.lbl_payform.Text = "Metodo de Pago"
        '
        'txt_product
        '
        Me.txt_product.Location = New System.Drawing.Point(116, 14)
        Me.txt_product.Name = "txt_product"
        Me.txt_product.Size = New System.Drawing.Size(203, 20)
        Me.txt_product.TabIndex = 7
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(116, 40)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.Size = New System.Drawing.Size(203, 20)
        Me.txt_cant.TabIndex = 8
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(116, 66)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(203, 20)
        Me.txt_precio.TabIndex = 9
        '
        'cbo_payform
        '
        Me.cbo_payform.FormattingEnabled = True
        Me.cbo_payform.Location = New System.Drawing.Point(116, 122)
        Me.cbo_payform.Name = "cbo_payform"
        Me.cbo_payform.Size = New System.Drawing.Size(203, 21)
        Me.cbo_payform.TabIndex = 12
        '
        'cbo_proveedor
        '
        Me.cbo_proveedor.FormattingEnabled = True
        Me.cbo_proveedor.Location = New System.Drawing.Point(116, 93)
        Me.cbo_proveedor.Name = "cbo_proveedor"
        Me.cbo_proveedor.Size = New System.Drawing.Size(203, 21)
        Me.cbo_proveedor.TabIndex = 13
        '
        'lbl_advise
        '
        Me.lbl_advise.AutoSize = True
        Me.lbl_advise.Location = New System.Drawing.Point(12, 184)
        Me.lbl_advise.Name = "lbl_advise"
        Me.lbl_advise.Size = New System.Drawing.Size(169, 13)
        Me.lbl_advise.TabIndex = 14
        Me.lbl_advise.Text = "Todos los campos son obligatorios"
        '
        'Frm_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 233)
        Me.Controls.Add(Me.lbl_advise)
        Me.Controls.Add(Me.cbo_proveedor)
        Me.Controls.Add(Me.cbo_payform)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_cant)
        Me.Controls.Add(Me.txt_product)
        Me.Controls.Add(Me.lbl_payform)
        Me.Controls.Add(Me.lbl_proveedor)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_product)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Agregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Compra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_product As System.Windows.Forms.Label
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_payform As System.Windows.Forms.Label
    Friend WithEvents txt_product As System.Windows.Forms.TextBox
    Friend WithEvents txt_cant As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents cbo_payform As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_advise As System.Windows.Forms.Label
End Class
