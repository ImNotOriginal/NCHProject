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
    public partial class frmApptInfo : Form
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
        public frmApptInfo()
        {
            InitializeComponent();
        }

        //Code used on the Forms Load
        private void frmApptInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.HouseHold' table. You can move, or remove it, as needed.
            this.houseHoldTableAdapter.Fill(this.systemsDataBase2DataSet.HouseHold);

            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.systemsDataBase2DataSet.Patients);
            // TODO: This line of code loads data into the 'systemsDataBase2DataSet.Appointment_Data' table. You can move, or remove it, as needed.
            this.appointment_DataTableAdapter.Fill(this.systemsDataBase2DataSet.Appointment_Data);
            // Used to change from Form to Form
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
            AccRec = new frmAccountsRevivable();

            


        }

        //Button to Close the program
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            //Closes the Program
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

        //Code for the Edit HouseHold ToolStrip
        private void addEdietHouseholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            House.ShowDialog();
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

        //Code for the Postcard Toolstrip
        private void postcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Used to change from Form to Form
            this.Hide();
            Post.ShowDialog();
            this.Close();
        }

        //Code for the Provider Report
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
          
        }

        

        private void houseHold_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void providerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
