Public Class AñadirAeropuerto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And NumericUpDown1.Value > 0 Then
            Dim u As New Aeropuerto(1, "", "", 0)
            u.nombre = TextBox1.Text
            u.direccion = TextBox2.Text
            u.pistas = NumericUpDown1.Value
            Dim a = UseCase.crearAeropuerto(u)
            Console.WriteLine(a)
            If a = 0 Then
                MessageBox.Show("Aeropuerto no creado (error en la base de datos)")
            Else
                MessageBox.Show("Aeropuerto creado")
            End If

        Else
            MessageBox.Show("Introduzca datos validos")
        End If
    End Sub

End Class