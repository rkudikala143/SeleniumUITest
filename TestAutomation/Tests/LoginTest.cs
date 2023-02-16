using NUnit.Framework;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using System;
using System.Configuration;

namespace SeleniumUITest.Tests
{

    public class LoginTest  : BaseClass
    {
        HomePage homePage;
        LoginPage loginPage;
        [Test]
         public void VerifyLoginFunctionalityWithValidData()
        {
            var username = ConfigurationManager.AppSettings["Email"];
            var password = ConfigurationManager.AppSettings["Password"];
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(username);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginBUtton();
        }
    }
}
