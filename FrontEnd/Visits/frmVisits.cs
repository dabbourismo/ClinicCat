using System;
using System.Windows.Forms;
using System.Collections.Generic;
using static ClinicCat.BackEnd.Visit;
using System.Text;

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
        }
        //Get Patient Info

        private void PatientGroupBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    VisitsLogic.PatientInfo(new List<TextBox>() { txtPatientID, txtPatientName, txtPatientPhone });

                    //check if reservation exists, if yes : insert reciption time
                    if (CheckForVisit(int.Parse(txtPatientID.Text)))
                    {
                        DialogResult Dialog = MessageBox.Show("تسجيل حضور المريض ؟", "تنبيه", MessageBoxButtons.YesNo);
                        if (Dialog == DialogResult.Yes)
                        {
                            RegisterVisit();
                            VisitsLogic.PopulateListBox(listbxWaitingQueue);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("مريضة غير موجودة");
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
                    additionalServices, visitState))
                {
                    MessageBox.Show("Success");
                    //1-loop on textboxes and make them empty
                    //2-populate list box
                    VisitsLogic.PopulateListBox(listbxWaitingQueue);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CmbxVisitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisitsLogic.CalculateTotalRequired(cmbxVisitType, lblTotal,clbAdditionalServices);
        }

        private void ClbAdditionalServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisitsLogic.CalculateTotalRequired(cmbxVisitType, lblTotal, clbAdditionalServices);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            VisitsLogic.ChangePriority(listbxWaitingQueue,"up");         
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            VisitsLogic.ChangePriority(listbxWaitingQueue, "down");
        }

        private void BtnDeleteVisit_Click(object sender, EventArgs e)
        {
            VisitsLogic.RemoveVisitFromListbox(listbxWaitingQueue);
        }

        private void btnInsertPatient_Click(object sender, EventArgs e)
        {
        }
    }
}
