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
    [Allure.NUnit.AllureNUnit]
    internal class dropdownLabTest
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
        }
        [Test, Category("Regression")]
        public void testCase()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

            //radio button selection
            IWebElement dropdown = driver.FindElement(By.XPath("//select[@id='dropdown']"));
            var select = new SelectElement(dropdown);
            //select by visible text
            Thread.Sleep(2000);
            select.SelectByText("Option 1");
            //select by index
            Thread.Sleep(2000);
            select.SelectByIndex(2);
            Thread.Sleep(2000);
         }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
