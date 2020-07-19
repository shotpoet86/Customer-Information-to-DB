Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TxtFirst_TextChanged(sender As Object, e As EventArgs) Handles TxtFirst.TextChanged, txtAddress.TextAlignChanged, txtCity.TextAlignChanged, txtLast.TextAlignChanged, txtZip.TextChanged
        lblMessage.Visible = False
    End Sub

    Private Sub TxtLast_TextChanged(sender As Object, e As EventArgs) Handles txtLast.TextChanged

    End Sub

    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub TxtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub TxtZip_TextChanged(sender As Object, e As EventArgs) Handles txtZip.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Error messages for invalid input
        If txtAddress.Text = "" Then
            MessageBox.Show("Address can't be blank!")
            txtAddress.Focus()
            Return
        End If
        If txtCity.Text = "" Then
            MessageBox.Show("City can't be blank!")
            txtCity.Focus()
            Return
        End If
        If TxtFirst.Text = "" Then
            MessageBox.Show("First name can't be blank!")
            TxtFirst.Focus()
            Return
        End If
        If txtLast.Text = "" Then
            MessageBox.Show("Last name can't be blank!")
            txtLast.Focus()
            Return
        End If
        If txtZip.Text = "" Then
            MessageBox.Show("Zip can't blank!")
            txtZip.Focus()
            Return
        End If 

        'Output format to txt. file
        Dim fname, lname, add, city, zip, str As String
        fname = TxtFirst.Text
        lname = txtLast.Text
        add = txtAddress.Text
        city = txtCity.Text
        zip = txtZip.Text

        'Output to txt. file
        Dim objWriter As New IO.StreamWriter("customers.txt", True)
        str = fname & " " & lname & vbNewLine & add & ", " & city & ", " & zip & vbNewLine
        objWriter.WriteLine(str)
        lblMessage.Visible = True
        objWriter.Close()
    End Sub

    Private Sub FileToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes application
        Me.Close()
    End Sub
End Class
