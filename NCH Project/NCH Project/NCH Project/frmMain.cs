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
    public partial class frmMain : Form
    {
        frmAccountsRevivable AccRec;
        frmPatientInfo PatientInfoForm;
        frmHousehold House;
        frmApptInfo ApptMake;
        frmGeneralLedger GenLedg;
        frmProviderReport Provider;
        frmCallList Call;
        frmMTDPayments MTD;
        frmPostCard Post;
        frmApptList AptList;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AccRec = new frmAccountsRevivable();
            AccRec.MdiParent = this;
            PatientInfoForm = new frmPatientInfo();
            PatientInfoForm.MdiParent = this;
            House = new frmHousehold();
            House.MdiParent = this;
            ApptMake = new frmApptInfo();
            ApptMake.MdiParent = this;
            GenLedg = new frmGeneralLedger();
            GenLedg.MdiParent = this;
            Provider = new frmProviderReport();
            Provider.MdiParent = this;
            Call = new frmCallList();
            Call.MdiParent = this;
            MTD = new frmMTDPayments();
            MTD.MdiParent = this;
            Post = new frmPostCard();
            Post.MdiParent = this;
            AptList = new frmApptList();
            AptList.MdiParent = this;



            
           

        }

        private void editPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientInfoForm.WindowState = FormWindowState.Maximized;
            PatientInfoForm.Show();
        }
      
        private void editHouseholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            House.WindowState = FormWindowState.Maximized;
            House.Show();
        }

        

        private void makeApointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApptMake.WindowState = FormWindowState.Maximized;
            ApptMake.Show();
        }

        private void generalLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenLedg .WindowState = FormWindowState.Maximized;
            GenLedg.Show();
        }

        private void accountsRecivableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccRec.WindowState = FormWindowState.Maximized;
            AccRec.Show();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider.WindowState = FormWindowState.Maximized;
            Provider.Show();
        }

        private void callListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Call.WindowState = FormWindowState.Maximized;
            Call.Show();
        }

        private void mTDPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MTD.WindowState = FormWindowState.Maximized;
            MTD.Show();
        }

        private void postCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Post.WindowState = FormWindowState.Maximized;
            Post.Show();
        }

        private void appointmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AptList.WindowState = FormWindowState.Maximized;
            AptList.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccRec.WindowState = FormWindowState.Maximized;
            AccRec.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
