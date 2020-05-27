Imports Microsoft.VisualBasic
Imports AccesoDatos
Public Module UseCase
    Public Function loggear() As DataTable

        Return USUARIOS.QryGetLogin()
    End Function




End Module