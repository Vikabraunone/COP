namespace ClassLibraryControl
{
    partial class ControlTextBoxEntered
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxHelp.Location = new System.Drawing.Point(71, 12);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.Size = new System.Drawing.Size(259, 36);
            this.textBoxHelp.TabIndex = 5;
            this.textBoxHelp.TabStop = false;
            this.textBoxHelp.Text = "Электронная почта имеет вид: логин@домен. \r\nНапример: vasheunikalnoeimya@yandex.r" +
    "u";
            this.textBoxHelp.Visible = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(9, 54);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(321, 20);
            this.textBox.TabIndex = 4;
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(9, 15);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(148, 13);
            this.labelEnter.TabIndex = 6;
            this.labelEnter.Text = "Введите электронную почту";
            // 
            // ControlTextBoxChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxHelp);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelEnter);
            this.Name = "ControlTextBoxChecking";
            this.Size = new System.Drawing.Size(341, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelEnter;
    }
}
