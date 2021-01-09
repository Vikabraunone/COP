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
            this.buttonSetIndex = new System.Windows.Forms.Button();
            this.buttonGetIndex = new System.Windows.Forms.Button();
            this.buttonSetPattern = new System.Windows.Forms.Button();
            this.controlListBoxGetting = new ClassLibraryControl.ControlListBoxGetting();
            this.buttonGetText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSetIndex
            // 
            this.buttonSetIndex.Location = new System.Drawing.Point(551, 300);
            this.buttonSetIndex.Name = "buttonSetIndex";
            this.buttonSetIndex.Size = new System.Drawing.Size(138, 36);
            this.buttonSetIndex.TabIndex = 8;
            this.buttonSetIndex.Text = "Установить индекс";
            this.buttonSetIndex.UseVisualStyleBackColor = true;
            this.buttonSetIndex.Click += new System.EventHandler(this.buttonSetIndex_Click);
            // 
            // buttonGetIndex
            // 
            this.buttonGetIndex.Location = new System.Drawing.Point(407, 300);
            this.buttonGetIndex.Name = "buttonGetIndex";
            this.buttonGetIndex.Size = new System.Drawing.Size(138, 36);
            this.buttonGetIndex.TabIndex = 7;
            this.buttonGetIndex.Text = "Получить индекс";
            this.buttonGetIndex.UseVisualStyleBackColor = true;
            this.buttonGetIndex.Click += new System.EventHandler(this.buttonGetIndex_Click);
            // 
            // buttonSetPattern
            // 
            this.buttonSetPattern.Location = new System.Drawing.Point(34, 301);
            this.buttonSetPattern.Name = "buttonSetPattern";
            this.buttonSetPattern.Size = new System.Drawing.Size(138, 35);
            this.buttonSetPattern.TabIndex = 6;
            this.buttonSetPattern.Text = "Задать шаблон вывода";
            this.buttonSetPattern.UseVisualStyleBackColor = true;
            this.buttonSetPattern.Click += new System.EventHandler(this.buttonSetPattern_Click);
            // 
            // controlListBoxGetting
            // 
            this.controlListBoxGetting.Location = new System.Drawing.Point(25, 12);
            this.controlListBoxGetting.Name = "controlListBoxGetting";
            this.controlListBoxGetting.SelectedIndex = 0;
            this.controlListBoxGetting.Size = new System.Drawing.Size(689, 282);
            this.controlListBoxGetting.TabIndex = 0;
            // 
            // buttonGetText
            // 
            this.buttonGetText.Location = new System.Drawing.Point(263, 301);
            this.buttonGetText.Name = "buttonGetText";
            this.buttonGetText.Size = new System.Drawing.Size(138, 36);
            this.buttonGetText.TabIndex = 9;
            this.buttonGetText.Text = "Получить текст";
            this.buttonGetText.UseVisualStyleBackColor = true;
            this.buttonGetText.Click += new System.EventHandler(this.buttonGetText_Click);
            // 
            // FormControlListGetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 349);
            this.Controls.Add(this.buttonGetText);
            this.Controls.Add(this.buttonSetIndex);
            this.Controls.Add(this.buttonGetIndex);
            this.Controls.Add(this.buttonSetPattern);
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
        private System.Windows.Forms.Button buttonGetText;
    }
}