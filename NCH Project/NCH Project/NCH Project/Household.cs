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
    public partial class frmHousehold : Form
    {
        //Declaration
  
        public frmHousehold()
        {
            InitializeComponent();
        }


        //Code used on the Forms Load
        private void frmHousehold_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.HouseHold' table. You can move, or remove it, as needed.
            this.houseHoldTableAdapter.Fill(this.systemsDataBase2DataSet.HouseHold);
            //ToolStrip - FormLoad
         
            
        }


        //Button to Close the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void houseHoldBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will save the data, Any changes will be final! Are you sure?", "Save Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                this.houseHoldBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);
            }
            else
            {

            }
            this.Validate();
            
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

      
    }

}
