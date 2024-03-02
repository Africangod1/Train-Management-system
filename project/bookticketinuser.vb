Imports System.Data.SqlClient
Public Class bookticketinuser
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Public temps As String
    Private Sub bookticketinuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        temps = userhome.temp
        Me.Text = temps

        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        da = New SqlDataAdapter("select * from addtrain", con)

        ds = New DataSet()
        da.Fill(ds, "addtrain")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
        userhome.Show()

    End Sub

   
    Private Sub btntrnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntrnsearch.Click
        cmd = New SqlCommand("select * from addtrain where source='" + txtsrc.Text + "' and destination='" + txtdst.Text + "'", con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "addtrain")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'cmd = New SqlCommand("insert into bookticket values('" + userlogin.userid. + "'," + txtpsngr.Text + ")", con)
        'cmd.ExecuteNonQuery()
        'con.Close()
        creditdetail.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        creditdetail.txttid.Text = dr.Cells(0).Value
        creditdetail.Show()
    End Sub
End Class