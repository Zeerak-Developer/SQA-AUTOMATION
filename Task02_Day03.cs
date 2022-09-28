using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Task02_Day03_Selenium
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

        [DataTestMethod]
        [DataRow("fname", "lname")]
        [DataRow("MSTest", "Selenium")]

        [TestMethod]
        public void TestMethod1(string val1, string val2)
        {
            Console.WriteLine("Value1: " + val1);
            Console.WriteLine("Value2: " + val2);
        }

        //Data Driven Using XML File
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "file.xml", "Login", DataAccessMethod.Sequential)]
        public void VerifyLoginWithValidUserValidPass_XML()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
        }
        //Data Driven Using CSV File
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV","data#csv", "cfile.csv", DataAccessMethod.Sequential)]
        public void ValidateLoginWithValidUserValidPass_CSV()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
        }
    }
}