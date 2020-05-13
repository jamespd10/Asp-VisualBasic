Imports System.Data.SqlClient
Public Class FrmCPropietario
    'Declaracion de variables
    Dim cadena As String
    'Declaracion de objetos
    Dim ds As New DataSet()
    Dim dapt As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
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

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        FrmCInventario.Show()
        Me.Close()
    End Sub

    Private Sub ApartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartamentoToolStripMenuItem.Click
        FrmCApartamentos.Show()
        Me.Close()
    End Sub

    Private Sub FrmCPropietario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Grid()
    End Sub

    Sub Cargar_Grid()
        'Abre la conexion
        cn.Open()
        'Variable que guarda la consulta a la BD
        cadena = "Select p.cod_pro, p.nombre, p.direccion, p.telefono, p.email, a.cod_apto, a.nombre 
                    From Propietarios p Inner Join Apartamento a
                    on p.cod_pro = a.cod_pro"
        'Carga el adaptador con la consulta y la conexion
        dapt = New SqlDataAdapter(cadena, cn)
        'Utiliza el adaptador para llenar el dataset con una tabla
        Dim dt As New DataTable("Propietarios_Apartamento")

        dapt.Fill(dt)
        'Cierra la conexion
        cn.Close()

        'Cuando nos desconectamos, recorremos la tabla del dataset
        dgvPropietario.DataSource = dt

    End Sub
End Class