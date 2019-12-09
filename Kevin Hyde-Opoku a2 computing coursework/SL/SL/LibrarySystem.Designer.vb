<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Home_AddressLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim AccountIDLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim IDLabel2 As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim ReservationsLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Return_DateLabel As System.Windows.Forms.Label
        Dim AvailabilityLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim IDLabel3 As System.Windows.Forms.Label
        Dim DVD_NameLabel As System.Windows.Forms.Label
        Dim DistributorLabel As System.Windows.Forms.Label
        Dim ReservationLabel As System.Windows.Forms.Label
        Dim AvailabilityLabel1 As System.Windows.Forms.Label
        Dim CustomerIDLabel1 As System.Windows.Forms.Label
        Dim Return_dateLabel1 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TbiCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseLibraryDataSet = New SL.DatabaseLibraryDataSet()
        Me.TbiCustomersTableAdapter = New SL.DatabaseLibraryDataSetTableAdapters.TbiCustomersTableAdapter()
        Me.TableAdapterManager = New SL.DatabaseLibraryDataSetTableAdapters.TableAdapterManager()
        Me.TbiBooksTableAdapter = New SL.DatabaseLibraryDataSetTableAdapters.TbiBooksTableAdapter()
        Me.TbiCustomersAccountTableAdapter = New SL.DatabaseLibraryDataSetTableAdapters.TbiCustomersAccountTableAdapter()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Home_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AccountIDTextBox = New System.Windows.Forms.TextBox()
        Me.TbiCustomersAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbiBooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox2 = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationsDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Return_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AvailabilityCheckBox = New System.Windows.Forms.CheckBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TbiDVDsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbiDVDsTableAdapter = New SL.DatabaseLibraryDataSetTableAdapters.TbiDVDsTableAdapter()
        Me.IDTextBox3 = New System.Windows.Forms.TextBox()
        Me.DVD_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DistributorTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AvailabilityCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CustomerIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Return_dateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ButtonAddCustomers = New System.Windows.Forms.Button()
        Me.ButtonAddCustomerAccount = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonSignOut = New System.Windows.Forms.Button()
        Me.ButtonAddBooks = New System.Windows.Forms.Button()
        Me.ButtonAccountDelete = New System.Windows.Forms.Button()
        Me.ButtonDeleteCustomer = New System.Windows.Forms.Button()
        Me.ButtonDeleteBooks = New System.Windows.Forms.Button()
        Me.ButtonDeleteDVDs = New System.Windows.Forms.Button()
        Me.ButtonAddFilms = New System.Windows.Forms.Button()
        Me.ButtonBackground = New System.Windows.Forms.Button()
        Me.ButtonFontColour = New System.Windows.Forms.Button()
        Me.ButtonOpenFile = New System.Windows.Forms.Button()
        Me.ButtonSaveFile = New System.Windows.Forms.Button()
        Me.ColorBackground = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Home_AddressLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        AccountIDLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        IDLabel2 = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        ReservationsLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Return_DateLabel = New System.Windows.Forms.Label()
        AvailabilityLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        IDLabel3 = New System.Windows.Forms.Label()
        DVD_NameLabel = New System.Windows.Forms.Label()
        DistributorLabel = New System.Windows.Forms.Label()
        ReservationLabel = New System.Windows.Forms.Label()
        AvailabilityLabel1 = New System.Windows.Forms.Label()
        CustomerIDLabel1 = New System.Windows.Forms.Label()
        Return_dateLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TbiCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbiCustomersAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbiBooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbiDVDsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(30, 116)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(62, 13)
        IDLabel.TabIndex = 27
        IDLabel.Text = "Member ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(30, 142)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 29
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(30, 168)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 31
        Last_NameLabel.Text = "Last Name:"
        '
        'Home_AddressLabel
        '
        Home_AddressLabel.AutoSize = True
        Home_AddressLabel.Location = New System.Drawing.Point(30, 194)
        Home_AddressLabel.Name = "Home_AddressLabel"
        Home_AddressLabel.Size = New System.Drawing.Size(79, 13)
        Home_AddressLabel.TabIndex = 33
        Home_AddressLabel.Text = "Home Address:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Location = New System.Drawing.Point(30, 220)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel.TabIndex = 35
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Location = New System.Drawing.Point(30, 246)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(76, 13)
        Email_AddressLabel.TabIndex = 37
        Email_AddressLabel.Text = "Email Address:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Location = New System.Drawing.Point(30, 273)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(69, 13)
        Date_of_BirthLabel.TabIndex = 39
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'AccountIDLabel
        '
        AccountIDLabel.AutoSize = True
        AccountIDLabel.Location = New System.Drawing.Point(30, 298)
        AccountIDLabel.Name = "AccountIDLabel"
        AccountIDLabel.Size = New System.Drawing.Size(64, 13)
        AccountIDLabel.TabIndex = 41
        AccountIDLabel.Text = "Account ID:"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(30, 403)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(62, 13)
        IDLabel1.TabIndex = 42
        IDLabel1.Text = "Member ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(30, 429)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 44
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(30, 455)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 46
        PasswordLabel.Text = "Password:"
        '
        'IDLabel2
        '
        IDLabel2.AutoSize = True
        IDLabel2.Location = New System.Drawing.Point(560, 113)
        IDLabel2.Name = "IDLabel2"
        IDLabel2.Size = New System.Drawing.Size(49, 13)
        IDLabel2.TabIndex = 48
        IDLabel2.Text = "Book ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(560, 139)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 50
        TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(560, 165)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 52
        AuthorLabel.Text = "Author:"
        '
        'ReservationsLabel
        '
        ReservationsLabel.AutoSize = True
        ReservationsLabel.Location = New System.Drawing.Point(560, 192)
        ReservationsLabel.Name = "ReservationsLabel"
        ReservationsLabel.Size = New System.Drawing.Size(72, 13)
        ReservationsLabel.TabIndex = 54
        ReservationsLabel.Text = "Reservations:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(560, 217)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 56
        CategoryLabel.Text = "Category:"
        '
        'Return_DateLabel
        '
        Return_DateLabel.AutoSize = True
        Return_DateLabel.Location = New System.Drawing.Point(560, 244)
        Return_DateLabel.Name = "Return_DateLabel"
        Return_DateLabel.Size = New System.Drawing.Size(68, 13)
        Return_DateLabel.TabIndex = 58
        Return_DateLabel.Text = "Return Date:"
        '
        'AvailabilityLabel
        '
        AvailabilityLabel.AutoSize = True
        AvailabilityLabel.Location = New System.Drawing.Point(560, 271)
        AvailabilityLabel.Name = "AvailabilityLabel"
        AvailabilityLabel.Size = New System.Drawing.Size(59, 13)
        AvailabilityLabel.TabIndex = 60
        AvailabilityLabel.Text = "Availability:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(560, 299)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(62, 13)
        CustomerIDLabel.TabIndex = 62
        CustomerIDLabel.Text = "Member ID:"
        '
        'IDLabel3
        '
        IDLabel3.AutoSize = True
        IDLabel3.Location = New System.Drawing.Point(560, 348)
        IDLabel3.Name = "IDLabel3"
        IDLabel3.Size = New System.Drawing.Size(42, 13)
        IDLabel3.TabIndex = 66
        IDLabel3.Text = "Film ID:"
        '
        'DVD_NameLabel
        '
        DVD_NameLabel.AutoSize = True
        DVD_NameLabel.Location = New System.Drawing.Point(560, 374)
        DVD_NameLabel.Name = "DVD_NameLabel"
        DVD_NameLabel.Size = New System.Drawing.Size(64, 13)
        DVD_NameLabel.TabIndex = 68
        DVD_NameLabel.Text = "DVD Name:"
        '
        'DistributorLabel
        '
        DistributorLabel.AutoSize = True
        DistributorLabel.Location = New System.Drawing.Point(560, 400)
        DistributorLabel.Name = "DistributorLabel"
        DistributorLabel.Size = New System.Drawing.Size(57, 13)
        DistributorLabel.TabIndex = 70
        DistributorLabel.Text = "Distributor:"
        '
        'ReservationLabel
        '
        ReservationLabel.AutoSize = True
        ReservationLabel.Location = New System.Drawing.Point(560, 427)
        ReservationLabel.Name = "ReservationLabel"
        ReservationLabel.Size = New System.Drawing.Size(67, 13)
        ReservationLabel.TabIndex = 72
        ReservationLabel.Text = "Reservation:"
        '
        'AvailabilityLabel1
        '
        AvailabilityLabel1.AutoSize = True
        AvailabilityLabel1.Location = New System.Drawing.Point(560, 454)
        AvailabilityLabel1.Name = "AvailabilityLabel1"
        AvailabilityLabel1.Size = New System.Drawing.Size(59, 13)
        AvailabilityLabel1.TabIndex = 74
        AvailabilityLabel1.Text = "Availability:"
        '
        'CustomerIDLabel1
        '
        CustomerIDLabel1.AutoSize = True
        CustomerIDLabel1.Location = New System.Drawing.Point(560, 482)
        CustomerIDLabel1.Name = "CustomerIDLabel1"
        CustomerIDLabel1.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel1.TabIndex = 76
        CustomerIDLabel1.Text = "Customer ID:"
        '
        'Return_dateLabel1
        '
        Return_dateLabel1.AutoSize = True
        Return_dateLabel1.Location = New System.Drawing.Point(560, 509)
        Return_dateLabel1.Name = "Return_dateLabel1"
        Return_dateLabel1.Size = New System.Drawing.Size(66, 13)
        Return_dateLabel1.TabIndex = 78
        Return_dateLabel1.Text = "Return date:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(999, 54)
        Me.Panel1.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(332, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 24)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Library system"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(75, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Members' information"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TbiCustomersBindingSource
        Me.ComboBox1.DisplayMember = "First Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(357, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'TbiCustomersBindingSource
        '
        Me.TbiCustomersBindingSource.DataMember = "TbiCustomers"
        Me.TbiCustomersBindingSource.DataSource = Me.DatabaseLibraryDataSet
        '
        'DatabaseLibraryDataSet
        '
        Me.DatabaseLibraryDataSet.DataSetName = "DatabaseLibraryDataSet"
        Me.DatabaseLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbiCustomersTableAdapter
        '
        Me.TbiCustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TbiBooksTableAdapter = Me.TbiBooksTableAdapter
        Me.TableAdapterManager.TbiCustomersAccountTableAdapter = Me.TbiCustomersAccountTableAdapter
        Me.TableAdapterManager.TbiCustomersTableAdapter = Me.TbiCustomersTableAdapter
        Me.TableAdapterManager.TbiDVDsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SL.DatabaseLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbiBooksTableAdapter
        '
        Me.TbiBooksTableAdapter.ClearBeforeFill = True
        '
        'TbiCustomersAccountTableAdapter
        '
        Me.TbiCustomersAccountTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(117, 113)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 28
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersBindingSource, "First Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(117, 139)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.First_NameTextBox.TabIndex = 30
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(117, 165)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_NameTextBox.TabIndex = 32
        '
        'Home_AddressTextBox
        '
        Me.Home_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersBindingSource, "Home Address", True))
        Me.Home_AddressTextBox.Location = New System.Drawing.Point(117, 191)
        Me.Home_AddressTextBox.Name = "Home_AddressTextBox"
        Me.Home_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Home_AddressTextBox.TabIndex = 34
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersBindingSource, "Phone Number", True))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(117, 217)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Phone_NumberTextBox.TabIndex = 36
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersBindingSource, "Email Address", True))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(117, 243)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Email_AddressTextBox.TabIndex = 38
        '
        'Date_of_BirthDateTimePicker
        '
        Me.Date_of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbiCustomersBindingSource, "Date of Birth", True))
        Me.Date_of_BirthDateTimePicker.Location = New System.Drawing.Point(117, 269)
        Me.Date_of_BirthDateTimePicker.Name = "Date_of_BirthDateTimePicker"
        Me.Date_of_BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_BirthDateTimePicker.TabIndex = 40
        '
        'AccountIDTextBox
        '
        Me.AccountIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersBindingSource, "AccountID", True))
        Me.AccountIDTextBox.Location = New System.Drawing.Point(117, 295)
        Me.AccountIDTextBox.Name = "AccountIDTextBox"
        Me.AccountIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AccountIDTextBox.TabIndex = 42
        '
        'TbiCustomersAccountBindingSource
        '
        Me.TbiCustomersAccountBindingSource.DataMember = "TbiCustomersAccount"
        Me.TbiCustomersAccountBindingSource.DataSource = Me.DatabaseLibraryDataSet
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersAccountBindingSource, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(94, 400)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox1.TabIndex = 43
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersAccountBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(94, 426)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 45
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiCustomersAccountBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(94, 452)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 18)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Members' account information"
        '
        'TbiBooksBindingSource
        '
        Me.TbiBooksBindingSource.DataMember = "TbiBooks"
        Me.TbiBooksBindingSource.DataSource = Me.DatabaseLibraryDataSet
        '
        'IDTextBox2
        '
        Me.IDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiBooksBindingSource, "ID", True))
        Me.IDTextBox2.Location = New System.Drawing.Point(638, 110)
        Me.IDTextBox2.Name = "IDTextBox2"
        Me.IDTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox2.TabIndex = 49
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiBooksBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(638, 136)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TitleTextBox.TabIndex = 51
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiBooksBindingSource, "Author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(638, 162)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AuthorTextBox.TabIndex = 53
        '
        'ReservationsDateTimePicker
        '
        Me.ReservationsDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbiBooksBindingSource, "Reservations", True))
        Me.ReservationsDateTimePicker.Location = New System.Drawing.Point(638, 188)
        Me.ReservationsDateTimePicker.Name = "ReservationsDateTimePicker"
        Me.ReservationsDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ReservationsDateTimePicker.TabIndex = 55
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiBooksBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(638, 214)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CategoryTextBox.TabIndex = 57
        '
        'Return_DateDateTimePicker
        '
        Me.Return_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbiBooksBindingSource, "Return Date", True))
        Me.Return_DateDateTimePicker.Location = New System.Drawing.Point(638, 240)
        Me.Return_DateDateTimePicker.Name = "Return_DateDateTimePicker"
        Me.Return_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Return_DateDateTimePicker.TabIndex = 59
        '
        'AvailabilityCheckBox
        '
        Me.AvailabilityCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbiBooksBindingSource, "Availability", True))
        Me.AvailabilityCheckBox.Location = New System.Drawing.Point(638, 266)
        Me.AvailabilityCheckBox.Name = "AvailabilityCheckBox"
        Me.AvailabilityCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.AvailabilityCheckBox.TabIndex = 61
        Me.AvailabilityCheckBox.UseVisualStyleBackColor = True
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiBooksBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(638, 296)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(617, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Book information"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.TbiBooksBindingSource
        Me.ComboBox2.DisplayMember = "Title"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(859, 109)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 65
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.TbiCustomersAccountBindingSource
        Me.ComboBox3.DisplayMember = "Username"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(231, 399)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 66
        '
        'TbiDVDsBindingSource
        '
        Me.TbiDVDsBindingSource.DataMember = "TbiDVDs"
        Me.TbiDVDsBindingSource.DataSource = Me.DatabaseLibraryDataSet
        '
        'TbiDVDsTableAdapter
        '
        Me.TbiDVDsTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox3
        '
        Me.IDTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiDVDsBindingSource, "ID", True))
        Me.IDTextBox3.Location = New System.Drawing.Point(634, 345)
        Me.IDTextBox3.Name = "IDTextBox3"
        Me.IDTextBox3.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox3.TabIndex = 67
        '
        'DVD_NameTextBox
        '
        Me.DVD_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiDVDsBindingSource, "DVD Name", True))
        Me.DVD_NameTextBox.Location = New System.Drawing.Point(634, 371)
        Me.DVD_NameTextBox.Name = "DVD_NameTextBox"
        Me.DVD_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DVD_NameTextBox.TabIndex = 69
        '
        'DistributorTextBox
        '
        Me.DistributorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiDVDsBindingSource, "Distributor", True))
        Me.DistributorTextBox.Location = New System.Drawing.Point(634, 397)
        Me.DistributorTextBox.Name = "DistributorTextBox"
        Me.DistributorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DistributorTextBox.TabIndex = 71
        '
        'ReservationDateTimePicker
        '
        Me.ReservationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbiDVDsBindingSource, "Reservation", True))
        Me.ReservationDateTimePicker.Location = New System.Drawing.Point(634, 423)
        Me.ReservationDateTimePicker.Name = "ReservationDateTimePicker"
        Me.ReservationDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ReservationDateTimePicker.TabIndex = 73
        '
        'AvailabilityCheckBox1
        '
        Me.AvailabilityCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TbiDVDsBindingSource, "Availability", True))
        Me.AvailabilityCheckBox1.Location = New System.Drawing.Point(634, 449)
        Me.AvailabilityCheckBox1.Name = "AvailabilityCheckBox1"
        Me.AvailabilityCheckBox1.Size = New System.Drawing.Size(200, 24)
        Me.AvailabilityCheckBox1.TabIndex = 75
        Me.AvailabilityCheckBox1.UseVisualStyleBackColor = True
        '
        'CustomerIDTextBox1
        '
        Me.CustomerIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbiDVDsBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox1.Location = New System.Drawing.Point(634, 479)
        Me.CustomerIDTextBox1.Name = "CustomerIDTextBox1"
        Me.CustomerIDTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox1.TabIndex = 77
        '
        'Return_dateDateTimePicker1
        '
        Me.Return_dateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbiDVDsBindingSource, "Return date", True))
        Me.Return_dateDateTimePicker1.Location = New System.Drawing.Point(634, 505)
        Me.Return_dateDateTimePicker1.Name = "Return_dateDateTimePicker1"
        Me.Return_dateDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.Return_dateDateTimePicker1.TabIndex = 79
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.TbiDVDsBindingSource
        Me.ComboBox4.DisplayMember = "DVD Name"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(878, 344)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 80
        '
        'ButtonAddCustomers
        '
        Me.ButtonAddCustomers.Location = New System.Drawing.Point(371, 168)
        Me.ButtonAddCustomers.Name = "ButtonAddCustomers"
        Me.ButtonAddCustomers.Size = New System.Drawing.Size(75, 37)
        Me.ButtonAddCustomers.TabIndex = 81
        Me.ButtonAddCustomers.Text = "Add new members"
        Me.ButtonAddCustomers.UseVisualStyleBackColor = True
        '
        'ButtonAddCustomerAccount
        '
        Me.ButtonAddCustomerAccount.Location = New System.Drawing.Point(242, 444)
        Me.ButtonAddCustomerAccount.Name = "ButtonAddCustomerAccount"
        Me.ButtonAddCustomerAccount.Size = New System.Drawing.Size(132, 23)
        Me.ButtonAddCustomerAccount.TabIndex = 82
        Me.ButtonAddCustomerAccount.Text = "Add customer account"
        Me.ButtonAddCustomerAccount.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(11, 595)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 26)
        Me.ButtonSave.TabIndex = 83
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonSignOut
        '
        Me.ButtonSignOut.Location = New System.Drawing.Point(119, 595)
        Me.ButtonSignOut.Name = "ButtonSignOut"
        Me.ButtonSignOut.Size = New System.Drawing.Size(75, 26)
        Me.ButtonSignOut.TabIndex = 84
        Me.ButtonSignOut.Text = "Sign Out"
        Me.ButtonSignOut.UseVisualStyleBackColor = True
        '
        'ButtonAddBooks
        '
        Me.ButtonAddBooks.Location = New System.Drawing.Point(878, 162)
        Me.ButtonAddBooks.Name = "ButtonAddBooks"
        Me.ButtonAddBooks.Size = New System.Drawing.Size(75, 37)
        Me.ButtonAddBooks.TabIndex = 85
        Me.ButtonAddBooks.Text = "Add new books"
        Me.ButtonAddBooks.UseVisualStyleBackColor = True
        '
        'ButtonAccountDelete
        '
        Me.ButtonAccountDelete.Location = New System.Drawing.Point(242, 477)
        Me.ButtonAccountDelete.Name = "ButtonAccountDelete"
        Me.ButtonAccountDelete.Size = New System.Drawing.Size(132, 45)
        Me.ButtonAccountDelete.TabIndex = 86
        Me.ButtonAccountDelete.Text = "Delete customer account"
        Me.ButtonAccountDelete.UseVisualStyleBackColor = True
        '
        'ButtonDeleteCustomer
        '
        Me.ButtonDeleteCustomer.Location = New System.Drawing.Point(371, 234)
        Me.ButtonDeleteCustomer.Name = "ButtonDeleteCustomer"
        Me.ButtonDeleteCustomer.Size = New System.Drawing.Size(75, 37)
        Me.ButtonDeleteCustomer.TabIndex = 87
        Me.ButtonDeleteCustomer.Text = "Delete members"
        Me.ButtonDeleteCustomer.UseVisualStyleBackColor = True
        '
        'ButtonDeleteBooks
        '
        Me.ButtonDeleteBooks.Location = New System.Drawing.Point(878, 223)
        Me.ButtonDeleteBooks.Name = "ButtonDeleteBooks"
        Me.ButtonDeleteBooks.Size = New System.Drawing.Size(75, 37)
        Me.ButtonDeleteBooks.TabIndex = 88
        Me.ButtonDeleteBooks.Text = "Delete books"
        Me.ButtonDeleteBooks.UseVisualStyleBackColor = True
        '
        'ButtonDeleteDVDs
        '
        Me.ButtonDeleteDVDs.Location = New System.Drawing.Point(878, 449)
        Me.ButtonDeleteDVDs.Name = "ButtonDeleteDVDs"
        Me.ButtonDeleteDVDs.Size = New System.Drawing.Size(75, 37)
        Me.ButtonDeleteDVDs.TabIndex = 89
        Me.ButtonDeleteDVDs.Text = "Delete films"
        Me.ButtonDeleteDVDs.UseVisualStyleBackColor = True
        '
        'ButtonAddFilms
        '
        Me.ButtonAddFilms.Location = New System.Drawing.Point(878, 388)
        Me.ButtonAddFilms.Name = "ButtonAddFilms"
        Me.ButtonAddFilms.Size = New System.Drawing.Size(75, 37)
        Me.ButtonAddFilms.TabIndex = 90
        Me.ButtonAddFilms.Text = "Add new films"
        Me.ButtonAddFilms.UseVisualStyleBackColor = True
        '
        'ButtonBackground
        '
        Me.ButtonBackground.Location = New System.Drawing.Point(214, 583)
        Me.ButtonBackground.Name = "ButtonBackground"
        Me.ButtonBackground.Size = New System.Drawing.Size(75, 38)
        Me.ButtonBackground.TabIndex = 91
        Me.ButtonBackground.Text = "Background colour"
        Me.ButtonBackground.UseVisualStyleBackColor = True
        '
        'ButtonFontColour
        '
        Me.ButtonFontColour.Location = New System.Drawing.Point(313, 583)
        Me.ButtonFontColour.Name = "ButtonFontColour"
        Me.ButtonFontColour.Size = New System.Drawing.Size(75, 38)
        Me.ButtonFontColour.TabIndex = 92
        Me.ButtonFontColour.Text = "Font colour"
        Me.ButtonFontColour.UseVisualStyleBackColor = True
        '
        'ButtonOpenFile
        '
        Me.ButtonOpenFile.Location = New System.Drawing.Point(526, 583)
        Me.ButtonOpenFile.Name = "ButtonOpenFile"
        Me.ButtonOpenFile.Size = New System.Drawing.Size(75, 38)
        Me.ButtonOpenFile.TabIndex = 93
        Me.ButtonOpenFile.Text = "Open into file"
        Me.ButtonOpenFile.UseVisualStyleBackColor = True
        '
        'ButtonSaveFile
        '
        Me.ButtonSaveFile.Location = New System.Drawing.Point(423, 583)
        Me.ButtonSaveFile.Name = "ButtonSaveFile"
        Me.ButtonSaveFile.Size = New System.Drawing.Size(75, 38)
        Me.ButtonSaveFile.TabIndex = 94
        Me.ButtonSaveFile.Text = "Save into a file"
        Me.ButtonSaveFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(356, 60)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 95
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(477, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Clock"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 624)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ButtonSaveFile)
        Me.Controls.Add(Me.ButtonOpenFile)
        Me.Controls.Add(Me.ButtonFontColour)
        Me.Controls.Add(Me.ButtonBackground)
        Me.Controls.Add(Me.ButtonAddFilms)
        Me.Controls.Add(Me.ButtonDeleteDVDs)
        Me.Controls.Add(Me.ButtonDeleteBooks)
        Me.Controls.Add(Me.ButtonDeleteCustomer)
        Me.Controls.Add(Me.ButtonAccountDelete)
        Me.Controls.Add(Me.ButtonAddBooks)
        Me.Controls.Add(Me.ButtonSignOut)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonAddCustomerAccount)
        Me.Controls.Add(Me.ButtonAddCustomers)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(IDLabel3)
        Me.Controls.Add(Me.IDTextBox3)
        Me.Controls.Add(DVD_NameLabel)
        Me.Controls.Add(Me.DVD_NameTextBox)
        Me.Controls.Add(DistributorLabel)
        Me.Controls.Add(Me.DistributorTextBox)
        Me.Controls.Add(ReservationLabel)
        Me.Controls.Add(Me.ReservationDateTimePicker)
        Me.Controls.Add(AvailabilityLabel1)
        Me.Controls.Add(Me.AvailabilityCheckBox1)
        Me.Controls.Add(CustomerIDLabel1)
        Me.Controls.Add(Me.CustomerIDTextBox1)
        Me.Controls.Add(Return_dateLabel1)
        Me.Controls.Add(Me.Return_dateDateTimePicker1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(IDLabel2)
        Me.Controls.Add(Me.IDTextBox2)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(ReservationsLabel)
        Me.Controls.Add(Me.ReservationsDateTimePicker)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Return_DateLabel)
        Me.Controls.Add(Me.Return_DateDateTimePicker)
        Me.Controls.Add(AvailabilityLabel)
        Me.Controls.Add(Me.AvailabilityCheckBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IDLabel1)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Home_AddressLabel)
        Me.Controls.Add(Me.Home_AddressTextBox)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Email_AddressLabel)
        Me.Controls.Add(Me.Email_AddressTextBox)
        Me.Controls.Add(Date_of_BirthLabel)
        Me.Controls.Add(Me.Date_of_BirthDateTimePicker)
        Me.Controls.Add(AccountIDLabel)
        Me.Controls.Add(Me.AccountIDTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TbiCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbiCustomersAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbiBooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbiDVDsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DatabaseLibraryDataSet As DatabaseLibraryDataSet
    Friend WithEvents TbiCustomersBindingSource As BindingSource
    Friend WithEvents TbiCustomersTableAdapter As DatabaseLibraryDataSetTableAdapters.TbiCustomersTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Home_AddressTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Email_AddressTextBox As TextBox
    Friend WithEvents Date_of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents AccountIDTextBox As TextBox
    Friend WithEvents TbiCustomersAccountTableAdapter As DatabaseLibraryDataSetTableAdapters.TbiCustomersAccountTableAdapter
    Friend WithEvents TbiCustomersAccountBindingSource As BindingSource
    Friend WithEvents TbiBooksTableAdapter As DatabaseLibraryDataSetTableAdapters.TbiBooksTableAdapter
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbiBooksBindingSource As BindingSource
    Friend WithEvents IDTextBox2 As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents ReservationsDateTimePicker As DateTimePicker
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents Return_DateDateTimePicker As DateTimePicker
    Friend WithEvents AvailabilityCheckBox As CheckBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TbiDVDsBindingSource As BindingSource
    Friend WithEvents TbiDVDsTableAdapter As DatabaseLibraryDataSetTableAdapters.TbiDVDsTableAdapter
    Friend WithEvents IDTextBox3 As TextBox
    Friend WithEvents DVD_NameTextBox As TextBox
    Friend WithEvents DistributorTextBox As TextBox
    Friend WithEvents ReservationDateTimePicker As DateTimePicker
    Friend WithEvents AvailabilityCheckBox1 As CheckBox
    Friend WithEvents CustomerIDTextBox1 As TextBox
    Friend WithEvents Return_dateDateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ButtonAddCustomers As Button
    Friend WithEvents ButtonAddCustomerAccount As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonSignOut As Button
    Friend WithEvents ButtonAddBooks As Button
    Friend WithEvents ButtonAccountDelete As Button
    Friend WithEvents ButtonDeleteCustomer As Button
    Friend WithEvents ButtonDeleteBooks As Button
    Friend WithEvents ButtonDeleteDVDs As Button
    Friend WithEvents ButtonAddFilms As Button
    Friend WithEvents ButtonBackground As Button
    Friend WithEvents ButtonFontColour As Button
    Friend WithEvents ButtonOpenFile As Button
    Friend WithEvents ButtonSaveFile As Button
    Friend WithEvents ColorBackground As ColorDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
End Class
