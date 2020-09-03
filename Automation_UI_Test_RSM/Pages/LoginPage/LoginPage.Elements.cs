using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace RSM_Automation_Test_UI.Pages
{
    public partial class LoginPage
    {
        //public readonly static string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        //public readonly static string loginPageUrl = ConfigurationManager.AppSettings["LoginUrl"];
        //public readonly static string fullLoginPageUrl = $"{baseUrl}/{loginPageUrl}";

        public string emailAddressField = "ctl00_PlaceHolderMain_txtEmail";
        public string passwordField = "ctl00_PlaceHolderMain_txtPassword";
        public string submitButton = "ctl00_PlaceHolderMain_cmdsubmit";
        public string newMemberLink = "lnkNewUser";
        public string PageTtile { get; set; }

        public IWebElement EmailInputField()
        {
            return driver.FindElement(By.Id(emailAddressField)); 
        }

        public IWebElement PasswordInputField()
        {
            return driver.FindElement(By.Id(passwordField));
        }

        public IWebElement SubmitButton()
        {
            return driver.FindElement(By.Id(submitButton));
        }

        public IWebElement NewMemberLinkButton()
        {
            return driver.FindElement(By.Id(newMemberLink));
        }
    }
}
