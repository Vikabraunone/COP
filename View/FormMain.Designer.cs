namespace View
{
    partial class FormMain
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
            this.buttonShowCourse = new System.Windows.Forms.Button();
            this.buttonShowForm = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupButtonControl = new ClassLibraryControl.AbstractFactory.GroupButtonControl();
            this.buttonShowProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowCourse
            // 
            this.buttonShowCourse.Location = new System.Drawing.Point(646, 59);
            this.buttonShowCourse.Name = "buttonShowCourse";
            this.buttonShowCourse.Size = new System.Drawing.Size(142, 37);
            this.buttonShowCourse.TabIndex = 2;
            this.buttonShowCourse.Text = "Показать направление";
            this.buttonShowCourse.UseVisualStyleBackColor = true;
            this.buttonShowCourse.Click += new System.EventHandler(this.buttonCourse_Click);
            // 
            // buttonShowForm
            // 
            this.buttonShowForm.Location = new System.Drawing.Point(646, 102);
            this.buttonShowForm.Name = "buttonShowForm";
            this.buttonShowForm.Size = new System.Drawing.Size(142, 36);
            this.buttonShowForm.TabIndex = 4;
            this.buttonShowForm.Text = "Показать форму обучения";
            this.buttonShowForm.UseVisualStyleBackColor = true;
            this.buttonShowForm.Click += new System.EventHandler(this.buttonForm_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(476, 59);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(164, 148);
            this.textBox.TabIndex = 3;
            // 
            // groupButtonControl
            // 
            this.groupButtonControl.Location = new System.Drawing.Point(12, 21);
            this.groupButtonControl.Name = "groupButtonControl";
            this.groupButtonControl.Size = new System.Drawing.Size(663, 212);
            this.groupButtonControl.TabIndex = 0;
            // 
            // buttonShowProgram
            // 
            this.buttonShowProgram.Location = new System.Drawing.Point(646, 144);
            this.buttonShowProgram.Name = "buttonShowProgram";
            this.buttonShowProgram.Size = new System.Drawing.Size(142, 63);
            this.buttonShowProgram.TabIndex = 5;
            this.buttonShowProgram.Text = "Показать образовательную  программу";
            this.buttonShowProgram.UseVisualStyleBackColor = true;
            this.buttonShowProgram.Click += new System.EventHandler(this.buttonShowProgram_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 224);
            this.Controls.Add(this.buttonShowProgram);
            this.Controls.Add(this.buttonShowForm);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonShowCourse);
            this.Controls.Add(this.groupButtonControl);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibraryControl.AbstractFactory.GroupButtonControl groupButtonControl;
        private System.Windows.Forms.Button buttonShowCourse;
        private System.Windows.Forms.Button buttonShowForm;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonShowProgram;
    }
}