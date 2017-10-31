Imports System.Drawing.Drawing2D

Module Funciones
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Public Function CreateBackgroundGradient(ByVal Img As Bitmap, ByVal h As Integer, ByVal w As Integer) As Bitmap
        Using e As Graphics = Graphics.FromImage(Img)
            Using b As New LinearGradientBrush(New Rectangle(0I, 0I, w, h), Color.RoyalBlue, Color.CornflowerBlue, Drawing2D.LinearGradientMode.ForwardDiagonal)
                e.FillRectangle(b, New Rectangle(0I, 0I, w, h))
            End Using
        End Using

        Return Img
    End Function
End Module
