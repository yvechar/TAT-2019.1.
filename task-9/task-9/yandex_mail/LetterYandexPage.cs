using OpenQA.Selenium;
using System;

namespace task_9
{
    /// <summary>
    /// class LetterYandexPage to sen letter
    /// </summary>
    class LetterYandexPage
    {
        private IWebDriver Driver;

        private IWebElement SendButton { get; set; }
        private IWebElement LetterText { get; set; }
        private IWebElement Receiver { get; set; }

        /// <summary>
        /// The contructor
        /// </summary>
        /// <param name="driver">WebDriver</param>
        public LetterYandexPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        /// <summary>
        /// The method that send a letter
        /// </summary>
        /// <param name="receiver">address ,whom we send letter</param>
        /// <param name="message">letters's message</param>
        public void SendLetter(string receiver ,string message)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Receiver = Driver.FindElement(By.XPath("//div[@class = 'to']/div/div")); 
            Receiver.SendKeys(receiver);
            LetterText = Driver.FindElement(By.XPath("//div[@role = 'textbox']/div/div"));
            LetterText.SendKeys(message);
            SendButton = Driver.FindElement(By.XPath("//span[contains(text(), 'Отправить')]"));
            SendButton.Click();
        }
    }
}
