using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using TestProject_CSharp.NunitTests;

namespace TestProject_CSharp.SeleniumC_
{
    [Allure.NUnit.AllureNUnit]
    internal class CheckoxLabTest
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            IWebElement checkbox2 = driver.FindElement(By.XPath("(//input[@type='checkbox'])[2]"));
            if (checkbox2.Selected)
            {
                Console.WriteLine("Checkbox 2 is already selected");
                checkbox2.Click();
            }
            
            IReadOnlyList<IWebElement> checkboxlist = driver.FindElements(By.TagName("input"));
            foreach (IWebElement e in checkboxlist)
            {
               
                e.Click();
                Console.WriteLine("Checkbox "+e+" selected");
                Thread.Sleep(1000);
            }
        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
