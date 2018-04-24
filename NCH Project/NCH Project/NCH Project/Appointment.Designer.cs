namespace NCH_Project
{
    partial class frmApptInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label appointment_NumberLabel;
            System.Windows.Forms.Label date_TImeLabel;
            System.Windows.Forms.Label appointment_TimeLabel1;
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMInitial = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.patientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEdietHouseholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accoubntReceivableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mTDPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postcardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtHouseID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.appointmentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointment_DataTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter1 = new NCH_Project.SystemsDataBase2DataSetTableAdapters.ProvidersTableAdapter();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter();
            this.appointment_DataTableAdapter1 = new NCH_Project.SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter();
            this.appointment_DataTableAdapter2 = new NCH_Project.SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter();
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.appointment_NumberTextBox = new System.Windows.Forms.TextBox();
            this.date_TImeTextBox = new System.Windows.Forms.TextBox();
            this.appointment_TimeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            appointment_NumberLabel = new System.Windows.Forms.Label();
            date_TImeLabel = new System.Windows.Forms.Label();
            appointment_TimeLabel1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointment_NumberLabel
            // 
            appointment_NumberLabel.AutoSize = true;
            appointment_NumberLabel.Location = new System.Drawing.Point(292, 41);
            appointment_NumberLabel.Name = "appointment_NumberLabel";
            appointment_NumberLabel.Size = new System.Drawing.Size(145, 17);
            appointment_NumberLabel.TabIndex = 68;
            appointment_NumberLabel.Text = "Appointment Number:";
            // 
            // date_TImeLabel
            // 
            date_TImeLabel.AutoSize = true;
            date_TImeLabel.Location = new System.Drawing.Point(345, 218);
            date_TImeLabel.Name = "date_TImeLabel";
            date_TImeLabel.Size = new System.Drawing.Size(77, 17);
            date_TImeLabel.TabIndex = 69;
            date_TImeLabel.Text = "Date/TIme:";
            // 
            // appointment_TimeLabel1
            // 
            appointment_TimeLabel1.AutoSize = true;
            appointment_TimeLabel1.Location = new System.Drawing.Point(13, 256);
            appointment_TimeLabel1.Name = "appointment_TimeLabel1";
            appointment_TimeLabel1.Size = new System.Drawing.Size(126, 17);
            appointment_TimeLabel1.TabIndex = 70;
            appointment_TimeLabel1.Text = "Appointment Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Patient ID:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Middle Initial:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(169, 153);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 22);
            this.txtFName.TabIndex = 5;
            // 
            // txtMInitial
            // 
            this.txtMInitial.Location = new System.Drawing.Point(313, 153);
            this.txtMInitial.Name = "txtMInitial";
            this.txtMInitial.Size = new System.Drawing.Size(38, 22);
            this.txtMInitial.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(428, 153);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 22);
            this.txtLName.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Dr. Stacy Smith",
            "Dr. Kacy Kepler",
            "Dr. Steven Jackson",
            "Justin Stalin",
            "Mario Mussilini",
            "Hitler McJager",
            "Micheal Denner",
            "Alex Blob",
            "Hector Potter",
            "Juan Baun",
            "Austin Burbach"});
            this.listBox1.Location = new System.Drawing.Point(16, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 84);
            this.listBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Provider";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "       1  \tGeneral\t\t\t$  17.00",
            "71045 \tX-Ray (Chest) \t\t$150.00",
            "71046 \tX-Ray (2 View) \t\t$150.00",
            "71047\tX-Ray (Chest 3 views)\t$ 298.00",
            "71048\tX-Ray (Chest 4+)\t\t$ 448.00",
            "74018\tRadiologic examination\t$ 298.00",
            "\tAbdominal; 1 view",
            "74019\tRadiologic Examination\t$ 298.00",
            "\tAbdomen; 2 views\t\t"});
            this.listBox2.Location = new System.Drawing.Point(0, 364);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(437, 84);
            this.listBox2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Procedure";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Phone";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(131, 22);
            this.textBox5.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(164, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "EX: xxx-xxx-xxxx";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "EX: 1500";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 464);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(74, 35);
            this.btnAccept.TabIndex = 21;
            this.btnAccept.Text = "Accept";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 31);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // patientInfoToolStripMenuItem
            // 
            this.patientInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEditPatientToolStripMenuItem,
            this.addEdietHouseholdToolStripMenuItem});
            this.patientInfoToolStripMenuItem.Name = "patientInfoToolStripMenuItem";
            this.patientInfoToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.patientInfoToolStripMenuItem.Text = "Patient Info";
            // 
            // addEditPatientToolStripMenuItem
            // 
            this.addEditPatientToolStripMenuItem.Name = "addEditPatientToolStripMenuItem";
            this.addEditPatientToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addEditPatientToolStripMenuItem.Text = "Add/Edit Patient";
            this.addEditPatientToolStripMenuItem.Click += new System.EventHandler(this.addEditPatientToolStripMenuItem_Click);
            // 
            // addEdietHouseholdToolStripMenuItem
            // 
            this.addEdietHouseholdToolStripMenuItem.Name = "addEdietHouseholdToolStripMenuItem";
            this.addEdietHouseholdToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addEdietHouseholdToolStripMenuItem.Text = "Add/Edit Household";
            this.addEdietHouseholdToolStripMenuItem.Click += new System.EventHandler(this.addEdietHouseholdToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalLedgerToolStripMenuItem,
            this.accoubntReceivableToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // generalLedgerToolStripMenuItem
            // 
            this.generalLedgerToolStripMenuItem.Name = "generalLedgerToolStripMenuItem";
            this.generalLedgerToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.generalLedgerToolStripMenuItem.Text = "General Ledger";
            this.generalLedgerToolStripMenuItem.Click += new System.EventHandler(this.generalLedgerToolStripMenuItem_Click);
            // 
            // accoubntReceivableToolStripMenuItem
            // 
            this.accoubntReceivableToolStripMenuItem.Name = "accoubntReceivableToolStripMenuItem";
            this.accoubntReceivableToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.accoubntReceivableToolStripMenuItem.Text = "Account Receivable";
            this.accoubntReceivableToolStripMenuItem.Click += new System.EventHandler(this.accoubntReceivableToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.makeToolStripMenuItem.Text = "Make";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.makeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentListToolStripMenuItem,
            this.callListToolStripMenuItem,
            this.providerToolStripMenuItem,
            this.mTDPaymentToolStripMenuItem,
            this.postcardToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // appointmentListToolStripMenuItem
            // 
            this.appointmentListToolStripMenuItem.Name = "appointmentListToolStripMenuItem";
            this.appointmentListToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.appointmentListToolStripMenuItem.Text = "Appointment list";
            this.appointmentListToolStripMenuItem.Click += new System.EventHandler(this.appointmentListToolStripMenuItem_Click);
            // 
            // callListToolStripMenuItem
            // 
            this.callListToolStripMenuItem.Name = "callListToolStripMenuItem";
            this.callListToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.callListToolStripMenuItem.Text = "Call List";
            this.callListToolStripMenuItem.Click += new System.EventHandler(this.callListToolStripMenuItem_Click);
            // 
            // providerToolStripMenuItem
            // 
            this.providerToolStripMenuItem.Name = "providerToolStripMenuItem";
            this.providerToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.providerToolStripMenuItem.Text = "Provider";
            this.providerToolStripMenuItem.Click += new System.EventHandler(this.providerToolStripMenuItem_Click);
            // 
            // mTDPaymentToolStripMenuItem
            // 
            this.mTDPaymentToolStripMenuItem.Name = "mTDPaymentToolStripMenuItem";
            this.mTDPaymentToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.mTDPaymentToolStripMenuItem.Text = "MTD Payment";
            this.mTDPaymentToolStripMenuItem.Click += new System.EventHandler(this.mTDPaymentToolStripMenuItem_Click);
            // 
            // postcardToolStripMenuItem
            // 
            this.postcardToolStripMenuItem.Name = "postcardToolStripMenuItem";
            this.postcardToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.postcardToolStripMenuItem.Text = "Postcard";
            this.postcardToolStripMenuItem.Click += new System.EventHandler(this.postcardToolStripMenuItem_Click);
            // 
            // txtHouseID
            // 
            this.txtHouseID.Location = new System.Drawing.Point(115, 69);
            this.txtHouseID.Name = "txtHouseID";
            this.txtHouseID.ReadOnly = true;
            this.txtHouseID.Size = new System.Drawing.Size(119, 22);
            this.txtHouseID.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 60;
            this.label18.Text = "Household ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.patientInfoToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(195, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 67;
            this.label17.Text = "EX: 1500";
            // 
            // systemsDataBase2DataSet
            // 
            this.systemsDataBase2DataSet.DataSetName = "SystemsDataBase2DataSet";
            this.systemsDataBase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentDataBindingSource
            // 
            this.appointmentDataBindingSource.DataMember = "Appointment Data";
            this.appointmentDataBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // appointment_DataTableAdapter
            // 
            this.appointment_DataTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter1
            // 
            this.providersTableAdapter1.ClearBeforeFill = true;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // appointment_DataTableAdapter1
            // 
            this.appointment_DataTableAdapter1.ClearBeforeFill = true;
            // 
            // appointment_DataTableAdapter2
            // 
            this.appointment_DataTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Appointment_DataTableAdapter = this.appointment_DataTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Complete_Service_DataTableAdapter = null;
            this.tableAdapterManager.Cpt_CodesTableAdapter = null;
            this.tableAdapterManager.HouseHoldTableAdapter = null;
            this.tableAdapterManager.InsurancecompaniesTableAdapter = null;
            this.tableAdapterManager.MTDChargesTableAdapter = null;
            this.tableAdapterManager.MTDPaymentsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.Pending_Insurance_ClaimsTableAdapter = null;
            this.tableAdapterManager.PostCardTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = this.providersTableAdapter1;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Visit_InfoTableAdapter = null;
            // 
            // appointment_NumberTextBox
            // 
            this.appointment_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentDataBindingSource, "Appointment Number", true));
            this.appointment_NumberTextBox.Location = new System.Drawing.Point(443, 41);
            this.appointment_NumberTextBox.Name = "appointment_NumberTextBox";
            this.appointment_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.appointment_NumberTextBox.TabIndex = 69;
            // 
            // date_TImeTextBox
            // 
            this.date_TImeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentDataBindingSource, "Date/TIme", true));
            this.date_TImeTextBox.Location = new System.Drawing.Point(428, 215);
            this.date_TImeTextBox.Name = "date_TImeTextBox";
            this.date_TImeTextBox.Size = new System.Drawing.Size(100, 22);
            this.date_TImeTextBox.TabIndex = 70;
            // 
            // appointment_TimeTextBox
            // 
            this.appointment_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentDataBindingSource, "Appointment Time", true));
            this.appointment_TimeTextBox.Location = new System.Drawing.Point(15, 276);
            this.appointment_TimeTextBox.Name = "appointment_TimeTextBox";
            this.appointment_TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.appointment_TimeTextBox.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmApptInfo
            // 
            this.ClientSize = new System.Drawing.Size(1057, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(appointment_TimeLabel1);
            this.Controls.Add(this.appointment_TimeTextBox);
            this.Controls.Add(date_TImeLabel);
            this.Controls.Add(this.date_TImeTextBox);
            this.Controls.Add(appointment_NumberLabel);
            this.Controls.Add(this.appointment_NumberTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtHouseID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtMInitial);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmApptInfo";
            this.Text = "Appointment Info";
            this.Load += new System.EventHandler(this.frmApptInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMInitial;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem patientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEditPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEdietHouseholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accoubntReceivableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mTDPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postcardToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHouseID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource appointmentDataBindingSource;
        private SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter appointment_DataTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SystemsDataBase2DataSetTableAdapters.ProvidersTableAdapter providersTableAdapter1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter appointment_DataTableAdapter1;
        private SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter appointment_DataTableAdapter2;
        private SystemsDataBase2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox appointment_NumberTextBox;
        private System.Windows.Forms.TextBox date_TImeTextBox;
        private System.Windows.Forms.TextBox appointment_TimeTextBox;
        private System.Windows.Forms.Button button1;
    }
}

