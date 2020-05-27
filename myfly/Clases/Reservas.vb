Public Class Reservas
    Public id_vuelo As String
    Public fecha As DateTime
    Public pasaporte As String

    Public Sub New(id_vuelo As String, fecha As DateTime)
        Me.id_vuelo = id_vuelo
        Me.fecha = fecha
    End Sub

    Public Sub New(fecha As Date, pasaporte As String)
        Me.fecha = fecha
        Me.pasaporte = pasaporte
    End Sub

    Public Sub New(id_vuelo As String, fecha As Date, pasaporte As String)
        Me.id_vuelo = id_vuelo
        Me.fecha = fecha
        Me.pasaporte = pasaporte
    End Sub
End Class
