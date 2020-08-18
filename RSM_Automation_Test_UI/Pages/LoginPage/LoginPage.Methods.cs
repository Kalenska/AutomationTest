using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using OpenQA.Selenium;
using RSM_Automation_Test_UI.Models;

namespace RSM_Automation_Test_UI.Pages
{
    public partial class LoginPage : PageBase
    {
        //private string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        //private string loginPageUrl = ConfigurationManager.AppSettings["LoginUrl"];

        //private string fullLoginPageUrl => $"{baseUrl}/{loginPageUrl}";

        public LoginPage(IWebDriver driver) : base(driver) { }

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
            LoginPage LoginPage = new LoginPage(driver);
            LoginPage.GoToLoginUrl();
            LoginPage.EmailInputField().SendKeys(testUser.Username);
            LoginPage.PasswordInputField().SendKeys(testUser.Password);
            LoginPage.Submit();
        }

      

      

       // public void CannotLoginWithValidEmailandInvalidPasswor(TestUser rsmAdminWrongPassword)
       // {
        //    driver.Navigate().GoToUrl(fullLoginPageUrl);
        //    driver.FindElement(By.Id(emailAddressField)).SendKeys(rsmAdminWrongPassword.Username);
         //   driver.FindElement(By.Id(passwordField)).SendKeys(rsmAdminWrongPassword.Password);
         //   driver.FindElement(By.Id(submitButton)).Click();
     //   }

      //  public void NewMemberLinkCanBeOpened()
      //  {
        //    driver.Navigate().GoToUrl(fullLoginPageUrl);
        //    driver.FindElement(By.Id(newMemberLink)).Click();
       // }
    }
}

