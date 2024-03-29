﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using static ClinicCat.DataAccessLayer.DataAccessLayer;
namespace ClinicCat.BackEnd
{
    public static class Setting
    {
        public static bool Insert(string backupURL,string videoURL,string news,byte daysBetween,decimal examiningPrice,
            decimal re_ExaminingPrice)
        {
            try
            {
                ExecuteNonQuery(@"insert into Settings (BackupURL,VideoURL,News,Days_Between,ExaminePrice,Re_ExaminePrice) 
                values ('" + backupURL + "','" + videoURL + "','" + news + "','" + daysBetween + "','" + examiningPrice + "','" + re_ExaminingPrice + "')");
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Edit(int ID,string backupURL, string videoURL, string news, byte daysBetween, decimal examiningPrice,
            decimal re_ExaminingPrice)
        {
            try
            {
                ExecuteNonQuery(@"update Settings set BackupURL ='"+backupURL+"',News='"+news+"'," +
                    "Days_Between = '"+daysBetween+ "',ExaminePrice ='"+examiningPrice+ "',Re_ExaminePrice='"+re_ExaminingPrice+"' where ID='"+ID+"'");
                if (videoURL.Length > 0)
                {
                    cm.CommandText = @"Update Settings set VideoURL=@video";
                    cm.Parameters.Add("@video", SqlDbType.VarBinary, PathToByte(videoURL).Length).Value = PathToByte(videoURL);
                    cm.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static byte[] PathToByte(string path)
        {
            try
            {
                FileInfo fiImage = new FileInfo(path);
                long m_lImageFileLength = fiImage.Length;
                byte[] m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
                FileStream fs = new FileStream(path, FileMode.Open,
                      FileAccess.Read, FileShare.Read);
                int iBytesRead = fs.Read(m_barrImg, 0,
                               Convert.ToInt32(m_lImageFileLength));
                fs.Close();
                return m_barrImg;
            }
            catch
            {
                byte[] m_barrImg = new byte[0];
                return m_barrImg;
            }

        }
        public static List<string> GetSettings(int ID)
        {
            try
            {
                return ExecuteReader(@"select BackupURL,VideoURL,News,Days_Between,ExaminePrice,Re_ExaminePrice from Settings where ID='" + ID + "'",
                    new string[] { "BackupURL", "VideoURL", "News", "Days_Between", "ExaminePrice", "Re_ExaminePrice" });
            }
            catch (Exception)
            {

                throw;
            }
        }
   

    public static decimal getExaminePrice()
        {
            try
            {
                return ExecuteScalar<decimal>(@"select ExaminePrice from Settings where ID='1' ");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static decimal getreExaminePrice()
        {
            try
            {
                return ExecuteScalar<decimal>(@"select Re_ExaminePrice from Settings where ID='1'");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static byte getDaysBetween()
        {
            try
            {
                return ExecuteScalar<byte>(@"select Days_Between from Settings where ID='1'");
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
