using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Xml;
using NUnit.Framework;

namespace Comm100Login
{
    class Program
    {

        /// <summary>
        /// Debugging code to test objects
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
         /*   XmlDocument document = XMLHelper.LoadXML(@"E:\Comm100\Comm100Login\Comm100Login\Data\AdminDataConfig.xml");
            IWebDriver driver = new ChromeDriver();
            string urlValue = XMLHelper.GetSingleElement(document, "adminData/uiPortal/hostUrl");
            driver.Navigate().GoToUrl(urlValue);
            System.Threading.Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://secure.comm100.com/login.aspx");

            IWebElement idtext = driver.FindElement(By.Id("txtEmail"));
            string UserID = XMLHelper.GetSingleElement(document, "adminData/uiPortal/loginId");
            idtext.SendKeys(UserID);
            System.Threading.Thread.Sleep(200);

            IWebElement Passt = driver.FindElement(By.Id("txtPassword"));
            string LoginPassword = XMLHelper.GetSingleElement(document, "adminData/uiPortal/loginPassword");
            Passt.SendKeys(LoginPassword);
            System.Threading.Thread.Sleep(200);
            IWebElement loginform = driver.FindElement(By.Id("lblLogin"));
            loginform.Submit();
            driver.Manage().Window.Maximize();*/
            

        }
    }
}
