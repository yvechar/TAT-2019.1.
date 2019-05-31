using OpenQA.Selenium;
using System;

namespace task_9
{
    /// <summary>
    /// class MailYandexPage , main mail page , here we see inbox letters, and we can read it , replay here?
    /// </summary>
    class MainYandexPage
    {
        private IWebDriver Driver;
        private IWebElement UnReadLetter { get; set; }
        private IWebElement SendButton { get; set; }
        private IWebElement ReplayButton { get; set; }
        private IWebElement NewLetter { get; set; }

        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="driver">WebDriver</param>
        public MainYandexPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        /// <summary>
        /// The method  ReplayOnLetter to read letter and replay on it
        /// </summary> 
        public void ReplayOnLetter(string sender,string new_letter)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            UnReadLetter = Driver.FindElement(By.XPath("//span[@class = 'mail-MessageSnippet-FromText']//class[contains(@title, '{sender}')]"));
            UnReadLetter.Click();
            ReplayButton = Driver.FindElement(By.XPath("//div[@title = 'Ответить']"));
            ReplayButton.Click();
            NewLetter = Driver.FindElement(By.XPath("//div[@role='textbox']"));
            NewLetter.SendKeys(new_letter);
            SendButton = Driver.FindElement(By.XPath("//span[contains(text(), 'Отправить')]"));
            SendButton.Click();
        }      
    }
}
