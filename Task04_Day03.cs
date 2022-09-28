using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Data;

namespace Task04_Day03_Selenium
{
    [TestClass]
    public class UnitTest1
    {

        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "Login", DataAccessMethod.Sequential)]
        public void xml()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            IWebDriver driver = new ChromeDriver();
            driver.Url = url;
            driver.FindElement(By.Id("email")).SendKeys(username);
            driver.FindElement(By.Id("pass")).SendKeys(password + Keys.Tab);
            
        }
        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "data@csv", "cfile.csv", DataAccessMethod.Sequential)]
        public void ForCsv()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            IWebDriver driver = new ChromeDriver();
            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
        }
    }
}
