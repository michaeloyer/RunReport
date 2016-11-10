using System.Windows.Forms;

namespace DataPull.Reports
{
    public class Profitability : IReportCreator
    {
        public string ReportName => "Profitability";
        public string Category => "Sales";

        public void CreateReport()
        {
            MessageBox.Show("We were profitable this year!");
        }
    }
}
