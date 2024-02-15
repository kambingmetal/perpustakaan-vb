Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Anda login sebagai " + cmb_login_as.Text)
        If cmb_login_as.Text = "Penulis" Then
            Penulis.Show()
            Me.Hide()
        Else
            Pembaca.Show()
            Me.Hide()
        End If
    End Sub
End Class
