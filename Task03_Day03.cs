using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;


namespace Task03_Day03_Selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/login/";
            driver.FindElement(By.Id("email")).SendKeys("zeerakasif@yahoo.com");
            driver.FindElement(By.Id("pass")).SendKeys("123Malik");
            driver.FindElement(By.Name("Login")).Click();
            Thread.Sleep(1000);
            driver.Close();
        }
    }
}
