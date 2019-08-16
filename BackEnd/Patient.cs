using System;
using System.Collections.Generic;
using System.Data;
using static ClinicCat.DataAccessLayer.DataAccessLayer;

namespace ClinicCat.BackEnd
{
    public static class Patient
    {
        private static List<string> containerlist;
        static Patient()
        {
            containerlist = new List<string>();
        }
        public static string getPatientPhone_By_ID(int patientID)
        {
            try
            {
                return ExecuteScalar<string>(@"select Pat_WifePhone from Patients where ID='" + patientID + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int getPatientID_By_Name(string patientName)
        {
            try
            {
                return ExecuteScalar<int>(@"select ID from Patients where Pat_WifeName='" + patientName + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string getPatientName_By_ID(int patientID)
        {
            try
            {
                return ExecuteScalar<string>(@"select Pat_WifeName from Patients where ID='" + patientID + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable getPatients()
        {
            try
            {
                return GetDataTable(@"SELECT        
                                    dbo.Patients.ID, dbo.Categories.Cat_Name AS [الفئة],
                                    dbo.Patients.Pat_WifeName AS [الإسم],
                                    dbo.Patients.Pat_WifePhone AS [الهاتف],
                                    dbo.Patients.Pat_WifeAge AS [العمر],
                                    dbo.Patients.Pat_MarriageCurrentPeriod AS [مدة الزواج], 
                                    dbo.Patients.Pat_NumOfKids AS [عدد الأولاد]
                                    FROM  
                                    dbo.Patients 
                                    INNER JOIN
                                    dbo.Categories ON dbo.Patients.CategoriesID = dbo.Categories.ID");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static DataTable Search(int? ID, string wifeName, string wifePhone)
        {
            try
            {
                //search using barcode
                if (ID.HasValue)
                {
                    return GetDataTable(@"SELECT        
                                    dbo.Patients.ID, dbo.Categories.Cat_Name AS [الفئة],
                                    dbo.Patients.Pat_WifeName AS [الإسم],
                                    dbo.Patients.Pat_WifePhone AS [الهاتف],
                                    dbo.Patients.Pat_WifeAge AS [العمر],
                                    dbo.Patients.Pat_MarriageCurrentPeriod AS [مدة الزواج], 
                                    dbo.Patients.Pat_NumOfKids AS [عدد الأولاد]
                                    FROM  
                                    dbo.Patients 
                                    INNER JOIN
                                    dbo.Categories dbo.Patients.CategoriesID = dbo.Categories.ID 
                                    where ID = '" + ID + "' ");

                }
                else
                {
                    //search using wife name
                    if (!string.IsNullOrEmpty(wifeName))
                    {
                        return GetDataTable(@"SELECT        
                                    dbo.Patients.ID, dbo.Categories.Cat_Name AS [الفئة],
                                    dbo.Patients.Pat_WifeName AS [الإسم],
                                    dbo.Patients.Pat_WifePhone AS [الهاتف],
                                    dbo.Patients.Pat_WifeAge AS [العمر],
                                    dbo.Patients.Pat_MarriageCurrentPeriod AS [مدة الزواج], 
                                    dbo.Patients.Pat_NumOfKids AS [عدد الأولاد]
                                    FROM  
                                    dbo.Patients 
                                    INNER JOIN
                                    dbo.Categories ON dbo.Patients.CategoriesID = dbo.Categories.ID 
                                    where dbo.Patients.Pat_WifeName like '%" + wifeName + "%' ");
                    }
                    else
                    {
                        //search using wife phone
                        return GetDataTable(@"SELECT        
                                    dbo.Patients.ID, dbo.Categories.Cat_Name AS [الفئة],
                                    dbo.Patients.Pat_WifeName AS [الإسم],
                                    dbo.Patients.Pat_WifePhone AS [الهاتف],
                                    dbo.Patients.Pat_WifeAge AS [العمر],
                                    dbo.Patients.Pat_MarriageCurrentPeriod AS [مدة الزواج], 
                                    dbo.Patients.Pat_NumOfKids AS [عدد الأولاد]
                                    FROM  
                                    dbo.Patients 
                                    INNER JOIN
                                    dbo.Categories ON dbo.Patients.CategoriesID = dbo.Categories.ID 
                                    where dbo.Patients.Pat_WifePhone = '" + wifePhone + "' ");
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }

        }
        public static bool Insert(string categoryName, string wifeName,
            string wifePhone, byte wifeAge, string wifeJob, string wifeBirthdate,
            byte currentMarriagePeriod, byte numberOfKids, string wifeAddress,
            string wifeEmail, bool didMarry, byte oldMarriagePeriod,
            string husbandName, string husbandPhone, byte husbandAge, string husbandJob, string husbandBirthDate,
            string husbandRelation, string husbandEmail, string husbandSmokingType)
        {
            try
            {
                ExecuteNonQuery(@"INSERT INTO [dbo].[Patients]
                               ([CategoriesID]
                               ,[Pat_WifeName]
                               ,[Pat_WifePhone]
                               ,[Pat_WifeAge]
                               ,[Pat_WifeJob]
                               ,[Pat_WifeBirthDate]
                               ,[Pat_MarriageCurrentPeriod]
                               ,[Pat_NumOfKids]
                               ,[Pat_WifeAddress]
                               ,[Pat_WifeEmail]
                               ,[Pat_DidMarry]
                               ,[Pat_MarriageOldPeriod]
                               ,[Pat_HusbandName]
                               ,[Pat_HusbandPhone]
                               ,[Pat_HusbandAge]
                               ,[Pat_HusbandJob]
                               ,[Pat_HusbandBirthDate]
                               ,[Pat_HusbandRelation]
                               ,[Pat_HusbandEmail]
                               ,[Pat_SmokingType])
                         VALUES
                               ('" + Category.getCategory_ID_by_Name(categoryName) + "'," +
                               "'" + wifeName + "'," +
                               "'" + wifePhone + "'," +
                               "'" + wifeAge + "'," +
                               "'" + wifeJob + "'," +
                               "'" + wifeBirthdate + "'," +
                               "'" + currentMarriagePeriod + "'," +
                               "'" + numberOfKids + "'," +
                               "'" + wifeAddress + "'," +
                               "'" + wifeEmail + "'," +
                               "'" + didMarry + "'," +
                               "'" + oldMarriagePeriod + "'," +
                               "'" + husbandName + "'," +
                               "'" + husbandPhone + "'," +
                               "'" + husbandAge + "'," +
                               "'" + husbandJob + "'," +
                               "'" + husbandBirthDate + "'," +
                               "'" + husbandRelation + "'," +
                               "'" + husbandEmail + "'," +
                               "'" + husbandSmokingType + "')");
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static bool Edit(int ID, string categoryName, string wifeName, string wifePhone, byte wifeAge, string wifeJob,
            string wifeBirthdate, byte currentMarriagePeriod, byte numberOfKids, string wifeAddress, string wifeEmail,
            bool didMarry, byte oldMarriagePeriod, string husbandName, string husbandPhone, byte husbandAge,
            string husbandJob, string husbandBirthDate, string husbandRelation,
            string husbandEmail, string husbandSmokingType)
        {
            try
            {
                ExecuteNonQuery(@"UPDATE dbo.Patients SET 
                                CategoriesID ='" + Category.getCategory_ID_by_Name(categoryName) + "', " +
                                "Pat_WifeName = '" + wifeName + "'," +
                                "Pat_WifePhone = '" + wifePhone + "'," +
                                "Pat_WifeAge = '" + wifeAge + "'," +
                                "Pat_WifeJob = '" + wifeJob + "'," +
                                "Pat_WifeBirthDate = '" + wifeBirthdate + "'," +
                                "Pat_MarriageCurrentPeriod = '" + currentMarriagePeriod + "'," +
                                "Pat_NumOfKids = '" + numberOfKids + "'," +
                                "Pat_WifeAddress = '" + wifeAddress + "'," +
                                "Pat_WifeEmail = '" + wifeEmail + "'," +
                                "Pat_DidMarry = '" + didMarry + "'," +
                                "Pat_MarriageOldPeriod = '" + oldMarriagePeriod + "'," +
                                "Pat_HusbandName = '" + husbandName + "'," +
                                "Pat_HusbandPhone = '" + husbandPhone + "'," +
                                "Pat_HusbandAge = '" + husbandAge + "'," +
                                "Pat_HusbandJob = '" + husbandJob + "'," +
                                "Pat_HusbandBirthDate = '" + husbandBirthDate + "'," +
                                "Pat_HusbandRelation = '" + husbandRelation + "'," +
                                "Pat_HusbandEmail = '" + husbandEmail + "'," +
                                "Pat_SmokingType = '" + husbandSmokingType + "'" +
                                "where ID = '" + ID + "' ");
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool Delete(string PatientsID)
        {
            try
            {
                ExecuteNonQuery(@"delete from Patients Where ID='" + PatientsID + "'");
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<string> Details(int ID)
        {
            try
            {
                return ExecuteReader(@"SELECT [ID]
                                  ,[CategoriesID]
                                  ,[Pat_WifeName]
                                  ,[Pat_WifePhone]
                                  ,[Pat_WifeAge]
                                  ,[Pat_WifeJob]
                                  ,[Pat_WifeBirthDate]
                                  ,[Pat_MarriageCurrentPeriod]
                                  ,[Pat_NumOfKids]
                                  ,[Pat_WifeAddress]
                                  ,[Pat_WifeEmail]
                                  ,[Pat_DidMarry]
                                  ,[Pat_MarriageOldPeriod]
                                  ,[Pat_HusbandName]
                                  ,[Pat_HusbandPhone]
                                  ,[Pat_HusbandAge]
                                  ,[Pat_HusbandJob]
                                  ,[Pat_HusbandBirthDate]
                                  ,[Pat_HusbandRelation]
                                  ,[Pat_HusbandEmail]
                                  ,[Pat_SmokingType]
                              FROM [dbo].[Patients]
                              where ID='" + ID + "' ", new string[] {"ID",
                                "CategoriesID","Pat_WifeName","Pat_WifePhone","Pat_WifeAge","Pat_WifeJob",
                                "Pat_WifeBirthDate","Pat_MarriageCurrentPeriod",
                                "Pat_NumOfKids","Pat_WifeAddress","Pat_WifeEmail",
                                "Pat_DidMarry","Pat_MarriageOldPeriod","Pat_HusbandName",
                                "Pat_HusbandPhone","Pat_HusbandAge","Pat_HusbandJob","Pat_HusbandBirthDate",
                                "Pat_HusbandRelation","Pat_HusbandEmail","Pat_SmokingType" });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
