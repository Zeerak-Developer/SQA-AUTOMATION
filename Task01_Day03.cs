using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace Day03_Selenium
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext instance;
        public TestContext TestContext
        {
            get { return instance; }
            set { instance = value; }
        }

        [AssemblyInitialize]
        //[TestMethod]
        public static void Assembly_Initialize_Method(TestContext context)
        {
            MessageBox.Show("Assembly Initialize Method");
        }

        [AssemblyCleanup]
        //[TestMethod]
        public static void Assembly_Cleanup_Method()
        {
            MessageBox.Show("Assembly Cleanup Method");
        }

        [ClassInitialize]
        //[TestMethod]
        public static void Class_Initialize_Method(TestContext context)
        {
            MessageBox.Show("Class Initialize Method");
        }

        [ClassCleanup]
        //[TestMethod]
        public static void Class_Cleanup_Method()
        {
            MessageBox.Show("Class Cleanup Method");
        }

        [TestInitialize]
       // [TestMethod]
        public void Test_Initialize_Method()
        {
            MessageBox.Show("Test Cleanup Method");
        }

        [TestCleanup]
       // [TestMethod]
        public void Test_Cleanup_Method()
        {
            MessageBox.Show("Test Cleanup Method");
        }
        [TestMethod]
        public void TestCase01()
        {
            MessageBox.Show("Done at the End");
        } 
    }
}
