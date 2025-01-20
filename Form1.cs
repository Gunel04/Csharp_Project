using System.Data;
using Microsoft.Data.SqlClient;
namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NCMM5OU;Initial Catalog=HMSFinalExam;Integrated Security=True;Trust Server Certificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Enter a Username and Password!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTbl where DocName = '"+usernameTextBox.Text+"' and DocPass = '"+passwordTextBox.Text+"' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
                Con.Close();
               
            }
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
