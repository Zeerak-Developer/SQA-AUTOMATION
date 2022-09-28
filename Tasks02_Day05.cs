using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Task02.Day05.Selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://fs2.formsite.com/meherpavan/form2/index.html?1537702596407";
            driver.Manage().Window.Maximize();
            IWebElement fname = driver.FindElement(By.Id("RESULT_TextField-1"));
            fname.SendKeys("Zeerak");
            IWebElement lname = driver.FindElement(By.Id("RESULT_TextField-2"));
            lname.SendKeys("Asif");
            IWebElement phone = driver.FindElement(By.Id("RESULT_TextField-3"));
            phone.SendKeys("03081611668");
            IWebElement country = driver.FindElement(By.Id("RESULT_TextField-4"));
            country.SendKeys("Pakistan");
            IWebElement city = driver.FindElement(By.Id("RESULT_TextField-5"));
            city.SendKeys("Lahore");
            IWebElement email = driver.FindElement(By.Id("RESULT_TextField-6"));
            email.SendKeys("mzeerak47@gmail.com");
            IWebElement male = driver.FindElement(By.XPath("//*[@id='q26']/table/tbody/tr[1]/td/label"));
            male.Click();
            //Actions actions = new Actions(driver);
            IWebElement chk1 = driver.FindElement(By.XPath("//*[@id='q15']/table/tbody/tr[1]/td/label"));
            chk1.Click();
            IWebElement chk2 = driver.FindElement(By.XPath("//*[@id='q15']/table/tbody/tr[2]/td/label"));
            chk2.Click();
            IWebElement chk3 = driver.FindElement(By.XPath("//*[@id='q15']/table/tbody/tr[3]/td/label"));
            chk3.Click();
            IWebElement chk4 = driver.FindElement(By.XPath("//*[@id='q15']/table/tbody/tr[4]/td/label"));
            chk4.Click();
            IWebElement chk6 = driver.FindElement(By.XPath("//*[@id='q15']/table/tbody/tr[6]/td/label"));
            chk6.Click();
            //IWebElement chk7 = driver.FindElement(By.XPath("//*[@id='q15']/table/tbody/tr[7]/td/label"));
            //chk7.Click();
            var dropdown = new SelectElement(driver.FindElement(By.Name("RESULT_RadioButton-9")));
            Thread.Sleep(100);
            //var selectdropdown = new SelectElement(dropdown);
            dropdown.SelectByValue("Radio-0");
            Thread.Sleep(1000);
            IWebElement submit = driver.FindElement(By.Id("FSsubmit"));
            submit.Click();

            Thread.Sleep(10000);
            driver.Close();
        }
    }
}
