Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class creditdetail
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Private Sub creditdetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        da = New SqlDataAdapter("select * from bookticket", con)

        ds = New DataSet()
        da.Fill(ds, "bookticket")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        con.Close()
    End Sub

    Private Sub btnbook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbook.Click
        con.Open()
        cmd = New SqlCommand("insert into bookticket (address,contact,person,cost,trainid,username)values('" + txtaddress.Text + "','" + txtcnm.Text + "','" + cmbps.Text + "','" + txtpr.Text + "','" + txttid.Text + "','" + txtunm.Text + "')", con)


        cmd.ExecuteNonQuery()
        MsgBox("Record insert sucsessfully !!!")

        txtaddress.Text = Nothing
        txtcnm.Text = Nothing
        cmbps.Text = Nothing
        txtpr.Text = Nothing
        txttid.Text = Nothing
        txtunm.Text = Nothing
        con.Close()




    End Sub

    Private Sub btncncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncncl.Click

        bookticketinuser.Show()
        Me.Close()
    End Sub

    Private Sub txttid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttid.TextChanged
        If Not Regex.Match(txttid.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Number Only!")
        End If
    End Sub

    Private Sub txtunm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunm.TextChanged
        If Not Regex.Match(txtunm.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
        End If
    End Sub

    Private Sub txtaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaddress.TextChanged
        If Not Regex.Match(txtaddress.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
        End If
    End Sub

    Private Sub txtcnm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcnm.TextChanged
        If Not Regex.Match(txtcnm.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Number Only!")
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub

    Private Sub cmbps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbps.SelectedIndexChanged

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
        txtunm.Text = dr.Cells(0).Value
        txtaddress.Text = dr.Cells(1).Value
        txtcnm.Text = dr.Cells(2).Value
        txttid.Text = dr.Cells(3).Value
        txtpr.Text = dr.Cells(4).Value
        cmbps.Text = dr.Cells(5).Value


    End Sub
End Class
