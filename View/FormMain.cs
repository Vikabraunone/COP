using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonControlSelected_Click(object sender, EventArgs e)
        {
            new FormControlSelected().ShowDialog();
        }

        private void buttonControlEntered_Click(object sender, EventArgs e)
        {
            new FormControlEntered().ShowDialog();
        }

        private void buttonControlListGetting_Click(object sender, EventArgs e)
        {
            new FormControlListGetting().ShowDialog();
        }
    }
}
