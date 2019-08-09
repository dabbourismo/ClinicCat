using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using static ClinicCat.DataAccessLayer.DataAccessLayer;
namespace ClinicCat.BackEnd
{
    public static class Attachment
    {
        //not working, needs implicit conversion
        public static void InsertImage(string filePath, byte[] imageData, int patientID)
        {
            string[] fileName = filePath.Split(Convert.ToChar(@"\"));
            try
            {
                ExecuteNonQuery(@"insert into Attachments (Attachment_Name,Attachment,PatientID)
                                    values('" + fileName[fileName.Length - 1] + "','" + imageData + "','" + patientID + "')");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<string> SelectImages(int patientID)
        {

            try
            {
                return ExecuteReader(@"select Attachment,Attachment_Name from Attachments where PatientID='" + patientID + "'", new string[] { "Attachment", "Attachment_Name" });
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
