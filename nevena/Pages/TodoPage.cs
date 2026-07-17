using OpenQA.Selenium;
using TodoListMe.AutomationTests.Base;
using TodoListMe.AutomationTests.Config;

namespace TodoListMe.AutomationTests.Pages
{
    public class TodoPage : BasePage
    {

        public TodoPage(IWebDriver driver) : base(driver) 
        {
           
        }

        private By input = By.Id("newtodo");

        public void Open()
        {
            driver.Navigate().GoToUrl(TestConfig.BaseUrl);
        }

        public void AddNewTask(string task)
        {
            driver.FindElement(input).SendKeys(task + Keys.Enter);
        }

        public void MarkTaskAsCompleted(string taskName)
        {
            var taskItem = driver.FindElement(By.XPath($"//li[contains(.,\"{taskName}\")]"));

            var checkbox = taskItem.FindElement(By.CssSelector("input[type='checkbox']"));

            if (!checkbox.Selected)
                checkbox.Click();
        }

        public bool IsTaskVisible(string taskName)
        {
            return driver.PageSource.Contains(taskName);
        }
    }
}