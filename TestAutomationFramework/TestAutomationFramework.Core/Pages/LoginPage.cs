using OpenQA.Selenium;
using TestAutomationFramework.Core.Utilities;

namespace TestAutomationFramework.Core.Pages
{
    public class LoginPage : BasePage
    {
        private By UsernameInput => By.XPath("//input[@placeholder='Username']");
        private By PasswordInput => By.XPath("//input[@placeholder='Password']");
        private By LoginButton => By.CssSelector("button[type='submit']");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void NavigateToLoginPage()
        {
            Driver.Navigate().GoToUrl(ConfigManager.GetOrangeHrmBaseUrl());
            WaitUntilVisible(UsernameInput);
        }

        public void Login(string username, string password)
        {
            EnterText(UsernameInput, username);
            EnterText(PasswordInput, password);
            Click(LoginButton);
        }
    }

}
