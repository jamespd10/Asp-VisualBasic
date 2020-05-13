Public Class FrmMantenimiento
    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        FrmAdicionar.Show()
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        FrmEliminar.Show()
        Me.Close()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        FrmModificar.Show()
        Me.Close()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        FrmRIngreso.Show()
        Me.Close()
    End Sub

    Private Sub MantenimientoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem1.Click
        FrmRMantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        FrmRCliente.Show()
        Me.Close()
    End Sub

    Private Sub PropietarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropietarioToolStripMenuItem.Click
        FrmCPropietario.Show()
        Me.Close()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        FrmCInventario.Show()
        Me.Close()
    End Sub
    Private Sub ApartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartamentoToolStripMenuItem.Click
        FrmCApartamentos.Show()
        Me.Close()
    End Sub

End Class