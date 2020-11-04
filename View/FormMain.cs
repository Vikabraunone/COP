using System;
using System.Collections.Generic;
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

        private void buttonComponentBackUp_Click(object sender, EventArgs e)
        {
            var students = new List<Student> {
                new Student
                {
                    FIO = "Иванов Иван Иваныч",
                    Age = 18,
                    Course = 1,
                    DateBirth = new DateTime(2001, 5, 1)
                },
                new Student
                {
                    FIO = "Петров Алексей Федорович",
                    Age = 19,
                    Course = 2,
                    DateBirth = new DateTime(2000, 8, 13)
                },
                new Student
                {
                    FIO = "Соколова Анастасия Валентиновна",
                    Age = 21,
                    Course = 4,
                    DateBirth = new DateTime(1998, 4, 20)
                }
            };
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                componentBackUp.CreateBackUp(students, fbd.SelectedPath);
                MessageBox.Show("Бекап создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonComponentDiagram_Click(object sender, EventArgs e)
        {
            double[] values = { 8.02, 1.1, 5.45, 10 };
            string[] axis = { "первый", "второй", "третий", "четвертый" };
            componentDiagram.AxisSeriesX = axis;
            componentDiagram.AxisNameX = "Имя оси X";
            componentDiagram.AxisNameY = "Имя оси Y";
            using (SaveFileDialog fd = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (fd.ShowDialog() == DialogResult.OK)
                    componentDiagram.CreateDiagram(fd.FileName, values);
            }
        }

        private void buttonComponentReport_Click(object sender, EventArgs e)
        {
            new FormComponentReport().Show();
        }
    }
}
