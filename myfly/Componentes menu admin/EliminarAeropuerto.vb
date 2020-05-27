Public Class EliminarAeropuerto

    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = UseCase.verAeropuertos

    End Sub

    Dim c As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        c = DataGridView1.CurrentRow.Cells(0).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DataGridView1.DataSource = UseCase.verAeropuertos
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If c <> "" Then
            Dim a = UseCase.borrarAeropuerto(c)
            DataGridView1.DataSource = UseCase.verAeropuertos
            If a <> 0 Then
                MessageBox.Show("aeropuerto borrado")
            Else
                MessageBox.Show("Cambios no efectuados")
            End If
        Else
            MessageBox.Show("selecione un aeropuerto")
        End If


    End Sub
End Class