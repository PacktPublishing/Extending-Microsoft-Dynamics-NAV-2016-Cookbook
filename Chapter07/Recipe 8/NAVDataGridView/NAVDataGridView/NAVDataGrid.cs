using Microsoft.Dynamics.Framework.UI.Extensibility;
using Microsoft.Dynamics.Framework.UI.Extensibility.WinForms;
using System.Windows.Forms;
using System.Data;
using System;

namespace NAVDataGridView
{
    [ControlAddInExport("NAVDataGridView")]
    public class NAVDataGrid : WinFormsControlAddInBase
    {
        private DataGridView dataGridView;
        
        [ApplicationVisible]
        public event ControlAddInEventHandler ControlAddIn;

        protected override Control CreateControl()
        {
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.ReadOnly = true;

            ControlAddIn(0, string.Empty);

            return dataGridView;
        }

        [ApplicationVisible]
        public void UpdateView(DataTable dataTable)
        {
            dataGridView.DataSource = dataTable;
        }
    }
}
