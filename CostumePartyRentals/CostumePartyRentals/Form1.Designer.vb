<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostumePartyRentals
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCostumePartyRentals))
        Me.cmbCostumeSelection = New System.Windows.Forms.ComboBox()
        Me.btnBookRental = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblExitMessage = New System.Windows.Forms.Label()
        Me.lblPerWeek = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblCostumeRentals = New System.Windows.Forms.Label()
        Me.picRenaissance = New System.Windows.Forms.PictureBox()
        Me.picStorm = New System.Windows.Forms.PictureBox()
        Me.picBatman = New System.Windows.Forms.PictureBox()
        Me.picBatgirl = New System.Windows.Forms.PictureBox()
        Me.picPirate = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picRenaissance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStorm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBatman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBatgirl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPirate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCostumeSelection
        '
        Me.cmbCostumeSelection.AccessibleDescription = ""
        Me.cmbCostumeSelection.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbCostumeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCostumeSelection.FormattingEnabled = True
        Me.cmbCostumeSelection.Items.AddRange(New Object() {"Batman/Batgirl", "Pirate", "Renaissance Fair", "Stormtrooper"})
        Me.cmbCostumeSelection.Location = New System.Drawing.Point(97, 179)
        Me.cmbCostumeSelection.Name = "cmbCostumeSelection"
        Me.cmbCostumeSelection.Size = New System.Drawing.Size(354, 21)
        Me.cmbCostumeSelection.TabIndex = 0
        '
        'btnBookRental
        '
        Me.btnBookRental.BackColor = System.Drawing.Color.Cyan
        Me.btnBookRental.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBookRental.Location = New System.Drawing.Point(195, 282)
        Me.btnBookRental.Name = "btnBookRental"
        Me.btnBookRental.Size = New System.Drawing.Size(158, 37)
        Me.btnBookRental.TabIndex = 1
        Me.btnBookRental.Text = "Book the Rental"
        Me.btnBookRental.UseVisualStyleBackColor = False
        Me.btnBookRental.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picPirate)
        Me.GroupBox1.Controls.Add(Me.picBatgirl)
        Me.GroupBox1.Controls.Add(Me.picBatman)
        Me.GroupBox1.Controls.Add(Me.picStorm)
        Me.GroupBox1.Controls.Add(Me.picRenaissance)
        Me.GroupBox1.Controls.Add(Me.lblExitMessage)
        Me.GroupBox1.Controls.Add(Me.lblPerWeek)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblInstructions)
        Me.GroupBox1.Controls.Add(Me.lblCostumeRentals)
        Me.GroupBox1.Controls.Add(Me.cmbCostumeSelection)
        Me.GroupBox1.Controls.Add(Me.btnBookRental)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 425)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lblExitMessage
        '
        Me.lblExitMessage.AutoSize = True
        Me.lblExitMessage.ForeColor = System.Drawing.Color.Cyan
        Me.lblExitMessage.Location = New System.Drawing.Point(190, 353)
        Me.lblExitMessage.Name = "lblExitMessage"
        Me.lblExitMessage.Size = New System.Drawing.Size(169, 39)
        Me.lblExitMessage.TabIndex = 6
        Me.lblExitMessage.Text = "Thank you for booking your rental!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Have a nice day!"
        Me.lblExitMessage.Visible = False
        '
        'lblPerWeek
        '
        Me.lblPerWeek.AutoSize = True
        Me.lblPerWeek.ForeColor = System.Drawing.Color.Cyan
        Me.lblPerWeek.Location = New System.Drawing.Point(234, 214)
        Me.lblPerWeek.Name = "lblPerWeek"
        Me.lblPerWeek.Size = New System.Drawing.Size(81, 13)
        Me.lblPerWeek.TabIndex = 5
        Me.lblPerWeek.Text = "Price per Week"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.ForeColor = System.Drawing.Color.Cyan
        Me.lblPrice.Location = New System.Drawing.Point(262, 237)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(25, 13)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "$40"
        Me.lblPrice.Visible = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.ForeColor = System.Drawing.Color.Cyan
        Me.lblInstructions.Location = New System.Drawing.Point(137, 98)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(275, 52)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = "Please Select a costume from the dropdown list." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Once you have decided on a cos" &
    "tume choice, select the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Book the Rental"" button below"
        '
        'lblCostumeRentals
        '
        Me.lblCostumeRentals.AutoSize = True
        Me.lblCostumeRentals.ForeColor = System.Drawing.Color.Cyan
        Me.lblCostumeRentals.Location = New System.Drawing.Point(231, 51)
        Me.lblCostumeRentals.Name = "lblCostumeRentals"
        Me.lblCostumeRentals.Size = New System.Drawing.Size(87, 13)
        Me.lblCostumeRentals.TabIndex = 2
        Me.lblCostumeRentals.Text = "Costume Rentals"
        '
        'picRenaissance
        '
        Me.picRenaissance.Image = CType(resources.GetObject("picRenaissance.Image"), System.Drawing.Image)
        Me.picRenaissance.Location = New System.Drawing.Point(365, 206)
        Me.picRenaissance.Name = "picRenaissance"
        Me.picRenaissance.Size = New System.Drawing.Size(158, 186)
        Me.picRenaissance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRenaissance.TabIndex = 7
        Me.picRenaissance.TabStop = False
        Me.picRenaissance.Visible = False
        '
        'picStorm
        '
        Me.picStorm.Image = CType(resources.GetObject("picStorm.Image"), System.Drawing.Image)
        Me.picStorm.Location = New System.Drawing.Point(365, 206)
        Me.picStorm.Name = "picStorm"
        Me.picStorm.Size = New System.Drawing.Size(158, 186)
        Me.picStorm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStorm.TabIndex = 8
        Me.picStorm.TabStop = False
        Me.picStorm.Visible = False
        '
        'picBatman
        '
        Me.picBatman.BackColor = System.Drawing.Color.DimGray
        Me.picBatman.Image = CType(resources.GetObject("picBatman.Image"), System.Drawing.Image)
        Me.picBatman.Location = New System.Drawing.Point(365, 206)
        Me.picBatman.Name = "picBatman"
        Me.picBatman.Size = New System.Drawing.Size(158, 186)
        Me.picBatman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBatman.TabIndex = 9
        Me.picBatman.TabStop = False
        Me.picBatman.Visible = False
        '
        'picBatgirl
        '
        Me.picBatgirl.BackColor = System.Drawing.Color.DimGray
        Me.picBatgirl.Image = CType(resources.GetObject("picBatgirl.Image"), System.Drawing.Image)
        Me.picBatgirl.Location = New System.Drawing.Point(26, 206)
        Me.picBatgirl.Name = "picBatgirl"
        Me.picBatgirl.Size = New System.Drawing.Size(158, 186)
        Me.picBatgirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBatgirl.TabIndex = 10
        Me.picBatgirl.TabStop = False
        Me.picBatgirl.Visible = False
        '
        'picPirate
        '
        Me.picPirate.Image = CType(resources.GetObject("picPirate.Image"), System.Drawing.Image)
        Me.picPirate.Location = New System.Drawing.Point(365, 206)
        Me.picPirate.Name = "picPirate"
        Me.picPirate.Size = New System.Drawing.Size(158, 186)
        Me.picPirate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPirate.TabIndex = 11
        Me.picPirate.TabStop = False
        Me.picPirate.Visible = False
        '
        'frmCostumePartyRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1177, 602)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCostumePartyRentals"
        Me.Text = "Costume Party Rentals"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picRenaissance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStorm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBatman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBatgirl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPirate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbCostumeSelection As ComboBox
    Friend WithEvents btnBookRental As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCostumeRentals As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblPerWeek As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblExitMessage As Label
    Friend WithEvents picRenaissance As PictureBox
    Friend WithEvents picStorm As PictureBox
    Friend WithEvents picBatman As PictureBox
    Friend WithEvents picBatgirl As PictureBox
    Friend WithEvents picPirate As PictureBox
End Class
