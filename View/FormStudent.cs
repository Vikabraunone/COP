using BusinessLogic.BindingModels;
using BusinessLogic.Enums;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormStudent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IStudentLogic studentLogic;

        private int? id;

        public FormStudent(IStudentLogic studentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
            comboBoxFormEducation.DataSource = Enum.GetValues(typeof(FormEducation))
                            .Cast<FormEducation>()
                            .Select(x => x.ToString())
                            .ToList();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    StudentViewModel view = studentLogic.Read(new StudentBindingModel { Id = id.Value })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                        textBoxEmail.Text = view.Email;
                        comboBoxFormEducation.SelectedIndex = (int)view.FormEducation;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboBoxFormEducation.SelectedItem = null;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Заполните электронную почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxFormEducation.SelectedValue == null)
            {
                MessageBox.Show("Укажите форму обучения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                studentLogic.CreateOrUpdate(new StudentBindingModel
                {
                    Id = id,
                    FIO = textBoxFIO.Text,
                    FormEducation = (FormEducation)Enum.Parse(typeof(FormEducation), comboBoxFormEducation.SelectedItem.ToString()),
                    Email = textBoxEmail.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
