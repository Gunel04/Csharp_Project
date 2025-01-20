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
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NCMM5OU;Initial Catalog=HMSFinalExam;Integrated Security=True;Trust Server Certificate=True");
        void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                patientIdComboBox.ValueMember = "PatId";
                patientIdComboBox.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        string patname;
        void fetchpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId = " + patientIdComboBox.SelectedValue.ToString() + "  ";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                patientNameTextBox.Text = patname;

            }
            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            diagnosisGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void diagnosisIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (diagnosisIdTextBox.Text == "" || medicinesTextBox.Text == "" || diagnosisTextBox.Text == "" || patientNameTextBox.Text == "" || medicinesTextBox.Text == "")
            {
                MessageBox.Show("No Empty Fill Accepted");
            }
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTbl values(" + diagnosisIdTextBox.Text + ", " + patientIdComboBox.SelectedValue.ToString() + ", '" + patientNameTextBox.Text + "', '" + symptomsTextBox.Text + "', '" + diagnosisTextBox.Text + "', '" + medicinesTextBox.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void patientIdComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (diagnosisIdTextBox.Text == "")
                MessageBox.Show("Enter The Diagnosis Id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + diagnosisIdTextBox.Text + " ";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void diagnosisGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = diagnosisGridView.Rows[e.RowIndex];


                if (selectedRow.Cells.Count > 0 && selectedRow.Cells[0].Value != null)
                {
                    diagnosisIdTextBox.Text = selectedRow.Cells[0].Value.ToString();
                    patientIdComboBox.SelectedValue = selectedRow.Cells[1].Value.ToString();
                    patientNameTextBox.Text = selectedRow.Cells[2].Value.ToString();
                    symptomsTextBox.Text = selectedRow.Cells[3].Value.ToString();
                    diagnosisTextBox.Text = selectedRow.Cells[4].Value.ToString();
                    medicinesTextBox.Text = selectedRow.Cells[5].Value.ToString();


                    pNameLabel.Text = selectedRow.Cells[2].Value.ToString();
                    dLabel.Text = selectedRow.Cells[3].Value.ToString();
                    sLabel.Text = selectedRow.Cells[4].Value.ToString();
                    mLabel.Text = selectedRow.Cells[5].Value.ToString();
                }
                else
                {
                    MessageBox.Show("The selected row does not contain valid data.");
                }
            }
            else
            {
                MessageBox.Show("Please click on a valid cell in the table.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTbl set PatId = " + patientIdComboBox.SelectedValue.ToString() + ", PatName = '" + patientNameTextBox.Text + "', Symptoms = '" + symptomsTextBox.Text + "', Diagnosis = '" + diagnosisTextBox.Text + "', Medicines = '" + medicinesTextBox.Text + "' where DiagId = " + diagnosisIdTextBox.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Successfully Updated!");
            Con.Close();
            populate();
        }

        private void printDiagnosis_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(summaryLabel.Text + "\n\n\n\n\n\n\n\n\n\n\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(pNameLabel.Text + "\n" + dLabel.Text + "\n" + sLabel.Text + "\n" + mLabel.Text + "\n", new Font("Century Gothic", 20, FontStyle.Regular), Brushes.Black, new Point(130, 150));
            e.Graphics.DrawString(label15.Text + "\n\t", new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Red, new Point(230, 380));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialogDiagnosis.ShowDialog() == DialogResult.OK)
            {
                printDiagnosis.Print();
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
