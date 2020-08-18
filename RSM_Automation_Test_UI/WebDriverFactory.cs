using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RSM_Automation_Test_UI
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver()
        {
           return new ChromeDriver();
        }
    }
}
