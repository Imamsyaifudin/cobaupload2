<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kdbarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namabrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrgjual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jmlbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalharga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdbarang, Me.namabrg, Me.hrgjual, Me.jmlbrg, Me.totalharga})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 385)
        Me.DataGridView1.TabIndex = 51
        '
        'kdbarang
        '
        Me.kdbarang.HeaderText = "Kode Barang"
        Me.kdbarang.Name = "kdbarang"
        '
        'namabrg
        '
        Me.namabrg.HeaderText = "Nama Barang"
        Me.namabrg.Name = "namabrg"
        Me.namabrg.Width = 200
        '
        'hrgjual
        '
        Me.hrgjual.HeaderText = "Harga Jual"
        Me.hrgjual.Name = "hrgjual"
        Me.hrgjual.Width = 175
        '
        'jmlbrg
        '
        Me.jmlbrg.HeaderText = "Jumlah Barang"
        Me.jmlbrg.Name = "jmlbrg"
        '
        'totalharga
        '
        Me.totalharga.HeaderText = "Total Harga"
        Me.totalharga.Name = "totalharga"
        Me.totalharga.Width = 175
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents kdbarang As DataGridViewTextBoxColumn
    Friend WithEvents namabrg As DataGridViewTextBoxColumn
    Friend WithEvents hrgjual As DataGridViewTextBoxColumn
    Friend WithEvents jmlbrg As DataGridViewTextBoxColumn
    Friend WithEvents totalharga As DataGridViewTextBoxColumn
End Class
