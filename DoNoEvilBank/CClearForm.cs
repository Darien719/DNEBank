using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNoEvilBank
{

    //Static class for clearing controls by passing it a container of controls
    static class CClearForm
    {
        //Pass controls here to clear them all, add more as we go
        public static void ClearScreenControls(Control objContainer)
        {

            String strControlType = "";

            foreach (Control obj in objContainer.Controls)
            {
                strControlType = obj.GetType().ToString();

                switch (strControlType)
                {
                    case "System.Windows.Forms.TextBox":
                        TextBox cntrlText = (TextBox)obj;
                        cntrlText.Clear();
                        break;
                    case "System.Windows.Forms.CheckBox":
                        CheckBox cntrlCheck = (CheckBox)obj;
                        cntrlCheck.Checked = false;
                        break;
                    case "System.Windows.Forms.ComboBox":
                        ComboBox cntrlCombo = (ComboBox)obj;
                        cntrlCombo.SelectedIndex = -1;
                        break;
                    case "System.Windows.Forms.RadioButton":
                        RadioButton cntrlRad = (RadioButton)obj;
                        cntrlRad.Checked = false;
                        break;
                    case "System.Windows.Forms.MaskedTextBox":
                        MaskedTextBox cntrlMasked = (MaskedTextBox)obj;
                        cntrlMasked.Clear();
                        break;
                    //Call itself recursively if it finds a masked text box
                    case "System.Windows.Forms.GroupBox":
                        GroupBox cntrlGroup = (GroupBox)obj;
                        ClearScreenControls(cntrlGroup);
                        break;
                   default:
                        //Do nothing
                        break;
                }
            }
        }
    }
}
