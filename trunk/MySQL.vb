Imports System.Data
Imports MySql.Data.MySqlClient

Public Class MySQL
    Dim ConStr As String = "server=localhost;uid=root;password=mysql;database=tccg"
    'instanciamos un objeto conexion
    'y le pasamos de parametro la variable con la cadena 
    Dim Con As New MySqlConnection(ConStr)
    'Instrucción a ejecutar

    Public Function LEER(ByVal Str_Sql As String) As DataTable
        'creamos el objeto comando y le pasamos el parámetro que contiene la query y la conexion 
        Dim Comando As New MySqlCommand(Str_Sql, Con)
        'Try para capturar los errores
        Try
            'antes de abrir conexión nos aseguramos que no exista conexión establecida previa 
            If Not Con Is Nothing Then
                Con.Close()
            End If
            'abrimos conexión 
            Con.Open()
            'declaramos la variable de tipo entero que contendrá las filas afectadas y ejecutamos 
            'el comando
            Dim Dt As New DataTable
            'adaptador que sirve de enlace intermedio entre la aplicación y la 
            'base de datos 
            Dim Da As New MySqlDataAdapter(Str_Sql, Con)
            Dim res As Integer = Comando.ExecuteNonQuery()
            Dim Cmd As New MySqlCommandBuilder(Da)
            'llenamos la tabla 
            Da.Fill(Dt)
            Return Dt
            Dt.Clear()
        Catch ex As Exception
            Dim Dt As New DataTable
            Return Dt
            MsgBox(ex.Message)
        Finally
            'cerramos la conexión 
            Con.Close()
            'y esto es muy importante, el objeto comando que habiamos creado 
            'lo eliminamos de la memoria 
            Comando = Nothing
            'finalizamos la captura de errores 
        End Try
    End Function

    Public Function INSERT_UPDATE_DELETE(ByVal Str_Sql As String) As String
        ' NOTA: en res devolvemos el nº de filas afectadas si es correcto o 
        '       cero si no pudimos insertar
        '
        '       res debería consultarse luego de invocar la función
        '       forma de uso: dim res as integer = INSERT_UPDATE_DELETE("LA INSTRUCCION SQL")
        '                     if res = 0 then
        '                         MsgBox ("No pude ejecutar la instrucción SQL")
        '                     end if

        'creamos el objeto comando y le pasamos el parámetro que contiene la query y la conexion 
        Dim Comando As New MySqlCommand(Str_Sql, Con)
        'Try para capturar los errores
        Try
            'antes de abrir conexión nos aseguramos que no exista conexión establecida previa 
            If Not Con Is Nothing Then
                Con.Close()
            End If
            'abrimos conexión 
            Con.Open()
            'adaptador que sirve de enlace intermedio entre la aplicación y la 
            'base de datos 
            Dim Da As New MySqlDataAdapter(Str_Sql, Con)
            Dim res As Integer = Comando.ExecuteNonQuery()
            Return res.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim Res As Integer = 0
            Return Res
        Finally
            'cerramos la conexión 
            Con.Close()
            'y esto es muy importante, el objeto comando que habiamos creado 
            'lo eliminamos de la memoria 
            Comando = Nothing
            'finalizamos la captura de errores 
        End Try
    End Function

End Class


