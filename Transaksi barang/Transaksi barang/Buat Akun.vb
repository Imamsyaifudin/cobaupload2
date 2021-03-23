Imports System.Data.SqlClient
Public Class Buat_Akun
    Sub terkunci()
        txnama.Enabled = False
        txusername.Enabled = False
        txpassword.Enabled = False
        cbstatus.Enabled = False

        btncreate.Text = "CREATE"
        btnupdate.Text = "UPDATE"
        btndelete.Text = "DELETE"

        btncreate.Enabled = True
        btnupdate.Enabled = True
        btndelete.Enabled = True
    End Sub
    Sub terbuka()
        txnama.Enabled = True
        txusername.Enabled = True
        txpassword.Enabled = True
        cbstatus.Enabled = True

    End Sub
    Sub hapus()
        txnama.Clear()
        txusername.Clear()
        txpassword.Clear()
        cbstatus.Items.Clear()
        cbstatus.Items.Add("Admin")
        cbstatus.Items.Add("User")
    End Sub


    Private Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("select*from tbuser", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbuser")
        DataGridView1.DataSource = (ds.Tables("tbuser"))

        cbstatus.Items.Clear()
        cbstatus.Items.Add("Admin")
        cbstatus.Items.Add("User")


    End Sub
    Private Sub Buat_Akun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiawal()
        txpassword.UseSystemPasswordChar = True
        terkunci()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txpassword.UseSystemPasswordChar = False
        Else
            txpassword.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub txnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txnama.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New SqlCommand("select* from tbuser where namauser='" & txnama.Text & "'", conn)
            rd = cmd.ExecuteReader()
            rd.Read()
            If rd.HasRows Then
                txusername.Enabled = True
                txpassword.Enabled = True
                cbstatus.Enabled = True
                txnama.Text = rd.Item("namauser")
                txusername.Text = rd.Item("username")
                txpassword.Text = rd.Item("password")
                cbstatus.Text = rd.Item("status")
            Else
                MsgBox("Data tidak ditemukan")
            End If

        End If


    End Sub




    Private Sub txcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txcari.KeyPress
        Call koneksi()
        Dim ds As DataSet = New DataSet
        Dim adapter As New SqlDataAdapter
        Dim sql As String
        If e.KeyChar = Chr(13) Then
            Try
                If txcari.Text = "" Then
                    sql = "select * from tbuser"
                Else
                    sql = "select * from tbuser where namauser like '%" & txcari.Text & "%'"
                End If

                adapter.SelectCommand = New SqlCommand(sql, conn)
                adapter.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.Refresh()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        If btncreate.Text = "CREATE" Then
            btncreate.Text = "SAVE"
            btnupdate.Enabled = False
            btndelete.Enabled = False
            btnexit.Text = "CANCEL"
            terbuka()
            txnama.Focus()
        Else
            If txnama.Text = "" Then
                MsgBox("Nama harus diisi")
                txnama.Focus()
                Exit Sub
            End If
            If txusername.Text = "" Then
                MsgBox("Username harus diisi")
                txusername.Focus()
                Exit Sub
            End If
            If txpassword.Text = "" Then
                MsgBox("Password harus diisi")
                txpassword.Focus()
                Exit Sub
            End If
            If cbstatus.Text = "" Then
                MsgBox("Status harus diisi")
                cbstatus.Focus()
                Exit Sub
            End If

            Try
                Call koneksi()
                Dim inputdata As String = "insert into tbuser (namauser,username,password,status) values ('" & txnama.Text & "','" & txusername.Text & "','" & txpassword.Text & "','" & cbstatus.Text & "')"
                cmd = New SqlCommand(inputdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Akun Berhasil Dibuat")
                Call kondisiawal()
                terkunci()
                hapus()

            Catch ex As Exception
                If ex.Message.Contains("PRIMARY") Then
                    MsgBox("Username Sudah Terpakai")
                    txusername.Focus()
                Else
                    MsgBox(ex.Message)
                End If

            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "UPDATE" Then
            btnupdate.Text = "SAVE"
            btncreate.Enabled = False
            btndelete.Enabled = False
            btnexit.Text = "CANCEL"
            terbuka()
            txnama.Focus()
            txusername.Enabled = False
            txpassword.Enabled = False
            cbstatus.Enabled = False
        Else
            If txnama.Text = "" Then
                MsgBox("Nama harus diisi")
                txnama.Focus()
                Exit Sub
            End If
            If txusername.Text = "" Then
                MsgBox("Username harus diisi")
                txusername.Focus()
                Exit Sub
            End If
            If txpassword.Text = "" Then
                MsgBox("Password harus diisi")
                txpassword.Focus()
                Exit Sub
            End If
            If cbstatus.Text = "" Then
                MsgBox("Status harus diisi")
                cbstatus.Focus()
                Exit Sub
            End If

            Call koneksi()
            Dim editdata As String = "update tbuser set namauser='" & txnama.Text & "',password='" & txpassword.Text & "',status='" & cbstatus.Text & "' where username='" & txusername.Text & "'"
            cmd = New SqlCommand(editdata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil diedit")
            Call kondisiawal()
            terkunci()
            hapus()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If btndelete.Text = "DELETE" Then
            btndelete.Text = "SAVE"
            btncreate.Enabled = False
            btnupdate.Enabled = False
            btnexit.Text = "CANCEL"
            terbuka()
            txnama.Focus()
            txusername.Enabled = False
            txpassword.Enabled = False
            cbstatus.Enabled = False

        Else

            If txnama.Text = "" Then
                MsgBox("Nama harus diisi")
                txnama.Focus()
                Exit Sub
            End If
            If txusername.Text = "" Then
                MsgBox("Username harus diisi")
                txusername.Focus()
                Exit Sub
            End If
            If txpassword.Text = "" Then
                MsgBox("Password harus diisi")
                txpassword.Focus()
                Exit Sub
            End If
            If cbstatus.Text = "" Then
                MsgBox("Status harus diisi")
                cbstatus.Focus()
                Exit Sub
            End If

            Call koneksi()
            Dim hapusdata As String = "delete tbuser where username='" & txusername.Text & "' or namauser='" & txnama.Text & "'"
            cmd = New SqlCommand(hapusdata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Akun Berhasil dihapus")
            Call kondisiawal()
            terkunci()
            hapus()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        hapus()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If btnexit.Text = "CANCEL" Then
            btnexit.Text = "EXIT"
            hapus()
            terkunci()
        Else
            Me.Close()
        End If

    End Sub

End Class