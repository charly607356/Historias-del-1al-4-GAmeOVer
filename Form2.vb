Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = My.Settings.Usuario
        Label6.Text = My.Settings.Email

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Visible = False
        Form3.Visible = True

    End Sub
End Class