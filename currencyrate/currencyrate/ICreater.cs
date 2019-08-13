using OpenQA.Selenium;

namespace currencyrate
{
    /// <summary>
    /// Factory Creater Interface 
    /// </summary>
    interface ICreater
    {
        /// <summary>
        /// The method to creat web driver
        /// </summary>
        /// <param name="currencies">name and values of currency</param>
        IWebDriver Create();
    }
}
