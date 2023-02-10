using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumUITest.BasePage;
using SeleniumUITest.Pages;
using System;
using System.Configuration;

namespace SeleniumUITest.Tests
{
    [TestClass]
    public class RegisterTest  : BaseClass
    {
        String email = "rkudikala3908973@yahoo.com";
        public HomePage homePage;
        public RegisterPage registerPage;
        [TestCategory("Smoke")]
        [TestMethod]
        public void VerifyRegisterFucntionalityWithValidData()
        {
      
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Ramesh");
            registerPage.EnterLastName("Kudikala");
            registerPage.EnterEmail(email);
            registerPage.EnterPassword("password");
            registerPage.EnterConfirmPassword("password");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMesasge();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed(email);
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void VerifyAppLogoDisplayed()
        {

        }
    }
}
