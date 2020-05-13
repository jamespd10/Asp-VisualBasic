Imports System.Data.SqlClient
Public Class FrmRCliente
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

    Private Sub MantenimientoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem1.Click
        FrmRMantenimiento.Show()
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

    Private Sub FrmRCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Grid()
        Call Calcular_Total()
    End Sub

    Sub Cargar_Grid()
        'Abre la conexion
        cn.Open()
        'Variable que guarda la consulta a la BD
        cadena = "Select * from Clientes"
        'Carga el adaptador con la consulta y la conexion
        dapt = New SqlDataAdapter(cadena, cn)
        'Utiliza el adaptador para llenar el dataset con una tabla
        dapt.Fill(ds, "Clientes")
        'Cierra la conexion
        cn.Close()

        'Cuando nos desconectamos, recorremos la tabla del dataset
        dgvRCliente.DataSource = ds
        dgvRCliente.DataMember = "Clientes"
    End Sub

    Sub Calcular_Total()
        'Abre la conexion
        cn.Open()
        cadena = “pa_Clientes_Total"
        cmd = New SqlCommand(cadena, cn)
        cmd.CommandType = CommandType.StoredProcedure

        'Crea el Parámetro de salida para atrapar el mensaje
        cmd.Parameters.Add("@tot", SqlDbType.Int)
        cmd.Parameters(0).Direction = ParameterDirection.Output
        cmd.ExecuteNonQuery() 'se ejecuta el comando
        lblRTotal.Text = CStr(cmd.Parameters("@tot").Value) 'Se recibe el mensaje

        cn.Close()
    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        Call Cargar_Grid()
        Call Conectar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim id As Integer
        Dim cadena As String

        cn.Open()
        If cn.State = ConnectionState.Open Then
            Try
                If txtCCodigo.Text <> " " Then
                    cadena = ("Select * from Clientes where cod_cli =" & CInt(txtCCodigo.Text) & "")

                    cmd = New SqlCommand(cadena, cn)

                    'Carga el adaptador con la consulta y la conexion
                    dapt = New SqlDataAdapter(cadena, cn)

                    'Limpiar el Dataset
                    ds.Clear()
                    'Utiliza el adaptador para llenar el dataset con una tabla
                    dapt.Fill(ds, "Clientes")
                    'Cierra la conexion
                    cn.Close()

                    'Cuando nos desconectamos, recorremos la tabla del dataset
                    dgvRCliente.DataSource = ds
                    dgvRCliente.DataMember = "Clientes"
                End If

            Catch ex As Exception
                MsgBox("Error..." & ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        Else
            MsgBox("Error...conexion cerrada", MsgBoxStyle.Critical, "ERROR")
        End If


    End Sub
End Class