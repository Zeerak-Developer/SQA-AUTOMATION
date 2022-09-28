using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Windows.Forms;


namespace Day05SeleniumPart01
{
    [TestClass]
    public class UnitTest1
    {
        /*  [TestMethod]
          public void TestMethod1()
          {
              IWebDriver driver = new ChromeDriver();

              driver.Url = "https://demoqa.com/elements";


              //Text Box
              driver.FindElement(By.XPath("//*[@id=\'item-0\']/span")).Click();
              IWebElement username = driver.FindElement(By.Id("userName"));
              username.SendKeys("Zeerak Asif");
              IWebElement useremail = driver.FindElement(By.Id("userEmail"));
              useremail.SendKeys("mzeerak47@gmail.com");
              IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));
              currentAddress.SendKeys("Contour Lahore");
              IWebElement permanentAddress = driver.FindElement(By.Id("permanentAddress"));
              permanentAddress.SendKeys("Contour Lahore");
              driver.Manage().Window.Maximize();
              driver.FindElement(By.Id("submit")).Click();



          } 

          //Check Box
          [TestMethod]
          public void Test02()
          {
              IWebDriver driver = new ChromeDriver();
              driver.Url = "https://demoqa.com/elements";
              driver.Manage().Window.Maximize();


              driver.FindElement(By.XPath("//*[@id=\'item-1\']/span")).Click();
              driver.FindElement(By.XPath("//button[@type ='button' and @class ='rct-collapse rct-collapse-btn' ]")).Click();
              driver.FindElement(By.XPath("//*[@id=\"tree-node\"]/ol/li/ol/li[1]/span/button")).Click();
              driver.FindElement(By.XPath("//*[@id=\"tree-node\"]/ol/li/ol/li[2]/span/button")).Click();
              driver.FindElement(By.XPath("//*[@id=\"tree-node\"]/ol/li/ol/li[3]/span/button")).Click();

              driver.FindElement(By.XPath("//span[text()='Commands']")).Click();
              driver.FindElement(By.XPath("//span[@class = 'rct-title' and  text() = 'Word File.doc']")).Click();
              driver.FindElement(By.XPath("//span[text() = 'WorkSpace']")).Click();

          }


         //Radio Button
         [TestMethod]
         public void Test003()
         {


             IWebDriver driver = new ChromeDriver();
             driver.Url = "https://demoqa.com/elements";
             driver.Manage().Window.Maximize();

             driver.FindElement(By.XPath("//*[@id=\"item-2\"]/span")).Click();

             driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/div[3]/label")).Click();
             Thread.Sleep(1000);
             driver.FindElement(By.XPath("//label[@class = 'custom-control-label']")).Click();



         } 

         //Web Tables

         [TestMethod]
         public void Test03()
         {


             IWebDriver driver = new ChromeDriver();
             driver.Url = "https://demoqa.com/elements";
             driver.Manage().Window.Maximize();
             Thread.Sleep(1000);

             driver.FindElement(By.XPath("//*[@id=\'item-3\']/span")).Click();
             driver.Manage().Window.Maximize();
             Thread.Sleep(2000);

             //Add Record
             driver.FindElement(By.XPath("//*[@id=\'addNewRecordButton\']")).Click();
             driver.FindElement(By.XPath("//input[@class = ' mr-sm-2 form-control' and @id = 'firstName']")).SendKeys("Zeerak");
             driver.FindElement(By.XPath("//input[@class = ' mr-sm-2 form-control' and @id = 'lastName']")).SendKeys("Asif");
             driver.FindElement(By.XPath("//input[@class = 'mr-sm-2 form-control' ]")).SendKeys("mzeerak47@gmail.com");
             driver.FindElement(By.XPath("//input[@id = 'age']")).SendKeys("24");
             driver.FindElement(By.XPath("//input[@id = 'salary']")).SendKeys("120000");
             driver.FindElement(By.XPath("//input[@class= ' mr-sm-2 form-control' and @id = 'department']")).SendKeys("SQA");
             driver.FindElement(By.XPath("//button[@class= 'btn btn-primary' and @id = 'submit']")).Click();

             //Delete Record
             driver.FindElement(By.Id("delete-record-2")).Click();

         }




         //Buttons

         [TestMethod]
         public void Test04()
         {


             IWebDriver driver = new ChromeDriver();
             driver.Url = "https://demoqa.com/elements";
             //driver.Manage().Window.Maximize();


             driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[5]/span")).Click();

             //For Double CLick
             driver.FindElement(By.Id("//button[@id = 'doubleClickBtn']")).Click();

             Thread.Sleep(2000);
             Actions actions = new Actions(driver);
             actions.MoveToElement(driver.FindElement(By.Id("//button[@id = 'doubleClickBtn']")))
             .DoubleClick()
             .Build()
             .Perform();


             MessageBox.Show("DOuble CLick"); 
     }  


         //Right Click

         [TestMethod]
         public void RightClick()
         { 

         IWebDriver driver = new ChromeDriver();
             driver.Url = "https://demoqa.com/elements"; 
             Actions act = new Actions(driver);

             driver.FindElement(By.XPath("//*[@id=\"item-4\"]/span")).Click();
             //Right click on element

             driver.FindElement(By.XPath("//*[@id=\'rightClickBtn\']")).Click();
             WebElement ele = (WebElement)driver.FindElement(By.XPath("//*[@id=\'rightClickBtn\']"));
             act.ContextClick(ele).Perform();

         }

         //Double CLick

         [TestMethod]
         public void DoubleCLick()
         {
             IWebDriver driver = new ChromeDriver();
             driver.Url = "https://demoqa.com/elements";
             Actions act = new Actions(driver);

             driver.FindElement(By.XPath("//*[@id=\"item-4\"]/span")).Click();
             //Double click on element

            driver.FindElement(By.XPath("//*[@id='doubleClickBtn']")).Click();
             WebElement elem = (WebElement)driver.FindElement(By.XPath("//*[@id='doubleClickBtn']"));
             act.DoubleClick(elem).Perform();
         } */


        //Click on button "Click me"

        [TestMethod]
        public void CLickMe()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/elements";
            

            driver.FindElement(By.XPath("//*[@id=\"item-4\"]/span")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button")).Click();
      
        }
    }

}