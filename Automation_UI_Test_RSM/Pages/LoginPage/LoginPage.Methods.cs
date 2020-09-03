using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using RSM_Automation_Test_UI.Models;

namespace RSM_Automation_Test_UI.Pages
{
    public partial class LoginPage
    {
        //private string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        //private string loginPageUrl = ConfigurationManager.AppSettings["LoginUrl"];
        //private string fullLoginPageUrl => $"{baseUrl}/{loginPageUrl}";
        //public string expectedLandingTitle = "Landing";

        public void GoToLoginUrl()
        {
            string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            string loginPageUrl = ConfigurationManager.AppSettings["LoginUrl"];
            var test = $"{baseUrl}/{loginPageUrl}";
            driver.Navigate().GoToUrl(test);
        }

        public void Submit()
        {
            SubmitButton().Click();
        }

        public void Login(TestUser testUser)
        {
            GoToLoginUrl();
            EmailInputField().SendKeys(testUser.Username);
            PasswordInputField().SendKeys(testUser.Password);
            Submit();
        }

        public void NewMemberLinkCanBeOpened()
        {
            GoToLoginUrl();
            NewMemberLinkButton().Click();
        }
    }
}

