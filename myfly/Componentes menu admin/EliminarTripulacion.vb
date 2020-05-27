Public Class EliminarTripulacion

    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim dt = UseCase.verTripulacion


        For index = 0 To dt.Rows.Count - 1

            ComboBox1.Items.Add(dt(index)(0).ToString)

        Next

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If ComboBox1.Text <> "" Then
            Dim a = borrarTripulacion(ComboBox1.Text)
            If a <> 0 Then
                MessageBox.Show("tripulacion borrada")
            Else
                MessageBox.Show("Cambios no efectuados")
            End If
        Else
            MessageBox.Show("selecione una tripulacion")
        End If


    End Sub
End Class