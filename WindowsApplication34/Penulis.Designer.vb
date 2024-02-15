<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penulis
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rt_buka_file = New System.Windows.Forms.RichTextBox()
        Me.cmb_pilih_file = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pembaca"
        '
        'rt_buka_file
        '
        Me.rt_buka_file.Location = New System.Drawing.Point(12, 115)
        Me.rt_buka_file.Name = "rt_buka_file"
        Me.rt_buka_file.Size = New System.Drawing.Size(875, 261)
        Me.rt_buka_file.TabIndex = 2
        Me.rt_buka_file.Text = ""
        '
        'cmb_pilih_file
        '
        Me.cmb_pilih_file.FormattingEnabled = True
        Me.cmb_pilih_file.Items.AddRange(New Object() {"Tes"})
        Me.cmb_pilih_file.Location = New System.Drawing.Point(681, 79)
        Me.cmb_pilih_file.Name = "cmb_pilih_file"
        Me.cmb_pilih_file.Size = New System.Drawing.Size(125, 21)
        Me.cmb_pilih_file.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(812, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Penulis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 388)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_pilih_file)
        Me.Controls.Add(Me.rt_buka_file)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penulis"
        Me.Text = "Penulis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rt_buka_file As System.Windows.Forms.RichTextBox
    Friend WithEvents cmb_pilih_file As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
