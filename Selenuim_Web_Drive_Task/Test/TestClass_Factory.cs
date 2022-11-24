using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenuim_Web_Drive_Task.PageObjects;
using System;
using Selenuim_Web_Drive_Task.PageObjectModel;

namespace Selenuim_Web_Drive_Task
{
    public class TestClass_Factory
    {
        IWebDriver webDriver;

        [SetUp]
        public void StartBrowser()
        {
            WebDriverFactory factory = new WebDriverFactory();
            webDriver = factory.CreateInstance("Chrome");
            HomePage_Factory home_page = new HomePage_Factory(webDriver);
            home_page.GoToPage();
        }

        [Test]
        public void Test_Factory1()
        {
            HomePage_Factory home_page = new HomePage_Factory(webDriver);
            home_page.Signup();
            home_page.IsSignupSuccessful();
        }

        [Test]
        public void Test_Factory2()
        {
            HomePage_Factory home_page = new HomePage_Factory(webDriver);
            home_page.Title();
            home_page.IsTitleExists();
        }

        [Test]
        public void Test_Factory3()
        {
            HomePage_Factory home_page = new HomePage_Factory(webDriver);
            home_page.Select();
        }

        [TearDown]
        public void CloseBrowser()
        {
            webDriver.Close(); 
        }

    }
}
