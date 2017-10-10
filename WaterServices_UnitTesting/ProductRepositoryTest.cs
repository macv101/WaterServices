using WaterServices._Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace WaterServices_UnitTesting
{
    
    
    /// <summary>
    ///This is a test class for ProductRepositoryTest and is intended
    ///to contain all ProductRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProductRepositoryTest
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
        ///A test for ProductRepository Constructor
        ///</summary>
        [TestMethod()]
        public void ProductRepositoryConstructorTest()
        {
            ProductRepository target = new ProductRepository();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getProductContainers
        ///</summary>
        [TestMethod()]
        public void getProductContainersTest()
        {
            ProductRepository target = new ProductRepository(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getProductContainers();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getProductType
        ///</summary>
        [TestMethod()]
        public void getProductTypeTest()
        {
            ProductRepository target = new ProductRepository(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getProductTypes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getProductVolume
        ///</summary>
        [TestMethod()]
        public void getProductVolumeTest()
        {
            ProductRepository target = new ProductRepository(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getProductVolumes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getProducts
        ///</summary>
        [TestMethod()]
        public void getProductsTest()
        {
            ProductRepository target = new ProductRepository(); // TODO: Initialize to an appropriate value
            string code = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.getProducts(code);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
