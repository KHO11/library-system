Imports System.IO
Public Class Form1
    Private Sub TbiCustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TbiCustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseLibraryDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseLibraryDataSet.TbiDVDs' table. You can move, or remove it, as needed.
        Me.TbiDVDsTableAdapter.Fill(Me.DatabaseLibraryDataSet.TbiDVDs)
        'TODO: This line of code loads data into the 'DatabaseLibraryDataSet.TbiBooks' table. You can move, or remove it, as needed.
        Me.TbiBooksTableAdapter.Fill(Me.DatabaseLibraryDataSet.TbiBooks)
        'TODO: This line of code loads data into the 'DatabaseLibraryDataSet.TbiCustomersAccount' table. You can move, or remove it, as needed.
        Me.TbiCustomersAccountTableAdapter.Fill(Me.DatabaseLibraryDataSet.TbiCustomersAccount)
        'TODO: This line of code loads data into the 'DatabaseLibraryDataSet.TbiCustomers' table. You can move, or remove it, as needed.
        Me.TbiCustomersTableAdapter.Fill(Me.DatabaseLibraryDataSet.TbiCustomers)

    End Sub

    Private Sub ButtonAddCustomers_Click(sender As Object, e As EventArgs) Handles ButtonAddCustomers.Click
        Form3.Show()
        Me.Hide()
        '  ButtonAddCustomerAccount.PerformClick()
        ' With Me.ComboBox1.Items
        '  .Add("")
        ' .Add("")
        '.Add("")
        '    .Add("")
        '   .Add("")
        '  .Add("")
        '  .Add("")
        '  .Add("")
        '  .Add("")
        '  .Add("")
        'the user can't add more than ten new customer accounts
        '  End With
    End Sub
    Private Sub ButtonAddCustomerAccount_Click(sender As Object, e As EventArgs) Handles ButtonAddCustomerAccount.Click
        Form4.Show()
        Me.Hide()
        'With Me.ComboBox2.Items
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        'the user can't add more than ten new customer accounts
        'End With
    End Sub

    Private Sub ButtonAddFilms_Click(sender As Object, e As EventArgs) Handles ButtonAddFilms.Click
        Form6.Show()
        Me.Hide()
        'ButtonAddFilms.PerformClick()
        'With Me.ComboBox3.Items
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        'the user can't add more than ten new films
        'End With

    End Sub
    Private Sub ButtonAddBooks_Click(sender As Object, e As EventArgs) Handles ButtonAddBooks.Click
        Form5.Show()
        Me.Hide()
        'ButtonAddBooks.PerformClick()
        'With Me.ComboBox4.Items
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        '.Add("")
        'the user can't add ten new books
        'End With
    End Sub
    Private Function ShouldSerializeTbiDVDs() As Boolean
        Return False
    End Function
    Private Function ShouldSerializeTbiBooks() As Boolean
        Return False
    End Function
    Private Function ShouldSerializeTbiCustomers() As Boolean
        Return False
    End Function
    Private Function ShouldSerializeTbiCustomersAccount() As Boolean
        Return False
    End Function
    'checking to see if the data should be changed
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Me.Validate()
        Me.TbiCustomersBindingSource.EndEdit()
        Me.TbiCustomersAccountBindingSource.EndEdit()
        Me.TbiDVDsBindingSource.EndEdit()
        Me.TbiBooksBindingSource.EndEdit()
        Me.TbiCustomersTableAdapter.Update(Me.DatabaseLibraryDataSet)
        Me.TbiBooksTableAdapter.Update(Me.DatabaseLibraryDataSet)
        Me.TbiDVDsTableAdapter.Update(Me.DatabaseLibraryDataSet)
        Me.TbiCustomersAccountTableAdapter.Update(Me.DatabaseLibraryDataSet)
        MsgBox("data saved")
    End Sub

    Private Sub ButtonDeleteCustomer_Click(sender As Object, e As EventArgs) Handles ButtonDeleteCustomer.Click
        If MsgBox("Do you want the delete the selected user", MsgBoxStyle.YesNo, "CONFIRM DELETE") = MsgBoxResult.No Then Exit Sub
        Me.IDTextBox.Text = ""
        Me.First_NameTextBox.Text = ""
        Me.Last_NameTextBox.Text = ""
        Me.Home_AddressTextBox.Text = ""
        Me.Phone_NumberTextBox.Text = ""
        Me.Email_AddressTextBox.Text = ""
        Me.AccountIDTextBox.Text = ""
        Me.IDTextBox.Focus()
        Me.ComboBox1.Text = ""
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        ComboBox3.Visible = True
        ComboBox4.Visible = True
        'the user has a choice to delete a member
    End Sub

    Private Sub ButtonAccountDelete_Click(sender As Object, e As EventArgs) Handles ButtonAccountDelete.Click
        If MsgBox("Do you want the delete the selected user account", MsgBoxStyle.YesNo, "CONFIRM DELETE") = MsgBoxResult.No Then Exit Sub
        Me.IDTextBox2.Text = ""
        Me.UsernameTextBox.Text = ""
        Me.PasswordTextBox.Text = ""
        Me.IDTextBox2.Focus()
        Me.ComboBox3.Text = ""
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        ComboBox3.Visible = True
        ComboBox4.Visible = True
    End Sub

    Private Sub ButtonDeleteDVDs_Click(sender As Object, e As EventArgs) Handles ButtonDeleteDVDs.Click
        Me.IDTextBox3.Text = ""
        Me.DVD_NameTextBox.Text = ""
        Me.DistributorTextBox.Text = ""
        Me.CustomerIDTextBox1.Text = ""
        Me.ComboBox4.Text = ""
    End Sub

    Private Sub ButtonDeleteBooks_Click(sender As Object, e As EventArgs) Handles ButtonDeleteBooks.Click
        Me.IDTextBox1.Text = ""
        Me.TitleTextBox.Text = ""
        Me.AuthorTextBox.Text = ""
        Me.CategoryTextBox.Text = ""
        Me.CustomerIDTextBox.Text = ""
        Me.ComboBox2.Text = ""
    End Sub


    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click
        MsgBox("do you want to log out")
        If MsgBoxResult.Yes Then
            Me.Close()
            'if the user chooses not to log out form 1 will still be open
            ' the user has a choice whenever he/she finishes using it
        End If
    End Sub

    Private Sub ButtonBackground_Click(sender As Object, e As EventArgs) Handles ButtonBackground.Click
        If ColorBackground.ShowDialog = DialogResult.OK Then
            Me.BackColor = ColorBackground.Color
            'The user has a choice to choose any background colour he prefers
            ' Different range of colours
        End If
    End Sub

    Private Sub ButtonFontColour_Click(sender As Object, e As EventArgs) Handles ButtonFontColour.Click
        If ColorBackground.ShowDialog = DialogResult.OK Then
            IDTextBox.ForeColor = ColorBackground.Color
            First_NameTextBox.ForeColor = ColorBackground.Color
            Last_NameTextBox.ForeColor = ColorBackground.Color
            Home_AddressTextBox.ForeColor = ColorBackground.Color
            Phone_NumberTextBox.ForeColor = ColorBackground.Color
            Email_AddressTextBox.ForeColor = ColorBackground.Color
            Date_of_BirthDateTimePicker.ForeColor = ColorBackground.Color
            AccountIDTextBox.ForeColor = ColorBackground.Color
            ComboBox1.ForeColor = ColorBackground.Color
            'changing the font colour for the customers' details section

            IDTextBox1.ForeColor = ColorBackground.Color
            TitleTextBox.ForeColor = ColorBackground.Color
            AuthorTextBox.ForeColor = ColorBackground.Color
            ReservationsDateTimePicker.ForeColor = ColorBackground.Color
            CategoryTextBox.ForeColor = ColorBackground.Color
            Return_DateDateTimePicker.ForeColor = ColorBackground.Color
            CustomerIDTextBox.ForeColor = ColorBackground.Color
            ComboBox2.ForeColor = ColorBackground.Color
            'changing the font colour for the books' details section

            IDTextBox2.ForeColor = ColorBackground.Color
            UsernameTextBox.ForeColor = ColorBackground.Color
            PasswordTextBox.ForeColor = ColorBackground.Color
            ComboBox3.ForeColor = ColorBackground.Color
            'changing the font colour for the customers' account section

            IDTextBox3.ForeColor = ColorBackground.Color
            DVD_NameTextBox.ForeColor = ColorBackground.Color
            DistributorTextBox.ForeColor = ColorBackground.Color
            ReservationDateTimePicker.ForeColor = ColorBackground.Color
            CustomerIDTextBox1.ForeColor = ColorBackground.Color
            Return_dateDateTimePicker1.ForeColor = ColorBackground.Color
            ComboBox4.ForeColor = ColorBackground.Color
            'changing the font colour for the film details' section
        End If
    End Sub
    Private Sub ButtonSaveFile_Click(sender As Object, e As EventArgs) Handles ButtonSaveFile.Click
        Dim FileWriter As StreamWriter
        Dim results As DialogResult
        results = SaveFileDialog1.ShowDialog
        If results = DialogResult.OK Then
            FileWriter = New StreamWriter(SaveFileDialog1.FileName, False)
            'FileWriter.WriteLine("stuff")
            FileWriter.Close()
        End If
    End Sub

    Private Sub ButtonOpenFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click
        Dim FileReader As StreamReader
        Dim results As DialogResult
        results = OpenFileDialog1.ShowDialog
        If results = DialogResult.OK Then
            FileReader = New StreamReader(OpenFileDialog1.FileName)
            FileReader.Close()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
        'the time that takes place today
    End Sub
End Class

