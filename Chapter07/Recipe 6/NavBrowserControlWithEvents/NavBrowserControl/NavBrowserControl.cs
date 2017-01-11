using System;
using Microsoft.Dynamics.Framework.UI.Extensibility;
using Microsoft.Dynamics.Framework.UI.Extensibility.WinForms;
using System.Windows.Forms;

namespace NavBrowserControl
{
    [ControlAddInExport("NavWebBrowserControl")]
    public class NavWebBrowser : WinFormsControlAddInBase
    {
        private WebBrowser browser;

        [ApplicationVisible]
        public event ControlAddInEventHandler BrowserNavigating;
        [ApplicationVisible]
        public event ControlAddInEventHandler BrowserNavigated;

        protected override Control CreateControl()
        {
            browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;

            browser.Navigating += Browser_Navigating;
            browser.Navigated += Browser_Navigated;

            return browser;
        }

        [ApplicationVisible]
        public void Navigate(string url)
        {
            browser.Navigate(url);
        }

        private void Browser_Navigating(object sender, EventArgs e)
        {
            BrowserNavigating(0, String.Empty);
        }

        private void Browser_Navigated(object sender, EventArgs e)
        {
            BrowserNavigated(0, String.Empty);
        }
    }
}
