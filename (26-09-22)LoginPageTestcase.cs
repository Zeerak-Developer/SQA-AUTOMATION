using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Final_Project;

namespace Day06.POM
{
    [TestClass]
    public class LoginPageTestcase
    {
        [TestMethod]
        public void Login()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://primezone-pk.com/login";

            LoginPage loginPage = new LoginPage(driver);
            loginPage.login("mzeerak47@email.com", "12345678");
            driver.Navigate().Refresh();
            loginPage.login("mzeerak47@email.com", "12345678");
            //driver.Close();
        }

    }
}

