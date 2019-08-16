using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicCat.BackEnd;
using ClinicCat.FrontEnd.Visits;

namespace ClinicCat.FrontEnd.VisitsDetails
{
    public partial class frmEditVisitsDetails : Form
    {
        private int visitID;
        private int patientID;
        frmVisitsDetails frmvisitsdetails;
        private List<string> dataList;
        public frmEditVisitsDetails(frmVisitsDetails owner,int visitID,int patientID)
        {
            InitializeComponent();
            this.frmvisitsdetails = owner;
            this.visitID = visitID;
            this.patientID = patientID;
            //populate listview
            VisitsLogic.PopulateCheckedListBox(clbAdditionalServices);
            dataList = new List<string>();

            //assign values
            txtPatientID.Text = patientID.ToString();
            txtPatientName.Text = Patient.getPatientName_By_ID(patientID);
            txtPatientPhone.Text = Patient.getPatientPhone_By_ID(patientID);
            int visitType = VisitDetails.getVisitType_By_VisitID(visitID);
            if (visitType == 0)
            {
                cmbxVisitType.SelectedIndex = 0;
            }
            else
            {
                cmbxVisitType.SelectedIndex = 1;
            }
            dtpVisitDate.Value = VisitDetails.getVisitDate_By_VisitID(visitID);
            //txtTotal.Text = VisitDetails.getRequired_By_VisitID(visitID).ToString();
            //txtRequired.Text = (VisitDetails.getRequired_By_VisitID(visitID) - Payment.get_Previous_Payment(visitID)).ToString();
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //تعديل
        }

        private void ClbAdditionalServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisitsLogic.CalculateTotalRequiredForEdit(txtTotal, clbAdditionalServices);
        }

        private void CmbxVisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VisitsLogic.CalculateTotalRequired(cmbxVisitType, txtTotal, clbAdditionalServices);
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.TextLength == 0)
            {
                txtDiscount.Text = "0";
            }
            try
            {
                if ((Decimal.Parse(txtDiscount.Text) > Decimal.Parse(txtTotal.Text)) || (Decimal.Parse(txtDiscount.Text) < 0))
                {
                    txtDiscount.Text = txtTotal.Text;
                }
                txtRequired.Text = (Decimal.Parse(txtTotal.Text) - Decimal.Parse(txtDiscount.Text)).ToString();
            }
            catch { }
        }

        private void TxtPayed_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.TextLength == 0)
            {
                txtDiscount.Text = "0";
            }
            if ((Decimal.Parse(txtPayed.Text) > Decimal.Parse(txtRequired.Text)) || (Decimal.Parse(txtPayed.Text) < 0))
            {
                txtPayed.Text = txtRequired.Text;
            }
            txtRemaining.Text = (Decimal.Parse(txtRequired.Text) - Decimal.Parse(txtPayed.Text)).ToString();
        }

        private void TxtRequired_TextChanged(object sender, EventArgs e)
        {
            txtPayed.Text = txtRequired.Text;
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
            TxtDiscount_TextChanged(sender, e);
            TxtPayed_TextChanged(sender, e);
        }
    }
}
