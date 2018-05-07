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
    public partial class frmPatientInfo : Form
    {
        

        public frmPatientInfo()
        {
            InitializeComponent();
        }
        private void frmPatientInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Insurancecompanies' table. You can move, or remove it, as needed.
            this.insurancecompaniesTableAdapter.Fill(this.systemsDataBase2DataSet.Insurancecompanies);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.systemsDataBase2DataSet.Patients);
            // Code NEEDED to change from form to form
            
        }
        
            
      

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will save the data, Any changes will be final! Are you sure?" ,"Save Data" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                this.patientsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);
            }
            else
            {
                
            }
            
        }
    }
}
