Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Public Class Laporan_Penjualan

    Private Sub Laporan_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata(Chart1)
        'grafik()
        'Call koneksi()
        'da = New SqlDataAdapter("select * from tbgrafik", conn)
        'ds = New DataSet
        'da.Fill(ds, "tbgrafik")
        'DataGridView1.DataSource = (ds.Tables("tbgrafik"))

        'If rd.HasRows Then
        '    Chart1.Series(0).ChartType = SeriesChartType.Column
        '    Chart1.Series(1).ChartType = SeriesChartType.Column
        '    Chart1.Series(2).ChartType = SeriesChartType.Column
        '    For baris As Integer = 0 To DataGridView1.Columns.Count - 2
        '        Chart1.Series(baris).ChartType = SeriesChartType.Column
        '        Chart1.Series(baris).Points.AddXY(DataGridView1.Rows(baris).Cells(1).Value, DataGridView1.Rows(baris).Cells(2).Value)
        '        Chart1.Series(baris).Points.AddXY(DataGridView1.Rows(baris).Cells(1).Value, DataGridView1.Rows(baris).Cells(2).Value)
        '        Chart1.Series(baris).Points.AddXY(DataGridView1.Rows(baris).Cells(1).Value, DataGridView1.Rows(baris).Cells(2).Value)
        '    Next
        'End If


    End Sub



    Sub grafik()
        With Chart1
            Dim nmsiswa() As String = {"Siswa 1", "Siswa 2", "Siswa 3", "siswa 4"}
            .Series.Clear()
            For a As Integer = 0 To nmsiswa.Length - 1
                .Series.Add(nmsiswa(a))
            Next
            .Series(0).ChartType = SeriesChartType.Column
            .Series(1).ChartType = SeriesChartType.Column
            .Series(2).ChartType = SeriesChartType.Column

            .Series(0).Points.AddXY("matematika", 100)
            .Series(0).Points.AddXY("bahasa indonesia", 90)
            .Series(0).Points.AddXY("fisika", 25)

            .Series(1).Points.AddXY("Matematika", 100)
            .Series(1).Points.AddXY("Bahasa Indonesia", 80)
            .Series(1).Points.AddXY("Fisika", 54)

            .Series(2).Points.AddXY("Matematika", 35)
            .Series(2).Points.AddXY("Bahasa Indonesia", 73)
            .Series(2).Points.AddXY("Fisika", 96)

            .Series(3).Points.AddXY("Matematika", 35)
            .Series(3).Points.AddXY("Bahasa Indonesia", 73)
            .Series(3).Points.AddXY("Fisika", 96)
        End With
    End Sub
    Public Sub tampildata(ByVal chart1 As Chart)
        Call koneksi()
        cmd = New SqlCommand("select* from chartt order by id", conn)
        rd = cmd.ExecuteReader()
        rd.Read()

        Try
            While rd.Read
                With chart1
                    .ChartAreas(0).AxisX.Interval = 1
                    .ChartAreas(0).AxisX.IsStartedFromZero = True
                    .Series(0).Name = rd.Item("nama").ToString
                    .Series(0).Points.Clear()
                    For Each seri As Series In .Series
                        seri.ChartType = SeriesChartType.Column
                        seri.XValueType = ChartValueType.String
                        seri.YValueType = ChartValueType.Double
                    Next
                    Do While rd.Read
                        .Series(0).Points.AddXY(rd.Item("id").ToString,
                        rd.Item("data"))
                    Loop
                End With
            End While
        Finally
        End Try
    End Sub


End Class