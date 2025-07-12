using global::TestAutomationFramework.Core.Drivers;
using OpenQA.Selenium;
using Reqnroll;
using TestAutomationFramework.Core.Reporting;

namespace TestAutomationFramework.Tests.Hooks
{
    [Binding]
    public sealed class TestHooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;
        private readonly IWebDriver _driver;

        public TestHooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
            _driver = DriverManager.GetDriver();
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Before Test Run");
            ReportManager.InitializeReport();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("After Test Run");
            ReportManager.FlushReport();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine($"Starting Feature: {featureContext.FeatureInfo.Title}");
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            Console.WriteLine($"Ending Feature: {featureContext.FeatureInfo.Title}");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine($"Starting Scenario: {_scenarioContext.ScenarioInfo.Title}");
            ReportManager.CreateScenario(_scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine($"Ending Scenario: {_scenarioContext.ScenarioInfo.Title}");

            if (_scenarioContext.TestError != null)
            {
                var screenshotPath = DriverManager.CaptureScreenshot(_scenarioContext.ScenarioInfo.Title);
                ReportManager.LogFailure(_scenarioContext.TestError.Message, screenshotPath);
            }

            DriverManager.QuitDriver();
        }

        [BeforeStep]
        public void BeforeStep()
        {
            ReportManager.CreateStep(_scenarioContext.StepContext.StepInfo.Text);
        }

        [AfterStep]
        public void AfterStep()
        {
            if (_scenarioContext.TestError == null)
            {
                ReportManager.MarkStepPassed();
            }
            else
            {
                ReportManager.MarkStepFailed(_scenarioContext.TestError.Message);
            }
        }
    }
}
