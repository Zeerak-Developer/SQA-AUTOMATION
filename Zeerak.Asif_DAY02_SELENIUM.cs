using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExecutionScope = Microsoft.VisualStudio.TestTools.UnitTesting.ExecutionScope;

[assembly: Parallelize(Workers = 2, Scope = ExecutionScope.MethodLevel)]

[assembly: AssemblyTitle("Day02Selenium")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Day02Selenium")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("008badf8-92d7-44c1-9cea-dbb2fdb4b509")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]





using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day02Selenium
{
    [TestClass]
    public class UnitTest1
    {
        string name = "Zeerak Asif";
        [Owner("Zeerak")]
        [Description("Remove last name from given string and compare with expected,pass or fail")]
        [Timeout(200)]
        [Priority(1)]
        [DoNotParallelize]
        [TestMethod]
        public void testcase01_RemoveLastName()
        {
            string expected = "Zeerak";
            Assert.AreNotEqual(expected, name);
        }

        [Owner("Asif")]
        [Description("Remove last name from given string and compare with expected,pass or fail")]
        [Timeout(250)]
        [Priority(2)]
        [WorkItem(2)]
        [TestMethod]
        public void testcase02_RemoveFirstName()
        {
            string expected = "Asif";
            Assert.AreNotEqual(expected, name);
        }

        [Owner("Malik")]
        [Description("Remove last name from given string and compare with expected,pass or fail")]
        [Timeout(350)]
        [Priority(3)]
        [WorkItem(2)]
        [TestMethod]
        public void testcase03_Compare()
        {
            string expected = "Zeerak Asif";
            Assert.AreEqual(expected, name);
        }

        [TestCategory("Smoke")]
        [TestMethod]
        public void testcase04_login_working()
        {
            bool t = true;
            Assert.IsTrue(t);
        }
        [TestMethod]
        public void testcase05_login_not_working()
        {
            bool f = false;
            Assert.IsFalse(f);
        }

        [DataRow(8, 9)]
        [DataRow(15, 10)]
        [DataRow(10, 11)]
        [DataRow(11, 14)]
        [DataRow(12, 13)]
        [DataRow(22, 9)]
        [TestMethod]
        public void testcase06_add(int a, int b)
        {
            int expected = 25;
            int sum = a + b;
            Assert.AreEqual(expected, sum);
        }

        [DataRow(3, 4, 5)]
        [DataRow(3, 10, 2)]
        [DataRow(3, 11, 2)]
        [TestMethod]
        public void testcase07_Mul(int a, int b, int c)
        {
            int expected = 60;
            int Mul = a * b * c;
            Assert.AreEqual(expected, Mul);
        }

        [Owner("Asif")]
        [Description("Checking if null or not")]
        [TestCategory("Smoke")]
        [Priority(15)]
        [WorkItem(15)]
        [TestMethod]
        public void testcase08_Null()
        {
            Nullable<int> nom = null;
            Assert.IsNull(nom);
        }

        [TestMethod]
        public void testcase09_Is_Not_Empty()
        {
            string s = "";
            Assert.IsNotNull(s);
        }
        [TestClass]
        public class UnitTest2
        {
            [Owner("Zeerak")]
            [Description("Names same or not")]
            [TestCategory("Smoke")]
            [Priority(1)]
            [WorkItem(1)]
            [DataTestMethod]
            public void testcase10_Same_Functionality()
            {
                string name1 = "Malik";
                string name2 = "Malik";
                Assert.AreSame(name1, name2);
            }

            [Owner("Zeerak")]
            [Description("Names same or not")]
            [TestCategory("Smoke")]
            [Priority(1)]
            [WorkItem(1)]
            [DataTestMethod]
            public void testcase11_Not_Same_Functionality()
            {
                string name1 = "Malik";
                string name2 = "Malik";
                Assert.AreNotSame(name1, name2);
            }
        }
    }
}
