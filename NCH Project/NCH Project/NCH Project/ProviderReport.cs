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

        public frmProviderReport()
        {
            InitializeComponent();
        }

        private void frmProviderReport_Load(object sender, EventArgs e)
        {
            Patient = new frmPatientInfo();
            Appointment = new frmApptInfo();
            Home = new frmHomePage();
            House = new frmHousehold();
            Post = new frmPostCard();
            ProReport = new frmProviderReport();
            GLedge = new frmGeneralLedger();
            MTD = new frmMTDPayments();
            Call = new frmCallList();
            AList = new frmApptList();
        }

        //Button that closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Code for the Home toolstrip
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Used to change from Form to Form
            this.Hide();
            Home.ShowDialog();
            this.Close();
        }

        //Code for the Add/Edit Patient toolstrip
        private void addEditPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Used to change from Form to Form
            this.Hide();
            Patient.ShowDialog();
            this.Close();
        }

        //Code for the Add/Edit Household toolstrip
        private void addEdietHouseholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Used to change from Form to Form
            this.Hide();
            House.ShowDialog();
            this.Close();
        }

        //Code for the Appointment(Make) toolstrip
        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Used to change from Form to Form
            this.Hide();
            Appointment.ShowDialog();
            this.Close();
        }

        //Code for the Postcard toolstrip
        private void postcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Used to change from Form to Form
            this.Hide();
            Post.ShowDialog();
            this.Close();
        }

        //Code for the Provider Report toolstrip
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

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
          
=======
            
>>>>>>> parent of af5820a... Working provider
        }
    }
}
