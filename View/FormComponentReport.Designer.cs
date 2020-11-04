namespace View
{
    partial class FormComponentReport
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
            this.componentReport = new ClassLibraryControl.Components.ComponentReport(this.components);
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.groupBoxColumnNames = new System.Windows.Forms.GroupBox();
            this.labelColumnName = new System.Windows.Forms.Label();
            this.buttonAddColumnName = new System.Windows.Forms.Button();
            this.textBoxColumnName = new System.Windows.Forms.TextBox();
            this.listBoxColumnNames = new System.Windows.Forms.ListBox();
            this.groupBoxSetFilename = new System.Windows.Forms.GroupBox();
            this.buttonSetPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBoxMergeColumn = new System.Windows.Forms.GroupBox();
            this.buttonMergeColumn = new System.Windows.Forms.Button();
            this.textBoxColumnEnd = new System.Windows.Forms.TextBox();
            this.textBoxColumnStart = new System.Windows.Forms.TextBox();
            this.labelColumnEnd = new System.Windows.Forms.Label();
            this.labelColumnStart = new System.Windows.Forms.Label();
            this.groupBoxColumnNames.SuspendLayout();
            this.groupBoxSetFilename.SuspendLayout();
            this.groupBoxMergeColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(217, 307);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(113, 33);
            this.buttonCreateReport.TabIndex = 7;
            this.buttonCreateReport.Text = "Создать отчёт";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // groupBoxColumnNames
            // 
            this.groupBoxColumnNames.Controls.Add(this.labelColumnName);
            this.groupBoxColumnNames.Controls.Add(this.buttonAddColumnName);
            this.groupBoxColumnNames.Controls.Add(this.textBoxColumnName);
            this.groupBoxColumnNames.Controls.Add(this.listBoxColumnNames);
            this.groupBoxColumnNames.Location = new System.Drawing.Point(268, 17);
            this.groupBoxColumnNames.Name = "groupBoxColumnNames";
            this.groupBoxColumnNames.Size = new System.Drawing.Size(250, 284);
            this.groupBoxColumnNames.TabIndex = 6;
            this.groupBoxColumnNames.TabStop = false;
            this.groupBoxColumnNames.Text = "Название колонок";
            // 
            // labelColumnName
            // 
            this.labelColumnName.AutoSize = true;
            this.labelColumnName.Location = new System.Drawing.Point(13, 203);
            this.labelColumnName.Name = "labelColumnName";
            this.labelColumnName.Size = new System.Drawing.Size(60, 13);
            this.labelColumnName.TabIndex = 3;
            this.labelColumnName.Text = "Название:";
            // 
            // buttonAddColumnName
            // 
            this.buttonAddColumnName.Location = new System.Drawing.Point(16, 245);
            this.buttonAddColumnName.Name = "buttonAddColumnName";
            this.buttonAddColumnName.Size = new System.Drawing.Size(75, 23);
            this.buttonAddColumnName.TabIndex = 2;
            this.buttonAddColumnName.Text = "Добавить";
            this.buttonAddColumnName.UseVisualStyleBackColor = true;
            this.buttonAddColumnName.Click += new System.EventHandler(this.buttonAddColumnName_Click);
            // 
            // textBoxColumnName
            // 
            this.textBoxColumnName.Location = new System.Drawing.Point(16, 219);
            this.textBoxColumnName.Name = "textBoxColumnName";
            this.textBoxColumnName.Size = new System.Drawing.Size(215, 20);
            this.textBoxColumnName.TabIndex = 1;
            // 
            // listBoxColumnNames
            // 
            this.listBoxColumnNames.FormattingEnabled = true;
            this.listBoxColumnNames.Location = new System.Drawing.Point(16, 32);
            this.listBoxColumnNames.Name = "listBoxColumnNames";
            this.listBoxColumnNames.Size = new System.Drawing.Size(215, 134);
            this.listBoxColumnNames.TabIndex = 0;
            // 
            // groupBoxSetFilename
            // 
            this.groupBoxSetFilename.Controls.Add(this.buttonSetPath);
            this.groupBoxSetFilename.Controls.Add(this.textBoxPath);
            this.groupBoxSetFilename.Location = new System.Drawing.Point(12, 196);
            this.groupBoxSetFilename.Name = "groupBoxSetFilename";
            this.groupBoxSetFilename.Size = new System.Drawing.Size(250, 105);
            this.groupBoxSetFilename.TabIndex = 5;
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
            // groupBoxMergeColumn
            // 
            this.groupBoxMergeColumn.Controls.Add(this.buttonMergeColumn);
            this.groupBoxMergeColumn.Controls.Add(this.textBoxColumnEnd);
            this.groupBoxMergeColumn.Controls.Add(this.textBoxColumnStart);
            this.groupBoxMergeColumn.Controls.Add(this.labelColumnEnd);
            this.groupBoxMergeColumn.Controls.Add(this.labelColumnStart);
            this.groupBoxMergeColumn.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMergeColumn.Name = "groupBoxMergeColumn";
            this.groupBoxMergeColumn.Size = new System.Drawing.Size(250, 178);
            this.groupBoxMergeColumn.TabIndex = 4;
            this.groupBoxMergeColumn.TabStop = false;
            this.groupBoxMergeColumn.Text = "Объединить колонки";
            // 
            // buttonMergeColumn
            // 
            this.buttonMergeColumn.Location = new System.Drawing.Point(18, 134);
            this.buttonMergeColumn.Name = "buttonMergeColumn";
            this.buttonMergeColumn.Size = new System.Drawing.Size(130, 24);
            this.buttonMergeColumn.TabIndex = 4;
            this.buttonMergeColumn.Text = "Объединить колонки";
            this.buttonMergeColumn.UseVisualStyleBackColor = true;
            this.buttonMergeColumn.Click += new System.EventHandler(this.buttonMergeColumn_Click);
            // 
            // textBoxColumnEnd
            // 
            this.textBoxColumnEnd.Location = new System.Drawing.Point(131, 89);
            this.textBoxColumnEnd.Name = "textBoxColumnEnd";
            this.textBoxColumnEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumnEnd.TabIndex = 3;
            // 
            // textBoxColumnStart
            // 
            this.textBoxColumnStart.Location = new System.Drawing.Point(131, 37);
            this.textBoxColumnStart.Name = "textBoxColumnStart";
            this.textBoxColumnStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumnStart.TabIndex = 2;
            // 
            // labelColumnEnd
            // 
            this.labelColumnEnd.AutoSize = true;
            this.labelColumnEnd.Location = new System.Drawing.Point(15, 92);
            this.labelColumnEnd.Name = "labelColumnEnd";
            this.labelColumnEnd.Size = new System.Drawing.Size(103, 13);
            this.labelColumnEnd.TabIndex = 1;
            this.labelColumnEnd.Text = "Конечная колонка:";
            // 
            // labelColumnStart
            // 
            this.labelColumnStart.AutoSize = true;
            this.labelColumnStart.Location = new System.Drawing.Point(15, 40);
            this.labelColumnStart.Name = "labelColumnStart";
            this.labelColumnStart.Size = new System.Drawing.Size(110, 13);
            this.labelColumnStart.TabIndex = 0;
            this.labelColumnStart.Text = "Начальная колонка:";
            // 
            // FormComponentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.groupBoxColumnNames);
            this.Controls.Add(this.groupBoxSetFilename);
            this.Controls.Add(this.groupBoxMergeColumn);
            this.Name = "FormComponentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компонент создания отчёта";
            this.groupBoxColumnNames.ResumeLayout(false);
            this.groupBoxColumnNames.PerformLayout();
            this.groupBoxSetFilename.ResumeLayout(false);
            this.groupBoxSetFilename.PerformLayout();
            this.groupBoxMergeColumn.ResumeLayout(false);
            this.groupBoxMergeColumn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibraryControl.Components.ComponentReport componentReport;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.GroupBox groupBoxColumnNames;
        private System.Windows.Forms.Label labelColumnName;
        private System.Windows.Forms.Button buttonAddColumnName;
        private System.Windows.Forms.TextBox textBoxColumnName;
        private System.Windows.Forms.ListBox listBoxColumnNames;
        private System.Windows.Forms.GroupBox groupBoxSetFilename;
        private System.Windows.Forms.Button buttonSetPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBoxMergeColumn;
        private System.Windows.Forms.Button buttonMergeColumn;
        private System.Windows.Forms.TextBox textBoxColumnEnd;
        private System.Windows.Forms.TextBox textBoxColumnStart;
        private System.Windows.Forms.Label labelColumnEnd;
        private System.Windows.Forms.Label labelColumnStart;
    }
}