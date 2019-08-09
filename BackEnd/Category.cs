using System;
using System.Collections.Generic;
using System.Data;
using static ClinicCat.DataAccessLayer.DataAccessLayer;

namespace ClinicCat.BackEnd
{
    public static class Category
    {
        private static List<string> containerlist;
        static Category()
        {
            containerlist = new List<string>();
        }
        public static DataTable getCategories()
        {
            try
            {
                return GetDataTable(@"select ID,Cat_Name as[إسم الفئة],Cat_Color as[لون الفئة] from Categories");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static List<string> getCategories_DropDownList()
        {
            try
            {
                return ExecuteReader(@"select Cat_Name from Categories",new string[] { "Cat_Name"});
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static DataTable Search(string categoryName)
        {
            try
            {
                return GetDataTable(@"select ID, Cat_Name as [إسم الفئة],Cat_Color as [لون الفئة] from Categories 
                                            where Cat_Name like '%" + categoryName + "%' ");
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static bool Insert(string categoryName, string categoryColor)
        {
            try
            {
                ExecuteNonQuery(@"insert into Categories (Cat_Name,Cat_Color) values ('" + categoryName + "','" + categoryColor + "')");
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool Edit(int ID, string categoryName, string categoryColor)
        {
            try
            {
                ExecuteNonQuery(@"update Categories set Cat_Name='" + categoryName + "', Cat_Color='" + categoryColor + "' where ID='" + ID + "'");
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool Delete(string categoryID)
        {
            try
            {
                ExecuteNonQuery(@"delete from Categories Where ID='" + categoryID + "'");
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int getCategory_ID_by_Name(string categoryName)
        {
            try
            {
                return ExecuteScalar<int>(@"select ID from Categories Where Cat_Name = '" + categoryName + "'");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static string getCategory_Name_by_ID(string categoryID)
        {
            try
            {
                return ExecuteScalar<string>(@"select Cat_Name from Categories Where ID = '" + categoryID + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool checkCategory_Name_Exist(string categoryName)
        {
            if (ExecuteScalar<string>(@"select 1 from Categories where Cat_Name='" + categoryName + "'") == categoryName)
            {
                return true; //>exist
            }
            else
            {
                return false;
            }
        }

        public static bool checkCategory_Color_Exist(string categoryColor)
        {
            if (ExecuteScalar<string>(@"select 1 from Categories where Cat_Color='" + categoryColor + "'") == categoryColor)
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
