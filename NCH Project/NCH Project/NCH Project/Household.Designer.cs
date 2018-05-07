namespace NCH_Project
{
    partial class frmHousehold
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label houseHold_NumberLabel;
            System.Windows.Forms.Label head_Of_HouseholdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHousehold));
            this.btnAccept = new System.Windows.Forms.Button();
            this.houseHoldBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.houseHoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
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
            this.houseHoldBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.houseHold_NumberTextBox = new System.Windows.Forms.TextBox();
            this.head_Of_HouseholdTextBox = new System.Windows.Forms.TextBox();
            this.houseHoldTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter();
            this.tableAdapterManager = new NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseHoldDataGridView = new System.Windows.Forms.DataGridView();
            addressLabel = new System.Windows.Forms.Label();
            houseHold_NumberLabel = new System.Windows.Forms.Label();
            head_Of_HouseholdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingNavigator)).BeginInit();
            this.houseHoldBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(30, 134);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 43;
            addressLabel.Text = "Address:";
            // 
            // houseHold_NumberLabel
            // 
            houseHold_NumberLabel.AutoSize = true;
            houseHold_NumberLabel.Location = new System.Drawing.Point(30, 92);
            houseHold_NumberLabel.Name = "houseHold_NumberLabel";
            houseHold_NumberLabel.Size = new System.Drawing.Size(140, 17);
            houseHold_NumberLabel.TabIndex = 44;
            houseHold_NumberLabel.Text = "House Hold Number:";
            // 
            // head_Of_HouseholdLabel
            // 
            head_Of_HouseholdLabel.AutoSize = true;
            head_Of_HouseholdLabel.Location = new System.Drawing.Point(304, 94);
            head_Of_HouseholdLabel.Name = "head_Of_HouseholdLabel";
            head_Of_HouseholdLabel.Size = new System.Drawing.Size(137, 17);
            head_Of_HouseholdLabel.TabIndex = 45;
            head_Of_HouseholdLabel.Text = "Head Of Household:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(746, 278);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(10, 10);
            this.btnAccept.TabIndex = 37;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // houseHoldBindingNavigator
            // 
            this.houseHoldBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.houseHoldBindingNavigator.BindingSource = this.houseHoldBindingSource;
            this.houseHoldBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.houseHoldBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.houseHoldBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.houseHoldBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.houseHoldBindingNavigatorSaveItem});
            this.houseHoldBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.houseHoldBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.houseHoldBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.houseHoldBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.houseHoldBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.houseHoldBindingNavigator.Name = "houseHoldBindingNavigator";
            this.houseHoldBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.houseHoldBindingNavigator.Size = new System.Drawing.Size(573, 27);
            this.houseHoldBindingNavigator.TabIndex = 41;
            this.houseHoldBindingNavigator.Text = "bindingNavigator1";
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
            // houseHoldBindingSource
            // 
            this.houseHoldBindingSource.DataMember = "HouseHold";
            this.houseHoldBindingSource.DataSource = this.systemsDataBase2DataSet;
            // 
            // systemsDataBase2DataSet
            // 
            this.systemsDataBase2DataSet.DataSetName = "SystemsDataBase2DataSet";
            this.systemsDataBase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // houseHoldBindingNavigatorSaveItem
            // 
            this.houseHoldBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.houseHoldBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("houseHoldBindingNavigatorSaveItem.Image")));
            this.houseHoldBindingNavigatorSaveItem.Name = "houseHoldBindingNavigatorSaveItem";
            this.houseHoldBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.houseHoldBindingNavigatorSaveItem.Text = "Save Data";
            this.houseHoldBindingNavigatorSaveItem.Click += new System.EventHandler(this.houseHoldBindingNavigatorSaveItem_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(100, 131);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(429, 22);
            this.addressTextBox.TabIndex = 44;
            // 
            // houseHold_NumberTextBox
            // 
            this.houseHold_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource, "HouseHold Number", true));
            this.houseHold_NumberTextBox.Location = new System.Drawing.Point(176, 89);
            this.houseHold_NumberTextBox.Name = "houseHold_NumberTextBox";
            this.houseHold_NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.houseHold_NumberTextBox.TabIndex = 45;
            // 
            // head_Of_HouseholdTextBox
            // 
            this.head_Of_HouseholdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseHoldBindingSource, "Head Of Household", true));
            this.head_Of_HouseholdTextBox.Location = new System.Drawing.Point(447, 89);
            this.head_Of_HouseholdTextBox.Name = "head_Of_HouseholdTextBox";
            this.head_Of_HouseholdTextBox.Size = new System.Drawing.Size(100, 22);
            this.head_Of_HouseholdTextBox.TabIndex = 46;
            // 
            // houseHoldTableAdapter
            // 
            this.houseHoldTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Complete_Service_DataTableAdapter = null;
            this.tableAdapterManager.Cpt_CodesTableAdapter = null;
            this.tableAdapterManager.HouseHoldTableAdapter = this.houseHoldTableAdapter;
            this.tableAdapterManager.InsurancecompaniesTableAdapter = null;
            this.tableAdapterManager.MTDChargesTableAdapter = null;
            this.tableAdapterManager.MTDPaymentsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.Pending_Insurance_ClaimsTableAdapter = null;
            this.tableAdapterManager.PostCardTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NCH_Project.SystemsDataBase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Visit_InfoTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Head Of Household";
            this.dataGridViewTextBoxColumn2.HeaderText = "Head Of Household";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HouseHold Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "HouseHold Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // houseHoldDataGridView
            // 
            this.houseHoldDataGridView.AutoGenerateColumns = false;
            this.houseHoldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.houseHoldDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.houseHoldDataGridView.DataSource = this.houseHoldBindingSource;
            this.houseHoldDataGridView.Location = new System.Drawing.Point(33, 173);
            this.houseHoldDataGridView.Name = "houseHoldDataGridView";
            this.houseHoldDataGridView.RowTemplate.Height = 24;
            this.houseHoldDataGridView.Size = new System.Drawing.Size(496, 200);
            this.houseHoldDataGridView.TabIndex = 46;
            // 
            // frmHousehold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 444);
            this.ControlBox = false;
            this.Controls.Add(this.houseHoldDataGridView);
            this.Controls.Add(head_Of_HouseholdLabel);
            this.Controls.Add(this.head_Of_HouseholdTextBox);
            this.Controls.Add(houseHold_NumberLabel);
            this.Controls.Add(this.houseHold_NumberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.houseHoldBindingNavigator);
            this.Controls.Add(this.btnAccept);
            this.Name = "frmHousehold";
            this.Text = "Household";
            this.Load += new System.EventHandler(this.frmHousehold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingNavigator)).EndInit();
            this.houseHoldBindingNavigator.ResumeLayout(false);
            this.houseHoldBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseHoldDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAccept;
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource houseHoldBindingSource;
        private SystemsDataBase2DataSetTableAdapters.HouseHoldTableAdapter houseHoldTableAdapter;
        private SystemsDataBase2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator houseHoldBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton houseHoldBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox houseHold_NumberTextBox;
        private System.Windows.Forms.TextBox head_Of_HouseholdTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView houseHoldDataGridView;
    }
}