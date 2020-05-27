Public Class ProgramarVuelo
    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = UseCase.verVuelos
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss"

    End Sub
    Dim c As String
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        c = DataGridView1.CurrentRow.Cells(0).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check As Boolean = False
        If c <> "" And NumericUpDown1.Value > 0 Then
            For index = 1 To NumericUpDown1.Value
                Dim h As New Reservas(c, DateTimePicker1.Value)
                Dim a = UseCase.crearReserva(h)
                DataGridView1.DataSource = UseCase.verVuelos
                If a <> 0 Then
                    check = True
                Else
                    check = False
                End If
            Next
            If check = True Then
                MessageBox.Show("Reservas creadas")
            Else
                MessageBox.Show("ERROR Reservas no creadas")
            End If
        Else
            MessageBox.Show("selecione un vuelo he introduzca ek numero de  plazas que tendra")
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class