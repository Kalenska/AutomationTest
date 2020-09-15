using OpenQA.Selenium;

namespace UnitTestsDemo.Pages.PageGroups
{
    public class Footer
    {
        private IWebDriver _driver;
        public ConnectWithUs ConnectWithUs { get; }
        public Footer(IWebDriver driver)
        {
            _driver = driver;
            ConnectWithUs = new ConnectWithUs(driver);
        }
    }
}