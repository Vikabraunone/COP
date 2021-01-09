using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class FormPdf : Form
    {
        List<Student> students;

        public FormPdf(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPath.Text) || string.IsNullOrEmpty(textBoxY.Text)
                || string.IsNullOrEmpty(textBoxX.Text))
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            componentDiagram.AxisSeriesX = students.Select(x => x.Age.ToString()).ToArray();
            componentDiagram.AxisNameX = textBoxX.Text;
            componentDiagram.AxisNameY = textBoxY.Text;
            componentDiagram.CreateDiagram(textBoxPath.Text, students.Select(x => Convert.ToDouble(x.Course)).ToArray());
            MessageBox.Show("Диаграмма создана", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSetPath_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fd = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (fd.ShowDialog() == DialogResult.OK)
                    textBoxPath.Text = fd.FileName;
            }
        }
    }
}