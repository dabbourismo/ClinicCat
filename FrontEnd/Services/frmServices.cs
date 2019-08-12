using System;
using System.Linq;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Service;

namespace ClinicCat.FrontEnd.Services
{
    public partial class frmServices : Form
    {
        public frmServices()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = getServices();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد فئات");
            }
            else
            {
                if (Application.OpenForms.OfType<frmServicesCRUD>().Any())
                {
                    return;
                }
                else
                {
                    new frmServicesCRUD(this, ServicesLogic.EditButton(dataGridView1)).Show();
                }
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmServicesCRUD>().Any())
            {
                return;
            }
            else
            {
                new frmServicesCRUD(this).Show();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ServicesLogic.DeleteButton(dataGridView1);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ServicesLogic.SearchButton(dataGridView1, txtSearch, false);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            ServicesLogic.SearchButton(dataGridView1, txtSearch, true);
        }
    }
}
