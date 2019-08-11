using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Setting;
namespace ClinicCat.FrontEnd.Settings
{
    public partial class frmSettings : Form
    {
        private string videoPath;
        private string backupPath;
        private List<string> containerList;

        public frmSettings()
        {
            InitializeComponent();

            containerList = new List<string>();
            containerList = GetSettings(1);
            if (containerList.Count>0)
            {
                backupPath = containerList[0];
                videoPath = containerList[1];
                txtNews.Text = containerList[2];
                numDaysBetween.Value = decimal.Parse(containerList[3]);
                numExaminePrice.Value = decimal.Parse(containerList[4]);
                numRe_ExaminePrice.Value = decimal.Parse(containerList[5]);
            }
           
            SettingsLogic.ShowPicture(videoPath, picVideoConfirm);
            SettingsLogic.ShowPicture(backupPath, picVideoConfirm);
        }

        private void BtnVideoURL_Click(object sender, EventArgs e)
        {
            ofdChooseVideo.ShowDialog();
        }

        private void BtnBackupURL_Click(object sender, EventArgs e)
        {
            sfdBackupPath.ShowDialog();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (containerList.Count == 0)
            {
                if (Insert(backupPath,videoPath,txtNews.Text, byte.Parse(numDaysBetween.Value.ToString()), numExaminePrice.Value, numRe_ExaminePrice.Value))
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                }
            }
            else
            {
                if (Edit(1, backupPath, videoPath, txtNews.Text, byte.Parse(numDaysBetween.Value.ToString()), numExaminePrice.Value, numRe_ExaminePrice.Value))
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                }
            }
           
        }
        //لما اليوزر يختار الفيديو اية اللى يحصل؟
        private void OfdChooseVideo_FileOk(object sender, CancelEventArgs e)
        {
            videoPath = ofdChooseVideo.FileName;
            SettingsLogic.ShowPicture(videoPath, picVideoConfirm);
        }
    }
}
