using NUnit.Framework;
using OpenQA.Selenium;
using UnitTestsDemo.Interfaces;
using UnitTestsDemo.Pages;

namespace UnitTestsDemo
{
    public class Tests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverFactory.CreateDriver();
        }

        [Test]
        public void Test1()
        {
            var homePage = new HomePage(_driver);
            homePage.CloseAscentPopUp();
            var aboutPage = homePage.Navigation.OpenPage("About") as AboutPage;
        }
    }
}