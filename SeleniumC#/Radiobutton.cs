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
    internal class RadioButton
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
            IWebElement radio = driver.FindElement(By.XPath("(//input[@name='radioButton'])[3]"));
            if (radio.Enabled)
            {
                Console.WriteLine("Radio button is Enabled");
                radio.Click();
            }

            //single checkbox selection
            IWebElement checkbox = driver.FindElement(By.XPath("//input[@id='checkBoxOption1']"));
            if (checkbox.Displayed)
            {
                Console.WriteLine("Checkbox is displayed");
                checkbox.Click();
            }
            Thread.Sleep(5000);
        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
