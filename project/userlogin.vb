Imports System.Data.SqlClient
Public Class userlogin
    Public userid As String
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        ' da = New SqlDataAdapter("select * from register where userid ='" + txtadminid.Text + "' and password='" + txtadminpassword.Text + "'", con)
        cmd = New SqlCommand("select * from register where username ='" + txtuserid.Text + "' and password='" + txtuserpassword.Text + "'", con)


        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            MessageBox.Show("Login successful")
            userid = txtuserid.Text
            Me.Hide()


            userhome.Show()



            Me.Close()

        Else
            MessageBox.Show("incorrect userid or password")

        End If
        con.Close()
       


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub userlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userid = txtuserid.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class