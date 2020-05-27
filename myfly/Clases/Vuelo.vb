Public Class Vuelo
    Public avion As String
    Public tripulacuion As String
    Public aeropuestoSalida As Integer
    Public aeropuestoLlegada As Integer

    Public Sub New(avion As String, tripulacuion As String, aeropuestoSalida As Integer, aeropuestoLlegada As Integer)
        Me.avion = avion
        Me.tripulacuion = tripulacuion
        Me.aeropuestoSalida = aeropuestoSalida
        Me.aeropuestoLlegada = aeropuestoLlegada
    End Sub
End Class
