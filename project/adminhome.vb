Imports System.Data.SqlClient
Public Class adminhome
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddtrain.Click
        addtrain.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewcustemerregistration.Click
        custebookticketelist.Show()
        Me.Close()


    End Sub

    Private Sub btndeletetrain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeletetrain.Click
        deletetrain.Show()

        Me.Close()


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

        Form1.Show()

    End Sub

    Private Sub adminhome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        updatetrain.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        about.Show()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class