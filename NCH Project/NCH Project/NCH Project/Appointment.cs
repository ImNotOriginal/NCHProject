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
    public partial class frmApptInfo : Form
    {
   
        public frmApptInfo()
        {
            InitializeComponent();
        }

        //Code used on the Forms Load
        private void frmApptInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.HouseHold' table. You can move, or remove it, as needed.
            this.houseHoldTableAdapter.Fill(this.systemsDataBase2DataSet.HouseHold);

            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.systemsDataBase2DataSet.Patients);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Appointment_Data' table. You can move, or remove it, as needed.
            this.appointment_DataTableAdapter.Fill(this.systemsDataBase2DataSet.Appointment_Data);
        

            


        }



        private void btnAccept_Click(object sender, EventArgs e)
        {
          
        }

        

        private void houseHold_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void providerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will save the data, Any changes will be final! Are you sure?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                this.patientsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);
            }
            else
            {

            }
        }

        private void providerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Validate();
            this.houseHoldBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }
    }
}
