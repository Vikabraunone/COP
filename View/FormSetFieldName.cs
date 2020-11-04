using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class FormSetFieldName : Form
    {
        public string TextField
        {
            get { return textBox.Text; }
        }

        public string Field
        {
            get { return comboBox.SelectedItem.ToString(); }
        }

        public FormSetFieldName(Type type)
        {
            InitializeComponent();
            comboBox.Items.AddRange(type.GetFields().Select(x => x.Name).ToArray());
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите значение");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
