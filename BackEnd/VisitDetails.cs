using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static ClinicCat.DataAccessLayer.DataAccessLayer;
using ClinicCat.BackEnd;
namespace ClinicCat.BackEnd
{
    class VisitDetails
    {
        private static List<string> containerlist;
        static VisitDetails()
        {
            containerlist = new List<string>();
        }
        public static DataTable getVisits()
        {
            try
            {
                return GetDataTable(@"SELECT    
                        dbo.Visits.ID,
                        dbo.Patients.ID AS [كود المريضة],
                        dbo.Patients.Pat_WifeName AS [اسم المريضة],
                        dbo.Visits.Visit_Date AS [تاريخ الزيارة],
                         Case When dbo.Visits.Visit_Type = 1 THEN 'كشف' ELSE 'اعادة' END AS [نوع الزيارة], 
                        dbo.Visits.Visit_Reserve_Time AS [تاريخ الحجز]
                        FROM
                        dbo.Visits INNER JOIN dbo.Patients
                        ON dbo.Visits.PatientID = dbo.Patients.ID");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static DataTable searchVisits_By_PatientID(int patientID, string dateFrom, string dateTo)
        {
            string patientName = Patient.getPatientName_By_ID(patientID);
            try
            {

                return GetDataTable(@"SELECT    
                        dbo.Visits.ID,
                        dbo.Patients.ID AS [كود المريضة],
                        dbo.Patients.Pat_WifeName AS [اسم المريضة],
                        dbo.Visits.Visit_Date AS [تاريخ الزيارة],
                        Case When dbo.Visits.Visit_Type = 1 THEN 'كشف' ELSE 'اعادة' END AS [نوع الزيارة], 
                        dbo.Visits.Visit_Reserve_Time AS [تاريخ الحجز]
                        FROM
                        dbo.Visits INNER JOIN dbo.Patients
                        ON dbo.Visits.PatientID = dbo.Patients.ID
                        where 
                        (dbo.Patients.Pat_WifeName='" + patientName + "') and (dbo.Visits.Visit_Reserve_Time BETWEEN '" + dateFrom + "' and '" + dateTo + "')");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static DataTable searchVisits_By_PatientName(string patientName, string dateFrom, string dateTo)
        {
            try
            {

                return GetDataTable(@"SELECT    
                        dbo.Visits.ID,
                        dbo.Patients.ID AS [كود المريضة],
                        dbo.Patients.Pat_WifeName AS [اسم المريضة],
                        dbo.Visits.Visit_Date AS [تاريخ الزيارة],
                        Case When dbo.Visits.Visit_Type = 1 THEN 'كشف' ELSE 'اعادة' END AS [نوع الزيارة], 
                        dbo.Visits.Visit_Reserve_Time AS [تاريخ الحجز]
                        FROM
                        dbo.Visits INNER JOIN dbo.Patients
                        ON dbo.Visits.PatientID = dbo.Patients.ID
                        where 
                        (dbo.Patients.Pat_WifeName LIKE '%" + patientName + "%') and (dbo.Visits.Visit_Reserve_Time BETWEEN '" + dateFrom + "' and '" + dateTo + "')");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static DataTable searchVisits_By_PatientPhone(string patientPhone, string dateFrom, string dateTo)
        {
            try
            {
                return GetDataTable(@"SELECT    
                        dbo.Visits.ID,
                        dbo.Patients.ID AS [كود المريضة],
                        dbo.Patients.Pat_WifeName AS [اسم المريضة],
                        dbo.Visits.Visit_Date AS [تاريخ الزيارة],
                        Case When dbo.Visits.Visit_Type = 1 THEN 'كشف' ELSE 'اعادة' END AS [نوع الزيارة], 
                        dbo.Visits.Visit_Reserve_Time AS [تاريخ الحجز]
                        FROM
                        dbo.Visits INNER JOIN dbo.Patients
                        ON dbo.Visits.PatientID = dbo.Patients.ID
                        where 
                        (dbo.Patients.Pat_WifePhone LIKE '%" + patientPhone + "%') and (dbo.Visits.Visit_Reserve_Time BETWEEN '" + dateFrom + "' and '" + dateTo + "')");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static int getVisitType_By_VisitID(int visitID)
        {
            try
            {
                return ExecuteScalar<int>(@"select Visit_Type from Visits where ID='" + visitID + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static DateTime getVisitDate_By_VisitID(int visitID)
        {
            try
            {
                return ExecuteScalar<DateTime>(@"select Visit_Date from Visits where ID='" + visitID + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static decimal getRequired_By_VisitID(int visitID)
        {
            try
            {
                return ExecuteScalar<decimal>(@"select Required from Visits where ID='" + visitID + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
