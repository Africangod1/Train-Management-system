Imports System.Data.SqlClient
Public Class custebookticketelist
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        adminhome.Show()

    End Sub

    Private Sub custebookticketelist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        da = New SqlDataAdapter("select * from bookticket", con)

        ds = New DataSet()
        da.Fill(ds, "bookticket")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class