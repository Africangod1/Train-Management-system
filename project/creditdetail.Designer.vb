<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class creditdetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(creditdetail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttid = New System.Windows.Forms.TextBox()
        Me.txtcnm = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtunm = New System.Windows.Forms.TextBox()
        Me.btnbook = New System.Windows.Forms.Button()
        Me.btncncl = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtpr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbps = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teller Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Train ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telephone No" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 127)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address :"
        '
        'txttid
        '
        Me.txttid.Location = New System.Drawing.Point(142, 59)
        Me.txttid.Margin = New System.Windows.Forms.Padding(4)
        Me.txttid.Name = "txttid"
        Me.txttid.Size = New System.Drawing.Size(152, 22)
        Me.txttid.TabIndex = 6
        '
        'txtcnm
        '
        Me.txtcnm.Location = New System.Drawing.Point(142, 157)
        Me.txtcnm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcnm.Name = "txtcnm"
        Me.txtcnm.Size = New System.Drawing.Size(152, 22)
        Me.txtcnm.TabIndex = 7
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(142, 122)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(152, 22)
        Me.txtaddress.TabIndex = 10
        '
        'txtunm
        '
        Me.txtunm.Location = New System.Drawing.Point(142, 90)
        Me.txtunm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtunm.Name = "txtunm"
        Me.txtunm.Size = New System.Drawing.Size(152, 22)
        Me.txtunm.TabIndex = 11
        '
        'btnbook
        '
        Me.btnbook.BackColor = System.Drawing.Color.Bisque
        Me.btnbook.Location = New System.Drawing.Point(81, 335)
        Me.btnbook.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbook.Name = "btnbook"
        Me.btnbook.Size = New System.Drawing.Size(100, 28)
        Me.btnbook.TabIndex = 12
        Me.btnbook.Text = "Submit"
        Me.btnbook.UseVisualStyleBackColor = False
        '
        'btncncl
        '
        Me.btncncl.BackColor = System.Drawing.Color.Bisque
        Me.btncncl.Location = New System.Drawing.Point(294, 335)
        Me.btncncl.Margin = New System.Windows.Forms.Padding(4)
        Me.btncncl.Name = "btncncl"
        Me.btncncl.Size = New System.Drawing.Size(109, 28)
        Me.btncncl.TabIndex = 13
        Me.btncncl.Text = "cancel"
        Me.btncncl.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(452, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(670, 310)
        Me.DataGridView1.TabIndex = 14
        '
        'txtpr
        '
        Me.txtpr.Location = New System.Drawing.Point(142, 225)
        Me.txtpr.Name = "txtpr"
        Me.txtpr.Size = New System.Drawing.Size(152, 22)
        Me.txtpr.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Passengers:"
        '
        'cmbps
        '
        Me.cmbps.FormattingEnabled = True
        Me.cmbps.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbps.Location = New System.Drawing.Point(142, 187)
        Me.cmbps.Name = "cmbps"
        Me.cmbps.Size = New System.Drawing.Size(152, 24)
        Me.cmbps.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Bisque
        Me.Button2.Location = New System.Drawing.Point(727, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 39)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "\"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtpr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbps)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txttid)
        Me.Panel1.Controls.Add(Me.txtcnm)
        Me.Panel1.Controls.Add(Me.txtunm)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Location = New System.Drawing.Point(63, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 302)
        Me.Panel1.TabIndex = 21
        '
        'creditdetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1158, 568)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btncncl)
        Me.Controls.Add(Me.btnbook)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "creditdetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "creditdetail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttid As System.Windows.Forms.TextBox
    Friend WithEvents txtcnm As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtunm As System.Windows.Forms.TextBox
    Friend WithEvents btnbook As System.Windows.Forms.Button
    Friend WithEvents btncncl As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtpr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbps As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
End Class
