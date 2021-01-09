using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Компонент выбора
    /// </summary>
    public partial class FormControlSelected : Form
    {
        public FormControlSelected()
        {
            InitializeComponent();
            var values = Enum.GetValues(typeof(TestEnum));
            foreach (var e in values)
                controlComboBoxSelected.LoadObject(e);
        }

        private void buttonShowIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Выбран индекс {controlComboBoxSelected.SelectedIndex}",
                    "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonChangeIndex_Click(object sender, EventArgs e)
        {
            var form = new FormSetIndex();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    controlComboBoxSelected.SelectedIndex = form.Id;
                    MessageBox.Show($"Выбран индекс {controlComboBoxSelected.SelectedIndex}",
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlComboBoxSelected.SelectedText);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            var form = new FormSetText();
            if (form.ShowDialog() == DialogResult.OK)
            {
                controlComboBoxSelected.SelectedText = form.TextValue;
                MessageBox.Show($"Изменился текст {controlComboBoxSelected.SelectedText}",
                    "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}