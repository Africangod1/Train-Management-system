<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminhome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminhome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndeletetrain = New System.Windows.Forms.Button()
        Me.btnaddtrain = New System.Windows.Forms.Button()
        Me.btnviewcustemerregistration = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(466, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome ADMIN"
        '
        'btndeletetrain
        '
        Me.btndeletetrain.BackColor = System.Drawing.Color.Bisque
        Me.btndeletetrain.Location = New System.Drawing.Point(345, 131)
        Me.btndeletetrain.Margin = New System.Windows.Forms.Padding(4)
        Me.btndeletetrain.Name = "btndeletetrain"
        Me.btndeletetrain.Size = New System.Drawing.Size(164, 44)
        Me.btndeletetrain.TabIndex = 2
        Me.btndeletetrain.Text = "DELETE TRAIN INFO"
        Me.btndeletetrain.UseVisualStyleBackColor = False
        '
        'btnaddtrain
        '
        Me.btnaddtrain.BackColor = System.Drawing.Color.Bisque
        Me.btnaddtrain.Location = New System.Drawing.Point(105, 131)
        Me.btnaddtrain.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddtrain.Name = "btnaddtrain"
        Me.btnaddtrain.Size = New System.Drawing.Size(164, 44)
        Me.btnaddtrain.TabIndex = 4
        Me.btnaddtrain.Text = "ADD TRAIN INFO"
        Me.btnaddtrain.UseVisualStyleBackColor = False
        '
        'btnviewcustemerregistration
        '
        Me.btnviewcustemerregistration.BackColor = System.Drawing.Color.Bisque
        Me.btnviewcustemerregistration.Location = New System.Drawing.Point(567, 131)
        Me.btnviewcustemerregistration.Margin = New System.Windows.Forms.Padding(4)
        Me.btnviewcustemerregistration.Name = "btnviewcustemerregistration"
        Me.btnviewcustemerregistration.Size = New System.Drawing.Size(280, 44)
        Me.btnviewcustemerregistration.TabIndex = 5
        Me.btnviewcustemerregistration.Text = "VIEW PASSENGER TICKET PURCHASE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnviewcustemerregistration.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.project.My.Resources.Resources._4115230_cancel_close_cross_delete_114048
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1038, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Bisque
        Me.Button2.Location = New System.Drawing.Point(908, 131)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 44)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "About us"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'adminhome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.project.My.Resources.Resources.Ghana_DMU
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1135, 491)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnviewcustemerregistration)
        Me.Controls.Add(Me.btnaddtrain)
        Me.Controls.Add(Me.btndeletetrain)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "adminhome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminhome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btndeletetrain As System.Windows.Forms.Button
    Friend WithEvents btnaddtrain As System.Windows.Forms.Button
    Friend WithEvents btnviewcustemerregistration As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
