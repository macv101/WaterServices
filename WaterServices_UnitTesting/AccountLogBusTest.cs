using WaterServices._Bus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace WaterServices_UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for AccountLogBusTest and is intended
    ///to contain all AccountLogBusTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountLogBusTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AccountLogBus Constructor
        ///</summary>
        [TestMethod()]
        public void AccountLogBusConstructorTest()
        {
            AccountLogBus target = new AccountLogBus();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getAccountLogs
        ///</summary>
        [TestMethod()]
        public void getAccountLogsTest()
        {
            AccountLogBus target = new AccountLogBus(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            DateTime from = DateTime.Today;
            DateTime to = DateTime.Today.AddDays(1);
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getAccountLogs(name, from, to);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
