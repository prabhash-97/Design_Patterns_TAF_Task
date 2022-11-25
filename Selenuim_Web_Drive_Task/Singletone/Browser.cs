using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenuim_Web_Drive_Task.Singletone
{
    public class Browser
    {
        public IWebDriver driver;

        private Browser(IWebDriver driver)
        {
            this.driver = driver;
        }

        private static Browser instance;

        public static string browser { get; private set; }

        public static Browser GetInstance()
        {
            if(instance == null)
            {
                WebDriverFactory webDriverFactory = new WebDriverFactory();
                instance = new Browser(webDriverFactory.CreateInstance("chrome"));
            }
            return instance;
        }
    }
}
