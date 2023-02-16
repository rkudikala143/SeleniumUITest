using OpenQA.Selenium;
using SeleniumUITest.WebDriverExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.Pages
{
    public  class LoginPage
    {

        // Instance for Webdriver
        public static IWebDriver driver;

        // constructor

        public LoginPage(IWebDriver driver) {
            LoginPage.driver= driver;
        }

        //* page objects

        public string getTitle()
        {
            return driver.Title;
        }
        public static readonly By emailtxt = By.Id("Email");
        public static readonly By passwordtxt = By.Id("Password");
        public static readonly By loginbtn = By.CssSelector("input.button-1.login-button");


        public readonly string emailnm = "Email Address";
        public readonly string passwordnm = "Password";
        public readonly string loginnm = "Login Button";

        // Page methods

        public void EnterEmailAddress(String email)
        {
            driver.EnterText(emailtxt, email, emailnm);
        }

        public void EnterPassword(String password)
        {
            driver.EnterText(passwordtxt, password, passwordnm);
        }
        public void ClickLoginBUtton()
        {
            driver.Click(loginbtn,loginnm);
        }
    }
}
