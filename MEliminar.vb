Imports System.Data.SqlClient
Public Class FrmEliminar

    'Declaracion de variables
    Dim cadena As String
    'Declaración de objetos
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

    Private Sub BtnEliminar_Apto_Click(sender As Object, e As EventArgs) Handles BtnEliminar_Apto.Click
        Dim cadena As String
        Try
            cn.Open()
            If cmbMCod_Apto.Text = "" And cmbMNombre.Text <> "" Then
                cadena = "pa_ApartNom_Eliminar"
                cmd = New SqlCommand(cadena, cn)
                cmd.CommandType = CommandType.StoredProcedure
                'Crea los Parámetros de entrada que envían los datos
                cmd.Parameters.AddWithValue("@nombre", cmbMNombre.Text)
                'Crea el Parámetro de salida para atrapar el mensaje
                cmd.Parameters.Add("@msj", SqlDbType.VarChar, 100)
                cmd.Parameters(1).Direction = ParameterDirection.Output
                cmd.ExecuteNonQuery() 'se ejecuta el comando
                MsgBox(CStr(cmd.Parameters("@msj").Value)) 'Se recibe el mensaje

            ElseIf cmbMCod_Apto.Text <> "" And cmbMNombre.Text = "" Then
                cadena = "pa_ApartCod_Eliminar"
                cmd = New SqlCommand(cadena, cn)
                cmd.CommandType = CommandType.StoredProcedure
                'Crea los Parámetros de entrada que envían los datos
                cmd.Parameters.AddWithValue("@cod_apto", cmbMCod_Apto.Text)
                'Crea el Parámetro de salida para atrapar el mensaje
                cmd.Parameters.Add("@msj", SqlDbType.VarChar, 100)
                cmd.Parameters(1).Direction = ParameterDirection.Output
                cmd.ExecuteNonQuery() 'se ejecuta el comando
                MsgBox(CStr(cmd.Parameters("@msj").Value)) 'Se recibe el mensaje

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        Console.Read()
    End Sub

    Private Sub txtCod_Apto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If cmbMCod_Apto.Text = "" Then
            MsgBox("Ingrese el Codigo de Apto", vbCritical, "Alerta")
        ElseIf Not IsNumeric(cmbMCod_Apto.Text) Then
            MsgBox("Solo se permite ingresar números", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If cmbMNombre.Text = "" Then
            MsgBox("Ingrese el Nombre del Apartamento", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub txtCodigo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If cmbMCodigo.Text = "" Then
            MsgBox("Ingrese el codigo", vbCritical, "Alerta")
        ElseIf Not IsNumeric(cmbMCodigo.Text) Then
            MsgBox("Solo se permite ingresar números", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbEstado.Validating
        If cmbEstado.Text = "" Then
            MsgBox("Ingrese el Estado del Mantenimiento", vbCritical, "Alerta")
        ElseIf cmbEstado.Text <> "P" And cmbEstado.Text <> "R" And cmbEstado.Text <> "C" Then
            MsgBox("Solo se permite ingresar los estados definidos P, R o C", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub BtnEliminar_Mant_Click(sender As Object, e As EventArgs) Handles BtnEliminarEstado_Mant.Click
        Dim cadena As String
        Try
            cn.Open()
            If cmbMCodigo.Text = "" And cmbEstado.Text <> "" Then
                cadena = "pa_MantSta_Eliminar"
                cmd = New SqlCommand(cadena, cn)
                cmd.CommandType = CommandType.StoredProcedure
                'Crea los Parámetros de entrada que envían los datos
                cmd.Parameters.AddWithValue("@status", cmbEstado.Text)
                'Crea el Parámetro de salida para atrapar el mensaje
                cmd.Parameters.Add("@msj", SqlDbType.VarChar, 100)
                cmd.Parameters(1).Direction = ParameterDirection.Output
                cmd.ExecuteNonQuery() 'se ejecuta el comando
                MsgBox(CStr(cmd.Parameters("@msj").Value)) 'Se recibe el mensaje

            ElseIf cmbMCodigo.Text <> "" And cmbEstado.Text = "" Then
                cadena = "pa_MantCod_Eliminar"
                cmd = New SqlCommand(cadena, cn)
                cmd.CommandType = CommandType.StoredProcedure
                'Crea los Parámetros de entrada que envían los datos
                cmd.Parameters.AddWithValue("@codigo", cmbMCodigo.Text)
                'Crea el Parámetro de salida para atrapar el mensaje
                cmd.Parameters.Add("@msj", SqlDbType.VarChar, 100)
                cmd.Parameters(1).Direction = ParameterDirection.Output
                cmd.ExecuteNonQuery() 'se ejecuta el comando
                MsgBox(CStr(cmd.Parameters("@msj").Value)) 'Se recibe el mensaje

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        Console.Read()
    End Sub

    Private Sub Cargar_Codigo_Mant()
        Dim cadena As String
        Try
            cn.Open()

            cadena = "pa_Mantenimiento"
            'Llamada al PA
            cmd = New SqlCommand(cadena, cn)
            'Ejecucion de un PA
            cmd.CommandType = CommandType.StoredProcedure
            'Se ejecuta el comando
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                cmbMCodigo.Items.Add(dr.Item("codigo"))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        Console.Read()
    End Sub

    Private Sub Cargar_Cod_Apart()
        Dim cadena As String
        Try
            cn.Open()

            cadena = "pa_Apartamento"
            'Llamada al PA
            cmd = New SqlCommand(cadena, cn)
            'Ejecucion de un PA
            cmd.CommandType = CommandType.StoredProcedure
            'Se ejecuta el comando
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                cmbMCod_Apto.Items.Add(dr.Item("cod_apto"))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        Console.Read()
    End Sub

    Private Sub Cargar_Nom_Apart()
        Dim cadena As String
        Try
            cn.Open()

            cadena = "pa_Apartamento_Nom"
            'Llamada al PA
            cmd = New SqlCommand(cadena, cn)
            'Ejecucion de un PA
            cmd.CommandType = CommandType.StoredProcedure
            'Se ejecuta el comando
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                cmbMNombre.Items.Add(dr.Item("nombre"))
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        Console.Read()
    End Sub

    Private Sub FrmEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_Codigo_Mant()
        Call Cargar_Cod_Apart()
        Call Cargar_Nom_Apart()

    End Sub
End Class