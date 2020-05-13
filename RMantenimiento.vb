Imports System.Data.SqlClient
Public Class FrmRMantenimiento

    'Declaracion de variables
    Dim cadena As String
    'Declaracion de Objetos
    Dim ds As New DataSet()
    Dim dapt As SqlDataAdapter
    Dim cmd As SqlCommand
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

    Private Sub FrmRMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Grid()
        Call Calcular_TotalC()
        Call Calcular_TotalR()
        Call Calcular_TotalP()

    End Sub
    Sub Cargar_Grid()
        'Abre la conexion
        cn.Open()
        'Variable que guarda la consulta a la BD
        cadena = "Select * from Mantenimiento"
        'Carga el adaptador con la consulta y la conexion
        dapt = New SqlDataAdapter(cadena, cn)
        'Utiliza el adaptador para llenar el dataset con una tabla
        dapt.Fill(ds, "Mantenimiento")
        'Cierra la conexion
        cn.Close()

        'Cuando nos desconectamos, recorremos la tabla del dataset
        dgvMantenimiento.DataSource = ds
        dgvMantenimiento.DataMember = "Mantenimiento"
    End Sub

    Sub Calcular_TotalC()
        'Abre la conexion
        cn.Open()
        cadena = “pa_MConcluido_Total"
        cmd = New SqlCommand(cadena, cn)
        cmd.CommandType = CommandType.StoredProcedure

        'Crea el Parámetro de salida para atrapar el mensaje
        cmd.Parameters.Add("@tot", SqlDbType.Int)
        cmd.Parameters(0).Direction = ParameterDirection.Output
        cmd.ExecuteNonQuery() 'se ejecuta el comando
        lblTConcluida.Text = CStr(cmd.Parameters("@tot").Value) 'Se recibe el mensaje

        cn.Close()
    End Sub

    Sub Calcular_TotalR()
        'Abre la conexion
        cn.Open()
        cadena = “pa_MReparacion_Total"
        cmd = New SqlCommand(cadena, cn)
        cmd.CommandType = CommandType.StoredProcedure

        'Crea el Parámetro de salida para atrapar el mensaje
        cmd.Parameters.Add("@tot", SqlDbType.Int)
        cmd.Parameters(0).Direction = ParameterDirection.Output
        cmd.ExecuteNonQuery() 'se ejecuta el comando
        lblTReparacion.Text = CStr(cmd.Parameters("@tot").Value) 'Se recibe el mensaje

        cn.Close()
    End Sub
    Sub Calcular_TotalP()
        'Abre la conexion
        cn.Open()
        cadena = “pa_MPendiente_Total"
        cmd = New SqlCommand(cadena, cn)
        cmd.CommandType = CommandType.StoredProcedure

        'Crea el Parámetro de salida para atrapar el mensaje
        cmd.Parameters.Add("@tot", SqlDbType.Int)
        cmd.Parameters(0).Direction = ParameterDirection.Output
        cmd.ExecuteNonQuery() 'se ejecuta el comando
        lblTPendiente.Text = CStr(cmd.Parameters("@tot").Value) 'Se recibe el mensaje

        cn.Close()
    End Sub
End Class