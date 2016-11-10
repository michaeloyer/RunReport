using System.Windows.Forms;

namespace DataPull.Reports
{
    public class Inventory : IReportCreator
    {
        public string ReportName => "Inventory";
        public string Category => "Inventory";

        public void CreateReport()
        {
            MessageBox.Show("Inventory is running low.");
        }
    }
}
