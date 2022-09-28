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
        [DoNotParallelize]
        [Priority(2)]
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com/index.php";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='categories_block_left']/div/ul/li[3]/a")).Click();
            driver.FindElement(By.Id("layered_id_attribute_group_2")).Click();
            driver.FindElement(By.Id("layered_id_attribute_group_14")).Click();
            //driver.FindElement(By.Id("enabled_filters")).Click();
            driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[1]/div/a[1]/img")).Click();
            driver.FindElement(By.XPath("//*[@id='thumb_13']")).Click();
            
            Thread.Sleep(100000);
            driver.Close();
        }

        [Priority(1)]
        [TestMethod]
        public void Contact_US()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com/index.php";
            //driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("contact-link")).Click();
            driver.FindElement(By.XPath("//*[@id='id_contact']")).Click();
            driver.FindElement(By.XPath("//*[@id='id_contact']/option[2]")).Click();
            driver.FindElement(By.Id("email")).SendKeys("mzeerak47@gmail.com");
            driver.FindElement(By.Id("id_order")).SendKeys("12345");
            driver.FindElement(By.Id("message")).SendKeys("Kindly confirm my order");
            driver.FindElement(By.XPath("//*[@id='submitMessage']/span")).Click();
            Thread.Sleep(10000);
            driver.Close();
        }
    }
}