Imports System.Data.SqlClient
Public Class LoginForm


    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub hapus()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub
    Sub terbuka()
        Formmenu.MasterToolStripMenuItem.Enabled = True
        Formmenu.TransaksiToolStripMenuItem.Enabled = True
        Formmenu.LaporanToolStripMenuItem.Enabled = True
        Formmenu.LogoutToolStripMenuItem.Enabled = True
        Formmenu.LoginToolStripMenuItem.Enabled = False
        Formmenu.stusername.Text = rd!Username
        Formmenu.stnama.Text = rd!Namauser
        Formmenu.ststatus.Text = rd!status

    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Then
            MsgBox("Silahkan isi username!", vbExclamation + vbRetryCancel)
            UsernameTextBox.Focus()
            Exit Sub
        End If
        If PasswordTextBox.Text = "" Then
            MsgBox("Silahkan isi Password!", vbExclamation + vbRetryCancel)
            PasswordTextBox.Focus()
            Exit Sub
        End If

        Call koneksi()
            cmd = New SqlClient.SqlCommand("select * from tbuser where Username='" & UsernameTextBox.Text & "' and Password='" & PasswordTextBox.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Formmenu.TransaksiToolStripMenuItem.Enabled = True
                Formmenu.LaporanToolStripMenuItem.Enabled = True
                Formmenu.LogoutToolStripMenuItem.Enabled = True
                Formmenu.LoginToolStripMenuItem.Enabled = False
                Formmenu.stusername.Text = rd!Username
                Formmenu.stnama.Text = rd!Namauser
                Formmenu.ststatus.Text = rd!status
                If Formmenu.ststatus.Text = "Admin" Then
                    Formmenu.MasterToolStripMenuItem.Enabled = True
                Else
                    Formmenu.MasterToolStripMenuItem.Enabled = False
                End If
                Me.Close()
                hapus()
            Else
                MessageBox.Show("Username dan Password Salah", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
            End If



    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Focus()
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
End Class
