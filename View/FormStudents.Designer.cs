namespace View
{
    partial class FormStudents
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Ref = new System.Windows.Forms.Button();
            this.textBoxSetId = new System.Windows.Forms.TextBox();
            this.buttonSetId = new System.Windows.Forms.Button();
            this.textBoxCurrentId = new System.Windows.Forms.TextBox();
            this.labelCurrentId = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.бекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоСтудентамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаПоФормамОбученияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDataGridViewOutput = new ClassLibraryControl.ThreeLab.ControlDataGridViewOutput();
            this.componentRestore = new ClassLibraryControl.Components.ComponentRestore(this.components);
            this.componentBackUp = new ClassLibraryControl.Components.ComponentBackUp(this.components);
            this.componentDiagramExcel = new ClassLibraryControl.Components.ComponentDiagramExcel(this.components);
            this.componentExcelReport = new ClassLibraryExcelReport.ExcelComponent();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(529, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 32);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Ref
            // 
            this.Ref.Location = new System.Drawing.Point(529, 142);
            this.Ref.Name = "Ref";
            this.Ref.Size = new System.Drawing.Size(83, 32);
            this.Ref.TabIndex = 4;
            this.Ref.Text = "Обновить";
            this.Ref.UseVisualStyleBackColor = true;
            this.Ref.Click += new System.EventHandler(this.Ref_Click);
            // 
            // textBoxSetId
            // 
            this.textBoxSetId.Location = new System.Drawing.Point(641, 33);
            this.textBoxSetId.Name = "textBoxSetId";
            this.textBoxSetId.Size = new System.Drawing.Size(115, 20);
            this.textBoxSetId.TabIndex = 5;
            // 
            // buttonSetId
            // 
            this.buttonSetId.Location = new System.Drawing.Point(641, 59);
            this.buttonSetId.Name = "buttonSetId";
            this.buttonSetId.Size = new System.Drawing.Size(115, 41);
            this.buttonSetId.TabIndex = 6;
            this.buttonSetId.Text = "Выбрать номер строки";
            this.buttonSetId.UseVisualStyleBackColor = true;
            this.buttonSetId.Click += new System.EventHandler(this.buttonSetId_Click);
            // 
            // textBoxCurrentId
            // 
            this.textBoxCurrentId.Location = new System.Drawing.Point(641, 149);
            this.textBoxCurrentId.Name = "textBoxCurrentId";
            this.textBoxCurrentId.Size = new System.Drawing.Size(115, 20);
            this.textBoxCurrentId.TabIndex = 7;
            // 
            // labelCurrentId
            // 
            this.labelCurrentId.AutoSize = true;
            this.labelCurrentId.Location = new System.Drawing.Point(638, 133);
            this.labelCurrentId.Name = "labelCurrentId";
            this.labelCurrentId.Size = new System.Drawing.Size(64, 13);
            this.labelCurrentId.TabIndex = 8;
            this.labelCurrentId.Text = "Текущий Id";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(529, 68);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 32);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(529, 106);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 32);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бекапToolStripMenuItem,
            this.отчетПоСтудентамToolStripMenuItem,
            this.диаграммаПоФормамОбученияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(772, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip";
            // 
            // бекапToolStripMenuItem
            // 
            this.бекапToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.сохранитьДанныеToolStripMenuItem});
            this.бекапToolStripMenuItem.Name = "бекапToolStripMenuItem";
            this.бекапToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.бекапToolStripMenuItem.Text = "Бекап";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            this.загрузитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеToolStripMenuItem_Click);
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            this.сохранитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеToolStripMenuItem_Click);
            // 
            // отчетПоСтудентамToolStripMenuItem
            // 
            this.отчетПоСтудентамToolStripMenuItem.Name = "отчетПоСтудентамToolStripMenuItem";
            this.отчетПоСтудентамToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.отчетПоСтудентамToolStripMenuItem.Text = "Отчет по студентам";
            this.отчетПоСтудентамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоСтудентамToolStripMenuItem_Click);
            // 
            // диаграммаПоФормамОбученияToolStripMenuItem
            // 
            this.диаграммаПоФормамОбученияToolStripMenuItem.Name = "диаграммаПоФормамОбученияToolStripMenuItem";
            this.диаграммаПоФормамОбученияToolStripMenuItem.Size = new System.Drawing.Size(205, 20);
            this.диаграммаПоФормамОбученияToolStripMenuItem.Text = "Диаграмма по формам обучения";
            this.диаграммаПоФормамОбученияToolStripMenuItem.Click += new System.EventHandler(this.диаграммаПоФормамОбученияToolStripMenuItem_Click);
            // 
            // controlDataGridViewOutput
            // 
            this.controlDataGridViewOutput.Location = new System.Drawing.Point(12, 30);
            this.controlDataGridViewOutput.Name = "controlDataGridViewOutput";
            this.controlDataGridViewOutput.SelectedIndex = 0;
            this.controlDataGridViewOutput.Size = new System.Drawing.Size(511, 256);
            this.controlDataGridViewOutput.TabIndex = 13;
            this.controlDataGridViewOutput.DataGridViewSelectionChanged += new System.EventHandler(this.controlDataGridViewOutput_DataGridViewSelectionChanged);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 347);
            this.Controls.Add(this.controlDataGridViewOutput);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelCurrentId);
            this.Controls.Add(this.textBoxCurrentId);
            this.Controls.Add(this.buttonSetId);
            this.Controls.Add(this.textBoxSetId);
            this.Controls.Add(this.Ref);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button Ref;
		private System.Windows.Forms.TextBox textBoxSetId;
		private System.Windows.Forms.Button buttonSetId;
		private System.Windows.Forms.TextBox textBoxCurrentId;
		private System.Windows.Forms.Label labelCurrentId;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem бекапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоСтудентамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммаПоФормамОбученияToolStripMenuItem;
        private ClassLibraryControl.ThreeLab.ControlDataGridViewOutput controlDataGridViewOutput;
        private ClassLibraryControl.Components.ComponentRestore componentRestore;
        private ClassLibraryControl.Components.ComponentBackUp componentBackUp;
        private ClassLibraryControl.Components.ComponentDiagramExcel componentDiagramExcel;
        private ClassLibraryExcelReport.ExcelComponent componentExcelReport;
    }
}