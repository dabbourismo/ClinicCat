using System;
using System.Collections.Generic;
using System.Data;
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
               
                cm.CommandText = @"insert into Attachments (Attachment_Name,Attachment,PatientID)
                                    values('" + fileName[fileName.Length - 1] + "',@photo,'" + patientID + "')";
                cm.Parameters.Add("@photo", SqlDbType.VarBinary, imageData.Length).Value = imageData;
                cm.ExecuteNonQuery();
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
                return ExecuteReader(@"select ID,Attachment_Name from Attachments where PatientID='" + patientID + "'", new string[] { "ID", "Attachment_Name" });
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
