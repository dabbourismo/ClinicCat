using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Category;

namespace ClinicCat.FrontEnd.Categories
{
    public partial class frmCategoryCRUD : Form
    {
        private frmCategory frmCategory;

        private List<string> parameters = new List<string>();
        //add constructor
        public frmCategoryCRUD(frmCategory owner)
        {
            InitializeComponent();
            frmCategory = owner;
        }
        //update constructor
        public frmCategoryCRUD(frmCategory owner, List<string> parameters)
        {
            InitializeComponent();
            frmCategory = owner;
            this.parameters = parameters;
            if (parameters.Count > 0)
            {
                txtName.Text = parameters[1]; //>cat_name
                try
                {
                    btnColorPicker.BackColor = ColorTranslator.FromHtml(parameters[2]);
                }
                catch (Exception)
                {

                    btnColorPicker.BackColor = ColorTranslator.FromHtml('#'+parameters[2]);
                }
                //>cat_color
            }
        }



        private void BtnColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                btnColorPicker.BackColor = colorDialog1.Color;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //add-update button
        private void BtnCRUD_Click(object sender, EventArgs e)
        {
            //update
            if (parameters.Count > 0)
            {
                try
                {
                    if (Edit(int.Parse(parameters[0]), txtName.Text, btnColorPicker.BackColor.Name.ToString()))
                    {
                        frmCategory.Focus();
                        CategoriesLogic.RefreshAfterEdit(frmCategory.dataGridView1);
                        parameters.Clear();
                        parameters.TrimExcess();
                        this.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }


            }

            //add
            else
            {
                try
                {
                    if (Insert(txtName.Text, btnColorPicker.BackColor.Name.ToString()))
                    {
                        frmCategory.Focus();
                        CategoriesLogic.RefreshAfterAdd(frmCategory.dataGridView1);
                        this.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
