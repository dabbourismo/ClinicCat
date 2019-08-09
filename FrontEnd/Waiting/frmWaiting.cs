using System;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Waiting;
namespace ClinicCat.FrontEnd.Waiting
{
    public partial class frmWaiting : Form
    {
        private Timer RefreshTimer;
        public frmWaiting()
        {
            InitializeComponent();
            StartTimer();
            WaitingLogic.PopulateListBox(listbxWaitingQueue);
        }
        private void StartTimer()
        {
            RefreshTimer = new Timer();
            RefreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            RefreshTimer.Interval = 15000;
            RefreshTimer.Start();
        }

        private void FrmWaiting_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = getVideoPath();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }



        private void FrmWaiting_Leave(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            WaitingLogic.PopulateListBox(listbxWaitingQueue);
        }
    }
}
