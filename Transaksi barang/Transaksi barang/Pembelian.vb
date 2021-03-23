Imports System.Data.SqlClient
Public Class Pembelian
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
        txkdbarang.Text = urutankode


    End Sub
    Sub hapus()
        txkdbarang.Clear()
        txnamabarang.Clear()
        txhargabeli.Clear()
        txhargajual.Clear()
        txjmlbarang.Clear()
        cbsatuan.Text = ""

    End Sub
    Sub terbuka()
        txkdbarang.Enabled = True
        txnamabarang.Enabled = True
        txhargajual.Enabled = True
        txhargabeli.Enabled = True
        txjmlbarang.Enabled = True
        cbsatuan.Enabled = True

    End Sub
    Sub terkunci()
        txkdbarang.Enabled = False
        txnamabarang.Enabled = False
        txhargajual.Enabled = False
        txhargabeli.Enabled = False
        txjmlbarang.Enabled = False
        cbsatuan.Enabled = False

        btninput.Text = "INPUT"
        btnupdate.Text = "UPDATE"
        btndelete.Text = "DELETE"

        btninput.Enabled = True
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub
    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("select*from barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "barang")
        DataGridView1.DataSource = (ds.Tables("barang"))

        cbsatuan.Items.Clear()
        cbsatuan.Items.Add("PCS")
        cbsatuan.Items.Add("BOX")
        cbsatuan.Items.Add("KG")

        txkdbarang.MaxLength = 6

        btnexit.Text = "EXIT"

    End Sub
    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kodeotomatis()
        kondisiawal()
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If btninput.Text = "INPUT" Then
            btninput.Text = "SAVE"
            btnexit.Text = "CANCEL"
            btnupdate.Enabled = False
            btndelete.Enabled = False
            terbuka()
        Else
            If txkdbarang.Text = "" Then
                MsgBox("Kode Barang harus diisi")
                txkdbarang.Focus()
                Exit Sub
            End If
            If txnamabarang.Text = "" Then
                MsgBox("Nama Barang harus diisi")
                txnamabarang.Focus()
                Exit Sub
            End If
            If txhargabeli.Text = "" Then
                MsgBox("Harga Beli harus diisi")
                txhargabeli.Focus()
                Exit Sub
            End If
            If txhargajual.Text = "" Then
                MsgBox("Harga Jual harus diisi")
                txhargajual.Focus()
                Exit Sub
            End If
            If txjmlbarang.Text = "" Then
                MsgBox("Jumlah Barang harus diisi")
                txjmlbarang.Focus()
                Exit Sub
            End If
            If cbsatuan.Text = "" Then
                MsgBox("Satuan Barang harus diisi")
                cbsatuan.Focus()
                Exit Sub
            End If
            Try
                Call koneksi()
                Dim inputdata As String = "insert into barang (kodebarang,namabarang,satuan,hargabeli,hargajual,jumlahstok) values('" & txkdbarang.Text & "','" & txnamabarang.Text & "','" & cbsatuan.Text & "','" & txhargabeli.Text & "','" & txhargajual.Text & "','" & txjmlbarang.Text & "')"
                cmd = New SqlCommand(inputdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil diinput")
                Call kondisiawal()
                terkunci()
                hapus()
            Catch ex As Exception
                If ex.Message.Contains("PRIMARY") Then
                    MsgBox("Kode Barang Sudah Terpakai")
                    txkdbarang.Focus()
                Else
                    MsgBox(ex.Message)
                End If
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        'If btnupdate.Text = "UPDATE" Then
        '    'btnupdate.Text = "SAVE"
        '    'btnexit.Text = "CANCEL"
        '    'btninput.Enabled = False
        '    'btndelete.Enabled = False

        '    'txkdbarang.Enabled = True
        '    'txnamabarang.Enabled = False
        '    'txhargajual.Enabled = False
        '    'txhargabeli.Enabled = False
        '    'txjmlbarang.Enabled = False
        '    'cbsatuan.Enabled = False
        'Else

        '    Call koneksi()
        '    Dim editdata As String = "update barang set namabarang='" & txnamabarang.Text & "',satuan='" & cbsatuan.Text & "',hargabeli=" & txhargabeli.Text & ",hargajual=" & txhargajual.Text & ",jumlahstok=" & txjmlbarang.Text & " where kodebarang='" & txkdbarang.Text & "'"
        '    cmd = New SqlCommand(editdata, conn)
        '    cmd.ExecuteNonQuery()
        '    MsgBox("Data Berhasil diedit")
        '    Call kondisiawal()
        '    hapus()
        '    kodeotomatis()

        ' End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If btndelete.Text = "DELETE" Then
            btndelete.Text = "SAVE"
            btnexit.Text = "CANCEL"
            btninput.Enabled = False
            btnupdate.Enabled = False

            txkdbarang.Enabled = True
            txnamabarang.Enabled = False
            txhargajual.Enabled = False
            txhargabeli.Enabled = False
            txjmlbarang.Enabled = False
            cbsatuan.Enabled = False

        Else

        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If btnexit.Text = "CANCEL" Then
            btnexit.Text = "EXIT"
            terkunci()
            hapus()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub txkdbarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkdbarang.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New SqlCommand("select* from barang where kodebarang='" & txkdbarang.Text & "'", conn)
            rd = cmd.ExecuteReader()
            rd.Read()
            If rd.HasRows Then
                terbuka()
                txnamabarang.Text = rd.Item("namabarang")
                txhargabeli.Text = rd.Item("hargabeli")
                txhargajual.Text = rd.Item("hargajual")
                txjmlbarang.Text = rd.Item("jumlahstok")
                txkdbarang.Text = rd.Item("kodebarang")
                cbsatuan.Text = rd.Item("satuan")
                terbuka()
            Else
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        hapus()
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txkdbarang.Text = DataGridView1.Rows(i).Cells(0).Value
        txnamabarang.Text = DataGridView1.Rows(i).Cells(1).Value
        txhargabeli.Text = DataGridView1.Rows(i).Cells(2).Value
        txhargajual.Text = DataGridView1.Rows(i).Cells(3).Value
        txjmlbarang.Text = DataGridView1.Rows(i).Cells(4).Value
        cbsatuan.Text = DataGridView1.Rows(i).Cells(5).Value



    End Sub
End Class