using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation
{
    public partial class ViewDonor : Form
    {
        public ViewDonor()
        {
            InitializeComponent();
        }

        private void ViewDonor_Load(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {
            //Donor
            Donor donor = new Donor();
            donor.StartPosition = FormStartPosition.Manual;
            donor.Location = this.Location;
            donor.Show();
            this.Hide();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            //Patient
            Patient patient = new Patient();
            patient.StartPosition = FormStartPosition.Manual;
            patient.Location = this.Location;
            patient.Show();
            this.Hide();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            //View Patients
            ViewPatient viewpatient = new ViewPatient();
            viewpatient.StartPosition = FormStartPosition.Manual;
            viewpatient.Location = this.Location;
            viewpatient.Show();
            this.Hide();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            //Blood Stock
            BloodStock stock = new BloodStock();
            stock.StartPosition = FormStartPosition.Manual;
            stock.Location = this.Location;
            stock.Show();
            this.Hide();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            //Blood Transfer
            BloodTransfer transfer = new BloodTransfer();
            transfer.StartPosition = FormStartPosition.Manual;
            transfer.Location = this.Location;
            transfer.Show();
            this.Hide();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            //DashBoard
            DashBoard dashBoard = new DashBoard();
            dashBoard.StartPosition = FormStartPosition.Manual;
            dashBoard.Location = this.Location;
            dashBoard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Logout
        }
    }
}
