namespace ClinicCat.FrontEnd.VisitsDetails
{
    partial class frmVisitsDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfVisits = new System.Windows.Forms.Label();
            this.btnPatientInfo = new System.Windows.Forms.Button();
            this.btnEditVisit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(8, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 368);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.VirtualMode = true;
            // 
            // groupbox1
            // 
            this.groupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.comboCriteria);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.dtpTo);
            this.groupbox1.Controls.Add(this.dtpFrom);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.btnSearch);
            this.groupbox1.Controls.Add(this.txtSearch);
            this.groupbox1.Location = new System.Drawing.Point(231, 22);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupbox1.Size = new System.Drawing.Size(824, 72);
            this.groupbox1.TabIndex = 17;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "بحث";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "بحث بواسطة";
            // 
            // comboCriteria
            // 
            this.comboCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCriteria.FormattingEnabled = true;
            this.comboCriteria.Items.AddRange(new object[] {
            "كود المريضة",
            "اسم المريضة",
            "هاتف المريضة"});
            this.comboCriteria.Location = new System.Drawing.Point(240, 28);
            this.comboCriteria.Name = "comboCriteria";
            this.comboCriteria.Size = new System.Drawing.Size(146, 30);
            this.comboCriteria.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "الى";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.CustomFormat = "dd-MM-yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(492, 27);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTo.Size = new System.Drawing.Size(122, 32);
            this.dtpTo.TabIndex = 29;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.CustomFormat = "dd-MM-yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(660, 27);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFrom.Size = new System.Drawing.Size(121, 32);
            this.dtpFrom.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "من";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(6, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 37);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(75, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "اجمالي الزيارات";
            // 
            // lblNumberOfVisits
            // 
            this.lblNumberOfVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfVisits.AutoSize = true;
            this.lblNumberOfVisits.Location = new System.Drawing.Point(89, 62);
            this.lblNumberOfVisits.Name = "lblNumberOfVisits";
            this.lblNumberOfVisits.Size = new System.Drawing.Size(49, 22);
            this.lblNumberOfVisits.TabIndex = 34;
            this.lblNumberOfVisits.Text = "العداد";
            // 
            // btnPatientInfo
            // 
            this.btnPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPatientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPatientInfo.Location = new System.Drawing.Point(8, 488);
            this.btnPatientInfo.Name = "btnPatientInfo";
            this.btnPatientInfo.Size = new System.Drawing.Size(186, 37);
            this.btnPatientInfo.TabIndex = 35;
            this.btnPatientInfo.Text = "عرض بيانات المريضة";
            this.btnPatientInfo.UseVisualStyleBackColor = false;
            this.btnPatientInfo.Click += new System.EventHandler(this.BtnPatientInfo_Click);
            // 
            // btnEditVisit
            // 
            this.btnEditVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnEditVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVisit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditVisit.Location = new System.Drawing.Point(231, 488);
            this.btnEditVisit.Name = "btnEditVisit";
            this.btnEditVisit.Size = new System.Drawing.Size(186, 37);
            this.btnEditVisit.TabIndex = 35;
            this.btnEditVisit.Text = "تعديل زيارة";
            this.btnEditVisit.UseVisualStyleBackColor = false;
            this.btnEditVisit.Click += new System.EventHandler(this.BtnEditVisit_Click);
            // 
            // frmVisitsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 533);
            this.Controls.Add(this.btnEditVisit);
            this.Controls.Add(this.btnPatientInfo);
            this.Controls.Add(this.lblNumberOfVisits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tajawal", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVisitsDetails";
            this.Text = "frmVisitsDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCriteria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfVisits;
        private System.Windows.Forms.Button btnPatientInfo;
        private System.Windows.Forms.Button btnEditVisit;
    }
}