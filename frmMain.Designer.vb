<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdOSK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDiscover = New System.Windows.Forms.Button()
        Me.lstComPort = New System.Windows.Forms.ComboBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.grpTelemetry = New System.Windows.Forms.GroupBox()
        Me.lblLegal = New System.Windows.Forms.Label()
        Me.lblAveragePower = New System.Windows.Forms.Label()
        Me.lblMinPower = New System.Windows.Forms.Label()
        Me.lblMaxPower = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSpreadVel = New System.Windows.Forms.Label()
        Me.lblMaxVel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAvgVel = New System.Windows.Forms.Label()
        Me.lblMinVel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLastShot = New System.Windows.Forms.Label()
        Me.splitContainerDataVis = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colShot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVelocity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWeight = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colEnergy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ctxShot = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveShotDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.grpTelemetry.SuspendLayout()
        CType(Me.splitContainerDataVis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerDataVis.Panel1.SuspendLayout()
        Me.splitContainerDataVis.Panel2.SuspendLayout()
        Me.splitContainerDataVis.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxShot.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdOSK)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdQuit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdEnd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdStart)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1008, 729)
        Me.SplitContainer1.SplitterDistance = 214
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RAPshot.My.Resources.Resources.rifle1
        Me.PictureBox1.Location = New System.Drawing.Point(33, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'cmdOSK
        '
        Me.cmdOSK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOSK.Location = New System.Drawing.Point(21, 524)
        Me.cmdOSK.Name = "cmdOSK"
        Me.cmdOSK.Size = New System.Drawing.Size(152, 62)
        Me.cmdOSK.TabIndex = 9
        Me.cmdOSK.Text = "OSK"
        Me.cmdOSK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDiscover)
        Me.GroupBox1.Controls.Add(Me.lstComPort)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 117)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COM"
        '
        'cmdDiscover
        '
        Me.cmdDiscover.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscover.Location = New System.Drawing.Point(9, 61)
        Me.cmdDiscover.Name = "cmdDiscover"
        Me.cmdDiscover.Size = New System.Drawing.Size(152, 50)
        Me.cmdDiscover.TabIndex = 2
        Me.cmdDiscover.Text = "Discover"
        Me.cmdDiscover.UseVisualStyleBackColor = True
        '
        'lstComPort
        '
        Me.lstComPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RAPshot.My.MySettings.Default, "ComPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lstComPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstComPort.FormattingEnabled = True
        Me.lstComPort.Items.AddRange(New Object() {"COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.lstComPort.Location = New System.Drawing.Point(9, 19)
        Me.lstComPort.Name = "lstComPort"
        Me.lstComPort.Size = New System.Drawing.Size(152, 33)
        Me.lstComPort.TabIndex = 1
        Me.lstComPort.Text = Global.RAPshot.My.MySettings.Default.ComPort
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(21, 388)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(152, 62)
        Me.cmdClear.TabIndex = 7
        Me.cmdClear.Text = "Clear Data"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(21, 456)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(152, 62)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save Data"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdQuit
        '
        Me.cmdQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuit.Location = New System.Drawing.Point(21, 642)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(152, 62)
        Me.cmdQuit.TabIndex = 5
        Me.cmdQuit.Text = "EXIT"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'cmdEnd
        '
        Me.cmdEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd.Location = New System.Drawing.Point(21, 266)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(152, 62)
        Me.cmdEnd.TabIndex = 4
        Me.cmdEnd.Text = "END"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(21, 198)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(152, 62)
        Me.cmdStart.TabIndex = 3
        Me.cmdStart.Text = "START"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpTelemetry)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblLastShot)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.splitContainerDataVis)
        Me.SplitContainer2.Size = New System.Drawing.Size(790, 729)
        Me.SplitContainer2.SplitterDistance = 182
        Me.SplitContainer2.TabIndex = 0
        '
        'grpTelemetry
        '
        Me.grpTelemetry.Controls.Add(Me.lblLegal)
        Me.grpTelemetry.Controls.Add(Me.lblAveragePower)
        Me.grpTelemetry.Controls.Add(Me.lblMinPower)
        Me.grpTelemetry.Controls.Add(Me.lblMaxPower)
        Me.grpTelemetry.Controls.Add(Me.Label7)
        Me.grpTelemetry.Controls.Add(Me.Label5)
        Me.grpTelemetry.Controls.Add(Me.Label2)
        Me.grpTelemetry.Controls.Add(Me.Label4)
        Me.grpTelemetry.Controls.Add(Me.lblSpreadVel)
        Me.grpTelemetry.Controls.Add(Me.lblMaxVel)
        Me.grpTelemetry.Controls.Add(Me.Label10)
        Me.grpTelemetry.Controls.Add(Me.Label6)
        Me.grpTelemetry.Controls.Add(Me.lblAvgVel)
        Me.grpTelemetry.Controls.Add(Me.lblMinVel)
        Me.grpTelemetry.Controls.Add(Me.Label8)
        Me.grpTelemetry.Location = New System.Drawing.Point(10, 85)
        Me.grpTelemetry.Name = "grpTelemetry"
        Me.grpTelemetry.Size = New System.Drawing.Size(755, 85)
        Me.grpTelemetry.TabIndex = 11
        Me.grpTelemetry.TabStop = False
        '
        'lblLegal
        '
        Me.lblLegal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegal.Location = New System.Drawing.Point(581, 47)
        Me.lblLegal.Name = "lblLegal"
        Me.lblLegal.Size = New System.Drawing.Size(153, 29)
        Me.lblLegal.TabIndex = 17
        Me.lblLegal.Text = "FAC Status"
        Me.lblLegal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAveragePower
        '
        Me.lblAveragePower.AutoSize = True
        Me.lblAveragePower.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveragePower.Location = New System.Drawing.Point(478, 47)
        Me.lblAveragePower.Name = "lblAveragePower"
        Me.lblAveragePower.Size = New System.Drawing.Size(48, 25)
        Me.lblAveragePower.TabIndex = 16
        Me.lblAveragePower.Text = "000"
        '
        'lblMinPower
        '
        Me.lblMinPower.AutoSize = True
        Me.lblMinPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinPower.Location = New System.Drawing.Point(279, 47)
        Me.lblMinPower.Name = "lblMinPower"
        Me.lblMinPower.Size = New System.Drawing.Size(48, 25)
        Me.lblMinPower.TabIndex = 15
        Me.lblMinPower.Text = "000"
        '
        'lblMaxPower
        '
        Me.lblMaxPower.AutoSize = True
        Me.lblMaxPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPower.Location = New System.Drawing.Point(100, 47)
        Me.lblMaxPower.Name = "lblMaxPower"
        Me.lblMaxPower.Size = New System.Drawing.Size(48, 25)
        Me.lblMaxPower.TabIndex = 14
        Me.lblMaxPower.Text = "000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(375, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Avg flbs"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(181, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Min flbs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Max flbs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Max fps"
        '
        'lblSpreadVel
        '
        Me.lblSpreadVel.AutoSize = True
        Me.lblSpreadVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpreadVel.Location = New System.Drawing.Point(676, 16)
        Me.lblSpreadVel.Name = "lblSpreadVel"
        Me.lblSpreadVel.Size = New System.Drawing.Size(48, 25)
        Me.lblSpreadVel.TabIndex = 10
        Me.lblSpreadVel.Text = "000"
        '
        'lblMaxVel
        '
        Me.lblMaxVel.AutoSize = True
        Me.lblMaxVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxVel.Location = New System.Drawing.Point(100, 16)
        Me.lblMaxVel.Name = "lblMaxVel"
        Me.lblMaxVel.Size = New System.Drawing.Size(48, 25)
        Me.lblMaxVel.TabIndex = 4
        Me.lblMaxVel.Text = "000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(589, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Spread"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(181, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Min fps"
        '
        'lblAvgVel
        '
        Me.lblAvgVel.AutoSize = True
        Me.lblAvgVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgVel.Location = New System.Drawing.Point(478, 16)
        Me.lblAvgVel.Name = "lblAvgVel"
        Me.lblAvgVel.Size = New System.Drawing.Size(48, 25)
        Me.lblAvgVel.TabIndex = 8
        Me.lblAvgVel.Text = "000"
        '
        'lblMinVel
        '
        Me.lblMinVel.AutoSize = True
        Me.lblMinVel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinVel.Location = New System.Drawing.Point(279, 16)
        Me.lblMinVel.Name = "lblMinVel"
        Me.lblMinVel.Size = New System.Drawing.Size(48, 25)
        Me.lblMinVel.TabIndex = 6
        Me.lblMinVel.Text = "000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(375, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Avg fps"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(16, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(302, 73)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last shot"
        '
        'lblLastShot
        '
        Me.lblLastShot.AutoSize = True
        Me.lblLastShot.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastShot.ForeColor = System.Drawing.Color.Navy
        Me.lblLastShot.Location = New System.Drawing.Point(377, 9)
        Me.lblLastShot.Name = "lblLastShot"
        Me.lblLastShot.Size = New System.Drawing.Size(343, 73)
        Me.lblLastShot.TabIndex = 0
        Me.lblLastShot.Text = "000.00 fps"
        '
        'splitContainerDataVis
        '
        Me.splitContainerDataVis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerDataVis.Location = New System.Drawing.Point(0, 0)
        Me.splitContainerDataVis.Name = "splitContainerDataVis"
        Me.splitContainerDataVis.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainerDataVis.Panel1
        '
        Me.splitContainerDataVis.Panel1.Controls.Add(Me.ListView1)
        '
        'splitContainerDataVis.Panel2
        '
        Me.splitContainerDataVis.Panel2.Controls.Add(Me.Chart1)
        Me.splitContainerDataVis.Size = New System.Drawing.Size(790, 543)
        Me.splitContainerDataVis.SplitterDistance = 271
        Me.splitContainerDataVis.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colShot, Me.colVelocity, Me.colWeight, Me.colEnergy})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(790, 271)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colShot
        '
        Me.colShot.Text = "Shot"
        Me.colShot.Width = 101
        '
        'colVelocity
        '
        Me.colVelocity.Text = "Velocity"
        Me.colVelocity.Width = 158
        '
        'colWeight
        '
        Me.colWeight.Text = "Pellet weight"
        Me.colWeight.Width = 198
        '
        'colEnergy
        '
        Me.colEnergy.Text = "Muzzle energy"
        Me.colEnergy.Width = 323
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BackColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineWidth = 2
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea1.AxisX2.IsStartedFromZero = False
        ChartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.IsStartedFromZero = False
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightSkyBlue
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.Black
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.White
        Series1.IsXValueIndexed = True
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Red
        Series1.MarkerSize = 8
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(790, 268)
        Me.Chart1.SuppressExceptions = True
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'ctxShot
        '
        Me.ctxShot.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveShotDataToolStripMenuItem})
        Me.ctxShot.Name = "ctxShot"
        Me.ctxShot.Size = New System.Drawing.Size(239, 34)
        '
        'RemoveShotDataToolStripMenuItem
        '
        Me.RemoveShotDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveShotDataToolStripMenuItem.Name = "RemoveShotDataToolStripMenuItem"
        Me.RemoveShotDataToolStripMenuItem.Size = New System.Drawing.Size(238, 30)
        Me.RemoveShotDataToolStripMenuItem.Text = "Remove Shot Data"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAPshot"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.grpTelemetry.ResumeLayout(False)
        Me.grpTelemetry.PerformLayout()
        Me.splitContainerDataVis.Panel1.ResumeLayout(False)
        Me.splitContainerDataVis.Panel2.ResumeLayout(False)
        CType(Me.splitContainerDataVis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerDataVis.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxShot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstComPort As System.Windows.Forms.ComboBox
    Friend WithEvents cmdQuit As System.Windows.Forms.Button
    Friend WithEvents cmdEnd As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblLastShot As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colShot As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVelocity As System.Windows.Forms.ColumnHeader
    Friend WithEvents colEnergy As System.Windows.Forms.ColumnHeader
    Friend WithEvents colWeight As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSpreadVel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblAvgVel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblMinVel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMaxVel As System.Windows.Forms.Label
    Friend WithEvents grpTelemetry As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDiscover As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAveragePower As System.Windows.Forms.Label
    Friend WithEvents lblMinPower As System.Windows.Forms.Label
    Friend WithEvents lblMaxPower As System.Windows.Forms.Label
    Friend WithEvents cmdOSK As System.Windows.Forms.Button
    Friend WithEvents ctxShot As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveShotDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLegal As System.Windows.Forms.Label
    Friend WithEvents splitContainerDataVis As SplitContainer
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
