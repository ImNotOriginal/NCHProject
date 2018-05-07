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
    public partial class frmProviderReport : Form
    {
    
        public frmProviderReport()
        {
            InitializeComponent();
        }

        private void providersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void providersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.providersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void frmProviderReport_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this.systemsDataBase2DataSet.Providers);
  
        }

      

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void providersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.providersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }
    }
}
