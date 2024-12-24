using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestProject_CSharp.SeleniumC_
{
    [Allure.NUnit.AllureNUnit]
    internal class File_Download
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement file = driver.FindElement(By.XPath("//a[normalize-space()='SomeFile.txt']"));
            file.Click();
            Thread.Sleep(2000);
            FileInfo fileinlocal = new FileInfo("C:\\Users\\ppooj\\Downloads\\SomeFile.txt");
            
            if (fileinlocal.Exists)
            {
                Console.WriteLine("File downloaded successfully");
            }
            else
            {
                Console.WriteLine("File not downloaded successfully");
            }
            fileinlocal.Delete();
        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Close();
        }
    }
}
