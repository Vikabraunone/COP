namespace View
{
    partial class FormControlListGetting
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
            this.controlListBoxGetting = new ClassLibraryControl.ControlListBoxGetting();
            this.buttonSetIndex = new System.Windows.Forms.Button();
            this.buttonGetIndex = new System.Windows.Forms.Button();
            this.buttonSetPattern = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlListBoxGetting
            // 
            this.controlListBoxGetting.Location = new System.Drawing.Point(25, 12);
            this.controlListBoxGetting.Name = "controlListBoxGetting";
            this.controlListBoxGetting.SelectedIndex = 0;
            this.controlListBoxGetting.Size = new System.Drawing.Size(400, 282);
            this.controlListBoxGetting.TabIndex = 0;
            this.controlListBoxGetting.ListBoxSelectedElementChange += new System.EventHandler(this.controlListBoxGetting_ListBoxSelectedElementChange);
            // 
            // buttonSetIndex
            // 
            this.buttonSetIndex.Location = new System.Drawing.Point(345, 300);
            this.buttonSetIndex.Name = "buttonSetIndex";
            this.buttonSetIndex.Size = new System.Drawing.Size(96, 36);
            this.buttonSetIndex.TabIndex = 8;
            this.buttonSetIndex.Text = "Установить индекс";
            this.buttonSetIndex.UseVisualStyleBackColor = true;
            this.buttonSetIndex.Click += new System.EventHandler(this.buttonSetIndex_Click);
            // 
            // buttonGetIndex
            // 
            this.buttonGetIndex.Location = new System.Drawing.Point(243, 300);
            this.buttonGetIndex.Name = "buttonGetIndex";
            this.buttonGetIndex.Size = new System.Drawing.Size(96, 36);
            this.buttonGetIndex.TabIndex = 7;
            this.buttonGetIndex.Text = "Получить индекс";
            this.buttonGetIndex.UseVisualStyleBackColor = true;
            this.buttonGetIndex.Click += new System.EventHandler(this.buttonGetIndex_Click);
            // 
            // buttonSetPattern
            // 
            this.buttonSetPattern.Location = new System.Drawing.Point(12, 300);
            this.buttonSetPattern.Name = "buttonSetPattern";
            this.buttonSetPattern.Size = new System.Drawing.Size(142, 36);
            this.buttonSetPattern.TabIndex = 6;
            this.buttonSetPattern.Text = "Задать шаблон вывода";
            this.buttonSetPattern.UseVisualStyleBackColor = true;
            this.buttonSetPattern.Click += new System.EventHandler(this.buttonSetPattern_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(160, 300);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 36);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormControlListGetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 354);
            this.Controls.Add(this.buttonSetIndex);
            this.Controls.Add(this.buttonGetIndex);
            this.Controls.Add(this.buttonSetPattern);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.controlListBoxGetting);
            this.Name = "FormControlListGetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компонент вывода списка";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibraryControl.ControlListBoxGetting controlListBoxGetting;
        private System.Windows.Forms.Button buttonSetIndex;
        private System.Windows.Forms.Button buttonGetIndex;
        private System.Windows.Forms.Button buttonSetPattern;
        private System.Windows.Forms.Button buttonAdd;
    }
}