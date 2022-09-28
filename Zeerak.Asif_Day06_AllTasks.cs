//Task02
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;

 namespace AssignmentDay06Selenium07
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ChromeBrowser()
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


        //For FireFox

        [TestMethod]
        public void FireFoxBrowser()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://demoqa.com/elements";
           Actions act = new Actions(driver);

            driver.FindElement(By.XPath("//*[@id=\"item-4\"]/span")).Click();
            //Right click on element

            driver.FindElement(By.XPath("//*[@id=\'rightClickBtn\']")).Click();
            WebElement ele = (WebElement)driver.FindElement(By.XPath("//*[@id=\'rightClickBtn\']"));
            act.ContextClick(ele).Perform();

        }

        //For Edge
        [TestMethod]
        public void EdgeeBrowser()
        {

            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://demoqa.com/elements";
            Actions act = new Actions(driver);

            driver.FindElement(By.XPath("//*[@id=\"item-4\"]/span")).Click();
            //Right click on element

            driver.FindElement(By.XPath("//*[@id=\'rightClickBtn\']")).Click();
            WebElement ele = (WebElement)driver.FindElement(By.XPath("//*[@id=\'rightClickBtn\']"));
            act.ContextClick(ele).Perform();

        }


    }
}


//Task03


using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

    namespace Task03_Day04_Selenium
{
    [TestClass]
    public class UnitTest1
    {

        //For Chrome Browser


        [TestMethod]
        public void Chrome()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.FullScreen();
            Thread.Sleep(1000);
            driver.FindElement(By.TagName("html")).SendKeys(Keys.Control + Keys.Subtract);
            driver.FindElement(By.XPath("//h5[contains(text(),'Forms')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]")).Click();
            driver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys("Zeerak");
            driver.FindElement(By.XPath("//input[@id='lastName']")).SendKeys("Asif");
            driver.FindElement(By.XPath("//*[@id='userEmail']")).SendKeys("mzeerak47@gmail.com");
            driver.FindElement(By.XPath("//label[contains(text(),'Male')]")).Click();
            driver.FindElement(By.XPath("//*[@id='userNumber']")).SendKeys("3081611668");

            driver.FindElement(By.Id("dateOfBirthInput")).Click();
            SelectElement dropdon1 = new SelectElement(driver.FindElement(By.ClassName("react-datepicker__month-select")));
            dropdon1.SelectByText("June");
            SelectElement dropdon2 = new SelectElement(driver.FindElement(By.ClassName("react-datepicker__year-select")));
            dropdon2.SelectByText("2000");
            driver.FindElement(By.XPath("//div[text()='12']")).Click();
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys("Maths");
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//label[text()='Sports']")).Click();
            driver.FindElement(By.XPath("//*[@id='currentAddress']")).SendKeys("usa CHICAGO" + Keys.Tab);
            driver.FindElement(By.XPath("//input[@id='react-select-3-input']")).SendKeys("NCR" + Keys.Tab);
            driver.FindElement(By.XPath("//input[@id='react-select-4-input']")).SendKeys("Delhi" + Keys.Tab);
            driver.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }


        //For FireFox Browser


        [TestMethod]
        public void FireFox()
        {

            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new FirefoxDriver();
            Actions actions = new Actions(driver);
            driver.Navigate().GoToUrl("https://demoqa.com/");
            
            Thread.Sleep(1000);
            driver.FindElement(By.TagName("html")).SendKeys(Keys.Control + Keys.Subtract);
            driver.FindElement(By.XPath("//h5[contains(text(),'Forms')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]")).Click();
            driver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys("Zeerak");
            driver.FindElement(By.XPath("//input[@id='lastName']")).SendKeys("Asif");
            driver.FindElement(By.XPath("//*[@id='userEmail']")).SendKeys("mzeerak47@gmail.com");
            driver.FindElement(By.XPath("//label[contains(text(),'Male')]")).Click();
            driver.FindElement(By.XPath("//*[@id='userNumber']")).SendKeys("3081611668");
            
            driver.FindElement(By.Id("dateOfBirthInput")).Click();
            SelectElement dropdon1 = new SelectElement(driver.FindElement(By.ClassName("react-datepicker__month-select")));
            dropdon1.SelectByText("June");
            SelectElement dropdon2 = new SelectElement(driver.FindElement(By.ClassName("react-datepicker__year-select")));
            dropdon2.SelectByText("2000");
            driver.FindElement(By.XPath("//div[text()='12']")).Click();
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys("Maths");
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//label[text()='Sports']")).Click();
            driver.FindElement(By.XPath("//*[@id='currentAddress']")).SendKeys("usa CHICAGO" + Keys.Tab);
            driver.FindElement(By.XPath("//input[@id='react-select-3-input']")).SendKeys("NCR" + Keys.Tab);
            driver.FindElement(By.XPath("//input[@id='react-select-4-input']")).SendKeys("Delhi" + Keys.Tab);
            driver.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }


        //Microsoft EDGE

        [TestMethod]
        public void MicrosoftEdge01()
        {

            EdgeOptions options = new EdgeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new EdgeDriver();
            Actions actions = new Actions(driver);
            driver.Navigate().GoToUrl("https://demoqa.com/");

            Thread.Sleep(1000);
            driver.FindElement(By.TagName("html")).SendKeys(Keys.Control + Keys.Subtract);
            driver.FindElement(By.XPath("//h5[contains(text(),'Forms')]")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]")).Click();
            driver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys("Zeerak");
            driver.FindElement(By.XPath("//input[@id='lastName']")).SendKeys("Asif");
            driver.FindElement(By.XPath("//*[@id='userEmail']")).SendKeys("mzeerak47@gmail.com");
            driver.FindElement(By.XPath("//label[contains(text(),'Male')]")).Click();
            driver.FindElement(By.XPath("//*[@id='userNumber']")).SendKeys("3081611668");

            driver.FindElement(By.Id("dateOfBirthInput")).Click();
            SelectElement dropdon1 = new SelectElement(driver.FindElement(By.ClassName("react-datepicker__month-select")));
            dropdon1.SelectByText("June");
            SelectElement dropdon2 = new SelectElement(driver.FindElement(By.ClassName("react-datepicker__year-select")));
            dropdon2.SelectByText("2000");
            driver.FindElement(By.XPath("//div[text()='12']")).Click();
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys("Maths");
            driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//label[text()='Sports']")).Click();
            driver.FindElement(By.XPath("//*[@id='currentAddress']")).SendKeys("usa CHICAGO" + Keys.Tab);
            driver.FindElement(By.XPath("//input[@id='react-select-3-input']")).SendKeys("NCR" + Keys.Tab);
            driver.FindElement(By.XPath("//input[@id='react-select-4-input']")).SendKeys("Delhi" + Keys.Tab);
            driver.FindElement(By.Id("submit")).SendKeys(Keys.Enter);
        }

     
    }
}




//Task04
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
//using OpenQA.Selenium.Edge;



namespace Task04
{
    [TestClass]
    public class UnitTest1
    {
        private int maximized;

        //For ChromeBrowser

        [TestMethod]
        public void Chrome()
        {

            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("start-maximized");
            // Options.AddArguments("headless");
            Options.AddArguments("incognito");


            IWebDriver driver = new ChromeDriver(Options);
            driver.Url = "https://fs2.formsite.com/meherpavan/form2/index.html?1537702596407";

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
            
            

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Chrome04th.png");
            Thread.Sleep(10000);
            driver.Close();
        }





        //For EdgeBrowser


        [TestMethod]
        public void EdgeBrowser()
        {

            EdgeOptions options1 = new EdgeOptions();
            options1.AddArguments("start-maximized");
            options1.AddArguments("headless");
            options1.AddArguments("Inprivate");

            IWebDriver driver = new EdgeDriver(options1);
            driver.Url = "https://fs2.formsite.com/meherpavan/form2/index.html?1537702596407";

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
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("EDGE04th.png");

            Thread.Sleep(10000);
            driver.Close();
        }



        //For FireFox Browser


        [TestMethod]
        public void FireFoxBrowser()
        {

            FirefoxOptions options11 = new FirefoxOptions();
            //options11.AddArguments("start-maximized");
            options11.AddArguments("-private");

            // options11.AddArguments("headless");


            IWebDriver driver = new FirefoxDriver(options11);
            driver.Url = "https://fs2.formsite.com/meherpavan/form2/index.html?1537702596407";



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
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("FireFox4th.png");

            Thread.Sleep(10000);
            driver.Close();
        }














        //Form two on different Browsers

        //On Chrome Browser

        [TestMethod]
        public void ChromeBrowser()
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
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Chrome04-02th.png");

            Thread.Sleep(1000);
            driver.Close();
        }


        //On FireFOx Browser

        [TestMethod]
        public void Firefox()
        {
            FirefoxOptions Options = new FirefoxOptions();
            //Options.AddArguments("headless");
            Options.AddArguments("new private window");
            

            IWebDriver driver = new FirefoxDriver(Options);
            driver.Url = "https://www.tutorialspoint.com/selenium/selenium_automation_practice.htm";
            driver.Manage().Window.Maximize();
           
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
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("FireFox04-02th.png");

            Thread.Sleep(1000);
            driver.Close();
        }



        //On Edge Browser

        [TestMethod]
        public void Edge()
        {
            EdgeOptions Options = new EdgeOptions();
            //Options.AddArguments("start-maximized");
            Options.AddArguments("disable-extensions"); 
            //Options.AddArguments("headless");
            //Options.AddArguments("incognito");
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
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("EDGE04-02th.png");

            Thread.Sleep(1000);
            driver.Close();
        }




        //Form three
        //For Chrome


        [TestMethod]
        public void ChromeFOr()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("disable-extensions");
            option.AddArguments("start-maximized");

            IWebDriver driver = new ChromeDriver(option);
            driver.Url = "https://www.techlistic.com/p/selenium-practice-form.html";
            Actions action = new Actions(driver);
            driver.FindElement(By.Name("firstname")).SendKeys("Zeerak");
            driver.FindElement(By.Name("lastname")).SendKeys("Asif");
            action.Click(driver.FindElement(By.XPath("//input[@value='Male']"))).Perform();
            action.Click(driver.FindElement(By.XPath("//input[@value='1']"))).Perform();
            driver.FindElement(By.Id("datepicker")).SendKeys("12/9/2005");
            action.Click(driver.FindElement(By.XPath("//input[@value='Automation Tester']"))).Perform();
            action.Click(driver.FindElement(By.XPath("//input[@value='Selenium Webdriver']"))).Perform();
            SelectElement continants = new SelectElement(driver.FindElement(By.Name("continents")));
            continants.SelectByText("Europe");
            driver.FindElement(By.Name("selenium_commands")).Click();
            SelectElement SeleniumCommands = new SelectElement(driver.FindElement(By.Name("selenium_commands")));
            continants.SelectByIndex(0);
            driver.FindElement(By.Name("submit")).Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Chrome04-03th.png");
        }

        //EDGE BROWSER

        [TestMethod]
        public void EdgeFor()
        {
            EdgeOptions optionn = new EdgeOptions();
            optionn.AddArguments("disable-extensions");
            optionn.AddArguments("start-maximized");


            IWebDriver driver = new EdgeDriver(optionn);
            driver.Url = "https://www.techlistic.com/p/selenium-practice-form.html";
            Actions action = new Actions(driver);
            driver.FindElement(By.Name("firstname")).SendKeys("Zeerak");
            driver.FindElement(By.Name("lastname")).SendKeys("Asif");
            action.Click(driver.FindElement(By.XPath("//input[@value='Male']"))).Perform();
            action.Click(driver.FindElement(By.XPath("//input[@value='1']"))).Perform();
            driver.FindElement(By.Id("datepicker")).SendKeys("12/9/2005");
            action.Click(driver.FindElement(By.XPath("//input[@value='Automation Tester']"))).Perform();
            action.Click(driver.FindElement(By.XPath("//input[@value='Selenium Webdriver']"))).Perform();
            SelectElement continants = new SelectElement(driver.FindElement(By.Name("continents")));
            continants.SelectByText("Europe");
            driver.FindElement(By.Name("selenium_commands")).Click();
            SelectElement SeleniumCommands = new SelectElement(driver.FindElement(By.Name("selenium_commands")));
            continants.SelectByIndex(0);
            driver.FindElement(By.Name("submit")).Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("FireFox04-02th.png");
        }

        //FIREFOX BROWSER

        [TestMethod]
        public void FireFoxFOr()
        {
            FirefoxOptions optionnn = new FirefoxOptions();
            // optionnn.AddArguments("disable-extensions");
            optionnn.AddArguments("start - maximized");


            IWebDriver driver = new FirefoxDriver(optionnn);
            driver.Url = "https://www.techlistic.com/p/selenium-practice-form.html";
            Actions action = new Actions(driver);
            driver.FindElement(By.Name("firstname")).SendKeys("Zeerak");
            driver.FindElement(By.Name("lastname")).SendKeys("Asif");
            action.Click(driver.FindElement(By.XPath("//input[@value='Male']"))).Perform();
            action.Click(driver.FindElement(By.XPath("//input[@value='1']"))).Perform();
            driver.FindElement(By.Id("datepicker")).SendKeys("12/9/2005");
            action.Click(driver.FindElement(By.XPath("//input[@value='Automation Tester']"))).Perform();
            action.Click(driver.FindElement(By.XPath("//input[@value='Selenium Webdriver']"))).Perform();
            SelectElement continants = new SelectElement(driver.FindElement(By.Name("continents")));
            continants.SelectByText("Europe");
            driver.FindElement(By.Name("selenium_commands")).Click();
            SelectElement SeleniumCommands = new SelectElement(driver.FindElement(By.Name("selenium_commands")));
            continants.SelectByIndex(0);
            driver.FindElement(By.Name("submit")).Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("FireFox04-03th.png");

        } 
    }
}