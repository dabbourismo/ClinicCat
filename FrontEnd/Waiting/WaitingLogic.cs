using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicCat.BackEnd;
namespace ClinicCat.FrontEnd.Waiting
{
    public static class WaitingLogic
    {
        public static void PopulateListBox(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (string service in Visit.getNames_listbox())
            {
                listbox.Items.Add(service);
            }
        }
  
    }
}
