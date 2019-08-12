using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Doctor;
using ClinicCat.BackEnd;
using System.IO;

namespace ClinicCat.FrontEnd.Doctors
{
    public partial class frmDoctors : Form
    {
        private Timer RefreshTimer;
        public frmDoctors()
        {
            InitializeComponent();
            StartTimer();
            DoctorsLogic.PopulateListBox(listbxWaitingQueue);
            chkEnableScanTime.CheckState = CheckState.Unchecked;
            dtpScanTime.Enabled = false;

        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            DoctorsLogic.PopulateListBox(listbxWaitingQueue);
        }
        private void StartTimer()
        {
            RefreshTimer = new Timer();
            RefreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            RefreshTimer.Interval = 15000;
            RefreshTimer.Start();
        }

        private void BtnEnterPatient_Click(object sender, EventArgs e)
        {
            //reset textboxes
            ValidationMethods.ClearTextBoxes(this.Controls);
            cmbxCategory.DataSource = Category.getCategories_DropDownList();
            //add enter time
            /*0 patient id,1 patient name,2 reserve time,3 reception time,4 current visit notes,5 category name,*/
            //show details of patient
            DoctorsLogic.EnterPatient(listbxWaitingQueue, txtPatientID, txtPatientName, dtpReserveTime, dtpReceptionTime, txtCurrentVisitNotes, cmbxCategory);

        }

        private void BtnShowDetails_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (chkEnableScanTime.Checked)
            {
                Doctor_RegisterVisit_Out(txtPatientName.Text, txtNextVisitNotes.Text, txtCurrentVisitNotes.Text, dtpScanTime.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                Doctor_RegisterVisit_Out(txtPatientName.Text, txtNextVisitNotes.Text, txtCurrentVisitNotes.Text, null);

            }
            DoctorsLogic.PopulateListBox(listbxWaitingQueue);
            /*************saving picture****************/

            /*************saving picture****************/
            ValidationMethods.ClearTextBoxes(this.Controls);
        }

        private void CmbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtPatientID.TextLength > 0)
            {
                int categoryID = Category.getCategory_ID_by_Name(cmbxCategory.Text);
                Update_Patient_Category(int.Parse(txtPatientID.Text), categoryID);
            }


        }

        private void ChkEnableScanTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableScanTime.Checked)
            {
                dtpScanTime.Enabled = true;
            }
            else
            {
                dtpScanTime.Enabled = false;
            }
        }

        private void BtnAddPrescription_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnAddScans_Click(object sender, EventArgs e)
        {
            int patientID = int.Parse(txtPatientID.Text);

            if (Application.OpenForms.OfType<frmDisplayPictureAttachment>().Any())
            {
                return;
            }
            else
            {
                new frmDisplayPictureAttachment(patientID).Show();
            }
            
        }
       
    }
}
