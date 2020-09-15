using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestsDemo
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Url = "https://www.techhuddle.com/#";
            return driver;
        }
    }
}
