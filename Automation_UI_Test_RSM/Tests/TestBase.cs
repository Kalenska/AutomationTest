using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSM_Automation_Test_UI.Tests
{
    public class TestBase
    {
        public IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverFactory.CreateDriver();
        }

        [OneTimeSetUp]
        public void Init()
        {
            // Login
        }

        //[OneTimeTearDown]
        //public void TearDown()
        //{
        //    _driver.Quit();
        //}

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        //onetimesetup
        //onetimeteardown
        //driver.quit
        //api create and delete 
    }
}
