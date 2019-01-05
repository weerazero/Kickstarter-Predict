Public Class Transparent
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(400, 600)
        Me.BackColor = Color.Black
        Me.Opacity = 0.45
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formNewLeft As Integer = Val(Val(screenWidth) / Val(2)) - Val(Val(Me.Width) / Val(2))
        Dim formNewTop As Integer = Val(Val(screenHeight) / Val(2)) - Val(Val(Me.Height) / Val(2))
        Me.Left = formNewLeft
        Me.Top = formNewTop
        Me.ShowInTaskbar = False
    End Sub
End Class