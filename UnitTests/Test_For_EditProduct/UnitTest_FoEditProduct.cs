using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTests.Test_For_EditProduct
{
    [TestClass]
    public class UnitTest_FoEditProduct
    {
        [TestMethod]
        public void Test_Method_For_EditProduct()
        {
            Test_Product test_product = new Test_Product(1, "Printer", "Computer Peripherals", "cs", "999");
            Assert.AreEqual(1, test_product.Id);
            Assert.AreEqual("Printer", test_product.Name);
            Assert.AreEqual("Computer Peripherals", test_product.Category);
            Assert.AreEqual("cs", test_product.Unit);
            Assert.AreEqual("999", test_product.Price);
        }
        public void ProductModel_Constructor_WithEmptyName_SetsEmpty()
        {
            var test_product = new Test_Product(1, string.Empty, "Периферия", "шт", "1500");
            Assert.AreEqual(string.Empty, test_product.Name);
        }
    }
}