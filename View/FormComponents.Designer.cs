namespace View
{
    partial class FormComponents
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
            this.buttonControlListGetting = new System.Windows.Forms.Button();
            this.buttonControlEntered = new System.Windows.Forms.Button();
            this.buttonControlSelected = new System.Windows.Forms.Button();
            this.buttonComponentBackUp = new System.Windows.Forms.Button();
            this.buttonComponentReport = new System.Windows.Forms.Button();
            this.buttonComponentDiagram = new System.Windows.Forms.Button();
            this.componentBackUp = new ClassLibraryControl.Components.ComponentBackUp(this.components);
            this.SuspendLayout();
            // 
            // buttonControlListGetting
            // 
            this.buttonControlListGetting.Location = new System.Drawing.Point(12, 161);
            this.buttonControlListGetting.Name = "buttonControlListGetting";
            this.buttonControlListGetting.Size = new System.Drawing.Size(190, 40);
            this.buttonControlListGetting.TabIndex = 5;
            this.buttonControlListGetting.Text = "Компонент вывода списка";
            this.buttonControlListGetting.UseVisualStyleBackColor = true;
            this.buttonControlListGetting.Click += new System.EventHandler(this.buttonControlListGetting_Click);
            // 
            // buttonControlEntered
            // 
            this.buttonControlEntered.Location = new System.Drawing.Point(12, 91);
            this.buttonControlEntered.Name = "buttonControlEntered";
            this.buttonControlEntered.Size = new System.Drawing.Size(190, 40);
            this.buttonControlEntered.TabIndex = 4;
            this.buttonControlEntered.Text = "Компонент ввода";
            this.buttonControlEntered.UseVisualStyleBackColor = true;
            this.buttonControlEntered.Click += new System.EventHandler(this.buttonControlEntered_Click);
            // 
            // buttonControlSelected
            // 
            this.buttonControlSelected.Location = new System.Drawing.Point(12, 21);
            this.buttonControlSelected.Name = "buttonControlSelected";
            this.buttonControlSelected.Size = new System.Drawing.Size(190, 40);
            this.buttonControlSelected.TabIndex = 3;
            this.buttonControlSelected.Text = "Компонент выбора";
            this.buttonControlSelected.UseVisualStyleBackColor = true;
            this.buttonControlSelected.Click += new System.EventHandler(this.buttonControlSelected_Click);
            // 
            // buttonComponentBackUp
            // 
            this.buttonComponentBackUp.Location = new System.Drawing.Point(228, 21);
            this.buttonComponentBackUp.Name = "buttonComponentBackUp";
            this.buttonComponentBackUp.Size = new System.Drawing.Size(190, 40);
            this.buttonComponentBackUp.TabIndex = 6;
            this.buttonComponentBackUp.Text = "Компонент работы с данными";
            this.buttonComponentBackUp.UseVisualStyleBackColor = true;
            this.buttonComponentBackUp.Click += new System.EventHandler(this.buttonComponentBackUp_Click);
            // 
            // buttonComponentReport
            // 
            this.buttonComponentReport.Location = new System.Drawing.Point(228, 91);
            this.buttonComponentReport.Name = "buttonComponentReport";
            this.buttonComponentReport.Size = new System.Drawing.Size(190, 40);
            this.buttonComponentReport.TabIndex = 7;
            this.buttonComponentReport.Text = "Компонент создания отчёта";
            this.buttonComponentReport.UseVisualStyleBackColor = true;
            this.buttonComponentReport.Click += new System.EventHandler(this.buttonComponentReport_Click);
            // 
            // buttonComponentDiagram
            // 
            this.buttonComponentDiagram.Location = new System.Drawing.Point(228, 161);
            this.buttonComponentDiagram.Name = "buttonComponentDiagram";
            this.buttonComponentDiagram.Size = new System.Drawing.Size(190, 40);
            this.buttonComponentDiagram.TabIndex = 8;
            this.buttonComponentDiagram.Text = "Компонент создания диаграм";
            this.buttonComponentDiagram.UseVisualStyleBackColor = true;
            this.buttonComponentDiagram.Click += new System.EventHandler(this.buttonComponentDiagram_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 223);
            this.Controls.Add(this.buttonComponentDiagram);
            this.Controls.Add(this.buttonComponentReport);
            this.Controls.Add(this.buttonComponentBackUp);
            this.Controls.Add(this.buttonControlListGetting);
            this.Controls.Add(this.buttonControlEntered);
            this.Controls.Add(this.buttonControlSelected);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonControlListGetting;
        private System.Windows.Forms.Button buttonControlEntered;
        private System.Windows.Forms.Button buttonControlSelected;
        private System.Windows.Forms.Button buttonComponentBackUp;
        private System.Windows.Forms.Button buttonComponentReport;
        private System.Windows.Forms.Button buttonComponentDiagram;
        private ClassLibraryControl.Components.ComponentBackUp componentBackUp;
    }
}