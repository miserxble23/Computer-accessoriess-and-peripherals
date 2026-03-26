using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Card_Storekep_Test_Method()
        {
            Test_For_CardStorekep_Method newtestCard_Storekep = new Test_For_CardStorekep_Method("1", "Printer_3D", "Сomputer Peripherals", "10", "cs", "500$");
            Assert.AreEqual("1", newtestCard_Storekep.id);
            Assert.AreEqual("Printer_3D", newtestCard_Storekep.name);
            Assert.AreEqual("Сomputer Peripherals", newtestCard_Storekep.category);
            Assert.AreEqual("10", newtestCard_Storekep.stock);
            Assert.AreEqual("pcs", newtestCard_Storekep.unit);
            Assert.AreEqual("500$", newtestCard_Storekep.price);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Card_Storekep_Test_Method_Exception()
        {
            Test_For_CardStorekep_Method test_For_CardStorekep_Method = new Test_For_CardStorekep_Method(string.Empty, "Printer_3D", "Сomputer Peripherals", "-10", "pcs", "500$");
        }
    }
}
