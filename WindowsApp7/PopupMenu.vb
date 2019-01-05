Public Class PopupMenu


    Dim name, backer, goal As String

    Public Property _name() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property _goal() As String
        Get
            Return goal
        End Get
        Set(ByVal value As String)
            goal = value
        End Set
    End Property
    Public Property _backer() As String
        Get
            Return backer
        End Get
        Set(ByVal value As String)
            backer = value
        End Set
    End Property

    Private Sub PopupMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formNewLeft As Integer = Val(Val(screenWidth) / Val(2)) - Val(Val(Me.Width) / Val(2))
        Dim formNewTop As Integer = Val(Val(screenHeight) / Val(2)) - Val(Val(Me.Height) / Val(2))
        Me.Left = formNewLeft
        Me.Top = formNewTop
        Me.TopMost = True

    End Sub
    Public Sub LoadInfor()


        Dim result = decistion_tree(backer, goal)
        lbName.Text = name
        lbResult.Text = result
        checkImage(result)

    End Sub
    Private Sub checkImage(result As String)
        If result = "successful" Then
            picResult.Image = My.Resources.success
        Else
            picResult.Image = My.Resources.fail
        End If


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BunifuFlatButton1.Enabled = False
        Me.Close()
        Transparent.Close()

    End Sub
    Function decistion_tree(backer As Double, goal As Double) As String
        If backer <= 14.5 Then
            If goal <= 1314.85 Then
                If backer <= 4.5 Then
                    Return "failed"

                Else
                    If goal <= 554.425 Then
                        Return "successful"
                    Else
                        Return "failed"
                    End If
                End If
            Else
                Return "failed"
            End If
        Else
            If goal <= 6098.215 Then
                If backer <= 32.5 Then
                    If goal <= 1800.245 Then
                        Return "successful"
                    Else
                        Return "failed"
                    End If
                Else
                    Return "successful"
                End If
            Else
                If backer <= 68.5 Then
                    Return "failed"
                Else
                    Return "successful"
                End If
            End If
        End If
        Return "not found"
    End Function
End Class