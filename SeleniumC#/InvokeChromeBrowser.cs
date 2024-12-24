using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace TestProject_CSharp.SeleniumC_
{
    [Allure.NUnit.AllureNUnit]
    internal class InvokeChromeBrowser
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        [Test, Category("Regression")]
        public void testCase()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            String title = driver.Title;
            Console.WriteLine("Title of the page is " + title);

            String url = driver.Url;
            Console.WriteLine("URL of the page is " + url);

            String pagesource = driver.PageSource;
            Console.WriteLine("Page source of the page is " + pagesource);
        }


        [TearDown]
        public void stopBrowser()
        {

            driver.Close();

        }
    }
}
