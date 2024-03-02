Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class addtrain
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub addtrain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttrnavl.TextChanged

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        adminhome.Show()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("insert into addtrain values(" + txttrnid.Text + ",'" + txttrnname.Text + "','" + txttrnsrc.Text + "','" + txttrndstn.Text + "','" + txttrnavl.Text + "')", con)
        cmd.ExecuteNonQuery()

        txttrnname.Text = Nothing
        txttrnavl.Text = Nothing
        txttrndstn.Text = Nothing
        txttrnid.Text = Nothing
        txttrnsrc.Text = Nothing
        MsgBox("record insert sucsessfully !!!")

    End Sub

    Private Sub txttrnid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttrnid.TextChanged
        If Not Regex.Match(txttrnid.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Number Only!")
        End If
    End Sub

    Private Sub txttrnname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttrnname.TextChanged

    End Sub
End Class