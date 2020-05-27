<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tusuario = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.passerror = New System.Windows.Forms.Label()
        Me.registrarse = New System.Windows.Forms.Button()
        Me.Crear_usuario = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.regContraseña2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.regContraseña = New System.Windows.Forms.TextBox()
        Me.regUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Crear_usuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Iniciar Sesión"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'Tusuario
        '
        Me.Tusuario.Location = New System.Drawing.Point(90, 145)
        Me.Tusuario.Name = "Tusuario"
        Me.Tusuario.Size = New System.Drawing.Size(115, 20)
        Me.Tusuario.TabIndex = 3
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(90, 244)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña.Size = New System.Drawing.Size(115, 20)
        Me.contraseña.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(156, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Iniciar sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'passerror
        '
        Me.passerror.AutoSize = True
        Me.passerror.ForeColor = System.Drawing.Color.Red
        Me.passerror.Location = New System.Drawing.Point(87, 304)
        Me.passerror.Name = "passerror"
        Me.passerror.Size = New System.Drawing.Size(123, 13)
        Me.passerror.TabIndex = 6
        Me.passerror.Text = "Credenciales incorrectas"
        Me.passerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.passerror.Visible = False
        '
        'registrarse
        '
        Me.registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarse.Location = New System.Drawing.Point(36, 350)
        Me.registrarse.Name = "registrarse"
        Me.registrarse.Size = New System.Drawing.Size(112, 23)
        Me.registrarse.TabIndex = 7
        Me.registrarse.Text = "Registrarse"
        Me.registrarse.UseVisualStyleBackColor = True
        '
        'Crear_usuario
        '
        Me.Crear_usuario.Controls.Add(Me.Button2)
        Me.Crear_usuario.Controls.Add(Me.regContraseña2)
        Me.Crear_usuario.Controls.Add(Me.Label4)
        Me.Crear_usuario.Controls.Add(Me.regContraseña)
        Me.Crear_usuario.Controls.Add(Me.regUsuario)
        Me.Crear_usuario.Controls.Add(Me.Label5)
        Me.Crear_usuario.Controls.Add(Me.Label6)
        Me.Crear_usuario.Controls.Add(Me.Label7)
        Me.Crear_usuario.Location = New System.Drawing.Point(-3, 0)
        Me.Crear_usuario.Name = "Crear_usuario"
        Me.Crear_usuario.Size = New System.Drawing.Size(313, 450)
        Me.Crear_usuario.TabIndex = 8
        Me.Crear_usuario.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(115, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Registrarse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'regContraseña2
        '
        Me.regContraseña2.Location = New System.Drawing.Point(96, 290)
        Me.regContraseña2.Name = "regContraseña2"
        Me.regContraseña2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.regContraseña2.Size = New System.Drawing.Size(115, 20)
        Me.regContraseña2.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Repetir contraseña"
        '
        'regContraseña
        '
        Me.regContraseña.Location = New System.Drawing.Point(96, 219)
        Me.regContraseña.Name = "regContraseña"
        Me.regContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.regContraseña.Size = New System.Drawing.Size(115, 20)
        Me.regContraseña.TabIndex = 15
        '
        'regUsuario
        '
        Me.regUsuario.Location = New System.Drawing.Point(96, 148)
        Me.regUsuario.Name = "regUsuario"
        Me.regUsuario.Size = New System.Drawing.Size(115, 20)
        Me.regUsuario.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Usuario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 39)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Crear usuario"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 450)
        Me.Controls.Add(Me.Crear_usuario)
        Me.Controls.Add(Me.registrarse)
        Me.Controls.Add(Me.passerror)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.Tusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "Log in"
        Me.Crear_usuario.ResumeLayout(False)
        Me.Crear_usuario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tusuario As TextBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents passerror As Label
    Friend WithEvents registrarse As Button
    Friend WithEvents Crear_usuario As Panel
    Friend WithEvents regContraseña2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents regContraseña As TextBox
    Friend WithEvents regUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
End Class
