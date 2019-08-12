using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.DataAccessLayer.DataAccessLayer;

namespace ClinicCat.BackEnd
{
    public static class Visit
    {
        private static List<string> containerlist;
        static Visit()
        {
            containerlist = new List<string>();
        }
        public static List<string> getPatientInfo(int? ID, string wifeName, string wifePhone)
        {
            try
            {
                return ExecuteReader(@"select ID,Pat_WifeName,Pat_WifePhone from Patients 
                           where (ID='" + ID + "' OR Pat_WifeName = '" + wifeName + "' OR Pat_WifePhone = '" + wifePhone + "' )"
            , new string[] { "ID", "Pat_WifeName", "Pat_WifePhone" });
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static int getLastVisitID_By_PatientID(int PatientID)
        {
            try
            {
                return ExecuteScalar<int>(@"select MAX(ID) from Visits where PatientID ='" + PatientID + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool Insert(int patientID, string visitDate, bool visitType,
            bool visitIsTelephone, StringBuilder visitExtraServices, byte visitState,decimal required)
        {
            try
            {
                cm.CommandText = "Select ID from Visits where PatientID='" + patientID + "' and Visit_State!='3'";
                cm.ExecuteScalar().ToString();
                return false;
            }
            catch
            {
                try
                {
                    ExecuteNonQuery(@"insert into Visits (PatientID,Visit_Date,Visit_Type,Visit_Reserve_Time,
                                Visit_IsPhone,Visit_ExtraServices,Visit_State,Required) 
                            values ('" + patientID + "','" + visitDate + "','" + visitType + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + visitIsTelephone + "','" + visitExtraServices + "'," +
                                "'" + visitState + "','" + required + "')");
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        public static List<string> getServices_CheckedListBox()
        {
            try
            {
                return ExecuteReader(@"select Service_Name from Services", new string[] { "Service_Name" });
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int PriorityCalculation()
        {
            try
            {
                int currentPriority = ExecuteScalar<int>(@"select MAX(Priority) from Visits");
                if (currentPriority >= 0)
                {
                    currentPriority = currentPriority + 1;
                }
                return currentPriority;
            }
            catch (Exception)
            {

                return 0;

            }



        }
        private static string visitID;
        public static bool CheckForVisit(int PatientID)
        {
            try
            {
                visitID = (ExecuteScalar<int>(@"select ID from Visits WHERE (Visit_Reserve_Time IS NOT NULL) and (Visit_Reception_Time IS NULL) and(Priority IS NULL) and PatientID='" + PatientID + "'")).ToString();
                //موجود مسبقا
                if (visitID != "0")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static void RegisterVisit()
        {
            //true, it means insert new reservation in that id  
            if (visitID != null)
            {
                ExecuteNonQuery(@"update Visits set Visit_Reception_Time ='" + DateTime.Now.ToString("yyyy-MM-dd") + "',Priority='" + PriorityCalculation() + "' where ID='" + visitID + "'");
            }
        }
        public static void DeleteVisit(string patientName)
        {
            int patientID = Patient.getPatientID_By_Name(patientName);
            int visitID = getLastVisitID_By_PatientID(patientID);
            try
            {
                ExecuteNonQuery(@"update Visits set Visit_Reception_Time= NULL ,Priority= NULL where ID='" + visitID + "'");
            }
            catch (Exception)
            {

                throw;
            }


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
        public static int getLastVisitID_By_Name(string patientName)
        {

            try
            {
                
                return ExecuteScalar<int>(@"SELECT 
                            dbo.Visits.ID
                            FROM dbo.Patients
                            INNER JOIN
                            dbo.Visits ON dbo.Patients.ID=dbo.Visits.PatientID where (Patients.Pat_WifeName='" + patientName + "')");
                    }
            catch
            {
                return 0;
            }

        }
        public static int getVisitID_To_Check_Payment(string patientName)
        {

            try
            {
                return ExecuteScalar<int>(@"SELECT 
                            dbo.Visits.ID
                            FROM dbo.Patients
                            INNER JOIN
                            dbo.Visits ON dbo.Patients.ID=dbo.Visits.PatientID where (Patients.Pat_WifeName='" + patientName + "') and (Visit_Reception_Time IS NULL) and ((dbo.Visits.Visit_State='1') or (dbo.Visits.Visit_State='0')) ");
            }
            catch
            {
                return 0;
            }

        }
        public static int getEnteredVisitID_By_Name(string patientName)
        {

            try
            {
                return ExecuteScalar<int>(@"SELECT 
                            dbo.Visits.ID
                            FROM dbo.Patients
                            INNER JOIN
                            dbo.Visits ON dbo.Patients.ID=dbo.Visits.PatientID where (Patients.Pat_WifeName='" + patientName + "') and (Visit_Enter_Time IS NOT NULL) and (dbo.Visits.Visit_State='2')");
            }
            catch
            {
                return 0;
            }

        }
        //should use more search critieria, what if there are more than one visit for same person?
        public static List<string> getVisitID_By_Name(string patientName)
        {

            try
            {
                containerlist = ExecuteReader(@"SELECT 
                            dbo.Visits.ID,
                            dbo.Visits.Priority
                            FROM dbo.Patients
                            INNER JOIN
                            dbo.Visits ON dbo.Patients.ID = dbo.Visits.PatientID where (Patients.Pat_WifeName ='" + patientName + "') and (Visit_Reception_Time IS NOT NULL)", new string[] { "ID", "Priority" });
                return containerlist;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /***********************************Move up Queue*******************************************/
        public static void getVisitID_LessInPriority()
        {
            try
            {
                containerlist.AddRange(ExecuteReader(@"SELECT 
                            dbo.Visits.ID,
                             dbo.Visits.Priority
                            FROM dbo.Patients
                            INNER JOIN
                            dbo.Visits ON dbo.Patients.ID = dbo.Visits.PatientID where Visits.Priority ='" + (int.Parse(containerlist[1]) - 1) + "'", new string[] { "ID", "Priority" }));
            }
            catch (Exception)
            {
                throw;
            }
        }
        //so now the container list = [0]>visitID we are moving,[1]>its priority,[2]> previous visitID,[3] previous visit priority
        public static void MoveUp()
        {
            //move only if it is the first element
            int minPriority = ExecuteScalar<int>(@"select MIN(Priority) from Visits");
            if (containerlist[1] != minPriority.ToString())
            {
                try
                {
                    ExecuteNonQuery(@"update Visits set Priority ='" + containerlist[1] + "' where ID ='" + containerlist[2] + "'");
                    ExecuteNonQuery(@"update Visits set Priority ='" + containerlist[3] + "' where ID ='" + containerlist[0] + "'");
                }
                catch (Exception)
                {

                    throw;
                }

            }
            containerlist.Clear();
            containerlist.TrimExcess();
        }
        /***********************************End of Move up Queue*******************************************/
        /***********************************Move down Queue*******************************************/
        public static void getVisitID_MoreInPriority()
        {
            try
            {
                containerlist.AddRange(ExecuteReader(@"SELECT 
                            dbo.Visits.ID,
                             dbo.Visits.Priority
                            FROM dbo.Patients
                            INNER JOIN
                            dbo.Visits ON dbo.Patients.ID = dbo.Visits.PatientID where Visits.Priority ='" + (int.Parse(containerlist[1]) + 1) + "'", new string[] { "ID", "Priority" }));
            }
            catch (Exception)
            {
                throw;
            }
        }
        //so now the container list = [0]>visitID we are moving,[1]>its priority,[2]> next visitID,[3] next visit priority
        public static void MoveDown()
        {
            int maxPriority = ExecuteScalar<int>(@"select MAX(Priority) from Visits");
            //move only if it is the first element
            if (containerlist[1] != maxPriority.ToString())
            {
                try
                {
                    ExecuteNonQuery(@"update Visits set Priority ='" + containerlist[1] + "' where ID ='" + containerlist[2] + "'");
                    ExecuteNonQuery(@"update Visits set Priority ='" + containerlist[3] + "' where ID ='" + containerlist[0] + "'");
                }
                catch (Exception)
                {

                    throw;
                }

            }
            containerlist.Clear();
            containerlist.TrimExcess();
        }
        /***********************************end Move down Queue*******************************************/
    }
}
