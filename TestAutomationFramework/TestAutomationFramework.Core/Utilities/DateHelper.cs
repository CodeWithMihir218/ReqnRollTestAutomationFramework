namespace TestAutomationFramework.Core.Utilities
{
    public static class DateHelper
    {
        public static string Today(string format = "yyyy-MM-dd") => DateTime.Now.ToString(format);
        public static string Tomorrow(string format = "yyyy-MM-dd") => DateTime.Now.AddDays(1).ToString(format);
        public static string DaysFromNow(int days, string format = "yyyy-MM-dd") => DateTime.Now.AddDays(days).ToString(format);
    }
}
