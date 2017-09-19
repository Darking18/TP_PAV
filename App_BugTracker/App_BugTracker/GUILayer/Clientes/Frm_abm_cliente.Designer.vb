<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_abm_cliente
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
        Me.Text_telefono = New System.Windows.Forms.TextBox()
        Me.Text_direccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Text_dni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Text_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Text_telefono
        '
        Me.Text_telefono.Location = New System.Drawing.Point(131, 64)
        Me.Text_telefono.Name = "Text_telefono"
        Me.Text_telefono.Size = New System.Drawing.Size(114, 20)
        Me.Text_telefono.TabIndex = 30
        '
        'Text_direccion
        '
        Me.Text_direccion.Location = New System.Drawing.Point(130, 92)
        Me.Text_direccion.Name = "Text_direccion"
        Me.Text_direccion.Size = New System.Drawing.Size(115, 20)
        Me.Text_direccion.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Telefono: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Direccion: "
        '
        'Text_dni
        '
        Me.Text_dni.Location = New System.Drawing.Point(131, 38)
        Me.Text_dni.Name = "Text_dni"
        Me.Text_dni.Size = New System.Drawing.Size(100, 20)
        Me.Text_dni.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Apellido y Nombre:"
        '
        'Text_nombre
        '
        Me.Text_nombre.Location = New System.Drawing.Point(131, 12)
        Me.Text_nombre.Name = "Text_nombre"
        Me.Text_nombre.Size = New System.Drawing.Size(181, 20)
        Me.Text_nombre.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "DNI:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(170, 136)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(80, 23)
        Me.btn_cancelar.TabIndex = 32
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(86, 136)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(78, 23)
        Me.btn_aceptar.TabIndex = 31
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Frm_abm_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 190)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Text_telefono)
        Me.Controls.Add(Me.Text_direccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Text_dni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Frm_abm_cliente"
        Me.Text = "Nuevo Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Text_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Text_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Text_dni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Text_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
End Class
