using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using SeleniumUITest.WebDriverExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITest.Pages
{
    public class RegisterPage 
    {
        // WebDriver instance
        public static IWebDriver driver;
        // Constructor
        public RegisterPage(IWebDriver driver) {
            RegisterPage.driver = driver;
        }

        public String getTitle()
        {
            return driver.Title;
        }

        /* Page objects
         */

        public static readonly By genderMale = By.Id("gender-male");
        public static readonly By firstname = By.Id("FirstName");
        public static readonly By lastname = By.Id("LastName");
        public static readonly By emailaddress = By.Id("Email");
        public static readonly By password = By.Name("Password");
        public static readonly By confirmpassword = By.Id("ConfirmPassword");
        public static readonly By registerbutton = By.Id("register-button");
        public static readonly By result = By.ClassName("result");
        public static readonly By logout = By.ClassName("ico-logout");

        public readonly string genderMalenm = "Male Radio";
        public readonly string fnamenm = "FirstName";
        public readonly string lnamenm = "LastName";
        public readonly string emailnm = "Email Address";
        public readonly string passnm = "Password";
        public readonly string confirmpassnm = "Password";
        public readonly string registerbtnnm = "Register Button";
        public readonly string logoutnm = "Logout Button";
        /* Page Methods
         */

        /// <summary>
        /// Click on Gender Male Radio  button
        /// </summary>
        public void SelectMaleRadio() {
            driver.Click(genderMale, genderMalenm);
        }
        /// <summary>
        /// Enter the Firstname
        /// </summary>
        public void EnterFirstName(String value)
        {

            driver.EnterText(firstname,value,fnamenm);
        }

        /// <summary>
        /// Enter the Lastname
        /// </summary>
        public void EnterLastName(String value)
        {
            driver.EnterText(lastname, value, lnamenm);
        }
        /// <summary>
        /// Enter the Email
        /// </summary>
    public void EnterEmail(String value) {
            driver.EnterText(emailaddress,value, emailnm);
        }

        /// <summary>
        /// Enter the Password
        /// </summary>
        public void EnterPassword(String pass) 
        {
            driver.EnterText(password,pass, passnm);
        }
        /// <summary>
        /// Enter the Confirm Pass
        /// </summary>

        public void EnterConfirmPassword(String pass)
        {
            driver.EnterText(confirmpassword, pass, confirmpassnm);
        }

        /// <summary>
        /// Click register button
        /// </summary>
        /// 
        public void ClickRegisterbtn()
        {
            driver.Click(registerbutton, registerbtnnm);
        }

        public String GetSuccessfullMesasge()
        {
           return driver.getText(result);
        }

        public bool IsEmailAccountDisplayed(String email)
        {
            return driver.getTextWithValueDisplayed(email);
        }

        public void clickLogout()
        {
            driver.Click(logout, logoutnm);
        }
    }
}
