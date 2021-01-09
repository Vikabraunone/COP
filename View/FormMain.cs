using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FormMain : Form
    {
        List<Student> students;

        public FormMain(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
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
            new FormControlListGetting(students).ShowDialog();
        }
    }
}
