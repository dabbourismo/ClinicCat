using System;
using System.Windows.Forms;
using ClinicCat.FrontEnd.Categories;
using ClinicCat.FrontEnd.Services;
using ClinicCat.FrontEnd.Patients;
using ClinicCat.FrontEnd.Visits;
using ClinicCat.FrontEnd.Settings;
using ClinicCat.FrontEnd.Waiting;
using ClinicCat.FrontEnd.Doctors;
namespace ClinicCat
{
    public partial class frmHOME : Form
    {
        frmCategory frmCategory;
        frmServices frmServices;
        frmPatients frmPatients;
        frmVisits frmVisits;
        frmSettings frmSettings;
        frmWaiting frmWaiting;
        frmDoctors frmDoctors;
        public frmHOME()
        {
            InitializeComponent();
        }

         private void Button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;

            this.Text = "الفئات";
            frmCategory = new frmCategory();
            groupBox1.Controls.Clear();
            frmCategory.TopLevel = false;
            groupBox1.Controls.Add(frmCategory);
            frmCategory.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmCategory.Dock = DockStyle.Fill;
            frmCategory.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;

            this.Text = "الخدمات";
            frmServices = new frmServices();
            groupBox1.Controls.Clear();
            frmServices.TopLevel = false;
            groupBox1.Controls.Add(frmServices);
            frmServices.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmServices.Dock = DockStyle.Fill;
            frmServices.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel3.Height = button4.Height;
            panel3.Top = button4.Top;

            this.Text = "المرضى";
            frmPatients = new frmPatients();
            groupBox1.Controls.Clear();
            frmPatients.TopLevel = false;
            groupBox1.Controls.Add(frmPatients);
            frmPatients.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;

            this.Text = "المرضى";
            frmVisits = new frmVisits();
            groupBox1.Controls.Clear();
            frmVisits.TopLevel = false;
            groupBox1.Controls.Add(frmVisits);
            frmVisits.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmVisits.Dock = DockStyle.Fill;
            frmVisits.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            panel3.Height = button6.Height;
            panel3.Top = button6.Top;

            this.Text = "الاعدادت";
            frmSettings = new frmSettings();
            groupBox1.Controls.Clear();
            frmSettings.TopLevel = false;
            groupBox1.Controls.Add(frmSettings);
            frmSettings.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmSettings.Dock = DockStyle.Fill;
            frmSettings.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            panel3.Height = button7.Height;
            panel3.Top = button7.Top;

            this.Text = "الاعدادت";
            frmWaiting = new frmWaiting();
            groupBox1.Controls.Clear();
            frmWaiting.TopLevel = false;
            groupBox1.Controls.Add(frmWaiting);
            frmWaiting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmWaiting.Dock = DockStyle.Fill;
            frmWaiting.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            panel3.Height = button8.Height;
            panel3.Top = button8.Top;

            this.Text = "الطبيب";
            frmDoctors = new frmDoctors();
            groupBox1.Controls.Clear();
            frmDoctors.TopLevel = false;
            groupBox1.Controls.Add(frmDoctors);
            frmDoctors.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmDoctors.Dock = DockStyle.Fill;
            frmDoctors.Show();
        }
    }
}
