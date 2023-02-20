using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using System;
using System.Configuration;
using System.Xml.Linq;

namespace SeleniumUITest.Tests
{
    [TestClass]
    public class LoginTest  : BaseClass
    {
        HomePage homePage;
        LoginPage loginPage;
        [TestCategory("Smoke")]      
        [TestMethod]
         public void VerifyLoginFunctionalityWithValidData()
        {
            string username = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            NUnit.Framework.Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(username);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginBUtton();
        }
    }
}
