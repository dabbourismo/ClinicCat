using System;
using System.IO;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Waiting;
namespace ClinicCat.FrontEnd.Waiting
{
    public partial class frmWaiting : Form
    {
        private Timer RefreshTimer;
        private int iScroll;
        string strString;
        public frmWaiting()
        {
            InitializeComponent();
            StartTimer();
            WaitingLogic.PopulateListBox(listbxWaitingQueue);
            SaveData(GetVideo());
            DataAccessLayer.DataAccessLayer.cm.CommandText = "select News from Settings";
            strString = DataAccessLayer.DataAccessLayer.cm.ExecuteScalar().ToString();
        }

        public static byte[] GetVideo()
        {
           DataAccessLayer.DataAccessLayer.cm.CommandText = "select VideoURL from Settings";
            return DataAccessLayer.DataAccessLayer.cm.ExecuteScalar() as byte[];
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

        protected bool SaveData( byte[] Data)
        {
            BinaryWriter Writer = null;
            string Name = @"D:\a.mp4";

            try
            {
                // Create a new stream to write to the file
                Writer = new BinaryWriter(File.OpenWrite(Name));

                // Writer raw data                
                Writer.Write(Data);
                Writer.Flush();
                Writer.Close();
                axWindowsMediaPlayer1.URL = Name;
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.Ctlcontrols.next();
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.enableContextMenu = false;
                axWindowsMediaPlayer1.uiMode = "None";
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            }
            catch
            {
                //...
                return false;
            }

            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
            iScroll = iScroll + 1;

            int iLmt = strString.Length - iScroll;
            if (iLmt < 180)
            {
                iScroll = 0;
            }
            string str = strString.Substring(iScroll, 180);
            label51.Text = str;
        }
    }
}
