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
    internal class DragAndDrop
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
        driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);
        
        IWebElement sourceelmnt= driver.FindElement(By.Id("column-a"));
        IWebElement destelmnt = driver.FindElement(By.Id("column-b"));

            Actions action = new Actions(driver);
            action.DragAndDrop(sourceelmnt, destelmnt).Build().Perform();
            Thread.Sleep(2000);



        }


    [TearDown]
    public void stopBrowser()
    {

        driver.Close();

    }
}
}
