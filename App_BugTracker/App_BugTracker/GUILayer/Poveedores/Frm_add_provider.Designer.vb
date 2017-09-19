<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_add_provider
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
        Me.lbl_account = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_account = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_accept = New System.Windows.Forms.Button()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_account
        '
        Me.lbl_account.AutoSize = True
        Me.lbl_account.Location = New System.Drawing.Point(9, 23)
        Me.lbl_account.Name = "lbl_account"
        Me.lbl_account.Size = New System.Drawing.Size(144, 13)
        Me.lbl_account.TabIndex = 0
        Me.lbl_account.Text = "Numero de Cuenta Bancaria:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(9, 68)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(50, 13)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Nombre: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'txt_account
        '
        Me.txt_account.Location = New System.Drawing.Point(159, 16)
        Me.txt_account.Name = "txt_account"
        Me.txt_account.Size = New System.Drawing.Size(154, 20)
        Me.txt_account.TabIndex = 3
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(159, 65)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(154, 20)
        Me.txt_name.TabIndex = 4
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(159, 112)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(154, 20)
        Me.txt_phone.TabIndex = 5
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(285, 183)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_accept
        '
        Me.btn_accept.Location = New System.Drawing.Point(175, 183)
        Me.btn_accept.Name = "btn_accept"
        Me.btn_accept.Size = New System.Drawing.Size(75, 23)
        Me.btn_accept.TabIndex = 7
        Me.btn_accept.Text = "Aceptar"
        Me.btn_accept.UseVisualStyleBackColor = True
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(9, 155)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(176, 13)
        Me.lbl_mensaje.TabIndex = 8
        Me.lbl_mensaje.Text = "* Todos los campos son obligatorios"
        '
        'Frm_add_provider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 218)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.btn_accept)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_account)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_account)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_add_provider"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agregar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_account As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_account As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_accept As System.Windows.Forms.Button
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
End Class
