Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")




    End Sub

    Private Sub txtsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'con.Open()
        'cmd = New SqlCommand("insert into register values('" + txtname.Text + "','" + txtnum.Text + "','" + txtemail.Text + "','" + txtgen.Text + "','" + txtadd.Text + "','" + txtst.Text + "','" + txtdob.Text + "','" + txtpin.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')", con)

        'cmd.ExecuteNonQuery()
        'Form1_Load(sender, e)
        'con.Close()

    End Sub

  

    Private Sub Register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Register.Click
        Form2.Show()
    End Sub

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        userlogin.Show()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginadmin.Click
        Form3.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
