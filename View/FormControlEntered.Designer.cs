namespace View
{
    partial class FormControlEntered
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
            this.controlTextBoxEntered = new ClassLibraryControl.ControlTextBoxEntered();
            this.SuspendLayout();
            // 
            // controlTextBoxEntered
            // 
            this.controlTextBoxEntered.Location = new System.Drawing.Point(12, 12);
            this.controlTextBoxEntered.Name = "controlTextBoxEntered";
            this.controlTextBoxEntered.Size = new System.Drawing.Size(341, 83);
            this.controlTextBoxEntered.TabIndex = 0;
            this.controlTextBoxEntered.TextBoxTextChange += new System.EventHandler(this.controlTextBoxEntered_TextBoxTextChange);
            // 
            // FormControlEntered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 104);
            this.Controls.Add(this.controlTextBoxEntered);
            this.Name = "FormControlEntered";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компонент ввода";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibraryControl.ControlTextBoxEntered controlTextBoxEntered;
    }
}