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
    internal class RegularXPathExpressions
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

            //div[@class = 'gstl_50 gstt']
            //div[@class = 'gstl_50 gstt']

            //div[ends-with(@class = 'gstt')]  ---ends with
            //div[starts-with(@class = 'gstl_50')]---starts with
            //div[contains(@class = 'gstl_50')]---contains
            //div[[starts-with(@class = 'gstl_50')] and [ends-with(@class = 'gstt')]]---starts with and ends with
            //div[[starts-with(@class = 'gstl_50')] or [ends-with(@class = 'gstt')]]---starts with or ends with

        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
