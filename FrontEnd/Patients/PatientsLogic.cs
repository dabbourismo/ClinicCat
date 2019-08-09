using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Patient;

namespace ClinicCat.FrontEnd.Patients
{
    public static class PatientsLogic
    {
        public static void RefreshAfterAdd(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count >= 0)
            {
                try
                {
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                    dgv.ColumnHeadersVisible = false;

                    dgv.DataSource = getPatients();
                    dgv.CurrentCell = dgv[1, dgv.Rows.Count - 1];
                    dgv.FirstDisplayedScrollingRowIndex = dgv.SelectedRows[0].Index;

                    dgv.ColumnHeadersVisible = true;
                }
                catch { }
            }

        }
        public static void RefreshAfterEdit(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int Row = dgv.CurrentRow.Index;
                dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                dgv.ColumnHeadersVisible = false;

                dgv.DataSource = getPatients();

                dgv.ColumnHeadersVisible = true;
                try
                {
                    dgv.CurrentCell = dgv[1, Row];
                    dgv.FirstDisplayedScrollingRowIndex = dgv.SelectedRows[0].Index;
                }
                catch { }
            }
        }
        public static void SearchButton(DataGridView dgv, TextBox txtbx,ComboBox cmbx, int? ID,bool non)
        {
            //search using barcode
            if (ID.HasValue)
            {
                dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                dgv.ColumnHeadersVisible = false;
                dgv.DataSource = Search(ID, null, null);
                dgv.ColumnHeadersVisible = true;
            }
            else
            {
                if (non==true)
                {
                    if (string.IsNullOrEmpty(txtbx.Text))
                    {
                        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                        dgv.ColumnHeadersVisible = false;
                        dgv.DataSource = getPatients();
                        dgv.ColumnHeadersVisible = true;
                    }
                }
                //get all patients when he delete text
                
                else
                {
                    //search by wife name
                    if (cmbx.SelectedIndex == 0)
                    {
                        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                        dgv.ColumnHeadersVisible = false;
                        dgv.DataSource = Search(null,txtbx.Text,null);
                        dgv.ColumnHeadersVisible = true;
                    }
                    //search by wife phone
                    else
                    {
                        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                        dgv.ColumnHeadersVisible = false;
                        dgv.DataSource = Search(null, null,txtbx.Text);
                        dgv.ColumnHeadersVisible = true;
                    }
                   
                }
              
            }

        }
        public static void DeleteButton(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int Row = dgv.CurrentRow.Index;
                DialogResult r = MessageBox.Show("هل انت متأكد من رغبتك في حذف المريض ؟", "تنبيه", MessageBoxButtons.YesNo);
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    if (r == DialogResult.Yes)
                    {
                        Delete(row.Cells[0].Value.ToString());
                        MessageBox.Show("تم مسح المريض");
                        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                        dgv.ColumnHeadersVisible = false;
                        dgv.DataSource = getPatients();
                        dgv.ColumnHeadersVisible = true;
                        dgv.Focus();
                        try
                        {
                            dgv.CurrentCell = dgv[1, Row - 1];
                            dgv.FirstDisplayedScrollingRowIndex = dgv.SelectedRows[0].Index;
                        }
                        catch { }
                    }
                }
            }
        }
        public static List<string> EditButton(DataGridView dgv)
        {
            int Row = dgv.CurrentRow.Index;
            List<string> parameters = new List<string>();
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                parameters.Add(dgv[i, Row].Value.ToString());
            }
            return parameters;
        }
    }
}
