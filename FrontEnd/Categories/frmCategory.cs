using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Category;

namespace ClinicCat.FrontEnd.Categories
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing; //>vip
            dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.DataSource = getCategories();
            this.dataGridView1.Columns[0].Visible = false;
        }
        //add button
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCategoryCRUD>().Any())
            {
                return;
            }
            else
            {
                new frmCategoryCRUD(this).Show();
            }
        }



        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد فئات");
            }
            else
            {
                if (Application.OpenForms.OfType<frmCategoryCRUD>().Any())
                {
                    return;
                }
                else
                {
                    new frmCategoryCRUD(this, CategoriesLogic.EditButton(dataGridView1)).Show();
                }
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            CategoriesLogic.DeleteButton(dataGridView1);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CategoriesLogic.SearchButton(dataGridView1, txtSearch, false);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            CategoriesLogic.SearchButton(dataGridView1, txtSearch, true);
        }
    }
}
