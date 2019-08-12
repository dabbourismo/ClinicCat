namespace ClinicCat.FrontEnd.Payments
{
    partial class frmPaymentCRUD
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
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblPreviousPayed = new System.Windows.Forms.Label();
            this.lblPayed = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.numRequired = new System.Windows.Forms.NumericUpDown();
            this.numPreviousPayed = new System.Windows.Forms.NumericUpDown();
            this.numPayed = new System.Windows.Forms.NumericUpDown();
            this.numRemaining = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numOtherPayed = new System.Windows.Forms.NumericUpDown();
            this.cmbxDirection = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreviousPayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherPayed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequired.AutoSize = true;
            this.lblRequired.Location = new System.Drawing.Point(548, 21);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(70, 22);
            this.lblRequired.TabIndex = 18;
            this.lblRequired.Text = "المطلوب";
            // 
            // lblPreviousPayed
            // 
            this.lblPreviousPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreviousPayed.AutoSize = true;
            this.lblPreviousPayed.Location = new System.Drawing.Point(548, 53);
            this.lblPreviousPayed.Name = "lblPreviousPayed";
            this.lblPreviousPayed.Size = new System.Drawing.Size(112, 22);
            this.lblPreviousPayed.TabIndex = 19;
            this.lblPreviousPayed.Text = "المدفوع مسبقا";
            // 
            // lblPayed
            // 
            this.lblPayed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayed.AutoSize = true;
            this.lblPayed.Location = new System.Drawing.Point(548, 133);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(92, 22);
            this.lblPayed.TabIndex = 19;
            this.lblPayed.Text = "المدفوع الان";
            // 
            // lblRemaining
            // 
            this.lblRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(548, 97);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(58, 22);
            this.lblRemaining.TabIndex = 19;
            this.lblRemaining.Text = "المتبقي";
            // 
            // numRequired
            // 
            this.numRequired.Enabled = false;
            this.numRequired.Location = new System.Drawing.Point(393, 17);
            this.numRequired.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numRequired.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numRequired.Name = "numRequired";
            this.numRequired.Size = new System.Drawing.Size(120, 30);
            this.numRequired.TabIndex = 20;
            this.numRequired.ValueChanged += new System.EventHandler(this.CalculateRemaining);
            // 
            // numPreviousPayed
            // 
            this.numPreviousPayed.Enabled = false;
            this.numPreviousPayed.Location = new System.Drawing.Point(393, 53);
            this.numPreviousPayed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPreviousPayed.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numPreviousPayed.Name = "numPreviousPayed";
            this.numPreviousPayed.Size = new System.Drawing.Size(120, 30);
            this.numPreviousPayed.TabIndex = 20;
            this.numPreviousPayed.ValueChanged += new System.EventHandler(this.CalculateRemaining);
            // 
            // numPayed
            // 
            this.numPayed.Location = new System.Drawing.Point(393, 125);
            this.numPayed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPayed.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numPayed.Name = "numPayed";
            this.numPayed.Size = new System.Drawing.Size(120, 30);
            this.numPayed.TabIndex = 20;
            // 
            // numRemaining
            // 
            this.numRemaining.Enabled = false;
            this.numRemaining.Location = new System.Drawing.Point(393, 89);
            this.numRemaining.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numRemaining.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numRemaining.Name = "numRemaining";
            this.numRemaining.Size = new System.Drawing.Size(120, 30);
            this.numRemaining.TabIndex = 20;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsert.Location = new System.Drawing.Point(543, 311);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 39);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "دفع للمريض";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(12, 311);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 39);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "اغلاق";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayDate.Location = new System.Drawing.Point(234, 270);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(117, 30);
            this.dtpPayDate.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "تاريخ الدفع";
            // 
            // numOtherPayed
            // 
            this.numOtherPayed.Location = new System.Drawing.Point(146, 97);
            this.numOtherPayed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOtherPayed.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numOtherPayed.Name = "numOtherPayed";
            this.numOtherPayed.Size = new System.Drawing.Size(120, 30);
            this.numOtherPayed.TabIndex = 20;
            // 
            // cmbxDirection
            // 
            this.cmbxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDirection.FormattingEnabled = true;
            this.cmbxDirection.Items.AddRange(new object[] {
            "صادر",
            "وارد"});
            this.cmbxDirection.Location = new System.Drawing.Point(146, 13);
            this.cmbxDirection.Name = "cmbxDirection";
            this.cmbxDirection.Size = new System.Drawing.Size(121, 30);
            this.cmbxDirection.TabIndex = 38;
            this.cmbxDirection.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "الاتجاة";
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(34, 53);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPersonName.Size = new System.Drawing.Size(233, 30);
            this.txtPersonName.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "الاسم";
            // 
            // lblDirection
            // 
            this.lblDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(299, 105);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(52, 22);
            this.lblDirection.TabIndex = 36;
            this.lblDirection.Text = "الصادر";
            // 
            // frmPaymentCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 362);
            this.Controls.Add(this.cmbxDirection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpPayDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.numRemaining);
            this.Controls.Add(this.numOtherPayed);
            this.Controls.Add(this.numPayed);
            this.Controls.Add(this.numPreviousPayed);
            this.Controls.Add(this.numRequired);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblPayed);
            this.Controls.Add(this.lblPreviousPayed);
            this.Controls.Add(this.lblRequired);
            this.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPaymentCRUD";
            this.Text = "frmPaymentCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.numRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreviousPayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOtherPayed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblPreviousPayed;
        private System.Windows.Forms.Label lblPayed;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.NumericUpDown numRequired;
        private System.Windows.Forms.NumericUpDown numPreviousPayed;
        private System.Windows.Forms.NumericUpDown numPayed;
        private System.Windows.Forms.NumericUpDown numRemaining;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numOtherPayed;
        private System.Windows.Forms.ComboBox cmbxDirection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDirection;
    }
}