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
    public partial class frmPostCard : Form
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
        public frmPostCard()
        {
            InitializeComponent();
        }

        private void frmPostCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.systemsDataBase2DataSet.Patients);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.PostCard' table. You can move, or remove it, as needed.
            this.postCardTableAdapter.Fill(this.systemsDataBase2DataSet.PostCard);
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
            Apointment.ShowDialog();
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

        //Code to Print - Waste of time
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 50, 50);
        }

        Bitmap bmp;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics ng = Graphics.FromImage(bmp);
            ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
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

        private void postCardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
    }
}
