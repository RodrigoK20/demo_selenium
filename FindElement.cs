using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace AutoDemo
{
    class FindElement
    {
        public static IWebDriver driver;

        [Test]
        public static void FindElem()
        {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\\chromedriver_win32\\chromedriver.exe");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/ajax.html");

            IList<IWebElement> elements = driver.FindElements(By.Name("name"));

            Console.WriteLine("Number of elements:" + elements.Count());

            int cantidadValores = elements.Count();

            foreach (IWebElement option in elements)
            {
                Console.WriteLine("Valor:" + option.GetAttribute("value"));
            }
            
           
            driver.Close();
        }
    }
}
