Imports System.IO

Public Class Pembaca

    Sub getFilename()
        cmb_pilih_file.Items.Clear()
        For Each filename As String In Directory.GetFiles(Application.StartupPath, "*txt*", SearchOption.AllDirectories)
            cmb_pilih_file.Items.Add(Replace(filename, Application.StartupPath + "\", "").Replace(".txt", ""))
        Next filename
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rt_buka_file.Text = System.IO.File.ReadAllText(cmb_pilih_file.Text + ".txt")
    End Sub

    Private Sub Pembaca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getFilename()
    End Sub

    Private Sub Txt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_logout.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class