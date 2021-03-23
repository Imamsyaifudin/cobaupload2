Imports System.Data.SqlClient
Public Class Penjualan
    Sub kembalian()
        Dim total, bayar, kembali As String
        total = lbtotal.Text
        bayar = txbayar.Text
        kembali = Val(bayar) - Val(total)
        lbkembalian.Text = kembali
    End Sub
    Sub totalsemua()
        Dim total As Double = 0
        For t As Integer = 0 To DataGridView1.Rows.Count - 1
            total = total + Val(DataGridView1.Rows(t).Cells(4).Value)
        Next
        lbtotal.Text = total
    End Sub
    Sub awal()
        btninput.Text = "Input"
        btnexit.Text = "Exit"
        txkdpenjualan.Enabled = False
        txnamapembeli.Enabled = False
        txkdbrg.Enabled = False
        txhargajual.Enabled = False
        txjmlbrg.Enabled = False
        txnamabarang.Enabled = False
        txtotalhrg.Enabled = False


    End Sub
    Sub terbuka()
        txkdpenjualan.Enabled = True
        txnamapembeli.Enabled = True
        txkdbrg.Enabled = True
        txhargajual.Enabled = True
        txjmlbrg.Enabled = True
        txnamabarang.Enabled = True
        txtotalhrg.Enabled = True
        txkdpenjualan.Enabled = False
        txnamapembeli.Focus()
    End Sub

    Sub hapus()
        txkdbrg.Clear()
        txnamabarang.Clear()
        txhargajual.Clear()
        txjmlbrg.Clear()
        txtotalhrg.Clear()
    End Sub
    Sub hapussemua()
        txkdpenjualan.Clear()
        txnamapembeli.Clear()
        txbayar.Clear()
        DataGridView1.Rows().Clear()
        lbtotal.Text = "0"
        lbkembalian.Text = "0"
        Call hapus()

    End Sub
    Sub kodeotomatis()
        Call koneksi()
        cmd = New SqlCommand("select * from jual where kodejual in (select max(kodejual)from jual)", conn)
        Dim urutankode As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutankode = "Kode" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            urutankode = "Kode" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txkdpenjualan.Text = urutankode
        txnamapembeli.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = “yyyy-MM-dd”
        kodeotomatis()
        awal()

    End Sub
    Private Sub txkdbrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkdbrg.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New SqlCommand("select * from barang where kodebarang='" & txkdbrg.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txkdbrg.Text = rd.Item("kodebarang")
                txnamabarang.Text = rd.Item("namabarang")
                txhargajual.Text = rd.Item("hargajual")
                txjmlbrg.Focus()
            Else
                Daftar_Barang.ShowDialog()
            End If
        End If
    End Sub

    Private Sub txjmlbrg_TextChanged(sender As Object, e As EventArgs) Handles txjmlbrg.TextChanged
        Dim harga, jumlah, total As String
        If txjmlbrg.Text = "0" Then
            MsgBox("Jumlah Pembelian kurang dari jumlah minimum ", vbOK + vbExclamation)
            txjmlbrg.Clear()
        Else
            harga = txhargajual.Text
            jumlah = txjmlbrg.Text
            total = Val(harga) * Val(jumlah)
            txtotalhrg.Text = total
        End If
    End Sub

    Private Sub txjmlbrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txjmlbrg.KeyPress
        If e.KeyChar = Chr(13) Then
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = txkdbrg.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = txnamabarang.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = txhargajual.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = txjmlbrg.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = txtotalhrg.Text
            DataGridView1.Update()
            Call hapus()
            txkdbrg.Focus()
            totalsemua()

        End If
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If btninput.Text = "Input" Then
            btninput.Text = "Simpan"
            btnexit.Text = "Batal"
            terbuka()
            kodeotomatis()
        Else
            Call koneksi()
            Dim inputdata As String = "insert into jual (kodejual,tanggal,namapembeli) values ('" & txkdpenjualan.Text & "','" & DateTimePicker1.Value.Year.ToString & "-" & DateTimePicker1.Value.Month.ToString & "-" & DateTimePicker1.Value.Day.ToString & "','" & txnamapembeli.Text & "')"
            cmd = New SqlCommand(inputdata, conn)
            cmd.ExecuteNonQuery()


            For brs = 0 To DataGridView1.RowCount - 2
                Dim inputdataa As String = "insert into detailjual (kodejual,kodebarang,jmljual,hargajual) values ('" & txkdpenjualan.Text & "','" & DataGridView1.Rows(brs).Cells(0).Value & "'," & DataGridView1.Rows(brs).Cells(3).Value & "," & Val(DataGridView1.Rows(brs).Cells(2).Value) & ")"
                cmd = New SqlCommand(inputdataa, conn)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Data Berhasil diinput")
            hapussemua()
            awal()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If btnexit.Text = "Batal" Then
            btnexit.Text = "Exit"
            btninput.Text = "Input"
            Call awal()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txnamapembeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txnamapembeli.KeyPress
        If e.KeyChar = Chr(13) Then
            txkdbrg.Focus()
        End If
    End Sub

    Private Sub txbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbayar.KeyPress
        kembalian()
    End Sub

    Private Sub lbtotal_Click(sender As Object, e As EventArgs) Handles lbtotal.Click

    End Sub

    Private Sub txtotalhrg_TextChanged(sender As Object, e As EventArgs) Handles txtotalhrg.TextChanged

    End Sub
End Class