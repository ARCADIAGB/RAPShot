Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class frmMain

    Const strSelect As String = "Select..."

    Private APPMODE As String = "RIFLE" 'PISTOL or RIFLE
    Private LegalLimit As Single = 12.0


    Private Shots As List(Of Shot)
    Private SelectedPortName As String
    Private cp As SerialPort
    Private myThread As Thread
    Private WeightMode As String 'USER | CHRONO
    Private TestMode As Boolean


#Region "Form Controls"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Shots = New List(Of Shot)
        ' this is only for tesing fake data

        Dim args() As String = Environment.GetCommandLineArgs
        If args.Count = 2 Then
            If args(1).ToLower = "testmode" Then
                TestMode = True
                Me.Text = "RAPShot (TEST MODE)"
            End If
        End If


        If My.Settings.ComPort = String.Empty Then
            lstComPort.Text = strSelect
        Else
            lstComPort.SelectedItem = My.Settings.ComPort
            If Not lstComPort.SelectedItem = strSelect Then
                SelectedPortName = lstComPort.SelectedItem
            End If
        End If

        Try
            If Not Directory.Exists(My.Settings.ReportsDir) Then
                Directory.CreateDirectory(My.Settings.ReportsDir)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        If lstComPort.Text = strSelect Then
            MsgBox("No valid COM port selected")
            Exit Sub
        End If

        Shots = New List(Of Shot)


        Dim dlgMode As New frmWeightConfig
        dlgMode.ShowDialog()
        WeightMode = dlgMode.WeightMode

        cmdStart.Enabled = False
        cmdEnd.Enabled = True

        Try
            cp = New SerialPort(SelectedPortName)
            cp.BaudRate = 9600
            cp.Parity = Parity.None
            cp.StopBits = StopBits.One
            cp.DataBits = 8
            cp.Handshake = Handshake.None
            cp.RtsEnable = True

            AddHandler cp.DataReceived, AddressOf DataReceivedHandler

            cp.Open()
        Catch ex As Exception
            MessageBox.Show("Error opening selected COM port" & vbCrLf & ex.Message, "Communication Breakdown", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdStart.Enabled = True
            cmdEnd.Enabled = False
        End Try



    End Sub

    Private Sub cmdEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
        Try
            cp.Close()
            cmdStart.Enabled = True
            cmdEnd.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If TestMode = True Then
            Shots = New List(Of Shot)
            If APPMODE = "RIFLE" Then
                WriteTestData("774.22,fps;8.44;gr")
                WriteTestData("769.72,fps;8.44;gr")
                WriteTestData("770.12,fps;8.44;gr")
                WriteTestData("766.22,fps;8.44;gr")
                WriteTestData("767.77,fps;8.44;gr")
                WriteTestData("772.40,fps;8.44;gr")
            ElseIf APPMODE = "PISTOL" Then
                WriteTestData("374.22,fps;16.00;gr")
                WriteTestData("379.72,fps;16.00;gr")
                WriteTestData("370.12,fps;16.00;gr")
                WriteTestData("376.22,fps;16.00;gr")
                WriteTestData("367.77,fps;16.00;gr")
                WriteTestData("352.40,fps;16.00;gr")
            End If

            UpdateTelemetry()
                Exit Sub
            End If


            Try
            If File.Exists("C:\Windows\System32\osk.exe") Then
                System.Diagnostics.Process.Start("C:\Windows\System32\osk.exe")
            End If
        Catch ex As Exception

        End Try


        Dim fsd As New SaveFileDialog
        Try

            With fsd
                .CheckPathExists = True
                .Title = "Select a file to save data to"
                .InitialDirectory = My.Settings.ReportsDir
                .DefaultExt = ".csv"
                .FileName = "RAPSHOT_DATA_"
                .OverwritePrompt = True
                .Filter = "Excel (*.csv) |*.csv |Notepad (*.txt) |*.txt|(*.*) |*.*"
            End With
        Catch ex As Exception

        End Try



        Dim dr As DialogResult = fsd.ShowDialog
        If dr = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        If File.Exists(fsd.FileName) Then
            Try
                File.Delete(fsd.FileName)

            Catch ex As Exception
                MsgBox("Sorry cannot delete the file, it may be open in another program")
                Exit Sub
            End Try
        End If


        Try
            Using fs As New FileStream(fsd.FileName, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite, 1024)
                Using sw As New StreamWriter(fs, System.Text.Encoding.UTF8)
                    For Each s As Shot In Shots
                        sw.WriteLine(s.Velocity & "," & s.PelletWeight & "," & s.MuzzleEnergy)
                    Next
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Cannot save file: " & ex.Message)
        End Try

        Dim sbReport As New System.Text.StringBuilder
        sbReport.AppendLine("RAPSHOT REPORT " & Now.ToShortDateString & " " & Now.ToShortTimeString)
        sbReport.AppendLine("----------------------------------------------")
        sbReport.AppendLine("Weapon profile: " & APPMODE)
        sbReport.AppendLine("Shot string of " & Shots.Count & " shots")
        sbReport.AppendLine()
        sbReport.AppendLine("Average pellet speed = " & lblAvgVel.Text & " fps")
        sbReport.AppendLine("Minimum pellet speed = " & lblMinVel.Text & " fps")
        sbReport.AppendLine("Maximum pellet speed = " & lblMaxVel.Text & " fps")
        sbReport.AppendLine("Pellet speed spread= " & lblSpreadVel.Text & " fps")
        sbReport.AppendLine()
        sbReport.AppendLine("Average muzzle force = " & lblAveragePower.Text & " ftlbs")
        sbReport.AppendLine("Minimum muzzle force = " & lblMinPower.Text & " ftlbs")
        sbReport.AppendLine("Maximum muzzle force = " & lblMaxPower.Text & " ftlbs")
        sbReport.AppendLine("Weapon test status = " & lblLegal.Text)


        Dim newFileName As String = "RAPShot_Report_" & GetDateSerial() & ".txt"
        If newFileName.ToLower.EndsWith(".csv") Then
            newFileName = Replace(fsd.FileName, ".csv", "") & "Report.txt"
        ElseIf newFileName.ToLower.EndsWith(".csv") Then
            newFileName = Replace(fsd.FileName, ".txt", "") & "Report.txt"
        End If


        Try
            Using fs As New FileStream(newFileName, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite, 1024)
                Using sw As New StreamWriter(fs, System.Text.Encoding.UTF8)
                    For Each s As Shot In Shots
                        sw.WriteLine(s.Velocity & "," & s.PelletWeight & "," & s.MuzzleEnergy)
                    Next
                End Using
            End Using
            MsgBox("File saved successfully")
        Catch ex As Exception
            MsgBox("Cannot save file: " & ex.Message)
        End Try

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        ListView1.Items.Clear()
        'clear the telemetry labels
        lblLastShot.Text = "000.00"
        lblMaxVel.Text = ""
        lblMinVel.Text = ""
        lblAvgVel.Text = ""
        lblSpreadVel.Text = ""
        lblAveragePower.Text = ""
        lblMinPower.Text = ""
        lblMaxPower.Text = ""
        lblLegal.Text = "FAC Status"
        lblLegal.BackColor = Color.Empty





    End Sub

    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click
        Environment.Exit(0)

    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub cmdDiscover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscover.Click

        ' Show all available COM ports.
        Cursor = Cursors.WaitCursor
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Try
                If SerialPortIsAvailable(sp) Then
                    lstComPort.SelectedItem = sp
                    Exit For
                End If
            Catch ex As Exception
                Cursor = Cursors.Default
            End Try

        Next
        Cursor = Cursors.Default


    End Sub

    Private Sub cmdOSK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOSK.Click
        If File.Exists("C:\Windows\System32\osk.exe") Then
            Dim psi As New ProcessStartInfo
            psi.FileName = "C:\Windows\System32\osk.exe"
            psi.WindowStyle = ProcessWindowStyle.Normal

            Dim p As New Process
            p.StartInfo = psi
            p.Start()
        Else
            MessageBox.Show("C:\Windows\System32\OSK.exe was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub RemoveShotDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveShotDataToolStripMenuItem.Click

        Dim thisIndex As Integer = ListView1.SelectedItems(0).Index
        ListView1.Items(thisIndex).Remove()
        Shots.RemoveAt(thisIndex)
        UpdateTelemetry()


    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If ListView1.FocusedItem.Bounds.Contains(e.Location) = True Then
                ctxShot.Show(Cursor.Position)
            End If
        End If

    End Sub


    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick

        If APPMODE = "RIFLE" Then
            PictureBox1.Image = My.Resources.pistol
            APPMODE = "PISTOL"
            LegalLimit = 6.0
        Else
            PictureBox1.Image = My.Resources.rifle1
            APPMODE = "RIFLE"
            LegalLimit = 12.0
        End If

        If ListView1.Items.Count > 0 Then
            cmdClear_Click(Nothing, Nothing)
        End If
        Chart1.Series.Clear()


    End Sub

#End Region

#Region "COMPort Ops"
    Private Sub lstComPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstComPort.SelectedIndexChanged
        If lstComPort.SelectedItem = strSelect Then Exit Sub

        My.Settings.ComPort = lstComPort.SelectedItem
        SelectedPortName = lstComPort.SelectedItem
        My.Settings.Save()

    End Sub

    Private Sub DataReceivedHandler(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim serData As String = sp.ReadExisting()
        CheckForIllegalCrossThreadCalls = False

        If serData = "" Then
            'lblRawData.Text = "No data"
            lblLastShot.Text = "-000.00"
        Else
            'lblRawData.Text = serData

            Dim vel As String = String.Empty
            Dim pellwt As String = String.Empty

            'the expected data from the air chrony mk3 is this line
            '000.00;fps;8.000;gr

            'Debug.Print("serdata<" & serData & ">")
            'Me.Text = serData

            If serData.Contains(";") Then
                vel = Split(serData, ";")(0)
                lblLastShot.Text = vel & " fps"
            End If

            If serData.Contains("fps;") Then
                pellwt = Split(Split(serData, "fps;")(1), ";")(0)
            End If


            If WeightMode = "CHRONO" Then
                'just feed it straight in

                Dim ls As New ListViewItem((ListView1.Items.Count + 1).ToString)
                ls.SubItems.Add("colVelocity").Text = FormatNumber(CSng(vel), 2, TriState.False, TriState.False, TriState.False)
                ls.SubItems.Add("colWeight").Text = FormatNumber(CSng(pellwt), 2, TriState.False, TriState.False, TriState.False)
                ls.SubItems.Add("colEnergy").Text = Format(GetPower(vel, pellwt), "0.00")
                ListView1.Items.Add(ls)
                ListView1.EnsureVisible(ListView1.Items.Count - 1)

            ElseIf WeightMode = "USER" Then

                Dim frmPellWeight As New dlgAddWeight
                frmPellWeight.PelletSpeed = vel
                Dim dr As DialogResult = frmPellWeight.ShowDialog
                If dr = Windows.Forms.DialogResult.Cancel Then Exit Sub
                pellwt = frmPellWeight.PelletWeight
                Dim ls As New ListViewItem((ListView1.Items.Count + 1).ToString)
                ls.SubItems.Add("colVelocity").Text = FormatNumber(CSng(vel), 2, TriState.False, TriState.False, TriState.False)
                ls.SubItems.Add("colWeight").Text = FormatNumber(CSng(pellwt), 2, TriState.False, TriState.False, TriState.False)
                ls.SubItems.Add("colEnergy").Text = Format(GetPower(vel, pellwt), "0.00")
                ListView1.Items.Add(ls)
                ListView1.EnsureVisible(ListView1.Items.Count - 1)

            End If

            Dim s As New Shot
            s.Velocity = CSng(vel)
            s.PelletWeight = CSng(pellwt)
            s.MuzzleEnergy = GetPower(vel, pellwt)
            Shots.Add(s)
            UpdateTelemetry()

        End If

    End Sub

    Private Function SerialPortIsAvailable(ByVal PortName As String) As Boolean
        If PortName.ToUpper = "COM1" Then
            'it is extremely unlikely that the chrono is on COM1
            Return False
        End If

        Try
            cp = New SerialPort(PortName)
            cp.BaudRate = 9600
            cp.Parity = Parity.None
            cp.StopBits = StopBits.One
            cp.DataBits = 8
            cp.Handshake = Handshake.None
            cp.RtsEnable = True
            cp.Open()
            System.Threading.Thread.Sleep(1000)
            cp.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

#End Region


#Region "Telemetry"

    Private Sub UpdateTelemetry()


        lblMaxVel.Text = GetMaxVelocity()
        lblMinVel.Text = GetMinVelocity()
        lblSpreadVel.Text = GetVelocitySpread()
        lblAvgVel.Text = GetAverageSpeed()
        lblMinPower.Text = GetMinPower()
        lblMaxPower.Text = GetMaxPower()
        lblAveragePower.Text = GetAveragePower()

        ShowFACstatus()
        UpdateChart()


    End Sub

    Private Sub ShowFACstatus()

        lblLegal.BackColor = Color.Empty
        lblLegal.Text = "FAC Status"
        lblLegal.ForeColor = Color.Black

        If Shots.Count = 0 Then Exit Sub
        Dim lstPwr As New List(Of Single)

        For Each s As Shot In Shots
            lstPwr.Add(s.MuzzleEnergy)
        Next


        If lstPwr.Max > LegalLimit Then
            lblLegal.BackColor = Color.Red
            lblLegal.ForeColor = Color.White
            lblLegal.Text = "Illegal"
        Else
            lblLegal.BackColor = Color.LightGreen
            lblLegal.ForeColor = Color.Black
            lblLegal.Text = "Legal"
        End If

    End Sub

    Private Function GetMinVelocity() As String
        GetMinVelocity = ""
        If Shots.Count = 0 Then Exit Function

        Dim lstVel As New List(Of Single)

        For Each s As Shot In Shots
            lstVel.Add(s.Velocity)
        Next

        Return FormatNumber(lstVel.Min, 2, TriState.False, TriState.False, TriState.False).ToString

    End Function

    Private Function GetMinPower() As String
        GetMinPower = ""
        If Shots.Count = 0 Then Exit Function
        Dim lstPwr As New List(Of Single)

        For Each s As Shot In Shots
            lstPwr.Add(s.MuzzleEnergy)
        Next

        Return FormatNumber(lstPwr.Min, 2, TriState.False, TriState.False, TriState.False).ToString

    End Function

    Private Function GetMaxVelocity() As String
        GetMaxVelocity = ""
        If Shots.Count = 0 Then Exit Function
        Dim lstVel As New List(Of Single)

        For Each s As Shot In Shots
            lstVel.Add(s.Velocity)
        Next

        Return FormatNumber(lstVel.Max, 2, TriState.False, TriState.False, TriState.False).ToString

    End Function

    Private Function GetMaxPower() As String
        GetMaxPower = ""
        If Shots.Count = 0 Then Exit Function
        Dim lstPwr As New List(Of Single)

        For Each s As Shot In Shots
            lstPwr.Add(s.MuzzleEnergy)
        Next

        Return FormatNumber(lstPwr.Max, 2, TriState.False, TriState.False, TriState.False).ToString

    End Function

    Private Function GetVelocitySpread() As String
        GetVelocitySpread = ""
        If Shots.Count = 0 Then Exit Function
        Dim lstVel As New List(Of Single)

        For Each s As Shot In Shots
            lstVel.Add(s.Velocity)
        Next

        Return FormatNumber((lstVel.Max - lstVel.Min), 2, TriState.True, TriState.False, TriState.False).ToString

    End Function

    Private Function GetAverageSpeed() As String
        GetAverageSpeed = ""
        If Shots.Count = 0 Then Exit Function
        Dim c As Integer = 0
        Dim total As Single = 0
        For Each s As Shot In Shots
            c = c + 1
            total = total + s.Velocity
        Next

        Return FormatNumber((total / c), 2, TriState.False, TriState.False, TriState.False)

    End Function

    Private Function GetAveragePower() As String
        GetAveragePower = ""
        Dim c As Integer = 0
        Dim total As Single = 0
        If Shots.Count = 0 Then Exit Function
        Try
            For Each s As Shot In Shots
                c = c + 1
                total = total + s.MuzzleEnergy
            Next
            Return FormatNumber((total / c), 2, TriState.False, TriState.False, TriState.False)
        Catch ex As Exception
            MessageBox.Show("Error in GetAveragePower: " & ex.Message)
            Return "0"
        End Try

    End Function

    Private Function GetDateSerial() As String
        Dim sb As New System.Text.StringBuilder

        sb.Append(Year(Now).ToString)
        Dim m As String = Month(Now).ToString
        If m.Length = 1 Then m = "0" & m
        sb.Append(m)

        Dim d As String = Now.Day.ToString
        If d.Length = 1 Then d = "0" & d
        sb.Append(d)
        Dim h As String = Now.Hour.ToString
        If h.Length = 1 Then h = "0" & h
        sb.Append(h)


        Dim mi As String = Now.Minute.ToString
        If mi.Length = 1 Then mi = "0" & mi
        sb.Append(mi)

        Return sb.ToString

    End Function

    Private Sub WriteTestData(ByVal serData As String)


        Dim vel As String = String.Empty
        Dim pellwt As String = String.Empty
        Dim s As New Shot

        CheckForIllegalCrossThreadCalls = False
        ' Dim serData As String = "774.22,fps;8.44;gr"


        'the expected data from the air chrony mk3 is this line
        '000.00,fps;8.000;gr
        If serData.Contains(",") Then
            vel = Split(serData, ",")(0)
            lblLastShot.Text = vel & " fps"
        End If

        If serData.Contains("fps;") Then
            pellwt = Split(Split(serData, "fps;")(1), ";")(0)
        End If

        Dim ls As New ListViewItem((ListView1.Items.Count + 1).ToString)
        ls.SubItems.Add("colVelocity").Text = vel
        ls.SubItems.Add("colWeight").Text = pellwt
        ls.SubItems.Add("colEnergy").Text = Format(GetPower(vel, pellwt), "0.00")
        ListView1.Items.Add(ls)
        ListView1.EnsureVisible(ListView1.Items.Count - 1)

        s.Velocity = CSng(vel)
        s.PelletWeight = CSng(pellwt)
        s.MuzzleEnergy = GetPower(vel, pellwt)
        Shots.Add(s)

    End Sub

    Function GetPower(ByVal fps As String, ByVal grains As String) As Single

        'E = (M x V²) ÷ K

        ' where K = 450,435 and is derived from (2 x 32.1739 x 7000),
        ' M is the weight of the projectile, in grains,
        ' V is the velocity in feet per second and
        ' E is the energy in foot pounds.
        Dim E, M, V As Single
        V = CSng(fps)
        M = CSng(grains)
        E = ((V * V) * M) / 450435


        'Debug.Print("GetPower = " & Format(E, "0.00"))
        'Debug.Print("Returning : " & FormatNumber(E, 2, TriState.False, TriState.False, TriState.False))
        'Debug.Print("")

        'Return Format(E, "0.00")
        Return FormatNumber(E, 2, TriState.False, TriState.False, TriState.False)


    End Function

    Private Sub UpdateChart()

        Chart1.Series.Clear()
        Chart1.Series.Add("Rapshot")
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline
        Chart1.Series(0).BorderWidth = 3
        Chart1.Series(0).Color = Color.White
        Chart1.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        Chart1.Series(0).MarkerColor = Color.Red
        Chart1.Series(0).MarkerSize = 8


        Dim ca As New DataVisualization.Charting.ChartArea
        ca = Chart1.ChartAreas(0)
        ca.AxisY.IntervalAutoMode = False
        ca.AxisX.Minimum = 1
        If APPMODE = "PISTOL" Then
            ca.AxisY.Minimum = 2
            ca.AxisY.Maximum = 7
        ElseIf APPMODE = "RIFLE" Then
            ca.AxisY.Minimum = 6
            ca.AxisY.Maximum = 13
        End If

        'ca.AxisY.IsLogarithmic = True

        For Each s As Shot In Shots
            Dim dp As New System.Windows.Forms.DataVisualization.Charting.DataPoint
            dp.SetValueY(s.MuzzleEnergy)
            Chart1.Series(0).Points.Add(dp)
        Next



    End Sub





#End Region


End Class
