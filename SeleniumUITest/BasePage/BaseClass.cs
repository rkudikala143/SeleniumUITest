using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SeleniumUITest.BasePage
{
    /*
     *  Intialize the driver - Setup driver
     *  Re-usable methods
     */

    public class BaseClass
    {
        public static IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            string siteurl = ConfigurationManager.AppSettings["Url"];

                // Create an Instance for WebDriver
                driver = new ChromeDriver();
            // Navigate to Site Url
            driver.Navigate().GoToUrl(siteurl);
            // Maximize the Browser Window
            driver.Manage().Window.Maximize();
        }

        
        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
