Imports System.IO
Imports Svg
Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class SIgnUp
    Dim connectionString As String = "Data Source=MANISHLAMA;Initial Catalog=UserDB;Integrated Security=True;Trust Server Certificate=True"

    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        Dim fullName As String = FnameTxt.Text
        Dim username As String = UnameTxt.Text
        Dim password As String = PassTxt.Text

        If String.IsNullOrEmpty(fullName) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("All fields are required.")
            Return
        End If

        Using conn As New SqlConnection("Server=MANISHLAMA;Database=UserDB;Trusted_Connection=True;")
            conn.Open()
            Using cmd As New SqlCommand("INSERT INTO Users (FullName, Username, Password) VALUES (@FullName, @Username, @Password)", conn)
                cmd.Parameters.AddWithValue("@FullName", fullName)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User registered successfully.")

                    Dim signInForm As New SignIn()
                    signInForm.Show()
                    Me.Hide()
                Catch ex As SqlException
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignInLL.LinkClicked
        Dim form2 As New SignIn
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub PassTxt_Enter(sender As Object, e As EventArgs) Handles PassTxt.Enter
        UpdatePasswordVisibility()
    End Sub

    Private Sub PassTxt_Leave(sender As Object, e As EventArgs) Handles PassTxt.Leave
        If String.IsNullOrWhiteSpace(PassTxt.Text) Then
            PassTxt.PasswordChar = ControlChars.NullChar ' Remove PasswordChar to show default text
        End If
    End Sub

    Private Sub ShowPassCB_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCB.CheckedChanged
        UpdatePasswordVisibility()
    End Sub

    Private Sub UpdatePasswordVisibility()
        If ShowPassCB.Checked Then
            ' Show the password
            PassTxt.PasswordChar = ControlChars.NullChar
        Else
            ' Hide the password, unless the TextBox is empty and showing default text
            If PassTxt.Text <> "Enter Password" Then
                PassTxt.PasswordChar = "*"c
            Else
                PassTxt.PasswordChar = ControlChars.NullChar
            End If
        End If
    End Sub

    Private Sub ShowPassCB_GotFocus(sender As Object, e As EventArgs) Handles ShowPassCB.GotFocus
        UpdatePasswordVisibility()
    End Sub


    '---- GRADIENT MILAUNA LAI ----'
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Get the client area of the form
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)

        ' Define the start and end colors for the gradient
        Dim startColor As Color = Color.Beige
        Dim endColor As Color = Color.AliceBlue

        ' Create a LinearGradientBrush
        Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
            ' Fill the rectangle with the gradient
            e.Graphics.FillRectangle(brush, rect)
        End Using
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Redraw the form when it is resized to update the gradient
        Me.Invalidate()
    End Sub

    '---- END ----'

End Class
