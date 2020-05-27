Public Class login

    Sub ClearForm()
        Tusuario.Text = ""
        contraseña.Text = ""
        regUsuario.Text = ""
        regContraseña.Text = ""
        regContraseña2.Text = ""
    End Sub


    Public row As DataRow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If Tusuario.Text <> "" And contraseña.Text <> "" Then

            Dim u As New usuario(1, "", "", "")
            u.nombre = Tusuario.Text
            u.contraseña = contraseña.Text
            Dim a = UseCase.loggear(u)

            Try
                row = a.Rows(0)
                Console.WriteLine(row(2))
                passerror.Visible = False
                If row(2) = "A" Then
                    myfly.menuAdmin.Show()
                    Me.Hide()
                ElseIf row(2) = "U" Then
                    myfly.menu.Show()
                    Me.Hide()
                End If


            Catch ex As Exception
                passerror.Visible = True
            End Try



        Else
            Console.WriteLine("no data")



        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registrarse_Click(sender As Object, e As EventArgs) Handles registrarse.Click
        Crear_usuario.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If regContraseña.Text = regContraseña2.Text Then
            Dim u As New usuario(1, "", "", "")
            u.nombre = regUsuario.Text
            u.contraseña = regContraseña.Text
            Dim a = UseCase.crearUsuario(u)
            Console.WriteLine(a)
            If a = 0 Then
                MessageBox.Show("Usuario no creado (error en la base de datos)")
            Else
                Crear_usuario.Visible = False
            End If

        Else
            MessageBox.Show("Las contraseñas no coinciden")
        End If


    End Sub

    Private Sub regContraseña_TextChanged(sender As Object, e As EventArgs) Handles regContraseña.TextChanged

    End Sub
End Class
