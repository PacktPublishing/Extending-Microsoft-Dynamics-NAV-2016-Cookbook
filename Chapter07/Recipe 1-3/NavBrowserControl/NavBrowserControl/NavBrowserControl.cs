using Microsoft.Dynamics.Framework.UI.Extensibility;
using Microsoft.Dynamics.Framework.UI.Extensibility.WinForms;
using System.Windows.Forms;

namespace NavBrowserControl
{
    [ControlAddInExport("NavWebBrowserControl")]
    public class NavWebBrowser : WinFormsControlAddInBase
    {
        private WebBrowser browser;

        protected override Control CreateControl()
        {
            browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;

            return browser;
        }

        [ApplicationVisible]
        public void Navigate(string url)
        {
            browser.Navigate(url);
        }
    }
}
