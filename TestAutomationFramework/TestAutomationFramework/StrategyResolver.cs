using OpenQA.Selenium;
using TestAutomationFramework.Core.Enums;
using TestAutomationFramework.Core.Strategy.API;
using TestAutomationFramework.Core.Strategy.UI;

namespace TestAutomationFramework.Tests
{
    public static class StrategyResolver
    {
        public static object ResolveStrategy(StrategyType strategyType, ExecutionMode mode, IWebDriver driver)
        {
            var strategyMap = new Dictionary<(StrategyType, ExecutionMode), Func<object>>
            {
                { (StrategyType.Employee, ExecutionMode.UI), () => new EmployeeUIActionStrategy(driver) },
                { (StrategyType.Employee, ExecutionMode.API), () => new EmployeeAPIActionStrategy() },

                { (StrategyType.User, ExecutionMode.UI), () => new UserUIActionStrategy(driver) },
                { (StrategyType.User, ExecutionMode.API), () => new UserAPIActionStrategy() },

                { (StrategyType.Leave, ExecutionMode.UI), () => new LeaveUIActionStrategy(driver) },
                { (StrategyType.Leave, ExecutionMode.API), () => new LeaveAPIActionStrategy() },

                { (StrategyType.LeaveHistory, ExecutionMode.UI), () => new LeaveHistoryUIActionStrategy(driver) }
            };

            if (!strategyMap.TryGetValue((strategyType, mode), out var strategyFactory))
            {
                throw new ArgumentException($"Strategy not found for: {strategyType} with mode: {mode}");
            }

            return strategyFactory.Invoke();
        }
    }

}
