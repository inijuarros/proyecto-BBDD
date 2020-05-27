Public Class Aeropuerto
    Public id As Integer
    Public nombre As String
    Public direccion As String
    Public pistas As Integer

    Public Sub New(id As Integer, nombre As String, direccion As String, pistas As Integer)
        Me.id = id
        Me.nombre = nombre
        Me.direccion = direccion
        Me.pistas = pistas
    End Sub


End Class
