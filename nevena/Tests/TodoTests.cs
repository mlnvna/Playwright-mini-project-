using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using TodoListMe.AutomationTests.Pages;

namespace TodoListMe.AutomationTests
{
    public class Tests
    {
        private IWebDriver driver;
        private TodoPage todo;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            todo = new TodoPage(driver);

        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
        [Test]
        public void TC001_User_can_add_task_to_todo_list()
        {
            todo.Open();

            todo.AddNewTask("QA Task");

            Assert.That(todo.IsTaskVisible("QA Task"), Is.True, "Task should appear in the line after creation");
        }

        [Test]
        public void TC002_User_can_complete_existing_task()
        {
            todo.Open();

            todo.AddNewTask("Task to complete");

            todo.MarkTaskAsCompleted("Task to complete");

            Assert.That(todo.IsTaskVisible("Task to complete"), Is.True, "Task should be visible after being added");
        }
    }
}