Public Class gg
    Dim a1 As Integer


    Private Sub главная_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub c1_MouseEnter(sender As Object, e As EventArgs) Handles c1.MouseEnter
        Randomize()
        c1.Top = (Me.Size.Height - c1.Size.Height) * Rnd()
        c1.Left = (Me.Size.Width - c1.Size.Width) * Rnd()
        a1 = a1 + 1
        c1.Text = a1
    End Sub

    Private Sub c1_MouseHover(sender As Object, e As EventArgs) Handles c1.MouseHover
        Randomize()
        c1.Top = (Me.Size.Height - c1.Size.Height) * Rnd()
        c1.Left = (Me.Size.Width - c1.Size.Width) * Rnd()
        a1 = a1 + 1
        c1.Text = a1
    End Sub
End Class
