using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClinicCat.BackEnd.Visit;
using ClinicCat.BackEnd;
namespace ClinicCat.FrontEnd.Visits
{
    public static class VisitsLogic
    {
        private static List<TextBox> containerList;
        private static List<string> dataList;
        private static StringBuilder additionalServices;
        static VisitsLogic()
        {
            dataList = new List<string>();

        }
        public static int? ToNullableInt(string stringInput)
        {
            int outputInt;
            if (int.TryParse(stringInput, out outputInt)) return outputInt;
            return null;
        }
        public static void PatientInfo(List<TextBox> list)
        {
            containerList = new List<TextBox>();
            containerList = list;
            dataList = getPatientInfo(ToNullableInt(containerList[0].Text), containerList[1].Text, containerList[2].Text);
            try
            {
                foreach (TextBox textbox in containerList)
                {
                    containerList[0].Text = dataList[0];
                    containerList[1].Text = dataList[1];
                    containerList[2].Text = dataList[2];
                }
            }
            catch (Exception)
            {
                //patient doesnt exist -->open add patient

                throw;
            }

        }
        public static void PopulateCheckedListBox(CheckedListBox clb)
        {
            foreach (string service in getServices_CheckedListBox())
            {
                clb.Items.Add(service);
            }
        }
        public static void PopulateListBox(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (string service in getNames_listbox())
            {
                listbox.Items.Add(service);
            }
        }
        public static void RemoveVisitFromListbox(ListBox listbox)
        {
            string name = listbox.SelectedItem.ToString();
            int index = listbox.SelectedIndex;
            DeleteVisit(name);
            PopulateListBox(listbox);
            //listbox.SelectedIndex = (index == 0) ? index + 1 : index - 1;
            SetSelection(index, listbox);

        }
        public static void SetSelection(int index, ListBox listbox)
        {
            if (index == 0)
            {
                if (listbox.Items.Count > 0)
                {
                    listbox.SelectedIndex = 0;
                }
            }
            else
            {
                listbox.SelectedIndex = index - 1;
            }
        }
        public static void ChangePriority(ListBox listbox, string direction)
        {
            string selectedName = string.Empty;
            if (direction == "up")
            {
                foreach (string name in listbox.SelectedItems)
                {
                    getVisitID_By_Name(name);
                    selectedName = name;
                }
                getVisitID_LessInPriority();
                MoveUp();
                PopulateListBox(listbox);
                listbox.SelectedItem = selectedName;
            }
            else
            {
                foreach (string name in listbox.SelectedItems)
                {
                    getVisitID_By_Name(name);
                    selectedName = name;
                }
                getVisitID_MoreInPriority();
                MoveDown();
                PopulateListBox(listbox);
                listbox.SelectedItem = selectedName;
            }

        }
        public static void CalculateTotalRequired(ComboBox cmbx, TextBox num, CheckedListBox clb)
        {
            num.Text = "0";
            if (cmbx.SelectedIndex == 0)
            {
                num.Text = Setting.getExaminePrice().ToString();
            }
            else
            {
                num.Text = Setting.getreExaminePrice().ToString(); ;
            }
            foreach (string service in clb.CheckedItems)
            {
                num.Text = (Decimal.Parse(num.Text) + Service.getService_Price_by_Name(service)).ToString();
            }
        }
        public static void CalculateTotalRequiredForEdit(TextBox num, CheckedListBox clb)
        {
            num.Text = "0";
            foreach (string service in clb.CheckedItems)
            {
                num.Text = (Decimal.Parse(num.Text) + Service.getService_Price_by_Name(service)).ToString();
            }
        }
        public static StringBuilder AdditionalServicesAppend(CheckedListBox clb)
        {
            if (clb.CheckedItems.Count > 0)
            {
                additionalServices = new StringBuilder();
                foreach (string service in clb.CheckedItems)
                {
                    additionalServices.Append(service);
                    if (additionalServices.Length > 0)
                    {
                        additionalServices.Append(Environment.NewLine);
                    }
                }
                return additionalServices;
            }
            else
            {
                return null;
            }


        }
    }
}
