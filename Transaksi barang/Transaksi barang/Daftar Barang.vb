Imports System.Data.SqlClient
Public Class Daftar_Barang
    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("select * from barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "barang")
        DataGridView1.DataSource = (ds.Tables("barang"))
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            da = New SqlDataAdapter("select * from barang where namabarang like'%" & txtcari.Text & "%' or kodebarang like'%" & txtcari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        End If



        'If e.KeyChar = Chr(13) Then
        '    Call koneksi()
        '    cmd = New SqlCommand("select * from barang where namabarang like'%" & txtcari.Text & "%' or kodebarang like'%" & txtcari.Text & "%'", conn)
        '    rd = cmd.ExecuteReader
        '    rd.Read()
        '    If rd.HasRows Then
        '        Call koneksi()
        '        da = New SqlDataAdapter("select * from barang where namabrg Like'%" & txtcari.Text & "%'", conn)
        '        ds = New DataSet
        '        da.Fill(ds)
        '        DataGridView1.DataSource = ds.Tables(0)
        '    Else
        '        MsgBox("data tidak ditemukan")
        '    End If
        'End If
    End Sub


    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        On Error Resume Next
        Penjualan.txkdbrg.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Penjualan.txnamabarang.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Penjualan.txhargajual.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Me.Close()
    End Sub


    Private Sub Daftar_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
    End Sub
End Class