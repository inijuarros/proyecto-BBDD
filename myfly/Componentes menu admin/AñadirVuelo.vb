Public Class AñadirVuelo
    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt = UseCase.verAviones
        Dim dt2 = UseCase.verTripulacion
        Dim dt3 = UseCase.verAeropuertos


        For index = 0 To dt.Rows.Count - 1

            ComboBox1.Items.Add(dt(index)(0).ToString)



        Next
        For index = 1 To dt2.Rows.Count - 1
            ComboBox2.Items.Add(dt2(index)(0).ToString)
        Next
        For index = 1 To dt3.Rows.Count - 1
            ComboBox3.Items.Add(dt3(index)(1).ToString)
            ComboBox4.Items.Add(dt3(index)(1).ToString)
        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aes As Integer = seleccionarAeropuerto(ComboBox3.Text)
        Dim ael As Integer = seleccionarAeropuerto(ComboBox4.Text)
        Console.WriteLine(aes + ael)
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox4.Text <> "" Then
            Dim u As New Vuelo(ComboBox1.Text, ComboBox2.Text, aes, ael)

            Dim a = UseCase.crearVuelo(u)
            Console.WriteLine(a)
            If a = 0 Then
                MessageBox.Show("vuelo no creado (error en la base de datos)")
            Else
                MessageBox.Show("vuelo creado")
            End If

        Else
            MessageBox.Show("Introduzca datos validos")
        End If

    End Sub
End Class