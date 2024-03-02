Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Form2
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Private NameValid As Boolean
    Private Emailvalid As Boolean
    Private Phonevalid As Boolean


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.;Initial Catalog=Safotraindb;Integrated Security=True")




    End Sub

    Private Sub txtsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      

    End Sub

    Private Sub txtcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcancel.Click
        Me.Close()
        Form1.Show()


    End Sub

    Private Sub txtsubmit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubmit.Click
        con.Open()
        cmd = New SqlCommand("insert into register (name,contact,email,gender,address,state,dob,postalcode,username,password) values('" + txtname.Text + "','" + txtnum.Text + "','" + txtemail.Text + "','" + txtgen.Text + "','" + txtadd.Text + "','" + txtst.Text + "','" + dtpdob.Text + "','" + txtpin.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')", con)

        cmd.ExecuteNonQuery()
        MsgBox("Record insert successful !!!")
        txtname.Text = Nothing
        txtnum.Text = Nothing
        dtpdob.Text = Nothing
        txtemail.Text = Nothing
        txtpassword.Text = Nothing
        txtpin.Text = Nothing
        txtgen.Text = Nothing
        txtst.Text = Nothing
        txtadd.Text = Nothing
        txtusername.Text = Nothing

        Form1_Load(sender, e)
        con.Close()
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        If Not Regex.Match(txtname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
        End If
        
    End Sub

    Private Sub txtemail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Leave
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
     ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
     RegexOptions.IgnoreCase _
     Or RegexOptions.CultureInvariant _
     Or RegexOptions.IgnorePatternWhitespace _
     Or RegexOptions.Compiled _
     )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtemail.Text)

        If blnPossibleMatch Then

            'Check If Entered Email Is In Correct Format
            If Not txtemail.Text.Equals(reEmail.Match(txtemail.Text).ToString) Then

                MessageBox.Show("Invalid Email Address!")

            Else

                Emailvalid = True 'Email is Perfect

            End If

        Else 'Not A Match To Pattern

            Emailvalid = False 'Set Boolean Variable To False

            MessageBox.Show("Invalid Email Address!") 'Inform User

            txtemail.Clear() 'Clear Textbox

            txtemail.Focus() 'Set Focus To TextBox

        End If
    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged
      
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnum.TextChanged
       
    End Sub

    Private Sub txtgen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub txtdob_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtst.TextChanged
        If Not Regex.Match(txtname.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
        End If
    End Sub

    Private Sub txtpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpin.TextChanged
        If Not Regex.Match(txtnum.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Number Only!")
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpdob.ValueChanged

    End Sub
End Class
