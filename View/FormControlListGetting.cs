using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Компонент вывода списка
    /// </summary>
    public partial class FormControlListGetting : Form
    {
        private Type typeObject = typeof(Student);

        private List<Student> students;

        public FormControlListGetting(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void buttonSetPattern_Click(object sender, EventArgs e)
        {
            var form = new FormPattern(typeObject);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var dictionary = form.PatternDictionary;
                var pattern = string.Join(string.Empty, dictionary.Select(x => x.Key + ":{" + x.Value + "};"));
                controlListBoxGetting.SetPattern(pattern);
                MessageBox.Show("Шаблон задан");
                LoadListBox();
            }
        }

        private void LoadListBox()
        {
            foreach (var student in students)
                controlListBoxGetting.AddObject(CreateObjectString(typeObject.GetFields(), student));
        }

        private string CreateObjectString(FieldInfo[] fields, object obj)
        {
            var objString = "";
            foreach (var field in fields)
                objString += field.Name + ":" + field.GetValue(obj) + ";";
            return objString;
        }

        private void buttonGetIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Индекс: {controlListBoxGetting.SelectedIndex}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSetIndex_Click(object sender, EventArgs e)
        {
            var form = new FormSetIndex();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    controlListBoxGetting.SelectedIndex = form.Id;
                    MessageBox.Show($"Выбран индекс {controlListBoxGetting.SelectedIndex}",
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void controlListBoxGetting_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlListBoxGetting.SelectedText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlListBoxGetting.SelectedText, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}