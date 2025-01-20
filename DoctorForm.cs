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
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NCMM5OU;Initial Catalog=HMSFinalExam;Integrated Security=True;Trust Server Certificate=True");

        public DoctorForm()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            doctorGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void doctorIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorTbl set DocName = '" + doctorNameTextBox.Text + "', DocExp = '" + yearsTextBox.Text + "', DocPass = '" + passwordTextBox.Text + "' where DocId = " + doctorIdTextBox.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully Updated!");
            Con.Close();
            populate();
        }

        private void doctorNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (doctorIdTextBox.Text == "")
                MessageBox.Show("Enter The Doctor Id");
            else
            {
                Con.Open();
                string query = "delete from DoctorTbl where DocId=" + doctorIdTextBox.Text + " ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (doctorIdTextBox.Text == "" || doctorNameTextBox.Text == "" || passwordTextBox.Text == "" || yearsTextBox.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                Con.Open();
                string query = "insert into DoctorTbl values(" + doctorIdTextBox.Text + ", '" + doctorNameTextBox.Text + "', " + yearsTextBox.Text + ", '" + passwordTextBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void doctorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = doctorGridView.Rows[e.RowIndex];

                // Check if the selected row's cells contain valid data
                if (selectedRow.Cells[0].Value != null)
                {
                    doctorIdTextBox.Text = selectedRow.Cells[0].Value.ToString();
                    doctorNameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                    yearsTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    passwordTextBox.Text = selectedRow.Cells[3].Value.ToString();
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
    }
}
