using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.VisitDetails;
namespace ClinicCat.FrontEnd.VisitsDetails
{
    public static class VisitsDetailsLogic
    {
        public static void SearchButton(DataGridView dgv, TextBox txtbx,string criteria,bool non,string dateFrom,string dateTo)
        {
            //التكستبوكس فاضي
            if (non == true && criteria == "")
            {
                if (string.IsNullOrEmpty(txtbx.Text))
                {
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                    dgv.ColumnHeadersVisible = false;
                    dgv.DataSource = getVisits();
                    dgv.ColumnHeadersVisible = true;
                }
            }
            else
            {
                //بحث بالكود
                if (criteria == "code")
                {
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                    dgv.ColumnHeadersVisible = false;
                    dgv.DataSource = searchVisits_By_PatientID(int.Parse(txtbx.Text), dateFrom, dateTo);
                    dgv.ColumnHeadersVisible = true;
                }
                //بحث بالاسم
                if (criteria == "name")
                {
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                    dgv.ColumnHeadersVisible = false;
                    dgv.DataSource = searchVisits_By_PatientName(txtbx.Text, dateFrom, dateTo);
                    dgv.ColumnHeadersVisible = true;
                }
                //بحث بالتليفون
                if (criteria == "phone")
                {
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                    dgv.ColumnHeadersVisible = false;
                    dgv.DataSource = searchVisits_By_PatientPhone(txtbx.Text, dateFrom, dateTo);
                    dgv.ColumnHeadersVisible = true;
                }
            }
          
           
        }
    }
}
