using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Вспомогательная форма для работы с FormControlListGetting и FormControlSelected. Установка индекса
    /// </summary>
    public partial class FormSetIndex : Form
    {
        public int Id { get { return id; } }

        private int id;

        public FormSetIndex()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox.Text, out id))
            {
                MessageBox.Show("Число должно быть целым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}