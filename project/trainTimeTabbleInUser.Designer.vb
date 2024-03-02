<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trainTimeTabbleInUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(trainTimeTabbleInUser))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtsrs = New System.Windows.Forms.TextBox()
        Me.txtdst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btntrnsearch = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 149)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(850, 262)
        Me.DataGridView1.TabIndex = 0
        '
        'txtsrs
        '
        Me.txtsrs.Location = New System.Drawing.Point(405, 80)
        Me.txtsrs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsrs.Name = "txtsrs"
        Me.txtsrs.Size = New System.Drawing.Size(132, 22)
        Me.txtsrs.TabIndex = 1
        '
        'txtdst
        '
        Me.txtdst.Location = New System.Drawing.Point(405, 110)
        Me.txtdst.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdst.Name = "txtdst"
        Me.txtdst.Size = New System.Drawing.Size(132, 22)
        Me.txtdst.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(307, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(307, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Destination"
        '
        'btntrnsearch
        '
        Me.btntrnsearch.Location = New System.Drawing.Point(633, 99)
        Me.btntrnsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btntrnsearch.Name = "btntrnsearch"
        Me.btntrnsearch.Size = New System.Drawing.Size(100, 28)
        Me.btntrnsearch.TabIndex = 5
        Me.btntrnsearch.Text = "Search"
        Me.btntrnsearch.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.BackgroundImage = Global.project.My.Resources.Resources.back_arrow__2_
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Location = New System.Drawing.Point(33, 13)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(89, 75)
        Me.btnback.TabIndex = 6
        Me.btnback.UseVisualStyleBackColor = False
        '
        'trainTimeTabbleInUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project.My.Resources.Resources.IMG_3849
        Me.ClientSize = New System.Drawing.Size(923, 492)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btntrnsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdst)
        Me.Controls.Add(Me.txtsrs)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "trainTimeTabbleInUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "trainTimeTabbleInUser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtsrs As System.Windows.Forms.TextBox
    Friend WithEvents txtdst As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btntrnsearch As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
