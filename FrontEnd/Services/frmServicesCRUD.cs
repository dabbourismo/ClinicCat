using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Service;

namespace ClinicCat.FrontEnd.Services
{
    public partial class frmServicesCRUD : Form
    {
        private frmServices frmServices;

        private List<string> parameters = new List<string>();
        //add constructor
        public frmServicesCRUD(frmServices owner)
        {
            InitializeComponent();
            frmServices = owner;

        }
        public frmServicesCRUD(frmServices owner, List<string> parameters)
        {
            InitializeComponent();
            frmServices = owner;
            this.parameters = parameters;
            if (parameters.Count > 0)
            {
                txtName.Text = parameters[1]; //>name
                numServicePrice.Value = decimal.Parse(parameters[2]); //>price
            }
        }
        private void BtnCRUD_Click(object sender, EventArgs e)
        {
            if (parameters.Count > 0)
            {
                try
                {
                    if (Edit(int.Parse(parameters[0]), txtName.Text,numServicePrice.Value))
                    {
                        frmServices.Focus();
                        ServicesLogic.RefreshAfterEdit(frmServices.dataGridView1);
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
                    if (Insert(txtName.Text, numServicePrice.Value))
                    {
                        frmServices.Focus();
                        ServicesLogic.RefreshAfterAdd(frmServices.dataGridView1);
                        this.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
