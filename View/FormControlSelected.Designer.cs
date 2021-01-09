namespace View
{
    partial class FormControlSelected
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
            this.buttonChangeIndex = new System.Windows.Forms.Button();
            this.buttonShowIndex = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.controlComboBoxSelected = new ClassLibraryControl.ControlComboBoxSelected();
            this.SuspendLayout();
            // 
            // buttonChangeIndex
            // 
            this.buttonChangeIndex.Location = new System.Drawing.Point(166, 66);
            this.buttonChangeIndex.Name = "buttonChangeIndex";
            this.buttonChangeIndex.Size = new System.Drawing.Size(127, 32);
            this.buttonChangeIndex.TabIndex = 4;
            this.buttonChangeIndex.Text = "Сменить индекс";
            this.buttonChangeIndex.UseVisualStyleBackColor = true;
            this.buttonChangeIndex.Click += new System.EventHandler(this.buttonChangeIndex_Click);
            // 
            // buttonShowIndex
            // 
            this.buttonShowIndex.Location = new System.Drawing.Point(20, 66);
            this.buttonShowIndex.Name = "buttonShowIndex";
            this.buttonShowIndex.Size = new System.Drawing.Size(127, 32);
            this.buttonShowIndex.TabIndex = 3;
            this.buttonShowIndex.Text = "Показать индекс";
            this.buttonShowIndex.UseVisualStyleBackColor = true;
            this.buttonShowIndex.Click += new System.EventHandler(this.buttonShowIndex_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(308, 67);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(127, 31);
            this.buttonChange.TabIndex = 7;
            this.buttonChange.Text = "Изменить текст";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // controlComboBoxSelected
            // 
            this.controlComboBoxSelected.Location = new System.Drawing.Point(12, 21);
            this.controlComboBoxSelected.Name = "controlComboBoxSelected";
            this.controlComboBoxSelected.SelectedIndex = 0;
            this.controlComboBoxSelected.SelectedText = "";
            this.controlComboBoxSelected.Size = new System.Drawing.Size(432, 29);
            this.controlComboBoxSelected.TabIndex = 0;
            this.controlComboBoxSelected.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // FormControlSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 109);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonChangeIndex);
            this.Controls.Add(this.buttonShowIndex);
            this.Controls.Add(this.controlComboBoxSelected);
            this.Name = "FormControlSelected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компонент выбора";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibraryControl.ControlComboBoxSelected controlComboBoxSelected;
        private System.Windows.Forms.Button buttonChangeIndex;
        private System.Windows.Forms.Button buttonShowIndex;
        private System.Windows.Forms.Button buttonChange;
    }
}