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
    public class UnitTest1
    {
        [TestMethod]
        public void GetElementValue()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            driver.FindElement(By.Id("password")).SendKeys("AmirTester");
            driver.FindElement(By.Id("login")).Click();
            var element = driver.FindElement(By.Id("datepick_in"));
            element.GetAttribute("value");
            Thread.Sleep(5000);
            driver.Close();
        }
        [TestMethod]
        public void GetElementText()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            var element = driver.FindElement(By.XPath("//td[@class='login_title']"));
            element.GetAttribute("text");
            Thread.Sleep(5000);
            driver.Close();
        }
        [TestMethod]
        public void GetElementHTML()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            driver.FindElement(By.Id("password")).SendKeys("AmirTester");
            driver.FindElement(By.Id("login")).Click();
            var element = driver.FindElement(By.XPath("//span[@class='login_title_comm']"));
            element.GetAttribute("innerHTML");
            Thread.Sleep(5000);
            driver.Close();
        }

    }
}
