
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Threading

Public Class Form1

    Dim selectedCrypto As String = "doge"
    Dim selectedCurrency As String = "aud"
    Dim lastPrice = 0.0

    Sub MyBackgroundThread()
        'Console.WriteLine("Hullo")'
        Do
            Dim generatedURL As String = "https://api.cryptonator.com/api/ticker/" + selectedCrypto + "-" + selectedCurrency
            Dim req As HttpWebRequest = WebRequest.Create(generatedURL)
            Dim res As HttpWebResponse = req.GetResponse()
            Dim sr As New StreamReader(res.GetResponseStream())
            Dim AvailableApps As Object = sr.ReadToEnd()
            Dim jo As JObject _
    = JsonConvert.DeserializeObject(Of Object)(AvailableApps)
            Dim timestamp = jo.Item("timestamp")
            Dim success = jo.Item("success")
            Dim error1 = jo.Item("error")
            Dim base = jo.Item("ticker").Item("base")
            Dim target = jo.Item("ticker").Item("target")
            Dim price = jo.Item("ticker").Item("price")
            Dim volume = jo.Item("ticker").Item("volume")
            Dim change = jo.Item("ticker").Item("change")

            'coinIdText.Text = base'
            'currencyText.Text = target'

            Dim convertedPrice = Convert.ToString(price)

            convertedPrice = Val(convertedPrice)

            Dim formattedPriceText = "$" + convertedPrice
            currentPriceText.Text = formattedPriceText
            currentVolumeText.Text = volume
            changeText.Text = change

            Dim convertedChange = Convert.ToString(change)
            Dim formattedPriceChange = "$" + convertedChange

            ' - SET NOTIFICATION ICON TOOLTIP LIVE - '
            Dim CurrPriceTooltip = "Current Price: " + formattedPriceText + " 
" + "Change: " + formattedPriceChange

            NotifyIcon1.Text = CurrPriceTooltip


            ' - SET NOTIFICATION ICON LIVE - '
            If convertedPrice > lastPrice Then
                Dim Ico1 As New System.Drawing.Icon("dogeGreen.ico")
                NotifyIcon1.Icon = Ico1
                lastPrice = convertedPrice
            End If
            If convertedPrice < lastPrice Then
                Dim Ico2 As New System.Drawing.Icon("dogeRed.ico")
                NotifyIcon1.Icon = Ico2
                lastPrice = convertedPrice
            End If
            'If convertedPrice = lastPrice Then
            'Dim Ico3 As New System.Drawing.Icon("C:\Users\T3\source\repos\Dogecoinv2\WindowsApp1\Doge225.ico")
            'NotifyIcon1.Icon = Ico3
            'lastPrice = convertedPrice
            'End If



            'Dim uTime As Double
            'uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
            Dim finalDateTime As String = "Updated: " + GetDateTimefromUTS(timestamp)
            Label7.Text = finalDateTime
            'Console.WriteLine(timestamp)'
            'Application.DoEvents()'

            Threading.Thread.Sleep(1000) 'ms
        Loop
    End Sub

    Dim threadBoi As New Thread(AddressOf MyBackgroundThread)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dim Ico As New System.Drawing.Icon("C:\Users\T3\source\repos\Dogecoinv2\WindowsApp1\Doge225.ico")
        ' Me.Icon = Ico

        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        Me.MaximizeBox = False

        threadBoi.Start()

    End Sub


    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.Icon = Me.NotifyIcon1.Icon
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipTitle = "Dogecoin tracker running"
            NotifyIcon1.BalloonTipText = "🡻 Dogecoin is tracking down here!"
            NotifyIcon1.ShowBalloonTip(30000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'e.Cancel = True'
        Application.Exit()
        End
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        selectedCrypto = ComboBox1.SelectedItem.ToString
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        selectedCurrency = ComboBox2.SelectedItem.ToString
        If threadBoi.ThreadState = ThreadState.StopRequested Then
            threadBoi.Resume()
        End If
    End Sub

    ' -- FUNCTION -- CONVERT UNIX TIME TO READABLE -- '
    Function GetDateTimefromUTS(ByVal seconds As Integer) As System.DateTime

        Dim EpochDate As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)

        Dim EventDT As System.DateTime = EpochDate.AddSeconds(seconds)

        EventDT = EventDT.ToLocalTime

        If EventDT.IsDaylightSavingTime = True And System.DateTime.Now.IsDaylightSavingTime = False Then

            EventDT = EventDT.AddHours(-1)

        ElseIf EventDT.IsDaylightSavingTime = False And System.DateTime.Now.IsDaylightSavingTime = True Then

            EventDT = EventDT.AddHours(1)

        End If

        GetDateTimefromUTS = EventDT

    End Function




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://www.cryptonator.com/api"
        Process.Start(webAddress)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Clipboard.SetText("DRJXuMYUFC8R6ux7885yN9RFE5HTTGwoix")
        sender.text = "COPIED TO CLIPBOARD"
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress As String = "http://reddit.com/user/t3r3nc3101/"
        Process.Start(webAddress)
    End Sub


    Dim instructionsHidden = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If instructionsHidden = False Then
            Me.Size = New Size(270, 292)
            instructionsHidden = True
        ElseIf instructionsHidden = True Then
            Me.Size = New Size(400, 292)
            instructionsHidden = False
        End If
    End Sub

End Class
