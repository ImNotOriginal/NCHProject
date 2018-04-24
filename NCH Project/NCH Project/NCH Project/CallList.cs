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
    public partial class frmCallList : Form
    {
        public frmHomePage Home;
        public frmHousehold House;
        public frmApptInfo Appointment;
        public frmPatientInfo Patient;
        public frmPostCard Post;
        public frmProviderReport ProReport;
        public frmGeneralLedger GLedge;
        public frmMTDPayments MTD;
        public frmCallList Call;
        public frmApptList AList;
        public frmAccountsRevivable AccRec;
        public frmCallList()
        {
            InitializeComponent();
        }

        private void frmCallList_Load(object sender, EventArgs e)
        {
           
            
            // Used to change from Form to Form
            Patient = new frmPatientInfo();
            Appointment = new frmApptInfo();
            House = new frmHousehold();
            Post = new frmPostCard();
            ProReport = new frmProviderReport();
            GLedge = new frmGeneralLedger();
            MTD = new frmMTDPayments();
            Home = new frmHomePage();
            Call = new frmCallList();
            AList = new frmApptList();
            AccRec = new frmAccountsRevivable();


            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Home.ShowDialog();
            this.Close();
        }

        private void addEditPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Patient.ShowDialog();
            this.Close();
        }

        private void addEdietHouseholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            House.ShowDialog();
            this.Close();
        }

        private void generalLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            GLedge.ShowDialog();
            this.Close();
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Appointment.ShowDialog();
            this.Close();
        }

        private void callListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Call.ShowDialog();
            this.Close();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            ProReport.ShowDialog();
            this.Close();
        }

        private void mTDPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            MTD.ShowDialog();
            this.Close();
        }

        private void postcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Post.ShowDialog();
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
    }
}
