namespace ClinicCat.FrontEnd.Doctors
{
    partial class frmDoctors
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnterPatient = new System.Windows.Forms.Button();
            this.listbxWaitingQueue = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreviousVisits = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.cmbxCategory = new System.Windows.Forms.ComboBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNextVisitNotes = new System.Windows.Forms.TextBox();
            this.txtCurrentVisitNotes = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpReceptionTime = new System.Windows.Forms.DateTimePicker();
            this.dtpReserveTime = new System.Windows.Forms.DateTimePicker();
            this.chkEnableScanTime = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddScans = new System.Windows.Forms.Button();
            this.btnAddPrescription = new System.Windows.Forms.Button();
            this.dtpScanTime = new System.Windows.Forms.DateTimePicker();
            this.txtReceptionTime = new System.Windows.Forms.TextBox();
            this.txtReserveTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdChoosePicture = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnEnterPatient);
            this.groupBox2.Controls.Add(this.listbxWaitingQueue);
            this.groupBox2.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Location = new System.Drawing.Point(653, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(185, 520);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة الانتظار";
            // 
            // btnEnterPatient
            // 
            this.btnEnterPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterPatient.BackColor = System.Drawing.Color.Crimson;
            this.btnEnterPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterPatient.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPatient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnterPatient.Location = new System.Drawing.Point(3, 475);
            this.btnEnterPatient.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnterPatient.Name = "btnEnterPatient";
            this.btnEnterPatient.Size = new System.Drawing.Size(179, 39);
            this.btnEnterPatient.TabIndex = 24;
            this.btnEnterPatient.Text = "استقبال";
            this.btnEnterPatient.UseVisualStyleBackColor = false;
            this.btnEnterPatient.Click += new System.EventHandler(this.BtnEnterPatient_Click);
            // 
            // listbxWaitingQueue
            // 
            this.listbxWaitingQueue.Dock = System.Windows.Forms.DockStyle.Top;
            this.listbxWaitingQueue.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbxWaitingQueue.FormattingEnabled = true;
            this.listbxWaitingQueue.ItemHeight = 22;
            this.listbxWaitingQueue.Location = new System.Drawing.Point(3, 22);
            this.listbxWaitingQueue.Margin = new System.Windows.Forms.Padding(0);
            this.listbxWaitingQueue.Name = "listbxWaitingQueue";
            this.listbxWaitingQueue.Size = new System.Drawing.Size(179, 444);
            this.listbxWaitingQueue.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.cmbxCategory);
            this.groupBox3.Controls.Add(this.txtPatientID);
            this.groupBox3.Controls.Add(this.txtPatientName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(645, 134);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات المريضة";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnPreviousVisits);
            this.groupBox1.Controls.Add(this.btnShowDetails);
            this.groupBox1.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(185, 117);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل عن المريضة";
            // 
            // btnPreviousVisits
            // 
            this.btnPreviousVisits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousVisits.BackColor = System.Drawing.Color.Crimson;
            this.btnPreviousVisits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousVisits.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousVisits.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPreviousVisits.Location = new System.Drawing.Point(16, 67);
            this.btnPreviousVisits.Name = "btnPreviousVisits";
            this.btnPreviousVisits.Size = new System.Drawing.Size(163, 44);
            this.btnPreviousVisits.TabIndex = 28;
            this.btnPreviousVisits.Text = "الزيارات السابقة";
            this.btnPreviousVisits.UseVisualStyleBackColor = false;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDetails.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShowDetails.Location = new System.Drawing.Point(16, 18);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(163, 44);
            this.btnShowDetails.TabIndex = 28;
            this.btnShowDetails.Text = "عرض بيانات المريضة";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.BtnShowDetails_Click);
            // 
            // cmbxCategory
            // 
            this.cmbxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCategory.FormattingEnabled = true;
            this.cmbxCategory.Location = new System.Drawing.Point(285, 96);
            this.cmbxCategory.Name = "cmbxCategory";
            this.cmbxCategory.Size = new System.Drawing.Size(240, 30);
            this.cmbxCategory.TabIndex = 26;
            this.cmbxCategory.SelectedIndexChanged += new System.EventHandler(this.CmbxCategory_SelectedIndexChanged);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientID.Location = new System.Drawing.Point(376, 22);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(149, 30);
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.Text = "1";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientName.BackColor = System.Drawing.SystemColors.Control;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatientName.Location = new System.Drawing.Point(285, 58);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.Size = new System.Drawing.Size(240, 30);
            this.txtPatientName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "كود المريض";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "فئة المريض";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "إسم المريض";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "وقت الحجز";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "وقت الاستقبال";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "ملاحظات الزيارة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "ملاحظات الزيارة القادمة";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.txtNextVisitNotes);
            this.groupBox4.Controls.Add(this.txtCurrentVisitNotes);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(2, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(645, 172);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات الزيارة";
            // 
            // txtNextVisitNotes
            // 
            this.txtNextVisitNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNextVisitNotes.Location = new System.Drawing.Point(6, 51);
            this.txtNextVisitNotes.Multiline = true;
            this.txtNextVisitNotes.Name = "txtNextVisitNotes";
            this.txtNextVisitNotes.Size = new System.Drawing.Size(309, 108);
            this.txtNextVisitNotes.TabIndex = 2;
            // 
            // txtCurrentVisitNotes
            // 
            this.txtCurrentVisitNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentVisitNotes.Location = new System.Drawing.Point(332, 51);
            this.txtCurrentVisitNotes.Multiline = true;
            this.txtCurrentVisitNotes.Name = "txtCurrentVisitNotes";
            this.txtCurrentVisitNotes.Size = new System.Drawing.Size(307, 108);
            this.txtCurrentVisitNotes.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.dtpReceptionTime);
            this.groupBox5.Controls.Add(this.dtpReserveTime);
            this.groupBox5.Controls.Add(this.chkEnableScanTime);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnAddScans);
            this.groupBox5.Controls.Add(this.btnAddPrescription);
            this.groupBox5.Controls.Add(this.dtpScanTime);
            this.groupBox5.Controls.Add(this.txtReceptionTime);
            this.groupBox5.Controls.Add(this.txtReserveTime);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(2, 313);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(645, 208);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "بيانات الحجز";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(164, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // dtpReceptionTime
            // 
            this.dtpReceptionTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReceptionTime.CustomFormat = "yyyy-MM-dd";
            this.dtpReceptionTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceptionTime.Location = new System.Drawing.Point(201, 72);
            this.dtpReceptionTime.Name = "dtpReceptionTime";
            this.dtpReceptionTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpReceptionTime.RightToLeftLayout = true;
            this.dtpReceptionTime.Size = new System.Drawing.Size(141, 30);
            this.dtpReceptionTime.TabIndex = 32;
            // 
            // dtpReserveTime
            // 
            this.dtpReserveTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReserveTime.CustomFormat = "yyyy-MM-dd";
            this.dtpReserveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReserveTime.Location = new System.Drawing.Point(201, 36);
            this.dtpReserveTime.Name = "dtpReserveTime";
            this.dtpReserveTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpReserveTime.RightToLeftLayout = true;
            this.dtpReserveTime.Size = new System.Drawing.Size(141, 30);
            this.dtpReserveTime.TabIndex = 31;
            // 
            // chkEnableScanTime
            // 
            this.chkEnableScanTime.AutoSize = true;
            this.chkEnableScanTime.Location = new System.Drawing.Point(286, 108);
            this.chkEnableScanTime.Name = "chkEnableScanTime";
            this.chkEnableScanTime.Size = new System.Drawing.Size(15, 14);
            this.chkEnableScanTime.TabIndex = 30;
            this.chkEnableScanTime.UseVisualStyleBackColor = true;
            this.chkEnableScanTime.CheckedChanged += new System.EventHandler(this.ChkEnableScanTime_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(6, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnAddScans
            // 
            this.btnAddScans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddScans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnAddScans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddScans.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScans.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddScans.Location = new System.Drawing.Point(6, 81);
            this.btnAddScans.Name = "btnAddScans";
            this.btnAddScans.Size = new System.Drawing.Size(152, 51);
            this.btnAddScans.TabIndex = 29;
            this.btnAddScans.Text = "إضافة فحوصات";
            this.btnAddScans.UseVisualStyleBackColor = false;
            this.btnAddScans.Click += new System.EventHandler(this.BtnAddScans_Click);
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPrescription.BackColor = System.Drawing.Color.Crimson;
            this.btnAddPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrescription.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPrescription.Location = new System.Drawing.Point(6, 20);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.Size = new System.Drawing.Size(152, 51);
            this.btnAddPrescription.TabIndex = 29;
            this.btnAddPrescription.Text = "إضافة روشتة";
            this.btnAddPrescription.UseVisualStyleBackColor = false;
            this.btnAddPrescription.Click += new System.EventHandler(this.BtnAddPrescription_Click);
            // 
            // dtpScanTime
            // 
            this.dtpScanTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpScanTime.CustomFormat = "yyyy-MM-dd";
            this.dtpScanTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScanTime.Location = new System.Drawing.Point(307, 108);
            this.dtpScanTime.Name = "dtpScanTime";
            this.dtpScanTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpScanTime.RightToLeftLayout = true;
            this.dtpScanTime.Size = new System.Drawing.Size(190, 30);
            this.dtpScanTime.TabIndex = 5;
            // 
            // txtReceptionTime
            // 
            this.txtReceptionTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceptionTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtReceptionTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceptionTime.Location = new System.Drawing.Point(348, 72);
            this.txtReceptionTime.Name = "txtReceptionTime";
            this.txtReceptionTime.ReadOnly = true;
            this.txtReceptionTime.Size = new System.Drawing.Size(149, 30);
            this.txtReceptionTime.TabIndex = 4;
            // 
            // txtReserveTime
            // 
            this.txtReserveTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReserveTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtReserveTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReserveTime.Location = new System.Drawing.Point(348, 35);
            this.txtReserveTime.Name = "txtReserveTime";
            this.txtReserveTime.ReadOnly = true;
            this.txtReserveTime.Size = new System.Drawing.Size(149, 30);
            this.txtReserveTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "وقت بدء الأشعة";
            // 
            // ofdChoosePicture
            // 
            this.ofdChoosePicture.DefaultExt = "mp4";
            this.ofdChoosePicture.Filter = "JPG Files|*.jpg|All Files|*.*";
            this.ofdChoosePicture.RestoreDirectory = true;
            this.ofdChoosePicture.Title = "Choose Video File";
            // 
            // frmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 533);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tajawal", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDoctors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmDoctors";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnterPatient;
        private System.Windows.Forms.ListBox listbxWaitingQueue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPreviousVisits;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNextVisitNotes;
        private System.Windows.Forms.TextBox txtCurrentVisitNotes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpScanTime;
        private System.Windows.Forms.TextBox txtReceptionTime;
        private System.Windows.Forms.TextBox txtReserveTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.Button btnAddScans;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkEnableScanTime;
        private System.Windows.Forms.DateTimePicker dtpReceptionTime;
        private System.Windows.Forms.DateTimePicker dtpReserveTime;
        private System.Windows.Forms.OpenFileDialog ofdChoosePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}