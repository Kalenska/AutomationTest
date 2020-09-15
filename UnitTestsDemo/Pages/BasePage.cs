using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UnitTestsDemo.Interfaces;
using UnitTestsDemo.Pages.PageGroups;

namespace UnitTestsDemo.Pages
{
    public class BasePage : IHomePage, IHomePageWithoutFooter
    {
        private readonly IWebDriver _driver;
        private WebDriverWait _driverWait;

        public Navigation Navigation { get; }
        public Footer Footer { get; }

        private string proceedToSiteButton = "//div[@id=\"ascentModal\"]//a[@class=\"popup-modal-dismiss ascent-no-announcement\"]";

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            Navigation = new Navigation(driver);
            Footer = new Footer(driver);
        }

        public void CloseAscentPopUp()
        {
            Thread.Sleep(3000);
            _driver.FindElement(By.XPath(proceedToSiteButton)).Click();
        }
    }
}
