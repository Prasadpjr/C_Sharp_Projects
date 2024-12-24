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
    internal class MouseHover_Actions
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
        Thread.Sleep(5000);
        
        IWebElement prime = driver.FindElement(By.Id("nav-link-amazonprime"));
       
            Actions action = new Actions(driver);
            action.MoveToElement(prime).Perform();
            Thread.Sleep(5000);
           



        }


    [TearDown]
    public void stopBrowser()
    {

        driver.Close();

    }
}
}
