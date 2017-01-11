using Microsoft.Dynamics.Framework.UI.Extensibility;
using Microsoft.Dynamics.Framework.UI.Extensibility.WinForms;
using System.Windows.Forms;
using System.Drawing;

namespace NavAddressBar
{
    [ControlAddInExport("NavAddressBar")]
    public class AddressBarControl : WinFormsControlAddInBase
    {
        private TextBox addressTextBox;

        [ApplicationVisible]
        public string Text
        {
            get { return addressTextBox.Text; }
            set { addressTextBox.Text = value; }
        }

        protected override Control CreateControl()
        {
            addressTextBox = new TextBox();
            return addressTextBox;
        }

        [ApplicationVisible]
        public void SetBackgroundColor(int red, int green, int blue)
        {
            addressTextBox.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
