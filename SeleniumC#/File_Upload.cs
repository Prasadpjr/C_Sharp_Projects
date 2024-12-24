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
    internal class File_Upload
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement file = driver.FindElement(By.XPath("//input[@id='file-upload']"));
            file.SendKeys("C:\\Users\\ppooj\\Desktop\\testfile\\test.docx");
            IWebElement upload = driver.FindElement(By.XPath("//input[@id='file-submit']"));
            upload.Click();
            Thread.Sleep(2000);
            IWebElement uploadedfile = driver.FindElement(By.XPath("//h3[normalize-space()='File Uploaded!']"));
           
            if(uploadedfile.Text== "File Uploaded!")
            {
                Console.WriteLine("File uploaded successfully");
            }
            else
            {
                Console.WriteLine("File not uploaded successfully");
            }
        }


        [TearDown]
    public void stopBrowser()
    {

        driver.Close();

    }
}
}
