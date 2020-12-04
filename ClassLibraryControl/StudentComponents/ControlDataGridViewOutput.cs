using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ClassLibraryControl.ThreeLab
{
    public partial class ControlDataGridViewOutput : UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndex;
        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _dataGridOutputElementSelected;

        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
            }
        }

        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return dataGridView.CurrentRow.Cells[0].Value.ToString(); }
        }

        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler DataGridViewSelectionChanged
        {
            add { _dataGridOutputElementSelected += value; }
            remove
            {
                _dataGridOutputElementSelected -= value;
            }
        }

        public ControlDataGridViewOutput()
        {
            InitializeComponent();
            dataGridView.SelectionChanged += (sender, e) =>
            {
                dataGridView_SelectedIndexChanged(sender, e);
                _dataGridOutputElementSelected?.Invoke(sender, e);
            };
        }

        public void SelectedLinkDataGridView(int number)
        {
            try
            {
                ReloadTable();
                dataGridView.Rows[number].Selected = true;
                _selectedIndex = number;
            }
            catch { }

        }
        public void ReloadTable()
        {
            for (int i = 0; i <= dataGridView.SelectedRows.Count; i++)
            {
                dataGridView.Rows[i].Selected = false;
            }
        }

        public void SetHeaders(List<Column> columns)
        {
            foreach (var i in columns)
            {
                var column = new DataGridViewColumn();
                column.Name = i.Name;
                column.HeaderText = i.Name;
                column.CellTemplate = new DataGridViewTextBoxCell();
                column.Width = i.Width;
                column.Visible = i.Visibility;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.Columns.Add(column);
            }
        }

        public void FillDataGrid<T>(List<T> data)
        {
            Clear();
            var reflectionData = new List<Column>();
            foreach (var prop in typeof(T).GetProperties())
            {
                if (reflectionData.OfType<Column>().FirstOrDefault(x => x.Name.Equals(prop.Name)) == null)
                    reflectionData.Add(new Column(prop.Name));
            }
            SetHeaders(reflectionData);
            foreach (var obj in data)
            {
                AddRow<T>(obj);
            }
        }

        public void AddRow<T>(T el)
        {
            var fields = el.GetType().GetProperties();

            string row = "";
            foreach (var field in fields)
            {

                row += el.GetType().GetProperty(field.Name).GetValue(el).ToString() + ",";
            }
            string[] l = row.Split(',');
            dataGridView.Rows.Add(l);

        }

        private void dataGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value != null)
                {
                    if (dataGridView.Rows[i].Cells[0].Value.ToString() == SelectedText)
                        SelectedIndex = i;
                }
            }
        }

        public int getId()
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            return id;
        }

        public int CountSelectedRows()
        {
            int count = Convert.ToInt32(dataGridView.SelectedRows.Count);
            return count;
        }

        override public void Refresh()
        {
            dataGridView.Refresh();
            ReloadTable();
        }

        public void Clear()
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }
    }
}