Public Class Form3
    Private Sub ButtonAddMember_Click(sender As Object, e As EventArgs) Handles ButtonAddMember.Click
        Form1.TbiCustomersTableAdapter.Insert(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text, Me.TextBox4.Text, Me.TextBox5.Text, Me.TextBox6.Text, Me.DateTimePicker1.Text, Me.TextBox7.Text)
        Form1.TbiCustomersTableAdapter.Fill(Form1.DatabaseLibraryDataSet.TbiCustomers)
        MsgBox("record added successfully")
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Form1.Show()
    End Sub
End Class