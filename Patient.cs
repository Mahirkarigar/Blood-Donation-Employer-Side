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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Donor
            Donor donor = new Donor();
            donor.StartPosition = FormStartPosition.Manual;
            donor.Location = this.Location;
            donor.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //View Donor
            ViewDonor viewDonor = new ViewDonor();
            viewDonor.StartPosition = FormStartPosition.Manual;
            viewDonor.Location = this.Location;
            viewDonor.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //View Patients
            ViewPatient viewpatient = new ViewPatient();
            viewpatient.StartPosition = FormStartPosition.Manual;
            viewpatient.Location = this.Location;
            viewpatient.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //Blood Stock
            BloodStock stock = new BloodStock();
            stock.StartPosition = FormStartPosition.Manual;
            stock.Location = this.Location;
            stock.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //Blood Transfer
            BloodTransfer transfer = new BloodTransfer();
            transfer.StartPosition = FormStartPosition.Manual;
            transfer.Location = this.Location;
            transfer.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            //DashBoard
            DashBoard dashBoard = new DashBoard();
            dashBoard.StartPosition = FormStartPosition.Manual;
            dashBoard.Location = this.Location;
            dashBoard.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            //Logout
        }
    }
}
