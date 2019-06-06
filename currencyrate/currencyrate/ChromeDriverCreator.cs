using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace currencyrate
{
    /// <summary>
    /// The class ChromeDriver
    /// </summary>
    class ChromeDriverCreator : ICreater
    {
        /// <summary>
        /// The method that create web driver
        /// </summary>
        public IWebDriver Create()
        {
            return new ChromeDriver();
        }
    }
}
