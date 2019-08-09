namespace ClinicCat.FrontEnd.Doctors
{
    partial class frmDisplayPictureAttachment
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
            this.listView = new System.Windows.Forms.ListView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofdChoosePicture = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(3, 4);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(221, 515);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(230, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(698, 434);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoosePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePicture.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePicture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChoosePicture.Location = new System.Drawing.Point(776, 444);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(152, 51);
            this.btnChoosePicture.TabIndex = 30;
            this.btnChoosePicture.Text = "اختر الصورة";
            this.btnChoosePicture.UseVisualStyleBackColor = false;
            this.btnChoosePicture.Click += new System.EventHandler(this.BtnChoosePicture_Click);
            // 
            // btnSavePicture
            // 
            this.btnSavePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnSavePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePicture.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePicture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSavePicture.Location = new System.Drawing.Point(618, 444);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(152, 51);
            this.btnSavePicture.TabIndex = 30;
            this.btnSavePicture.Text = "حفظ الصورة";
            this.btnSavePicture.UseVisualStyleBackColor = false;
            this.btnSavePicture.Click += new System.EventHandler(this.BtnSavePicture_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File name";
            // 
            // ofdChoosePicture
            // 
            this.ofdChoosePicture.DefaultExt = "mp4";
            this.ofdChoosePicture.Filter = "JPG Files|*.jpg|All Files|*.*";
            this.ofdChoosePicture.RestoreDirectory = true;
            this.ofdChoosePicture.Title = "Choose Video File";
            // 
            // frmDisplayPictureAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 531);
            this.Controls.Add(this.btnSavePicture);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Tajawal", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDisplayPictureAttachment";
            this.Text = "frmDisplayPictureAttachment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Button btnSavePicture;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.OpenFileDialog ofdChoosePicture;
    }
}