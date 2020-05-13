Imports System.Data.SqlClient
Public Class FrmAdicionar
    'Declaracion de variables
    Dim cadena As String
    'Dim cn As New SqlConnection()
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

    Private Sub BtnAgregarApto_Click(sender As Object, e As EventArgs) Handles BtnAgregarApto.Click
        Dim cadena As String
        Try
            cn.Open()
            cadena = "pa_Apartamento_Insertar"
            cmd = New SqlCommand(cadena, cn)
            cmd.CommandType = CommandType.StoredProcedure
            'Crea los Parámetros de entrada que envían los datos
            cmd.Parameters.AddWithValue("@cod_pro", txtCod_Pro.Text)
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text)
            cmd.Parameters.AddWithValue("@rec", txtRecamaras.Text)
            cmd.Parameters.AddWithValue("@valor", txtValor.Text)
            cmd.Parameters.AddWithValue("@año", txtAño.Text)
            cmd.Parameters.AddWithValue("@costo", txtCosto_Alquiler.Text)
            'Crea el Parámetro de salida para atrapar el mensaje
            cmd.Parameters.Add("@msj", SqlDbType.VarChar, 100)
            cmd.Parameters(6).Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery() 'se ejecuta el comando
            MsgBox(CStr(cmd.Parameters("@msj").Value)) 'Se recibe el mensaje

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        Console.Read()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cadena As String
        Try
            cn.Open()
            cadena = "pa_Mantenimiento_Insertar"
            cmd = New SqlCommand(cadena, cn)
            cmd.CommandType = CommandType.StoredProcedure

            'Crea los Parámetros de entrada que envían los datos
            cmd.Parameters.AddWithValue("@cod_apto", txtCod_AptoM.Text)
            cmd.Parameters.AddWithValue("@fecha", CDate(dtpFecha.Text))
            cmd.Parameters.AddWithValue("@costo", txtCosto.Text)
            cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
            cmd.Parameters.AddWithValue("@status", cmbEstado.Text)

            'Crea el Parámetro de salida para atrapar el mensaje
            cmd.Parameters.Add("@msj", SqlDbType.VarChar, 100)
            cmd.Parameters(5).Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery() 'se ejecuta el comando
            MsgBox(CStr(cmd.Parameters("@msj").Value)) 'Se recibe el mensaje


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        Console.Read()
    End Sub

    Private Sub txtCod_Pro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCod_Pro.Validating
        If txtCod_Pro.Text = "" Then
            MsgBox("Ingrese el código de Propietario", vbCritical, "Alerta")
        ElseIf Not IsNumeric(txtCod_Pro.Text) Then
            MsgBox("Solo permite insertar números", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text = "" Then
            MsgBox("Ingrese el Nombre del Apartamento", vbCritical, "Alerta")
        End If

    End Sub

    Private Sub txtRecamaras_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRecamaras.Validating
        If txtRecamaras.Text = "" Then
            MsgBox("Ingrese la Cantidad de Recamaras", vbCritical, "Alerta")
        ElseIf txtRecamaras.Text > 3 Or txtRecamaras.Text < 1 Then
            MsgBox("Cantidad de Recamaras no disponible en el rango", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub txtValor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtValor.Validating
        If txtValor.Text = "" Then
            MsgBox("Ingrese el Valor", vbCritical, "Alerta")
        ElseIf Not IsNumeric(txtValor.Text) Then
            MsgBox("Solo permite ingresar números", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub txtAño_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAño.Validating
        If txtAño.Text = "" Then
            MsgBox("Ingrese el Año", vbCritical, "Alerta")
        ElseIf Not IsNumeric(txtAño.Text) Then
            MsgBox("Solo permite ingresar números", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub txtCosto_Alquiler_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCosto_Alquiler.Validating
        If txtCosto_Alquiler.Text = "" Then
            MsgBox("Ingrese el costo", vbCritical, "Alerta")
        ElseIf Not IsNumeric(txtCosto_Alquiler.Text) Then
            MsgBox("Solo se permite ingresar números", vbCritical, "Alerta")
        End If
    End Sub

    Private Sub txtCod_AptoM_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCod_AptoM.Validating
        If txtCod_AptoM.Text = "" Then
            MsgBox("Ingrese el Codigo de Apartamento", vbCritical, "Alerta")
        ElseIf Not IsNumeric(txtCod_AptoM.Text) Then
            MsgBox("Solo se permite ingresar números", vbCritical, "Alerta")
        End If

    End Sub

    Private Sub txtCosto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCosto.Validating
        If txtCosto.Text = "" Then
            MsgBox("Ingrese el costo", vbCritical, "Alerta")
        ElseIf Not IsNumeric(txtCosto.Text) Then
            MsgBox("Solo se permite ingresar números", vbCritical, "Alerta")
        End If

    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        If txtDescripcion.Text = "" Then
            MsgBox("Ingrese una breve descripción", vbCritical, "Alerta")
        End If

    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbEstado.Validating
        If cmbEstado.Text = "" Then
            MsgBox("Ingrese el Estado del Mantenimiento", vbCritical, "Alerta")
        ElseIf Not cmbEstado.Text = "P" Or cmbEstado.Text = "R" Or cmbEstado.Text = "C" Then
            MsgBox("Solo se permite ingresar los estados definidos P, R o C", vbCritical, "Alerta")
        End If

    End Sub
End Class