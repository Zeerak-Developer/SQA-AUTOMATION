using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System.Threading;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Task01_Day07
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            driver.FindElement(By.Id("password")).SendKeys("AmirTester");
            driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }
        [TestMethod]
        public void Test001()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/browser-windows";
            driver.FindElement(By.Id("tabButton")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string text = driver.FindElement(By.Id("sampleHeading")).Text;
            Console.WriteLine(text);
            Thread.Sleep(5000);
            driver.Quit();
        }
        [TestMethod]
        public void BrowserNavigationCommand()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";

            driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

            driver.Close();
        }
        [TestMethod]
        public void GetElementState()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            var element = driver.FindElement(By.Id("login"));

            string elementState = element.GetAttribute("Disabled");

            if (elementState == null)
            {
                elementState = "enabled";
            }
            else if (elementState == "true")
            {
                elementState = "disabled";
            }
        }
        [TestMethod]
        public void DriverCloseCommand()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.Close();
        }
        [TestMethod]
        public void DriverQuitCommand()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            Thread.Sleep(5000);
            driver.Quit();
        }
        [TestMethod]
        public void DriverDisposeCommand()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            Thread.Sleep(5000);
            driver.Dispose();
        }
        [TestMethod]
        public void TaboutElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            var element = driver.FindElement(By.Id("username"));
            element.SendKeys(Keys.Tab);
            driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(5000);
            driver.Close();
        }
        [TestMethod]
        public void TakeScreenShot()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            // Taking a full-screen screenshot
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\Screenshot.png", ScreenshotImageFormat.Png);
            driver.Close();
        }
    }
}
