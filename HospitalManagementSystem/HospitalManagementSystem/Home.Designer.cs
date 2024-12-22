namespace HospitalManagementSystem
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            doctorPictureBox = new PictureBox();
            doctorLabel = new Label();
            patientLabel = new Label();
            patientPictureBox = new PictureBox();
            diagnosisPictureBox = new PictureBox();
            diagnosisLabel = new Label();
            logOut = new PictureBox();
            logOutLabel = new Label();
            mottoLabel = new Label();
            motto2Label = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)doctorPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diagnosisPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logOut).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Footlight MT Light", 28F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(511, 29);
            label1.Name = "label1";
            label1.Size = new Size(967, 80);
            label1.TabIndex = 0;
            label1.Text = "GUARDIAN ANGEL HOSPITAL";
            label1.Click += label1_Click;
            // 
            // doctorPictureBox
            // 
            doctorPictureBox.BackColor = Color.White;
            doctorPictureBox.Image = (Image)resources.GetObject("doctorPictureBox.Image");
            doctorPictureBox.Location = new Point(184, 264);
            doctorPictureBox.Name = "doctorPictureBox";
            doctorPictureBox.Size = new Size(156, 142);
            doctorPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            doctorPictureBox.TabIndex = 1;
            doctorPictureBox.TabStop = false;
            doctorPictureBox.Click += doctorPictureBox_Click;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Footlight MT Light", 18F);
            doctorLabel.ForeColor = Color.White;
            doctorLabel.Location = new Point(158, 200);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(228, 51);
            doctorLabel.TabIndex = 2;
            doctorLabel.Text = "DOCTORS";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Font = new Font("Footlight MT Light", 18F);
            patientLabel.ForeColor = Color.White;
            patientLabel.Location = new Point(158, 454);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new Size(216, 51);
            patientLabel.TabIndex = 3;
            patientLabel.Text = "PATIENTS";
            // 
            // patientPictureBox
            // 
            patientPictureBox.Image = (Image)resources.GetObject("patientPictureBox.Image");
            patientPictureBox.Location = new Point(184, 527);
            patientPictureBox.Name = "patientPictureBox";
            patientPictureBox.Size = new Size(156, 142);
            patientPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            patientPictureBox.TabIndex = 4;
            patientPictureBox.TabStop = false;
            patientPictureBox.Click += patientPictureBox_Click;
            // 
            // diagnosisPictureBox
            // 
            diagnosisPictureBox.Image = (Image)resources.GetObject("diagnosisPictureBox.Image");
            diagnosisPictureBox.Location = new Point(577, 419);
            diagnosisPictureBox.Name = "diagnosisPictureBox";
            diagnosisPictureBox.Size = new Size(156, 142);
            diagnosisPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            diagnosisPictureBox.TabIndex = 5;
            diagnosisPictureBox.TabStop = false;
            diagnosisPictureBox.Click += diagnosisPictureBox_Click;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new Font("Footlight MT Light", 18F);
            diagnosisLabel.ForeColor = Color.White;
            diagnosisLabel.Location = new Point(532, 355);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new Size(251, 51);
            diagnosisLabel.TabIndex = 6;
            diagnosisLabel.Text = "DİAGNOSİS";
            diagnosisLabel.Click += diagnosisLabel_Click;
            // 
            // logOut
            // 
            logOut.BackColor = Color.Transparent;
            logOut.Image = (Image)resources.GetObject("logOut.Image");
            logOut.Location = new Point(204, 796);
            logOut.Name = "logOut";
            logOut.Size = new Size(118, 114);
            logOut.SizeMode = PictureBoxSizeMode.StretchImage;
            logOut.TabIndex = 7;
            logOut.TabStop = false;
            logOut.Click += logOut_Click;
            // 
            // logOutLabel
            // 
            logOutLabel.AutoSize = true;
            logOutLabel.Font = new Font("Footlight MT Light", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOutLabel.ForeColor = Color.White;
            logOutLabel.Location = new Point(213, 922);
            logOutLabel.Name = "logOutLabel";
            logOutLabel.Size = new Size(109, 32);
            logOutLabel.TabIndex = 9;
            logOutLabel.Text = "Log Out";
            // 
            // mottoLabel
            // 
            mottoLabel.AutoSize = true;
            mottoLabel.Font = new Font("Footlight MT Light", 26F, FontStyle.Italic);
            mottoLabel.ForeColor = Color.White;
            mottoLabel.Location = new Point(1032, 331);
            mottoLabel.Name = "mottoLabel";
            mottoLabel.Size = new Size(810, 75);
            mottoLabel.TabIndex = 10;
            mottoLabel.Text = "Your health is your power!";
            // 
            // motto2Label
            // 
            motto2Label.AutoSize = true;
            motto2Label.Font = new Font("Footlight MT Light", 26F, FontStyle.Italic);
            motto2Label.ForeColor = Color.White;
            motto2Label.Location = new Point(975, 454);
            motto2Label.Name = "motto2Label";
            motto2Label.Size = new Size(922, 75);
            motto2Label.TabIndex = 11;
            motto2Label.Text = "Eat well, move often, live fully!";
            motto2Label.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 26F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1067, 594);
            label2.Name = "label2";
            label2.Size = new Size(723, 75);
            label2.TabIndex = 12;
            label2.Text = "Strong body, strong life!";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1951, 1100);
            Controls.Add(label2);
            Controls.Add(motto2Label);
            Controls.Add(mottoLabel);
            Controls.Add(logOutLabel);
            Controls.Add(logOut);
            Controls.Add(diagnosisLabel);
            Controls.Add(diagnosisPictureBox);
            Controls.Add(patientPictureBox);
            Controls.Add(patientLabel);
            Controls.Add(doctorLabel);
            Controls.Add(doctorPictureBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)doctorPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)diagnosisPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox doctorPictureBox;
        private Label doctorLabel;
        private Label patientLabel;
        private PictureBox patientPictureBox;
        private PictureBox diagnosisPictureBox;
        private Label diagnosisLabel;
        private PictureBox logOut;
        private Label logOutLabel;
        private Label mottoLabel;
        private Label motto2Label;
        private Label label2;
    }
}