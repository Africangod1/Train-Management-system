Imports System.Data.SqlClient
Public Class deletetrain

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Private Sub deletetrain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        da = New SqlDataAdapter("select * from addtrain", con)

        ds = New DataSet()
        da.Fill(ds, "emp")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        con.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        adminhome.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("delete from addtrain where tid='" + txtdelete.Text + "'", con)
        cmd.ExecuteNonQuery()
       

        deletetrain_Load(sender, e)
        con.Close()

    End Sub
End Class