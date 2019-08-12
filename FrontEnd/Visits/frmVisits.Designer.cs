namespace ClinicCat.FrontEnd.Visits
{
    partial class frmVisits
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDeleteVisit = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.listbxWaitingQueue = new System.Windows.Forms.ListBox();
            this.btnInsertPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.txtRequired = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxVisitType = new System.Windows.Forms.ComboBox();
            this.clbAdditionalServices = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkIsPhone = new System.Windows.Forms.CheckBox();
            this.dtpVisitDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.txtPatientPhone);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.txtPatientName);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.txtPatientID);
            this.groupbox1.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.Location = new System.Drawing.Point(6, 3);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupbox1.Size = new System.Drawing.Size(581, 74);
            this.groupbox1.TabIndex = 4;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "بحث أو إضافة";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "التليفون";
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientPhone.Location = new System.Drawing.Point(6, 29);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(135, 26);
            this.txtPatientPhone.TabIndex = 20;
            this.txtPatientPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientGroupBox_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "إسم المريض";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientName.Location = new System.Drawing.Point(203, 29);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(135, 26);
            this.txtPatientName.TabIndex = 18;
            this.txtPatientName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientGroupBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "كود المريض";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientID.Location = new System.Drawing.Point(429, 29);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(66, 26);
            this.txtPatientID.TabIndex = 0;
            this.txtPatientID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientGroupBox_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Controls.Add(this.btnDeleteVisit);
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.listbxWaitingQueue);
            this.groupBox2.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Location = new System.Drawing.Point(593, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(245, 518);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة الانتظار";
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.Location = new System.Drawing.Point(189, 470);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(50, 37);
            this.btnUp.TabIndex = 24;
            this.btnUp.Text = "فوق";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // btnDeleteVisit
            // 
            this.btnDeleteVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteVisit.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVisit.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVisit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteVisit.Location = new System.Drawing.Point(70, 470);
            this.btnDeleteVisit.Name = "btnDeleteVisit";
            this.btnDeleteVisit.Size = new System.Drawing.Size(113, 37);
            this.btnDeleteVisit.TabIndex = 24;
            this.btnDeleteVisit.Text = "ازالة من قائمة الانتظار";
            this.btnDeleteVisit.UseVisualStyleBackColor = false;
            this.btnDeleteVisit.Click += new System.EventHandler(this.BtnDeleteVisit_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDown.Location = new System.Drawing.Point(6, 470);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(58, 37);
            this.btnDown.TabIndex = 24;
            this.btnDown.Text = "تحت";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // listbxWaitingQueue
            // 
            this.listbxWaitingQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbxWaitingQueue.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbxWaitingQueue.FormattingEnabled = true;
            this.listbxWaitingQueue.ItemHeight = 22;
            this.listbxWaitingQueue.Location = new System.Drawing.Point(6, 20);
            this.listbxWaitingQueue.Name = "listbxWaitingQueue";
            this.listbxWaitingQueue.Size = new System.Drawing.Size(233, 444);
            this.listbxWaitingQueue.TabIndex = 6;
            // 
            // btnInsertPatient
            // 
            this.btnInsertPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnInsertPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPatient.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPatient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsertPatient.Location = new System.Drawing.Point(131, 83);
            this.btnInsertPatient.Name = "btnInsertPatient";
            this.btnInsertPatient.Size = new System.Drawing.Size(108, 37);
            this.btnInsertPatient.TabIndex = 19;
            this.btnInsertPatient.Text = "اضافة مريض";
            this.btnInsertPatient.UseVisualStyleBackColor = false;
            this.btnInsertPatient.Click += new System.EventHandler(this.btnInsertPatient_Click);
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnUpdatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePatient.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePatient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdatePatient.Location = new System.Drawing.Point(6, 83);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(109, 37);
            this.btnUpdatePatient.TabIndex = 20;
            this.btnUpdatePatient.Text = "تعديل مريض";
            this.btnUpdatePatient.UseVisualStyleBackColor = false;
            this.btnUpdatePatient.Click += new System.EventHandler(this.BtnUpdatePatient_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.txtRemaining);
            this.groupBox3.Controls.Add(this.txtPayed);
            this.groupBox3.Controls.Add(this.txtRequired);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(233, 352);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المستحقات";
            // 
            // txtRemaining
            // 
            this.txtRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemaining.Enabled = false;
            this.txtRemaining.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtRemaining.Location = new System.Drawing.Point(6, 198);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRemaining.Size = new System.Drawing.Size(135, 27);
            this.txtRemaining.TabIndex = 23;
            this.txtRemaining.Text = "0";
            this.txtRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRemaining.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemaining_KeyPress);
            // 
            // txtPayed
            // 
            this.txtPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayed.ForeColor = System.Drawing.Color.Indigo;
            this.txtPayed.Location = new System.Drawing.Point(6, 154);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayed.Size = new System.Drawing.Size(135, 27);
            this.txtPayed.TabIndex = 22;
            this.txtPayed.Text = "0";
            this.txtPayed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPayed.TextChanged += new System.EventHandler(this.txtPayed_TextChanged);
            this.txtPayed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayed_KeyPress);
            // 
            // txtRequired
            // 
            this.txtRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequired.Enabled = false;
            this.txtRequired.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequired.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtRequired.Location = new System.Drawing.Point(6, 113);
            this.txtRequired.Name = "txtRequired";
            this.txtRequired.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRequired.Size = new System.Drawing.Size(135, 27);
            this.txtRequired.TabIndex = 21;
            this.txtRequired.Text = "0";
            this.txtRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRequired.TextChanged += new System.EventHandler(this.txtRequired_TextChanged);
            this.txtRequired.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequired_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.txtDiscount.Location = new System.Drawing.Point(6, 71);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(135, 27);
            this.txtDiscount.TabIndex = 20;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Navy;
            this.txtTotal.Location = new System.Drawing.Point(6, 35);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(135, 27);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "متبقي";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "مدفوع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "مطلوب";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "خصم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "إجمالي";
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReservation.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReservation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewReservation.Location = new System.Drawing.Point(145, 484);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(94, 37);
            this.btnNewReservation.TabIndex = 22;
            this.btnNewReservation.Text = "حالة جديدة";
            this.btnNewReservation.UseVisualStyleBackColor = false;
            this.btnNewReservation.Click += new System.EventHandler(this.BtnNewReservation_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddReservation.BackColor = System.Drawing.Color.Crimson;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddReservation.Location = new System.Drawing.Point(6, 484);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(94, 37);
            this.btnAddReservation.TabIndex = 23;
            this.btnAddReservation.Text = "حفظ الحجز";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.BtnAddReservation_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "نوع الزيارة";
            // 
            // cmbxVisitType
            // 
            this.cmbxVisitType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxVisitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVisitType.FormattingEnabled = true;
            this.cmbxVisitType.Items.AddRange(new object[] {
            "كشف",
            "إعادة"});
            this.cmbxVisitType.Location = new System.Drawing.Point(64, 23);
            this.cmbxVisitType.Name = "cmbxVisitType";
            this.cmbxVisitType.Size = new System.Drawing.Size(180, 30);
            this.cmbxVisitType.TabIndex = 25;
            this.cmbxVisitType.SelectedIndexChanged += new System.EventHandler(this.CmbxVisitType_SelectedIndexChanged);
            // 
            // clbAdditionalServices
            // 
            this.clbAdditionalServices.CheckOnClick = true;
            this.clbAdditionalServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbAdditionalServices.FormattingEnabled = true;
            this.clbAdditionalServices.Location = new System.Drawing.Point(3, 26);
            this.clbAdditionalServices.Name = "clbAdditionalServices";
            this.clbAdditionalServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clbAdditionalServices.Size = new System.Drawing.Size(316, 269);
            this.clbAdditionalServices.TabIndex = 26;
            this.clbAdditionalServices.SelectedIndexChanged += new System.EventHandler(this.ClbAdditionalServices_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chkIsPhone);
            this.groupBox4.Controls.Add(this.dtpVisitDate);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbxVisitType);
            this.groupBox4.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(245, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(342, 438);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "المستحقات";
            // 
            // chkIsPhone
            // 
            this.chkIsPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsPhone.AutoSize = true;
            this.chkIsPhone.Location = new System.Drawing.Point(209, 401);
            this.chkIsPhone.Name = "chkIsPhone";
            this.chkIsPhone.Size = new System.Drawing.Size(116, 26);
            this.chkIsPhone.TabIndex = 29;
            this.chkIsPhone.Text = "حجز بالتليفون";
            this.chkIsPhone.UseVisualStyleBackColor = true;
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVisitDate.CustomFormat = "dd-MM-yyyy";
            this.dtpVisitDate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVisitDate.Location = new System.Drawing.Point(64, 59);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpVisitDate.Size = new System.Drawing.Size(180, 32);
            this.dtpVisitDate.TabIndex = 28;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.clbAdditionalServices);
            this.groupBox5.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(322, 298);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "الخدمات الاضافية";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "تاريخ الزيارة";
            // 
            // frmVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 533);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.btnNewReservation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnInsertPatient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Font = new System.Drawing.Font("Tajawal", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVisits";
            this.Text = "frmVisits";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listbxWaitingQueue;
        private System.Windows.Forms.Button btnInsertPatient;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxVisitType;
        private System.Windows.Forms.CheckedListBox clbAdditionalServices;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIsPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDeleteVisit;
        private System.Windows.Forms.TextBox txtRemaining;
        private System.Windows.Forms.TextBox txtPayed;
        private System.Windows.Forms.TextBox txtRequired;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotal;
    }
}