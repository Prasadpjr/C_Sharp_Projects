using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace TestProject_CSharp.SeleniumC_
{
    internal class WindowTabHandle
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
        }

        [Test]
        public void testCase()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement clickLink = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            clickLink.Click();
            List<string> windowHandles = new List<string>(driver.WindowHandles);

            driver.SwitchTo().Window(windowHandles[1]);//new window
            Console.WriteLine(driver.Title);

            driver.SwitchTo().Window(windowHandles[0]);//back to parent window again
            Assert.AreEqual("The Internet", driver.Title);
            Console.WriteLine(driver.Title);
            Thread.Sleep(2000);

            //driver.SwitchTo().DefaultContent(); //This can be used to switch to parent window
            //Thread.Sleep(2000);
        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
