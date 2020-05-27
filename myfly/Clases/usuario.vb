Public Class usuario
    Public id As Integer
    Public contraseña As String
    Public tipo As Char
    Public nombre As String

    Public Sub New(id As Integer, contraseña As String, tipo As Char, nombre As String)
        Me.id = id
        Me.contraseña = contraseña
        Me.tipo = tipo
        Me.nombre = nombre
    End Sub

    Public Sub New(contraseña As String, nombre As String)

        Me.contraseña = contraseña

        Me.nombre = nombre
    End Sub

    Public Sub New(row As DataRow)
        id = row("ID")
        contraseña = row("CONTRASEÑA")
        tipo = row("TIPO")
        nombre = row("nombre")
    End Sub

    Public Sub New(id As Integer, contraseña As String)
        Me.id = id
        Me.contraseña = contraseña
    End Sub
End Class
