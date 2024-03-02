Imports System.Data.SqlClient
Public Class Form3

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        ' da = New SqlDataAdapter("select * from register where userid ='" + txtadminid.Text + "' and password='" + txtadminpassword.Text + "'", con)
        cmd = New SqlCommand("select * from adminlogin where id ='" + txtadminid.Text + "' and password='" + txtadminpassword.Text + "'", con)


        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            MessageBox.Show("Login successful")
            adminhome.Show()

            Me.Close()

        Else
            MessageBox.Show("incorrect userid or password")

        End If

        ' ds = New DataSet()
        '  da.Fill(ds, "emp")
        ' DataGridView1.DataSource = ds.Tables(0).DefaultView

        con.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class