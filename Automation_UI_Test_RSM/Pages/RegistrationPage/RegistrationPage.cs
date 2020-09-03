using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSM_Automation_Test_UI.Pages
{
    class RegistrationPage
    {
        private IWebDriver driver;
        //private WebDriverWait driverWait;

        private string emailAddressField = "ctl00_PlaceHolderMain_txtEmail";
        private string passwordField = "ctl00_PlaceHolderMain_txtPassword";
        private string submitButton = "ctl00_PlaceHolderMain_cmdsubmit";
        private string newMemberLink = "lnkNewUser";
        private string loginURL = "http://vm-asc-rsm-merc.ascent.com.mt:7000/_layouts/15/RSM.ConnectPlus/Login.aspx?ReturnUrl=%2f_layouts%2f15%2fAuthenticate.aspx%3fSource%3d%252F&Source=%2F";

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            //driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        public void EmailIsSendToUser()
        {

        }

        public void UnableToRegisterAlreadyRegisteredUser()
        {

        }

        public void BackButtonIsWorking()
        {

        }

        public void ValidationMessagesPresentedWhenSubmitIsClicked()
        {

        }

        public void UserCanRegisterViaRegisterLinkWithinEmail()
        {

        }
    }
}
