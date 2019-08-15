using ClinicCat.FrontEnd.Patients;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using static ClinicCat.BackEnd.VisitDetails;
namespace ClinicCat.FrontEnd.VisitsDetails
{
    public partial class frmVisitsDetails : Form
    {
        public frmVisitsDetails()
        {
            InitializeComponent();
            ValidationMethods.OptimizeDataGridView(dataGridView1);
            this.dataGridView1.DataSource = getVisits();
            dataGridView1.ColumnHeadersVisible = true;
            ShowNumberOfVisits();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //كود المريضة
            if (comboCriteria.SelectedIndex == 0)
            {
                VisitsDetailsLogic.SearchButton(dataGridView1, txtSearch, "code", false, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));
                ShowNumberOfVisits();
            }
            //اسم المريضة
            if (comboCriteria.SelectedIndex == 1)
            {
                VisitsDetailsLogic.SearchButton(dataGridView1, txtSearch, "name", false, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));
                ShowNumberOfVisits();
            }

            //هاتف المريضة
            if (comboCriteria.SelectedIndex == 2)
            {
                VisitsDetailsLogic.SearchButton(dataGridView1, txtSearch, "phone", false, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));
                ShowNumberOfVisits();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            VisitsDetailsLogic.SearchButton(dataGridView1, txtSearch, "", true, dtpFrom.Value.ToString("yyyy-MM-dd"), dtpTo.Value.ToString("yyyy-MM-dd"));
            ShowNumberOfVisits();
        }
        private void ShowNumberOfVisits()
        {
            lblNumberOfVisits.Text = dataGridView1.Rows.Count.ToString();
        }

        private void BtnPatientInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد مرضى");
            }
            else
            {
                if (Application.OpenForms.OfType<frmPatientsCRUD>().Any())
                {
                    return;
                }
                else
                {
                    if (dataGridView1.SelectedRows.Count>0)
                    {
                        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        new frmPatientsCRUD(null, new List<string>(),int.Parse(selectedRow.Cells[1].Value.ToString()), "الحجز").Show();
                    }
                    
                }
            }
        }
    }
}
