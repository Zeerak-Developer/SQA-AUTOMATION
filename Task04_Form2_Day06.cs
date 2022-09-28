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
    public class UnitTest2
    {
        [TestMethod]
        public void Chrome()
        {
            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("start-maximized");
            //Options.AddArguments("headless");
            Options.AddArguments("incognito");
            IWebDriver driver = new ChromeDriver(Options);
            driver.Url = "https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm";
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            IWebElement fname = driver.FindElement(By.Name("firstname"));
            fname.SendKeys("Zeerak");
            IWebElement lname = driver.FindElement(By.Name("lastname"));
            lname.SendKeys("Asif");
            Thread.Sleep(1000);
            IWebElement male = driver.FindElement(By.XPath("//input[@value='Male']"));
            male.Click();
            IWebElement exp = driver.FindElement(By.XPath("//input[@value='1']"));
            exp.Click();
            IWebElement date = driver.FindElement(By.XPath("//*[@id='mainContent']/div[6]/div/form/table/tbody/tr[5]/td[2]/input"));
            date.SendKeys("23/01/1998");
            IWebElement chk1 = driver.FindElement(By.XPath("//input[@value= 'Manual Tester']"));
            chk1.Click();
            IWebElement chk2 = driver.FindElement(By.XPath("//input[@value= 'Automation Tester']"));
            chk2.Click();
            Thread.Sleep(1000);
            //IWebElement chk3 = driver.FindElement(By.XPath("//input[@value= 'RC']']"));
            //chk3.Click();
            IWebElement chk4 = driver.FindElement(By.XPath("//input[@value= 'Selenium IDE']"));
            chk4.Click();
            IWebElement chk5 = driver.FindElement(By.XPath("//input[@value= 'Selenium Webdriver']"));
            chk5.Click();
            var dropdown = new SelectElement(driver.FindElement(By.XPath("//select[@name='continents']")));
            Thread.Sleep(100);
            dropdown.SelectByIndex(3);
            var dropdown1 = new SelectElement(driver.FindElement(By.XPath("//select[@name='selenium_commands']")));
            Thread.Sleep(100);
            dropdown1.SelectByIndex(0);
            IWebElement submit = driver.FindElement(By.Name("submit"));
            submit.Click();

            Thread.Sleep(1000);
            driver.Close();
        }

        [TestMethod]
        public void Firefox()
        {
            FirefoxOptions Options = new FirefoxOptions();
            //Options.AddArguments("start-maximized");
            //Options.AddArguments("headless");
            Options.AddArguments("new private window");
            IWebDriver driver = new FirefoxDriver(Options);
            driver.Url = "https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm";
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            IWebElement fname = driver.FindElement(By.Name("firstname"));
            fname.SendKeys("Zeerak");
            IWebElement lname = driver.FindElement(By.Name("lastname"));
            lname.SendKeys("Asif");
            Thread.Sleep(1000);
            IWebElement male = driver.FindElement(By.XPath("//input[@value='Male']"));
            male.Click();
            IWebElement exp = driver.FindElement(By.XPath("//input[@value='1']"));
            exp.Click();
            IWebElement date = driver.FindElement(By.XPath("//*[@id='mainContent']/div[6]/div/form/table/tbody/tr[5]/td[2]/input"));
            date.SendKeys("23/01/1998");
            IWebElement chk1 = driver.FindElement(By.XPath("//input[@value= 'Manual Tester']"));
            chk1.Click();
            IWebElement chk2 = driver.FindElement(By.XPath("//input[@value= 'Automation Tester']"));
            chk2.Click();
            Thread.Sleep(1000);
            //IWebElement chk3 = driver.FindElement(By.XPath("//input[@value= 'RC']']"));
            //chk3.Click();
            IWebElement chk4 = driver.FindElement(By.XPath("//input[@value= 'Selenium IDE']"));
            chk4.Click();
            IWebElement chk5 = driver.FindElement(By.XPath("//input[@value= 'Selenium Webdriver']"));
            chk5.Click();
            var dropdown = new SelectElement(driver.FindElement(By.XPath("//select[@name='continents']")));
            Thread.Sleep(100);
            dropdown.SelectByIndex(3);
            var dropdown1 = new SelectElement(driver.FindElement(By.XPath("//select[@name='selenium_commands']")));
            Thread.Sleep(100);
            dropdown1.SelectByIndex(0);
            IWebElement submit = driver.FindElement(By.Name("submit"));
            submit.Click();

            Thread.Sleep(1000);
            driver.Close();
        }

        [TestMethod]
        public void Edge()
        {
            EdgeOptions Options = new EdgeOptions();
            Options.AddArguments("start-maximized");
            //Options.AddArguments("headless");
            Options.AddArguments("incognito");
            IWebDriver driver = new EdgeDriver(Options);
            driver.Url = "https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm";
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            IWebElement fname = driver.FindElement(By.Name("firstname"));
            fname.SendKeys("Zeerak");
            IWebElement lname = driver.FindElement(By.Name("lastname"));
            lname.SendKeys("Asif");
            Thread.Sleep(1000);
            IWebElement male = driver.FindElement(By.XPath("//input[@value='Male']"));
            male.Click();
            IWebElement exp = driver.FindElement(By.XPath("//input[@value='1']"));
            exp.Click();
            IWebElement date = driver.FindElement(By.XPath("//*[@id='mainContent']/div[6]/div/form/table/tbody/tr[5]/td[2]/input"));
            date.SendKeys("23/01/1998");
            IWebElement chk1 = driver.FindElement(By.XPath("//input[@value= 'Manual Tester']"));
            chk1.Click();
            IWebElement chk2 = driver.FindElement(By.XPath("//input[@value= 'Automation Tester']"));
            chk2.Click();
            Thread.Sleep(1000);
            //IWebElement chk3 = driver.FindElement(By.XPath("//input[@value= 'RC']']"));
            //chk3.Click();
            IWebElement chk4 = driver.FindElement(By.XPath("//input[@value= 'Selenium IDE']"));
            chk4.Click();
            IWebElement chk5 = driver.FindElement(By.XPath("//input[@value= 'Selenium Webdriver']"));
            chk5.Click();
            var dropdown = new SelectElement(driver.FindElement(By.XPath("//select[@name='continents']")));
            Thread.Sleep(100);
            dropdown.SelectByIndex(3);
            var dropdown1 = new SelectElement(driver.FindElement(By.XPath("//select[@name='selenium_commands']")));
            Thread.Sleep(100);
            dropdown1.SelectByIndex(0);
            IWebElement submit = driver.FindElement(By.Name("submit"));
            submit.Click();

            Thread.Sleep(1000);
            driver.Close();
        }
    }
}

