

Imports MySql.Data.MySqlClient

Public Class Form2

    ' button close click
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)

        Application.Exit()

    End Sub

    ' textbox username enter
    Private Sub TextBoxUsername_Enter(sender As Object, e As EventArgs) Handles TextBoxUsername.Enter

        ' clear the textbox when the textbox get the focus
        Dim username As String = TextBoxUsername.Text
        ' check if the username is empty
        ' check if the textbox contains the default value "username"
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            ' clear the textbox
            TextBoxUsername.Text = ""
            ' change the textbox for color
            TextBoxUsername.ForeColor = Color.Black

        End If

    End Sub

    ' textbox username leave
    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave

        ' when the textbox get lost the focus
        Dim username As String = TextBoxUsername.Text
        ' check if the username is empty
        ' check if the textbox contains the default value "username"
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            ' set the textbox text
            TextBoxUsername.Text = "username"
            ' change the textbox for color
            TextBoxUsername.ForeColor = Color.DarkGray

        End If

    End Sub

    ' textbox password enter
    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter

        ' when textbox password has focus
        Dim pass As String = TextBoxPassword.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            ' clear the textbox text
            TextBoxPassword.Text = ""
            ' change the textbox font color
            TextBoxPassword.ForeColor = Color.Black
            ' use system password
            TextBoxPassword.UseSystemPasswordChar = True

        End If

    End Sub

    ' textbox password leave
    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave

        ' when textbox password lost focus
        Dim pass As String = TextBoxPassword.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then

            ' set the textbox text
            TextBoxPassword.Text = "password"
            ' change the textbox font color
            TextBoxPassword.ForeColor = Color.DarkGray
            ' set system password to false
            TextBoxPassword.UseSystemPasswordChar = False

        End If

    End Sub

    ' button login click
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click, ButtonCancel.Click

        ' before the user can login we need to check if the textboxes are empty
        ' if they contains the default values( username & password )
        ' check if this user exist in the database

        Dim conn As New MY_CONNECTION()
            Dim adapter As New MySqlDataAdapter()
            Dim table As New DataTable()
            Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users` WHERE `username` = @usn AND `password` = @pass", conn.getConnection())

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text

            If TextBoxUsername.Text.Trim() = "" Or TextBoxUsername.Text.Trim().ToLower() = "username" Then

                MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf TextBoxPassword.Text.Trim() = "" Or TextBoxPassword.Text.Trim().ToLower() = "password" Then

                MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                adapter.SelectCommand = command
                adapter.Fill(table)

                If table.Rows.Count > 0 Then

                    Me.Hide()
                    Dim mainAppForm As New Form1()
                    mainAppForm.Show()

                Else

                    MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If


    End Sub
    Private Sub ButtonLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles ButtonLogin.KeyDown



        Dim conn As New MY_CONNECTION()
            Dim adapter As New MySqlDataAdapter()
            Dim table As New DataTable()
            Dim command As New MySqlCommand("SELECT `username`, `password` FROM `users` WHERE `username` = @usn AND `password` = @pass", conn.getConnection())

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text

            If TextBoxUsername.Text.Trim() = "" Or TextBoxUsername.Text.Trim().ToLower() = "username" Then

                MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf TextBoxPassword.Text.Trim() = "" Or TextBoxPassword.Text.Trim().ToLower() = "password" Then

                MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                adapter.SelectCommand = command
                adapter.Fill(table)

                If table.Rows.Count > 0 Then

                    Me.Hide()
                    Dim mainAppForm As New Form1()
                    mainAppForm.Show()

                Else

                    MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

    End Sub


    ' label go to signup form click
    Private Sub LabelGoToSignUp_Click(sender As Object, e As EventArgs)

        Me.Hide()
        Dim rForm As New RegisterForm()
        rForm.Show()

    End Sub


End Class