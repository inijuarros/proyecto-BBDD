Public Class EliminarAerolinea

    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = UseCase.verAerolineas


        For index = 0 To dt.Rows.Count - 1

            ComboBox1.Items.Add(dt(index)(0).ToString)

        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then
            Dim a = UseCase.borrarAerolinea(ComboBox1.Text)
            If a <> 0 Then
                MessageBox.Show("aerolinea borrada")
            Else
                MessageBox.Show("Cambios no efectuados")
            End If
        Else
            MessageBox.Show("selecione una aerolinea")
        End If

        Console.WriteLine(ComboBox1.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class