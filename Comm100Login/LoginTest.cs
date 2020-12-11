using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Xml;
using NUnit.Framework;

namespace Comm100Login
{
    [TestFixture]
    public class LoginTest
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver(); // Launches Browser
            driver.Manage().Window.Maximize(); // Maximizes Browser
         

        }

        /// <summary>
        /// Is a positive unit test case with correct userid and password
        /// </summary>
        [Test]
        public void VerifyValidLogin()
        {

            // Open the url and read the Home page url from XML 
            XmlDocument document = XMLHelper.LoadXML(@"E:\Comm100\Comm100Login\Comm100Login\Data\AdminDataConfig.xml");
            IWebDriver driver = new FirefoxDriver();
            string urlValue = XMLHelper.GetSingleElement(document, "adminData/uiPortal/hostUrl");
            driver.Navigate().GoToUrl(urlValue);
            System.Threading.Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://secure.comm100.com/login.aspx");
            // Enter the User Name
            IWebElement idtext = driver.FindElement(By.Id("txtEmail"));
            string UserID = XMLHelper.GetSingleElement(document, "adminData/uiPortal/loginId");
            idtext.SendKeys(UserID);
            System.Threading.Thread.Sleep(200);

            // Enter the Password
            IWebElement Passt = driver.FindElement(By.Id("txtPassword"));
            string LoginPassword = XMLHelper.GetSingleElement(document, "adminData/uiPortal/loginPassword");
            Passt.SendKeys(LoginPassword);
            System.Threading.Thread.Sleep(200);
            // Click on the Sign in button
            IWebElement loginform = driver.FindElement(By.Id("lblLogin"));
            loginform.Submit();
            System.Threading.Thread.Sleep(9000);
            Assert.AreEqual(true, driver.Url.Contains("siteId"));

            //Assert.AreEqual(driver.FindElement(By.Id("Dashboard"));
        }

        /// <summary>
        /// Is a negative unit test case with valid userid and invalid password
        /// </summary>
        [Test]
        public void VerifyInvalidLogin()
        {
            // Open the url and read the Home page url from XML 
            XmlDocument document = XMLHelper.LoadXML(@"E:\Comm100\Comm100Login\Comm100Login\Data\AdminDataConfig.xml");
            IWebDriver driver = new FirefoxDriver();
            string urlValue = XMLHelper.GetSingleElement(document, "adminData/uiPortal/hostUrl");
            driver.Navigate().GoToUrl(urlValue);
            System.Threading.Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://secure.comm100.com/login.aspx");
            // Enter the User Name
            IWebElement idtext = driver.FindElement(By.Id("txtEmail"));
            string UserID = XMLHelper.GetSingleElement(document, "adminData/uiPortal/loginId");
            idtext.SendKeys(UserID);
            System.Threading.Thread.Sleep(200);

            // Enter the Password
            IWebElement Passt = driver.FindElement(By.Id("txtPassword"));
            string LoginPassword = XMLHelper.GetSingleElement(document, "adminData/uiPortal/invalidPassword");
            Passt.SendKeys(LoginPassword);
            System.Threading.Thread.Sleep(200);
            // Click on the Sign in button
            IWebElement loginform = driver.FindElement(By.Id("lblLogin"));
            loginform.Submit();

            Assert.AreEqual(false, driver.Url.Contains("siteId"));

            //Assert.AreEqual(driver.FindElement(By.Id("Dashboard"));
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
