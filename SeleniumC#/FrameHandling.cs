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
    internal class FrameHandling
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
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement frameElement = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));
            Assert.IsNotNull(frameElement);
            driver.SwitchTo().Frame(frameElement);
            IWebElement radiobutton = driver.FindElement(By.XPath("//label[normalize-space()='New York']"));
            radiobutton.Click();
            Thread.Sleep(2000);

            //we can try  driver.SwitchTo().Frame(0); based on index
            //we can try  driver.SwitchTo().Frame(id); based on id
            //we can try  driver.SwitchTo().Frame(name); based on name or xpath
        }


        [TearDown]
    public void stopBrowser()
    {

        driver.Close();

    }
}
}
