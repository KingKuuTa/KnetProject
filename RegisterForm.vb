Imports MySql.Data.MySqlClient

Public Class RegisterForm



    ' button close click
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub

    ' textbox first name enter


    ' textbox first name leave


    ' textbox last name enter


    ' textbox last name leave


    ' textbox username enter


    ' textbox username leave


    ' textbox email enter


    ' textbox email leave


    ' textbox password enter


    ' textbox password leave


    ' textbox confirm password enter


    ' textbox confirm password leave


    ' button register click
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click, ButtonClose.Click

        ' check if the fields are empty
        ' check if the password = the confirm password
        ' check if the username already exists

        ' get textboxes values
        Dim fname As String = TextBoxFirstname.Text
        Dim lname As String = TextBoxLastname.Text
        Dim username As String = TextBoxUsername.Text
        Dim email As String = TextBoxEmail.Text
        Dim password As String = TextBoxPassword.Text
        Dim cpassword As String = TextBoxConfirmPassword.Text


        If fname.Trim() = "" Or lname.Trim() = "" Or username.Trim() = "" Or email.Trim() = "" Or password.Trim() = "" Then

            MessageBox.Show("One Or More Fields Are Empty", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Not String.Equals(password, cpassword) Then

            MessageBox.Show("Wrong Confirmation Password", "password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf usernameExist(username) Then

            MessageBox.Show("This Username Already Exists, Choose Another One", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            ' add the new user
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO `users`(`first_name`, `last_name`, `email`, `username`, `password`) VALUES (@fn, @ln, @mail, @usn, @pass)", conn.getConnection)

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Registration Completed Successfully", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.closeConnection()

            Else

                MessageBox.Show("Something Happen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.closeConnection()

            End If


        End If



    End Sub


    ' create a function to check if the username already exists
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim con As New MY_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the username exist return true
        If table.Rows.Count > 0 Then

            Return True

            ' if not return false  
        Else

            Return False

        End If

    End Function

    ' button close mouse enter


    ' button close mouse leave


    ' label go to signin mouse enter


    ' label go to signin mouse leave


    ' label go to signin mouse click
    Private Sub LabelGoToSignIn_Click(sender As Object, e As EventArgs) Handles LabelGoToSignIn.Click

        Me.Hide()
        Dim lForm As New Form2()
        lForm.Show()

    End Sub
End Class
