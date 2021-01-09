using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormAddStudent : Form
    {
        public Student Student { get; private set; }

        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Student = new Student();
                Student.FIO = textBoxFIO.Text;
                Student.Age = Convert.ToInt32(textBoxAge.Text);
                Student.Course = Convert.ToInt32(textBoxCourse.Text);
                Student.DateBirth = dateTimePickerDateBirth.Value;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}