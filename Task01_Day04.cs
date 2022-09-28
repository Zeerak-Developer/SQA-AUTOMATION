using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

namespace XPath_Assignment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = " https://adactinhotelapp.com/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='login_form']/table/tbody/tr[7]/td/a")).Click();
            driver.FindElement(By.Id("username")).SendKeys("zeerak123");
            driver.FindElement(By.Name("password")).SendKeys("123malik");
            driver.FindElement(By.Name("re_password")).SendKeys("123malik");
            driver.FindElement(By.Name("full_name")).SendKeys("Zeerak Asif");
            driver.FindElement(By.Id("email_add")).SendKeys("mzeerak47@gmail.com");
            Thread.Sleep(10000);
            driver.FindElement(By.Id("captcha-form"));
            driver.FindElement(By.Id("tnc_box")).Click();
            driver.FindElement(By.Id("Submit")).Click();
            driver.FindElement(By.XPath("//a[@href='index.php']")).Click();
            Thread.Sleep(10000);
           // driver.FindElement(By.Id("tnc_box")).Click();
            driver.Close();
        }
        [DoNotParallelize]
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("zeerak123");
            driver.FindElement(By.Id("password")).SendKeys("123malik");
            driver.FindElement(By.Id("login")).Click();
            driver.Close();
        }
    }
}
