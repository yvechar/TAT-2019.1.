using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using task_9;

namespace test_task_9
{
    /// <summary>
    /// To test that the letter reached and displayed as unread and that the correct sender. 
    /// Read the letter and test that the actual content matches the one sent.
    /// </summary>
    class TestLetter
    {
        private IWebDriver Driver { get; set; }
        [SetUp]
        public void OpenBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://passport.yandex.by");
        }

        /// <summary>
        /// in yandex main page we test that letter shown as the unread letter
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="letter"></param>
        [TestCase("", "")]
        public void Letter_UnRead_UnReadLetterDisplayed(string mail, string letter)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            MainYandexPage mailPage = new MainYandexPage(Driver);
            Assert.IsTrue(Driver.FindElement(By.XPath("")).Displayed);
        }

        /// <summary>
        /// in yandex main page we test the correct sender
        /// </summary>
        /// <param name="sender"></param>
        [TestCase("имя1 фамилия1")]
        [TestCase("имя2 фамилия2")]
        public void Letter_CorrectSender_CorrectSenderDisplayed(string sender)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            MainYandexPage mailPage = new MainYandexPage(Driver);
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[contains(text(), 'имя2 фамилия2')]")).Displayed);
        }

        /// <summary>
        /// in yandex letter page we test that the actual content matches the one sent
        /// </summary>
        /// <param name="letter"></param>
        [TestCase("Not Ready")]
        [TestCase("Ready")]
        public void LetterText_CorrectText_CorrectTextDisplayed(string letter)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            LetterYandexPage letterPage = new LetterYandexPage(Driver);
            Assert.IsTrue(Driver.FindElement(By.XPath("//div[@class = 'mail-Message-Body-Content' and (contains(text(), 'Ready') )]")).Displayed);
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
