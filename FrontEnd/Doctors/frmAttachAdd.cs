using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace ClinicCat.FrontEnd.Doctors
{
    public partial class frmAttachAdd : Form
    {
        string path = "";
        int visitid;

        public frmAttachAdd()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        public frmAttachAdd(int VisitID)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            visitid = VisitID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(new ThreadStart(thread));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        public void thread()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.ShowDialog();
            try
            {
                string strFn = openfiledialog.FileName;
                pictureBox1.Image = ByteToImage(PathToByte(strFn));
                this.path = strFn;
            }
            catch (Exception) { }
        }
        public byte[] PathToByte(string path)
        {
            try
            {
                FileInfo fiImage = new FileInfo(path);
                long m_lImageFileLength = fiImage.Length;
                byte[] m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
                FileStream fs = new FileStream(path, FileMode.Open,
                      FileAccess.Read, FileShare.Read);
                int iBytesRead = fs.Read(m_barrImg, 0,
                               Convert.ToInt32(m_lImageFileLength));
                fs.Close();
                return m_barrImg;
            }
            catch
            {
                byte[] m_barrImg = new byte[0];
                return m_barrImg;
            }

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

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && path.Length>0) {
                DataAccessLayer.DataAccessLayer.cm.CommandText = "Insert into Attachments(VisitID,Attachment_Name,Attachment,Attachment_Type,Attachment_Notes) values('"+visitid+"','"+textBox1.Text+"',@photo,'"+comboBox1.Text+"','"+textBox2.Text+"')";
                DataAccessLayer.DataAccessLayer.cm.Parameters.Add("@photo", SqlDbType.VarBinary, PathToByte(path).Length).Value = PathToByte(path);
                DataAccessLayer.DataAccessLayer.cm.ExecuteNonQuery();
            }
            else { MessageBox.Show("ادخل اسم ومسار الفحص"); }
        }
    }
}
