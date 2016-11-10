namespace DataPull
{
    public interface IReportCreator
    {
        string ReportName { get; }
        string Category { get; }

        void CreateReport();
    }
}
