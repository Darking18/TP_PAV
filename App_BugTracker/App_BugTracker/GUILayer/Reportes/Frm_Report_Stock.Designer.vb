<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Report_Stock
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rv_stock = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.StockSource = New App_BugTracker.StockSource()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.StockSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rv_stock
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.StockBindingSource
        Me.rv_stock.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rv_stock.LocalReport.ReportEmbeddedResource = "App_BugTracker.ReportStock.rdlc"
        Me.rv_stock.Location = New System.Drawing.Point(12, 12)
        Me.rv_stock.Name = "rv_stock"
        Me.rv_stock.Size = New System.Drawing.Size(700, 453)
        Me.rv_stock.TabIndex = 0
        '
        'StockSource
        '
        Me.StockSource.DataSetName = "StockSource"
        Me.StockSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.StockSource
        '
        'Frm_Report_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 477)
        Me.Controls.Add(Me.rv_stock)
        Me.Name = "Frm_Report_Stock"
        Me.Text = "Reporte de Stock"
        CType(Me.StockSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rv_stock As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockSource As App_BugTracker.StockSource
End Class
