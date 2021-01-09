namespace View
{
    partial class FormPdf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.groupBoxSetFilename = new System.Windows.Forms.GroupBox();
            this.buttonSetPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBoxNamesXY = new System.Windows.Forms.GroupBox();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.componentDiagram = new ClassLibraryControl.Components.ComponentDiagram(this.components);
            this.groupBoxSetFilename.SuspendLayout();
            this.groupBoxNamesXY.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(16, 30);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(85, 13);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Подпись оси X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(16, 68);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(85, 13);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Подпись оси Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(107, 27);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(123, 20);
            this.textBoxX.TabIndex = 4;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(107, 65);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(123, 20);
            this.textBoxY.TabIndex = 5;
            // 
            // groupBoxSetFilename
            // 
            this.groupBoxSetFilename.Controls.Add(this.buttonSetPath);
            this.groupBoxSetFilename.Controls.Add(this.textBoxPath);
            this.groupBoxSetFilename.Location = new System.Drawing.Point(23, 12);
            this.groupBoxSetFilename.Name = "groupBoxSetFilename";
            this.groupBoxSetFilename.Size = new System.Drawing.Size(250, 105);
            this.groupBoxSetFilename.TabIndex = 6;
            this.groupBoxSetFilename.TabStop = false;
            this.groupBoxSetFilename.Text = "Указать имя файла";
            // 
            // buttonSetPath
            // 
            this.buttonSetPath.Location = new System.Drawing.Point(15, 66);
            this.buttonSetPath.Name = "buttonSetPath";
            this.buttonSetPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPath.TabIndex = 1;
            this.buttonSetPath.Text = "Выбрать";
            this.buttonSetPath.UseVisualStyleBackColor = true;
            this.buttonSetPath.Click += new System.EventHandler(this.buttonSetPath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(15, 40);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(215, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // groupBoxNamesXY
            // 
            this.groupBoxNamesXY.Controls.Add(this.textBoxY);
            this.groupBoxNamesXY.Controls.Add(this.labelX);
            this.groupBoxNamesXY.Controls.Add(this.labelY);
            this.groupBoxNamesXY.Controls.Add(this.textBoxX);
            this.groupBoxNamesXY.Location = new System.Drawing.Point(291, 17);
            this.groupBoxNamesXY.Name = "groupBoxNamesXY";
            this.groupBoxNamesXY.Size = new System.Drawing.Size(260, 100);
            this.groupBoxNamesXY.TabIndex = 7;
            this.groupBoxNamesXY.TabStop = false;
            this.groupBoxNamesXY.Text = "Подпись осей";
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(201, 137);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(159, 40);
            this.buttonCreateReport.TabIndex = 8;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // componentDiagram
            // 
            this.componentDiagram.AxisNameX = null;
            this.componentDiagram.AxisNameY = null;
            this.componentDiagram.AxisSeriesX = null;
            // 
            // FormPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 192);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.groupBoxNamesXY);
            this.Controls.Add(this.groupBoxSetFilename);
            this.Name = "FormPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диаграмма PDF";
            this.groupBoxSetFilename.ResumeLayout(false);
            this.groupBoxSetFilename.PerformLayout();
            this.groupBoxNamesXY.ResumeLayout(false);
            this.groupBoxNamesXY.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.GroupBox groupBoxSetFilename;
        private System.Windows.Forms.Button buttonSetPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBoxNamesXY;
        private System.Windows.Forms.Button buttonCreateReport;
        private ClassLibraryControl.Components.ComponentDiagram componentDiagram;
    }
}