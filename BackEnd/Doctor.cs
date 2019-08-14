using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.DataAccessLayer.DataAccessLayer;

namespace ClinicCat.BackEnd
{
    public static class Doctor
    {
        private static List<string> containerlist;
        static Doctor()
        {
            containerlist = new List<string>();
        }
        public static List<string> getNames_listbox()
        {
            try
            {
                return ExecuteReader(@"SELECT
                                    dbo.Patients.Pat_WifeName, dbo.Visits.Priority
                                    FROM
                                    dbo.Patients INNER JOIN
                                    dbo.Visits ON dbo.Patients.ID = dbo.Visits.PatientID
                                    where (Visit_Reception_Time IS NOT NULL) and (Priority IS NOT NULL)
                                    order by dbo.Visits.Priority", new string[] { "Pat_WifeName" });
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool Doctor_RegisterVisit_In(string patientName)
        {
            int visitID = Visit.getLastVisitID_By_Name(patientName);
            if (visitID == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    ExecuteNonQuery(@"update Visits set Visit_State='2', Visit_Enter_Time='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where ID='" + visitID + "'");
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
        public static bool Doctor_RegisterVisit_Out(string patientName, string nextVisitNotes, string currentVisitNotes, string visitScanTime)
        {
            int visitID = Visit.getEnteredVisitID_By_Name(patientName);
            if (visitID == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(visitScanTime))
                    {
                        ExecuteNonQuery(@"update Visits set Visit_State='3', Visit_Next_Notes='" + nextVisitNotes + "', Visit_Current_Notes='" + currentVisitNotes + "', Priority = null where ID='" + visitID + "'");
                        return true;

                    }
                    else
                    {
                        ExecuteNonQuery(@"update Visits set Visit_State='3', Visit_Next_Notes='" + nextVisitNotes + "',Visit_Current_Notes='" + currentVisitNotes + "', Visit_Scan_Time='" + visitScanTime + "', Priority = null where ID='" + visitID + "'");

                        return true;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
        public static bool Update_Patient_Category(int patientID, int categoryID)
        {
            try
            {
                ExecuteNonQuery(@"update Patients set CategoriesID='" + categoryID + "' where ID='" + patientID + "'");
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static List<string> GetEnteredPatientInfo(string patientName)
        {
            try
            {
                containerlist = ExecuteReader(@"SELECT
dbo.Patients.ID, dbo.Patients.Pat_WifeName, dbo.Visits.Visit_Reserve_Time, dbo.Visits.Visit_Reception_Time,dbo.Visits.Visit_Current_Notes, dbo.Categories.Cat_Name
FROM
dbo.Patients 
INNER JOIN
dbo.Visits ON dbo.Patients.ID = dbo.Visits.PatientID 
INNER JOIN
dbo.Categories ON dbo.Patients.CategoriesID = dbo.Categories.ID where (dbo.Patients.Pat_WifeName='" + patientName + "') and (dbo.Visits.Visit_State='2') and (dbo.Visits.Visit_Enter_Time IS NOT NULL)",
new string[] { "ID", "Pat_WifeName", "Visit_Reserve_Time", "Visit_Reception_Time", "Visit_Current_Notes", "Cat_Name" });
                return containerlist;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string Get_LastVisit_Note(string patientName)
        {
            int patientID = Patient.getPatientID_By_Name(patientName);
            try
            {
                int visitID = ExecuteScalar<int>(@"select MAX(ID) from Visits where (PatientID='" + patientID + "') and (Visit_State='3') ");
                if (visitID != 0)
                {
                    return ExecuteScalar<string>(@"select Visit_Next_Notes from Visits where ID='" + visitID + "'");
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
