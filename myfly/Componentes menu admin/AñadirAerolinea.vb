Public Class AñadirAerolinea
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then

            Dim a = UseCase.crearAerolinea(TextBox1.Text)
            Console.WriteLine(a)
            If a = 0 Then
                MessageBox.Show("Aerolinea no creada (error en la base de datos)")
            Else
                MessageBox.Show("Aerolinea creada")
            End If

        Else
            MessageBox.Show("Introduzca datos validos")
        End If
    End Sub
End Class