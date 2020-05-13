Imports System.Data.SqlClient

Public Class FrmCInventario
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

    Private Sub PropietarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropietarioToolStripMenuItem.Click
        FrmCPropietario.Show()
        Me.Close()
    End Sub

    Private Sub ApartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartamentoToolStripMenuItem.Click
        FrmCApartamentos.Show()
        Me.Close()
    End Sub

    Private Sub FrmCInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Grid()

    End Sub

    Sub Cargar_Grid()
        'Abre la conexion
        cn.Open()
        'Variable que guarda la consulta a la BD
        cadena = "Select a.cod_apto, a.nombre, e.cod_equipo, e.descripcion, e.tipo
                    from Equipos e Inner Join Apto_Equipo ae
                    on e.cod_equipo = ae.cod_equipo
                    inner join Apartamento a on a.cod_apto = ae.cod_apto
                    order by a.cod_apto"

        'Carga el adaptador con la consulta y la conexion
        dapt = New SqlDataAdapter(cadena, cn)
        'Utiliza el adaptador para llenar el dataset con una tabla
        Dim dt As New DataTable("Equipos_Apartamento")

        dapt.Fill(dt)
        'Cierra la conexion
        cn.Close()

        'Cuando nos desconectamos, recorremos la tabla del dataset
        dgvInventario.DataSource = dt

    End Sub
End Class