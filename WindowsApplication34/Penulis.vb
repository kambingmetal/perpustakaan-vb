Public Class Penulis

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        rt_buka_file.Text = System.IO.File.ReadAllText(cmb_pilih_file.Text + ".txt")
    End Sub
End Class