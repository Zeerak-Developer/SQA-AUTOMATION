using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.POM
{
    public class LoginPage
    {
        WebDriver driver;

        #region objects
        By Email = By.XPath("//input[@id='email']");
        By pass = By.XPath("//input[@id='password']");
        By loginButton = By.XPath("//button[@class='btn btn-primary btn-md btn-block waves-effect text-center m-b-20']");
        #endregion
        #region constructor
        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
        }
        #endregion
        #region login
        public void login(String User, String passwd)
        {
            inputPhoneEmail(User);
            inputPassword(passwd);
            clickLogin();
            //Assert.AreEqual(url, driver.Url);
        }
        #endregion
        #region operation-methods
        void inputPhoneEmail(String emailInput)
        {
            type(Email, emailInput);
        }
        void inputPassword(String passInput)
        {
            type(pass, passInput);
        }
        void clickLogin()
        {
            click(loginButton);
        }
        #endregion
        #region common-methods
        IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        void type(By locator, String text)
        {
            IWebElement element = findElement(locator);
            element.Clear();
            removeText(element);
            element.SendKeys(text);
        }
        void removeText(IWebElement element)
        {
            while (element.Text.Length > 0)
            {
                element.SendKeys(Keys.Backspace);
            }
        }
        void click(By locator)
        {
            findElement(locator).Click();
        }
        #endregion
    }
}
