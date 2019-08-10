﻿using System;
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
    public partial class frmPaymentCRUD : Form
    {
        frmPayments frmPayments;
        List<string> parameters = new List<string>();
        //اضافة مصروف خارجي
        public frmPaymentCRUD(frmPayments owner)
        {
            InitializeComponent();
            this.frmPayments = owner;
            numRemaining.Visible = false;
            numRequired.Visible = false;
            numPayed.Visible = false;
            numPreviousPayed.Visible = false;

            lblRemaining.Visible = false;
            lblRequired.Visible = false;
            lblPayed.Visible = false;
            lblPreviousPayed.Visible = false;


        }
        //تعديل مصروف خارجي

        //دفع باقي فلوس العيان
        public frmPaymentCRUD(frmPayments owner, List<string> parameters)
        {
            InitializeComponent();
            frmPayments = owner;
            this.parameters = parameters;
            numRequired.Value = get_Required_Payment(int.Parse(parameters[6]));
            numPreviousPayed.Value = get_Previous_Payment(int.Parse(parameters[6]));

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //مدفوع لمريض
            if (parameters.Count > 0)
            {
                if (get_Required_Payment(int.Parse(parameters[6])) == get_Previous_Payment(int.Parse(parameters[6])))
                {
                    MessageBox.Show("المريض دفع كله");
                }
                else
                {
                    InsertPayment(parameters[1], true, int.Parse(parameters[6]), int.Parse(parameters[3]), dtpPayDate.Value.ToString("yyyy-MM-dd"), numPayed.Value);
                    frmPayments.Focus();
                    PaymentsLogic.RefreshAfterAdd(frmPayments.dataGridView1);
                    this.Close();
                }
            }
            //اضافة مصروف خارجي
            if (numRemaining.Visible == false)
            {
                bool Direction = cmbxDirection.SelectedIndex == 0 ? false : true;

                InsertPayment(txtPersonName.Text, Direction, 0, 0, dtpPayDate.Value.ToString("yyyy-MM-dd"), numOtherPayed.Value);
                frmPayments.Focus();
                PaymentsLogic.RefreshAfterAdd(frmPayments.dataGridView1);
                this.Close();
            }
        }

        private void CalculateRemaining(object sender, EventArgs e)
        {
            numRemaining.Value = numRequired.Value - numPreviousPayed.Value;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxDirection.SelectedIndex == 0)
            {
                lblDirection.Text = "الصادر";
            }
            if (cmbxDirection.SelectedIndex == 1)
            {
                lblDirection.Text = "الوارد";
            }
        }
    }
}
