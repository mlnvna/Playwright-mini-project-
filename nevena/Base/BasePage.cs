using OpenQA.Selenium;

namespace TodoListMe.AutomationTests.Base
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}