Imports Microsoft.VisualBasic

Public Module UseCase
    Public Function loggear(u As usuario) As DataTable
        Return Usuarios.QryGetLogin(u)
    End Function

    Public Function crearUsuario(u As usuario) As Integer
        Return Usuarios.QryCreateUser(u)
    End Function
    Public Function cambiarContraseña(u As usuario) As Integer
        Return Usuarios.QryChangePass(u)
    End Function


    Public Function crearAeropuerto(u As Aeropuerto) As Integer
        Return Aeropuertos.QryCreateAirport(u)
    End Function
    Public Function verAeropuertos() As DataTable
        Return Aeropuertos.QrySeeAirport
    End Function

    Public Function borrarAeropuerto(u As String) As Integer
        Return Aeropuertos.QryDeleteAirport(u)
    End Function

    Public Function crearAerolinea(u As String) As Integer
        Return Aerolinea.QryCreateAirline(u)
    End Function

    Public Function borrarAerolinea(u As String) As Integer
        Return Aerolinea.QryDeleteAirline(u)
    End Function

    Public Function verAerolineas() As DataTable
        Return Aerolinea.QryGetAirline()
    End Function

    Public Function crearAvion(u As Avion) As Integer
        Return Aviones.QryCreatePlane(u)
    End Function

    Public Function borrarAvion(u As String) As Integer
        Return Aviones.QryDeletePlane(u)
    End Function

    Public Function verAviones() As DataTable
        Return Aviones.QryGetPlane()
    End Function

    Public Function cambiarAerolinea(nm As String, ae As String) As Integer
        Return Aviones.QryUpdatePlane(nm, ae)
    End Function

    Public Function verPuestos() As DataTable
        Return Tripulacion.QryGetStall()
    End Function

    Public Function crearTripulacion(u As Tripulacion1) As Integer
        Return Tripulacion.QryCreateCrew(u)
    End Function

    Public Function borrarTripulacion(u As String) As Integer
        Return Tripulacion.QryDeleteCrew(u)
    End Function

    Public Function verTripulacion() As DataTable
        Return Tripulacion.QryGetCrew()
    End Function

    Public Function seleccionarAeropuerto(u As String) As Integer
        Return Vuelos.QrySelectAirports(u)
    End Function

    Public Function crearVuelo(u As Vuelo) As Integer
        Return Vuelos.QryCreateFlight(u)
    End Function

    Public Function verVuelos() As DataTable
        Return Vuelos.QryGetFlight()
    End Function

    Public Function borrarVuelo(u As String) As Integer
        Return Vuelos.QryDeleteFlight(u)
    End Function

    Public Function crearReserva(u As Reservas) As Integer
        Return Reserva.QryCreateReserve(u)
    End Function
    Public Function borrarReserva(u As Reservas) As Integer
        Return Reserva.QryDeleteReserve(u)
    End Function
    Public Function verReservas() As DataTable
        Return Reserva.QryGetReserve()
    End Function

    Public Function Reservar(u As Reservas) As Integer
        Return Reserva.QryReserve(u)
    End Function

    Public Function verHoras(u As String) As DataTable
        Return Reserva.QryGetDate(u)
    End Function

    Public Function CrearPasajero(u As Pasajero) As Integer
        Return Reserva.QryCreatePassenger(u)
    End Function
    Public Function Inicio(u As String) As DataTable
        Return Reserva.QryGetMyfly(u)
    End Function

    Public Function CancelarReserva(u As Reservas) As Integer
        Return Reserva.QryUserDeleteReserve(u)
    End Function

End Module