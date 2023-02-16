using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.WebDriverExtensions
{
  
    public static class WebDriverExtension 
    {
        
        public static ExtentHtmlReporter htmlreporter;
        public static ExtentReports extent;
        public static ExtentTest test;
        static string reporterPath = System.IO.Directory.GetParent(@"C:\Users\Slgadmin\Source\Repos\SeleniumUITest\SeleniumUITest\").FullName
            + Path.DirectorySeparatorChar + "Result" +
            Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMYYYY");
        [OneTimeSetUp]
        public static void Init()
        {
            htmlreporter = new ExtentHtmlReporter(reporterPath);
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reporterPath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
            string extensionConfiguration = @"C:\Users\Slgadmin\Source\Repos\SeleniumUITest\SeleniumUITest\\extent-config.xml";
            htmlreport.LoadConfig(extensionConfiguration);
        }

        [TearDown]
        public static void TearDown(this IWebDriver driver)
        {
            extent.Flush();
            driver.Close();
            driver.Quit();
        }

        // Common methods or Re-usable methods for page

        /// <summary>
        /// Enter the text in textboxes / Edit boxes
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebDriver driver,By locator, string value, string name)
        {
            IWebElement ele = driver.FindElement(locator);
            if (ele.Displayed && ele.Enabled) {
            
                ele.Clear();
                ele.SendKeys(value);
            }

        }
        /// <summary>
        /// Click the buttton, radio button, Checkboxes
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        public static void Click(this IWebDriver driver, By locator, string name)
        {
            IWebElement ele = driver.FindElement(locator);
            if(ele.Displayed && ele.Enabled)
            {
                ele.Click();
            }

        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator)
        {
            IWebElement ele = driver.FindElement(locator);
            if(ele.Displayed)
            {
                return true;
            }
            return true;
        }

        /// <summary>
        /// Get text of WebElement
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static string getText(this IWebDriver driver, By locator) {
        
            IWebElement ele = driver.FindElement(locator);
            var text="";
            if (ele.Displayed)
            {
                text = ele.Text;
            }
            return text;
        }

        /// <summary>
        /// Element Text displayed
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool getTextWithValueDisplayed(this IWebDriver driver, string value)
        {
            
            IWebElement ele = driver.FindElement(By.XPath("//*[text()='" + value + "']"));
            if (ele.Displayed)
            {
                return true;
            }

            return true;
        }

        public static void IsAlertPresent()
        {

        }

        public static void SelectByVisibleTextFromDropDown()
        {

        }
    }
}
