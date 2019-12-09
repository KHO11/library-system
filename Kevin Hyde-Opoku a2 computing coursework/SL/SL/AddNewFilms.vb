Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.TbiDVDsTableAdapter.Insert(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text, Me.DateTimePicker1.Text, Me.CheckBox1.Text, Me.TextBox6.Text, Me.DateTimePicker2.Text)
        Form1.TbiDVDsTableAdapter.Fill(Form1.DatabaseLibraryDataSet.TbiDVDs)
        MsgBox("record added successfully")
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.CheckBox1.Checked = False
        Me.TextBox6.Text = ""
        Form1.Show()
    End Sub
End Class