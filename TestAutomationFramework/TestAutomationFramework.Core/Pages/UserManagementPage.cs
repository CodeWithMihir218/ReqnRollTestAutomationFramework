using OpenQA.Selenium;

namespace TestAutomationFramework.Core.Pages
{
    public class UserManagementPage
    {
        private readonly IWebDriver _driver;

        public UserManagementPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By AddUserButton => By.XPath("//button[normalize-space()='Add']");
        private By UserRoleDropdown => By.XPath("//label[text()='User Role']/following::div[@class='oxd-select-text-input'][1]");
        private By UsernameField => By.XPath("//label[text()='Username']/following::input[1]");
        private By PasswordField => By.XPath("//label[text()='Password']/following::input[1]");
        private By ConfirmPasswordField => By.XPath("//label[text()='Confirm Password']/following::input[1]");
        private By SaveButton => By.XPath("//button[normalize-space()='Save']");
        private By SuccessToast => By.CssSelector(".oxd-toast .oxd-toast-content");

        public void ClickAddUser()
        {
            _driver.FindElement(AddUserButton).Click();
        }

        public void SelectUserRole(string role)
        {
            _driver.FindElement(UserRoleDropdown).Click();
            var roleOption = By.XPath($"//div[@role='option']//span[text()='{role}']");
            _driver.FindElement(roleOption).Click();
        }

        public void FillUsername(string username)
        {
            _driver.FindElement(UsernameField).SendKeys(username);
        }

        public void FillPassword(string password)
        {
            _driver.FindElement(PasswordField).SendKeys(password);
            _driver.FindElement(ConfirmPasswordField).SendKeys(password);
        }

        public void ClickSave()
        {
            _driver.FindElement(SaveButton).Click();
        }

        public bool IsSuccessMessageDisplayed()
        {
            try
            {
                return _driver.FindElement(SuccessToast).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void AddNewUser(string role, string username, string password)
        {
            ClickAddUser();
            SelectUserRole(role);
            FillUsername(username);
            FillPassword(password);
            ClickSave();
        }
    }
}
