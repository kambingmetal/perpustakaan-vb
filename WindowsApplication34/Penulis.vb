Imports System.IO
Public Class Penulis

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pilih.Click
        rt_isi_file.Text = System.IO.File.ReadAllText(cmb_pilih_file.Text + ".txt")
    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        System.IO.File.Create(txt_tambah.Text + ".txt")
        MsgBox("File baru berhasil ditambahkan!")
        txt_tambah.Text = ""
        cmb_pilih_file.Items.Clear()
        For Each filename As String In Directory.GetFiles(Application.StartupPath, "*txt*", SearchOption.AllDirectories)
            cmb_pilih_file.Items.Add(Replace(filename, Application.StartupPath + "\", "").Replace(".txt", ""))
        Next filename
    End Sub

    Private Sub Penulis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_pilih_file.Items.Clear()
        For Each filename As String In Directory.GetFiles(Application.StartupPath, "*txt*", SearchOption.AllDirectories)
            cmb_pilih_file.Items.Add(Replace(filename, Application.StartupPath + "\", "").Replace(".txt", ""))
        Next filename
    End Sub


    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        System.IO.File.WriteAllText(cmb_pilih_file.Text + ".txt", rt_isi_file.Text)
        MsgBox("Konten Berhasil Di Update!")
    End Sub
End Class