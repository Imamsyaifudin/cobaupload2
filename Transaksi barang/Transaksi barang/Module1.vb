Imports System.Data.SqlClient
Imports System.CodeDom.Compiler
Imports Microsoft.VisualBasic
Module Module1
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Public ds As DataSet
    Public rd As SqlDataReader
    Public sqlcmd As String

    'Public mydb As String
    'Sub koneksi()
    '    mydb = "Data Source=DESKTOP-2QJ7FIF\SQLEXPRESS;Initial Catalog=dbbpenjualan;Integrated Security=True"
    '    conn = New SqlConnection(mydb)
    '    If conn.State = ConnectionState.Closed Then conn.Open()
    'End Sub
    Public mydb As String
    Sub koneksi()
        'If conn.State = ConnectionState.Closed Then
        Dim baca As New System.IO.StreamReader("C:\koneksi.txt")
        Dim HAS
        HAS = baca.ReadToEnd
        Dim mystring As String = HAS

        mydb = HAS
        conn = New SqlConnection(mydb)
        If conn.State = ConnectionState.Closed Then conn.Open()
        'Try
        '    conn.ConnectionString = mystring
        '    conn.Open()
        'Catch ex As Exception

        'End Try
        '  End If
    End Sub


End Module

