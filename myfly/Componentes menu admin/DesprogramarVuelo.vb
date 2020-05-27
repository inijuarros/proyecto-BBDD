Public Class DesprogramarVuelo
    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = UseCase.verReservas


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class