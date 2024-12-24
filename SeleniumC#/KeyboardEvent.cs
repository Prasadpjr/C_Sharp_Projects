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
    internal class KeyboardEvent
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
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement email = driver.FindElement(By.Id("email"));
            IWebElement pass = driver.FindElement(By.Id("pass"));
            Actions action = new Actions(driver);
            action.KeyDown(Keys.Shift)
                .SendKeys("hkhande")
                .Perform();
                 Thread.Sleep(2000);
            action.MoveToElement(pass).Click()
                .SendKeys("12345")
                .Perform();
            Thread.Sleep(2000);

        }


    [TearDown]
    public void stopBrowser()
    {

        driver.Close();

    }
}
}
