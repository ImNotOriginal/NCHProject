namespace NCH_Project
{
    partial class frmGeneralLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneralLedger));
            System.Windows.Forms.Label patient_NumberLabel;
            System.Windows.Forms.Label patient_NameLabel;
            System.Windows.Forms.Label current_BalanceLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPostRef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.mTDChargesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTDChargesTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.MTDChargesTableAdapter();
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.mTDChargesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mTDChargesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patient_NumberTextBox = new System.Windows.Forms.TextBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter();
            this.patient_NameTextBox = new System.Windows.Forms.TextBox();
            this.mTDPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTDPaymentsTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.MTDPaymentsTableAdapter();
            this.current_BalanceTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            patient_NumberLabel = new System.Windows.Forms.Label();
            patient_NameLabel = new System.Windows.Forms.Label();
            current_BalanceLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingNavigator)).BeginInit();
            this.mTDChargesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDPaymentsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(663, 28);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paymentTextBox);
            this.groupBox1.Controls.Add(current_BalanceLabel);
            this.groupBox1.Controls.Add(this.current_BalanceTextBox);
            this.groupBox1.Controls.Add(this.txtAmountPaid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDebit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPostRef);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 265);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(203, 223);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(100, 22);
            this.txtAmountPaid.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Amount Paid:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Credit: ";
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(365, 51);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.ReadOnly = true;
            this.txtDebit.Size = new System.Drawing.Size(100, 22);
            this.txtDebit.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Debit: ";
            // 
            // txtPostRef
            // 
            this.txtPostRef.Location = new System.Drawing.Point(203, 51);
            this.txtPostRef.Name = "txtPostRef";
            this.txtPostRef.ReadOnly = true;
            this.txtPostRef.Size = new System.Drawing.Size(100, 22);
            this.txtPostRef.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Post ref. :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(21, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(171, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 33);
            this.btnClose.TabIndex = 68;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // systemsDataBase2DataSet
            // 
            this.systemsDataBase2DataSet.DataSetName = "SystemsDataBase2DataSet";
            this.systemsDataBase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mTDChargesBindingSource
            // 
            this.mTDChargesBindingSource.DataMember = "MTDCharges";
            this.mTDChargesBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // mTDChargesTableAdapter
            // 
            this.mTDChargesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Appointment_DataTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Complete_Service_DataTableAdapter = null;
            this.tableAdapterManager.Cpt_CodesTableAdapter = null;
            this.tableAdapterManager.HouseHoldTableAdapter = null;
            this.tableAdapterManager.InsurancecompaniesTableAdapter = null;
            this.tableAdapterManager.MTDChargesTableAdapter = this.mTDChargesTableAdapter;
            this.tableAdapterManager.MTDPaymentsTableAdapter = this.mTDPaymentsTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.Pending_Insurance_ClaimsTableAdapter = null;
            this.tableAdapterManager.PostCardTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Visit_InfoTableAdapter = null;
            // 
            // mTDChargesBindingNavigator
            // 
            this.mTDChargesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mTDChargesBindingNavigator.BindingSource = this.mTDChargesBindingSource;
            this.mTDChargesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mTDChargesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mTDChargesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mTDChargesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mTDChargesBindingNavigatorSaveItem});
            this.mTDChargesBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.mTDChargesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mTDChargesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mTDChargesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mTDChargesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mTDChargesBindingNavigator.Name = "mTDChargesBindingNavigator";
            this.mTDChargesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mTDChargesBindingNavigator.Size = new System.Drawing.Size(663, 27);
            this.mTDChargesBindingNavigator.TabIndex = 69;
            this.mTDChargesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mTDChargesBindingNavigatorSaveItem
            // 
            this.mTDChargesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mTDChargesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mTDChargesBindingNavigatorSaveItem.Image")));
            this.mTDChargesBindingNavigatorSaveItem.Name = "mTDChargesBindingNavigatorSaveItem";
            this.mTDChargesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mTDChargesBindingNavigatorSaveItem.Text = "Save Data";
            this.mTDChargesBindingNavigatorSaveItem.Click += new System.EventHandler(this.mTDChargesBindingNavigatorSaveItem_Click);
            // 
            // patient_NumberLabel
            // 
            patient_NumberLabel.AutoSize = true;
            patient_NumberLabel.Location = new System.Drawing.Point(30, 115);
            patient_NumberLabel.Name = "patient_NumberLabel";
            patient_NumberLabel.Size = new System.Drawing.Size(110, 17);
            patient_NumberLabel.TabIndex = 69;
            patient_NumberLabel.Text = "Patient Number:";
            // 
            // patient_NumberTextBox
            // 
            this.patient_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDChargesBindingSource, "Patient Number", true));
            this.patient_NumberTextBox.Location = new System.Drawing.Point(146, 112);
            this.patient_NumberTextBox.Name = "patient_NumberTextBox";
            this.patient_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.patient_NumberTextBox.TabIndex = 70;
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
            // patient_NameLabel
            // 
            patient_NameLabel.AutoSize = true;
            patient_NameLabel.Location = new System.Drawing.Point(30, 80);
            patient_NameLabel.Name = "patient_NameLabel";
            patient_NameLabel.Size = new System.Drawing.Size(97, 17);
            patient_NameLabel.TabIndex = 70;
            patient_NameLabel.Text = "Patient Name:";
            // 
            // patient_NameTextBox
            // 
            this.patient_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "Patient Name", true));
            this.patient_NameTextBox.Location = new System.Drawing.Point(146, 77);
            this.patient_NameTextBox.Name = "patient_NameTextBox";
            this.patient_NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.patient_NameTextBox.TabIndex = 71;
            // 
            // mTDPaymentsBindingSource
            // 
            this.mTDPaymentsBindingSource.DataMember = "MTDPayments";
            this.mTDPaymentsBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // mTDPaymentsTableAdapter
            // 
            this.mTDPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // current_BalanceLabel
            // 
            current_BalanceLabel.AutoSize = true;
            current_BalanceLabel.Location = new System.Drawing.Point(28, 136);
            current_BalanceLabel.Name = "current_BalanceLabel";
            current_BalanceLabel.Size = new System.Drawing.Size(114, 17);
            current_BalanceLabel.TabIndex = 12;
            current_BalanceLabel.Text = "Current Balance:";
            // 
            // current_BalanceTextBox
            // 
            this.current_BalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "Current Balance", true));
            this.current_BalanceTextBox.Location = new System.Drawing.Point(159, 133);
            this.current_BalanceTextBox.Name = "current_BalanceTextBox";
            this.current_BalanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.current_BalanceTextBox.TabIndex = 13;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "Payment", true));
            this.paymentTextBox.Location = new System.Drawing.Point(498, 51);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 22);
            this.paymentTextBox.TabIndex = 14;
            // 
            // frmGeneralLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 530);
            this.Controls.Add(patient_NameLabel);
            this.Controls.Add(this.patient_NameTextBox);
            this.Controls.Add(patient_NumberLabel);
            this.Controls.Add(this.patient_NumberTextBox);
            this.Controls.Add(this.mTDChargesBindingNavigator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmGeneralLedger";
            this.Text = "Genreal Ledger";
            this.Load += new System.EventHandler(this.frmGeneralLedger_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingNavigator)).EndInit();
            this.mTDChargesBindingNavigator.ResumeLayout(false);
            this.mTDChargesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDPaymentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostRef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource mTDChargesBindingSource;
        private SystemsDataBase2DataSetTableAdapters.MTDChargesTableAdapter mTDChargesTableAdapter;
        private SystemsDataBase2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mTDChargesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mTDChargesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patient_NumberTextBox;
        private SystemsDataBase2DataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private SystemsDataBase2DataSetTableAdapters.MTDPaymentsTableAdapter mTDPaymentsTableAdapter;
        private System.Windows.Forms.TextBox patient_NameTextBox;
        private System.Windows.Forms.BindingSource mTDPaymentsBindingSource;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox current_BalanceTextBox;
    }
}