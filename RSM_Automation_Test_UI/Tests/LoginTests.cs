using NUnit.Framework;
using OpenQA.Selenium;
using RSM_Automation_Test_UI.Models;
using RSM_Automation_Test_UI.Pages;
using System.Configuration;

namespace RSM_Automation_Test_UI.Tests
{
    public class LoginTests : TestBase
    {
        [Test]
        public void TestSuccessfulLogin()
        {
            TestUser validUser = new TestUser(ConfigurationManager.AppSettings["ValidUserEmail"], ConfigurationManager.AppSettings["ValidUserPassword"]);

            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(validUser);
        }
    }
}