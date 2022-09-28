using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Task02_Day07
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GetElementState()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            var element = driver.FindElement(By.Id("password"));
            //var element = driver.FindElement(By.Id("login"));
            //var element = driver.FindElement(By.Id(""));

            string elementState = element.GetAttribute("Disabled");

            if (elementState == null)
            {
                elementState = "enabled";
            }
            else if (elementState == "true")
            {
                elementState = "disabled";
            }
            Thread.Sleep(2000);
            Console.WriteLine(elementState);
            driver.Close();
        }

    }
}
