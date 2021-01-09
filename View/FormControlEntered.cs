using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormControlEntered : Form
    {
        // Компонент ввода
        public FormControlEntered()
        {
            InitializeComponent();
        }

        private void controlTextBoxEntered_TextBoxTextChange(object sender, EventArgs e)
        {
            controlTextBoxEntered.CheckedText = controlTextBoxEntered.CurrentText;
        }
    }
}
