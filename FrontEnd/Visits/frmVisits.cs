using System;
using System.Windows.Forms;
using System.Collections.Generic;
using static ClinicCat.BackEnd.Visit;
using System.Text;
using ClinicCat.BackEnd;
using ClinicCat.FrontEnd.Patients;
using System.Linq;
using ClinicCat.FrontEnd.Payments;

namespace ClinicCat.FrontEnd.Visits
{
    public partial class frmVisits : Form
    {
        private StringBuilder additionalServices;
        public frmVisits()
        {
            InitializeComponent();
            VisitsLogic.PopulateCheckedListBox(clbAdditionalServices);
            VisitsLogic.PopulateListBox(listbxWaitingQueue);
            cmbxVisitType.SelectedIndex = 0;
            if (listbxWaitingQueue.Items.Count == 1)
            {
                btnUp.Enabled = false;
                btnDown.Enabled = false;
            }
        }
        //Get Patient Info

        private void PatientGroupBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    VisitsLogic.PatientInfo(new List<TextBox>() { txtPatientID, txtPatientName, txtPatientPhone });
                    //شوف لو علية فلوس
                    //1-هات الفيزيت اي دي

                    //2-هات الفلوس اللى علية بالفيزيت اي دي دة
                    /*-------------------------------*/
                    int visitID = getVisitID_To_Check_Payment(txtPatientName.Text);
                    if (Payment.get_Required_Payment(visitID) != Payment.get_Previous_Payment(visitID))
                    {
                        DialogResult Dialog = MessageBox.Show("المريض علية فلوس هل تريد تدفع ؟", "تنبيه", MessageBoxButtons.YesNo);
                        if (Dialog == DialogResult.Yes)
                        {
                            //افتح فورمه الدفع و باصيلها الفيزيت اي دي
                            if (Application.OpenForms.OfType<frmPaymentCRUD>().Any())
                            {
                                return;
                            }
                            else
                            {
                                new frmPaymentCRUD(null, new List<string>(), visitID, int.Parse(txtPatientID.Text)).Show();
                            }
                        }
                    }
                    /*-------------------------------*/
                    //disable textboxes
                    ValidationMethods.Enable_DisableTextBoxes(new List<TextBox>() { txtPatientID, txtPatientName, txtPatientPhone }, false);
                    //check if reservation exists, if yes : insert reciption time
                    if (CheckForVisit(int.Parse(txtPatientID.Text)))
                    {
                        DialogResult Dialog = MessageBox.Show("تسجيل حضور المريض ؟", "تنبيه", MessageBoxButtons.YesNo);
                        if (Dialog == DialogResult.Yes)
                        {
                            RegisterVisit();
                            VisitsLogic.PopulateListBox(listbxWaitingQueue);
                            BtnNewReservation_Click(sender, e);
                            if (listbxWaitingQueue.Items.Count == 1)
                            {
                                btnUp.Enabled = false;
                                btnDown.Enabled = false;
                            }
                            else
                            {
                                btnUp.Enabled = true;
                                btnDown.Enabled = true;
                            }
                        }
                        else
                        {
                            BtnNewReservation_Click(sender, e);
                        }
                    }
                }
                catch (Exception)
                {
                    DialogResult Dialog = MessageBox.Show("مريض غير موجود، هل تود اضافة هذا المريض الان؟", "تنبيه", MessageBoxButtons.YesNo);
                    if (Dialog == DialogResult.Yes)
                    {
                        //افتح شاشة اضافة مريض (دوس على الزرار يعني)
                        btnInsertPatient_Click(sender, e);
                    }

                }


            }

        }

        private void BtnAddReservation_Click(object sender, EventArgs e)
        {

            // 0>(حجزت بالتليفون) 
            // 1>(انتظار أو حجزت عادي)
            // 2>(دخلت للدكتور)
            // 3>(خلصت كشف )
            byte visitState = (chkIsPhone.Checked) ? (byte)0 : (byte)1;
            //preparing checklistbox for add            
            additionalServices = VisitsLogic.AdditionalServicesAppend(clbAdditionalServices);
            //convert visit_type to bool
            bool visitType = (cmbxVisitType.SelectedIndex == 0) ? true : false;
            //inserting into visits table
            try
            {

                if (Insert(int.Parse(txtPatientID.Text), dtpVisitDate.Value.ToString("yyyy-MM-dd"), visitType, chkIsPhone.Checked,
                    additionalServices, visitState, Decimal.Parse(txtRequired.Text)))
                {
                    //0-insert payment
                    int visitID = Payment.Get_VisitID_for_Payment(int.Parse(txtPatientID.Text));
                    if (visitID != 0)
                    {
                        Payment.InsertPayment(txtPatientName.Text, true, visitID, int.Parse(txtPatientID.Text), DateTime.Now.ToString("yyyy-MM-dd"),
                                                Decimal.Parse(txtPayed.Text));
                        //1-populate list box
                        VisitsLogic.PopulateListBox(listbxWaitingQueue);
                    }
                    //2-loop on textboxes and make them enabled
                    BtnNewReservation_Click(sender, e);
                    MessageBox.Show("تم الحجز بنجاح");
                    if (listbxWaitingQueue.Items.Count == 1)
                    {
                        btnUp.Enabled = false;
                        btnDown.Enabled = false;
                    }
                    else
                    {
                        btnUp.Enabled = true;
                        btnDown.Enabled = true;
                    }
                }
                else { MessageBox.Show("يوجد حجز مفتوح لنفس الحالة"); }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CmbxVisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisitsLogic.CalculateTotalRequired(cmbxVisitType, txtTotal, clbAdditionalServices);

        }

        private void ClbAdditionalServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisitsLogic.CalculateTotalRequired(cmbxVisitType, txtTotal, clbAdditionalServices);

        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            try
            {
                VisitsLogic.ChangePriority(listbxWaitingQueue, "up");
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            try
            {
                VisitsLogic.ChangePriority(listbxWaitingQueue, "down");
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void BtnDeleteVisit_Click(object sender, EventArgs e)
        {
            VisitsLogic.RemoveVisitFromListbox(listbxWaitingQueue);
        }

        //اضافة مريض
        private void btnInsertPatient_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPatientsCRUD>().Any())
            {
                return;
            }
            else
            {
                new frmPatientsCRUD().Show();
            }
        }
        //تعديل مريض
        private void BtnUpdatePatient_Click(object sender, EventArgs e)
        {
            if (txtPatientID.TextLength > 0)
            {
                if (Application.OpenForms.OfType<frmPatientsCRUD>().Any())
                {
                    return;
                }
                else
                {
                    new frmPatientsCRUD(null, new List<string>(), int.Parse(txtPatientID.Text),null).Show();
                }
            }
            VisitsLogic.PatientInfo(new List<TextBox>() { txtPatientID, txtPatientName, txtPatientPhone });
        }


        private void BtnNewReservation_Click(object sender, EventArgs e)
        {
            ValidationMethods.Enable_DisableTextBoxes(new List<TextBox>() { txtPatientID, txtPatientName, txtPatientPhone }, true);
            ValidationMethods.ClearTextBoxes(new List<TextBox>() { txtPatientID, txtPatientName, txtPatientPhone });
            cmbxVisitType.SelectedIndex = 0;
            ValidationMethods.ClearCheckedListBoxSelection(clbAdditionalServices);
            ValidationMethods.ClearTextBoxesNumbers(new List<TextBox>() { txtDiscount, txtPayed, txtRemaining });
            VisitsLogic.CalculateTotalRequired(cmbxVisitType, txtTotal, clbAdditionalServices);

        }
        //calculate required




        private void NumDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Decimal.Parse(txtDiscount.Text) > Decimal.Parse(txtTotal.Text)) || (Decimal.Parse(txtDiscount.Text) < 0))
            {
                txtDiscount.Text = txtTotal.Text;
            }
            txtRequired.Text = (Decimal.Parse(txtTotal.Text) - Decimal.Parse(txtDiscount.Text)).ToString();
        }





        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationMethods.NumberValidation(sender, e);

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationMethods.NumberValidation(sender, e);

        }

        private void txtRequired_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationMethods.NumberValidation(sender, e);

        }

        private void txtPayed_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationMethods.NumberValidation(sender, e);

        }

        private void txtRemaining_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationMethods.NumberValidation(sender, e);

        }


        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtDiscount_TextChanged(sender, e);
            txtPayed_TextChanged(sender, e);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
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

        private void txtPayed_TextChanged(object sender, EventArgs e)
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

        private void txtRequired_TextChanged(object sender, EventArgs e)
        {
            txtPayed.Text = txtRequired.Text;
        }

       
    }
}
