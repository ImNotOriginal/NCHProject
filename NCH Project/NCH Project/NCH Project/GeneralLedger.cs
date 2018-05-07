using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCH_Project
{
    public partial class frmGeneralLedger : Form
    {
     
        public frmGeneralLedger()
        {
            InitializeComponent();

        }

      
        private void frmGeneralLedger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDPayments' table. You can move, or remove it, as needed.
            this.mTDPaymentsTableAdapter.Fill(this.systemsDataBase2DataSet.MTDPayments);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDPayments' table. You can move, or remove it, as needed.
            this.mTDPaymentsTableAdapter.Fill(this.systemsDataBase2DataSet.MTDPayments);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDPayments' table. You can move, or remove it, as needed.
            this.mTDPaymentsTableAdapter.Fill(this.systemsDataBase2DataSet.MTDPayments);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDCharges' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDPayments' table. You can move, or remove it, as needed.
            this.mTDPaymentsTableAdapter.Fill(this.systemsDataBase2DataSet.MTDPayments);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDPayments' table. You can move, or remove it, as needed.
            this.mTDPaymentsTableAdapter.Fill(this.systemsDataBase2DataSet.MTDPayments);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDPayments' table. You can move, or remove it, as needed.
            this.mTDPaymentsTableAdapter.Fill(this.systemsDataBase2DataSet.MTDPayments);
       
        }

        private void mTDPaymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mTDPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void mTDPaymentsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mTDPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void mTDPaymentsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.mTDPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void mTDChargesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void mTDPaymentsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.mTDPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void mTDPaymentsBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.mTDPaymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }
    }
}
