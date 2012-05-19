<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Head = New System.Windows.Forms.Panel()
        Me.topmid = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.menuhide = New System.Windows.Forms.PictureBox()
        Me.maximize = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.closeform = New System.Windows.Forms.PictureBox()
        Me.topright = New System.Windows.Forms.Panel()
        Me.topleft = New System.Windows.Forms.Panel()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlertPanel = New System.Windows.Forms.Panel()
        Me.AlertText = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AlertClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AlertIcon = New System.Windows.Forms.PictureBox()
        Me.AlertTitle = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SiriPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.buttonactivator = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Head.SuspendLayout()
        Me.topmid.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TitleBar.SuspendLayout()
        CType(Me.menuhide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContentPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.AlertPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.AlertIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SiriPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Head
        '
        Me.Head.BackColor = System.Drawing.Color.Pink
        Me.Head.Controls.Add(Me.topmid)
        Me.Head.Controls.Add(Me.topright)
        Me.Head.Controls.Add(Me.topleft)
        Me.Head.Dock = System.Windows.Forms.DockStyle.Top
        Me.Head.Location = New System.Drawing.Point(0, 0)
        Me.Head.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Head.MaximumSize = New System.Drawing.Size(0, 78)
        Me.Head.Name = "Head"
        Me.Head.Size = New System.Drawing.Size(882, 78)
        Me.Head.TabIndex = 0
        '
        'topmid
        '
        Me.topmid.BackgroundImage = Global.SiriProx.My.Resources.Resources.Top
        Me.topmid.Controls.Add(Me.ToolStrip1)
        Me.topmid.Controls.Add(Me.TitleBar)
        Me.topmid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topmid.Location = New System.Drawing.Point(5, 0)
        Me.topmid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.topmid.Name = "topmid"
        Me.topmid.Size = New System.Drawing.Size(872, 78)
        Me.topmid.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 22)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(872, 56)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.SiriProx.My.Resources.Resources.about
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(53, 52)
        Me.ToolStripButton2.Text = "Credits"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton2.ToolTipText = "Credits"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Image = Global.SiriProx.My.Resources.Resources.uninstall
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(60, 52)
        Me.ToolStripButton1.Text = "Uninstall"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Transparent
        Me.TitleBar.Controls.Add(Me.menuhide)
        Me.TitleBar.Controls.Add(Me.maximize)
        Me.TitleBar.Controls.Add(Me.minimize)
        Me.TitleBar.Controls.Add(Me.closeform)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(872, 22)
        Me.TitleBar.TabIndex = 1
        '
        'menuhide
        '
        Me.menuhide.BackColor = System.Drawing.Color.Transparent
        Me.menuhide.BackgroundImage = Global.SiriProx.My.Resources.Resources.hidemenu
        Me.menuhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menuhide.Dock = System.Windows.Forms.DockStyle.Right
        Me.menuhide.Location = New System.Drawing.Point(852, 0)
        Me.menuhide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.menuhide.Name = "menuhide"
        Me.menuhide.Size = New System.Drawing.Size(20, 22)
        Me.menuhide.TabIndex = 6
        Me.menuhide.TabStop = False
        Me.menuhide.Visible = False
        '
        'maximize
        '
        Me.maximize.BackColor = System.Drawing.Color.Transparent
        Me.maximize.BackgroundImage = Global.SiriProx.My.Resources.Resources.button_off
        Me.maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.maximize.Dock = System.Windows.Forms.DockStyle.Left
        Me.maximize.Enabled = False
        Me.maximize.Location = New System.Drawing.Point(42, 0)
        Me.maximize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(21, 22)
        Me.maximize.TabIndex = 5
        Me.maximize.TabStop = False
        '
        'minimize
        '
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.BackgroundImage = Global.SiriProx.My.Resources.Resources.minimize
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.minimize.Dock = System.Windows.Forms.DockStyle.Left
        Me.minimize.Location = New System.Drawing.Point(21, 0)
        Me.minimize.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(21, 22)
        Me.minimize.TabIndex = 4
        Me.minimize.TabStop = False
        '
        'closeform
        '
        Me.closeform.BackColor = System.Drawing.Color.Transparent
        Me.closeform.BackgroundImage = Global.SiriProx.My.Resources.Resources.Close
        Me.closeform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeform.Dock = System.Windows.Forms.DockStyle.Left
        Me.closeform.Location = New System.Drawing.Point(0, 0)
        Me.closeform.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.closeform.Name = "closeform"
        Me.closeform.Size = New System.Drawing.Size(21, 22)
        Me.closeform.TabIndex = 3
        Me.closeform.TabStop = False
        '
        'topright
        '
        Me.topright.BackgroundImage = Global.SiriProx.My.Resources.Resources.topright
        Me.topright.Dock = System.Windows.Forms.DockStyle.Right
        Me.topright.Location = New System.Drawing.Point(877, 0)
        Me.topright.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.topright.Name = "topright"
        Me.topright.Size = New System.Drawing.Size(5, 78)
        Me.topright.TabIndex = 1
        '
        'topleft
        '
        Me.topleft.BackgroundImage = Global.SiriProx.My.Resources.Resources.topleft
        Me.topleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.topleft.Location = New System.Drawing.Point(0, 0)
        Me.topleft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.topleft.Name = "topleft"
        Me.topleft.Size = New System.Drawing.Size(5, 78)
        Me.topleft.TabIndex = 0
        '
        'ContentPanel
        '
        Me.ContentPanel.Controls.Add(Me.GroupBox3)
        Me.ContentPanel.Controls.Add(Me.Label1)
        Me.ContentPanel.Controls.Add(Me.AlertPanel)
        Me.ContentPanel.Controls.Add(Me.GroupBox2)
        Me.ContentPanel.Controls.Add(Me.GroupBox1)
        Me.ContentPanel.Controls.Add(Me.Label6)
        Me.ContentPanel.Controls.Add(Me.SiriPictureBox)
        Me.ContentPanel.Controls.Add(Me.Label7)
        Me.ContentPanel.Controls.Add(Me.GroupBox4)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(0, 78)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(882, 249)
        Me.ContentPanel.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Location = New System.Drawing.Point(-14, 236)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1220, 92)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Pink
        Me.Panel1.Location = New System.Drawing.Point(3, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1142, 95)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Label1"
        '
        'AlertPanel
        '
        Me.AlertPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AlertPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.AlertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlertPanel.Controls.Add(Me.AlertText)
        Me.AlertPanel.Controls.Add(Me.Panel2)
        Me.AlertPanel.Controls.Add(Me.Panel3)
        Me.AlertPanel.Location = New System.Drawing.Point(210, -250)
        Me.AlertPanel.Name = "AlertPanel"
        Me.AlertPanel.Size = New System.Drawing.Size(500, 233)
        Me.AlertPanel.TabIndex = 0
        '
        'AlertText
        '
        Me.AlertText.AcceptsReturn = True
        Me.AlertText.AcceptsTab = True
        Me.AlertText.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.AlertText.Cursor = System.Windows.Forms.Cursors.Default
        Me.AlertText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlertText.Location = New System.Drawing.Point(0, 70)
        Me.AlertText.Multiline = True
        Me.AlertText.Name = "AlertText"
        Me.AlertText.ReadOnly = True
        Me.AlertText.Size = New System.Drawing.Size(498, 138)
        Me.AlertText.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.AlertClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 23)
        Me.Panel2.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.Location = New System.Drawing.Point(264, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Yes, please uninstall the Siri Proxy on my iDevice."
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.Location = New System.Drawing.Point(176, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "No."
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.Location = New System.Drawing.Point(88, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "YES"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "NO"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'AlertClose
        '
        Me.AlertClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.AlertClose.Location = New System.Drawing.Point(410, 0)
        Me.AlertClose.Name = "AlertClose"
        Me.AlertClose.Size = New System.Drawing.Size(88, 23)
        Me.AlertClose.TabIndex = 0
        Me.AlertClose.Text = "Close"
        Me.AlertClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.AlertIcon)
        Me.Panel3.Controls.Add(Me.AlertTitle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(498, 70)
        Me.Panel3.TabIndex = 3
        '
        'AlertIcon
        '
        Me.AlertIcon.BackColor = System.Drawing.Color.Transparent
        Me.AlertIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AlertIcon.Location = New System.Drawing.Point(3, 3)
        Me.AlertIcon.Name = "AlertIcon"
        Me.AlertIcon.Size = New System.Drawing.Size(64, 64)
        Me.AlertIcon.TabIndex = 0
        Me.AlertIcon.TabStop = False
        '
        'AlertTitle
        '
        Me.AlertTitle.AutoSize = True
        Me.AlertTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertTitle.Location = New System.Drawing.Point(70, 36)
        Me.AlertTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.AlertTitle.Name = "AlertTitle"
        Me.AlertTitle.Size = New System.Drawing.Size(66, 31)
        Me.AlertTitle.TabIndex = 1
        Me.AlertTitle.Text = "Title"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(196, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 129)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.SiriProx.My.Resources.Resources.install
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(55, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(399, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Install SiriProx"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 39)
        Me.ProgressBar1.MarqueeAnimationSpeed = 19
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(477, 25)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(29, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Waiting for iDevice ..."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 94)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Server Adress :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cert Link :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(99, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(251, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(412, 28)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "NOTE: This program requires Wi-Fi + OpenSSH"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SiriPictureBox
        '
        Me.SiriPictureBox.BackgroundImage = Global.SiriProx.My.Resources.Resources.siri
        Me.SiriPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SiriPictureBox.Location = New System.Drawing.Point(689, -49)
        Me.SiriPictureBox.Name = "SiriPictureBox"
        Me.SiriPictureBox.Size = New System.Drawing.Size(234, 298)
        Me.SiriPictureBox.TabIndex = 23
        Me.SiriPictureBox.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(622, 21)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Info : You need a working Siri GUI on your idevice (like Spire)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 97)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(175, 101)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "OpenSSH Login"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Password :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Username :"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(76, 45)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(79, 20)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Text = "alpine"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(76, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(79, 20)
        Me.TextBox4.TabIndex = 0
        Me.TextBox4.Text = "root"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Enabled = False
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(6, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(163, 20)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.Text = "Enter WIFI-IP for iDevice Here!"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timer1
        '
        Me.timer1.Interval = 1
        '
        'BackgroundWorker1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        Me.Timer6.Interval = 1
        '
        'buttonactivator
        '
        Me.buttonactivator.Enabled = True
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'Timer5
        '
        Me.Timer5.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 327)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.Head)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SiriProx Premium"
        Me.TransparencyKey = System.Drawing.Color.Pink
        Me.Head.ResumeLayout(False)
        Me.topmid.ResumeLayout(False)
        Me.topmid.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TitleBar.ResumeLayout(False)
        CType(Me.menuhide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContentPanel.ResumeLayout(False)
        Me.ContentPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.AlertPanel.ResumeLayout(False)
        Me.AlertPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AlertIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SiriPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Head As System.Windows.Forms.Panel
    Friend WithEvents topmid As System.Windows.Forms.Panel
    Friend WithEvents topright As System.Windows.Forms.Panel
    Friend WithEvents topleft As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TitleBar As System.Windows.Forms.Panel
    Friend WithEvents maximize As System.Windows.Forms.PictureBox
    Friend WithEvents minimize As System.Windows.Forms.PictureBox
    Friend WithEvents closeform As System.Windows.Forms.PictureBox
    Friend WithEvents menuhide As System.Windows.Forms.PictureBox

    Private Sub menuhide_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles menuhide.MouseDown
        menuhide.BackgroundImage = My.Resources.hidemenu_click
    End Sub

    Private Sub menuhide_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles menuhide.MouseUp
        menuhide.BackgroundImage = My.Resources.hidemenu
    End Sub
    Friend WithEvents ContentPanel As System.Windows.Forms.Panel
    Friend WithEvents AlertPanel As System.Windows.Forms.Panel
    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents AlertTitle As System.Windows.Forms.Label
    Friend WithEvents AlertIcon As System.Windows.Forms.PictureBox
    Friend WithEvents AlertText As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AlertClose As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents SiriPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents buttonactivator As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
