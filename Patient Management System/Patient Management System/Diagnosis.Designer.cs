namespace Patient_Management_System
{
    partial class Diagnosis
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            this.label14 = new System.Windows.Forms.Label();
            this.Diagnosis_GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newHMSDataSet1 = new Patient_Management_System.newHMSDataSet1();
            this.Diagnosis_Reset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Diagnosis_Update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Diagnosis_Delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Diagnosis_Add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.D_Med = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.D_Tests = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.D_Symptoms = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.D_PName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.D_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnmax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnmin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.Diagnosis_Report = new Guna.UI2.WinForms.Guna2Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.D_PId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.diagnosisTableAdapter = new Patient_Management_System.newHMSDataSet1TableAdapters.DiagnosisTableAdapter();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Diagnosis_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newHMSDataSet1)).BeginInit();
            this.Diagnosis_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label14.Location = new System.Drawing.Point(257, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 51);
            this.label14.TabIndex = 13;
            this.label14.Text = "Diagnosis";
            // 
            // Diagnosis_GridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Diagnosis_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Diagnosis_GridView.AutoGenerateColumns = false;
            this.Diagnosis_GridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Diagnosis_GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Diagnosis_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Diagnosis_GridView.ColumnHeadersHeight = 48;
            this.Diagnosis_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Diagnosis_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dIdDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.symptomsDataGridViewTextBoxColumn,
            this.testDataGridViewTextBoxColumn,
            this.medicinesDataGridViewTextBoxColumn});
            this.Diagnosis_GridView.DataSource = this.diagnosisBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Diagnosis_GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Diagnosis_GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Diagnosis_GridView.Location = new System.Drawing.Point(515, 457);
            this.Diagnosis_GridView.Name = "Diagnosis_GridView";
            this.Diagnosis_GridView.RowHeadersVisible = false;
            this.Diagnosis_GridView.RowHeadersWidth = 51;
            this.Diagnosis_GridView.RowTemplate.Height = 24;
            this.Diagnosis_GridView.Size = new System.Drawing.Size(890, 312);
            this.Diagnosis_GridView.TabIndex = 67;
            this.Diagnosis_GridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Diagnosis_GridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Diagnosis_GridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Diagnosis_GridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Diagnosis_GridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Diagnosis_GridView.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Diagnosis_GridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Diagnosis_GridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Diagnosis_GridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Diagnosis_GridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis_GridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Diagnosis_GridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Diagnosis_GridView.ThemeStyle.HeaderStyle.Height = 48;
            this.Diagnosis_GridView.ThemeStyle.ReadOnly = false;
            this.Diagnosis_GridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Diagnosis_GridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Diagnosis_GridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Diagnosis_GridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Diagnosis_GridView.ThemeStyle.RowsStyle.Height = 24;
            this.Diagnosis_GridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Diagnosis_GridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Diagnosis_GridView.DoubleClick += new System.EventHandler(this.Diagnosis_GridView_DoubleClick);
            // 
            // dIdDataGridViewTextBoxColumn
            // 
            this.dIdDataGridViewTextBoxColumn.DataPropertyName = "DId";
            this.dIdDataGridViewTextBoxColumn.HeaderText = "Diagnosis Id";
            this.dIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIdDataGridViewTextBoxColumn.Name = "dIdDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "Patient ID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // symptomsDataGridViewTextBoxColumn
            // 
            this.symptomsDataGridViewTextBoxColumn.DataPropertyName = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.HeaderText = "Symptoms";
            this.symptomsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.symptomsDataGridViewTextBoxColumn.Name = "symptomsDataGridViewTextBoxColumn";
            // 
            // testDataGridViewTextBoxColumn
            // 
            this.testDataGridViewTextBoxColumn.DataPropertyName = "Test";
            this.testDataGridViewTextBoxColumn.HeaderText = "Test";
            this.testDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testDataGridViewTextBoxColumn.Name = "testDataGridViewTextBoxColumn";
            // 
            // medicinesDataGridViewTextBoxColumn
            // 
            this.medicinesDataGridViewTextBoxColumn.DataPropertyName = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.HeaderText = "Medicines";
            this.medicinesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicinesDataGridViewTextBoxColumn.Name = "medicinesDataGridViewTextBoxColumn";
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "Diagnosis";
            this.diagnosisBindingSource.DataSource = this.newHMSDataSet1;
            // 
            // newHMSDataSet1
            // 
            this.newHMSDataSet1.DataSetName = "newHMSDataSet1";
            this.newHMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Diagnosis_Reset
            // 
            this.Diagnosis_Reset.AutoRoundedCorners = true;
            this.Diagnosis_Reset.BorderRadius = 21;
            this.Diagnosis_Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Reset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Diagnosis_Reset.FillColor = System.Drawing.Color.Indigo;
            this.Diagnosis_Reset.FillColor2 = System.Drawing.Color.SlateBlue;
            this.Diagnosis_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis_Reset.ForeColor = System.Drawing.Color.White;
            this.Diagnosis_Reset.Location = new System.Drawing.Point(232, 685);
            this.Diagnosis_Reset.Name = "Diagnosis_Reset";
            this.Diagnosis_Reset.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Diagnosis_Reset.Size = new System.Drawing.Size(180, 45);
            this.Diagnosis_Reset.TabIndex = 65;
            this.Diagnosis_Reset.Text = "Reset";
            this.Diagnosis_Reset.Click += new System.EventHandler(this.Diagnosis_Reset_Click);
            // 
            // Diagnosis_Update
            // 
            this.Diagnosis_Update.AutoRoundedCorners = true;
            this.Diagnosis_Update.BorderRadius = 21;
            this.Diagnosis_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Diagnosis_Update.FillColor = System.Drawing.Color.Indigo;
            this.Diagnosis_Update.FillColor2 = System.Drawing.Color.SlateBlue;
            this.Diagnosis_Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis_Update.ForeColor = System.Drawing.Color.White;
            this.Diagnosis_Update.Location = new System.Drawing.Point(33, 685);
            this.Diagnosis_Update.Name = "Diagnosis_Update";
            this.Diagnosis_Update.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Diagnosis_Update.Size = new System.Drawing.Size(180, 45);
            this.Diagnosis_Update.TabIndex = 64;
            this.Diagnosis_Update.Text = "Update";
            this.Diagnosis_Update.Click += new System.EventHandler(this.Diagnosis_Update_Click);
            // 
            // Diagnosis_Delete
            // 
            this.Diagnosis_Delete.AutoRoundedCorners = true;
            this.Diagnosis_Delete.BorderRadius = 21;
            this.Diagnosis_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Diagnosis_Delete.FillColor = System.Drawing.Color.Indigo;
            this.Diagnosis_Delete.FillColor2 = System.Drawing.Color.SlateBlue;
            this.Diagnosis_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis_Delete.ForeColor = System.Drawing.Color.White;
            this.Diagnosis_Delete.Location = new System.Drawing.Point(232, 594);
            this.Diagnosis_Delete.Name = "Diagnosis_Delete";
            this.Diagnosis_Delete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Diagnosis_Delete.Size = new System.Drawing.Size(180, 45);
            this.Diagnosis_Delete.TabIndex = 63;
            this.Diagnosis_Delete.Text = "Delete";
            this.Diagnosis_Delete.Click += new System.EventHandler(this.Diagnosis_Delete_Click);
            // 
            // Diagnosis_Add
            // 
            this.Diagnosis_Add.AutoRoundedCorners = true;
            this.Diagnosis_Add.BorderRadius = 21;
            this.Diagnosis_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Diagnosis_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Diagnosis_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Diagnosis_Add.FillColor = System.Drawing.Color.Indigo;
            this.Diagnosis_Add.FillColor2 = System.Drawing.Color.SlateBlue;
            this.Diagnosis_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis_Add.ForeColor = System.Drawing.Color.White;
            this.Diagnosis_Add.Location = new System.Drawing.Point(33, 594);
            this.Diagnosis_Add.Name = "Diagnosis_Add";
            this.Diagnosis_Add.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Diagnosis_Add.Size = new System.Drawing.Size(180, 45);
            this.Diagnosis_Add.TabIndex = 62;
            this.Diagnosis_Add.Text = "Add";
            this.Diagnosis_Add.Click += new System.EventHandler(this.Diagnosis_Add_Click);
            // 
            // D_Med
            // 
            this.D_Med.AutoRoundedCorners = true;
            this.D_Med.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.D_Med.BorderRadius = 17;
            this.D_Med.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.D_Med.DefaultText = "";
            this.D_Med.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.D_Med.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.D_Med.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Med.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Med.FillColor = System.Drawing.Color.Lavender;
            this.D_Med.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Med.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_Med.ForeColor = System.Drawing.Color.Black;
            this.D_Med.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Med.Location = new System.Drawing.Point(216, 510);
            this.D_Med.Margin = new System.Windows.Forms.Padding(4);
            this.D_Med.Name = "D_Med";
            this.D_Med.PasswordChar = '\0';
            this.D_Med.PlaceholderText = "";
            this.D_Med.SelectedText = "";
            this.D_Med.Size = new System.Drawing.Size(200, 36);
            this.D_Med.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label13.Location = new System.Drawing.Point(46, 510);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 58;
            this.label13.Text = "Medicine";
            // 
            // D_Tests
            // 
            this.D_Tests.AutoRoundedCorners = true;
            this.D_Tests.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.D_Tests.BorderRadius = 17;
            this.D_Tests.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.D_Tests.DefaultText = "";
            this.D_Tests.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.D_Tests.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.D_Tests.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Tests.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Tests.FillColor = System.Drawing.Color.Lavender;
            this.D_Tests.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Tests.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_Tests.ForeColor = System.Drawing.Color.Black;
            this.D_Tests.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Tests.Location = new System.Drawing.Point(216, 457);
            this.D_Tests.Margin = new System.Windows.Forms.Padding(4);
            this.D_Tests.Name = "D_Tests";
            this.D_Tests.PasswordChar = '\0';
            this.D_Tests.PlaceholderText = "";
            this.D_Tests.SelectedText = "";
            this.D_Tests.Size = new System.Drawing.Size(200, 36);
            this.D_Tests.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(46, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tests";
            // 
            // D_Symptoms
            // 
            this.D_Symptoms.AutoRoundedCorners = true;
            this.D_Symptoms.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.D_Symptoms.BorderRadius = 17;
            this.D_Symptoms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.D_Symptoms.DefaultText = "";
            this.D_Symptoms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.D_Symptoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.D_Symptoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Symptoms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Symptoms.FillColor = System.Drawing.Color.Lavender;
            this.D_Symptoms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Symptoms.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_Symptoms.ForeColor = System.Drawing.Color.Black;
            this.D_Symptoms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Symptoms.Location = new System.Drawing.Point(218, 397);
            this.D_Symptoms.Margin = new System.Windows.Forms.Padding(4);
            this.D_Symptoms.Name = "D_Symptoms";
            this.D_Symptoms.PasswordChar = '\0';
            this.D_Symptoms.PlaceholderText = "";
            this.D_Symptoms.SelectedText = "";
            this.D_Symptoms.Size = new System.Drawing.Size(200, 36);
            this.D_Symptoms.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(46, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Symptoms";
            // 
            // D_PName
            // 
            this.D_PName.AutoRoundedCorners = true;
            this.D_PName.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.D_PName.BorderRadius = 17;
            this.D_PName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.D_PName.DefaultText = "";
            this.D_PName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.D_PName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.D_PName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_PName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_PName.FillColor = System.Drawing.Color.Lavender;
            this.D_PName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_PName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_PName.ForeColor = System.Drawing.Color.Black;
            this.D_PName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_PName.Location = new System.Drawing.Point(216, 340);
            this.D_PName.Margin = new System.Windows.Forms.Padding(4);
            this.D_PName.Name = "D_PName";
            this.D_PName.PasswordChar = '\0';
            this.D_PName.PlaceholderText = "";
            this.D_PName.SelectedText = "";
            this.D_PName.Size = new System.Drawing.Size(200, 36);
            this.D_PName.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(46, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Patient Name";
            // 
            // D_Id
            // 
            this.D_Id.AutoRoundedCorners = true;
            this.D_Id.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.D_Id.BorderRadius = 17;
            this.D_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.D_Id.DefaultText = "";
            this.D_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.D_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.D_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.D_Id.FillColor = System.Drawing.Color.Lavender;
            this.D_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Id.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_Id.ForeColor = System.Drawing.Color.Black;
            this.D_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_Id.Location = new System.Drawing.Point(216, 228);
            this.D_Id.Margin = new System.Windows.Forms.Padding(4);
            this.D_Id.Name = "D_Id";
            this.D_Id.PasswordChar = '\0';
            this.D_Id.PlaceholderText = "";
            this.D_Id.SelectedText = "";
            this.D_Id.Size = new System.Drawing.Size(200, 36);
            this.D_Id.TabIndex = 47;
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.BorderRadius = 6;
            this.btnmax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnmax.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnmax.IconColor = System.Drawing.Color.White;
            this.btnmax.Location = new System.Drawing.Point(1332, 23);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(45, 29);
            this.btnmax.TabIndex = 45;
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.BorderRadius = 6;
            this.btnmin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnmin.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnmin.IconColor = System.Drawing.Color.White;
            this.btnmin.Location = new System.Drawing.Point(1281, 23);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(45, 29);
            this.btnmin.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(267, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 43);
            this.label4.TabIndex = 68;
            this.label4.Text = "Diagnosis Report";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2VSeparator1.Location = new System.Drawing.Point(450, 228);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 559);
            this.guna2VSeparator1.TabIndex = 69;
            // 
            // Diagnosis_Report
            // 
            this.Diagnosis_Report.BackColor = System.Drawing.Color.White;
            this.Diagnosis_Report.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.Diagnosis_Report.BorderThickness = 1;
            this.Diagnosis_Report.Controls.Add(this.label16);
            this.Diagnosis_Report.Controls.Add(this.label15);
            this.Diagnosis_Report.Controls.Add(this.label3);
            this.Diagnosis_Report.Controls.Add(this.label1);
            this.Diagnosis_Report.Controls.Add(this.label10);
            this.Diagnosis_Report.Controls.Add(this.label8);
            this.Diagnosis_Report.Controls.Add(this.label9);
            this.Diagnosis_Report.Controls.Add(this.label7);
            this.Diagnosis_Report.Controls.Add(this.guna2PictureBox1);
            this.Diagnosis_Report.Controls.Add(this.label4);
            this.Diagnosis_Report.Location = new System.Drawing.Point(515, 107);
            this.Diagnosis_Report.Name = "Diagnosis_Report";
            this.Diagnosis_Report.Size = new System.Drawing.Size(890, 341);
            this.Diagnosis_Report.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label16.Location = new System.Drawing.Point(213, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 25);
            this.label16.TabIndex = 79;
            this.label16.Text = "                       ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label15.Location = new System.Drawing.Point(213, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 25);
            this.label15.TabIndex = 78;
            this.label15.Text = "                       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(213, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "                       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(213, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "                       ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label10.Location = new System.Drawing.Point(30, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 25);
            this.label10.TabIndex = 71;
            this.label10.Text = "Medicine       :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(30, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 25);
            this.label8.TabIndex = 71;
            this.label8.Text = "Symptoms     :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(28, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "Tests             :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(30, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 71;
            this.label7.Text = "Patient Name :";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(613, 86);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(249, 219);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 69;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(33, 23);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.BorderRadius = 10;
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(204, 199);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 46;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseWaitCursor = true;
            // 
            // D_PId
            // 
            this.D_PId.BackColor = System.Drawing.Color.Transparent;
            this.D_PId.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.D_PId.BorderRadius = 15;
            this.D_PId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.D_PId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.D_PId.FillColor = System.Drawing.Color.Lavender;
            this.D_PId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_PId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.D_PId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.D_PId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.D_PId.ItemHeight = 30;
            this.D_PId.Location = new System.Drawing.Point(216, 283);
            this.D_PId.Name = "D_PId";
            this.D_PId.Size = new System.Drawing.Size(200, 36);
            this.D_PId.TabIndex = 72;
            this.D_PId.SelectionChangeCommitted += new System.EventHandler(this.D_PId_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(46, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 25);
            this.label11.TabIndex = 73;
            this.label11.Text = "Diagnosis ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label12.Location = new System.Drawing.Point(46, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 74;
            this.label12.Text = "Patient ID";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 6;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Crimson;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1383, 23);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 75;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderRadius = 21;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Indigo;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(130, 751);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 76;
            this.guna2GradientButton1.Text = "    Home";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(156, 755);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(42, 32);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 77;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1450, 825);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.D_PId);
            this.Controls.Add(this.Diagnosis_Report);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.Diagnosis_GridView);
            this.Controls.Add(this.Diagnosis_Reset);
            this.Controls.Add(this.Diagnosis_Update);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Diagnosis_Delete);
            this.Controls.Add(this.Diagnosis_Add);
            this.Controls.Add(this.D_Med);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.D_Tests);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.D_Symptoms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.D_PName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.D_Id);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diagnosis_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newHMSDataSet1)).EndInit();
            this.Diagnosis_Report.ResumeLayout(false);
            this.Diagnosis_Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView Diagnosis_GridView;
        private Guna.UI2.WinForms.Guna2GradientButton Diagnosis_Reset;
        private Guna.UI2.WinForms.Guna2GradientButton Diagnosis_Update;
        private Guna.UI2.WinForms.Guna2GradientButton Diagnosis_Delete;
        private Guna.UI2.WinForms.Guna2GradientButton Diagnosis_Add;
        private Guna.UI2.WinForms.Guna2TextBox D_Med;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox D_Tests;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox D_Symptoms;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox D_PName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox D_Id;
        private Guna.UI2.WinForms.Guna2ControlBox btnmax;
        private Guna.UI2.WinForms.Guna2ControlBox btnmin;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Panel Diagnosis_Report;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox D_PId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private newHMSDataSet1 newHMSDataSet1;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private newHMSDataSet1TableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}