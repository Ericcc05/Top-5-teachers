<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.picTeach1 = New System.Windows.Forms.PictureBox()
        CType(Me.picTeach1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Items.AddRange(New Object() {"Teacher 1", "Teacher 2", "Teacher 3 ", "Teacher 4 ", "Teacher 5"})
        Me.ListBox1.Location = New System.Drawing.Point(605, 90)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(183, 159)
        Me.ListBox1.TabIndex = 0
        '
        'picTeach1
        '
        Me.picTeach1.Image = Global.Top_5_teachers.My.Resources.Resources.ms_green
        Me.picTeach1.Location = New System.Drawing.Point(153, 62)
        Me.picTeach1.Name = "picTeach1"
        Me.picTeach1.Size = New System.Drawing.Size(189, 187)
        Me.picTeach1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeach1.TabIndex = 1
        Me.picTeach1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picTeach1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picTeach1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents picTeach1 As PictureBox
End Class
