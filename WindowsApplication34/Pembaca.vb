Imports System.IO

Public Class Pembaca

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rt_buka_file.Text = System.IO.File.ReadAllText(cmb_pilih_file.Text + ".txt")
    End Sub

    Private Sub Pembaca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each filename As String In Directory.GetFiles(Application.StartupPath, "*txt*", SearchOption.AllDirectories)
            cmb_pilih_file.Items.Add(Replace(filename, Application.StartupPath + "\", "").Replace(".txt", ""))
        Next filename
    End Sub
End Class