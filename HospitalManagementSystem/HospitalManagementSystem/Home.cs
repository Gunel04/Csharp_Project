using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 h = new Form1();
            h.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doctorPictureBox_Click(object sender, EventArgs e)
        {
            DoctorForm h = new DoctorForm();
            h.Show();
            this.Hide();
        }

        private void patientPictureBox_Click(object sender, EventArgs e)
        {
            PatientForm h = new PatientForm();
            h.Show();
            this.Hide();
        }

        private void diagnosisPictureBox_Click(object sender, EventArgs e)
        {
            DiagnosisForm h = new DiagnosisForm();
            h.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void diagnosisLabel_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
