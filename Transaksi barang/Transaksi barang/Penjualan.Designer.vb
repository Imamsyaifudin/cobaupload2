<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Me.components = New System.ComponentModel.Container()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.totalharga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jmlbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrgjual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namabrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdbarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtotalhrg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txjmlbrg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txhargajual = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txnamabarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txkdbrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txnamapembeli = New System.Windows.Forms.TextBox()
        Me.txkdpenjualan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lbtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbkembalian = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(155, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker1.TabIndex = 51
        '
        'totalharga
        '
        Me.totalharga.HeaderText = "Total Harga"
        Me.totalharga.Name = "totalharga"
        Me.totalharga.Width = 175
        '
        'jmlbrg
        '
        Me.jmlbrg.HeaderText = "Jumlah Barang"
        Me.jmlbrg.Name = "jmlbrg"
        '
        'hrgjual
        '
        Me.hrgjual.HeaderText = "Harga Jual"
        Me.hrgjual.Name = "hrgjual"
        Me.hrgjual.Width = 175
        '
        'namabrg
        '
        Me.namabrg.HeaderText = "Nama Barang"
        Me.namabrg.Name = "namabrg"
        Me.namabrg.Width = 200
        '
        'kdbarang
        '
        Me.kdbarang.HeaderText = "Kode Barang"
        Me.kdbarang.Name = "kdbarang"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdbarang, Me.namabrg, Me.hrgjual, Me.jmlbrg, Me.totalharga})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 214)
        Me.DataGridView1.TabIndex = 50
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(311, 382)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(85, 32)
        Me.btnexit.TabIndex = 49
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(220, 382)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(85, 32)
        Me.btninput.TabIndex = 48
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'txtotalhrg
        '
        Me.txtotalhrg.Location = New System.Drawing.Point(639, 122)
        Me.txtotalhrg.Name = "txtotalhrg"
        Me.txtotalhrg.Size = New System.Drawing.Size(151, 20)
        Me.txtotalhrg.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(636, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Total Harga"
        '
        'txjmlbrg
        '
        Me.txjmlbrg.Location = New System.Drawing.Point(522, 122)
        Me.txjmlbrg.Name = "txjmlbrg"
        Me.txjmlbrg.Size = New System.Drawing.Size(108, 20)
        Me.txjmlbrg.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(519, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Jumlah Barang"
        '
        'txhargajual
        '
        Me.txhargajual.Location = New System.Drawing.Point(381, 122)
        Me.txhargajual.Name = "txhargajual"
        Me.txhargajual.Size = New System.Drawing.Size(135, 20)
        Me.txhargajual.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(378, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Harga Jual"
        '
        'txnamabarang
        '
        Me.txnamabarang.Location = New System.Drawing.Point(159, 122)
        Me.txnamabarang.Name = "txnamabarang"
        Me.txnamabarang.Size = New System.Drawing.Size(216, 20)
        Me.txnamabarang.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(156, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Nama Barang"
        '
        'txkdbrg
        '
        Me.txkdbrg.Location = New System.Drawing.Point(14, 122)
        Me.txkdbrg.Name = "txkdbrg"
        Me.txkdbrg.Size = New System.Drawing.Size(136, 20)
        Me.txkdbrg.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Kode Barang"
        '
        'txnamapembeli
        '
        Me.txnamapembeli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txnamapembeli.Location = New System.Drawing.Point(155, 36)
        Me.txnamapembeli.Name = "txnamapembeli"
        Me.txnamapembeli.Size = New System.Drawing.Size(150, 20)
        Me.txnamapembeli.TabIndex = 31
        '
        'txkdpenjualan
        '
        Me.txkdpenjualan.Location = New System.Drawing.Point(155, 10)
        Me.txkdpenjualan.Name = "txkdpenjualan"
        Me.txkdpenjualan.Size = New System.Drawing.Size(150, 20)
        Me.txkdpenjualan.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Tanggal Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nama Pembeli"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(11, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 16)
        Me.label1.TabIndex = 27
        Me.label1.Text = "Kode Penjualan"
        '
        'lbtotal
        '
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.Location = New System.Drawing.Point(515, 19)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(273, 42)
        Me.lbtotal.TabIndex = 52
        Me.lbtotal.Text = "0"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(437, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 42)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Rp."
        '
        'txbayar
        '
        Me.txbayar.Location = New System.Drawing.Point(627, 368)
        Me.txbayar.Name = "txbayar"
        Me.txbayar.Size = New System.Drawing.Size(161, 20)
        Me.txbayar.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(536, 369)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Bayar"
        '
        'lbkembalian
        '
        Me.lbkembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkembalian.Location = New System.Drawing.Point(669, 391)
        Me.lbkembalian.Name = "lbkembalian"
        Me.lbkembalian.Size = New System.Drawing.Size(119, 29)
        Me.lbkembalian.TabIndex = 56
        Me.lbkembalian.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(623, 391)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 24)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Rp."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(536, 397)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 16)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Kembalian"
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbkembalian)
        Me.Controls.Add(Me.txbayar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbtotal)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.txtotalhrg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txjmlbrg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txhargajual)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txnamabarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txkdbrg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txnamapembeli)
        Me.Controls.Add(Me.txkdpenjualan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents totalharga As DataGridViewTextBoxColumn
    Friend WithEvents jmlbrg As DataGridViewTextBoxColumn
    Friend WithEvents hrgjual As DataGridViewTextBoxColumn
    Friend WithEvents namabrg As DataGridViewTextBoxColumn
    Friend WithEvents kdbarang As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnexit As Button
    Friend WithEvents btninput As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtotalhrg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txjmlbrg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txhargajual As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txnamabarang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txkdbrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txnamapembeli As TextBox
    Friend WithEvents txkdpenjualan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents lbtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txbayar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbkembalian As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
