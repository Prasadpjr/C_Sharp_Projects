using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Configuration;
using System.Xml.Linq;


namespace TestProject_CSharp.Utilities
{
    public class Base //made it as public for access in other classes
    {
        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            String name = ConfigurationManager.AppSettings["browser"];   // we need to add package System.Configuration.ConfigurationManager

            string browser = ConfigurationManager.AppSettings["browser"];
            string aut = ConfigurationManager.AppSettings["aut"];
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];

            Console.WriteLine($"Browser: {browser}");
            Console.WriteLine($"AUT: {aut}");
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            //if (name == "Chrome")
            //{
            //    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //    driver = new ChromeDriver();
            //}
            //else (name == "Edge")
            //{
            //    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //    driver = new EdgeDriver();
            //}
            //else
            //{
            //    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //    driver = new FirefoxDriver();
            //}
        }

        
        [Test]
        public void testCase()
        {
            //driver.Navigate().GoToUrl("https://www.facebook.com/");
            //driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            // Ensure you use the exact key names from App.config (case-sensitive)
            string browser = ConfigurationManager.AppSettings["browser"];
            string aut = ConfigurationManager.AppSettings["aut"];
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];

            // Check if any value is null or empty
            if (string.IsNullOrEmpty(browser) || string.IsNullOrEmpty(aut) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Warning: Configuration values are missing.");
            }

            // Output the values to the console
            Console.WriteLine("Browser: " + browser);
            Console.WriteLine("AUT: " + aut);
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);

            // Example logic based on the config values
            if (browser == "Chrome")
            {
                Console.WriteLine("Setting up Chrome WebDriver...");
                // Add your WebDriver setup code here
            }

            // Use the URL for navigation
            Console.WriteLine("Using AUT: " + aut);
        }


        [TearDown]
        public void stopBrowser()
        {
            //if (driver != null)
            //{
            //    driver.Quit();
            //}
            //driver.Dispose();
        }
    }
}
