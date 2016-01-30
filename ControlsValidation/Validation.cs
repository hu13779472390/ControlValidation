using System.Windows.Forms;

namespace ControlsValidation
{
    /// <summary>
    /// Validation Class
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Indicates whether the all Specified Comboboxes are not Empty/Null.
        /// </summary>
        /// <param name="ComboBoxList">ComboBox list</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidComboBoxes(params ComboBox[] ComboBoxList)
        {
            foreach (ComboBox con in ComboBoxList)
            {
                if (con.SelectedIndex == -1)
                {
                    con.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the Specified single Combobox is not Empty/Null.
        /// </summary>
        /// <param name="combobox">Combobox</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidComboBox(ComboBox combobox)
        {
            if (combobox.SelectedIndex == -1)
            {
                combobox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the all Specified TextBoxes are not Empty/Null.
        /// </summary>
        /// <param name="TextBoxList">Textbox list</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidTextBoxes(params TextBox[] TextBoxList)
        {
            foreach (TextBox con in TextBoxList)
            {
                if (string.IsNullOrEmpty(con.Text))
                {
                    con.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the all Specified TextBoxes are not Empty/Null.
        /// </summary>
        /// <param name="Textbox">Textbox</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidTextBox(TextBox Textbox)
        {
            if (string.IsNullOrEmpty(Textbox.Text))
            {
                Textbox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the DatagridView has atleaset one row and Cell[0,0] value is not Empty/Null.
        /// </summary>
        /// <param name="dgv">DataGridView</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidDatagridView(DataGridView dgv)
        {
            if (dgv[0, 0].Value == null && dgv.Rows.Count < 1)
            {
                dgv.CurrentCell = dgv[0, 0];
                return false;
            }
            return true;
        }

        /// <summary>
        /// Indicates whether the all Specified Control are not Empty/Null.
        /// </summary>
        /// <param name="cont">Control list</param>
        /// <returns>
        /// Boolean Value
        /// </returns>
        public static bool IsValidControl(params Control[] cont)
        {
            foreach (Control con in cont)
            {
                if ((con is TextBox) && string.IsNullOrEmpty((con as TextBox).Text))
                {
                    (con as TextBox).Focus();
                    return false;
                }
                else if ((con is ComboBox) && (con as ComboBox).SelectedIndex == -1)
                {
                    (con as ComboBox).Focus();
                    return false;
                }
            }
            return true;
        }
    }
}