using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibraryControl
{
    public partial class ControlTextBoxEntered : UserControl
    {
        /// <summary>
        /// Введенная строка
        /// </summary>
        private string _currentText;

        /// <summary>
        /// Шаблон электронной почты
        /// </summary>
        private Regex PatternEmailText => new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        /// <summary>
        /// Событие изменения текста
        /// </summary>
        private event EventHandler _textBoxTextChange;

        /// <summary>
        /// Проверенная строка
        /// </summary>
        [Category("Спецификация"), Description("Проверенная строка")]
        public string CheckedText
        {
            get
            {
                if (!string.IsNullOrEmpty(_currentText))
                {
                    if (PatternEmailText.IsMatch(_currentText))
                        return _currentText;
                }
                throw new Exception("Email имеет неверный формат");
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (PatternEmailText.IsMatch(value))
                    {
                        _currentText = value;
                        textBox.BackColor = Color.White;
                    }
                    else
                    {
                        textBox.BackColor = Color.FromArgb(255, 50, 50);
                    }
                }
            }
        }

        /// <summary>
        /// Текущая строка
        /// </summary>
        [Category("Спецификация"), Description("Текущая строка")]
        public string CurrentText
        {
            get { return textBox.Text; }
        }

        /// <summary>
        /// Событие изменения текста
        /// </summary>
        [Category("Спецификация"), Description("Событие изменения текста")]
        public event EventHandler TextBoxTextChange
        {
            add { _textBoxTextChange += value; }
            remove { _textBoxTextChange -= value; }
        }

        public ControlTextBoxEntered()
        {
            InitializeComponent();
            textBox.TextChanged += (sender, e) => { _textBoxTextChange?.Invoke(sender, e); };
            textBox.MouseEnter += (sender, e) => { textBoxHelp.Visible = true; };
            textBox.MouseLeave += (sender, e) => { textBoxHelp.Visible = false; };
        }
    }
}
