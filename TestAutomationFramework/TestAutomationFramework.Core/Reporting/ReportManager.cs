using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace TestAutomationFramework.Core.Reporting
{
    public static class ReportManager
    {
        private static ExtentReports _extent;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;
        private static ExtentTest _step;
        private static ExtentSparkReporter _sparkReporter;

        private static readonly string ReportDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestReports");
        private static readonly string ReportPath = Path.Combine(ReportDir, $"ExtentReport_{DateTime.Now:yyyyMMdd_HHmmss}.html");

        public static void InitializeReport()
        {
            Directory.CreateDirectory(ReportDir);
            _sparkReporter = new ExtentSparkReporter(ReportPath);
            _sparkReporter.Config.DocumentTitle = "Automation Test Report";
            _sparkReporter.Config.ReportName = "Regression Suite";

            _extent = new ExtentReports();
            _extent.AttachReporter(_sparkReporter);
        }

        public static void CreateScenario(string scenarioName)
        {
            _scenario = _extent.CreateTest(scenarioName);
        }

        public static void CreateStep(string stepText)
        {
            _step = _scenario.CreateNode(stepText);
        }

        public static void MarkStepPassed()
        {
            _step.Pass("Step passed");
        }

        public static void MarkStepFailed(string error)
        {
            _step.Fail(error);
        }

        public static void LogFailure(string error, string screenshotPath)
        {
            _scenario.Fail(error).AddScreenCaptureFromPath(screenshotPath);
        }

        public static void FlushReport()
        {
            _extent.Flush();
        }
    }
}
