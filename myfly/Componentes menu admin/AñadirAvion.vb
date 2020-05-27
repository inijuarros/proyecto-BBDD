Public Class AñadirAvion
    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = UseCase.verAerolineas


        For index = 0 To dt.Rows.Count - 1

            ComboBox1.Items.Add(dt(index)(0).ToString)

        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And ComboBox1.Text <> "" Then
            Dim u As New Avion("", "")
            u.matricula = TextBox1.Text
            u.aerolinea = ComboBox1.Text

            Dim a = UseCase.crearAvion(u)
            Console.WriteLine(a)
            If a = 0 Then
                MessageBox.Show("Avion no creado (error en la base de datos)")
            Else
                MessageBox.Show("Avion creado")
            End If

        Else
            MessageBox.Show("Introduzca datos validos")
        End If
    End Sub
End Class