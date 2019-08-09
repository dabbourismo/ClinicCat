namespace ClinicCat.FrontEnd.Settings
{
    partial class frmSettings
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.picBackupConfirm = new System.Windows.Forms.PictureBox();
            this.picVideoConfirm = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNews = new System.Windows.Forms.TextBox();
            this.numDaysBetween = new System.Windows.Forms.NumericUpDown();
            this.numRe_ExaminePrice = new System.Windows.Forms.NumericUpDown();
            this.numExaminePrice = new System.Windows.Forms.NumericUpDown();
            this.btnBackupURL = new System.Windows.Forms.Button();
            this.btnVideoURL = new System.Windows.Forms.Button();
            this.sfdBackupPath = new System.Windows.Forms.SaveFileDialog();
            this.ofdChooseVideo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackupConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysBetween)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRe_ExaminePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExaminePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.picBackupConfirm);
            this.groupBox5.Controls.Add(this.picVideoConfirm);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtNews);
            this.groupBox5.Controls.Add(this.numDaysBetween);
            this.groupBox5.Controls.Add(this.numRe_ExaminePrice);
            this.groupBox5.Controls.Add(this.numExaminePrice);
            this.groupBox5.Controls.Add(this.btnBackupURL);
            this.groupBox5.Controls.Add(this.btnVideoURL);
            this.groupBox5.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(507, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(322, 520);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "الاعدادات";
            // 
            // picBackupConfirm
            // 
            this.picBackupConfirm.Location = new System.Drawing.Point(38, 69);
            this.picBackupConfirm.Name = "picBackupConfirm";
            this.picBackupConfirm.Size = new System.Drawing.Size(36, 36);
            this.picBackupConfirm.TabIndex = 29;
            this.picBackupConfirm.TabStop = false;
            // 
            // picVideoConfirm
            // 
            this.picVideoConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picVideoConfirm.ErrorImage = global::ClinicCat.Resources.RightSign;
            this.picVideoConfirm.Location = new System.Drawing.Point(38, 26);
            this.picVideoConfirm.Name = "picVideoConfirm";
            this.picVideoConfirm.Size = new System.Drawing.Size(36, 36);
            this.picVideoConfirm.TabIndex = 29;
            this.picVideoConfirm.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(6, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 37);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "الفترة بين الكشف والاعادة";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "سعر الاعادة";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "سعر الكشف";
            // 
            // txtNews
            // 
            this.txtNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNews.Location = new System.Drawing.Point(38, 127);
            this.txtNews.Multiline = true;
            this.txtNews.Name = "txtNews";
            this.txtNews.Size = new System.Drawing.Size(248, 133);
            this.txtNews.TabIndex = 26;
            // 
            // numDaysBetween
            // 
            this.numDaysBetween.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numDaysBetween.Location = new System.Drawing.Point(38, 358);
            this.numDaysBetween.Name = "numDaysBetween";
            this.numDaysBetween.Size = new System.Drawing.Size(51, 30);
            this.numDaysBetween.TabIndex = 25;
            // 
            // numRe_ExaminePrice
            // 
            this.numRe_ExaminePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numRe_ExaminePrice.Location = new System.Drawing.Point(38, 321);
            this.numRe_ExaminePrice.Name = "numRe_ExaminePrice";
            this.numRe_ExaminePrice.Size = new System.Drawing.Size(120, 30);
            this.numRe_ExaminePrice.TabIndex = 25;
            // 
            // numExaminePrice
            // 
            this.numExaminePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numExaminePrice.Location = new System.Drawing.Point(38, 285);
            this.numExaminePrice.Name = "numExaminePrice";
            this.numExaminePrice.Size = new System.Drawing.Size(120, 30);
            this.numExaminePrice.TabIndex = 25;
            // 
            // btnBackupURL
            // 
            this.btnBackupURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnBackupURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupURL.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupURL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackupURL.Location = new System.Drawing.Point(80, 68);
            this.btnBackupURL.Name = "btnBackupURL";
            this.btnBackupURL.Size = new System.Drawing.Size(206, 37);
            this.btnBackupURL.TabIndex = 24;
            this.btnBackupURL.Text = "مسار النسخ الاحتياطي";
            this.btnBackupURL.UseVisualStyleBackColor = false;
            this.btnBackupURL.Click += new System.EventHandler(this.BtnBackupURL_Click);
            // 
            // btnVideoURL
            // 
            this.btnVideoURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideoURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnVideoURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoURL.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoURL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVideoURL.Location = new System.Drawing.Point(80, 25);
            this.btnVideoURL.Name = "btnVideoURL";
            this.btnVideoURL.Size = new System.Drawing.Size(206, 37);
            this.btnVideoURL.TabIndex = 24;
            this.btnVideoURL.Text = "اختر الفيديو";
            this.btnVideoURL.UseVisualStyleBackColor = false;
            this.btnVideoURL.Click += new System.EventHandler(this.BtnVideoURL_Click);
            // 
            // ofdChooseVideo
            // 
            this.ofdChooseVideo.DefaultExt = "mp4";
            this.ofdChooseVideo.Filter = "mp4 Files|*.mp4|All Files|*.*";
            this.ofdChooseVideo.RestoreDirectory = true;
            this.ofdChooseVideo.Title = "Choose Video File";
            this.ofdChooseVideo.FileOk += new System.ComponentModel.CancelEventHandler(this.OfdChooseVideo_FileOk);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 533);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Tajawal", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackupConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysBetween)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRe_ExaminePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExaminePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBackupURL;
        private System.Windows.Forms.Button btnVideoURL;
        private System.Windows.Forms.NumericUpDown numExaminePrice;
        private System.Windows.Forms.TextBox txtNews;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numRe_ExaminePrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog sfdBackupPath;
        private System.Windows.Forms.OpenFileDialog ofdChooseVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDaysBetween;
        private System.Windows.Forms.PictureBox picVideoConfirm;
        private System.Windows.Forms.PictureBox picBackupConfirm;
    }
}