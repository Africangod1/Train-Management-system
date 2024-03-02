Imports System.Data.SqlClient
Public Class trainTimeTabbleInUser
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Public tempss As String
    Private Sub trainTimeTabbleInUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        da = New SqlDataAdapter("select * from addtrain", con)

        ds = New DataSet()
        da.Fill(ds, "addtrain")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
       
        tempss = userhome.temp
        Me.Text = tempss






    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        userhome.Show()

    End Sub

    Private Sub btntrnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntrnsearch.Click

        cmd = New SqlCommand("select * from addtrain where source='" + txtsrs.Text + "' and destination='" + txtdst.Text + "'", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "addtrain")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
    End Sub
End Class