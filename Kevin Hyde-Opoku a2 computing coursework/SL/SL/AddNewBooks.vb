Public Class Form5
    Private Sub AddNewBooks_Click(sender As Object, e As EventArgs) Handles AddNewBooks.Click
        Form1.TbiBooksTableAdapter.Insert(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text, Me.DateTimePicker1.Text, Me.TextBox4.Text, Me.DateTimePicker2.Text, Me.CheckBox1.Checked.ToString, TextBox5.Text)
        Form1.TbiBooksTableAdapter.Fill(Form1.DatabaseLibraryDataSet.TbiBooks)
        MsgBox("record added succesfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        CheckBox1.Checked = False
        Form1.Show()
    End Sub
End Class