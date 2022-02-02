using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoDemo
{
    class Form
    {
        public static IWebDriver driver;

        [Test]
        public static void FormLogin()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver",@"C:\\chromedriver_win32\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/login.html");
            

            IWebElement email = driver.FindElement(By.Id("email"));
            IWebElement password = driver.FindElement(By.Id("passwd"));

            email.SendKeys("abcd@gmail.com");
            password.SendKeys("abcdefghlkjl");
            Console.WriteLine("Text Field Set");

            email.Clear();
            password.Clear();
            Console.WriteLine("Text Field Cleared");

            //Submit button
            IWebElement login = driver.FindElement(By.Id("SubmitLogin"));

            //Using click method to submit form
            email.SendKeys("abcd@gmail.com");
            password.SendKeys("abcdefghlkjl");
            login.Click();
            Console.WriteLine("Login done with click");

           // driver.Close();

        }
    }
}
