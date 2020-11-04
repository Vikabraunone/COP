using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.Rendering;
using System;
using System.ComponentModel;

namespace ClassLibraryControl.Components
{
    public partial class ComponentDiagram : Component
    {
        public ComponentDiagram()
        {
            InitializeComponent();
        }

        public ComponentDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// Подпись данных
        /// </summary>
        public string[] AxisSeriesX { set; get; }


        /// <summary>
        /// Подпись оси X
        /// </summary>
        public string AxisNameX { set; get; }

        /// <summary>
        /// Подпись оси X
        /// </summary>
        public string AxisNameY { set; get; }

        /// <summary>
        /// Создание диаграммы
        /// </summary>
        /// <param name="fileName">Путь до файла</param>
        /// <param name="data">Данные</param>
        public void CreateDiagram(string fileName, double[] data)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException("Имя файла неверное");
            Document document = new Document();
            DefineStyles(document);
            document.AddSection();

            Chart chart = new Chart();
            chart.Left = 0;

            chart.Width = Unit.FromCentimeter(16);
            chart.Height = Unit.FromCentimeter(12);

            Series series = chart.SeriesCollection.AddSeries();
            series.ChartType = ChartType.Line;
            series.Add(data);
            series.HasDataLabel = true;

            if (AxisSeriesX != null)
            {
                XSeries xseries = chart.XValues.AddXSeries();
                xseries.Add(AxisSeriesX);
            }

            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.XAxis.Title.Caption = AxisNameX;

            chart.YAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.HasMajorGridlines = true;
            chart.YAxis.Title.Caption = AxisNameY;

            document.LastSection.Add(chart);

            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always)
            {
                Document = document
            };
            renderer.RenderDocument();
            renderer.PdfDocument.Save(fileName);
        }

        /// <summary>
        /// Создание стилей для документа
        /// </summary>
        /// <param name="document"></param>
        private static void DefineStyles(Document document)
        {
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 14;
            style = document.Styles.AddStyle("NormalTitle", "Normal");
            style.Font.Bold = true;
        }
    }
}