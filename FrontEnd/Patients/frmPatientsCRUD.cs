using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Patient;
using ClinicCat.BackEnd;
namespace ClinicCat.FrontEnd.Patients
{
    public partial class frmPatientsCRUD : Form
    {
        private frmPatients frmPatients;
        private List<string> parameters = new List<string>();
        private List<string> details;
        //add constructor




    
        public frmPatientsCRUD(frmPatients owner)
        {
            InitializeComponent();
            frmPatients = owner;
            cmbxCategoryName.DataSource = Category.getCategories_DropDownList();
        }
        //edit constructor
        public frmPatientsCRUD(frmPatients owner, List<string> parameters)
        {
            InitializeComponent();
            frmPatients = owner;
            this.parameters = parameters;
            cmbxCategoryName.DataSource = Category.getCategories_DropDownList();
            if (parameters.Count > 0)
            {
                //get values using parameter[0] > patient id
                details = new List<string>();
                details = Details(int.Parse(parameters[0]));
                //assign to controls
                //**wife**//
                cmbxCategoryName.Text = Category.getCategory_Name_by_ID(details[1]);
                txtWifeName.Text = details[2];
                txtWifePhone.Text = details[3];
                txtWifeAge.Text = details[4];
                txtWifeJob.Text = details[5];
                dtpWifeBirthDate.Value = DateTime.Parse(details[6]);
                numMarryCurrent.Value = Convert.ToByte(details[7]);
                numNumOfKids.Value = Convert.ToByte(details[8]);
                txtAddress.Text = details[9];
                txtEmail.Text = details[10];
                chkDidMarry.Checked = Convert.ToBoolean(details[11]);
                try
                {
                    numOldMarryPeriod.Value = Convert.ToByte(details[12]);
                }
                catch (Exception)
                {
                    numOldMarryPeriod.Value = 0;
                }
                //**husband**//
                txtHusbandName.Text = details[13];
                txtHusbandPhone.Text = details[14];
                numHusbandAge.Value = Convert.ToByte(details[15]);
                txtHusbandJob.Text = details[16];
                dtpHusbandBirthDate.Value = DateTime.Parse(details[17]);
                txtusbandRelation.Text = details[18];
                txtHusbandEmail.Text = details[19];
                txtHusbandSmokingType.Text = details[20];
            }
        }



        private void BtnCRUD_Click(object sender, EventArgs e)
        {
            if (parameters.Count > 0)
            {
                try
                {
                    if (Edit(int.Parse(parameters[0]), cmbxCategoryName.Text, txtWifeName.Text, txtWifePhone.Text,
                        byte.Parse(txtWifeAge.Text), txtWifeJob.Text, dtpWifeBirthDate.Value.ToString("yyyy-MM-dd"),
                        byte.Parse(numMarryCurrent.Value.ToString()), byte.Parse(numNumOfKids.Value.ToString()),
                        txtAddress.Text, txtEmail.Text, chkDidMarry.Checked, byte.Parse(numOldMarryPeriod.Value.ToString()),
                        txtHusbandName.Text, txtHusbandPhone.Text, byte.Parse(numHusbandAge.Value.ToString()), txtHusbandJob.Text,
                        dtpHusbandBirthDate.Value.ToString("yyyy-MM-dd"), txtusbandRelation.Text, txtHusbandEmail.Text, txtHusbandSmokingType.Text)) ;
                    {
                        frmPatients.Focus();
                        PatientsLogic.RefreshAfterEdit(frmPatients.dataGridView1);
                        parameters.Clear();
                        details.Clear();
                        parameters.TrimExcess();
                        details.TrimExcess();
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
                    if (Insert(cmbxCategoryName.Text, txtWifeName.Text, txtWifePhone.Text,
                        byte.Parse(txtWifeAge.Text), txtWifeJob.Text, dtpWifeBirthDate.Value.ToString("yyyy-MM-dd"),
                        byte.Parse(numMarryCurrent.Value.ToString()), byte.Parse(numNumOfKids.Value.ToString()),
                        txtAddress.Text, txtEmail.Text, chkDidMarry.Checked, byte.Parse(numOldMarryPeriod.Value.ToString()),
                        txtHusbandName.Text, txtHusbandPhone.Text, byte.Parse(numHusbandAge.Value.ToString()), txtHusbandJob.Text,
                        dtpHusbandBirthDate.Value.ToString("yyyy-MM-dd"), txtusbandRelation.Text, txtHusbandEmail.Text, txtHusbandSmokingType.Text))
                    {
                        frmPatients.Focus();
                        PatientsLogic.RefreshAfterAdd(frmPatients.dataGridView1);
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
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
