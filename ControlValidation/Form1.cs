
using System;
using System.Windows.Forms;
using ControlsValidation;

namespace ControlValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation.IsValidControl(textBox1,comboBox1))
                MessageBox.Show("Controls Aren't Empty/Null");
        }
    }
}
