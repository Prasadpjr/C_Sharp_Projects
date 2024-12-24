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
    internal class SwagLabslogin
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys("standard_user");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("secret_sauce");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='login-button']")).Click();
            Thread.Sleep(2000);
        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
