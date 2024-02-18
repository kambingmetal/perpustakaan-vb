Imports System.IO
Public Class Penulis

    Sub getFilename()
        cmb_pilih_file.Items.Clear()
        For Each filename As String In Directory.GetFiles(Application.StartupPath, "*txt*", SearchOption.AllDirectories)
            cmb_pilih_file.Items.Add(Replace(filename, Application.StartupPath + "\", "").Replace(".txt", ""))
        Next filename
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pilih.Click
        rt_isi_file.Text = System.IO.File.ReadAllText(cmb_pilih_file.Text + ".txt")
    End Sub

    Private Sub btn_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tambah.Click
        Using fs As FileStream = File.Create(txt_tambah.Text + ".txt")
            ' untuk mennutup secara otomatis setelah selesai
        End Using
        MsgBox("File baru berhasil ditambahkan!")
        txt_tambah.Text = ""
        getFilename()
    End Sub

    Private Sub Penulis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getFilename()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If cmb_pilih_file.Text = "" Then
            MsgBox("Pilih file terlebih dahulu!")
        Else
            System.IO.File.WriteAllText(cmb_pilih_file.Text + ".txt", rt_isi_file.Text)
            MsgBox("Konten Berhasil Di Update!")
        End If
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        If cmb_pilih_file.Text = "" Then
            MsgBox("Pilih file terlebih dahulu!")
        Else
            System.IO.File.Delete(cmb_pilih_file.Text + ".txt")
            cmb_pilih_file.Text = ""
            rt_isi_file.Text = ""
            MsgBox("Buku berhasil dihapus!")
            getFilename()
        End If
    End Sub

    Private Sub txt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_logout.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class