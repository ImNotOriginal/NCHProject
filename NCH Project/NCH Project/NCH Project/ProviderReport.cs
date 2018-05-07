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
        public frmHousehold House;
        public frmApptInfo Apointment;
        public frmPatientInfo Patient;
        public frmHomePage Home;
        public frmPostCard Post;
        public frmProviderReport ProReport;
        public frmGeneralLedger GLedge;
        public frmMTDPayments MTD;
        public frmCallList Call;
        public frmApptList AList;
        public frmAccountsRevivable AccRec;
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
            Patient = new frmPatientInfo();
            Apointment = new frmApptInfo();
            Home = new frmHomePage();
            House = new frmHousehold();
            Post = new frmPostCard();
            ProReport = new frmProviderReport();
            GLedge = new frmGeneralLedger();
            MTD = new frmMTDPayments();
            Call = new frmCallList();
            AList = new frmApptList();
            AccRec = new frmAccountsRevivable();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.ShowDialog();
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void addEditPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient.ShowDialog();
            this.Close();
        }

        private void addEdietHouseholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            House.ShowDialog();
            this.Close();
        }

        private void generalLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLedge.ShowDialog();
            this.Close();
        }

        private void accoubntReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccRec.ShowDialog();
            this.Close();
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appointmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AList.ShowDialog();
            this.Close();
        }

        private void callListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Call.ShowDialog();
            this.Close();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProReport.ShowDialog();
            this.Close();
        }

        private void mTDPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MTD.ShowDialog();
            this.Close();
        }

        private void postcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Post.ShowDialog();
            this.Close();
        }
    }
}
