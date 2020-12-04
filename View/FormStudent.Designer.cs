namespace View
{
    partial class FormStudent
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxFormEducation = new System.Windows.Forms.ComboBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFormEducation = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(137, 176);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 22);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(60, 176);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(71, 22);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(27, 134);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(210, 20);
            this.textBoxEmail.TabIndex = 21;
            // 
            // comboBoxFormEducation
            // 
            this.comboBoxFormEducation.FormattingEnabled = true;
            this.comboBoxFormEducation.Location = new System.Drawing.Point(27, 79);
            this.comboBoxFormEducation.Name = "comboBoxFormEducation";
            this.comboBoxFormEducation.Size = new System.Drawing.Size(210, 21);
            this.comboBoxFormEducation.TabIndex = 20;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(27, 31);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(210, 20);
            this.textBoxFIO.TabIndex = 19;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(24, 118);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(107, 13);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "Электронная почта:";
            // 
            // labelFormEducation
            // 
            this.labelFormEducation.AutoSize = true;
            this.labelFormEducation.Location = new System.Drawing.Point(24, 63);
            this.labelFormEducation.Name = "labelFormEducation";
            this.labelFormEducation.Size = new System.Drawing.Size(96, 13);
            this.labelFormEducation.TabIndex = 17;
            this.labelFormEducation.Text = "Форма обучения:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(24, 15);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 16;
            this.labelFIO.Text = "ФИО:";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 216);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.comboBoxFormEducation);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFormEducation);
            this.Controls.Add(this.labelFIO);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студент";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxFormEducation;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFormEducation;
        private System.Windows.Forms.Label labelFIO;
    }
}