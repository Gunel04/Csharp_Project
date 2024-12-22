namespace HospitalManagementSystem
{
    partial class PatientForm
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
            panel1 = new Panel();
            headerLabel = new Label();
            hospitalNameLabel = new Label();
            patientIdLabel = new Label();
            patientPhoneLabel = new Label();
            patientAddressLabel = new Label();
            patientNameLabel = new Label();
            patientAgeLabel = new Label();
            patientIdTextBox = new TextBox();
            patientPhoneTextBox = new TextBox();
            patientNameTextBox = new TextBox();
            patientAddressTextBox = new TextBox();
            patientAgeTextBox = new TextBox();
            genderComboBox = new ComboBox();
            bloodGrComboBox = new ComboBox();
            patientGridView = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnHome = new Button();
            diseasesLabel = new Label();
            diseasesTextBox = new TextBox();
            patientListLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(headerLabel);
            panel1.Controls.Add(hospitalNameLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1951, 151);
            panel1.TabIndex = 1;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Footlight MT Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(886, 85);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(195, 51);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "PATIENT";
            // 
            // hospitalNameLabel
            // 
            hospitalNameLabel.AutoSize = true;
            hospitalNameLabel.Font = new Font("Footlight MT Light", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hospitalNameLabel.ForeColor = Color.White;
            hospitalNameLabel.Location = new Point(683, 9);
            hospitalNameLabel.Name = "hospitalNameLabel";
            hospitalNameLabel.Size = new Size(629, 63);
            hospitalNameLabel.TabIndex = 1;
            hospitalNameLabel.Text = "Guardian Angel Hospital";
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdLabel.Location = new Point(51, 168);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(147, 34);
            patientIdLabel.TabIndex = 2;
            patientIdLabel.Text = "Patient Id:";
            // 
            // patientPhoneLabel
            // 
            patientPhoneLabel.AutoSize = true;
            patientPhoneLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientPhoneLabel.Location = new Point(51, 430);
            patientPhoneLabel.Name = "patientPhoneLabel";
            patientPhoneLabel.Size = new Size(201, 34);
            patientPhoneLabel.TabIndex = 3;
            patientPhoneLabel.Text = "Patient Phone:";
            // 
            // patientAddressLabel
            // 
            patientAddressLabel.AutoSize = true;
            patientAddressLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientAddressLabel.Location = new Point(51, 252);
            patientAddressLabel.Name = "patientAddressLabel";
            patientAddressLabel.Size = new Size(224, 34);
            patientAddressLabel.TabIndex = 4;
            patientAddressLabel.Text = "Patient Address:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(51, 336);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(197, 34);
            patientNameLabel.TabIndex = 5;
            patientNameLabel.Text = "Patient Name:";
            // 
            // patientAgeLabel
            // 
            patientAgeLabel.AutoSize = true;
            patientAgeLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientAgeLabel.Location = new Point(51, 525);
            patientAgeLabel.Name = "patientAgeLabel";
            patientAgeLabel.Size = new Size(169, 34);
            patientAgeLabel.TabIndex = 6;
            patientAgeLabel.Text = "Patient Age:";
            patientAgeLabel.Click += label7_Click;
            // 
            // patientIdTextBox
            // 
            patientIdTextBox.Location = new Point(51, 210);
            patientIdTextBox.Name = "patientIdTextBox";
            patientIdTextBox.Size = new Size(312, 39);
            patientIdTextBox.TabIndex = 7;
            // 
            // patientPhoneTextBox
            // 
            patientPhoneTextBox.Location = new Point(51, 472);
            patientPhoneTextBox.Name = "patientPhoneTextBox";
            patientPhoneTextBox.Size = new Size(312, 39);
            patientPhoneTextBox.TabIndex = 8;
            // 
            // patientNameTextBox
            // 
            patientNameTextBox.Location = new Point(51, 378);
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.Size = new Size(312, 39);
            patientNameTextBox.TabIndex = 9;
            patientNameTextBox.TextChanged += patientNameTextBox_TextChanged;
            // 
            // patientAddressTextBox
            // 
            patientAddressTextBox.Location = new Point(51, 294);
            patientAddressTextBox.Name = "patientAddressTextBox";
            patientAddressTextBox.Size = new Size(312, 39);
            patientAddressTextBox.TabIndex = 10;
            patientAddressTextBox.TextChanged += textBox4_TextChanged;
            // 
            // patientAgeTextBox
            // 
            patientAgeTextBox.Location = new Point(51, 567);
            patientAgeTextBox.Name = "patientAgeTextBox";
            patientAgeTextBox.Size = new Size(312, 39);
            patientAgeTextBox.TabIndex = 11;
            // 
            // genderComboBox
            // 
            genderComboBox.Font = new Font("Footlight MT Light", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderComboBox.ForeColor = Color.FromArgb(64, 64, 64);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(51, 629);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(312, 37);
            genderComboBox.TabIndex = 12;
            genderComboBox.Text = "Gender";
            // 
            // bloodGrComboBox
            // 
            bloodGrComboBox.Font = new Font("Footlight MT Light", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bloodGrComboBox.ForeColor = Color.FromArgb(64, 64, 64);
            bloodGrComboBox.FormattingEnabled = true;
            bloodGrComboBox.Items.AddRange(new object[] { "+1", "+2", "+3", "+4", "-1", "-2", "-3", "-4" });
            bloodGrComboBox.Location = new Point(51, 688);
            bloodGrComboBox.Name = "bloodGrComboBox";
            bloodGrComboBox.Size = new Size(312, 37);
            bloodGrComboBox.TabIndex = 13;
            bloodGrComboBox.Text = "Blood Group";
            // 
            // patientGridView
            // 
            patientGridView.AllowUserToOrderColumns = true;
            patientGridView.BackgroundColor = Color.White;
            patientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGridView.Location = new Point(683, 239);
            patientGridView.Name = "patientGridView";
            patientGridView.RowHeadersWidth = 82;
            patientGridView.Size = new Size(1234, 745);
            patientGridView.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumTurquoise;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(51, 826);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 71);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumTurquoise;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(453, 826);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 71);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumTurquoise;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(252, 826);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(195, 71);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.MediumTurquoise;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(252, 940);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(195, 71);
            btnHome.TabIndex = 18;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // diseasesLabel
            // 
            diseasesLabel.AutoSize = true;
            diseasesLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diseasesLabel.Location = new Point(51, 733);
            diseasesLabel.Name = "diseasesLabel";
            diseasesLabel.Size = new Size(222, 34);
            diseasesLabel.TabIndex = 19;
            diseasesLabel.Text = "Major Diseases:";
            // 
            // diseasesTextBox
            // 
            diseasesTextBox.Location = new Point(51, 770);
            diseasesTextBox.Name = "diseasesTextBox";
            diseasesTextBox.Size = new Size(312, 39);
            diseasesTextBox.TabIndex = 20;
            // 
            // patientListLabel
            // 
            patientListLabel.AutoSize = true;
            patientListLabel.BackColor = Color.Transparent;
            patientListLabel.Font = new Font("Footlight MT Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientListLabel.ForeColor = Color.MediumTurquoise;
            patientListLabel.Location = new Point(1157, 168);
            patientListLabel.Name = "patientListLabel";
            patientListLabel.Size = new Size(312, 51);
            patientListLabel.TabIndex = 3;
            patientListLabel.Text = "PATIENTS LIST";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1951, 1100);
            Controls.Add(patientListLabel);
            Controls.Add(diseasesTextBox);
            Controls.Add(diseasesLabel);
            Controls.Add(btnHome);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(patientGridView);
            Controls.Add(bloodGrComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(patientAgeTextBox);
            Controls.Add(patientAddressTextBox);
            Controls.Add(patientNameTextBox);
            Controls.Add(patientPhoneTextBox);
            Controls.Add(patientIdTextBox);
            Controls.Add(patientAgeLabel);
            Controls.Add(patientNameLabel);
            Controls.Add(patientAddressLabel);
            Controls.Add(patientPhoneLabel);
            Controls.Add(patientIdLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label headerLabel;
        private Label hospitalNameLabel;
        private Label patientIdLabel;
        private Label patientPhoneLabel;
        private Label patientAddressLabel;
        private Label patientNameLabel;
        private Label patientAgeLabel;
        private TextBox patientIdTextBox;
        private TextBox patientPhoneTextBox;
        private TextBox patientNameTextBox;
        private TextBox patientAddressTextBox;
        private TextBox patientAgeTextBox;
        private ComboBox genderComboBox;
        private ComboBox bloodGrComboBox;
        private DataGridView patientGridView;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnHome;
        private Label diseasesLabel;
        private TextBox diseasesTextBox;
        private Label patientListLabel;
    }
}