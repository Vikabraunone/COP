using AbstractFactory;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClassLibraryControl.AbstractFactory
{
    public partial class GroupButtonControl : UserControl
    {
        /// <summary>
        /// Курс
        /// </summary>
        private ICourse _course;

        /// <summary>
        /// Форма обучения
        /// </summary>
        private IForm _form;

        /// <summary>
        /// Выбранный курс
        /// </summary>
        [Category("Спецификация"), Description("Выбранный курс")]
        public ICourse SelectedCourse
        {
            get
            {
                if (_course != null)
                    return _course;
                throw new Exception("Курс не инициализирован");
            }
        }

        /// <summary>
        /// Выбранная форма обучения
        /// </summary>
        [Category("Спецификация"), Description("Выбранная форма обучения")]
        public IForm SelectedForm
        {
            get
            {
                if (_form != null)
                    return _form;
                throw new Exception("Форма обучения не инициализирована");
            }
        }

        /// <summary>
        /// Образовательная программа
        /// </summary>
        [Category("Спецификация"), Description("Образовательная программа")]
        public IProgram Program
        {
            get
            {
                if (_form != null && _course != null)
                {
                    var typeForm = _form.GetType();
                    var typeCourse = _course.GetType();

                    if (typeCourse.Name == "PICourse")
                    {
                        if (typeForm.Name == "FullForm")
                            return new PIFullProgram();
                        else if (typeForm.Name == "FullAndPartForm")
                            return new PIFullAndPartProgram();
                        else if (typeForm.Name == "PartForm")
                            return new PIPartProgram();
                    }
                    else if (typeCourse.Name == "ISECourse")
                    {
                        if (typeForm.Name == "FullForm")
                            return new ISEFullProgram();
                        else if (typeForm.Name == "FullAndPartForm")
                            return new ISEFullAndPartProgram();
                        else if (typeForm.Name == "PartForm")
                            return new ISEPartProgram();
                    }
                }
                throw new Exception("Форма обучения или направление не инициализировано");
            }
        }

        public GroupButtonControl()
        {
            InitializeComponent();
            radioButtonISE.CheckedChanged += (sender, e) => CourseChanged(sender, e);
            radioButtonPI.CheckedChanged += (sender, e) => CourseChanged(sender, e);

            radioButtonFullForm.CheckedChanged += (sender, e) => FormChanged(sender, e);
            radioButtonPartForm.CheckedChanged += (sender, e) => FormChanged(sender, e);
            radioButtonFullAndPartForm.CheckedChanged += (sender, e) => FormChanged(sender, e);
        }

        private void CourseChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                if (radioButton.Name == "radioButtonPI")
                    _course = new PICourse();
                else if (radioButton.Name == "radioButtonISE")
                    _course = new ISECourse();
            }
        }

        private void FormChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                if (radioButton.Name == "radioButtonFullForm")
                    _form = new FullForm();
                else if (radioButton.Name == "radioButtonPartForm")
                    _form = new PartForm();
                else if (radioButton.Name == "radioButtonFullAndPartForm")
                    _form = new FullAndPartForm();
            }
        }
    }
}
