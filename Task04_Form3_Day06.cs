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

namespace Task04
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void Chrome()
        {
            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("start-maximized");
            //Options.AddArguments("headless");
            Options.AddArguments("incognito");
            IWebDriver driver = new ChromeDriver(Options);
            driver.Url = "https://www.techlistic.com/p/selenium-practice-form.html";
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            IWebElement fname = driver.FindElement(By.Name("firstname"));
            fname.SendKeys("Zeerak");
            IWebElement lname = driver.FindElement(By.Name("lastname"));
            lname.SendKeys("Asif");
            Thread.Sleep(1000);
            IWebElement male = driver.FindElement(By.Id("sex-0"));
            male.Click();
            IWebElement exp = driver.FindElement(By.Id("exp-0"));
            exp.Click();
            IWebElement date = driver.FindElement(By.Id("datepicker"));
            date.SendKeys("23/01/1998");
            IWebElement chk1 = driver.FindElement(By.Id("profession-0"));
            chk1.Click();
            IWebElement chk2 = driver.FindElement(By.Id("profession-1"));
            chk2.Click();
            Thread.Sleep(1000);

            IWebElement chk3 = driver.FindElement(By.Id("tool-0"));
            chk3.Click();
            IWebElement chk4 = driver.FindElement(By.Id("tool-1"));
            chk4.Click();
            IWebElement chk5 = driver.FindElement(By.Id("tool-2"));
            chk5.Click();

            var dropdown = new SelectElement(driver.FindElement(By.Id("continents")));
            Thread.Sleep(100);
            dropdown.SelectByIndex(2);
            var dropdown1 = new SelectElement(driver.FindElement(By.Id("selenium_commands")));
            dropdown1.SelectByIndex(0);
            Thread.Sleep(1000);
            IWebElement submit = driver.FindElement(By.Id("submit"));
            submit.Click();

            Thread.Sleep(1000);
            driver.Close();
        }

        [TestMethod]
        public void Firefox()
        {
            FirefoxOptions Options = new FirefoxOptions();
            Options.AddArguments("new private window");
            //Options.AddArguments("maximized");
            //Options.AddArguments("headless");
            IWebDriver driver = new FirefoxDriver(Options);
            driver.Url = "https://www.techlistic.com/p/selenium-practice-form.html";
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            IWebElement fname = driver.FindElement(By.Name("firstname"));
            fname.SendKeys("Zeerak");
            IWebElement lname = driver.FindElement(By.Name("lastname"));
            lname.SendKeys("Asif");
            Thread.Sleep(1000);
            IWebElement male = driver.FindElement(By.Id("sex-0"));
            male.Click();
            IWebElement exp = driver.FindElement(By.Id("exp-0"));
            exp.Click();
            IWebElement date = driver.FindElement(By.Id("datepicker"));
            date.SendKeys("23/01/1998");
            IWebElement chk1 = driver.FindElement(By.Id("profession-0"));
            chk1.Click();
            IWebElement chk2 = driver.FindElement(By.Id("profession-1"));
            chk2.Click();
            Thread.Sleep(1000);

            IWebElement chk3 = driver.FindElement(By.Id("tool-0"));
            chk3.Click();
            IWebElement chk4 = driver.FindElement(By.Id("tool-1"));
            chk4.Click();
            IWebElement chk5 = driver.FindElement(By.Id("tool-2"));
            chk5.Click();

            var dropdown = new SelectElement(driver.FindElement(By.Id("continents")));
            Thread.Sleep(100);
            dropdown.SelectByIndex(2);
            var dropdown1 = new SelectElement(driver.FindElement(By.Id("selenium_commands")));
            dropdown1.SelectByIndex(0);
            Thread.Sleep(1000);
            IWebElement submit = driver.FindElement(By.Id("submit"));
            submit.Click();

            Thread.Sleep(1000);
            driver.Close();
        }

        [TestMethod]
        public void Edge()
        {
            EdgeOptions Options = new EdgeOptions();
            Options.AddArguments("start-maximized");
            Options.AddArguments("headless");
            Options.AddArguments("incognito");
            IWebDriver driver = new EdgeDriver(Options);
            driver.Url = "https://www.techlistic.com/p/selenium-practice-form.html";
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            IWebElement fname = driver.FindElement(By.Name("firstname"));
            fname.SendKeys("Zeerak");
            IWebElement lname = driver.FindElement(By.Name("lastname"));
            lname.SendKeys("Asif");
            Thread.Sleep(1000);
            IWebElement male = driver.FindElement(By.Id("sex-0"));
            male.Click();
            IWebElement exp = driver.FindElement(By.Id("exp-0"));
            exp.Click();
            IWebElement date = driver.FindElement(By.Id("datepicker"));
            date.SendKeys("23/01/1998");
            IWebElement chk1 = driver.FindElement(By.Id("profession-0"));
            chk1.Click();
            IWebElement chk2 = driver.FindElement(By.Id("profession-1"));
            chk2.Click();
            Thread.Sleep(1000);

            IWebElement chk3 = driver.FindElement(By.Id("tool-0"));
            chk3.Click();
            IWebElement chk4 = driver.FindElement(By.Id("tool-1"));
            chk4.Click();
            IWebElement chk5 = driver.FindElement(By.Id("tool-2"));
            chk5.Click();

            var dropdown = new SelectElement(driver.FindElement(By.Id("continents")));
            Thread.Sleep(100);
            dropdown.SelectByIndex(2);
            var dropdown1 = new SelectElement(driver.FindElement(By.Id("selenium_commands")));
            dropdown1.SelectByIndex(0);
            Thread.Sleep(1000);
            IWebElement submit = driver.FindElement(By.Id("submit"));
            submit.Click();

            Thread.Sleep(1000);
            driver.Close();
        }
    }
}
