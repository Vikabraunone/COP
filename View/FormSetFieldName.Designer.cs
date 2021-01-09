namespace View
{
    partial class FormSetFieldName
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
            this.labelField = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelField
            // 
            this.labelField.AutoSize = true;
            this.labelField.Location = new System.Drawing.Point(43, 75);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(36, 13);
            this.labelField.TabIndex = 9;
            this.labelField.Text = "Поле:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(43, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Наименование:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(46, 36);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(242, 20);
            this.textBox.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(108, 131);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(128, 30);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(46, 91);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(242, 21);
            this.comboBox.TabIndex = 5;
            // 
            // FormSetFieldName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 177);
            this.Controls.Add(this.labelField);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBox);
            this.Name = "FormSetFieldName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задать наименование полю класса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBox;
    }
}