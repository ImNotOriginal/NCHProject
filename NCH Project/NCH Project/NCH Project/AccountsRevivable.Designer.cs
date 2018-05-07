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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsRevivable));
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.mTDChargesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTDChargesTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.MTDChargesTableAdapter();
            this.mTDPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTDPaymentsTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.MTDPaymentsTableAdapter();
            this.systemsDataBase2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.houseHoldTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter();
            this.payment_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.houseHold_NumberTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.current_BalanceTextBox = new System.Windows.Forms.TextBox();
            this.houseHoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.head_Of_HouseholdTextBox = new System.Windows.Forms.TextBox();
            this.appointment_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointment_DataTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter();
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
            payment_DateLabel = new System.Windows.Forms.Label();
            houseHold_NumberLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            current_BalanceLabel = new System.Windows.Forms.Label();
            head_Of_HouseholdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).BeginInit();
            this.patientsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // houseHold_NumberLabel
            // 
            houseHold_NumberLabel.AutoSize = true;
            houseHold_NumberLabel.Location = new System.Drawing.Point(12, 72);
            houseHold_NumberLabel.Name = "houseHold_NumberLabel";
            houseHold_NumberLabel.Size = new System.Drawing.Size(140, 17);
            houseHold_NumberLabel.TabIndex = 63;
            houseHold_NumberLabel.Text = "House Hold Number:";
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
            // current_BalanceLabel
            // 
            current_BalanceLabel.AutoSize = true;
            current_BalanceLabel.Location = new System.Drawing.Point(195, 141);
            current_BalanceLabel.Name = "current_BalanceLabel";
            current_BalanceLabel.Size = new System.Drawing.Size(114, 17);
            current_BalanceLabel.TabIndex = 65;
            current_BalanceLabel.Text = "Current Balance:";
            // 
            // head_Of_HouseholdLabel
            // 
            head_Of_HouseholdLabel.AutoSize = true;
            head_Of_HouseholdLabel.Location = new System.Drawing.Point(195, 72);
            head_Of_HouseholdLabel.Name = "head_Of_HouseholdLabel";
            head_Of_HouseholdLabel.Size = new System.Drawing.Size(137, 17);
            head_Of_HouseholdLabel.TabIndex = 68;
            head_Of_HouseholdLabel.Text = "Head Of Household:";
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
            // houseHoldTableAdapter
            // 
            this.houseHoldTableAdapter.ClearBeforeFill = true;
            // 
            // payment_DateDateTimePicker
            // 
            this.payment_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mTDPaymentsBindingSource, "Payment Date", true));
            this.payment_DateDateTimePicker.Location = new System.Drawing.Point(15, 243);
            this.payment_DateDateTimePicker.Name = "payment_DateDateTimePicker";
            this.payment_DateDateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.payment_DateDateTimePicker.TabIndex = 63;
            // 
            // houseHold_NumberTextBox
            // 
            this.houseHold_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "HouseHold Number", true));
            this.houseHold_NumberTextBox.Location = new System.Drawing.Point(13, 92);
            this.houseHold_NumberTextBox.Name = "houseHold_NumberTextBox";
            this.houseHold_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.houseHold_NumberTextBox.TabIndex = 64;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "Payment", true));
            this.paymentTextBox.Location = new System.Drawing.Point(15, 161);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(100, 22);
            this.paymentTextBox.TabIndex = 65;
            // 
            // current_BalanceTextBox
            // 
            this.current_BalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mTDPaymentsBindingSource, "Current Balance", true));
            this.current_BalanceTextBox.Location = new System.Drawing.Point(198, 161);
            this.current_BalanceTextBox.Name = "current_BalanceTextBox";
            this.current_BalanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.current_BalanceTextBox.TabIndex = 66;
            // 
            // houseHoldBindingSource
            // 
            this.houseHoldBindingSource.DataMember = "HouseHold";
            this.houseHoldBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // head_Of_HouseholdTextBox
            // 
            this.head_Of_HouseholdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource, "Head Of Household", true));
            this.head_Of_HouseholdTextBox.Location = new System.Drawing.Point(198, 92);
            this.head_Of_HouseholdTextBox.Name = "head_Of_HouseholdTextBox";
            this.head_Of_HouseholdTextBox.Size = new System.Drawing.Size(100, 22);
            this.head_Of_HouseholdTextBox.TabIndex = 69;
            // 
            // appointment_DataBindingSource
            // 
            this.appointment_DataBindingSource.DataMember = "Appointment Data";
            this.appointment_DataBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // appointment_DataTableAdapter
            // 
            this.appointment_DataTableAdapter.ClearBeforeFill = true;
            // 
            // patientsBindingNavigator
            // 
            this.patientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.patientsBindingNavigator.Size = new System.Drawing.Size(562, 27);
            this.patientsBindingNavigator.TabIndex = 70;
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
            // frmAccountsRevivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 354);
            this.ControlBox = false;
            this.Controls.Add(this.patientsBindingNavigator);
            this.Controls.Add(head_Of_HouseholdLabel);
            this.Controls.Add(this.head_Of_HouseholdTextBox);
            this.Controls.Add(current_BalanceLabel);
            this.Controls.Add(this.current_BalanceTextBox);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(houseHold_NumberLabel);
            this.Controls.Add(this.houseHold_NumberTextBox);
            this.Controls.Add(payment_DateLabel);
            this.Controls.Add(this.payment_DateDateTimePicker);
            this.Name = "frmAccountsRevivable";
            this.Text = "Accounts Recivable";
            this.Load += new System.EventHandler(this.frmAccountsRevivable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDChargesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTDPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingNavigator)).EndInit();
            this.patientsBindingNavigator.ResumeLayout(false);
            this.patientsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter houseHoldTableAdapter;
        private System.Windows.Forms.BindingSource houseHoldBindingSource;
        private System.Windows.Forms.TextBox head_Of_HouseholdTextBox;
        private System.Windows.Forms.BindingSource appointment_DataBindingSource;
        private SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter appointment_DataTableAdapter;
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
    }
}