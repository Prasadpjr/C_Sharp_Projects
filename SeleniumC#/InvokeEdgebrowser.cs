using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject_CSharp.SeleniumC_
{
    [Allure.NUnit.AllureNUnit]
    internal class InvokeEdgebrowser
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
        }
        [Test, Category("Regression")]
        public void testCase()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }


        [TearDown]
        public void stopBrowser()
        {
     
          driver.Close();
      
        }

    }
}
