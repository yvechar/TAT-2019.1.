using OpenQA.Selenium;
using System;

namespace task_9
{
    /// <summary>
    /// Class LoginYandexPage to login to Yandex Mail
    /// </summary>
    class LoginYandexPage
    {
        private IWebDriver Driver;
        private IWebElement LoginButton { get; set; }
        private IWebElement Password { get; set; }
        private IWebElement Login { get; set; }

        /// The contructor
        /// </summary>
        /// <param name="driver">WebDriver</param>
        public LoginYandexPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        /// <summary>
        /// The metod GoToPage do to login Yandex mail page
        /// </summary>
        public void GoToPage()
        {
            Driver.Navigate().GoToUrl("https://passport.yandex.by");
        }

        /// <summary>
        /// The method LoginToMai to log in the mail
        /// </summary>
        /// <param name="login">account's login</param>
        /// <param name="password">account's password</param>
        /// <returns>Login Yandex Page</returns>
        public LoginYandexPage LoginToMail(string login,string password)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Login = Driver.FindElement(By.XPath("//input[@name = 'login']"));
            Login.SendKeys(login);
            LoginButton = Driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();
            Password = Driver.FindElement(By.XPath("//input[@name = 'passwd']"));
            Password.SendKeys(password);
            LoginButton = Driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();

             return new LoginYandexPage(Driver);
        }
    }
}
