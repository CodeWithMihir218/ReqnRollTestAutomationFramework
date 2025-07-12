using OpenQA.Selenium;

namespace TestAutomationFramework.Core.Pages
{
    public class PIMPage : BasePage
    {
        private By PIMTab => By.XPath("//span[text()='PIM']");
        private By AddButton => By.XPath("//button[normalize-space()='Add']");
        private By FirstNameField => By.Name("firstName");
        private By LastNameField => By.Name("lastName");
        private By SaveButton => By.XPath("//button[normalize-space()='Save']");

        public PIMPage(IWebDriver driver) : base(driver) { }

        public void NavigateToPIM()
        {
            Click(PIMTab);
        }

        public void AddEmployee(string firstName, string lastName)
        {
            Click(AddButton);
            EnterText(FirstNameField, firstName);
            EnterText(LastNameField, lastName);
            Click(SaveButton);
        }
    }
}
