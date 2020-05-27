Public Class menu
    'para acceder al usuario logueado
    Dim usuario As DataRow = login.row
    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Bienvenido/a " + usuario(3)
        DataGridView2.DataSource = UseCase.verReservas
        DataGridView2.Columns(0).Visible = False
        DataGridView2.Columns(4).Visible = False
        DataGridView2.Columns(1).HeaderText = "Matricula avion"
        DataGridView2.Columns(2).HeaderText = "Salida"
        DataGridView2.Columns(3).HeaderText = "Llegada"
        DataGridView1.DataSource = UseCase.Inicio(usuario(0).ToString)

        DataGridView1.Columns(0).HeaderText = "Salida"
        DataGridView1.Columns(1).HeaderText = "Llegada"
        DataGridView1.Columns(2).HeaderText = "Fecha"
        DataGridView1.Columns(3).HeaderText = "Pasaporte"

        DataGridView3.DataSource = UseCase.Inicio(usuario(0).ToString)

        DataGridView3.Columns(0).HeaderText = "Salida"
        DataGridView3.Columns(1).HeaderText = "Llegada"
        DataGridView3.Columns(2).HeaderText = "Fecha"
        DataGridView3.Columns(3).HeaderText = "Pasaporte"





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
    Dim c As String
    Dim f As DateTime
    Dim g As String
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        ComboBox1.Items.Clear()
        c = DataGridView2.CurrentRow.Cells(4).Value

        Dim dt = UseCase.verHoras(c)

        For index = 0 To dt.Rows.Count - 1

            ComboBox1.Items.Add(dt(index)(0))

        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        If NumericUpDown1.Value > 18 And TextBox1.Text <> "" And c <> "" And ComboBox1.Text <> "" And TextBox2.Text <> "" Then
            Dim u As New Reservas(c, ComboBox1.Text, TextBox2.Text)
            Dim a = Reservar(u)

            If a <> 0 Then
                MessageBox.Show("Reserva creada")
            Else
                MessageBox.Show("ERROR Reservas no creada")
            End If

        End If

        If NumericUpDown1.Value > 18 And TextBox1.Text <> "" And c <> "" And ComboBox1.Text <> "" And TextBox2.Text <> "" Then
            Dim h As New Pasajero(TextBox1.Text, NumericUpDown1.Value, usuario(0), TextBox2.Text)
            Dim a = CrearPasajero(h)
        Else
            MessageBox.Show("Para reservar un vuelo tiene que introducir todos sus datos y ser mayor de 18 años")
        End If
        DataGridView1.DataSource = UseCase.Inicio(usuario(0).ToString)
        DataGridView3.DataSource = UseCase.Inicio(usuario(0).ToString)

        ComboBox1.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If f.ToString <> "" And g <> "" Then
            Dim u As New Reservas(f, g)
            Dim a = UseCase.CancelarReserva(u)

            If a <> 0 Then
                MessageBox.Show("Reserva cancelada")
            Else
                MessageBox.Show("ERROR Reservas no cancelada")
            End If

        End If
        DataGridView1.DataSource = UseCase.Inicio(usuario(0).ToString)
        DataGridView3.DataSource = UseCase.Inicio(usuario(0).ToString)
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        f = DataGridView3.CurrentRow.Cells(2).Value
        g = DataGridView3.CurrentRow.Cells(3).Value
        DataGridView2.DataSource = UseCase.verReservas
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Application.Exit()
        Me.Hide()
        login.ClearForm()
        login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel2.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox3.Text = TextBox4.Text Then
            Dim u As New usuario(1, "", "", "")
            u.id = usuario(0).ToString
            u.contraseña = TextBox4.Text
            Dim a = cambiarContraseña(u)
            If a > 0 Then
                MessageBox.Show("Contraseña cambiada")
            Else
                MessageBox.Show("ERROR Contraseña no cambiada")
            End If
        Else
            MessageBox.Show("Asegurese de que las contraseñas coinciden")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel2.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class