using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace TestProject_CSharp.SeleniumC_
{
    internal class Dropdownhandling
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

            //radio button selection
            IWebElement dropdown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(dropdown);
            var select = new SelectElement(dropdown);
            //select by visible text
            Thread.Sleep(2000);
            select.SelectByText("Option1");
            //select by index
            Thread.Sleep(2000);
            select.SelectByIndex(2);
            //select by value
            Thread.Sleep(2000);
            select.SelectByValue("option3");//value tag name in html
            Thread.Sleep(2000);


        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
