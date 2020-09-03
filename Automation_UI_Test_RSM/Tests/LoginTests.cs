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
        public void TestLoginWithValidUser()
        {
            TestUser validUser = new TestUser(ConfigurationManager.AppSettings["ValidUserEmail"], ConfigurationManager.AppSettings["ValidUserPassword"]);

            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(validUser);
            loginPage.AssertLandingTitleAreEqual("Landing");
        }

        [Test]
        public void TestLoginWithInvalidUserEmail()
        {
            TestUser invalidUserEmail = new TestUser(ConfigurationManager.AppSettings["InvalidUserEmail"], ConfigurationManager.AppSettings["ValidUserPassword"]);

            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(invalidUserEmail);
            loginPage.AssertLandingTitleAreEqual("RSM Applications Login");
        }

        [Test]
        public void TestLoginWithInvalidUserPassword()
        {
            TestUser invalidUserPassword = new TestUser(ConfigurationManager.AppSettings["ValidUserEmail"], ConfigurationManager.AppSettings["InvalidUserPassword"]);

            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(invalidUserPassword);
            loginPage.AssertLandingTitleAreEqual("RSM Applications Login");
        }

        [Test]
        public void TestNewMemberLinkCanBeOpened()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.NewMemberLinkCanBeOpened();
            loginPage.AssertLandingTitleAreEqual("RSM Connect Register Page");
        }
    }
}