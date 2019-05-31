using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using task_9;

namespace test_task_9
{
    /// <summary>
    /// tests for rambler mail
    /// </summary>
    class TestRamblerLogin
    {
        private IWebDriver Driver { get; set; }

        [SetUp]
        public void OpenBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://mail.rambler.ru");
        }

        [TestCase("ifamilya2@rambler.ru", "r7TSn76caDNChD7")]
        public void Login_CorrectInput_PageDisplayed(string login, string password)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginRamblerPage mailPage = new LoginRamblerPage(Driver);
            mailPage.LoginToMail(login, password);
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[contains(text(), 'Написать письмо')]")).Displayed);
        }

        [TestCase("mail", "password")]
        [TestCase(" ", " ")]
        [TestCase(" ", "password")]
        [TestCase("mail", " ")]
        public void Login_IncorrectInput_ErrorDisplayed(string login, string password)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LoginRamblerPage mailPage = new LoginRamblerPage(Driver);
            mailPage.LoginToMail(login, password);
            Assert.IsTrue(Driver.FindElement(By.XPath("//div[@class = 'rui-Inputstatus-message' and (contains(text(), 'Неправильная почта или пароль') )]")).Displayed);
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
