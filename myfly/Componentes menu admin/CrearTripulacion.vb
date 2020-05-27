Public Class CrearTripulacion

    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim dt = UseCase.verPuestos


        For index = 0 To dt.Rows.Count - 1

            ComboBox1.Items.Add(dt(index)(0).ToString)
            ComboBox2.Items.Add(dt(index)(0).ToString)
            ComboBox3.Items.Add(dt(index)(0).ToString)
            ComboBox4.Items.Add(dt(index)(0).ToString)
            ComboBox5.Items.Add(dt(index)(0).ToString)
            ComboBox6.Items.Add(dt(index)(0).ToString)
            ComboBox7.Items.Add(dt(index)(0).ToString)
            ComboBox8.Items.Add(dt(index)(0).ToString)

        Next

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox9.Text <> "" Then
            If TextBox8.Text <> "" And ComboBox8.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox8.Text, TextBox8.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If
            If TextBox1.Text <> "" And ComboBox1.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox1.Text, TextBox1.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If

            If TextBox2.Text <> "" And ComboBox2.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox2.Text, TextBox2.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If
            If TextBox3.Text <> "" And ComboBox3.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox3.Text, TextBox3.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If
            If TextBox4.Text <> "" And ComboBox4.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox4.Text, TextBox4.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If
            If TextBox5.Text <> "" And ComboBox5.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox5.Text, TextBox5.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If
            If TextBox6.Text <> "" And ComboBox6.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox6.Text, TextBox6.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If
            If TextBox7.Text <> "" And ComboBox7.Text <> "" Then
                Dim u As New Tripulacion1(ComboBox7.Text, TextBox7.Text, TextBox9.Text)

                Dim a = UseCase.crearTripulacion(u)
                Console.WriteLine(a)
            End If

        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class