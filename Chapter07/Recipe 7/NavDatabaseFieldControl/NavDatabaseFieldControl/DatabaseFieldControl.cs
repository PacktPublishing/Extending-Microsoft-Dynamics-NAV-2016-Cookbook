using System;
using Microsoft.Dynamics.Framework.UI.Extensibility;
using Microsoft.Dynamics.Framework.UI.Extensibility.WinForms;
using System.Windows.Forms;

namespace NavDatabaseFieldControl
{
    [ControlAddInExport("NavDatabaseFieldControl")]
    public class DatabaseFieldControl : WinFormsControlAddInBase, IObjectControlAddInDefinition
    {
        private TextBox textBox;
        private bool valueChanged;

        public event ControlAddInEventHandler ControlAddIn;
        public bool HasValueChanged {
            get { return valueChanged; }
        }

        public object Value
        {
            get { return textBox.Text; }
            set {
                textBox.Text = (string)value;
                valueChanged = false;
            }
        }

        protected override Control CreateControl()
        {
            textBox = new TextBox();
            textBox.TextChanged += TextBox_TextChanged;
            textBox.BorderStyle = BorderStyle.None;

            ControlAddIn(0, string.Empty);

            return textBox;
        }

        [ApplicationVisible]
        public bool Editable
        {
            get { return !textBox.ReadOnly; }
            set { textBox.ReadOnly = !value; }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            valueChanged = true;
        }
    }
}
