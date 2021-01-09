using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Отчет Excel
    /// </summary>
    public partial class FormComponentReport : Form
    {
        private List<string> columnNames = new List<string>();

        private List<Student> students;

        public FormComponentReport(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
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
            if (!string.IsNullOrEmpty(textBoxPath.Text))
            {
                componentReport.CreateReport(textBoxPath.Text, students, columnNames);
                MessageBox.Show("Отчёт создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}