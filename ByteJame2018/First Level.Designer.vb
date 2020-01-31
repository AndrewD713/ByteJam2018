<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFirstLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstLevel))
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblGotBurger = New System.Windows.Forms.Label()
        Me.picCorg = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picNoOb6 = New System.Windows.Forms.PictureBox()
        Me.picNoOb5 = New System.Windows.Forms.PictureBox()
        Me.picNoOb4 = New System.Windows.Forms.PictureBox()
        Me.picNoOb3 = New System.Windows.Forms.PictureBox()
        Me.picPud2 = New System.Windows.Forms.PictureBox()
        Me.picpud1 = New System.Windows.Forms.PictureBox()
        Me.picBed = New System.Windows.Forms.PictureBox()
        Me.picCuc2 = New System.Windows.Forms.PictureBox()
        Me.picCuc1 = New System.Windows.Forms.PictureBox()
        Me.picOb12 = New System.Windows.Forms.PictureBox()
        Me.picOb11 = New System.Windows.Forms.PictureBox()
        Me.picBurger = New System.Windows.Forms.PictureBox()
        Me.picOb9 = New System.Windows.Forms.PictureBox()
        Me.picOb8 = New System.Windows.Forms.PictureBox()
        Me.picOb7 = New System.Windows.Forms.PictureBox()
        Me.picOb6 = New System.Windows.Forms.PictureBox()
        Me.picOb5 = New System.Windows.Forms.PictureBox()
        Me.picOb4 = New System.Windows.Forms.PictureBox()
        Me.picOb3 = New System.Windows.Forms.PictureBox()
        Me.picOb2 = New System.Windows.Forms.PictureBox()
        Me.picOb1 = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picNoOb1 = New System.Windows.Forms.PictureBox()
        Me.picNoOb2 = New System.Windows.Forms.PictureBox()
        Me.picOb10 = New System.Windows.Forms.PictureBox()
        CType(Me.picCorg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoOb6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoOb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoOb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoOb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCuc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCuc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBurger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoOb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNoOb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 10
        '
        'tmrSpeed
        '
        Me.tmrSpeed.Interval = 3000
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 10
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 10
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 10
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 1
        '
        'tmrGameTime
        '
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(629, 34)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(35, 37)
        Me.lblTimer.TabIndex = 8
        Me.lblTimer.Text = "0"
        '
        'lblGotBurger
        '
        Me.lblGotBurger.AutoSize = True
        Me.lblGotBurger.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGotBurger.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblGotBurger.Location = New System.Drawing.Point(340, 83)
        Me.lblGotBurger.Name = "lblGotBurger"
        Me.lblGotBurger.Size = New System.Drawing.Size(612, 29)
        Me.lblGotBurger.TabIndex = 33
        Me.lblGotBurger.Text = "You Haz CheezBurger! Escape through the window!"
        Me.lblGotBurger.Visible = False
        '
        'picCorg
        '
        Me.picCorg.Image = Global.ByteJame2018.My.Resources.Resources.corg
        Me.picCorg.Location = New System.Drawing.Point(4381, 664)
        Me.picCorg.Name = "picCorg"
        Me.picCorg.Size = New System.Drawing.Size(206, 119)
        Me.picCorg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCorg.TabIndex = 34
        Me.picCorg.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.Image = Global.ByteJame2018.My.Resources.Resources.cato
        Me.picPlayer.Location = New System.Drawing.Point(89, 667)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(109, 115)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 4
        Me.picPlayer.TabStop = False
        '
        'picNoOb6
        '
        Me.picNoOb6.Image = Global.ByteJame2018.My.Resources.Resources.images__1_
        Me.picNoOb6.Location = New System.Drawing.Point(5021, 238)
        Me.picNoOb6.Name = "picNoOb6"
        Me.picNoOb6.Size = New System.Drawing.Size(334, 174)
        Me.picNoOb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNoOb6.TabIndex = 32
        Me.picNoOb6.TabStop = False
        '
        'picNoOb5
        '
        Me.picNoOb5.Image = Global.ByteJame2018.My.Resources.Resources.blamedog
        Me.picNoOb5.Location = New System.Drawing.Point(3050, 391)
        Me.picNoOb5.Name = "picNoOb5"
        Me.picNoOb5.Size = New System.Drawing.Size(238, 159)
        Me.picNoOb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNoOb5.TabIndex = 31
        Me.picNoOb5.TabStop = False
        '
        'picNoOb4
        '
        Me.picNoOb4.Image = Global.ByteJame2018.My.Resources.Resources._02_cathumor_net_
        Me.picNoOb4.Location = New System.Drawing.Point(2254, 159)
        Me.picNoOb4.Name = "picNoOb4"
        Me.picNoOb4.Size = New System.Drawing.Size(233, 178)
        Me.picNoOb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNoOb4.TabIndex = 30
        Me.picNoOb4.TabStop = False
        '
        'picNoOb3
        '
        Me.picNoOb3.Image = Global.ByteJame2018.My.Resources.Resources._015_best_Grumpy_Cat_memes
        Me.picNoOb3.Location = New System.Drawing.Point(487, 217)
        Me.picNoOb3.Name = "picNoOb3"
        Me.picNoOb3.Size = New System.Drawing.Size(335, 189)
        Me.picNoOb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNoOb3.TabIndex = 29
        Me.picNoOb3.TabStop = False
        '
        'picPud2
        '
        Me.picPud2.BackColor = System.Drawing.Color.Transparent
        Me.picPud2.Image = Global.ByteJame2018.My.Resources.Resources.puddle
        Me.picPud2.Location = New System.Drawing.Point(5060, 570)
        Me.picPud2.Name = "picPud2"
        Me.picPud2.Size = New System.Drawing.Size(110, 58)
        Me.picPud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPud2.TabIndex = 27
        Me.picPud2.TabStop = False
        '
        'picpud1
        '
        Me.picpud1.BackColor = System.Drawing.Color.Transparent
        Me.picpud1.Image = Global.ByteJame2018.My.Resources.Resources.puddle
        Me.picpud1.Location = New System.Drawing.Point(2740, 580)
        Me.picpud1.Name = "picpud1"
        Me.picpud1.Size = New System.Drawing.Size(175, 58)
        Me.picpud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picpud1.TabIndex = 26
        Me.picpud1.TabStop = False
        '
        'picBed
        '
        Me.picBed.Image = Global.ByteJame2018.My.Resources.Resources.Bed
        Me.picBed.Location = New System.Drawing.Point(58, 723)
        Me.picBed.Name = "picBed"
        Me.picBed.Size = New System.Drawing.Size(176, 85)
        Me.picBed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBed.TabIndex = 25
        Me.picBed.TabStop = False
        '
        'picCuc2
        '
        Me.picCuc2.Image = Global.ByteJame2018.My.Resources.Resources.cucumber
        Me.picCuc2.Location = New System.Drawing.Point(3422, 236)
        Me.picCuc2.Name = "picCuc2"
        Me.picCuc2.Size = New System.Drawing.Size(175, 58)
        Me.picCuc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCuc2.TabIndex = 24
        Me.picCuc2.TabStop = False
        '
        'picCuc1
        '
        Me.picCuc1.BackColor = System.Drawing.Color.Transparent
        Me.picCuc1.Image = Global.ByteJame2018.My.Resources.Resources.cucumber
        Me.picCuc1.Location = New System.Drawing.Point(709, 530)
        Me.picCuc1.Name = "picCuc1"
        Me.picCuc1.Size = New System.Drawing.Size(175, 58)
        Me.picCuc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCuc1.TabIndex = 23
        Me.picCuc1.TabStop = False
        '
        'picOb12
        '
        Me.picOb12.Image = Global.ByteJame2018.My.Resources.Resources.Window_Sill
        Me.picOb12.Location = New System.Drawing.Point(6121, 528)
        Me.picOb12.Name = "picOb12"
        Me.picOb12.Size = New System.Drawing.Size(407, 51)
        Me.picOb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb12.TabIndex = 20
        Me.picOb12.TabStop = False
        '
        'picOb11
        '
        Me.picOb11.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb11.Location = New System.Drawing.Point(5645, 445)
        Me.picOb11.Name = "picOb11"
        Me.picOb11.Size = New System.Drawing.Size(313, 77)
        Me.picOb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb11.TabIndex = 19
        Me.picOb11.TabStop = False
        '
        'picBurger
        '
        Me.picBurger.BackColor = System.Drawing.Color.Transparent
        Me.picBurger.Image = Global.ByteJame2018.My.Resources.Resources.testChzBurger
        Me.picBurger.Location = New System.Drawing.Point(5307, 514)
        Me.picBurger.Name = "picBurger"
        Me.picBurger.Size = New System.Drawing.Size(146, 114)
        Me.picBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBurger.TabIndex = 18
        Me.picBurger.TabStop = False
        '
        'picOb9
        '
        Me.picOb9.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb9.Location = New System.Drawing.Point(3769, 434)
        Me.picOb9.Name = "picOb9"
        Me.picOb9.Size = New System.Drawing.Size(313, 77)
        Me.picOb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb9.TabIndex = 16
        Me.picOb9.TabStop = False
        '
        'picOb8
        '
        Me.picOb8.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb8.Location = New System.Drawing.Point(3293, 619)
        Me.picOb8.Name = "picOb8"
        Me.picOb8.Size = New System.Drawing.Size(313, 77)
        Me.picOb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb8.TabIndex = 15
        Me.picOb8.TabStop = False
        '
        'picOb7
        '
        Me.picOb7.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb7.Location = New System.Drawing.Point(3293, 281)
        Me.picOb7.Name = "picOb7"
        Me.picOb7.Size = New System.Drawing.Size(313, 77)
        Me.picOb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb7.TabIndex = 14
        Me.picOb7.TabStop = False
        '
        'picOb6
        '
        Me.picOb6.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb6.Location = New System.Drawing.Point(2724, 619)
        Me.picOb6.Name = "picOb6"
        Me.picOb6.Size = New System.Drawing.Size(313, 77)
        Me.picOb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb6.TabIndex = 13
        Me.picOb6.TabStop = False
        '
        'picOb5
        '
        Me.picOb5.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb5.Location = New System.Drawing.Point(2724, 281)
        Me.picOb5.Name = "picOb5"
        Me.picOb5.Size = New System.Drawing.Size(313, 77)
        Me.picOb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb5.TabIndex = 12
        Me.picOb5.TabStop = False
        '
        'picOb4
        '
        Me.picOb4.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb4.Location = New System.Drawing.Point(2211, 466)
        Me.picOb4.Name = "picOb4"
        Me.picOb4.Size = New System.Drawing.Size(313, 77)
        Me.picOb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb4.TabIndex = 11
        Me.picOb4.TabStop = False
        '
        'picOb3
        '
        Me.picOb3.Image = Global.ByteJame2018.My.Resources.Resources.Window_Sill
        Me.picOb3.Location = New System.Drawing.Point(1764, 533)
        Me.picOb3.Name = "picOb3"
        Me.picOb3.Size = New System.Drawing.Size(289, 63)
        Me.picOb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOb3.TabIndex = 9
        Me.picOb3.TabStop = False
        '
        'picOb2
        '
        Me.picOb2.Image = Global.ByteJame2018.My.Resources.Resources.Counter_Float
        Me.picOb2.Location = New System.Drawing.Point(1260, 396)
        Me.picOb2.Name = "picOb2"
        Me.picOb2.Size = New System.Drawing.Size(322, 84)
        Me.picOb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb2.TabIndex = 7
        Me.picOb2.TabStop = False
        '
        'picOb1
        '
        Me.picOb1.BackColor = System.Drawing.Color.Transparent
        Me.picOb1.Image = Global.ByteJame2018.My.Resources.Resources.Counter_w_Base
        Me.picOb1.Location = New System.Drawing.Point(310, 566)
        Me.picOb1.Name = "picOb1"
        Me.picOb1.Size = New System.Drawing.Size(755, 235)
        Me.picOb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb1.TabIndex = 5
        Me.picOb1.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.picGround.Location = New System.Drawing.Point(27, 776)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(6897, 50)
        Me.picGround.TabIndex = 3
        Me.picGround.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6833, 350)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'picNoOb1
        '
        Me.picNoOb1.Image = Global.ByteJame2018.My.Resources.Resources.Window
        Me.picNoOb1.Location = New System.Drawing.Point(1768, 245)
        Me.picNoOb1.Name = "picNoOb1"
        Me.picNoOb1.Size = New System.Drawing.Size(280, 298)
        Me.picNoOb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNoOb1.TabIndex = 10
        Me.picNoOb1.TabStop = False
        '
        'picNoOb2
        '
        Me.picNoOb2.Image = Global.ByteJame2018.My.Resources.Resources.Window
        Me.picNoOb2.Location = New System.Drawing.Point(6183, 235)
        Me.picNoOb2.Name = "picNoOb2"
        Me.picNoOb2.Size = New System.Drawing.Size(280, 298)
        Me.picNoOb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picNoOb2.TabIndex = 21
        Me.picNoOb2.TabStop = False
        '
        'picOb10
        '
        Me.picOb10.Image = Global.ByteJame2018.My.Resources.Resources.Counter_w_Base
        Me.picOb10.Location = New System.Drawing.Point(4782, 588)
        Me.picOb10.Name = "picOb10"
        Me.picOb10.Size = New System.Drawing.Size(695, 213)
        Me.picOb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOb10.TabIndex = 28
        Me.picOb10.TabStop = False
        '
        'frmFirstLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 844)
        Me.Controls.Add(Me.picCorg)
        Me.Controls.Add(Me.lblGotBurger)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picNoOb6)
        Me.Controls.Add(Me.picNoOb5)
        Me.Controls.Add(Me.picNoOb4)
        Me.Controls.Add(Me.picNoOb3)
        Me.Controls.Add(Me.picPud2)
        Me.Controls.Add(Me.picpud1)
        Me.Controls.Add(Me.picBed)
        Me.Controls.Add(Me.picCuc2)
        Me.Controls.Add(Me.picCuc1)
        Me.Controls.Add(Me.picOb12)
        Me.Controls.Add(Me.picOb11)
        Me.Controls.Add(Me.picBurger)
        Me.Controls.Add(Me.picOb9)
        Me.Controls.Add(Me.picOb8)
        Me.Controls.Add(Me.picOb7)
        Me.Controls.Add(Me.picOb6)
        Me.Controls.Add(Me.picOb5)
        Me.Controls.Add(Me.picOb4)
        Me.Controls.Add(Me.picOb3)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.picOb2)
        Me.Controls.Add(Me.picOb1)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picNoOb1)
        Me.Controls.Add(Me.picNoOb2)
        Me.Controls.Add(Me.picOb10)
        Me.Name = "frmFirstLevel"
        Me.Text = "First_Level"
        CType(Me.picCorg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoOb6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoOb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoOb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoOb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCuc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCuc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBurger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoOb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNoOb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrSpeed As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrDown As Timer
    Friend WithEvents tmrCheck As Timer
    Friend WithEvents tmrGameTime As Timer
    Friend WithEvents picOb10 As PictureBox
    Friend WithEvents picNoOb2 As PictureBox
    Friend WithEvents picNoOb1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents picOb1 As PictureBox
    Friend WithEvents picOb2 As PictureBox
    Friend WithEvents lblTimer As Label
    Friend WithEvents picOb3 As PictureBox
    Friend WithEvents picOb4 As PictureBox
    Friend WithEvents picOb5 As PictureBox
    Friend WithEvents picOb6 As PictureBox
    Friend WithEvents picOb7 As PictureBox
    Friend WithEvents picOb8 As PictureBox
    Friend WithEvents picOb9 As PictureBox
    Friend WithEvents picBurger As PictureBox
    Friend WithEvents picOb11 As PictureBox
    Friend WithEvents picOb12 As PictureBox
    Friend WithEvents picCuc1 As PictureBox
    Friend WithEvents picCuc2 As PictureBox
    Friend WithEvents picBed As PictureBox
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picpud1 As PictureBox
    Friend WithEvents picPud2 As PictureBox
    Friend WithEvents picNoOb3 As PictureBox
    Friend WithEvents picNoOb4 As PictureBox
    Friend WithEvents picNoOb5 As PictureBox
    Friend WithEvents picNoOb6 As PictureBox
    Friend WithEvents lblGotBurger As Label
    Friend WithEvents picCorg As PictureBox
End Class
