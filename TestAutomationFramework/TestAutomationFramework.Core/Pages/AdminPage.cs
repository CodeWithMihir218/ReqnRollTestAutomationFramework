using OpenQA.Selenium;

namespace TestAutomationFramework.Core.Pages
{
    public class AdminPage : BasePage
    {
        private By AdminTab => By.XPath("//span[text()='Admin']");
        private By AddButton => By.XPath("//button[normalize-space()='Add']");
        private By UsernameField => By.XPath("//label[text()='Username']/../following-sibling::div/input");
        private By RoleDropdown => By.XPath("//label[text()='User Role']/../following-sibling::div//div[contains(@class,'dropdown')]//i");
        private By SaveButton => By.XPath("//button[normalize-space()='Save']");

        public AdminPage(IWebDriver driver) : base(driver) { }

        public void NavigateToAdmin()
        {
            Click(AdminTab);
        }

        public void AddUser(string username, string role)
        {
            Click(AddButton);
            EnterText(UsernameField, username);
            Click(RoleDropdown);
            Click(By.XPath($"//div[@role='listbox']//span[text()='{role}']"));
            Click(SaveButton);
        }
    }
}
