<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Home_AddressLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim AccountIDLabel As System.Windows.Forms.Label
        Me.ButtonAddMember = New System.Windows.Forms.Button()
        Me.TbiCustomersTableAdapter1 = New SL.DatabaseLibraryDataSetTableAdapters.TbiCustomersTableAdapter()
        Me.TableAdapterManager1 = New SL.DatabaseLibraryDataSetTableAdapters.TableAdapterManager()
        Me.DatabaseLibraryDataSet1 = New SL.DatabaseLibraryDataSet()
        Me.DatabaseLibraryDataSet2 = New SL.DatabaseLibraryDataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Home_AddressLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        AccountIDLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseLibraryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseLibraryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 33)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(62, 13)
        IDLabel.TabIndex = 43
        IDLabel.Text = "Member ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(12, 59)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 45
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(12, 85)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 47
        Last_NameLabel.Text = "Last Name:"
        '
        'Home_AddressLabel
        '
        Home_AddressLabel.AutoSize = True
        Home_AddressLabel.Location = New System.Drawing.Point(12, 111)
        Home_AddressLabel.Name = "Home_AddressLabel"
        Home_AddressLabel.Size = New System.Drawing.Size(79, 13)
        Home_AddressLabel.TabIndex = 49
        Home_AddressLabel.Text = "Home Address:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(12, 137)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 51
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(12, 163)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(76, 13)
        Email_AddressLabel.TabIndex = 53
        Email_AddressLabel.Text = "Email Address:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Location = New System.Drawing.Point(12, 190)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(69, 13)
        Date_of_BirthLabel.TabIndex = 55
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'AccountIDLabel
        '
        AccountIDLabel.AutoSize = True
        AccountIDLabel.Location = New System.Drawing.Point(12, 215)
        AccountIDLabel.Name = "AccountIDLabel"
        AccountIDLabel.Size = New System.Drawing.Size(64, 13)
        AccountIDLabel.TabIndex = 57
        AccountIDLabel.Text = "Account ID:"
        '
        'ButtonAddMember
        '
        Me.ButtonAddMember.Location = New System.Drawing.Point(136, 268)
        Me.ButtonAddMember.Name = "ButtonAddMember"
        Me.ButtonAddMember.Size = New System.Drawing.Size(75, 42)
        Me.ButtonAddMember.TabIndex = 59
        Me.ButtonAddMember.Text = "Add new member"
        Me.ButtonAddMember.UseVisualStyleBackColor = True
        '
        'TbiCustomersTableAdapter1
        '
        Me.TbiCustomersTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.TbiBooksTableAdapter = Nothing
        Me.TableAdapterManager1.TbiCustomersAccountTableAdapter = Nothing
        Me.TableAdapterManager1.TbiCustomersTableAdapter = Me.TbiCustomersTableAdapter1
        Me.TableAdapterManager1.TbiDVDsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = SL.DatabaseLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DatabaseLibraryDataSet1
        '
        Me.DatabaseLibraryDataSet1.DataSetName = "DatabaseLibraryDataSet"
        Me.DatabaseLibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseLibraryDataSet2
        '
        Me.DatabaseLibraryDataSet2.DataSetName = "DatabaseLibraryDataSet"
        Me.DatabaseLibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 60
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 61
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(111, 137)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 62
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(111, 111)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 63
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(111, 85)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 64
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(111, 160)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 65
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(111, 215)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 66
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(111, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 67
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 322)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonAddMember)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Home_AddressLabel)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Date_of_BirthLabel)
        Me.Controls.Add(AccountIDLabel)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DatabaseLibraryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseLibraryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAddMember As Button
    Friend WithEvents TbiCustomersTableAdapter1 As DatabaseLibraryDataSetTableAdapters.TbiCustomersTableAdapter
    Friend WithEvents TableAdapterManager1 As DatabaseLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DatabaseLibraryDataSet1 As DatabaseLibraryDataSet
    Friend WithEvents DatabaseLibraryDataSet2 As DatabaseLibraryDataSet
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
