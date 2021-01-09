using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FormComponents : Form
    {
        List<Student> students;

        public FormComponents(List<Student> students)
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

        private void buttonComponentBackUp_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                componentBackUp.CreateBackUp(students, fbd.SelectedPath);
                MessageBox.Show("Бекап создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonComponentDiagram_Click(object sender, EventArgs e)
        {
            new FormPdf(students).ShowDialog();
        }

        private void buttonComponentReport_Click(object sender, EventArgs e)
        {
            new FormComponentReport(students).Show();
        }
    }
}
