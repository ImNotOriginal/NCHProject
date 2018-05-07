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

    public partial class frmAccountsRevivable : Form
    {
        
        public frmAccountsRevivable()
        {
            InitializeComponent();
        }
        private void frmAccountsRevivable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Appointment_Data' table. You can move, or remove it, as needed.
            this.appointment_DataTableAdapter.Fill(this.systemsDataBase2DataSet.Appointment_Data);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.HouseHold' table. You can move, or remove it, as needed.
            this.houseHoldTableAdapter.Fill(this.systemsDataBase2DataSet.HouseHold);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDPayments' table. You can move, or remove it, as needed.
            this.mTDPaymentsTableAdapter.Fill(this.systemsDataBase2DataSet.MTDPayments);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.MTDCharges' table. You can move, or remove it, as needed.
            this.mTDChargesTableAdapter.Fill(this.systemsDataBase2DataSet.MTDCharges);
          
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will save the data, Any changes will be final! Are you sure?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
               
                this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);
            }
            else
            {

            }
        }

       
    }
}
