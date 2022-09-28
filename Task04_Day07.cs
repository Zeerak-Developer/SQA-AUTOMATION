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
    public class UnitTest3
    {
        [TestMethod]
        public void ScrollToElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://automationpractice.com/index.php";
            var element = driver.FindElement(By.XPath("//*[@class='product_img_link']"));

            //Scroll To Element
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(1000);
            var element1 = driver.FindElement(By.XPath("//img[@class='item-img' and @width='381' and @height = '219']"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element1);
        }
    }
}