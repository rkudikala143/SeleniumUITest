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


        /* Page Methods
         */

        /// <summary>
        /// Click on Gender Male Radio  button
        /// </summary>
        public void SelectMaleRadio() {
            driver.Click(genderMale);
        }
        /// <summary>
        /// Enter the Firstname
        /// </summary>
        public void EnterFirstName(String value)
        {
            driver.EnterText(firstname,value);
        }

        /// <summary>
        /// Enter the Lastname
        /// </summary>
        public void EnterLastName(String value)
        {
           driver.EnterText(lastname,value);
        }

        /// <summary>
        /// Enter the Email
        /// </summary>
    public void EnterEmail(String value) {
            driver.EnterText(emailaddress,value);
        }

        /// <summary>
        /// Enter the Password
        /// </summary>
        public void EnterPassword(String pass) 
        {
            driver.EnterText(password,pass);
        }
        /// <summary>
        /// Enter the Confirm Pass
        /// </summary>

        public void EnterConfirmPassword(String pass)
        {
            driver.EnterText(confirmpassword, pass);
        }

        /// <summary>
        /// Click register button
        /// </summary>
        /// 
        public void ClickRegisterbtn()
        {
            driver.Click(registerbutton);
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
            driver.Click(logout);
        }
    }
}
