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
    internal class AlertHandling
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            //Handling information alert
            IWebElement element =driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));
            element.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            //Handling confirmation alert
            IWebElement element1 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Confirm']"));
            element1.Click();
            IAlert alert1 = driver.SwitchTo().Alert();
            alert.Dismiss();

            //Handling promt alert
            IWebElement element2 = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Prompt']"));
            element2.Click();
            IAlert alert2 = driver.SwitchTo().Alert();
            String text = alert2.Text;
            Console.WriteLine(text);
            Thread.Sleep(2000);
            alert.Dismiss();

        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
