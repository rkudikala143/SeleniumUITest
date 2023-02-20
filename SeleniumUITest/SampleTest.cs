using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Cryptography.X509Certificates;

namespace SeleniumUITest
{
    [TestClass]
    public class SampleTest
    {
        String email = "Stepehnrub944@yahoo.com";
        IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            // Create an Instance for WebDriver
            driver = new ChromeDriver();
            // Navigate to Site Url
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            // Maximize the Browser Window
            driver.Manage().Window.Maximize();

        }
        [TestCategory("SampleTest")]
        [TestMethod]
        public void TestMethod1()
        {
            try
            {

                String title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");
                // Click on Register link

                driver.FindElement(By.ClassName("ico-register")).Click();
                String registerTitle = driver.Title;
                Assert.AreEqual(registerTitle, "Demo Web Shop. Register");

                // Select the Male Gender
                driver.FindElement(By.Id("gender-male")).Click();
                // Enter firstname
                driver.FindElement(By.Id("FirstName")).SendKeys("Stephen");
                // Enter lastname
                driver.FindElement(By.Id("LastName")).SendKeys("Ruben");
                // Enter email
                driver.FindElement(By.Id("Email")).SendKeys(email);
                // Enter Password
                driver.FindElement(By.Id("Password")).SendKeys("Password");
                // Enter confirm Password
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Password");
                // Click on Register button
                driver.FindElement(By.Id("register-button")).Click();
                // get the successfull text message

                String message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");

                IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailAccount.Displayed);
                // Log out
                driver.FindElement(By.ClassName("ico-logout")).Click();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            [TestCleanup]
            public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
