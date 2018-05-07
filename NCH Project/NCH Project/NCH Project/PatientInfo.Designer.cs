namespace NCH_Project
{
    partial class frmPatientInfo
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
            System.Windows.Forms.Label patient_NumberLabel;
            System.Windows.Forms.Label household_NumberLabel;
            System.Windows.Forms.Label patient_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label raceLabel1;
            System.Windows.Forms.Label compIDLabel;
            System.Windows.Forms.Label insuranceCompNameLabel;
            System.Windows.Forms.Label companyPhoneLabel;
            System.Windows.Forms.Label companyAddressLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientInfo));
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoAsain = new System.Windows.Forms.RadioButton();
            this.rdoNativeAmerican = new System.Windows.Forms.RadioButton();
            this.rdoAfricanAmerican = new System.Windows.Forms.RadioButton();
            this.rdoHispanic = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter();
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.patient_NumberTextBox = new System.Windows.Forms.TextBox();
            this.household_NumberTextBox = new System.Windows.Forms.TextBox();
            this.patient_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.patientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.insurancecompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyPhoneTextBox = new System.Windows.Forms.TextBox();
            this.insuranceCompNameTextBox = new System.Windows.Forms.TextBox();
            this.compIDTextBox = new System.Windows.Forms.TextBox();
            this.insurancecompaniesTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.InsurancecompaniesTableAdapter();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            patient_NumberLabel = new System.Windows.Forms.Label();
            household_NumberLabel = new System.Windows.Forms.Label();
            patient_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            raceLabel1 = new System.Windows.Forms.Label();
            compIDLabel = new System.Windows.Forms.Label();
            insuranceCompNameLabel = new System.Windows.Forms.Label();
            companyPhoneLabel = new System.Windows.Forms.Label();
            companyAddressLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insurancecompaniesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_NumberLabel
            // 
            patient_NumberLabel.AutoSize = true;
            patient_NumberLabel.Location = new System.Drawing.Point(18, 74);
            patient_NumberLabel.Name = "patient_NumberLabel";
            patient_NumberLabel.Size = new System.Drawing.Size(110, 17);
            patient_NumberLabel.TabIndex = 61;
            patient_NumberLabel.Text = "Patient Number:";
            // 
            // household_NumberLabel
            // 
            household_NumberLabel.AutoSize = true;
            household_NumberLabel.Location = new System.Drawing.Point(309, 71);
            household_NumberLabel.Name = "household_NumberLabel";
            household_NumberLabel.Size = new System.Drawing.Size(134, 17);
            household_NumberLabel.TabIndex = 62;
            household_NumberLabel.Text = "Household Number:";
            // 
            // patient_NameLabel
            // 
            patient_NameLabel.AutoSize = true;
            patient_NameLabel.Location = new System.Drawing.Point(18, 111);
            patient_NameLabel.Name = "patient_NameLabel";
            patient_NameLabel.Size = new System.Drawing.Size(97, 17);
            patient_NameLabel.TabIndex = 63;
            patient_NameLabel.Text = "Patient Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(9, 195);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 64;
            addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(13, 229);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 65;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(120, 229);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 66;
            emailLabel.Text = "Email:";
            // 
            // raceLabel1
            // 
            raceLabel1.AutoSize = true;
            raceLabel1.Location = new System.Drawing.Point(28, 153);
            raceLabel1.Name = "raceLabel1";
            raceLabel1.Size = new System.Drawing.Size(45, 17);
            raceLabel1.TabIndex = 73;
            raceLabel1.Text = "Race:";
            // 
            // compIDLabel
            // 
            compIDLabel.AutoSize = true;
            compIDLabel.Location = new System.Drawing.Point(6, 18);
            compIDLabel.Name = "compIDLabel";
            compIDLabel.Size = new System.Drawing.Size(65, 17);
            compIDLabel.TabIndex = 0;
            compIDLabel.Text = "Comp ID:";
            // 
            // insuranceCompNameLabel
            // 
            insuranceCompNameLabel.AutoSize = true;
            insuranceCompNameLabel.Location = new System.Drawing.Point(285, 18);
            insuranceCompNameLabel.Name = "insuranceCompNameLabel";
            insuranceCompNameLabel.Size = new System.Drawing.Size(155, 17);
            insuranceCompNameLabel.TabIndex = 2;
            insuranceCompNameLabel.Text = "Insurance Comp Name:";
            // 
            // companyPhoneLabel
            // 
            companyPhoneLabel.AutoSize = true;
            companyPhoneLabel.Location = new System.Drawing.Point(6, 82);
            companyPhoneLabel.Name = "companyPhoneLabel";
            companyPhoneLabel.Size = new System.Drawing.Size(116, 17);
            companyPhoneLabel.TabIndex = 4;
            companyPhoneLabel.Text = "Company Phone:";
            // 
            // companyAddressLabel
            // 
            companyAddressLabel.AutoSize = true;
            companyAddressLabel.Location = new System.Drawing.Point(285, 82);
            companyAddressLabel.Name = "companyAddressLabel";
            companyAddressLabel.Size = new System.Drawing.Size(127, 17);
            companyAddressLabel.TabIndex = 6;
            companyAddressLabel.Text = "Company Address:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(278, 152);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(69, 17);
            birthdateLabel.TabIndex = 74;
            birthdateLabel.Text = "Birthdate:";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 71;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 70;
            // 
            // rdoOther
            // 
            this.rdoOther.Location = new System.Drawing.Point(0, 0);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(104, 24);
            this.rdoOther.TabIndex = 0;
            // 
            // rdoAsain
            // 
            this.rdoAsain.Location = new System.Drawing.Point(0, 0);
            this.rdoAsain.Name = "rdoAsain";
            this.rdoAsain.Size = new System.Drawing.Size(104, 24);
            this.rdoAsain.TabIndex = 0;
            // 
            // rdoNativeAmerican
            // 
            this.rdoNativeAmerican.Location = new System.Drawing.Point(0, 0);
            this.rdoNativeAmerican.Name = "rdoNativeAmerican";
            this.rdoNativeAmerican.Size = new System.Drawing.Size(104, 24);
            this.rdoNativeAmerican.TabIndex = 0;
            // 
            // rdoAfricanAmerican
            // 
            this.rdoAfricanAmerican.Location = new System.Drawing.Point(0, 0);
            this.rdoAfricanAmerican.Name = "rdoAfricanAmerican";
            this.rdoAfricanAmerican.Size = new System.Drawing.Size(104, 24);
            this.rdoAfricanAmerican.TabIndex = 0;
            // 
            // rdoHispanic
            // 
            this.rdoHispanic.Location = new System.Drawing.Point(0, 0);
            this.rdoHispanic.Name = "rdoHispanic";
            this.rdoHispanic.Size = new System.Drawing.Size(104, 24);
            this.rdoHispanic.TabIndex = 0;
            // 
            // rdoWhite
            // 
            this.rdoWhite.Location = new System.Drawing.Point(0, 0);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(104, 24);
            this.rdoWhite.TabIndex = 0;
            // 
            // systemsDataBase2DataSet
            // 
            this.systemsDataBase2DataSet.DataSetName = "SystemsDataBase2DataSet";
            this.systemsDataBase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
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
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Visit_InfoTableAdapter = null;
            // 
            // patient_NumberTextBox
            // 
            this.patient_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Patient Number", true));
            this.patient_NumberTextBox.Location = new System.Drawing.Point(134, 71);
            this.patient_NumberTextBox.Name = "patient_NumberTextBox";
            this.patient_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.patient_NumberTextBox.TabIndex = 62;
            // 
            // household_NumberTextBox
            // 
            this.household_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Household Number", true));
            this.household_NumberTextBox.Location = new System.Drawing.Point(449, 68);
            this.household_NumberTextBox.Name = "household_NumberTextBox";
            this.household_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.household_NumberTextBox.TabIndex = 63;
            // 
            // patient_NameTextBox
            // 
            this.patient_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Patient Name", true));
            this.patient_NameTextBox.Location = new System.Drawing.Point(121, 108);
            this.patient_NameTextBox.Name = "patient_NameTextBox";
            this.patient_NameTextBox.Size = new System.Drawing.Size(210, 22);
            this.patient_NameTextBox.TabIndex = 64;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(79, 192);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(274, 22);
            this.addressTextBox.TabIndex = 65;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(12, 249);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 66;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(125, 249);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(263, 22);
            this.emailTextBox.TabIndex = 67;
            // 
            // patientsBindingNavigator
            // 
            this.patientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientsBindingNavigator.BindingSource = this.patientsBindingSource;
            this.patientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patientsBindingNavigatorSaveItem});
            this.patientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientsBindingNavigator.Name = "patientsBindingNavigator";
            this.patientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientsBindingNavigator.Size = new System.Drawing.Size(576, 27);
            this.patientsBindingNavigator.TabIndex = 73;
            this.patientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // patientsBindingNavigatorSaveItem
            // 
            this.patientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientsBindingNavigatorSaveItem.Image")));
            this.patientsBindingNavigatorSaveItem.Name = "patientsBindingNavigatorSaveItem";
            this.patientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.patientsBindingNavigatorSaveItem.Text = "Save Data";
            this.patientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientsBindingNavigatorSaveItem_Click);
            // 
            // raceComboBox
            // 
            this.raceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Race", true));
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "White ",
            "African American",
            "Hispanic",
            "Other"});
            this.raceComboBox.Location = new System.Drawing.Point(79, 150);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(171, 24);
            this.raceComboBox.TabIndex = 74;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(companyAddressLabel);
            this.groupBox2.Controls.Add(this.companyAddressTextBox);
            this.groupBox2.Controls.Add(companyPhoneLabel);
            this.groupBox2.Controls.Add(this.companyPhoneTextBox);
            this.groupBox2.Controls.Add(insuranceCompNameLabel);
            this.groupBox2.Controls.Add(this.insuranceCompNameTextBox);
            this.groupBox2.Controls.Add(compIDLabel);
            this.groupBox2.Controls.Add(this.compIDTextBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 133);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medical Info";
            // 
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insurancecompaniesBindingSource, "CompanyAddress", true));
            this.companyAddressTextBox.Location = new System.Drawing.Point(288, 102);
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(189, 22);
            this.companyAddressTextBox.TabIndex = 7;
            // 
            // insurancecompaniesBindingSource
            // 
            this.insurancecompaniesBindingSource.DataMember = "Insurancecompanies";
            this.insurancecompaniesBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // companyPhoneTextBox
            // 
            this.companyPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insurancecompaniesBindingSource, "CompanyPhone", true));
            this.companyPhoneTextBox.Location = new System.Drawing.Point(9, 102);
            this.companyPhoneTextBox.Name = "companyPhoneTextBox";
            this.companyPhoneTextBox.Size = new System.Drawing.Size(189, 22);
            this.companyPhoneTextBox.TabIndex = 5;
            // 
            // insuranceCompNameTextBox
            // 
            this.insuranceCompNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insurancecompaniesBindingSource, "InsuranceCompName", true));
            this.insuranceCompNameTextBox.Location = new System.Drawing.Point(288, 38);
            this.insuranceCompNameTextBox.Name = "insuranceCompNameTextBox";
            this.insuranceCompNameTextBox.Size = new System.Drawing.Size(189, 22);
            this.insuranceCompNameTextBox.TabIndex = 3;
            // 
            // compIDTextBox
            // 
            this.compIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insurancecompaniesBindingSource, "CompID", true));
            this.compIDTextBox.Location = new System.Drawing.Point(9, 38);
            this.compIDTextBox.Name = "compIDTextBox";
            this.compIDTextBox.Size = new System.Drawing.Size(189, 22);
            this.compIDTextBox.TabIndex = 1;
            // 
            // insurancecompaniesTableAdapter
            // 
            this.insurancecompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientsBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(353, 148);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birthdateDateTimePicker.TabIndex = 75;
            // 
            // frmPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 457);
            this.ControlBox = false;
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(raceLabel1);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(patient_NameLabel);
            this.Controls.Add(this.patient_NameTextBox);
            this.Controls.Add(household_NumberLabel);
            this.Controls.Add(this.household_NumberTextBox);
            this.Controls.Add(patient_NumberLabel);
            this.Controls.Add(this.patient_NumberTextBox);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPatientInfo";
            this.Text = " PatientInfo";
            this.Load += new System.EventHandler(this.frmPatientInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insurancecompaniesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoAsain;
        private System.Windows.Forms.RadioButton rdoNativeAmerican;
        private System.Windows.Forms.RadioButton rdoAfricanAmerican;
        private System.Windows.Forms.RadioButton rdoHispanic;
        private System.Windows.Forms.RadioButton rdoWhite;
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private SystemsDataBase2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox patient_NumberTextBox;
        private System.Windows.Forms.TextBox household_NumberTextBox;
        private System.Windows.Forms.TextBox patient_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.BindingNavigator patientsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patientsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource insurancecompaniesBindingSource;
        private SystemsDataBase2DataSetTableAdapters.InsurancecompaniesTableAdapter insurancecompaniesTableAdapter;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.TextBox companyPhoneTextBox;
        private System.Windows.Forms.TextBox insuranceCompNameTextBox;
        private System.Windows.Forms.TextBox compIDTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
    }
}