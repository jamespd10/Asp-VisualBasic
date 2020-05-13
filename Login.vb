Public Class FrmLogin
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If txtUsuario.Text = "administrador" And txtContraseña.Text = "123" Then
            FrmMantenimiento.Show()
            Me.Close()

        Else
            MsgBox("Contraseña o usuario incorrectos", vbCritical)

        End If
    End Sub

    Private Sub TxtUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        If txtUsuario.Text = "" Then
            MsgBox("Ingrese un usuario", vbCritical)
        End If
    End Sub

    Private Sub TxtContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
        If txtContraseña.Text = "" Then
            MsgBox("Ingrese una contraseña", vbCritical)
        End If
    End Sub
End Class