Public Class frmCostumePartyRentals
    Private Sub lblCostumeRentals_Click(sender As Object, e As EventArgs) Handles lblCostumeRentals.Click

    End Sub

    Private Sub cmbCostumeSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCostumeSelection.SelectedIndexChanged

        If cmbCostumeSelection.SelectedItem = "Pirate" Then
            lblPrice.Text = "$29"
            lblPrice.Visible = True
            btnBookRental.Visible = True
            btnBookRental.Enabled = True
            picRenaissance.Visible = False
            picStorm.Visible = False
            picBatman.Visible = False
            picBatgirl.Visible = False
            picPirate.Visible = True

        End If
        If cmbCostumeSelection.SelectedItem = "Renaissance Fair" Then
            lblPrice.Text = "$40"
            lblPrice.Visible = True
            btnBookRental.Visible = True
            btnBookRental.Enabled = True
            picRenaissance.Visible = True
            picStorm.Visible = False
            picBatman.Visible = False
            picBatgirl.Visible = False
            picPirate.Visible = False
        End If
        If cmbCostumeSelection.SelectedItem = "Stormtrooper" Then
            lblPrice.Text = "$49"
            lblPrice.Visible = True
            btnBookRental.Visible = True
            btnBookRental.Enabled = True
            picRenaissance.Visible = False
            picStorm.Visible = True
            picBatman.Visible = False
            picBatgirl.Visible = False
            picPirate.Visible = False
        End If
        If cmbCostumeSelection.SelectedItem = "Batman/Batgirl" Then
            lblPrice.Text = "$36"
            lblPrice.Visible = True
            btnBookRental.Visible = True
            btnBookRental.Enabled = True
            picRenaissance.Visible = False
            picStorm.Visible = False
            picBatman.Visible = True
            picBatgirl.Visible = True
            picPirate.Visible = False
        End If
    End Sub

    Private Sub lblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click

    End Sub

    Private Sub btnBookRental_Click(sender As Object, e As EventArgs) Handles btnBookRental.Click
        lblExitMessage.Visible = True
        btnBookRental.Enabled = False
        Application.DoEvents()
        System.Threading.Thread.Sleep(6000)
        Close()
    End Sub

    Private Sub picRenaissance_Click(sender As Object, e As EventArgs) Handles picRenaissance.Click

    End Sub
End Class
