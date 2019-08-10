using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Payment;
namespace ClinicCat.FrontEnd.Payments
{
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            InitializeComponent();
            dataGridView1.DataSource = getPayments();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد فئات");
            }
            else
            {
                if (Application.OpenForms.OfType<frmPaymentCRUD>().Any())
                {
                    return;
                }
                else
                {
                    new frmPaymentCRUD(this, PaymentsLogic.EditButton(dataGridView1)).Show();
                }
            }
        }

        private void BtnOtherPaymentInsert_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد فئات");
            }
            else
            {
                if (Application.OpenForms.OfType<frmPaymentCRUD>().Any())
                {
                    return;
                }
                else
                {
                    new frmPaymentCRUD(this).Show();
                }
            }
        }
    }
}
