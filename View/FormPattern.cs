using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FormPattern : Form
    {
        private readonly Type typeObject;

        public Dictionary<string, string> PatternDictionary { get; private set; }

        public FormPattern(Type typeObject)
        {
            InitializeComponent();
            this.typeObject = typeObject;
            PatternDictionary = new Dictionary<string, string>();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new FormSetFieldName(typeObject);
            if (form.ShowDialog() == DialogResult.OK)
                if (!listBoxPattern.Items.Contains(form.Field))
                {
                    PatternDictionary.Add(form.TextField, form.Field);
                    listBoxPattern.Items.Add(string.Join(":", form.TextField, form.Field));
                }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
