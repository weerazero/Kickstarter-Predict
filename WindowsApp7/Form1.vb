Imports System.Diagnostics
Public Class Form1
    Dim timer1 As Timer = New Timer()
    Dim timer2 As Timer = New Timer()
    Private logreg As Label = New Label()
    Public Sub New()

        InitializeComponent()
        Me.Size = New Size(400, 600)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formNewLeft As Integer = Val(Val(screenWidth) / Val(2)) - Val(Val(Me.Width) / Val(2))
        Dim formNewTop As Integer = Val(Val(screenHeight) / Val(2)) - Val(Val(Me.Height) / Val(2))
        Me.Left = formNewLeft
        Me.Top = formNewTop




        AddHandler timer2.Tick, New EventHandler(AddressOf timer2_go)
        timer1.Interval = 10
        timer2.Interval = 5
        timer1.Start()

    End Sub



    Private Sub timer2_go(ByVal sender As Object, ByVal e As EventArgs)
        If logreg.Text = "Register" Then
            reg()
        ElseIf logreg.Text = "Login" Then
            log()
        ElseIf logreg.Text = "panel3" Then
            Page3()
        End If
    End Sub



    Private go As Integer = 1


    Private move_speed As Integer = 20

    Private Sub Page3()
        If Panel3.Left > 0 Then

            timer1.Start()

            Panel2.Left -= move_speed
            Panel1.Left -= move_speed
            Panel3.Left -= move_speed

        End If
    End Sub
    Private Sub reg()
        If Panel2.Left > 0 Then
            timer1.Start()

            Panel1.Left -= move_speed
            Panel2.Left -= move_speed
            Panel3.Left -= move_speed
            If Panel2.Left = 0 Then
                timer2.[Stop]()
            End If
        ElseIf Panel2.Left < 0 Then
            timer1.Start()

            Panel1.Left += move_speed
            Panel2.Left += move_speed
            Panel3.Left += move_speed
            If Panel2.Left = 0 Then
                timer2.[Stop]()
            End If

        End If
    End Sub

    Private Sub log()
        If Panel1.Left < 0 Then
            timer1.Start()

            Panel2.Left += move_speed
            Panel1.Left += move_speed
            Panel3.Left += move_speed

            If Panel1.Left = 0 Then
                timer2.[Stop]()
            End If
        End If
    End Sub



    Private Sub btn_Click(sender As Object, e As EventArgs)
        logreg.Text = "Register"
        timer2.Start()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        logreg.Text = "Login"
        timer2.Start()
        BunifuFlatButton1.Normalcolor = Color.FromArgb(243, 137, 32)
        BunifuFlatButton2.Normalcolor = Color.FromArgb(55, 55, 55)
        BunifuFlatButton3.Normalcolor = Color.FromArgb(55, 55, 55)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        logreg.Text = "Register"
        timer2.Start()
        BunifuFlatButton2.Normalcolor = Color.FromArgb(243, 137, 32)
        BunifuFlatButton1.Normalcolor = Color.FromArgb(55, 55, 55)
        BunifuFlatButton3.Normalcolor = Color.FromArgb(55, 55, 55)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        logreg.Text = "panel3"
        timer2.Start()
        BunifuFlatButton2.Normalcolor = Color.FromArgb(55, 55, 55)
        BunifuFlatButton3.Normalcolor = Color.FromArgb(243, 137, 32)
        BunifuFlatButton1.Normalcolor = Color.FromArgb(55, 55, 55)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ทำนายผล_Click(sender As Object, e As EventArgs) Handles ทำนายผล.Click

        Dim backer, goal As Double, name As String, backerCk = True, goalCk = True

        If txtName.Text <> "" Then
            lbNameErr.Text = ""
        Else
            lbNameErr.Text = "Please input name of project"
        End If

        If Not Double.TryParse(txtBacker.Text, backer) Then
            lbBackerErr.Text = "Please input correct backer"
            backerCk = False
        Else
            lbBackerErr.Text = ""
        End If

        If Not Double.TryParse(txtGoal.Text, goal) Then
            lbGoalErr.Text = "Please input correct Goal"
            goalCk = False
        Else
            lbGoalErr.Text = ""
        End If

        If goalCk And backerCk And txtName.Text <> "" Then
            Transparent.Show()
            Dim frm As New PopupMenu
            frm._name = Me.txtName.Text
            frm._goal = goal
            frm._backer = backer

            frm.LoadInfor()
            frm.Show()

        End If


        'name = txtNmae.Text








    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Clear()





    End Sub
    Private Sub Clear()
        txtName.ResetText()

        txtGoal.Text = ""
        txtBacker.Text = ""

    End Sub

End Class
