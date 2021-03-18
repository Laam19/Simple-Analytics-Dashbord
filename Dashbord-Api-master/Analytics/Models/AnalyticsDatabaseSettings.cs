namespace Analytics.Models
{
    public class AnalyticsDatabaseSettings : IAnalyticsDatabaseSettings
    {
        public string AnalyticsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAnalyticsDatabaseSettings
    {
        string AnalyticsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
