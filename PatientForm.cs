using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NCMM5OU;Initial Catalog=HMSFinalExam;Integrated Security=True;Trust Server Certificate=True");
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            patientGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add button logic
            MessageBox.Show("Add button clicked!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete button logic
            MessageBox.Show("Delete button clicked!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update button logic
            MessageBox.Show("Update button clicked!");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Home button logic
            MessageBox.Show("Home button clicked!");
        }







        private void patientAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (patientIdTextBox.Text == "" || patientNameTextBox.Text == "" || patientAddressTextBox.Text == "" || patientPhoneTextBox.Text == "" || patientAgeTextBox.Text == "" || diseasesTextBox.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values(" + patientIdTextBox.Text + ", '" + patientNameTextBox.Text + "', '" + patientAddressTextBox.Text + "', '" + patientPhoneTextBox.Text + "', " + patientAgeTextBox.Text + ", '" + genderComboBox.SelectedItem.ToString() + "', '" + bloodGrComboBox.SelectedItem.ToString() + "', '" + diseasesTextBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (patientIdTextBox.Text == "")
                MessageBox.Show("Enter The Patient Id");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId=" + patientIdTextBox.Text + " ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void patientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = patientGridView.Rows[e.RowIndex];

                // Check if the selected row's cells contain valid data
                if (selectedRow.Cells[0].Value != null)
                {
                    patientIdTextBox.Text = selectedRow.Cells[0].Value.ToString();
                    patientNameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                    patientAddressTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    patientPhoneTextBox.Text = selectedRow.Cells[3].Value.ToString();
                    patientAgeTextBox.Text = selectedRow.Cells[4].Value.ToString();
                    genderComboBox.SelectedValue = selectedRow.Cells[5].Value.ToString();
                    bloodGrComboBox.SelectedValue = selectedRow.Cells[6].Value.ToString();
                    diseasesTextBox.Text = selectedRow.Cells[7].Value.ToString();
                }
                else
                {
                    MessageBox.Show("The selected row does not contain valid data.");
                }
            }
            else
            {
                MessageBox.Show("Please click on a valid cell.");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTbl set PatName = '" + patientNameTextBox.Text + "', PatAddress = '" + patientAddressTextBox.Text + "', PatPhone = '" + patientPhoneTextBox.Text + "', PatAge = " + patientAgeTextBox.Text + ", PatGender = '" + genderComboBox.SelectedItem.ToString() + "', PatBlood = '" + bloodGrComboBox.SelectedItem.ToString() + "',PatDisease = '" + diseasesTextBox.Text + "' where PatId = " + patientIdTextBox.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Successfully Updated!");
            Con.Close();
            populate();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
