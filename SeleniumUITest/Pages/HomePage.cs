using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using SeleniumUITest.WebDriverExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.Pages
{
    public class HomePage 

    {
        
        // Instance of Webdriver

        public static IWebDriver driver;
                // Create a constructor

        public HomePage(IWebDriver  driver) {
            HomePage.driver = driver;
        }

        public String getTitle()
        {
            return driver.Title;
        }

        /* Page Objects  - for webelements
         */

        private  readonly By registerlink = By.ClassName("ico-register");
        public  readonly By loginlink = By.ClassName("ico-login");

        /// page Methods
        /// 
        public void ClickRegisterLink()
        {
            driver.Click(registerlink);
        }

        public void ClickLoginLink()
        {
            driver.Click(loginlink);
        }

    }
}
