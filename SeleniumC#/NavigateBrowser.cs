using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject_CSharp.SeleniumC_
{
    internal class NavigateBrowser
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        [Test]
        public void testCase()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            //navigate back
            driver.Navigate().Back();
            Thread.Sleep(3000);
            //navigate forward
            driver.Navigate().Forward();
            Thread.Sleep(3000);
            //referesh browser
            driver.Navigate().Refresh();
            Thread.Sleep(3000);
        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
