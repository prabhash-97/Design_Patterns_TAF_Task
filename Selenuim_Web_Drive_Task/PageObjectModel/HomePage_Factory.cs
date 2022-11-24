using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using Selenuim_Web_Drive_Task.Singletone;

namespace Selenuim_Web_Drive_Task.PageObjects
{
    public class HomePage_Factory
    {
        string testUrl = "http://demo.guru99.com/test/guru99home/";

        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage_Factory(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            PageFactory.InitElements(driver, this);
        }

        private IWebElement emailTextBox => driver.FindElement(By.CssSelector("input[id=philadelphia-field-email]"));
        private IWebElement signUpButton => driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));
        private IWebElement sapTitle => driver.FindElement(By.XPath("//*[@id=\"site-name\"]/a"));
        private IWebElement course => driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(testUrl);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        public void Signup()
        {
            emailTextBox.Clear();
            emailTextBox.SendKeys("test123@gmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            signUpButton.Click();
        }

        public void IsSignupSuccessful()
        {
            var expectedAlertText = "Form Submitted Successfully...";
            var alert_win = driver.SwitchTo().Alert();

            Assert.AreEqual(expectedAlertText, alert_win.Text);
            alert_win.Accept();
        }

        public void IsTitleExists()
        {
            Assert.AreEqual(sapTitle.Enabled, true);
        }

        public void Title()
        {
            Assert.AreEqual("Demo Site", sapTitle.Text);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        public void Select()
        {
            var selectTest = new SelectElement(course);
            selectTest.SelectByValue("sap-abap");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
    }
}
