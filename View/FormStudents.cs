using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormStudents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IStudentLogic studentLogic;

        public FormStudents(IStudentLogic studentLogic)
        {
            InitializeComponent();
            this.studentLogic = studentLogic;
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                controlDataGridViewOutput.Clear();
                var list = studentLogic.Read(null);
                if (list != null)
                    controlDataGridViewOutput.FillDataGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStudent>();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormStudent>();
            form.Id = Convert.ToInt32(controlDataGridViewOutput.SelectedText);
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    studentLogic.Delete(new StudentBindingModel { Id = int.Parse(controlDataGridViewOutput.SelectedText) });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
        }

        private void Ref_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSetId_Click(object sender, EventArgs e)
        {
            try
            {
                controlDataGridViewOutput.SelectedLinkDataGridView(int.Parse(textBoxSetId.Text));
                textBoxCurrentId.Text = controlDataGridViewOutput.SelectedIndex.ToString();
            }
            catch { }
        }

        private void controlDataGridViewOutput_DataGridViewSelectionChanged(object sender, EventArgs e)
        {
            textBoxCurrentId.Text = controlDataGridViewOutput.SelectedIndex.ToString();
        }

        private void загрузитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog od = new OpenFileDialog { Filter = "all|*.*" })
                {
                    if (od.ShowDialog() == DialogResult.OK)
                    {
                        var list = componentRestore.DownloadBackUp<StudentViewModel>(od.FileName);
                        foreach (var item in list)
                            studentLogic.CreateOrUpdate(new StudentBindingModel
                            {
                                Id = item.Id,
                                Email = item.Email,
                                FIO = item.FIO,
                                FormEducation = item.FormEducation
                            });
                        LoadData();
                        MessageBox.Show("Данные успешно загружены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog fd = new SaveFileDialog { Filter = "all|*.json" })
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        componentBackUp.CreateBackUp(studentLogic.Read(null), fd.FileName);
                        MessageBox.Show("Данные успешно сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void диаграммаПоФормамОбученияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog fd = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        componentDiagramExcel.CreateDiagram(fd.FileName, studentLogic.Read(null));
                        MessageBox.Show("Диаграмма создана", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void отчетПоСтудентамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                componentExcelReport = new ClassLibraryExcelReport.ExcelComponent();
                using (SaveFileDialog fd = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
                {
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        var students = studentLogic.Read(null);
                        var report = students.Select(x => new { x.FIO, x.Email }).ToArray(); ;
                        componentExcelReport.CreateExcelReport(fd.FileName, true, report, new int[] { 1, 3 }, new string[] { "ФИО", "Email" });
                        MessageBox.Show("Отчет сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
