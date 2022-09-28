using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Task03_Day04_Selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            driver.FindElement(By.TagName("html")).SendKeys(Keys.Control + Keys.Subtract);
            driver.FindElement(By.XPath("//h5[contains(text(),'Forms')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]")).Click();
            driver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys("Zeerak");
            driver.FindElement(By.XPath("//input[@id='lastName']")).SendKeys("Asif");
            driver.FindElement(By.XPath("//*[@id='userEmail']")).SendKeys("mzeerak47@gmail.com");
            driver.FindElement(By.XPath("//label[contains(text(),'Male')]")).Click();
            driver.FindElement(By.XPath("//*[@id='userNumber']")).SendKeys("3081611668");
            driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'january')]")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'1998')]")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'23')]")).Click();
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys("Maths");
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//label[text()='Sports']")).Click();
            driver.FindElement(By.XPath("//*[@id='currentAddress']")).SendKeys("usa CHICAGO" + Keys.Tab);
            driver.FindElement(By.XPath("//input[@id='react-select-3-input']")).SendKeys("NCR" + Keys.Tab);

            driver.FindElement(By.XPath("//input[@id='react-select-4-input']")).SendKeys("Delhi" + Keys.Tab);
            driver.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }
    }
}