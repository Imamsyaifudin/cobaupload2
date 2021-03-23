Imports System.Data.SqlClient
Public Class FormPenjualan
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.RowIndex = DataGridView1.CurrentCell.ColumnIndex Then
            Call koneksi()
            cmd = New SqlCommand("select * from barang where kodebarang='" & DataGridView1.CurrentCell.Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim i As Integer
                i = DataGridView1.CurrentRow.Index
                DataGridView1.Rows(i).Cells(0) = rd.Item("kodebarang")
                DataGridView1.Rows(i).Cells(1) = rd.Item("Namabarang")
                'DataGridView1.Rows(i).Cells(2) = rd.Item("kodebarang")
                'DataGridView1.Rows(i).Cells(3) = rd.Item("kodebarang")
                'DataGridView1.Rows(i).Cells(4) = rd.Item("kodebarang")



            Else
                Daftar_Barang.ShowDialog()
            End If
        End If
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class