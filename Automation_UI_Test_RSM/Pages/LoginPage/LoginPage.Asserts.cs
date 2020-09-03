using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using RSM_Automation_Test_UI.Pages;

namespace RSM_Automation_Test_UI.Pages
{
    public partial class LoginPage : PageBase
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public void AssertLandingTitleAreEqual(string pageTitle)
        {
            PageTtile = pageTitle;
            Assert.AreEqual(pageTitle, driver.Title);
        }
    }
}
