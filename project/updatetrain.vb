Imports System.Data.SqlClient

Public Class updatetrain
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()


        cmd = New SqlCommand("update addtrain set tname='" + txttrnname.Text + "',source ='" + txttrnsrc.Text + "', destination='" + txttrndstn.Text + "' where tid ='" + txttrnid.Text + "'", con)

        cmd.ExecuteNonQuery()


        txttrnname.Text = Nothing
        txttrnavl.Text = Nothing
        txttrndstn.Text = Nothing
        txttrnid.Text = Nothing
        txttrnsrc.Text = Nothing
        MsgBox("record Update sucsessfully !!!")
    End Sub

    Private Sub updatetrain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        adminhome.Show()

    End Sub
End Class