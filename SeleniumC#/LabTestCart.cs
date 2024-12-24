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
    internal class LAbTestCart
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@id='user-name']")).SendKeys("standard_user");
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("secret_sauce");
            driver.FindElement(By.XPath("//input[@id='login-button']")).Click();
            Thread.Sleep(2000);
           
            IReadOnlyList<IWebElement> elements = driver.FindElements(By.XPath("//button[@class='btn_primary btn_inventory']"));
            elements[0].Click();         
            elements[2].Click();
            driver.FindElement(By.XPath("//*[name()='path' and contains(@fill,'currentCol')]")).Click();
            String text = driver.FindElement(By.XPath("//div[normalize-space()='Sauce Labs Backpack']")).Text;
            Console.WriteLine(text);
            Assert.AreEqual(text, "Sauce Labs Backpack");
            String text1 = driver.FindElement(By.XPath("//div[normalize-space()='Sauce Labs Bolt T-Shirt']")).Text;
            Console.WriteLine(text1);
            Assert.AreEqual(text1, "Sauce Labs Bolt T-Shirt");
            driver.FindElement(By.XPath("//a[normalize-space()='CHECKOUT']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='first-name']")).SendKeys("Prasad");
            driver.FindElement(By.XPath("(//input[@id='last-name'])[1]")).SendKeys("poojary");
            driver.FindElement(By.XPath("(//input[@id='postal-code'])[1]")).SendKeys("123456");
            driver.FindElement(By.XPath("//input[@value='CONTINUE']")).Click();
            Thread.Sleep(2000);
            String text2 = driver.FindElement(By.XPath("//div[normalize-space()='Sauce Labs Backpack']")).Text;
            Console.WriteLine(text2);
            Assert.AreEqual(text2, "Sauce Labs Backpack");
            String text3 = driver.FindElement(By.XPath("//div[normalize-space()='Sauce Labs Bolt T-Shirt']")).Text;
            Console.WriteLine(text3);
            Assert.AreEqual(text3, "Sauce Labs Bolt T-Shirt");
            driver.FindElement(By.XPath("//a[normalize-space()='FINISH']")).Click();
            Thread.Sleep(2000);
            String text4 = driver.FindElement(By.XPath("//h2[normalize-space()='THANK YOU FOR YOUR ORDER']")).Text;
            Console.WriteLine(text4);
            Assert.AreEqual(text4, "THANK YOU FOR YOUR ORDER");
            Thread.Sleep(2000);
        }


    [TearDown]
    public void stopBrowser()
    {

        driver.Close();

    }
}
}
