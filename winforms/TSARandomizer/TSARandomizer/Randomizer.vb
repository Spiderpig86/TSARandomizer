Public Class Randomizer

    Private _fadeOpacity As Single = 1
    Private arrow As Image
    Private rnd As New Random

    Private Function FadeBitmap(ByVal bmp As Bitmap, ByVal opacity As Single) As Bitmap
        Dim bmp2 As New Bitmap(bmp.Width, bmp.Height, Imaging.PixelFormat.Format32bppArgb)
        opacity = Math.Max(0, Math.Min(opacity, 1.0F))
        Using ia As New Imaging.ImageAttributes
            Dim cm As New Imaging.ColorMatrix
            cm.Matrix33 = opacity
            ia.SetColorMatrix(cm)
            Dim destpoints() As PointF = {New Point(0, 0), New Point(bmp.Width, 0), New Point(0, bmp.Height)}
            Using g As Graphics = Graphics.FromImage(bmp2)
                g.DrawImage(bmp, destpoints, _
                New RectangleF(Point.Empty, bmp.Size), GraphicsUnit.Pixel, ia)
            End Using
        End Using
        Return bmp2
    End Function

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles arrowPb.Paint
        If _fadeOpacity > 0 AndAlso arrow IsNot Nothing Then
            Using fadedImage As Bitmap = FadeBitmap(arrow, _fadeOpacity)
                e.Graphics.DrawImageUnscaled(fadedImage, Point.Empty)
            End Using
        End If
    End Sub

    Private Sub Randomizer_Layout(sender As Object, e As LayoutEventArgs) Handles MyBase.Layout
        arrowPb.Refresh()
    End Sub

    Private Sub fadeTimer_Tick(sender As Object, e As EventArgs) Handles fadeTimer.Tick
        _fadeOpacity -= 0.02
        If _fadeOpacity < 0 Then
            _fadeOpacity = 1
            fadeTimer.Stop()
            arrowPb.Image = Nothing
            arrow = Nothing
        End If
        arrowPb.Invalidate()
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, arrowPb.MouseEnter
        Panel1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackColor = Color.Transparent
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, arrowPb.Click
        fadeTimer.Stop() ' Just in case it was still running
        _fadeOpacity = 1
        arrow = IIf(rnd.Next(0, 2), My.Resources.Back_96, My.Resources.Forward_96)
        fadeTimer.Start()
    End Sub
End Class
