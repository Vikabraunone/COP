using System;
using System.Windows.Forms;

namespace View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCourse_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = groupButtonControl.SelectedCourse.Name + ", " + groupButtonControl.SelectedCourse.Code;
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void buttonForm_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = groupButtonControl.SelectedForm.Name;
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }

        private void buttonShowProgram_Click(object sender, EventArgs e)
        {
            try
            {
                var nameCreator = groupButtonControl.Program.GetType().Name;
                if (nameCreator == "PIFullProgram")
                    textBox.Text = "Программная инженерия; очная форма обучения";
                else if (nameCreator == "PIFullAndPartProgram")
                    textBox.Text = "Программная инженерия; очно-заочная форма обучения";
                else if (nameCreator == "PIPartProgram")
                    textBox.Text = "Программная инженерия; заочная форма обучения";
                else if (nameCreator == "ISEFullProgram")
                    textBox.Text = "Информационные системы в экономике; очная форма обучения";
                else if (nameCreator == "ISEFullAndPartProgram")
                    textBox.Text = "Информационные системы в экономике; очно-заочная форма обучения";
                else if (nameCreator == "ISEPartProgram")
                    textBox.Text = "Информационные системы в экономике; заочная форма обучения";
            }
            catch (Exception ex)
            {
                textBox.Text = ex.Message;
            }
        }
    }
}
