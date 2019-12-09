Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.TbiCustomersAccountTableAdapter.Insert(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text)
        Form1.TbiCustomersAccountTableAdapter.Fill(Form1.DatabaseLibraryDataSet.TbiCustomersAccount)
        MsgBox("record added successfully")
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Form1.Show()
    End Sub
End Class