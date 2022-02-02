using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoDemo
{
    class Program2
    {
        public static IWebDriver driver;

        [Test]
        public static void Main2()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",@"C:\\chromedriver_win32\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); 
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/ajax.html");
                  

            //Find the radio button for "No" using the ID and click on it
            driver.FindElement(By.Id("no")).Click();

            //Clic on check button
            driver.FindElement(By.Id("buttoncheck")).Click();
            
            driver.Close();
            
        }
    }
}
