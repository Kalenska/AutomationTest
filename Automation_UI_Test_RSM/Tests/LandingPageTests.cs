using Automation_UI_Test_RSM.Models;
using Automation_UI_Test_RSM.Pages;
using NUnit.Framework;
using System.Configuration;

namespace Automation_UI_Test_RSM.Tests
{
    class LandingPageTests : TestBase
    {
        TestUser validUser = new TestUser(ConfigurationManager.AppSettings["ValidUserEmail"], ConfigurationManager.AppSettings["ValidUserPassword"]);

        [Test]
        public void TestThatFirmDetailsPageCanBeOpened()
        {
            LandingPage landingPage = new LandingPage(_driver);
            LoginPage loginPage = new LoginPage(_driver);
            Asserts asserts = new Asserts(_driver);

            loginPage.Login(validUser);
            landingPage.FirmDetailsBox().Click();
            asserts.AssertPageTitleAreEqual("Pages - Firm Details");
        }

        [Test]
        public void TestThaPeoplePageCanBeOpened()
        {
            LandingPage landingPage = new LandingPage(_driver);
            LoginPage loginPage = new LoginPage(_driver);
            Asserts asserts = new Asserts(_driver);

            loginPage.Login(validUser);
            landingPage.PeopleBox().Click();
            asserts.AssertPageTitleAreEqual("Pages - People");
        }

        [Test]
        public void TestThaInviteUserPageCanBeOpened()
        {
            LandingPage landingPage = new LandingPage(_driver);
            LoginPage loginPage = new LoginPage(_driver);
            Asserts asserts = new Asserts(_driver);

            loginPage.Login(validUser);
            landingPage.InviteUserBox().Click();
            asserts.AssertPageTitleAreEqual("Add User");
        }

        [Test]
        public void TestThatAdministrationPageCanBeOpened()
        {
            LandingPage landingPage = new LandingPage(_driver);
            LoginPage loginPage = new LoginPage(_driver);
            Asserts asserts = new Asserts(_driver);

            loginPage.Login(validUser);
            landingPage.AdministrationBox().Click();
            asserts.AssertPageTitleAreEqual("Pages - General Menu");
        }
    }
}
