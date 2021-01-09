using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClassLibraryControl
{
    public partial class ControlListBoxGetting : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Шаблонная строка
        /// </summary>
        private string _patternStr;

        /// <summary>
        /// Регулярное выражение для проверки входящей шаблонной строки
        /// </summary>
        private Regex TruePattern => new Regex(@"^([А-Яа-яA-Za-z\w\s.,\-+]*:{[A-Za-z]+[\w]};)+$");

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _listBoxSelectedElementChange;

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                try
                {
                    if (value >= 0 && value < listBox.Items.Count)
                    {
                        _selectedIndex = value;
                        listBox.SelectedIndex = _selectedIndex;
                    }
                    else if (value != 0)
                        throw new Exception("Выход за пределы массива значений");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Текст выбранного значения
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранного значения")]
        public string SelectedText
        {
            get { return listBox.Text; }
        }

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ListBoxSelectedElementChange
        {
            add { _listBoxSelectedElementChange += value; }
            remove { _listBoxSelectedElementChange -= value; }
        }

        public ControlListBoxGetting()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) => { _listBoxSelectedElementChange?.Invoke(sender, e); };
        }

        /// <summary>
        /// Метод для ввода шаблонной строки вывода
        /// </summary>
        /// <param name="pattern">Шаблон-строка</param>
        public void SetPattern(string pattern)
        {
            if (!TruePattern.IsMatch(pattern))
                throw new Exception("Шаблонная строка имеет неверный формат");
            listBox.Items.Clear();
            _patternStr = pattern;
        }

        /// <summary>
        /// Метод добавления объекта класса в список (добавление строки с данными из полей объекта)
        /// </summary>
        /// <param name="strObject">Строка с данными из полей объекта</param>
        public void AddObject(string fields)
        {
            if (string.IsNullOrEmpty(_patternStr))
                throw new Exception("Шаблонная строка является пустой. Невозможно отобразить объект");
            var strPattern = string.Copy(_patternStr);
            var array = fields.Split(';');
            foreach (var e in array)
            {
                var field = e.Split(':');
                if (strPattern.Contains($"{{{field[0]}}}"))
                    strPattern = strPattern.Replace($"{{{field[0]}}}", field[1]);
            }
            if (strPattern.Contains("{}"))
                throw new Exception("Шаблонная строка или строка с данными из полей объекта имеет неверный формат");
            listBox.Items.Add(strPattern);
        }
    }
}
