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
using OpenQA.Selenium.Support.UI;

namespace TestProject_CSharp.SeleniumC_
{
    internal class Manage_Waits
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
            IWebElement amazonScience = driver.FindElement(By.XPath("//a[normalize-space()='Amazon Science']"));

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);//implicit wait

            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2)); //Explicit wait
            wait.Until(d => amazonScience.Displayed);

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(2)) //Fluent wait
            {
                PollingInterval = TimeSpan.FromMilliseconds(300),
            };
            wait1.IgnoreExceptionTypes(typeof(ElementNotInteractableException));

            wait1.Until(d => {
                amazonScience.SendKeys("Displayed");
                return true;
            });
        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Close();
        }
    }
}
