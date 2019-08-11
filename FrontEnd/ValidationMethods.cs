using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
namespace ClinicCat.FrontEnd
{
    public static class ValidationMethods
    {
        public static void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        public static void ClearNumericUpDown(List<NumericUpDown> NumericUpDown)
        {
            foreach (NumericUpDown numericupdown in NumericUpDown)
            {
                numericupdown.Value = 0;
            }
        }
        public static void ClearTextBoxes(List<TextBox> textBoxlist)
        {
            foreach (TextBox txtbox in textBoxlist)
            {
                txtbox.Text = String.Empty;
            }
        }
        public static void Enable_DisableTextBoxes(List<TextBox> textBoxlist, bool isEnabled)
        {
            if (isEnabled == true)
            {
                foreach (TextBox txtbox in textBoxlist)
                {
                    txtbox.Enabled = true;
                }
            }
            else
            {
                foreach (TextBox txtbox in textBoxlist)
                {
                    txtbox.Enabled = false;
                }
            }

        }
        public static void ClearCheckedListBoxSelection(CheckedListBox chkedListBox)
        {
            for (int i = 0; i < chkedListBox.Items.Count; i++)
            {
                chkedListBox.SetItemCheckState(i, (false ? CheckState.Checked : CheckState.Unchecked));
            }
                
        }


    }
}
