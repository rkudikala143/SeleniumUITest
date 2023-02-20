using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using SeleniumUITest.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumUITest
{
    /// <summary>
    /// Summary description for RegisterTestWithMultipleData
    /// </summary>
    [TestClass]
    public class RegisterTestWithMultipleData :BaseClass
    {
       
        [TestMethod]
        public void TestMethod1()
        {
            RegisterList userdata = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"C:\Users\Slgadmin\source\repos\SeleniumUITest\SeleniumUITest\TestData\RegisterData.json"));

            for (int i = 0; i < userdata.Register.Count; i++)
            {
                string fname = userdata.Register[i].FirstName.ToString();
                string lname = userdata.Register[i].LastName.ToString();
                string email = userdata.Register[i].Email.ToString();
                string password = userdata.Register[i].Password.ToString();

               // Click on Register link

                driver.FindElement(By.ClassName("ico-register")).Click();
                String registerTitle = driver.Title;
                Assert.AreEqual(registerTitle, "Demo Web Shop. Register");

                // Select the Male Gender
                driver.FindElement(By.Id("gender-male")).Click();
                // Enter firstname
                driver.FindElement(By.Id("FirstName")).SendKeys(fname);
                // Enter lastname
                driver.FindElement(By.Id("LastName")).SendKeys(lname);
                // Enter email
                driver.FindElement(By.Id("Email")).SendKeys(email);
                // Enter Password
                driver.FindElement(By.Id("Password")).SendKeys(password);
                // Enter confirm Password
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys(password);
                // Click on Register button
                driver.FindElement(By.Id("register-button")).Click();
                // get the successfull text message

                String message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");

                // Log out
                driver.FindElement(By.ClassName("ico-logout")).Click();
            }
        }
    }
}
