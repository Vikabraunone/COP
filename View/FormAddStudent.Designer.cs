namespace View
{
    partial class FormAddStudent
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.labelCource = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(199, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(81, 26);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(96, 188);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 26);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerDateBirth
            // 
            this.dateTimePickerDateBirth.Location = new System.Drawing.Point(122, 141);
            this.dateTimePickerDateBirth.Name = "dateTimePickerDateBirth";
            this.dateTimePickerDateBirth.Size = new System.Drawing.Size(254, 20);
            this.dateTimePickerDateBirth.TabIndex = 17;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(122, 99);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(254, 20);
            this.textBoxAge.TabIndex = 16;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(122, 61);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(254, 20);
            this.textBoxCourse.TabIndex = 15;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(122, 21);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(254, 20);
            this.textBoxFIO.TabIndex = 14;
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Location = new System.Drawing.Point(26, 147);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(89, 13);
            this.labelDateBirth.TabIndex = 13;
            this.labelDateBirth.Text = "Дата рождения:";
            // 
            // labelCource
            // 
            this.labelCource.AutoSize = true;
            this.labelCource.Location = new System.Drawing.Point(26, 64);
            this.labelCource.Name = "labelCource";
            this.labelCource.Size = new System.Drawing.Size(34, 13);
            this.labelCource.TabIndex = 12;
            this.labelCource.Text = "Курс:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(26, 102);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(52, 13);
            this.labelAge.TabIndex = 11;
            this.labelAge.Text = "Возраст:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(26, 24);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 10;
            this.labelFIO.Text = "ФИО:";
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 229);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerDateBirth);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelDateBirth);
            this.Controls.Add(this.labelCource);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBirth;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelDateBirth;
        private System.Windows.Forms.Label labelCource;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelFIO;
    }
}