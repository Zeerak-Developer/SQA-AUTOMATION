using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
namespace Assignment_9
{
    [TestClass]
    public class Assignment_9
    {

        //Task 1
        [TestMethod]
        public void Allwaits()
        {

            IWebDriver driver = new ChromeDriver();
            //Implicit Wait

            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(200));

            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";


            //default Wait

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);

            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            driver.Close();
        }


        //Task 2
  
        [TestMethod]
        public void Task2()
        {

            //open the website
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();

            var element = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]/div/div[3]"));

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);

            driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]/div/div[3]")).Click();

            driver.FindElement(By.CssSelector("#item-0>span")).Click();

            IWebElement text1 = driver.FindElement(By.Id("userName"));
            text1.SendKeys("Zeerak");
            String att1 = text1.GetAttribute("value");
            Assert.AreEqual("Zeerak", att1);

            IWebElement text2 = driver.FindElement(By.Id("userEmail"));
            text2.SendKeys("mzeerak47@gmail.com");

            String att2 = text2.GetAttribute("value");
            Assert.AreEqual("mzeerak47@gmail.com", att2);

            IWebElement text3 = driver.FindElement(By.Id("currentAddress"));
            text3.SendKeys("Askari Corporate Tower");

            String att3 = text3.GetAttribute("value");
            Assert.AreEqual("Askari Corporate Tower", att3);

            IWebElement text4 = driver.FindElement(By.Id("permanentAddress"));
            text4.SendKeys("Lahore");

            String att4 = text4.GetAttribute("value");
            Assert.AreEqual("Lahore", att4);

            //validate login is enabled
            var element2 = driver.FindElement(By.Id("submit"));

            string elementState = element.GetAttribute("innerHTML");

            if (elementState == null)
            {
                elementState = "enabled";
                Console.WriteLine("Submit button is enabled");
            }
            else if (elementState == "true")
            {
                elementState = "disabled";
                Console.WriteLine("Submit button is disabled");
            }

            Thread.Sleep(2000);
            driver.Close();
        }

        [TestMethod]
        public void max_min_full()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            driver.Manage().Window.Minimize();
            Thread.Sleep(1000);

            driver.Manage().Window.FullScreen();

            Thread.Sleep(2000);
            driver.Close();
        }

        [TestMethod]
        public void Text()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("Zeerak");
            driver.FindElement(By.Id("password")).SendKeys("123Malik");
            IWebElement txt = driver.FindElement(By.LinkText("Forgot Password?"));
            string txt1 = txt.Text;
            Console.WriteLine(txt1);
            Assert.AreEqual("Forgot Password?", txt1);
            Thread.Sleep(2000);
            driver.Close();
        }

        [TestMethod]
        public void enabled()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            driver.FindElement(By.Id("username")).SendKeys("Zeerak");
            driver.FindElement(By.Id("password")).SendKeys("123Malik");
            var a = driver.FindElement(By.Id("login"));
            bool login_enabled = a.Enabled;
            Assert.IsTrue(login_enabled);

            Thread.Sleep(2000);
            driver.Close();
        }

        [TestMethod]
        public void displayed()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";

            driver.FindElement(By.Id("username")).SendKeys("Zeerak");
            driver.FindElement(By.Id("password")).SendKeys("123Malik");
            var a = driver.FindElement(By.Id("login"));
            bool login_displayed = a.Displayed;
            Assert.IsTrue(login_displayed);

            Thread.Sleep(2000);
            driver.Close();
        }
        
    }
}
