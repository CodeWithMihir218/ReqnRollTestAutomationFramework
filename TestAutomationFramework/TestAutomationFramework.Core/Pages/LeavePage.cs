using OpenQA.Selenium;

namespace TestAutomationFramework.Core.Pages
{
    public class LeavePage : BasePage
    {
        private By LeaveTab => By.XPath("//span[text()='Leave']");
        private By ApplyButton => By.XPath("//a[text()='Apply']");
        private By LeaveTypeDropdown => By.XPath("//label[text()='Leave Type']/../following-sibling::div//div[contains(@class,'dropdown')]//i");
        private By FromDateField => By.XPath("//label[text()='From Date']/../following-sibling::div/input");
        private By ToDateField => By.XPath("//label[text()='To Date']/../following-sibling::div/input");
        private By ReasonField => By.XPath("//textarea");
        private By SubmitButton => By.XPath("//button[normalize-space()='Apply']");

        public LeavePage(IWebDriver driver) : base(driver) { }

        public void NavigateToLeave()
        {
            Click(LeaveTab);
        }

        public void ApplyLeave(string leaveType, string fromDate, string toDate, string reason)
        {
            Click(ApplyButton);
            Click(LeaveTypeDropdown);
            Click(By.XPath($"//div[@role='listbox']//span[text()='{leaveType}']"));
            EnterText(FromDateField, fromDate);
            EnterText(ToDateField, toDate);
            EnterText(ReasonField, reason);
            Click(SubmitButton);
        }
    }
}
