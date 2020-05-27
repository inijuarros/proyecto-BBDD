




Imports System.Data.SQLite

Public Module DB
    Public Function getConnection() As SQLiteConnection
        Dim connString = "Data Source=c:..\..\base.sq3;version=3;"
        getConnection = New SQLiteConnection(connString)
        ' Console.WriteLine("State: {0}", getConnection.State)


    End Function
End Module

Public Module Usuarios


    Public Function QryGetLogin(u As usuario) As DataTable

        Dim query = "SELECT * FROM USUARIOS
               WHERE nombre = '" + u.nombre + "' and contrasena ='" + u.contraseña + "'"
        'Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function


    Public Function QryCreateUser(u As usuario) As Integer

        Dim query = "INSERT INTO USUARIOS (ID_USUARIO, contrasena, TIPO, nombre) VALUES (null, '" + u.contraseña + "', 'U', '" + u.nombre + "')"
        ' Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryChangePass(u As usuario) As Integer

        Dim query = "UPDATE USUARIOS SET contrasena = '" + u.contraseña + "' WHERE ID_USUARIO = " + u.id.ToString + ""
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function


End Module

Public Module Aeropuertos
    Public Function QryCreateAirport(u As Aeropuerto) As Integer

        Dim query = "INSERT INTO AEROPUERTOS (ID_AEROPUERTO, NOMBRE, DIRECCION, PISTAS) VALUES (null, '" + u.nombre + "', '" + u.direccion + "', '" + u.pistas.ToString + "')"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QrySeeAirport() As DataTable

        Dim query = "SELECT * FROM AEROPUERTOS"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    Public Function QryDeleteAirport(u As String) As Integer

        Dim query = "DELETE FROM AEROPUERTOS WHERE id_aeropuerto = " + u + ""
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function
End Module

Public Module Aerolinea
    Public Function QryCreateAirline(u As String) As Integer

        Dim query = "INSERT INTO AEROLINEA (NOMBRE) VALUES ('" + u + "')"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryDeleteAirline(u As String) As Integer

        Dim query = "DELETE FROM AEROLINEA WHERE NOMBRE = '" + u + "'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryGetAirline() As DataTable

        Dim query = "SELECT * FROM AEROLINEA"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function
End Module
Public Module Aviones

    Public Function QryCreatePlane(u As Avion) As Integer

        Dim query = "INSERT INTO AVIONES (MATRICULA, AEROLINEA) VALUES ('" + u.matricula + "', '" + u.aerolinea + "')"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryDeletePlane(u As String) As Integer

        Dim query = "DELETE FROM AVIONES WHERE MATRICULA = '" + u + "'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryGetPlane() As DataTable

        Dim query = "SELECT * FROM AVIONES"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    Public Function QryUpdatePlane(nm As String, ae As String) As Integer

        Dim query = "UPDATE AVIONES SET AEROLINEA = '" + ae + "' WHERE MATRICULA = '" + nm + "'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

End Module

Public Module Tripulacion
    Public Function QryGetStall() As DataTable

        Dim query = "SELECT * FROM PUESTOS"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    Public Function QryGetCrew() As DataTable

        Dim query = "SELECT distinct TRIPULACION FROM TRIPULACION"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    Public Function QryCreateCrew(u As Tripulacion1) As Integer

        Dim query = "INSERT INTO TRIPULACION (ID_TRIPULACION, PUESTO, nombre, TRIPULACION) VALUES (null, '" + u.idpuesto + "', '" + u.nombre + "', '" + u.tripulacion + "')"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryDeleteCrew(u As String) As Integer

        Dim query = "DELETE FROM TRIPULACION WHERE TRIPULACION = '" + u + "'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

End Module

Public Module Vuelos
    Public Function QrySelectAirports(u As String) As Integer

        Dim query = "SELECT ID_AEROPUERTO  FROM AEROPUERTOS WHERE NOMBRE = '" + u + "'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Dim id As Integer = table(0)(0)
        Return id
    End Function

    Public Function QrySelectIdAirports(u As String) As String

        Dim query = "SELECT NOMBRE  FROM AEROPUERTOS WHERE ID_AEROPUERTO = " + u + ""
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Dim id As String = table(0)(0)
        Return id
    End Function

    Public Function QryCreateFlight(u As Vuelo) As Integer

        Dim query = "INSERT INTO VUELOS (ID_AVION, TRIPULACION, ID_AE_SALIDA, ID_AE_LLEGADA) VALUES ('" + u.avion + "', '" + u.tripulacuion + "', " + u.aeropuestoSalida.ToString + ", " + u.aeropuestoLlegada.ToString + ")"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryGetFlight() As DataTable

        Dim query = "SELECT * FROM VUELOS"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    Public Function QryDeleteFlight(u As String) As Integer

        Dim query = "DELETE FROM VUELOS WHERE ID_VUELO = " + u + ""
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function
End Module
Public Module Reserva
    Public Function QryCreateReserve(u As Reservas) As Integer

        Dim query = "INSERT INTO RESERVAS (NUM_PASAPORTE, ID_VUELO, FECHA_SALIDA) VALUES ( 'LIBRE', " + u.id_vuelo + ", '" + Format(u.fecha, "yyyy-MM-dd HH:mm:ss") + "')"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryDeleteReserve(u As Reservas) As Integer

        Dim query = "DELETE FROM RESERVAS WHERE ID_VUELO = " + u.id_vuelo + " AND FECHA_SALIDA = '" + Format(u.fecha, "yyyy-MM-dd HH:mm:ss") + "'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryGetReserve() As DataTable

        Dim query = "select ID_VUELO, ID_AVION ,ID_AE_SALIDA, ID_AE_LLEGADA from VUELOS inner join AEROPUERTOS group by ID_VUELO"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        table.Columns.Add("idvuelo", GetType(Integer))
        table.Columns.Add("ID_AVION", GetType(String))
        table.Columns.Add("ID_AE_SALIDA", GetType(String))
        table.Columns.Add("ID_AE_LLEGADA", GetType(String))

        Dim executeReader = sqlCommand.ExecuteReader()



        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        table.Columns(2).DataType = GetType(String)
        table.Columns(3).DataType = GetType(String)
        For index = 0 To table.Rows.Count - 1
            table.Rows(index).Item(2) = Vuelos.QrySelectIdAirports(table.Rows(index).Item(2).ToString)
            table.Rows(index).Item(3) = Vuelos.QrySelectIdAirports(table.Rows(index).Item(3).ToString)
        Next
        Return table
    End Function

    Public Function QryReserve(u As Reservas) As Integer

        Dim query = "UPDATE RESERVAS SET NUM_PASAPORTE = '" + u.pasaporte + "' WHERE ID_VUELO = " + u.id_vuelo + " AND FECHA_SALIDA = '" + Format(u.fecha, "yyyy-MM-dd HH:mm:ss") + "' and ID_RESERVA IN (SELECT ID_RESERVA FROM RESERVAS WHERE FECHA_SALIDA = '" + Format(u.fecha, "yyyy-MM-dd HH:mm:ss") + "' AND NUM_PASAPORTE = 'LIBRE' limit 1)"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function

    Public Function QryGetDate(u As String) As DataTable

        Dim query = "select  distinct cast(FECHA_SALIDA as text) as fecha from RESERVAS where ID_VUELO = " + u.ToString + " and FECHA_SALIDA > datetime('now') and NUM_PASAPORTE = 'LIBRE'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()

        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    Public Function QryCreatePassenger(u As Pasajero) As Integer

        Dim query = "INSERT or ignore INTO PASAJEROS (NUM_PASAPORTE, NOMBRE, EDAD, ID_USUARIO) VALUES ('" + u.pasaporte + "', '" + u.nombre + "', " + u.edad.ToString + ", " + u.id.ToString + ")"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function


    Public Function QryGetMyfly(u As String) As DataTable

        Dim query = "select ID_AE_SALIDA, ID_AE_LLEGADA, FECHA_SALIDA, P.NUM_PASAPORTE  from VUELOS inner join AEROPUERTOS a inner join RESERVAS R on VUELOS.ID_VUELO = R.ID_VUELO inner join PASAJEROS P on R.NUM_PASAPORTE = P.NUM_PASAPORTE inner join USUARIOS U on P.ID_USUARIO = U.ID_USUARIO where FECHA_SALIDA > datetime('now') and U.ID_USUARIO = " + u + " group by FECHA_SALIDA, P.NUM_PASAPORTE"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)

        Dim table = New DataTable()
        table.Columns.Add("ID_AE_SALIDA", GetType(String))
        table.Columns.Add("ID_AE_LLEGADA", GetType(String))
        table.Columns.Add("FECHA_SALIDA", GetType(Date))
        table.Columns.Add("NUM_PASAPORTE", GetType(String))
        Dim executeReader = sqlCommand.ExecuteReader()

        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        For index = 0 To table.Rows.Count - 1
            table.Rows(index).Item(0) = Vuelos.QrySelectIdAirports(table.Rows(index).Item(0).ToString)
            table.Rows(index).Item(1) = Vuelos.QrySelectIdAirports(table.Rows(index).Item(1).ToString)
        Next
        Return table
    End Function

    Public Function QryUserDeleteReserve(u As Reservas) As Integer

        Dim query = "UPDATE RESERVAS SET NUM_PASAPORTE = 'LIBRE' WHERE FECHA_SALIDA = '" + Format(u.fecha, "yyyy-MM-dd HH:mm:ss") + "' and NUM_PASAPORTE = '" + u.pasaporte + "'"
        Console.WriteLine(query)
        Dim conn = DB.getConnection()
        conn.Open()
        Dim sqlCommand = New SQLiteCommand(query, conn)


        Dim a As Integer = sqlCommand.ExecuteNonQuery
        sqlCommand.Dispose()
        conn.Close()

        Return a
    End Function



End Module