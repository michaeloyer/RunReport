using System.Windows.Forms;

namespace DataPull.Reports
{
    public class Depreciation : IReportCreator
    {
        public string ReportName => "Depreciation";
        public string Category => "Inventory";

        public void CreateReport()
        {
            MessageBox.Show("This old inventory is still worth a little something.");
        }
    }
}
