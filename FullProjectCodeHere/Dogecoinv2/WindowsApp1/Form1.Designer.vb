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
        Dim ListView1 As System.Windows.Forms.ListView
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.currentPriceText = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.currentVolumeText = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.changeText = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        ListView1 = New System.Windows.Forms.ListView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        ListView1.AutoArrange = False
        ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        ListView1.HideSelection = False
        ListView1.Location = New System.Drawing.Point(9, 10)
        ListView1.Margin = New System.Windows.Forms.Padding(2)
        ListView1.Name = "ListView1"
        ListView1.Size = New System.Drawing.Size(238, 156)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Dogecoin Tracker"
        Me.NotifyIcon1.Visible = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(18, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Coin ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(18, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Currency:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Price:"
        '
        'currentPriceText
        '
        Me.currentPriceText.AutoSize = True
        Me.currentPriceText.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.currentPriceText.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.currentPriceText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.currentPriceText.Location = New System.Drawing.Point(98, 13)
        Me.currentPriceText.Margin = New System.Windows.Forms.Padding(0)
        Me.currentPriceText.Name = "currentPriceText"
        Me.currentPriceText.Size = New System.Drawing.Size(67, 20)
        Me.currentPriceText.TabIndex = 7
        Me.currentPriceText.Text = "loading..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(18, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Volume:"
        '
        'currentVolumeText
        '
        Me.currentVolumeText.AutoSize = True
        Me.currentVolumeText.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.currentVolumeText.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.currentVolumeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.currentVolumeText.Location = New System.Drawing.Point(99, 105)
        Me.currentVolumeText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.currentVolumeText.Name = "currentVolumeText"
        Me.currentVolumeText.Size = New System.Drawing.Size(55, 17)
        Me.currentVolumeText.TabIndex = 9
        Me.currentVolumeText.Tag = "loading..."
        Me.currentVolumeText.Text = "loading..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(18, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Change:"
        '
        'changeText
        '
        Me.changeText.AutoSize = True
        Me.changeText.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.changeText.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.changeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.changeText.Location = New System.Drawing.Point(99, 34)
        Me.changeText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.changeText.Name = "changeText"
        Me.changeText.Size = New System.Drawing.Size(55, 17)
        Me.changeText.TabIndex = 11
        Me.changeText.Text = "loading..."
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "DOGE"
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DOGE", "BTC", "ETH", "XRP"})
        Me.ComboBox1.Location = New System.Drawing.Point(146, 88)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Tag = "DOGE"
        Me.ComboBox1.ValueMember = "DOGE"
        Me.ComboBox1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(18, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Updated: loading..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(20, 169)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 14)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Free for everyone! Dogecoin tips appreciated:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 6.75!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(66, 196)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "(click to copy to clipboard)"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ComboBox2.DisplayMember = "DOGE"
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.ComboBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ItemHeight = 17
        Me.ComboBox2.Items.AddRange(New Object() {"AUD", "USD", "GBP", "EUR"})
        Me.ComboBox2.Location = New System.Drawing.Point(102, 59)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(90, 25)
        Me.ComboBox2.TabIndex = 17
        Me.ComboBox2.Tag = ""
        Me.ComboBox2.ValueMember = "AUD"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Comic Sans MS", 6.75!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(71, 233)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(151, 13)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://www.cryptonator.com/api"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 6.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(6, 233)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Data source -"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(99, 89)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "DOGE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(255, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(3, 230)
        Me.Panel1.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 6.7!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(77, 150)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "(updates every minute)"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Italic)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 183)
        Me.RichTextBox1.Multiline = False
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(211, 15)
        Me.RichTextBox1.TabIndex = 24
        Me.RichTextBox1.Text = "DRJXuMYUFC8R6ux7885yN9RFE5HTTGwoix"
        Me.RichTextBox1.WordWrap = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 6.75!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(6, 220)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Creator -"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Comic Sans MS", 6.75!)
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(71, 220)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(167, 13)
        Me.LinkLabel2.TabIndex = 26
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "https://reddit.com/user/t3r3nc3101"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Marlett", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.Location = New System.Drawing.Point(223, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 20)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "?"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.instructions1
        Me.PictureBox1.Location = New System.Drawing.Point(264, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 235)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 253)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.changeText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.currentVolumeText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.currentPriceText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(ListView1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dogecoin Tracker v0.1"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents currentPriceText As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents currentVolumeText As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents changeText As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button1 As Button
End Class
