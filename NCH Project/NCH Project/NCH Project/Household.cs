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
        public frmHousehold House;
        public frmApptInfo Appointment;
        public frmPatientInfo Patient;
        public frmHomePage Home;
        public frmPostCard Post;
        public frmProviderReport ProReport;
        public frmGeneralLedger GLedge;
        public frmMTDPayments MTD;
        public frmCallList Call;
        public frmApptList AList;
        public frmAccountsRevivable AccRec;
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
            Appointment = new frmApptInfo();
            Patient = new frmPatientInfo();
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


        //Button to Close the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Code for the Home Tool Strip
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Home.ShowDialog();
            this.Close();
        }

        //Code for the Edit Patient ToolStrip
        private void addEditPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Patient.ShowDialog();
            this.Close();
        }

        //Code for the Make Appointment ToolStrip
        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Appointment.ShowDialog();
            this.Close();
        }

        //Code for the Edit HouseHold ToolStrip
        private void addEdietHouseholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            House.ShowDialog();
            this.Close();
        }

        //Code for the PostCard ToolStrip
        private void postcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Post.ShowDialog();
            this.Close();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Used to change from Form to Form
            this.Hide();
            ProReport.ShowDialog();
            this.Close();
        }

        private void generalLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLedge.ShowDialog();
            this.Close();
        }

        private void mTDPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            MTD.ShowDialog();
            this.Close();
        }

        private void callListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Call.ShowDialog();
            this.Close();
        }

        private void accoubntReceivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            AccRec.ShowDialog();
            this.Close();
        }

        private void appointmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            AList.ShowDialog();
            this.Close();
        }

        private void houseHoldBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.houseHoldBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.systemsDataBase2DataSet);

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }

}
