using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SeleniumUITest.BasePage;
using SeleniumUITest.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace SeleniumUITest
{
    /// <summary>
    /// Summary description for ReadJsonData
    /// </summary>
    [TestClass]
    public class ReadJsonData
    {


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ReadJsonDataMultipleObjects()
        {
            RegisterList userdata = JsonConvert.DeserializeObject<RegisterList>(File.ReadAllText(@"C:\Users\Slgadmin\source\repos\SeleniumUITest\SeleniumUITest\TestData\RegisterData.json"));

            for (int i = 0; i < userdata.Register.Count; i++)
            {
                string fname = userdata.Register[i].FirstName.ToString();
                string lname = userdata.Register[i].LastName.ToString();
                string email = userdata.Register[i].Email.ToString();
                string password = userdata.Register[i].Password.ToString();
                Console.WriteLine("================================");
                Console.WriteLine(fname +" - " + lname +" - "+email +" - "+password);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {

            //string readdatafromjson = File.ReadAllText(@"C:\Users\Slgadmin\source\repos\SeleniumUITest\SeleniumUITest\TestData\userdata.json");
            //var registerData = JsonSerializer.Deserialize<RegisterDataModel>(readdatafromjson);

            //Console.WriteLine(registerData.FirstName);
            //Console.WriteLine(registerData.LastName);
            //Console.WriteLine(registerData.Email);
            //Console.WriteLine(registerData.Password);

            //String title = driver.Title;
            //Assert.AreEqual(title, "Demo Web Shop");
            //// Click on Register link

            //driver.FindElement(By.ClassName("ico-register")).Click();
            //String registerTitle = driver.Title;
            //Assert.AreEqual(registerTitle, "Demo Web Shop. Register");

            //// Select the Male Gender
            //driver.FindElement(By.Id("gender-male")).Click();
            //// Enter firstname
            //driver.FindElement(By.Id("FirstName")).SendKeys(registerData.FirstName);
            //// Enter lastname
            //driver.FindElement(By.Id("LastName")).SendKeys(registerData.LastName);
            //// Enter email
            //driver.FindElement(By.Id("Email")).SendKeys(registerData.Email);
            //// Enter Password
            //driver.FindElement(By.Id("Password")).SendKeys(registerData.Password);
            //// Enter confirm Password
            //driver.FindElement(By.Id("ConfirmPassword")).SendKeys(registerData.Password);
            //// Click on Register button
            //driver.FindElement(By.Id("register-button")).Click();
            // get the successfull text message

        }
    }
}
