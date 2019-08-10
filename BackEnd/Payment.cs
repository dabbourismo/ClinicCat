using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClinicCat.DataAccessLayer.DataAccessLayer;
namespace ClinicCat.BackEnd
{
    public static class Payment
    {
        public static bool InsertPayment(string personName, bool direction, int visitID, int patientID, string payDate, decimal required,
            decimal payed, decimal remaining)
        {
           
            try
            {
                ExecuteNonQuery(@"insert into Payments (PersonName,Direction,VisitID,PatientID,PayDate,Required,Payed,Remaining)
                values ('" + personName + "','" + direction + "','" + visitID + "','" + patientID + "','" + payDate + "','" + required + "','" + payed + "','" + remaining + "')");
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static int Get_VisitID_for_Payment(int PatientID)
        {
            try
            {
                int visitID = ExecuteScalar<int>(@"select ID from Visits WHERE (Visit_Reserve_Time IS NOT NULL) and (Visit_Reception_Time IS NULL) and(Priority IS NULL) and PatientID='" + PatientID + "'");
                return visitID;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
