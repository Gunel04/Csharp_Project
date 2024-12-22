namespace HospitalManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            btnLogin = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            clearLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            exitLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(exitLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 180);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(174, 49);
            label1.Name = "label1";
            label1.Size = new Size(575, 58);
            label1.TabIndex = 0;
            label1.Text = "Guardian Angel Hospital";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumTurquoise;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Footlight MT Light", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(248, 479);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(363, 82);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.MediumTurquoise;
            usernameLabel.Location = new Point(248, 227);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(179, 39);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.MediumTurquoise;
            passwordLabel.Location = new Point(248, 337);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(169, 39);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.Font = new Font("Footlight MT Light", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearLabel.ForeColor = Color.MediumTurquoise;
            clearLabel.Location = new Point(388, 579);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(78, 32);
            clearLabel.TabIndex = 6;
            clearLabel.Text = "Clear";
            clearLabel.Click += clearLabel_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(248, 269);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(363, 39);
            usernameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(248, 379);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(363, 39);
            passwordTextBox.TabIndex = 8;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(816, 9);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(44, 44);
            exitLabel.TabIndex = 1;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(867, 642);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(clearLabel);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogin;
        private MaskedTextBox maskedTextBox1;
        private Label usernameLabel;
        private Label passwordLabel;
        private MaskedTextBox maskedTextBox2;
        private Label clearLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label exitLabel;
    }
}
