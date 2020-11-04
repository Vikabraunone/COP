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
            this.buttonControlListGetting = new System.Windows.Forms.Button();
            this.buttonControlEntered = new System.Windows.Forms.Button();
            this.buttonControlSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonControlListGetting
            // 
            this.buttonControlListGetting.Location = new System.Drawing.Point(45, 166);
            this.buttonControlListGetting.Name = "buttonControlListGetting";
            this.buttonControlListGetting.Size = new System.Drawing.Size(190, 40);
            this.buttonControlListGetting.TabIndex = 5;
            this.buttonControlListGetting.Text = "Компонент вывода списка";
            this.buttonControlListGetting.UseVisualStyleBackColor = true;
            this.buttonControlListGetting.Click += new System.EventHandler(this.buttonControlListGetting_Click);
            // 
            // buttonControlEntered
            // 
            this.buttonControlEntered.Location = new System.Drawing.Point(45, 96);
            this.buttonControlEntered.Name = "buttonControlEntered";
            this.buttonControlEntered.Size = new System.Drawing.Size(190, 40);
            this.buttonControlEntered.TabIndex = 4;
            this.buttonControlEntered.Text = "Компонент ввода";
            this.buttonControlEntered.UseVisualStyleBackColor = true;
            this.buttonControlEntered.Click += new System.EventHandler(this.buttonControlEntered_Click);
            // 
            // buttonControlSelected
            // 
            this.buttonControlSelected.Location = new System.Drawing.Point(45, 26);
            this.buttonControlSelected.Name = "buttonControlSelected";
            this.buttonControlSelected.Size = new System.Drawing.Size(190, 40);
            this.buttonControlSelected.TabIndex = 3;
            this.buttonControlSelected.Text = "Компонент выбора";
            this.buttonControlSelected.UseVisualStyleBackColor = true;
            this.buttonControlSelected.Click += new System.EventHandler(this.buttonControlSelected_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 223);
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
    }
}