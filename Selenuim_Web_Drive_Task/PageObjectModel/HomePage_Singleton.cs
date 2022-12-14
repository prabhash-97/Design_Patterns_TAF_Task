using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Selenuim_Web_Drive_Task.Singletone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenuim_Web_Drive_Task.PageObjectModel
{
    public class HomePage_Singleton
    {
        string testUrl = "http://demo.guru99.com/test/guru99home/";

        private IWebDriver driver;
        private WebDriverWait wait;
 
        private IWebElement sapTitle => Browser.GetInstance().driver.FindElement(By.XPath("//*[@id=\"site-name\"]/a"));

        public void GoToPage()
        {
            Browser.GetInstance().driver.Navigate().GoToUrl(testUrl);
            Browser.GetInstance().driver.Manage().Window.Maximize();
        }

        public void IsTitleExists()
        {
            Assert.AreEqual(sapTitle.Enabled, true);
        }

        public void Title()
        {
            Assert.AreEqual("Demo Site", sapTitle.Text);
        }
    }
}
