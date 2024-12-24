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
    internal class Screenshot_Test
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            
            Screenshot obj =driver.TakeScreenshot();
            obj.SaveAsFile("C:\\Users\\ppooj\\Desktop\\testfile\\screenshot.png");
        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Close();
        }
    }
}
