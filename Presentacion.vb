Public Class FrmPresentacion
    Private Sub IniciarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesiónToolStripMenuItem.Click
        FrmLogin.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conectar()
    End Sub
End Class
