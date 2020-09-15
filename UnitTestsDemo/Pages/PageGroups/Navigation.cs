using OpenQA.Selenium;

namespace UnitTestsDemo.Pages.PageGroups
{
    public class Navigation
    {
        private readonly IWebDriver _driver;

        private string mainPath = "//header[@id=\"main-header\"]";

        private string ButtonPath(string buttonName)
        {
            return $"{mainPath}//a[text()=\"{buttonName}\"]";
        }

        public Navigation(IWebDriver driver)
        {
            _driver = driver;
        }

        public BasePage OpenPage(string buttonName)
        {
            _driver.FindElement(By.XPath(ButtonPath(buttonName))).Click();
            switch (buttonName)
            {
                case "About": return new AboutPage(_driver);
                case "Home": return new HomePage(_driver);
                default: return null;
            }
        }
        
        public AboutPage OpenAboutPage()
        {
            _driver.FindElement(By.XPath(ButtonPath("About"))).Click();
            return new AboutPage(_driver);
        }
    }
}