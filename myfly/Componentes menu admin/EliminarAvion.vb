Public Class EliminarAvion
    Dim c As String
    Private Sub cargador(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = UseCase.verAviones

        Dim dt = UseCase.verAerolineas


        For index = 0 To dt.Rows.Count - 1

            ComboBox1.Items.Add(dt(index)(0).ToString)

        Next

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        c = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If c <> "" Then
            Dim a = UseCase.borrarAvion(c)
            If a <> 0 Then
                MessageBox.Show("Avion eliminado")
            Else
                MessageBox.Show("Cambios no efectuados")
            End If
        Else
            MessageBox.Show("selecione un avion")
        End If
        UseCase.borrarAvion(c)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text <> "" Then
            Dim a = UseCase.cambiarAerolinea(c, ComboBox1.Text)
            If a <> 0 Then
                MessageBox.Show("aerolinea actualizada")
            Else
                MessageBox.Show("Cambios no efectuados")
            End If
        Else
            MessageBox.Show("selecione una aerolinea")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.DataSource = UseCase.verAviones
        Panel1.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class