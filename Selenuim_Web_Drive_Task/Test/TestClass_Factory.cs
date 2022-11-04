using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenuim_Web_Drive_Task.PageObjects;
using System;

namespace Selenuim_Web_Drive_Task
{
    public class TestClass_Factory
    {
        IWebDriver webDriver;

        [SetUp]
        public void startBrowser()
        {
            WebDriverFactory factory = new WebDriverFactory();
            webDriver = factory.CreateInstance("Chrome");
            HomePage_Factory home_page = new HomePage_Factory(webDriver);
            home_page.GoToPage();
        }

        [Test]
        public void Test_Factory()
        {
            HomePage_Factory home_page = new HomePage_Factory(webDriver);
            //act
            home_page.Signup();
            //assert
            home_page.IsSignupSuccessful();
        }

        [TearDown]
        public void closeBrowser()
        {
            webDriver.Quit(); 
        }

    }
}
