Imports System.Data.SqlClient
Public Class Formmenu
    Sub terkunci()
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        stusername.Text = ""
        stnama.Text = ""
        ststatus.Text = ""

    End Sub

    Private Sub Formmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        terkunci()
        stjam.Text = Format(Now, "hh:mm")
        sttanggal.Text = Format(Now, "yyyy-MM-dd")

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        LoginForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim pesan As String
        pesan = MessageBox.Show("Anda yakin ingin keluar ??", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesan = vbYes Then
            terkunci()
        End If
    End Sub

    Private Sub TambahAkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAkunToolStripMenuItem.Click
        Buat_Akun.ShowDialog()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Pembelian.ShowDialog()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Penjualan.ShowDialog()
    End Sub

    Private Sub DaftarBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarBarangToolStripMenuItem.Click
        Daftar_Barang.ShowDialog()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        Laporan_Penjualan.ShowDialog()
    End Sub
End Class
