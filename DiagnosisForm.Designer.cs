namespace HospitalManagementSystem
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            panel1 = new Panel();
            diagnoseLabel = new Label();
            hospitalNameLabel = new Label();
            diagnosisIdLabel = new Label();
            diagnosisIdTextBox = new TextBox();
            patientIdComboBox = new ComboBox();
            patientNameTextBox = new TextBox();
            patientNameLabel = new Label();
            symptomsLabel = new Label();
            symptomsTextBox = new TextBox();
            diagnosisTextBox = new TextBox();
            diagnosisLabel = new Label();
            medicinesLabel = new Label();
            medicinesTextBox = new TextBox();
            btnAdd = new Button();
            btnHome = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            diagnosisGridView = new DataGridView();
            patientListLabel = new Label();
            summaryPanel = new Panel();
            btnPrint = new Button();
            label15 = new Label();
            exitLabel = new Label();
            dLabel = new Label();
            mLabel = new Label();
            sLabel = new Label();
            pNameLabel = new Label();
            summaryLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            printDiagnosis = new System.Drawing.Printing.PrintDocument();
            printPreviewDialogDiagnosis = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)diagnosisGridView).BeginInit();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(diagnoseLabel);
            panel1.Controls.Add(hospitalNameLabel);
            panel1.Controls.Add(exitLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1951, 151);
            panel1.TabIndex = 2;
            // 
            // diagnoseLabel
            // 
            diagnoseLabel.AutoSize = true;
            diagnoseLabel.Font = new Font("Footlight MT Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diagnoseLabel.ForeColor = Color.White;
            diagnoseLabel.Location = new Point(879, 86);
            diagnoseLabel.Name = "diagnoseLabel";
            diagnoseLabel.Size = new Size(257, 51);
            diagnoseLabel.TabIndex = 2;
            diagnoseLabel.Text = "DIAGNOSIS";
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
            // diagnosisIdLabel
            // 
            diagnosisIdLabel.AutoSize = true;
            diagnosisIdLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diagnosisIdLabel.Location = new Point(41, 167);
            diagnosisIdLabel.Name = "diagnosisIdLabel";
            diagnosisIdLabel.Size = new Size(188, 34);
            diagnosisIdLabel.TabIndex = 3;
            diagnosisIdLabel.Text = "Diagnosis Id:";
            // 
            // diagnosisIdTextBox
            // 
            diagnosisIdTextBox.Location = new Point(41, 204);
            diagnosisIdTextBox.Name = "diagnosisIdTextBox";
            diagnosisIdTextBox.Size = new Size(312, 39);
            diagnosisIdTextBox.TabIndex = 8;
            diagnosisIdTextBox.TextChanged += diagnosisIdTextBox_TextChanged;
            // 
            // patientIdComboBox
            // 
            patientIdComboBox.Font = new Font("Footlight MT Light", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientIdComboBox.ForeColor = Color.FromArgb(64, 64, 64);
            patientIdComboBox.FormattingEnabled = true;
            patientIdComboBox.Location = new Point(41, 262);
            patientIdComboBox.Name = "patientIdComboBox";
            patientIdComboBox.Size = new Size(312, 37);
            patientIdComboBox.TabIndex = 13;
            patientIdComboBox.Text = "PatientID";
            patientIdComboBox.SelectionChangeCommitted += patientIdComboBox_SelectionChangeCommitted;
            // 
            // patientNameTextBox
            // 
            patientNameTextBox.Enabled = false;
            patientNameTextBox.Location = new Point(41, 348);
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.Size = new Size(312, 39);
            patientNameTextBox.TabIndex = 14;
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameLabel.Location = new Point(41, 311);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(197, 34);
            patientNameLabel.TabIndex = 15;
            patientNameLabel.Text = "Patient Name:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            symptomsLabel.Location = new Point(445, 167);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new Size(158, 34);
            symptomsLabel.TabIndex = 16;
            symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.Location = new Point(445, 204);
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.Size = new Size(312, 39);
            symptomsTextBox.TabIndex = 17;
            // 
            // diagnosisTextBox
            // 
            diagnosisTextBox.Location = new Point(445, 299);
            diagnosisTextBox.Name = "diagnosisTextBox";
            diagnosisTextBox.Size = new Size(312, 39);
            diagnosisTextBox.TabIndex = 18;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diagnosisLabel.Location = new Point(445, 261);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new Size(153, 34);
            diagnosisLabel.TabIndex = 19;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // medicinesLabel
            // 
            medicinesLabel.AutoSize = true;
            medicinesLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medicinesLabel.Location = new Point(445, 364);
            medicinesLabel.Name = "medicinesLabel";
            medicinesLabel.Size = new Size(158, 34);
            medicinesLabel.TabIndex = 20;
            medicinesLabel.Text = "Medicines:";
            // 
            // medicinesTextBox
            // 
            medicinesTextBox.Location = new Point(445, 401);
            medicinesTextBox.Name = "medicinesTextBox";
            medicinesTextBox.Size = new Size(312, 39);
            medicinesTextBox.TabIndex = 21;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumTurquoise;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(53, 484);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 71);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.MediumTurquoise;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(254, 561);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(195, 71);
            btnHome.TabIndex = 23;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumTurquoise;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(455, 484);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(195, 71);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumTurquoise;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(254, 484);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(195, 71);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // diagnosisGridView
            // 
            diagnosisGridView.AllowUserToOrderColumns = true;
            diagnosisGridView.BackgroundColor = Color.White;
            diagnosisGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            diagnosisGridView.Location = new Point(41, 699);
            diagnosisGridView.Name = "diagnosisGridView";
            diagnosisGridView.RowHeadersWidth = 82;
            diagnosisGridView.Size = new Size(1880, 389);
            diagnosisGridView.TabIndex = 26;
            diagnosisGridView.CellContentClick += diagnosisGridView_CellContentClick;
            // 
            // patientListLabel
            // 
            patientListLabel.AutoSize = true;
            patientListLabel.BackColor = Color.Transparent;
            patientListLabel.Font = new Font("Footlight MT Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientListLabel.ForeColor = Color.MediumTurquoise;
            patientListLabel.Location = new Point(790, 635);
            patientListLabel.Name = "patientListLabel";
            patientListLabel.Size = new Size(353, 51);
            patientListLabel.TabIndex = 27;
            patientListLabel.Text = "DIAGNOSIS LIST";
            // 
            // summaryPanel
            // 
            summaryPanel.Controls.Add(btnPrint);
            summaryPanel.Controls.Add(label15);
            summaryPanel.Controls.Add(dLabel);
            summaryPanel.Controls.Add(mLabel);
            summaryPanel.Controls.Add(sLabel);
            summaryPanel.Controls.Add(pNameLabel);
            summaryPanel.Controls.Add(summaryLabel);
            summaryPanel.Location = new Point(817, 180);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(1104, 435);
            summaryPanel.TabIndex = 28;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.MediumTurquoise;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Footlight MT Light", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(544, 364);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(137, 50);
            btnPrint.TabIndex = 29;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Footlight MT Light", 9F);
            label15.ForeColor = Color.MediumTurquoise;
            label15.Location = new Point(700, 381);
            label15.Name = "label15";
            label15.Size = new Size(377, 25);
            label15.TabIndex = 9;
            label15.Text = "Guardian Angel-by Gunel Alkhasova";
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Arial Narrow", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = Color.White;
            exitLabel.Location = new Point(1909, 0);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(39, 43);
            exitLabel.TabIndex = 8;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            // 
            // dLabel
            // 
            dLabel.AutoSize = true;
            dLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dLabel.ForeColor = Color.MediumTurquoise;
            dLabel.Location = new Point(578, 119);
            dLabel.Name = "dLabel";
            dLabel.Size = new Size(145, 34);
            dLabel.TabIndex = 7;
            dLabel.Text = "Diagnosis";
            // 
            // mLabel
            // 
            mLabel.AutoSize = true;
            mLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mLabel.ForeColor = Color.MediumTurquoise;
            mLabel.Location = new Point(578, 266);
            mLabel.Name = "mLabel";
            mLabel.Size = new Size(150, 34);
            mLabel.TabIndex = 6;
            mLabel.Text = "Medicines";
            // 
            // sLabel
            // 
            sLabel.AutoSize = true;
            sLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sLabel.ForeColor = Color.MediumTurquoise;
            sLabel.Location = new Point(62, 266);
            sLabel.Name = "sLabel";
            sLabel.Size = new Size(150, 34);
            sLabel.TabIndex = 5;
            sLabel.Text = "Symptoms";
            // 
            // pNameLabel
            // 
            pNameLabel.AutoSize = true;
            pNameLabel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pNameLabel.ForeColor = Color.MediumTurquoise;
            pNameLabel.Location = new Point(62, 119);
            pNameLabel.Name = "pNameLabel";
            pNameLabel.Size = new Size(189, 34);
            pNameLabel.TabIndex = 4;
            pNameLabel.Text = "Patient Name";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Footlight MT Light", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            summaryLabel.ForeColor = Color.MediumTurquoise;
            summaryLabel.Location = new Point(345, 17);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(438, 46);
            summaryLabel.TabIndex = 3;
            summaryLabel.Text = "DIAGNOSIS SUMMARY";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // printDiagnosis
            // 
            printDiagnosis.PrintPage += printDiagnosis_PrintPage;
            // 
            // printPreviewDialogDiagnosis
            // 
            printPreviewDialogDiagnosis.AutoScrollMargin = new Size(0, 0);
            printPreviewDialogDiagnosis.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialogDiagnosis.ClientSize = new Size(400, 300);
            printPreviewDialogDiagnosis.Document = printDiagnosis;
            printPreviewDialogDiagnosis.Enabled = true;
            printPreviewDialogDiagnosis.Icon = (Icon)resources.GetObject("printPreviewDialogDiagnosis.Icon");
            printPreviewDialogDiagnosis.Name = "printPreviewDialog1";
            printPreviewDialogDiagnosis.Visible = false;
            // 
            // DiagnosisForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1951, 1100);
            Controls.Add(summaryPanel);
            Controls.Add(patientListLabel);
            Controls.Add(diagnosisGridView);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnHome);
            Controls.Add(btnAdd);
            Controls.Add(medicinesTextBox);
            Controls.Add(medicinesLabel);
            Controls.Add(diagnosisLabel);
            Controls.Add(diagnosisTextBox);
            Controls.Add(symptomsTextBox);
            Controls.Add(symptomsLabel);
            Controls.Add(patientNameLabel);
            Controls.Add(patientNameTextBox);
            Controls.Add(patientIdComboBox);
            Controls.Add(diagnosisIdTextBox);
            Controls.Add(diagnosisIdLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiagnosisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiagnosisForm";
            Load += DiagnosisForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)diagnosisGridView).EndInit();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label diagnoseLabel;
        private Label hospitalNameLabel;
        private Label diagnosisIdLabel;
        private TextBox diagnosisIdTextBox;
        private ComboBox patientIdComboBox;
        private TextBox patientNameTextBox;
        private Label patientNameLabel;
        private Label symptomsLabel;
        private TextBox symptomsTextBox;
        private TextBox diagnosisTextBox;
        private Label diagnosisLabel;
        private Label medicinesLabel;
        private TextBox medicinesTextBox;
        private Button btnAdd;
        private Button btnHome;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView diagnosisGridView;
        private Label patientListLabel;
        private Panel summaryPanel;
        private Label pNameLabel;
        private Label summaryLabel;
        private Label sLabel;
        private Label exitLabel;
        private Label dLabel;
        private Label mLabel;
        private Label label15;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDiagnosis;
        private PrintPreviewDialog printPreviewDialogDiagnosis;
    }
}