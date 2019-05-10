using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace task_9
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            //IWebDriver webDriver = new ChromeDriver();
            //LoginYandexPage yandexPage = new LoginYandexPage(webDriver);
            //yandexPage.GoToPage();
            //yandexPage.LoginToMail("ifamilya1", "i8LHxjTDvrdMgCy");

         
            IWebDriver webDriver = new ChromeDriver();
            LoginRamblerPage ramblerPage = new LoginRamblerPage(webDriver);
            ramblerPage.GoToPage();
            ramblerPage.LoginToMail("ifamilya2@rambler.ru", "r7TSn76caDNChD7");

            Console.ReadKey();

        }
    }
}
