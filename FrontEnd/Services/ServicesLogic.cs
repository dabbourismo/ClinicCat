using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Service;
namespace ClinicCat.FrontEnd.Services
{
    class ServicesLogic
    {
        public static void RefreshAfterAdd(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count >= 0)
            {
                try
                {
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                    dgv.ColumnHeadersVisible = false;

                    dgv.DataSource = getServices();
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

                dgv.DataSource = getServices();

                dgv.ColumnHeadersVisible = true;
                try
                {
                    dgv.CurrentCell = dgv[1, Row];
                    dgv.FirstDisplayedScrollingRowIndex = dgv.SelectedRows[0].Index;
                }
                catch { }
            }
        }
        public static void SearchButton(DataGridView dgv, TextBox txtbx, bool non)
        {
            if (non == true)
            {
                if (string.IsNullOrEmpty(txtbx.Text))
                {
                    dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                    dgv.ColumnHeadersVisible = false;
                    dgv.DataSource = getServices();
                    dgv.ColumnHeadersVisible = true;
                }
            }
            else
            {
                dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                dgv.ColumnHeadersVisible = false;
                dgv.DataSource = Search(txtbx.Text);
                dgv.ColumnHeadersVisible = true;
            }

        }
        public static void DeleteButton(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int Row = dgv.CurrentRow.Index;
                DialogResult r = MessageBox.Show("هل انت متأكد من رغبتك في حذف الخدمة ؟", "تنبيه", MessageBoxButtons.YesNo);
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    if (r == DialogResult.Yes)
                    {
                        Delete(row.Cells[0].Value.ToString());
                        MessageBox.Show("تم مسح الخدمة");
                        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
                        dgv.ColumnHeadersVisible = false;
                        dgv.DataSource = getServices();
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
