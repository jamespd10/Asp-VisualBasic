Imports System.Data.SqlClient
Public Class FrmRIngreso
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

    Sub Cargar_Grid()
        'Abre la conexion
        cn.Open()
        'Variable que guarda la consulta a la BD
        cadena = "select p.nombre As 'Propietario', Datediff(day, a.fecha_entrada, a.fecha_salida) As 'Días', 
                  a.cod_cli, a.cod_apto, ap.cost_aquiler, (Datediff(day, a.fecha_entrada, a.fecha_salida) * ap.cost_aquiler) As 
                  'Total' from Alquiler a inner join Apartamento ap
                  on ap.cod_apto = a.cod_apto inner join Propietarios p on p.cod_pro = ap.cod_pro"

        'Carga el adaptador con la consulta y la conexion
        dapt = New SqlDataAdapter(cadena, cn)
        'Utiliza el adaptador para llenar el dataset con una tabla
        Dim dt As New DataTable("Alquiler_Apartamento_Prop")

        dapt.Fill(dt)
        'Cierra la conexion
        cn.Close()

        'Cuando nos desconectamos, recorremos la tabla del dataset
        dgvRIngreso.DataSource = dt

    End Sub

    Sub Calcular_Total()
        'Abre la conexion
        cn.Open()
        cadena = “pa_Alquiler_Total"
        cmd = New SqlCommand(cadena, cn)
        cmd.CommandType = CommandType.StoredProcedure

        'Crea el Parámetro de salida para atrapar el mensaje
        cmd.Parameters.Add("@tot", SqlDbType.Int)
        cmd.Parameters(0).Direction = ParameterDirection.Output
        cmd.ExecuteNonQuery() 'se ejecuta el comando
        lblRTotal.Text = "$" & CStr(cmd.Parameters("@tot").Value) 'Se recibe el mensaje

        cn.Close()
    End Sub

    Private Sub FrmRIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Grid()
        Call Calcular_Total()
    End Sub

End Class