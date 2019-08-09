using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Patient;

namespace ClinicCat.FrontEnd.Patients
{
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = getPatients();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPatientsCRUD>().Any())
            {
                return;
            }
            else
            {
                new frmPatientsCRUD(this).Show();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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
                    new frmPatientsCRUD(this, PatientsLogic.EditButton(dataGridView1)).Show();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            PatientsLogic.DeleteButton(dataGridView1);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            PatientsLogic.SearchButton(dataGridView1, txtSearch, cmbSearchCriteria, null, true);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            PatientsLogic.SearchButton(dataGridView1, txtSearch, cmbSearchCriteria, null, false);
        }
    }
}
