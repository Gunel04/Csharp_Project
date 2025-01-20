namespace HospitalManagementSystem
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            progressBar = new ProgressBar();
            label2 = new Label();
            splashTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 20);
            label1.Name = "label1";
            label1.Size = new Size(629, 63);
            label1.TabIndex = 2;
            label1.Text = "Guardian Angel Hospital";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(135, 341);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(629, 37);
            progressBar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(275, 99);
            label2.Name = "label2";
            label2.Size = new Size(329, 41);
            label2.TabIndex = 4;
            label2.Text = "by Gunel Alkhasova";
            // 
            // splashTimer
            // 
            splashTimer.Tick += splashTimer_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(867, 642);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar;
        private Label label2;
        private System.Windows.Forms.Timer splashTimer;
    }
}