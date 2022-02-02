using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoDemo
{
    class Program
    {
        public static IWebDriver driver;

        [Test]
        public static void Main()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",@"C:\\chromedriver_win32\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.sv");

            driver.Close();
        }
    }
}
