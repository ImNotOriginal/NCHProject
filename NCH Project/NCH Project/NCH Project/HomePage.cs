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
    public partial class frmHomePage : Form
    {
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
        public frmHomePage()
        {
            InitializeComponent();
        }

        //Code executed on Form Load
        private void frmHomePage_Load(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            Patient = new frmPatientInfo();
            Appointment = new frmApptInfo();
            House = new frmHousehold();
            Post = new frmPostCard();
            ProReport = new frmProviderReport();
            GLedge = new frmGeneralLedger();
            MTD = new frmMTDPayments();
            Call = new frmCallList();
            AList = new frmApptList();
            AccRec = new frmAccountsRevivable();

        }
       
        //Button that takes to the Add/Edit Household Form
        private void btnHouse_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            House.ShowDialog();
            this.Close();

        }

        //Button that takes to the Add/Edit Patient Form
        private void btnPatient_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Patient.ShowDialog();
            this.Close();
        }

        //Button that takes to the Appointment Form (Make)
        private void btnMake_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Appointment.ShowDialog();
            this.Close();
        }

        //Button that takes to the Postcard Form
        private void btnPostcards_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Post.ShowDialog();
            this.Close();

        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            //Used to change from Form to Form
            this.Hide();
            ProReport.ShowDialog();
            this.Close();
        }

        private void btnGeneralLedger_Click(object sender, EventArgs e)
        {
            this.Hide();
            GLedge.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            MTD.ShowDialog();
            this.Close();
        }

        private void btnCallList_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Call.ShowDialog();
            this.Close();
        }

        private void btnAccountRec_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            AccRec.ShowDialog();
            this.Close();
        }

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            AList.ShowDialog();
            this.Close();
        }
    }
}
