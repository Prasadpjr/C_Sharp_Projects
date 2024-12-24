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
    [Allure.NUnit.AllureNUnit]
    internal class WebTable_Handle
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
            
            //launch application URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            //Fetch the table
            IWebElement Table = driver.FindElement(By.XPath("//table[@id = 'table1']"));
            //Fetch Rows
            Thread.Sleep(2000);

            List<IWebElement> trRow = new List<IWebElement>(Table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr")));
            int rowcount = trRow.Count();
            Console.WriteLine(rowcount);
            Thread.Sleep(2000);


            List<IWebElement> tdCol = new List<IWebElement>(Table.FindElements(By.XPath("//table[@id = 'table1']/tbody/td")));
            int colCount = tdCol.Count();
            Console.WriteLine(colCount);
            Thread.Sleep(2000);


            //cell data
            IWebElement cellData = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[3]/td[2]"));
            string text = cellData.Text;
            Console.WriteLine(text);
            Assert.AreEqual("Jason", text);
            Thread.Sleep(2000);
        }

        [TearDown]
        public void stopBrowser()
        {
            driver.Close();
        }
    }
}
