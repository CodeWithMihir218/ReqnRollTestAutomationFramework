using OpenQA.Selenium;
using TestAutomationFramework.Core.Pages;
using TestAutomationFramework.Core.Strategy.Interfaces;

namespace TestAutomationFramework.Core.Strategy.UI
{
    public class UserUIActionStrategy : IUserActionStrategy
    {
        private readonly AdminPage _adminPage;

        public UserUIActionStrategy(IWebDriver driver)
        {
            _adminPage = new AdminPage(driver);
        }

        public void AddUser(string username, string role)
        {
            _adminPage.NavigateToAdmin();
            _adminPage.AddUser(username, role);
        }
    }
}
