namespace HospitalManagementSystem
{
    partial class PatientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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
            diseasesLabel = new Label();
            diseasesTextBox = new TextBox();
            patientListLabel = new Label();
            patientGridView = new DataGridView();
            btnHome = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            exitLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(exitLabel);
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
            headerLabel.Font = new Font("Footlight MT Light", 18F);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(863, 82);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(216, 51);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "PATIENTS";
            // 
            // hospitalNameLabel
            // 
            hospitalNameLabel.AutoSize = true;
            hospitalNameLabel.Font = new Font("Footlight MT Light", 22.125F);
            hospitalNameLabel.ForeColor = Color.White;
            hospitalNameLabel.Location = new Point(683, 9);
            hospitalNameLabel.Name = "hospitalNameLabel";
            hospitalNameLabel.Size = new Size(629, 63);
            hospitalNameLabel.TabIndex = 1;
            hospitalNameLabel.Text = "Guardian Angel Hospital";
            // 
            // patientIdLabel
            // 
            patientIdLabel.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdLabel.Location = new Point(34, 167);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(217, 38);
            patientIdLabel.TabIndex = 39;
            patientIdLabel.Text = "Patient ID:";
            // 
            // patientPhoneLabel
            // 
            patientPhoneLabel.Font = new Font("Footlight MT Light", 13.875F);
            patientPhoneLabel.Location = new Point(34, 443);
            patientPhoneLabel.Name = "patientPhoneLabel";
            patientPhoneLabel.Size = new Size(289, 42);
            patientPhoneLabel.TabIndex = 38;
            patientPhoneLabel.Text = "Patient Phone:";
            // 
            // patientAddressLabel
            // 
            patientAddressLabel.Font = new Font("Footlight MT Light", 13.875F);
            patientAddressLabel.Location = new Point(34, 349);
            patientAddressLabel.Name = "patientAddressLabel";
            patientAddressLabel.Size = new Size(310, 36);
            patientAddressLabel.TabIndex = 37;
            patientAddressLabel.Text = "Patient Address:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.Font = new Font("Footlight MT Light", 13.875F);
            patientNameLabel.Location = new Point(34, 261);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(251, 43);
            patientNameLabel.TabIndex = 36;
            patientNameLabel.Text = "Patient Name:";
            // 
            // patientAgeLabel
            // 
            patientAgeLabel.Font = new Font("Footlight MT Light", 13.875F);
            patientAgeLabel.Location = new Point(34, 531);
            patientAgeLabel.Name = "patientAgeLabel";
            patientAgeLabel.Size = new Size(254, 52);
            patientAgeLabel.TabIndex = 35;
            patientAgeLabel.Text = "Patient Age:";
            // 
            // patientIdTextBox
            // 
            patientIdTextBox.Location = new Point(37, 208);
            patientIdTextBox.Name = "patientIdTextBox";
            patientIdTextBox.Size = new Size(336, 39);
            patientIdTextBox.TabIndex = 34;
            // 
            // patientPhoneTextBox
            // 
            patientPhoneTextBox.Location = new Point(37, 488);
            patientPhoneTextBox.Name = "patientPhoneTextBox";
            patientPhoneTextBox.Size = new Size(336, 39);
            patientPhoneTextBox.TabIndex = 33;
            // 
            // patientNameTextBox
            // 
            patientNameTextBox.Location = new Point(34, 307);
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.Size = new Size(339, 39);
            patientNameTextBox.TabIndex = 32;
            // 
            // patientAddressTextBox
            // 
            patientAddressTextBox.Location = new Point(34, 388);
            patientAddressTextBox.Name = "patientAddressTextBox";
            patientAddressTextBox.Size = new Size(339, 39);
            patientAddressTextBox.TabIndex = 31;
            patientAddressTextBox.TextChanged += patientAddressTextBox_TextChanged;
            // 
            // patientAgeTextBox
            // 
            patientAgeTextBox.Location = new Point(37, 572);
            patientAgeTextBox.Name = "patientAgeTextBox";
            patientAgeTextBox.Size = new Size(336, 39);
            patientAgeTextBox.TabIndex = 30;
            // 
            // genderComboBox
            // 
            genderComboBox.Font = new Font("Footlight MT Light", 10F);
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(37, 629);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(336, 37);
            genderComboBox.TabIndex = 29;
            genderComboBox.Text = "Gender";
            // 
            // bloodGrComboBox
            // 
            bloodGrComboBox.Font = new Font("Footlight MT Light", 10F);
            bloodGrComboBox.Items.AddRange(new object[] { "+1", "+2", "+3", "+4", "-1", "-2", "-3", "-4" });
            bloodGrComboBox.Location = new Point(37, 683);
            bloodGrComboBox.Name = "bloodGrComboBox";
            bloodGrComboBox.Size = new Size(336, 37);
            bloodGrComboBox.TabIndex = 28;
            bloodGrComboBox.Text = "Blood Group";
            // 
            // diseasesLabel
            // 
            diseasesLabel.Font = new Font("Footlight MT Light", 13.875F);
            diseasesLabel.Location = new Point(37, 734);
            diseasesLabel.Name = "diseasesLabel";
            diseasesLabel.Size = new Size(307, 50);
            diseasesLabel.TabIndex = 23;
            diseasesLabel.Text = "Major Diseases:";
            // 
            // diseasesTextBox
            // 
            diseasesTextBox.Location = new Point(40, 787);
            diseasesTextBox.Name = "diseasesTextBox";
            diseasesTextBox.Size = new Size(333, 39);
            diseasesTextBox.TabIndex = 22;
            // 
            // patientListLabel
            // 
            patientListLabel.Font = new Font("Footlight MT Light", 20F);
            patientListLabel.ForeColor = Color.MediumTurquoise;
            patientListLabel.Location = new Point(1018, 167);
            patientListLabel.Name = "patientListLabel";
            patientListLabel.Size = new Size(353, 63);
            patientListLabel.TabIndex = 0;
            patientListLabel.Text = "PATIENTS LIST";
            // 
            // patientGridView
            // 
            patientGridView.BackgroundColor = Color.White;
            patientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGridView.Location = new Point(464, 233);
            patientGridView.Name = "patientGridView";
            patientGridView.RowHeadersWidth = 82;
            patientGridView.Size = new Size(1475, 767);
            patientGridView.TabIndex = 21;
            patientGridView.CellContentClick += patientGridView_CellContentClick;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.MediumTurquoise;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(128, 925);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(146, 71);
            btnHome.TabIndex = 43;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumTurquoise;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(280, 848);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 71);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumTurquoise;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(128, 848);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 71);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumTurquoise;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(12, 848);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 71);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Arial Narrow", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(1909, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(39, 43);
            exitLabel.TabIndex = 9;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1951, 1100);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(patientListLabel);
            Controls.Add(patientGridView);
            Controls.Add(diseasesTextBox);
            Controls.Add(diseasesLabel);
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
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)patientGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label hospitalNameLabel;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Label patientPhoneLabel;
        private System.Windows.Forms.Label patientAddressLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientAgeLabel;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.TextBox patientPhoneTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox patientAddressTextBox;
        private System.Windows.Forms.TextBox patientAgeTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox bloodGrComboBox;
        private System.Windows.Forms.Label diseasesLabel;
        private System.Windows.Forms.TextBox diseasesTextBox;
        private System.Windows.Forms.Label patientListLabel;
        private System.Windows.Forms.DataGridView patientGridView;
        private Button btnHome;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label exitLabel;
    }
}
