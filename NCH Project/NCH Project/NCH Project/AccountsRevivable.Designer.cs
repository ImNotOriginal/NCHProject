namespace NCH_Project
{
    partial class frmAccountsRevivable
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
            System.Windows.Forms.Label payment_DateLabel;
            System.Windows.Forms.Label houseHold_NumberLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label current_BalanceLabel;
            System.Windows.Forms.Label head_Of_HouseholdLabel;
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
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.mTDChargesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTDChargesTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.MTDChargesTableAdapter();
            this.mTDPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTDPaymentsTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.MTDPaymentsTableAdapter();
            this.systemsDataBase2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.payment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.houseHold_NumberTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.current_BalanceTextBox = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.houseHoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseHoldTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter();
            this.head_Of_HouseholdTextBox = new System.Windows.Forms.TextBox();
            payment_DateLabel = new System.Windows.Forms.Label();
            houseHold_NumberLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            current_BalanceLabel = new System.Windows.Forms.Label();
            head_Of_HouseholdLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(497, 28);
            this.menuStrip1.TabIndex = 62;
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
            // mTDPaymentsBindingSource
            // 
            this.mTDPaymentsBindingSource.DataMember = "MTDPayments";
            this.mTDPaymentsBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // mTDPaymentsTableAdapter
            // 
            this.mTDPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // systemsDataBase2DataSetBindingSource
            // 
            this.systemsDataBase2DataSetBindingSource.DataSource = this.systemsDataBase2DataSet;
            this.systemsDataBase2DataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Appointment_DataTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Complete_Service_DataTableAdapter = null;
            this.tableAdapterManager.Cpt_CodesTableAdapter = null;
            this.tableAdapterManager.HouseHoldTableAdapter = this.houseHoldTableAdapter;
            this.tableAdapterManager.InsurancecompaniesTableAdapter = null;
            this.tableAdapterManager.MTDChargesTableAdapter = this.mTDChargesTableAdapter;
            this.tableAdapterManager.MTDPaymentsTableAdapter = this.mTDPaymentsTableAdapter;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.Pending_Insurance_ClaimsTableAdapter = null;
            this.tableAdapterManager.PostCardTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Visit_InfoTableAdapter = null;
            // 
            // payment_DateLabel
            // 
            payment_DateLabel.AutoSize = true;
            payment_DateLabel.Location = new System.Drawing.Point(12, 223);
            payment_DateLabel.Name = "payment_DateLabel";
            payment_DateLabel.Size = new System.Drawing.Size(101, 17);
            payment_DateLabel.TabIndex = 62;
            payment_DateLabel.Text = "Payment Date:";
            // 
            // payment_DateDateTimePicker
            // 
            this.payment_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mTDPaymentsBindingSource, "Payment Date", true));
            this.payment_DateDateTimePicker.Location = new System.Drawing.Point(15, 243);
            this.payment_DateDateTimePicker.Name = "payment_DateDateTimePicker";
            this.payment_DateDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.payment_DateDateTimePicker.TabIndex = 63;
            // 
            // houseHold_NumberLabel
            // 
            houseHold_NumberLabel.AutoSize = true;
            houseHold_NumberLabel.Location = new System.Drawing.Point(12, 38);
            houseHold_NumberLabel.Name = "houseHold_NumberLabel";
            houseHold_NumberLabel.Size = new System.Drawing.Size(140, 17);
            houseHold_NumberLabel.TabIndex = 63;
            houseHold_NumberLabel.Text = "House Hold Number:";
            // 
            // houseHold_NumberTextBox
            // 
            this.houseHold_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "HouseHold Number", true));
            this.houseHold_NumberTextBox.Location = new System.Drawing.Point(15, 58);
            this.houseHold_NumberTextBox.Name = "houseHold_NumberTextBox";
            this.houseHold_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.houseHold_NumberTextBox.TabIndex = 64;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(12, 141);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(67, 17);
            paymentLabel.TabIndex = 64;
            paymentLabel.Text = "Payment:";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "Payment", true));
            this.paymentTextBox.Location = new System.Drawing.Point(15, 161);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 22);
            this.paymentTextBox.TabIndex = 65;
            // 
            // current_BalanceLabel
            // 
            current_BalanceLabel.AutoSize = true;
            current_BalanceLabel.Location = new System.Drawing.Point(195, 141);
            current_BalanceLabel.Name = "current_BalanceLabel";
            current_BalanceLabel.Size = new System.Drawing.Size(114, 17);
            current_BalanceLabel.TabIndex = 65;
            current_BalanceLabel.Text = "Current Balance:";
            // 
            // current_BalanceTextBox
            // 
            this.current_BalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "Current Balance", true));
            this.current_BalanceTextBox.Location = new System.Drawing.Point(198, 161);
            this.current_BalanceTextBox.Name = "current_BalanceTextBox";
            this.current_BalanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.current_BalanceTextBox.TabIndex = 66;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(15, 326);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(78, 38);
            this.btnAccept.TabIndex = 67;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(134, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 38);
            this.btnClose.TabIndex = 68;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // head_Of_HouseholdLabel
            // 
            head_Of_HouseholdLabel.AutoSize = true;
            head_Of_HouseholdLabel.Location = new System.Drawing.Point(195, 38);
            head_Of_HouseholdLabel.Name = "head_Of_HouseholdLabel";
            head_Of_HouseholdLabel.Size = new System.Drawing.Size(137, 17);
            head_Of_HouseholdLabel.TabIndex = 68;
            head_Of_HouseholdLabel.Text = "Head Of Household:";
            // 
            // head_Of_HouseholdTextBox
            // 
            this.head_Of_HouseholdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource, "Head Of Household", true));
            this.head_Of_HouseholdTextBox.Location = new System.Drawing.Point(198, 58);
            this.head_Of_HouseholdTextBox.Name = "head_Of_HouseholdTextBox";
            this.head_Of_HouseholdTextBox.Size = new System.Drawing.Size(100, 22);
            this.head_Of_HouseholdTextBox.TabIndex = 69;
            // 
            // frmAccountsRevivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 397);
            this.Controls.Add(head_Of_HouseholdLabel);
            this.Controls.Add(this.head_Of_HouseholdTextBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(current_BalanceLabel);
            this.Controls.Add(this.current_BalanceTextBox);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(houseHold_NumberLabel);
            this.Controls.Add(this.houseHold_NumberTextBox);
            this.Controls.Add(payment_DateLabel);
            this.Controls.Add(this.payment_DateDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAccountsRevivable";
            this.Text = "Accounts Recivable";
            this.Load += new System.EventHandler(this.frmAccountsRevivable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).EndInit();
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
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource mTDChargesBindingSource;
        private SystemsDataBase2DataSetTableAdapters.MTDChargesTableAdapter mTDChargesTableAdapter;
        private System.Windows.Forms.BindingSource mTDPaymentsBindingSource;
        private SystemsDataBase2DataSetTableAdapters.MTDPaymentsTableAdapter mTDPaymentsTableAdapter;
        private System.Windows.Forms.BindingSource systemsDataBase2DataSetBindingSource;
        private SystemsDataBase2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker payment_DateDateTimePicker;
        private System.Windows.Forms.TextBox houseHold_NumberTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox current_BalanceTextBox;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClose;
        private SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter houseHoldTableAdapter;
        private System.Windows.Forms.BindingSource houseHoldBindingSource;
        private System.Windows.Forms.TextBox head_Of_HouseholdTextBox;
    }
}