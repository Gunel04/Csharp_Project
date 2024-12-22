namespace HospitalManagementSystem
{
    partial class DoctorForm
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
            label2 = new Label();
            label1 = new Label();
            doctorIdLabel = new Label();
            doctorIdTextBox = new TextBox();
            doctorNameLabel = new Label();
            doctorNameTextBox = new TextBox();
            yearsTextBox = new TextBox();
            yearsLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            doctorGridView = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnHome = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1951, 151);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(877, 84);
            label2.Name = "label2";
            label2.Size = new Size(207, 51);
            label2.TabIndex = 2;
            label2.Text = "DOCTOR\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(683, 9);
            label1.Name = "label1";
            label1.Size = new Size(629, 63);
            label1.TabIndex = 1;
            label1.Text = "Guardian Angel Hospital";
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorIdLabel.Location = new Point(38, 179);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(170, 39);
            doctorIdLabel.TabIndex = 1;
            doctorIdLabel.Text = "Doctor Id:";
            // 
            // doctorIdTextBox
            // 
            doctorIdTextBox.Location = new Point(38, 221);
            doctorIdTextBox.Name = "doctorIdTextBox";
            doctorIdTextBox.Size = new Size(312, 39);
            doctorIdTextBox.TabIndex = 2;
            doctorIdTextBox.TextChanged += doctorIdTextBox_TextChanged;
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorNameLabel.Location = new Point(38, 277);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new Size(228, 39);
            doctorNameLabel.TabIndex = 3;
            doctorNameLabel.Text = "Doctor Name:";
            // 
            // doctorNameTextBox
            // 
            doctorNameTextBox.Location = new Point(38, 319);
            doctorNameTextBox.Name = "doctorNameTextBox";
            doctorNameTextBox.Size = new Size(312, 39);
            doctorNameTextBox.TabIndex = 4;
            doctorNameTextBox.TextChanged += doctorNameTextBox_TextChanged;
            // 
            // yearsTextBox
            // 
            yearsTextBox.Location = new Point(38, 421);
            yearsTextBox.Name = "yearsTextBox";
            yearsTextBox.Size = new Size(312, 39);
            yearsTextBox.TabIndex = 5;
            yearsTextBox.TextChanged += yearsTextBox_TextChanged;
            // 
            // yearsLabel
            // 
            yearsLabel.AutoSize = true;
            yearsLabel.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearsLabel.Location = new Point(38, 379);
            yearsLabel.Name = "yearsLabel";
            yearsLabel.Size = new Size(325, 39);
            yearsLabel.TabIndex = 6;
            yearsLabel.Text = "Years of Experience:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(38, 474);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(169, 39);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(38, 516);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(312, 39);
            passwordTextBox.TabIndex = 8;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // doctorGridView
            // 
            doctorGridView.AllowUserToOrderColumns = true;
            doctorGridView.BackgroundColor = Color.White;
            doctorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorGridView.Location = new Point(670, 179);
            doctorGridView.Name = "doctorGridView";
            doctorGridView.RowHeadersWidth = 82;
            doctorGridView.Size = new Size(1234, 729);
            doctorGridView.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumTurquoise;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(38, 699);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 71);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumTurquoise;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(239, 699);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(195, 71);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumTurquoise;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(440, 699);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 71);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.MediumTurquoise;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(239, 837);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(195, 71);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1951, 1100);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(doctorGridView);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(yearsLabel);
            Controls.Add(yearsTextBox);
            Controls.Add(doctorNameTextBox);
            Controls.Add(doctorNameLabel);
            Controls.Add(doctorIdTextBox);
            Controls.Add(doctorIdLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label doctorIdLabel;
        private TextBox doctorIdTextBox;
        private Label doctorNameLabel;
        private TextBox doctorNameTextBox;
        private TextBox yearsTextBox;
        private Label yearsLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private DataGridView doctorGridView;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnHome;
    }
}