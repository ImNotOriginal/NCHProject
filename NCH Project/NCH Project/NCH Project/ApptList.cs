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
    
    public partial class frmApptList : Form
    {

        public frmApptList()
        {
            InitializeComponent();
        }
        private void frmApptList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Appointment_Data' table. You can move, or remove it, as needed.
            this.appointment_DataTableAdapter.Fill(this.systemsDataBase2DataSet.Appointment_Data);
            // Used to change from Form to Form
         
        }

        private void accoubntReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        

     

        private void appointment_DataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will save the data, Any changes will be final! Are you sure?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                this.appointment_DataBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);
            }
            else
            {

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
