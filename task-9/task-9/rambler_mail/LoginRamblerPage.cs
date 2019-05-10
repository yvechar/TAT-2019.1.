using OpenQA.Selenium;
using System;

namespace task_9
{
    class LoginRamblerPage
    {
        private IWebDriver Driver;
        private IWebElement LoginButton { get; set; }
        private IWebElement Login { get; set; }
        private IWebElement Password { get; set; }
 
        /// <summary>
        /// The contructor of Login Yandex Page
        /// </summary>
        /// <param name="driver"></param>
        public LoginRamblerPage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        /// <summary>
        /// The metod GoToPage do to login Rambler mail page
        /// </summary>
        public void GoToPage()
        {
            Driver.Navigate().GoToUrl("https://mail.rambler.ru");      
        }

        /// <summary>
        /// The method LoginToMai to log in the mail
        /// </summary>
        /// <param name="login">account's login</param>
        /// <param name="password">account's password</param>
        /// <returns>Login Rambler Page</returns>
        public LoginRamblerPage LoginToMail(string login, string password)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe")));
            Login = Driver.FindElement(By.XPath("//input[@name = 'login']"));
            Login.SendKeys(login);
            Password = Driver.FindElement(By.XPath("//input[@name = 'password']"));
            Password.SendKeys(password);
            LoginButton = Driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();
            Driver.SwitchTo().DefaultContent();

            return new LoginRamblerPage(Driver);
        }
    }
}
