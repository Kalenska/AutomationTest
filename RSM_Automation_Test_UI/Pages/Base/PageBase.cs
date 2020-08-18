using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSM_Automation_Test_UI.Pages
{
    public class PageBase
    {
        public IWebDriver driver;

        public PageBase(IWebDriver driver)
        {
          this.driver = driver;
         //driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
      }
    }

}
