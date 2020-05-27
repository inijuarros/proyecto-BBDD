Public Class EliminarVuelo
    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = UseCase.verVuelos

    End Sub
    Dim c As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        c = DataGridView1.CurrentRow.Cells(0).Value

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If c <> "" Then
            Dim a = UseCase.borrarVuelo(c)
            DataGridView1.DataSource = UseCase.verVuelos
            If a <> 0 Then
                MessageBox.Show("vuelo borrado")
            Else
                MessageBox.Show("Cambios no efectuados")
            End If
        Else
            MessageBox.Show("selecione un vuelo")
        End If
    End Sub
End Class