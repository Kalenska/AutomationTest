using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation_UI_Test_RSM.Pages
{
    class Asserts : PageBase
    {
        public Asserts(IWebDriver driver) : base(driver) { }

        public void AssertPageTitleAreEqual(string pageTitle)
        {
            pageTitle = pageTitle;
            Assert.AreEqual(pageTitle, driver.Title);
        }
    }
}
