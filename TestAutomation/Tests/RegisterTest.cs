using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V107.Debugger;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using SeleniumUITest.WebDriverExtensions;
using System;
using System.Configuration;
using Assert = NUnit.Framework.Assert;

namespace SeleniumUITest.Tests
{
  
    public class RegisterTest  : BaseClass
    {
        String email = "rikala309933@yahoo.com";
        public HomePage homePage;
        public RegisterPage registerPage;

       
        [Test]
    
        public void VerifyRegisterFucntionalityWithValidData()
        {
      
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            
            //Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
         
            homePage.ClickRegisterLink();

            //Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
       
            registerPage.SelectMaleRadio();
       
            registerPage.EnterFirstName("Ramesh");
        
            registerPage.EnterLastName("Kudikala");
      
            registerPage.EnterEmail(email);
        
            registerPage.EnterPassword("password");
    
            registerPage.EnterConfirmPassword("password");
        
            registerPage.ClickRegisterbtn();
           
            String result = registerPage.GetSuccessfullMesasge();
           
          
            bool isTrue = registerPage.IsEmailAccountDisplayed(email);
            //Assert.IsTrue(isTrue);
         
            registerPage.clickLogout();
            WebDriverExtension.extent.Flush();
            driver.Close();
            driver.Quit();
        }

      
    }
}
