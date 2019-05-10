using OpenQA.Selenium;
using System;

namespace task_9
{
    /// <summary>
    /// 
    /// </summary>
    class SettingRamblerPage
    {
        private IWebDriver Driver { get; set; }
        private IWebElement Name { get; set; }
        private IWebElement SaveButton { get; set; }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="driver">WebDriver</param>
        public SettingRamblerPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        /// <summary>
        /// The method ChangeName to change name to a new one
        /// </summary>
        /// <param name="newNickname">New nickname</param>
        public void ChangeName(string new_name)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Name = Driver.FindElement(By.XPath("//input[@class = 'rui-Input-input']"));
            Name.Clear();
            Name.SendKeys(new_name);
            SaveButton = Driver.FindElement(By.XPath("//span[text() = 'Сохранить измения']"));
            SaveButton.Click();
        }
    }
}
