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
        Me.rt_isi_file = New System.Windows.Forms.RichTextBox()
        Me.cmb_pilih_file = New System.Windows.Forms.ComboBox()
        Me.btn_pilih = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tambah = New System.Windows.Forms.TextBox()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Penulis"
        '
        'rt_isi_file
        '
        Me.rt_isi_file.Location = New System.Drawing.Point(12, 115)
        Me.rt_isi_file.Name = "rt_isi_file"
        Me.rt_isi_file.Size = New System.Drawing.Size(604, 261)
        Me.rt_isi_file.TabIndex = 2
        Me.rt_isi_file.Text = ""
        '
        'cmb_pilih_file
        '
        Me.cmb_pilih_file.FormattingEnabled = True
        Me.cmb_pilih_file.Items.AddRange(New Object() {"Tes"})
        Me.cmb_pilih_file.Location = New System.Drawing.Point(12, 80)
        Me.cmb_pilih_file.Name = "cmb_pilih_file"
        Me.cmb_pilih_file.Size = New System.Drawing.Size(508, 21)
        Me.cmb_pilih_file.TabIndex = 3
        '
        'btn_pilih
        '
        Me.btn_pilih.Location = New System.Drawing.Point(541, 81)
        Me.btn_pilih.Name = "btn_pilih"
        Me.btn_pilih.Size = New System.Drawing.Size(75, 23)
        Me.btn_pilih.TabIndex = 4
        Me.btn_pilih.Text = "Pilih"
        Me.btn_pilih.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(705, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tambah"
        '
        'txt_tambah
        '
        Me.txt_tambah.Location = New System.Drawing.Point(643, 137)
        Me.txt_tambah.Name = "txt_tambah"
        Me.txt_tambah.Size = New System.Drawing.Size(244, 20)
        Me.txt_tambah.TabIndex = 6
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(812, 172)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 7
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(541, 389)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "Update Isi"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Penulis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 424)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.txt_tambah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_pilih)
        Me.Controls.Add(Me.cmb_pilih_file)
        Me.Controls.Add(Me.rt_isi_file)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penulis"
        Me.Text = "Penulis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rt_isi_file As System.Windows.Forms.RichTextBox
    Friend WithEvents cmb_pilih_file As System.Windows.Forms.ComboBox
    Friend WithEvents btn_pilih As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_tambah As System.Windows.Forms.TextBox
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
End Class
