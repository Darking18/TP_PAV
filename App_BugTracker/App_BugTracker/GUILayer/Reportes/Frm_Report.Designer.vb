<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportCompra = New App_BugTracker.ReportCompra()
        Me.txt_fec_desde = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fec_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_consult = New System.Windows.Forms.Button()
        Me.rv_compra = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.ReportCompra
        '
        'ReportCompra
        '
        Me.ReportCompra.DataSetName = "ReportCompra"
        Me.ReportCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_fec_desde
        '
        Me.txt_fec_desde.Location = New System.Drawing.Point(110, 21)
        Me.txt_fec_desde.Mask = "00/00/0000"
        Me.txt_fec_desde.Name = "txt_fec_desde"
        Me.txt_fec_desde.Size = New System.Drawing.Size(100, 20)
        Me.txt_fec_desde.TabIndex = 0
        Me.txt_fec_desde.ValidatingType = GetType(Date)
        '
        'txt_fec_hasta
        '
        Me.txt_fec_hasta.Location = New System.Drawing.Point(350, 20)
        Me.txt_fec_hasta.Mask = "00/00/0000"
        Me.txt_fec_hasta.Name = "txt_fec_hasta"
        Me.txt_fec_hasta.Size = New System.Drawing.Size(100, 20)
        Me.txt_fec_hasta.TabIndex = 1
        Me.txt_fec_hasta.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha hasta:"
        '
        'btn_consult
        '
        Me.btn_consult.Location = New System.Drawing.Point(503, 14)
        Me.btn_consult.Name = "btn_consult"
        Me.btn_consult.Size = New System.Drawing.Size(85, 26)
        Me.btn_consult.TabIndex = 4
        Me.btn_consult.Text = "Consultar"
        Me.btn_consult.UseVisualStyleBackColor = True
        '
        'rv_compra
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ComprasBindingSource
        Me.rv_compra.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rv_compra.LocalReport.ReportEmbeddedResource = "App_BugTracker.Repocompra.rdlc"
        Me.rv_compra.Location = New System.Drawing.Point(12, 47)
        Me.rv_compra.Name = "rv_compra"
        Me.rv_compra.Size = New System.Drawing.Size(675, 488)
        Me.rv_compra.TabIndex = 5
        '
        'Frm_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 547)
        Me.Controls.Add(Me.rv_compra)
        Me.Controls.Add(Me.btn_consult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_fec_hasta)
        Me.Controls.Add(Me.txt_fec_desde)
        Me.Name = "Frm_Report"
        Me.Text = "Reporte de ventas"
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_fec_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fec_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_consult As System.Windows.Forms.Button
    Friend WithEvents rv_compra As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportCompra As App_BugTracker.ReportCompra
End Class
