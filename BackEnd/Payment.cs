using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static ClinicCat.DataAccessLayer.DataAccessLayer;
namespace ClinicCat.BackEnd
{
    public static class Payment
    {

        public static DataTable getPayments()
        {
            try
            {
                return GetDataTable(@"SELECT
                    ID,
                    PersonName as [اسم الشخص],
                    CASE When Payments.Direction = 1 THEN 'وارد' ELSE 'صادر' END AS 'الاتجاه',
                    PatientID as [كود المريض],
                    PayDate as [تاريخ الدفع],
                    Payed as [المدفوع],
                    VisitID as [كود الزيارة]
                    FROM
                    dbo.Payments");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static decimal get_Previous_Payment(int visitID)
        {
            try
            {
                return ExecuteScalar<decimal>(@"select sum(Payed) from Payments where VisitID='"+visitID+"'");
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static decimal get_Required_Payment(int visitID)
        {
            try
            {
                return ExecuteScalar<decimal>(@"select Required from Visits where ID='" + visitID + "' ");
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool InsertPayment(string personName, bool direction, int visitID, int patientID, string payDate,decimal payed)
        {
           
            try
            {
                ExecuteNonQuery(@"insert into Payments (PersonName,Direction,VisitID,PatientID,PayDate,Payed)
                values ('" + personName + "','" + direction + "','" + visitID + "','" + patientID + "','" + payDate + "','" + payed + "')");
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
