//Task01

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SELENIUM_DAY07_ASSIGNMENT08
{
    [TestClass]
 public class Task1
    {
        
      [TestMethod]
      public void ForLogin()
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
        public void WindowHandling()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://demoqa.com/browser-windows";

            driver.FindElement(By.Id("tabButton")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id = 'windowButton']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            //string text = driver.FindElement(By.Id("sampleHeading")).Text;
            //Console.WriteLine(text);
            //Console.WriteLine("Windows Opened By Selenium" + driver.WindowHandles.Count);
            Thread.Sleep(5000);
            driver.Quit();
        }

       



        [TestMethod]
        public void BrowserNavigationCommand()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/";

            driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            driver.FindElement(By.XPath("//input[@type = 'text']")).SendKeys("sheri1122");
            driver.FindElement(By.XPath("//input[@type = 'password']")).SendKeys("79OBXX");
            driver.FindElement(By.XPath("//input[@type = 'Submit']")).Click();
            Thread.Sleep(2000);
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
                Console.WriteLine("abled");

            }
            else if (elementState == "true")
            {
                elementState = "disabled";
                Console.WriteLine("disabled");
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
            driver.FindElement(By.Id("username")).SendKeys(Keys.Tab);
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




//Task02

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SELENIUM_DAY07_ASSIGNMENT08
{
    [TestClass]
    public class Task2
    {

        //GetElementValue


        [TestMethod]
        public void GetElementValue()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            driver.FindElement(By.Id("password")).SendKeys("AmirTester");
            driver.FindElement(By.Id("login")).Click();
            var element = driver.FindElement(By.Id("datepick_in"));
            element.GetAttribute("value");
            Thread.Sleep(5000);
            driver.Close();
        }


        //GetElementText

        [TestMethod]
        public void GetElementText()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://adactinhotelapp.com/";
        var element = driver.FindElement(By.XPath("//td[@class='login_title']"));
        element.GetAttribute("text");
        Thread.Sleep(5000);
        driver.Close();
    }


//        GetElementHTML

    [TestMethod]
    public void GetElementHTML()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://adactinhotelapp.com/";
        driver.FindElement(By.Id("username")).SendKeys("AmirTester");
        driver.FindElement(By.Id("password")).SendKeys("AmirTester");
        driver.FindElement(By.Id("login")).Click();
        var element = driver.FindElement(By.XPath("//span[@class='login_title_comm']"));
        element.GetAttribute("innerHTML");
        Thread.Sleep(5000);
        driver.Close();
    }
}
}




//Task03


using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SELENIUM_DAY07_ASSIGNMENT08
{
    [TestClass]
     public class Task3
    {
        [TestMethod]
        public void GetElementState()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            driver.FindElement(By.Id("username")).SendKeys("AmirTester");
            var element = driver.FindElement(By.Id("password"));
            //var element = driver.FindElement(By.Id("login"));
             //var element = driver.FindElement(By.Id(""));

             string elementState = element.GetAttribute("Disabled");

             if (elementState == null)
             {
                 elementState = "enabled";
             }
             else if (elementState == "true")
             {
                 elementState = "disabled";
             }
             Thread.Sleep(2000);
             Console.WriteLine(elementState);
             driver.Close();
        
        }
    }
}



//Task04

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SELENIUM_DAY07_ASSIGNMENT08
{
    [TestClass]
     public class Task4
    {

        //Scroll to element.

        [TestMethod]
        public void ScrollToElement()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(option);
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



//Task05

using Docker.DotNet.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELENIUM_DAY07_ASSIGNMENT08
{
    [TestClass]
    public class Task5
    {

        [TestMethod]

        public void ForCheckBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";
            driver.Manage().Window.Maximize();

            var click = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/form/div[3]/label[2]/input"));
                click.Click();

            if ( !click.Selected)
                {

                click.Click();
            }
            else
            {
                Console.WriteLine("Already Selected");
            }

        }    
    }
}
