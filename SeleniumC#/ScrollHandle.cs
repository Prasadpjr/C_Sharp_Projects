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
    internal class ScrollHandle
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
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            IWebElement amazonScience = driver.FindElement(By.XPath("//a[normalize-space()='Amazon Science']"));

            // Scroll to the element
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", amazonScience);
            Thread.Sleep(2000);

            // Scroll to the element
            //Actions action = new Actions(driver);
            //action.MoveToElement(amazonScience)
            //    .Click(amazonScience)
            //    .Perform();
            //Thread.Sleep(2000);
        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Close();
        }
    }
}
