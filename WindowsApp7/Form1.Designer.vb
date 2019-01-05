<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbGoalErr = New System.Windows.Forms.Label()
        Me.lbBackerErr = New System.Windows.Forms.Label()
        Me.lbNameErr = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtGoal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtBacker = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dpCatagory = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ทำนายผล = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 527)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "โปรเเกรมทํานายผลโปรเจค จาก Kickstarter"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Angsana New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(35, 102)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(337, 311)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = resources.GetString("BunifuCustomLabel2.Text")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Location = New System.Drawing.Point(400, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 527)
        Me.Panel2.TabIndex = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(158, 162)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(104, 13)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "BunifuCustomLabel1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lbGoalErr)
        Me.Panel3.Controls.Add(Me.lbBackerErr)
        Me.Panel3.Controls.Add(Me.lbNameErr)
        Me.Panel3.Controls.Add(Me.BunifuFlatButton5)
        Me.Panel3.Controls.Add(Me.ทำนายผล)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel3.Controls.Add(Me.txtGoal)
        Me.Panel3.Controls.Add(Me.txtBacker)
        Me.Panel3.Controls.Add(Me.dpCatagory)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Location = New System.Drawing.Point(800, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 527)
        Me.Panel3.TabIndex = 1
        '
        'lbGoalErr
        '
        Me.lbGoalErr.AutoSize = True
        Me.lbGoalErr.ForeColor = System.Drawing.Color.Red
        Me.lbGoalErr.Location = New System.Drawing.Point(157, 309)
        Me.lbGoalErr.Name = "lbGoalErr"
        Me.lbGoalErr.Size = New System.Drawing.Size(0, 13)
        Me.lbGoalErr.TabIndex = 14
        '
        'lbBackerErr
        '
        Me.lbBackerErr.AutoSize = True
        Me.lbBackerErr.BackColor = System.Drawing.Color.White
        Me.lbBackerErr.ForeColor = System.Drawing.Color.Red
        Me.lbBackerErr.Location = New System.Drawing.Point(158, 261)
        Me.lbBackerErr.Name = "lbBackerErr"
        Me.lbBackerErr.Size = New System.Drawing.Size(0, 13)
        Me.lbBackerErr.TabIndex = 13
        '
        'lbNameErr
        '
        Me.lbNameErr.AutoSize = True
        Me.lbNameErr.ForeColor = System.Drawing.Color.Red
        Me.lbNameErr.Location = New System.Drawing.Point(154, 155)
        Me.lbNameErr.Name = "lbNameErr"
        Me.lbNameErr.Size = New System.Drawing.Size(0, 13)
        Me.lbNameErr.TabIndex = 12
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(41, 279)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(90, 33)
        Me.BunifuCustomLabel6.TabIndex = 9
        Me.BunifuCustomLabel6.Text = "Goal (USD)"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(41, 233)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(60, 33)
        Me.BunifuCustomLabel5.TabIndex = 8
        Me.BunifuCustomLabel5.Text = "Backer"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(41, 183)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(73, 33)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "Catagory"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Angsana New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(42, 127)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(52, 33)
        Me.BunifuCustomLabel3.TabIndex = 6
        Me.BunifuCustomLabel3.Text = "Name"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGoal
        '
        Me.txtGoal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGoal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGoal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGoal.HintForeColor = System.Drawing.Color.Empty
        Me.txtGoal.HintText = ""
        Me.txtGoal.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtGoal.isPassword = False
        Me.txtGoal.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtGoal.LineIdleColor = System.Drawing.Color.Gray
        Me.txtGoal.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtGoal.LineThickness = 3
        Me.txtGoal.Location = New System.Drawing.Point(155, 279)
        Me.txtGoal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGoal.Name = "txtGoal"
        Me.txtGoal.Size = New System.Drawing.Size(199, 24)
        Me.txtGoal.TabIndex = 5
        Me.txtGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtBacker
        '
        Me.txtBacker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBacker.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtBacker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBacker.HintForeColor = System.Drawing.Color.Empty
        Me.txtBacker.HintText = ""
        Me.txtBacker.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtBacker.isPassword = False
        Me.txtBacker.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBacker.LineIdleColor = System.Drawing.Color.Gray
        Me.txtBacker.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtBacker.LineThickness = 3
        Me.txtBacker.Location = New System.Drawing.Point(155, 233)
        Me.txtBacker.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBacker.Name = "txtBacker"
        Me.txtBacker.Size = New System.Drawing.Size(199, 23)
        Me.txtBacker.TabIndex = 4
        Me.txtBacker.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dpCatagory
        '
        Me.dpCatagory.BackColor = System.Drawing.Color.Transparent
        Me.dpCatagory.BorderRadius = 3
        Me.dpCatagory.ForeColor = System.Drawing.Color.White
        Me.dpCatagory.Items = New String() {"Publishing ", "Film & Video", "Music", "Food", "Design", "Crafts", "Games", "Comics", "Fashion", "Theater", "Art", "Photography", "Technology", "Dance", "Journalism"}
        Me.dpCatagory.Location = New System.Drawing.Point(155, 185)
        Me.dpCatagory.Name = "dpCatagory"
        Me.dpCatagory.NomalColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.dpCatagory.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dpCatagory.selectedIndex = -1
        Me.dpCatagory.Size = New System.Drawing.Size(199, 26)
        Me.dpCatagory.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HintForeColor = System.Drawing.Color.Empty
        Me.txtName.HintText = ""
        Me.txtName.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtName.isPassword = False
        Me.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtName.LineIdleColor = System.Drawing.Color.Gray
        Me.txtName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.txtName.LineThickness = 3
        Me.txtName.Location = New System.Drawing.Point(155, 127)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(199, 23)
        Me.txtName.TabIndex = 2
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Prediction"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(262, 25)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.SystemColors.Window
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(121, 36)
        Me.BunifuFlatButton3.TabIndex = 6
        Me.BunifuFlatButton3.Text = "Prediction"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Visualization"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(141, 25)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(121, 36)
        Me.BunifuFlatButton2.TabIndex = 5
        Me.BunifuFlatButton2.Text = "Visualization"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Introduction"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(20, 25)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(121, 36)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.Text = "Introduction"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(166, -81)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(400, 20)
        Me.Panel4.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ทํานายผลโปรเจค จาก Kickstarter"
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.White
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = Nothing
        Me.btnMinimize.Location = New System.Drawing.Point(357, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(15, 15)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 9
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Zoom = 10
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(382, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(15, 15)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 8
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "Reset"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(222, 344)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(132, 48)
        Me.BunifuFlatButton5.TabIndex = 11
        Me.BunifuFlatButton5.Text = "Reset"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ทำนายผล
        '
        Me.ทำนายผล.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ทำนายผล.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ทำนายผล.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ทำนายผล.BorderRadius = 0
        Me.ทำนายผล.ButtonText = "Predict"
        Me.ทำนายผล.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ทำนายผล.DisabledColor = System.Drawing.Color.Gray
        Me.ทำนายผล.Iconcolor = System.Drawing.Color.Transparent
        Me.ทำนายผล.Iconimage = CType(resources.GetObject("ทำนายผล.Iconimage"), System.Drawing.Image)
        Me.ทำนายผล.Iconimage_right = Nothing
        Me.ทำนายผล.Iconimage_right_Selected = Nothing
        Me.ทำนายผล.Iconimage_Selected = Nothing
        Me.ทำนายผล.IconMarginLeft = 0
        Me.ทำนายผล.IconMarginRight = 0
        Me.ทำนายผล.IconRightVisible = True
        Me.ทำนายผล.IconRightZoom = 0R
        Me.ทำนายผล.IconVisible = True
        Me.ทำนายผล.IconZoom = 90.0R
        Me.ทำนายผล.IsTab = False
        Me.ทำนายผล.Location = New System.Drawing.Point(48, 344)
        Me.ทำนายผล.Name = "ทำนายผล"
        Me.ทำนายผล.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ทำนายผล.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ทำนายผล.OnHoverTextColor = System.Drawing.Color.White
        Me.ทำนายผล.selected = False
        Me.ทำนายผล.Size = New System.Drawing.Size(132, 48)
        Me.ทำนายผล.TabIndex = 10
        Me.ทำนายผล.Text = "Predict"
        Me.ทำนายผล.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ทำนายผล.Textcolor = System.Drawing.Color.White
        Me.ทำนายผล.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGoal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtBacker As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dpCatagory As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ทำนายผล As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbGoalErr As Label
    Friend WithEvents lbBackerErr As Label
    Friend WithEvents lbNameErr As Label
    Friend WithEvents Label2 As Label
End Class
