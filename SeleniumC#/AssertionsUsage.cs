using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject_CSharp.SeleniumC_
{
    internal class AssertionsUsage
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
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//input[@placeholder='Username']")).SendKeys("Admin");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("admin123");
            Thread.Sleep(2000);
            driver.FindElement(By.TagName("button")).Click();
            Thread.Sleep(10000);
            IWebElement textInPage = driver.FindElement(By.XPath("//p[normalize-space()='Time at Work']"));

            // Displayed validation
            if (textInPage.Displayed)
            {
                Console.WriteLine("User is on the home page");
            }
            else
            {

                Console.WriteLine("User is not on the home page");
            }
            // Assertion class valdiation
            string actualtext = textInPage.Text;
            string expectedvalue = "Time at Work";
            Assert.AreEqual(actualtext, expectedvalue);
        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
