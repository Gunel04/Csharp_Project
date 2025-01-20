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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                splashTimer.Stop();
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.splashTimer.Start();
        }

        
    }
}
