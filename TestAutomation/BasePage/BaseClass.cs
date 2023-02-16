using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using NUnit.Framework;
using SeleniumUITest.WebDriverExtensions;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace SeleniumUITest.BasePage
{
    /*
     *  Intialize the driver - Setup driver
     *  Re-usable methods
     */

    public  class BaseClass 
    {
        public static IWebDriver driver;
        public static ExtentHtmlReporter htmlreporter;
        public static ExtentReports extent;
        public static ExtentTest test;
        static string reporterPath = System.IO.Directory.GetParent(@"C:\Users\Slgadmin\Source\Repos\SeleniumUITest\SeleniumUITest\").FullName
            + Path.DirectorySeparatorChar + "Result" +
            Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMYYYY");
        [SetUp]
        public static void SetUp()
        {
            var siteurl = ConfigurationManager.AppSettings["Url"];
            Console.WriteLine("Url :"+ siteurl);
            // Create an Instance for WebDriver
            driver = new ChromeDriver();
            // Navigate to Site Url
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com");
            // Maximize the Browser Window
            driver.Manage().Window.Maximize();
            htmlreporter = new ExtentHtmlReporter(reporterPath);
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reporterPath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
            string extensionConfiguration = @"C:\Users\Slgadmin\Source\Repos\SeleniumUITest\SeleniumUITest\\extent-config.xml";
            htmlreport.LoadConfig(extensionConfiguration);
        }     

        public void Type(By locator, string value, string name)
        {

            driver.EnterText(locator, value, name);
        }
    }
}
