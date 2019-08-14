using ClinicCat.BackEnd;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Doctor;
using static ClinicCat.DataAccessLayer.DataAccessLayer;

namespace ClinicCat.FrontEnd.Doctors
{
    public static class DoctorsLogic
    {
        private static List<string> containerList;
        public static List<Image> imageList;
        static DoctorsLogic()
        {

        }
        public static void PopulateListBox(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (string service in getNames_listbox())
            {
                listbox.Items.Add(service);
            }
        }
        public static void EnterPatient(ListBox listbox, TextBox txtPatientID, TextBox txtPatientName,
            DateTimePicker dtpReserveTime, DateTimePicker dtpReceptionTime, TextBox txtCurrentVisitNotes, ComboBox cmbx)
        {
            string name = listbox.SelectedItem.ToString();
            if (Doctor_RegisterVisit_In(name))
            {
                containerList = new List<string>();
                containerList = GetEnteredPatientInfo(name);
                /*0 patient id,1 patient name,2 reserve time,3 reception time,4 current visit notes,5 category name,*/
                txtPatientID.Text = containerList[0];
                txtPatientName.Text = containerList[1];
                dtpReserveTime.Value = DateTime.Parse(containerList[2]);
                dtpReceptionTime.Value = DateTime.Parse(containerList[3]);
                //ملاحظات الزيارة
                txtCurrentVisitNotes.Text = Get_LastVisit_Note(name);
                
                cmbx.Text = containerList[5];
            }

        }



        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }

        public static Image ConvertBinaryToImage(byte[] imageData)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = imageData;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        public static void PopulatePictureListBox(ListView listview,int patientID)
        {
            listview.Items.Clear();
            imageList = new List<Image>();
            containerList = Attachment.SelectImages(patientID);
            for (int i = 0; i < containerList.Count; i++)
            {
                ListViewItem item = new ListViewItem(containerList[0].ToString());
                listview.Items.Add(item);
            }
            for (int i = 0; i < containerList.Count; i++)
            {
                imageList.Add(ConvertBinaryToImage(GetPhoto(containerList[0].ToString())));
            }
        }

        
        public static byte[] GetPhoto(string userId)
        {
            cm.CommandText = "select Attachment from Attachments where ID = '" + userId + "'";
            return cm.ExecuteScalar() as byte[];
        }
    }
}
