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
            System.Windows.Forms.Label appointment_TimeLabel1;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label patient_NumberLabel;
            System.Windows.Forms.Label houseHold_NumberLabel;
            System.Windows.Forms.Label patient_NameLabel;
            System.Windows.Forms.Label appointment_NumberLabel;
            System.Windows.Forms.Label providerNameLabel;
            System.Windows.Forms.Label end_TimeLabel;
            System.Windows.Forms.Label date_TImeLabel;
            System.Windows.Forms.Label cpt_codesLabel;
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
            this.appointment_TimeTextBox = new System.Windows.Forms.TextBox();
            this.houseHoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseHoldTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.houseHoldBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patient_NumberTextBox = new System.Windows.Forms.TextBox();
            this.houseHold_NumberTextBox = new System.Windows.Forms.TextBox();
            this.patient_NameTextBox = new System.Windows.Forms.TextBox();
            this.appointment_NumberTextBox = new System.Windows.Forms.TextBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerNameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.end_TimeTextBox = new System.Windows.Forms.TextBox();
            this.date_TImeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cpt_codesListBox = new System.Windows.Forms.ListBox();
            appointment_TimeLabel1 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            patient_NumberLabel = new System.Windows.Forms.Label();
            houseHold_NumberLabel = new System.Windows.Forms.Label();
            patient_NameLabel = new System.Windows.Forms.Label();
            appointment_NumberLabel = new System.Windows.Forms.Label();
            providerNameLabel = new System.Windows.Forms.Label();
            end_TimeLabel = new System.Windows.Forms.Label();
            date_TImeLabel = new System.Windows.Forms.Label();
            cpt_codesLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointment_TimeLabel1
            // 
            appointment_TimeLabel1.AutoSize = true;
            appointment_TimeLabel1.Location = new System.Drawing.Point(13, 269);
            appointment_TimeLabel1.Name = "appointment_TimeLabel1";
            appointment_TimeLabel1.Size = new System.Drawing.Size(126, 17);
            appointment_TimeLabel1.TabIndex = 70;
            appointment_TimeLabel1.Text = "Appointment Time:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(167, 193);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 74;
            phoneLabel.Text = "Phone:";
            // 
            // patient_NumberLabel
            // 
            patient_NumberLabel.AutoSize = true;
            patient_NumberLabel.Location = new System.Drawing.Point(21, 41);
            patient_NumberLabel.Name = "patient_NumberLabel";
            patient_NumberLabel.Size = new System.Drawing.Size(110, 17);
            patient_NumberLabel.TabIndex = 75;
            patient_NumberLabel.Text = "Patient Number:";
            // 
            // houseHold_NumberLabel
            // 
            houseHold_NumberLabel.AutoSize = true;
            houseHold_NumberLabel.Location = new System.Drawing.Point(21, 77);
            houseHold_NumberLabel.Name = "houseHold_NumberLabel";
            houseHold_NumberLabel.Size = new System.Drawing.Size(140, 17);
            houseHold_NumberLabel.TabIndex = 76;
            houseHold_NumberLabel.Text = "House Hold Number:";
            // 
            // patient_NameLabel
            // 
            patient_NameLabel.AutoSize = true;
            patient_NameLabel.Location = new System.Drawing.Point(173, 153);
            patient_NameLabel.Name = "patient_NameLabel";
            patient_NameLabel.Size = new System.Drawing.Size(97, 17);
            patient_NameLabel.TabIndex = 77;
            patient_NameLabel.Text = "Patient Name:";
            // 
            // appointment_NumberLabel
            // 
            appointment_NumberLabel.AutoSize = true;
            appointment_NumberLabel.Location = new System.Drawing.Point(292, 41);
            appointment_NumberLabel.Name = "appointment_NumberLabel";
            appointment_NumberLabel.Size = new System.Drawing.Size(145, 17);
            appointment_NumberLabel.TabIndex = 78;
            appointment_NumberLabel.Text = "Appointment Number:";
            // 
            // providerNameLabel
            // 
            providerNameLabel.AutoSize = true;
            providerNameLabel.Location = new System.Drawing.Point(13, 128);
            providerNameLabel.Name = "providerNameLabel";
            providerNameLabel.Size = new System.Drawing.Size(106, 17);
            providerNameLabel.TabIndex = 79;
            providerNameLabel.Text = "Provider Name:";
            // 
            // end_TimeLabel
            // 
            end_TimeLabel.AutoSize = true;
            end_TimeLabel.Location = new System.Drawing.Point(174, 269);
            end_TimeLabel.Name = "end_TimeLabel";
            end_TimeLabel.Size = new System.Drawing.Size(72, 17);
            end_TimeLabel.TabIndex = 80;
            end_TimeLabel.Text = "End Time:";
            // 
            // date_TImeLabel
            // 
            date_TImeLabel.AutoSize = true;
            date_TImeLabel.Location = new System.Drawing.Point(292, 269);
            date_TImeLabel.Name = "date_TImeLabel";
            date_TImeLabel.Size = new System.Drawing.Size(42, 17);
            date_TImeLabel.TabIndex = 81;
            date_TImeLabel.Text = "Date:";
            // 
            // cpt_codesLabel
            // 
            cpt_codesLabel.AutoSize = true;
            cpt_codesLabel.Location = new System.Drawing.Point(13, 340);
            cpt_codesLabel.Name = "cpt_codesLabel";
            cpt_codesLabel.Size = new System.Drawing.Size(75, 17);
            cpt_codesLabel.TabIndex = 82;
            cpt_codesLabel.Text = "Cpt codes:";
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
            this.label15.Location = new System.Drawing.Point(13, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "EX: 1500";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(16, 450);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(74, 35);
            this.btnAccept.TabIndex = 21;
            this.btnAccept.Text = "Accept";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(153, 450);
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
            this.menuStrip1.Size = new System.Drawing.Size(605, 28);
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
            // appointment_TimeTextBox
            // 
            this.appointment_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentDataBindingSource, "Appointment Time", true));
            this.appointment_TimeTextBox.Location = new System.Drawing.Point(16, 289);
            this.appointment_TimeTextBox.Name = "appointment_TimeTextBox";
            this.appointment_TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.appointment_TimeTextBox.TabIndex = 71;
            // 
            // houseHoldBindingSource
            // 
            this.houseHoldBindingSource.DataMember = "HouseHold";
            this.houseHoldBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // houseHoldTableAdapter
            // 
            this.houseHoldTableAdapter.ClearBeforeFill = true;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(170, 215);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 75;
            // 
            // houseHoldBindingSource1
            // 
            this.houseHoldBindingSource1.DataMember = "Appointment DataHouseHold";
            this.houseHoldBindingSource1.DataSource = this.appointmentDataBindingSource;
            // 
            // patient_NumberTextBox
            // 
            this.patient_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource1, "Patient Number", true));
            this.patient_NumberTextBox.Location = new System.Drawing.Point(137, 38);
            this.patient_NumberTextBox.Name = "patient_NumberTextBox";
            this.patient_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.patient_NumberTextBox.TabIndex = 76;
            // 
            // houseHold_NumberTextBox
            // 
            this.houseHold_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource1, "HouseHold Number", true));
            this.houseHold_NumberTextBox.Location = new System.Drawing.Point(167, 74);
            this.houseHold_NumberTextBox.Name = "houseHold_NumberTextBox";
            this.houseHold_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.houseHold_NumberTextBox.TabIndex = 77;
            // 
            // patient_NameTextBox
            // 
            this.patient_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource1, "Patient Name", true));
            this.patient_NameTextBox.Location = new System.Drawing.Point(276, 150);
            this.patient_NameTextBox.Name = "patient_NameTextBox";
            this.patient_NameTextBox.Size = new System.Drawing.Size(267, 22);
            this.patient_NameTextBox.TabIndex = 78;
            // 
            // appointment_NumberTextBox
            // 
            this.appointment_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentDataBindingSource, "Appointment Number", true));
            this.appointment_NumberTextBox.Location = new System.Drawing.Point(443, 38);
            this.appointment_NumberTextBox.Name = "appointment_NumberTextBox";
            this.appointment_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.appointment_NumberTextBox.TabIndex = 79;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // providerNameCheckedListBox
            // 
            this.providerNameCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providersBindingSource, "ProviderName", true));
            this.providerNameCheckedListBox.FormattingEnabled = true;
            this.providerNameCheckedListBox.Items.AddRange(new object[] {
            "Stacy Smith",
            "Kacy Kepler",
            "Steven Jackson",
            "Justin Stalin",
            "Micheal Denner",
            "Alex Blob",
            "Hector Potter",
            "Juan Jose",
            "Austin Burbach"});
            this.providerNameCheckedListBox.Location = new System.Drawing.Point(7, 153);
            this.providerNameCheckedListBox.Name = "providerNameCheckedListBox";
            this.providerNameCheckedListBox.Size = new System.Drawing.Size(154, 89);
            this.providerNameCheckedListBox.TabIndex = 80;
            // 
            // end_TimeTextBox
            // 
            this.end_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentDataBindingSource, "End Time", true));
            this.end_TimeTextBox.Location = new System.Drawing.Point(170, 289);
            this.end_TimeTextBox.Name = "end_TimeTextBox";
            this.end_TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.end_TimeTextBox.TabIndex = 81;
            // 
            // date_TImeDateTimePicker
            // 
            this.date_TImeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentDataBindingSource, "Date/TIme", true));
            this.date_TImeDateTimePicker.Location = new System.Drawing.Point(295, 289);
            this.date_TImeDateTimePicker.Name = "date_TImeDateTimePicker";
            this.date_TImeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_TImeDateTimePicker.TabIndex = 82;
            // 
            // cpt_codesListBox
            // 
            this.cpt_codesListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providersBindingSource, "Cpt codes", true));
            this.cpt_codesListBox.FormattingEnabled = true;
            this.cpt_codesListBox.ItemHeight = 16;
            this.cpt_codesListBox.Items.AddRange(new object[] {
            "       1  \tGeneral\t\t\t$  17.00",
            "71045 \tX-Ray (Chest) \t\t$150.00",
            "71046 \tX-Ray (2 View) \t\t$150.00",
            "71047\tX-Ray (Chest 3 views)\t$ 298.00",
            "71048\tX-Ray (Chest 4+)\t\t$ 448.00",
            "74018\tRadiologic examination\t$ 298.00",
            "\tAbdominal; 1 view",
            "74019\tRadiologic Examination\t$ 298.00",
            "\tAbdomen; 2 views\t\t"});
            this.cpt_codesListBox.Location = new System.Drawing.Point(16, 360);
            this.cpt_codesListBox.Name = "cpt_codesListBox";
            this.cpt_codesListBox.Size = new System.Drawing.Size(251, 84);
            this.cpt_codesListBox.TabIndex = 83;
            // 
            // frmApptInfo
            // 
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1057, 519);
=======
            this.ClientSize = new System.Drawing.Size(605, 519);
>>>>>>> 48d6d8503c1f9874e231562399dd7fd0bcaa162e
            this.Controls.Add(cpt_codesLabel);
            this.Controls.Add(this.cpt_codesListBox);
            this.Controls.Add(date_TImeLabel);
            this.Controls.Add(this.date_TImeDateTimePicker);
            this.Controls.Add(end_TimeLabel);
            this.Controls.Add(this.end_TimeTextBox);
            this.Controls.Add(providerNameLabel);
            this.Controls.Add(this.providerNameCheckedListBox);
            this.Controls.Add(appointment_NumberLabel);
            this.Controls.Add(this.appointment_NumberTextBox);
            this.Controls.Add(patient_NameLabel);
            this.Controls.Add(this.patient_NameTextBox);
            this.Controls.Add(houseHold_NumberLabel);
            this.Controls.Add(this.houseHold_NumberTextBox);
            this.Controls.Add(patient_NumberLabel);
            this.Controls.Add(this.patient_NumberTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(appointment_TimeLabel1);
            this.Controls.Add(this.appointment_TimeTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
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
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox appointment_TimeTextBox;
        private System.Windows.Forms.BindingSource houseHoldBindingSource;
        private SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter houseHoldTableAdapter;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.BindingSource houseHoldBindingSource1;
        private System.Windows.Forms.TextBox patient_NumberTextBox;
        private System.Windows.Forms.TextBox houseHold_NumberTextBox;
        private System.Windows.Forms.TextBox patient_NameTextBox;
        private System.Windows.Forms.TextBox appointment_NumberTextBox;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private System.Windows.Forms.CheckedListBox providerNameCheckedListBox;
        private System.Windows.Forms.TextBox end_TimeTextBox;
        private System.Windows.Forms.DateTimePicker date_TImeDateTimePicker;
        private System.Windows.Forms.ListBox cpt_codesListBox;
    }
}

