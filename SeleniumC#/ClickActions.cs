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
    internal class ClickActions
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
        driver.Navigate().GoToUrl("https://www.amazon.in/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);
        
        IWebElement bestseller = driver.FindElement(By.XPath("//a[@href='/gp/bestsellers/?ref_=nav_cs_bestsellers']"));
        IWebElement todaysdeals = driver.FindElement(By.XPath("//a[@href='/deals?ref_=nav_cs_gb']"));

            Actions action = new Actions(driver);
            action.ContextClick(bestseller).Perform();
            Thread.Sleep(2000);
            action.DoubleClick(todaysdeals).Perform();
            Thread.Sleep(2000);



        }


    [TearDown]
    public void stopBrowser()
    {

        driver.Close();

    }
}
}
