'Hey thanks for downloading the source !
'I sunra1n (@sunra1n_) & Validati0n (@validation) spend many time in this program, so please follow us on twitter (it's free) !
'With this premium version you can allow idevice udid's to use siriprox or not via a MYSQL DATABASE ...
'It isn't 100% complete at the moment.
'Take a look in the background.vb to change the MYSQL Database ...
' Much fun !
'If you publish this tool under your name please add our names to the credits :)
Imports System.Net
Imports System.IO
Imports SiriProx.background
Imports Tamir.SharpSsh

Public Class Form1

    Dim iphone As New MobileDevice.iPhone
    Private WithEvents transfer As SecureFileTransfer
    Dim temp As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Dim iPhonev As String
    Dim UsrName As String
    Dim PassWord As String
    Dim isCinject As Boolean
    Dim lbl1String As String = ""
    Dim isbutton1enabled As Boolean = False
    Public Event onTransferStart(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String)
    Public Event onTransferProgress(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String)
    Public Event onTransferEnd(ByVal source As String, ByVal destination As String, ByVal transferredBytes As Integer, ByVal totalBytes As Integer, ByVal message As String)

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        TextBox3.Text = My.Settings.IP
        My.Settings.IP = TextBox3.Text
        My.Settings.Save()
        Dim path As String
        Timer3.Start()
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        path = temp & "\SiriProx\"
        Try
            If IO.Directory.Exists(path) = True Then
                IO.Directory.Delete(path, True)
            End If
        Catch ex As Exception
        End Try
        Application.Exit()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerSupportsCancellation = True
        CheckForIllegalCrossThreadCalls = False
        ToolStrip1.Renderer = New Renderer
        If My.Resources.IP = "Enter WIFI-IP for iDevice Here!" Then
            TextBox3.Text = "Enter WIFI-IP for iDevice Here!"
        Else

            TextBox3.Text = My.Settings.IP
        End If
        BackgroundWorker1.RunWorkerAsync()
        System.IO.Directory.CreateDirectory(temp & "\SiriProx\")
        Timer3.Enabled = True
    End Sub


#Region "Skin Variablen"
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Dim ShowMenu As Boolean = True
    Dim MenuSize As Integer
    Dim AlertPanelShow As Boolean = False
#End Region

#Region "Form Bewegbar machen"

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, TitleBar.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer

        If e.Button = MouseButtons.Left Then
            xOffset = -e.X
            yOffset = -e.Y
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, TitleBar.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub


    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, TitleBar.MouseUp
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If

    End Sub
#End Region

#Region "Skin Funktionen"


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TitleBar.Paint
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Dim B As New Drawing.SolidBrush(Color.FromArgb(128, 255, 255, 255))
        Dim F As New Font("Lucida Sans Unicode", 12, FontStyle.Regular, GraphicsUnit.Pixel, 0, 0)
        e.Graphics.DrawString(Me.Text, F, B, (TitleBar.Width / 2) - (e.Graphics.MeasureString(Me.Text, F, TitleBar.Size, Nothing).Width / 2) + 1, 3)
        e.Graphics.DrawString(Me.Text, F, Brushes.Black, (TitleBar.Width / 2) - (e.Graphics.MeasureString(Me.Text, F, TitleBar.Size, Nothing).Width / 2), 2)
    End Sub

    Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeform.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximize.Click

        Me.MaximizedBounds = My.Computer.Screen.WorkingArea
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
        TitleBar.Refresh()
    End Sub

    Private Sub ControlBoxes_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maximize.MouseEnter, minimize.MouseEnter, closeform.MouseEnter
        closeform.BackgroundImage = My.Resources.close_hover
        minimize.BackgroundImage = My.Resources.minimize_hover
        maximize.BackgroundImage = My.Resources.button_off
    End Sub

    Private Sub ControlBoxes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimize.MouseLeave, maximize.MouseLeave, closeform.MouseLeave
        closeform.BackgroundImage = My.Resources.Close
        minimize.BackgroundImage = My.Resources.minimize
        maximize.BackgroundImage = My.Resources.button_off
    End Sub

    Private Sub close_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles closeform.MouseDown
        closeform.BackgroundImage = My.Resources.Close_click
    End Sub

    Private Sub close_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles closeform.MouseUp
        closeform.BackgroundImage = My.Resources.Close
    End Sub

    Private Sub minimize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles minimize.MouseDown
        minimize.BackgroundImage = My.Resources.minimize_click
    End Sub

    Private Sub minimize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles minimize.MouseUp
        minimize.BackgroundImage = My.Resources.minimize
    End Sub


    Private Sub maximize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles maximize.MouseDown
        maximize.BackgroundImage = My.Resources.button_off
    End Sub

    Private Sub maximize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles maximize.MouseUp
        maximize.BackgroundImage = My.Resources.button_off
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuhide.Click
        If CBool(ShowMenu) Then
            MenuSize = Head.Height
            Head.Height = 22
            ShowMenu = False
        Else
            ShowMenu = True
            Head.Height = MenuSize
        End If
    End Sub

    Sub ShowAlertPanel(ByVal icon As Image, ByVal Title As String, ByVal text As String)
        AlertPanel.Width = CInt((ContentPanel.Width / 100) * 90)
        AlertIcon.BackgroundImage = icon
        AlertTitle.Text = Title
        AlertText.Text = text

        timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        If AlertPanelShow Then

            If AlertPanel.Location.Y + AlertPanel.Height <= 0 Then
                timer1.Stop()

                AlertPanelShow = False
                For Each ctrl As Control In ContentPanel.Controls
                    If ctrl.Name = "AlertPanel" = False Then
                        ctrl.Enabled = True
                    End If
                Next
            Else
                AlertPanel.Location = New Point(CInt((Me.ClientRectangle.Width / 2) - (AlertPanel.Width / 2)), AlertPanel.Location.Y - 5)


            End If
        Else
            If AlertPanel.Location.Y + 5 >= 0 Then
                timer1.Stop()

                AlertPanelShow = True
                For Each ctrl As Control In ContentPanel.Controls
                    If ctrl.Name = "AlertPanel" = False Then
                        ctrl.Enabled = False
                    End If
                Next
            Else
                AlertPanel.Location = New Point(CInt((Me.ClientRectangle.Width / 2) - (AlertPanel.Width / 2)), AlertPanel.Location.Y + 5)

            End If

        End If
    End Sub

    Private Sub AlertClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlertClose.Click
        timer1.Start()
    End Sub
#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ShowAlertPanel(My.Resources.about, "Credits", "              SiriProx Premium by The iRa1nDev Team | Copyright© 2012 @ The iRa1nDev Team " & " | " & "Follow us on twitter (twitter.com/sunra1n_)/(twitter.com/Validati0n)" & "                                                        " & "MacForm programmed by Devtronic | Copyright© 2010 by Devtronic | follow him on twitter (http://twitter.com/devtronic)")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'FIRST 0-50/200
        Button1.Text = "Preparing..."
        buttonactivator.Stop()
        ToolStripButton1.Enabled = False
        Button1.Enabled = False
        Button1.Enabled = False
        ProgressBar1.Style = ProgressBarStyle.Blocks
        Button1.Image = My.Resources.run
        GroupBox4.Enabled = False
        Dim i As Integer = 1000
        ProgressBar1.Value = 5
        Delay(1)
        Button1.Text = "Selecting Server..."
        Dim serverID As Integer = getbestServerId
        If serverID = 0 Then 'Error

        ElseIf serverID = 1 Then

        ElseIf serverID = 2 Then

        End If
        ProgressBar1.Value = 10
        Delay(1)
        Button1.Text = "Downloading files ..."
        Try
            Dim client4 As WebClient = New WebClient
            client4.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/SiriRoxy.zip"), temp & "\SiriProx\SiriRoxy.zip") 'Download the plist 
            Dim client2 As WebClient = New WebClient
            client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), temp & "\SiriProx\cinject") 'Download the cinject for sending the cert
            Dim client3 As WebClient = New WebClient
            client3.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), temp & "\SiriProx\cinject.exe") 'Download the cinject for sending the cert
        Catch
            MsgBox("Please connect to the internet to use SiriProx ! ", MsgBoxStyle.Exclamation)
            Me.Close()
        End Try
        ProgressBar1.Value = 20
        Button1.Text = "Downloading files ..."
        Delay(1)


  

        Button1.Text = "Unpacking files ..."
        Delay(1)
        Dim zip1 As New Ionic.Zip.ZipFile(temp & "\SiriProx\SiriRoxy.zip")
        zip1.ExtractAll(temp & "\SiriProx\", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
        ProgressBar1.Value = 50

        'NeXTSTeP - lol
        If System.IO.File.Exists(temp & "\SiriProx\com.chpwn.spire.preferences.plist") Then
            Button1.Text = "Uploading content ..."
            Delay(1)

            transfer = New SecureFileTransfer(TextBox3.Text, 22, TextBox4.Text, TextBox5.Text)
            transfer.putFile(temp & "\SiriProx\com.chpwn.spire.preferences.plist", "/var/mobile/Library/Preferences/")
            ProgressBar1.Value = 60
            Delay(1)
        Else
            MsgBox("Error #2001")
            'Exit Sub
        End If

        If System.IO.File.Exists(temp & "\SiriProx\hosts") Then
            Button1.Text = "Uploading content ..."
            Delay(1)
            transfer = New SecureFileTransfer(TextBox3.Text, 22, TextBox4.Text, TextBox5.Text)
            transfer.putFile(temp & "\SiriProx\hosts", "/etc/")
            ProgressBar1.Value = 70
            Delay(1)
           
        Else
            MsgBox("Error #2002")
            'Exit Sub
        End If

        If System.IO.File.Exists(temp & "\SiriProx\com.apple.assistant.plist") Then
            Button1.Text = "Uploading content ..."
            Delay(1)
            transfer = New SecureFileTransfer(TextBox3.Text, 22, TextBox4.Text, TextBox5.Text)
            transfer.putFile(temp & "\SiriProx\com.apple.assistant.plist", "/var/mobile/Library/Preferences/")
            ProgressBar1.Value = 80
            Delay(1)

            Dim Cert As WebClient = New WebClient
            Dim certlink As String = Cert.DownloadString(New Uri("http://sirifor.me/client/cert.txt")) 'change this link dude ! this is a text with the download link to the cert !


            Try
                If certlink.Contains("crt") Then
                    ProgressBar1.Value = 90
                    Button1.Text = "Sending crt ..."
                    Delay(1)
                    i += 1
                    Dim certdownloadclient As WebClient = New WebClient
                    certdownloadclient.DownloadFileAsync(New Uri(certlink), temp & "\SiriProx\SiriProx.crt")
                    Label1.Text = temp & "\SiriProx\SiriProx.crt"
                    Try
                        Timer5.Start()
                        Shell(temp & "\SiriProx\cinject.exe -i" & Label1.Text, AppWinStyle.Hide)
                    Catch
                    End Try
                Else
                    If certlink.Contains("pem") Then
                        Button1.Text = "Sending crt ..."
                        Delay(1)
                        ProgressBar1.Value = 90


                        Delay(1)
                        Dim client99 As WebClient = New WebClient
                        client99.DownloadFileAsync(New Uri(certlink), temp & "\SiriProx\SiriProx.pem")
                        Label1.Text = temp & "\SiriProx\SiriProx.pem"
                        Try
                            If System.IO.File.Exists(temp & "\SiriProx\SiriProx.pem") Then
                                Timer5.Start()
                                Shell(temp & "\SiriProx\cinject.exe -i" & Label1.Text, AppWinStyle.Hide)


                            End If


                        Catch
                            ShowAlertPanel(My.Resources.about, "Error", "Could not install pem.")
                        End Try
                    End If
                End If
            Catch
                MsgBox("Error #" & i)
            End Try
        End If
        ProgressBar1.Value = 98

        Button1.Text = "Update Server System..."
        Delay(0.5)
        SetServerIDtoUDID(serverID) 'Important to know what server is used

        Button1.Text = "Cleaning up ..."
        Delay(0.5)
        Dim path As String
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        Try
            path = temp & "\SiriProx\"
            My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch
        End Try
        ProgressBar1.Value = 100
        Button1.Image = My.Resources.installed
        ToolStripButton1.Enabled = False
        Button1.Text = "Siri Proxy was installed!" & vbCrLf & "Don't forget to reboot and enjoy Siri on your iDevice!"

    End Sub


    Sub changelabel1()
        Label4.Text = lbl1String
    End Sub

    Private Sub BackgroundWorker1_DoWork() Handles BackgroundWorker1.DoWork
        Do Until iphone.IsConnected = True
            Application.DoEvents()
        Loop
        If iphone.IsConnected = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True

            If iphone.DeviceProductType = "iPod3,1" Then
                iPhonev = "iPod Touch 3G"

            ElseIf iphone.DeviceProductType = "iPod4,1" Then
                iPhonev = "iPod Touch 4"

            ElseIf iphone.DeviceProductType = "iPod2,1" Then
                iPhonev = "iPod Touch 2G"

            ElseIf iphone.DeviceProductType = "iPod1,1" Then
                iPhonev = "iPod touch 1G"

            ElseIf iphone.DeviceProductType = "AppleTV2,1" Then
                iPhonev = "Apple TV 2G"

            ElseIf iphone.DeviceProductType = "iPad1,1" Then
                iPhonev = "iPad 1G"

            ElseIf iphone.DeviceProductType = "iPad2,1" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPad2,2" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPad2,3" Then
                iPhonev = "iPad 2G"

            ElseIf iphone.DeviceProductType = "iPhone1,1" Then
                iPhonev = "iPhone 2G"

            ElseIf iphone.DeviceProductType = "iPhone1,2" Then
                iPhonev = "iPhone 3G"

            ElseIf iphone.DeviceProductType = "iPhone2,1" Then
                iPhonev = "iPhone 3GS"

            ElseIf iphone.DeviceProductType = "iPhone3,3" Then
                iPhonev = "iPhone 4"

            ElseIf iphone.DeviceProductType = "iPhone3,1" Then
                iPhonev = "iPhone 4"

            ElseIf iphone.DeviceProductType = "iPhone4,1" Then
                iPhonev = "iPhone 4S"

            End If


            lbl1String = iPhonev & " connected."
            Label4.Invoke((CType(AddressOf changelabel1, MethodInvoker)))

            Delay(3)

            lbl1String = "Check compatibility"
            Label4.Invoke((CType(AddressOf changelabel1, MethodInvoker)))

            Dim Spire As Boolean = isSpireinstalled(iphone)
            If Spire = False Then
                MsgBox("Warning this Operation needs a Device with Spire." & vbNewLine & "You can get Spire for free in Cydia", MsgBoxStyle.Critical, "Error")
                lbl1String = "You need Spire !"
                Label4.Invoke((CType(AddressOf changelabel1, MethodInvoker)))
                BackgroundWorker1.CancelAsync()
                Exit Sub
            End If

            lbl1String = "Check Premium..."
            Label4.Invoke((CType(AddressOf changelabel1, MethodInvoker)))

            Dim prem As Boolean = isPremium(iphone)
            If prem = False Then
                MsgBox("Haha nice trick but you are not a Premium seller...")
                lbl1String = "No Premium"
                Label4.Invoke((CType(AddressOf changelabel1, MethodInvoker)))
                BackgroundWorker1.CancelAsync()
                Exit Sub
            End If

            lbl1String = iphone.DeviceName & " is ready to install SiriProx Premium"
            Label4.Invoke((CType(AddressOf changelabel1, MethodInvoker)))

            ' Timer3.Enabled = False
            Timer3.Stop()

            Button1.Enabled = True 'Hier button

            TextBox3.Enabled = True
            TextBox3.Text = "Enter WIFI-IP for iDevice Here!"
            BackgroundWorker1.CancelAsync()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.Text.Contains("crt") Then
        Else
            Shell(temp & "\SiriProx\cinject.exe -i" & Label1.Text, AppWinStyle.MaximizedFocus)
            ProgressBar1.Value = 100
            timer1.Stop()
        End If
    End Sub
  

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        UsrName = TextBox4.Text
        PassWord = TextBox5.Text
    End Sub

    Private Sub buttonactivator_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonactivator.Tick
        If TextBox3.Text.Contains("1") Then
            Button1.Enabled = True
            ToolStripButton1.Enabled = True
        Else
            ToolStripButton1.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        ShowAlertPanel(My.Resources.uninstall, "Uninstall SiriProx Siri Proxy", "This will delete all installed files (that SiriProx has installed) from your idevice. Are you sure ?")
        Button4.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Dim path As String
        Dim processes = (From p As Process In Process.GetProcesses Where p.ProcessName = "cinject" Select p).ToArray()
        If processes.Count > 0 Then

         

        Else

            Button1.Text = "Cleaning up ..."
            temp = My.Computer.FileSystem.SpecialDirectories.Temp
           
            Try
                path = temp & "\SiriProx\"
                My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch
            End Try
            ProgressBar1.Value = 100
            Button1.Image = My.Resources.installed
            Button1.Text = "Siri Proxy was succesfull uninstalled!"
            Timer4.Stop()
        End If

    
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Dim path As String
        Dim processes = (From p As Process In Process.GetProcesses Where p.ProcessName = "cinject" Select p).ToArray()
        If processes.Count > 0 Then


        Else


            temp = My.Computer.FileSystem.SpecialDirectories.Temp
            Try
                Shell("taskkill /IM:cinject.exe")
            Catch
            End Try
            Try
                path = temp & "\SiriProx\"
                My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch
            End Try
         
            Timer5.Stop()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Timer4.Start()
        Shell(temp & "\SiriProx\cinject.exe -r", AppWinStyle.Hide)
        Button1.Text = "Cleaning up ..."
        Dim path As String
        'Try
        '    Shell("taskkill /IM:cinject.exe")

        'Catch
        'End Try
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        Try
            path = temp & "\SiriProx\"
            My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch
        End Try
        timer1.Start()
        ProgressBar1.Value = 100
        Button1.Image = My.Resources.installed
        ToolStripButton1.Enabled = False

        Button1.Text = "Siri Proxy was succesfull uninstalled!"

    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        timer1.Start()
        Button1.Text = "Cleaning up ..."
        Dim path As String
        'Try
        '    Shell("taskkill /IM:cinject.exe")

        'Catch
        'End Try
        temp = My.Computer.FileSystem.SpecialDirectories.Temp
        Try
            path = temp & "\SiriProx\"
            My.Computer.FileSystem.DeleteDirectory(path, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch
        End Try
        ProgressBar1.Value = 100
        Button1.Image = My.Resources.installed
        ToolStripButton1.Enabled = False
        Button2.Visible = False
        Button3.Visible = False
        Button1.Text = "Siri Proxy was succesfull uninstalled!"

    End Sub

    Private Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
  
        timer1.Start()
        Button4.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
  
        timer1.Start()
        Button1.Text = "Starting uninstall ..."
        Button4.Visible = False
        Button5.Visible = False
        buttonactivator.Stop()
        Button1.Enabled = False
        ToolStripButton1.Enabled = False
        ProgressBar1.Style = ProgressBarStyle.Blocks
        Button1.Image = My.Resources.run
        GroupBox4.Enabled = False
        Dim i As Integer = 1000
        ProgressBar1.Value = 10
        Button1.Text = "Preparing iDevice ..."
        Delay(1)
        Try
            Dim client4 As WebClient = New WebClient
            client4.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/SUninstall.zip"), temp & "\SiriProx\SUninstall.zip") 'Download the the clean plist

            Dim client2 As WebClient = New WebClient
            client2.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject"), temp & "\SiriProx\cinject")
            Dim client3 As WebClient = New WebClient
            i += 1
            client3.DownloadFileAsync(New Uri("http://dl.dropbox.com/u/50777566/cinject.exe"), temp & "\SiriProx\cinject.exe")


        Catch
            MsgBox("Please connect to the internet to use SiriProx ! ", MsgBoxStyle.Exclamation)
            Me.Close()
        End Try
        ProgressBar1.Value = 20

        Delay(1)
        Button1.Text = "Preparing to remove the files ..."
        Delay(1)
        Dim zip1 As New Ionic.Zip.ZipFile(temp & "\SiriProx\SUninstall.zip")
        zip1.ExtractAll(temp & "\SiriProx\", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
        ProgressBar1.Value = 50

        'NeXTSTeP - lol
        If System.IO.File.Exists(temp & "\SiriProx\com.chpwn.spire.preferences.plist") Then
            Button1.Text = "Deleting content ..."
            Delay(1)
            'WinSCP.StandardInput.WriteLine("put " & temp & "\SiriProx\com.chpwn.spire.preferences.plist")
            transfer = New SecureFileTransfer(TextBox3.Text, 22, TextBox4.Text, TextBox5.Text)
            transfer.putFile(temp & "\SiriProx\com.chpwn.spire.preferences.plist", "/var/mobile/Library/Preferences/")
            ProgressBar1.Value = 60
            Delay(1)
        Else
            MsgBox("Error #2001")
            Exit Sub
        End If

        If System.IO.File.Exists(temp & "\SiriProx\hosts") Then
            Button1.Text = "Deleting content ..."
            Delay(1)
            transfer = New SecureFileTransfer(TextBox3.Text, 22, TextBox4.Text, TextBox5.Text)
            transfer.putFile(temp & "\SiriProx\hosts", "/etc/")
            ProgressBar1.Value = 70
            Delay(1)
            'WinSCP.StandardInput.WriteLine("cd /etc/")
            'WinSCP.StandardInput.WriteLine("put " & temp & "\SiriProx\hosts")
        Else
            MsgBox("Error #2002")
            Exit Sub
        End If

        If System.IO.File.Exists(temp & "\SiriProx\com.apple.assistant.plist") Then
            Button1.Text = "Deleting content ..."
            Delay(1)
            transfer = New SecureFileTransfer(TextBox3.Text, 22, TextBox4.Text, TextBox5.Text)
            transfer.putFile(temp & "\SiriProx\com.apple.assistant.plist", "/var/mobile/Library/Preferences/")
            ProgressBar1.Value = 80
            Delay(1)
            Button2.Visible = True
            Button3.Visible = True
            Button1.Enabled = False

            ShowAlertPanel(My.Resources.cert, "Delete all certs ?", "Do you want to delete the/all certs ? (WARNING : THIS WILL DELETE ALL PROFILES/CERTIFICATES FROM YOUR iDEVICE !)")
            Delay(1)
            'Select Case MessageBox.Show("Do you want to delete the/all certs ? " & vbLf & "(WARNING : THIS WILL DELETE ALL PROFILES/CERTIFICATES FROM YOUR iDEVICE !)", "SiriProx | Uninstall", MessageBoxButtons.YesNo)
            '    Case Windows.Forms.DialogResult.Yes
            '        'code für Ja
            '        Try

            '        Catch
            '            Timer5.Start()
            '            MsgBox("Critical Error : Could not uninstall the certs ... sorry", MsgBoxStyle.Critical)
            '        End Try
            '    Case Windows.Forms.DialogResult.No
            '        'Code für Nein
            'End Select



        End If
    End Sub

    Private Sub ContentPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ContentPanel.Paint

    End Sub
End Class
