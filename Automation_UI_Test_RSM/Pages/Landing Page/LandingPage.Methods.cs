using System.Configuration;
using OpenQA.Selenium;

namespace Automation_UI_Test_RSM.Pages
{
    public partial class LandingPage
    {
        private IWebDriver _driver;

        public void GoToLandingUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            string loginPageUrl = ConfigurationManager.AppSettings["LandingUrl"];
            var test = $"{baseUrl}/{loginPageUrl}";
            driver.Navigate().GoToUrl(test);
        }
    }
}
