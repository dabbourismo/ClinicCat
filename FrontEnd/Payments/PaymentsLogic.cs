using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Payment;
namespace ClinicCat.FrontEnd.Payments
{
    public static class PaymentsLogic
    {
        public static void RefreshAfterAdd(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count >= 0)
            {
                try
                {
                    dgv.DataSource = getPayments();
                    dgv.CurrentCell = dgv[1, dgv.Rows.Count - 1];
                    dgv.FirstDisplayedScrollingRowIndex = dgv.SelectedRows[0].Index;
                }
                catch { }
            }

        }
        public static void RefreshAfterEdit(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int Row = dgv.CurrentRow.Index;
                dgv.DataSource = getPayments();
                try
                {
                    dgv.CurrentCell = dgv[1, Row];
                    dgv.FirstDisplayedScrollingRowIndex = dgv.SelectedRows[0].Index;
                }
                catch { }
            }
        }
        public static void SearchButton(ComboBox cmbx, DataGridView dgv, TextBox txtbx, bool non, DateTimePicker dtpFrom, DateTimePicker dtpTo)
        {
            if (non == true)
            {
                if (string.IsNullOrEmpty(txtbx.Text))
                {
                    dgv.DataSource = getPayments();
                    dtpFrom.Value = DateTime.Now;
                    dtpTo.Value = DateTime.Now;
                }
            }
            else
            {
                if (cmbx.SelectedIndex == 0)
                {
                    //dgv.DataSource = Search(txtbx.Text, null, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));
                }
                else
                {
                    //dgv.DataSource = Search(null, txtbx.Text, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));
                }
            }

        }
        public static void DeleteButton(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                int Row = dgv.CurrentRow.Index;
                DialogResult r = MessageBox.Show("هل انت متأكد من رغبتك في حذف المصروف ؟", "تنبيه", MessageBoxButtons.YesNo);
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    if (r == DialogResult.Yes)
                    {
                        //Delete(row.Cells[0].Value.ToString());
                        MessageBox.Show("تم مسح المصروف");
                        dgv.DataSource = getPayments();
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
        public static void TotalPayedlabel(Label lbl, DateTimePicker dtpFrom, DateTimePicker dtpTo)
        {
           // lbl.Text = GetTotalPayed(dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd")).ToString();
        }
        public static void TotalEarnedlabel(Label lbl, DateTimePicker dtpFrom, DateTimePicker dtpTo)
        {
           // lbl.Text = GetTotalEarned(dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd")).ToString();
        }
    }
}
