using WaterServices._Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace WaterServices_UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for ClientRepositoryTest and is intended
    ///to contain all ClientRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ClientRepositoryTest
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
        ///A test for ClientRepository Constructor
        ///</summary>
        [TestMethod()]
        public void ClientRepositoryConstructorTest()
        {
            ClientRepository target = new ClientRepository();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getClientAndLocationById
        ///</summary>
        [TestMethod()]
        public void getClientAndLocationByIdTest()
        {
            ClientRepository target = new ClientRepository(); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getClientAndLocationById(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getClientById
        ///</summary>
        [TestMethod()]
        public void getClientByIdTest()
        {
            ClientRepository target = new ClientRepository(); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getClientById(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getClients
        ///</summary>
        [TestMethod()]
        public void getClientsTest()
        {
            ClientRepository target = new ClientRepository(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getClients();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
