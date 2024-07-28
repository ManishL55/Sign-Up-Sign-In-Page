Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class User_profile

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)

        Dim color1 As Color = Color.AliceBlue
        Dim color2 As Color = Color.FromArgb(20, 30, 80, 225)
        Dim color3 As Color = Color.LavenderBlush

        Using brush As New LinearGradientBrush(rect, color1, color3, LinearGradientMode.Horizontal)
            Dim colorBlend As New ColorBlend()

            colorBlend.Positions = New Single() {0.0F, 0.5F, 1.0F}
            colorBlend.Colors = New Color() {color1, color2, color3}

            brush.InterpolationColors = colorBlend

            e.Graphics.FillRectangle(brush, rect)
        End Using
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Invalidate()
    End Sub
End Class