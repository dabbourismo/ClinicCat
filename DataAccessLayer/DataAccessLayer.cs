using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ClinicCat.DataAccessLayer
{
    public static class DataAccessLayer
    {
        public static SqlCommand cm;
        public static DataTable table;
        static DataAccessLayer()
        {
            cm = new SqlCommand();
        }

        public static DataTable GetDataTable(string command)
        {
            cm.Connection = ConnectionSettings.cn;
            SqlDataAdapter adapter = new SqlDataAdapter(command, ConnectionSettings.cn);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable GetDataTableFast(string command)
        {
            cm.Connection = ConnectionSettings.cn;
            cm.CommandText = command;
            DataTable dt = new DataTable();
            SqlDataReader Sqlreader = cm.ExecuteReader();
            if (Sqlreader.HasRows)
            {
                dt.Load(Sqlreader);
            }
            return dt;
        }

        public static void ExecuteNonQuery(string command)
        {
            cm.Connection = ConnectionSettings.cn;
            cm.CommandText = command;
            try
            {
                cm.ExecuteNonQuery();
            }
            catch (Exception)
            { throw; }

        }
        public static T ExecuteScalar<T>(string command)
        {
            cm.Connection = ConnectionSettings.cn;
            cm.CommandText = command;

            if ((T)cm.ExecuteScalar() == default)
            {
                return default(T); //>produce the default value for each datatype. reference=>null,value=>0 etc;
            }
            else
            {
                return (T)cm.ExecuteScalar();
            }
        }

        public static List<string> ExecuteReader(string command, string[] WhatDoYouWantToReturn)
        {

            cm.Connection = ConnectionSettings.cn;
            cm.CommandText = command;

            SqlDataReader SQLitereader = cm.ExecuteReader();
            List<string> list = new List<string>();
            while (SQLitereader.Read())
            {
                foreach (string userinput in WhatDoYouWantToReturn)
                {
                    list.Add(SQLitereader[userinput].ToString());
                }
            }
            SQLitereader.Close();
            list.TrimExcess();
            return list;
        }











        //public static bool BulkInsert(string command,string DestinationTable)
        //{
        //    cm.Connection = ConnectionSettings.cn;
        //    SqlDataAdapter adapter = new SqlDataAdapter(command, ConnectionSettings.cn);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    SqlBulkCopy bulkcopy = new SqlBulkCopy(ConnectionSettings.cn);
        //    bulkcopy.DestinationTableName = DestinationTable;
        //    //bcopy.WriteToServer(SourceTable);
        //    SqlBulkCopyColumnMapping mapping = new SqlBulkCopyColumnMapping("SourceColumnName", "TargetColumnName");
        //    bulkcopy.ColumnMappings.Add(mapping);
        //}
    }



}
