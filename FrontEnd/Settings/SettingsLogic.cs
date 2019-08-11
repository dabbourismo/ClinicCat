using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicCat.FrontEnd.Settings
{
    public static class SettingsLogic
    {
        public static void ShowPicture(string path,PictureBox picturebox)
        {
            if (string.IsNullOrEmpty(path))
            {
                picturebox.BackgroundImage = Resources.WrongSign;
            }
            else
            {
                picturebox.BackgroundImage = Resources.RightSign;
            }
           
            
          
        }
    }
}
