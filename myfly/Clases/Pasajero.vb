Public Class Pasajero
    Public nombre As String
    Public edad As Integer
    Public id As Integer
    Public pasaporte As String

    Public Sub New(nombre As String, edad As Integer, id As Integer, pasaporte As String)
        Me.nombre = nombre
        Me.edad = edad
        Me.id = id
        Me.pasaporte = pasaporte
    End Sub
End Class
