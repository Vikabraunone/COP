using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FormComponentReport : Form
    {
        private List<string> columnNames = new List<string>();

        public FormComponentReport()
        {
            InitializeComponent();
        }

        private void buttonMergeColumn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxColumnStart.Text, out int start) && int.TryParse(textBoxColumnEnd.Text, out int end))
                componentReport.MergeColumn(start, end);
            else
                MessageBox.Show("Введите числа в поля объединения колонок");
        }

        private void buttonSetPath_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fd = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (fd.ShowDialog() == DialogResult.OK)
                    textBoxPath.Text = fd.FileName;
            }
        }

        private void buttonAddColumnName_Click(object sender, EventArgs e)
        {
            listBoxColumnNames.Items.Add(textBoxColumnName.Text);
            columnNames.Add(textBoxColumnName.Text);
            textBoxColumnName.Clear();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            var data = new List<Student> {
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
            if (!string.IsNullOrEmpty(textBoxPath.Text))
                componentReport.CreateReport(textBoxPath.Text, data, columnNames);
        }
    }
}