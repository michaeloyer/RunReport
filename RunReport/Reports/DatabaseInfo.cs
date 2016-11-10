using System.Configuration;
using System.Windows.Forms;

namespace DataPull.Reports
{
    public class DatabaseInfo : IReportCreator
    {
        public string Category => "Database Info";
        public string ReportName => "Show Connection String";

        public void CreateReport()
        {
            try
            {
                var dbName = ConfigurationManager.AppSettings["DbName"];
                var connectionString = ConfigurationManager.ConnectionStrings[dbName]?.ConnectionString ?? "#MISSING#";
                MessageBox.Show($"The current Connection String being used is:\n\n{connectionString}");
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show($"There was a problem reading the configuration file.");
            }
        }
    }
}
