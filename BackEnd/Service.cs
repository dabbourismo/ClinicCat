using System;
using System.Collections.Generic;
using System.Data;
using static ClinicCat.DataAccessLayer.DataAccessLayer;

namespace ClinicCat.BackEnd
{
    public static class Service
    {
        private static List<string> containerlist;
        static Service()
        {
            containerlist = new List<string>();
        }
        public static DataTable getServices()
        {
            try
            {
                return GetDataTable(@"select ID,Service_Name as[إسم الخدمة],Service_Price as[سعر الخدمة] from Services");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static DataTable Search(string serviceName)
        {
            try
            {
                return GetDataTable(@"select ID,Service_Name as[إسم الخدمة],Service_Price as[سعر الخدمة] from Services 
                                            where Service_Name like '%" + serviceName + "%' ");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static bool Insert(string serviceName, decimal servicePrice)
        {
            try
            {
                ExecuteNonQuery(@"insert into Services (Service_Name,Service_Price) values ('" + serviceName + "','" + servicePrice + "')");
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool Edit(int ID, string serviceName, decimal servicePrice)
        {
            try
            {
                ExecuteNonQuery(@"update Services set Service_Name='" + serviceName + "', Service_Price='" + servicePrice + "' where ID='" + ID + "'");
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool Delete(string serviceID)
        {
            try
            {
                ExecuteNonQuery(@"delete from Services Where ID='" + serviceID + "'");
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static int getService_ID_by_Name(string serviceName)
        {
            try
            {
                return ExecuteScalar<int>(@"select ID from Services Where Service_Name = '" + serviceName + "'");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static string getService_Name_by_ID(string serviceID)
        {
            try
            {
                return ExecuteScalar<string>(@"select Service_Name from Services Where ID = '" + serviceID + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static string getService_Price_by_ID(string serviceID)
        {
            try
            {
                return ExecuteScalar<string>(@"select Service_Price from Services Where ID = '" + serviceID + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static decimal getService_Price_by_Name(string serviceName)
        {
            try
            {
                return ExecuteScalar<decimal>(@"select Service_Price from Services Where Service_Name = '" + serviceName + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool checkService_Name_Exist(string serviceName)
        {
            if (ExecuteScalar<string>(@"select 1 from Services where Service_Name='" + serviceName + "'") == serviceName)
            {
                return true; //>exist
            }
            else
            {
                return false;
            }
        }
       
    }
}
