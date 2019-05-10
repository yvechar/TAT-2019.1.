using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using task_9;

namespace test_task_9
{
    /// <summary>
    /// tests for yandex mail
    /// </summary>
    class Test1
    {
        private IWebDriver Driver { get; set; }

        [SetUp]
        public void OpenBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://passport.yandex.by");
        }

        [TestCase("ifamilya1@yandex.by", "i8LHxjTDvrdMgCy")]
        public void Login_CorrectInput_ElementDisplayed(string login, string password)
        {
            LoginYandexPage mailPage = new LoginYandexPage(Driver);
            mailPage.LoginToMail(login, password);
            Assert.IsTrue(Driver.FindElement(By.XPath("")).Displayed);
        }

        [TestCase("mail", "password")]
        [TestCase(" ", " ")]
        [TestCase(" ", "password")]
        [TestCase("mail", " ")]
        public void Login_IncorrectInput_ErrorDisplayed(string login, string password)
        {
            LoginYandexPage mailPage = new LoginYandexPage(Driver);
            mailPage.LoginToMail(login, password);
            Assert.IsTrue(Driver.FindElement(By.XPath("")).Displayed);
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
