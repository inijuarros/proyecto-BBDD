Public Class menuAdmin
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AñadirAeropuerto.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EliminarAeropuerto.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AñadirAerolinea.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EliminarAerolinea.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AñadirAvion.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EliminarAvion.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CrearTripulacion.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EliminarTripulacion.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AñadirVuelo.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EliminarVuelo.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ProgramarVuelo.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ProgramarVuelo.Hide()
        EliminarVuelo.Hide()
        AñadirVuelo.Hide()
        EliminarTripulacion.Hide()
        CrearTripulacion.Hide()
        EliminarAvion.Hide()
        AñadirAvion.Hide()
        EliminarAerolinea.Hide()
        AñadirAerolinea.Hide()
        EliminarAeropuerto.Hide()
        AñadirAeropuerto.Hide()


        Me.Hide()
        login.ClearForm()
        login.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        DesprogramarVuelo.Show()
    End Sub
End Class