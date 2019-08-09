using ClinicCat.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicCat.FrontEnd.Doctors
{
    public partial class frmDisplayPictureAttachment : Form
    {
        int patientID;
        DataTable dt;
        public frmDisplayPictureAttachment(int patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
           dt= DataAccessLayer.DataAccessLayer.GetDataTable("Select ID,Attachment_Name,Attachment_Type,Attachment_Notes from Attachments where VisitID='" + patientID + "'");
            foreach (DataRow row in dt.Rows) {
                listBox1.Items.Add(row[1].ToString());
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            new frmAttachAdd(patientID).ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = dt.Rows[listBox1.SelectedIndex][1].ToString();
            label4.Text = dt.Rows[listBox1.SelectedIndex][3].ToString();


           pictureBox.Image=ByteToImage(DoctorsLogic.GetPhoto(dt.Rows[listBox1.SelectedIndex][0].ToString()));
            pictureBox.Refresh();
        }
        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }

        private void frmDisplayPictureAttachment_Load(object sender, EventArgs e)
        {

        }
    }
}
