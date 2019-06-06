using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace currencyrate
{
    /// <summary>
    /// The class CurrencyPage to get currency rate 
    /// </summary>
    class CurrencyPage
    {
        private IWebDriver Driver { get; }
        private IWebElement CurrencyField  { get; set; }
        WebDriverWait WebDriverWait { get; }
        List<IWebElement> Names { get; }
        List<IWebElement> Values { get; }
        private string page = "https://myfin.by/currency/minsk";
        private string locator = "//div[@class = 'best-rates big-rates-table']";
        private string nameLocator = "//div[@class = 'table-responsive']//tr/td/a";
        private string valueLocator = "//div[@class = 'table-responsive']//tr/td[2]";

        /// <summary>
        /// The constructor of page
        /// </summary>
        /// <param name="driver"></param>
        public CurrencyPage(IWebDriver driver)
        {
            this.WebDriverWait = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));
            GoToPage();
            this.Names = Driver.FindElements(By.XPath(nameLocator)).ToList();
            this.Values =Driver.FindElements(By.XPath(valueLocator)).ToList();
        }
        /// <summary>
        /// The method goes to page
        /// </summary>
        public void GoToPage()
        {
           Driver.Navigate().GoToUrl(page);
        }

        /// <summary>
        /// The method to get currency from the table and add to the list
        /// </summary>
        /// <returns></returns>
        public List<Currency> GetCurrency()
        {
            WebDriverWait.Until(t => Driver.FindElements(By.XPath(locator)).Any());
            List<Currency> currencies = new List<Currency>();

            for (int i = 0; i < Names.Count; i++)
            {
                currencies.Add(new Currency(Names[i].Text, Values[i].Text));
            }
            Driver.Quit();

            return currencies;
        }
    }
}
