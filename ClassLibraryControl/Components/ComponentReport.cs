using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ClassLibraryControl.Components
{
    public partial class ComponentReport : Component
    {
        Worksheet _worksheet;

        Application _excel_report;

        string[] _letters = Enumerable.Range('A', 'Z' - 'A' + 1).Select(c => ((char)c).ToString()).ToArray();

        public ComponentReport()
        {
            InitializeComponent();
            InitializeExcelApp();
        }

        public ComponentReport(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitializeExcelApp();
        }

        private void InitializeExcelApp()
        {
            _excel_report = new Application { SheetsInNewWorkbook = 1 };
            // добавить книгу
            Workbook workBook = _excel_report.Workbooks.Add(Type.Missing);
            // получаем первый лист документа
            _worksheet = (Worksheet)_excel_report.Worksheets.get_Item(1);
        }

        /// <summary>
        /// Создание отчёта
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName">Имя файла</param>
        /// <param name="data">Данные</param>
        /// <param name="columnNames">Название колонок</param>
        public void CreateReport<T>(string fileName, List<T> data, List<string> columnNames)
        {
            var fields = typeof(T).GetFields();
            if (fields.Length != columnNames.Count)
                throw new Exception("Количество колонок и их наименований не совпадает");
            // вставка колонок
            int column = 1;
            int row = 1;
            foreach (var name in columnNames)
            {
                _worksheet.Cells[row, column] = name;
                column++;
            }
            row++;

            foreach (var obj in data)
            {
                column = 1;
                foreach (var field in fields)
                {
                    _worksheet.Cells[row, column] = field.GetValue(obj).ToString();
                    column++;
                }
                row++;
            }
            // авто ширина и высота, выравнивание
            var excel_cells_range = _worksheet.get_Range("A1", _letters[columnNames.Count - 1] + 1);
            excel_cells_range.EntireColumn.AutoFit();
            excel_cells_range.EntireRow.AutoFit();
            excel_cells_range.HorizontalAlignment = Constants.xlCenter;
            excel_cells_range.VerticalAlignment = Constants.xlCenter;
            _excel_report.Application.ActiveWorkbook.SaveAs(fileName, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        public void MergeColumn(int start, int end)
        {
            var excel_cells = _worksheet.get_Range(_letters[start - 1] + 1, _letters[end - 1] + 1);
            excel_cells.Merge(Type.Missing);
        }
    }
}