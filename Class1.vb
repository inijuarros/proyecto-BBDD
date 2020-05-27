Imports Microsoft.VisualBasic
Imports Microsoft.Data.Sqlite


Public Module DB
    Public Function getConnection() As SqliteConnection
        Console.WriteLine(Directory.GetCurrentDirectory())
        Dim connString = "Data Source=..\base.db"
        getConnection = New SqliteConnection(connString)
        Console.WriteLine("State: {0}", getConnection.State)
        Console.WriteLine("ServerVersion: {0}", getConnection.ServerVersion)
    End Function
End Module

Public Module Usuarios


    Public Function QryGetLogin() As DataTable
        Dim query = "SELECT * FROM USUARIOS 
                WHERE nombre LIKE @nombre and CONTRASEÑA LIKE @contraseña "
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SqliteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function
End Module