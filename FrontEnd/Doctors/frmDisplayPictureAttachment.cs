using ClinicCat.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicCat.FrontEnd.Doctors
{
    public partial class frmDisplayPictureAttachment : Form
    {
        private int patientID;
        string fileName;
        public frmDisplayPictureAttachment(int patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
            DoctorsLogic.PopulatePictureListBox(listView, patientID);
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox.Image = DoctorsLogic.imageList[listView.SelectedItems[0].Index];
            }
            catch { }
            }

        private void BtnChoosePicture_Click(object sender, EventArgs e)
        {
            if (ofdChoosePicture.ShowDialog() == DialogResult.OK)
            {
              fileName = ofdChoosePicture.FileName;
                pictureBox.Image = Image.FromFile(fileName);             
            }
        }

        private void BtnSavePicture_Click(object sender, EventArgs e)
        {
            Attachment.InsertImage(ofdChoosePicture.FileName, DoctorsLogic.ConvertImageToBinary(pictureBox.Image),patientID);  //upload the attachment
            MessageBox.Show("success");
        }
    }
}
