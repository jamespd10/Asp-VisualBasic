Imports System.Data.SqlClient
Module Conexion
    Public cn As New SqlConnection()

    Sub Conectar()
        cn.ConnectionString = "Data Source=home;Initial Catalog=ResortBuenaVista;Integrated Security=True"
        '"Data Source=home;Initial Catalog=BuenaVistaResort;Integrated Security=True"
        'Nancy Data Source=laptop-pq9igmo7
        Try
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If cn.State = ConnectionState.Open Then
            'MsgBox("Conexion Satisfactoria")
        Else
            MsgBox("Error en la conexion...")
        End If
        Console.Read()
        cn.Close()
    End Sub
End Module

